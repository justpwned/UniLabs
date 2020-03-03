using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4
{
	public partial class SourceForm : Form
	{
		class Event
		{
			public Action Methods { get; set; }
			public int NumMethods { get; set; }
		};

		private Dictionary<string, Event> events = new Dictionary<string, Event>();

		private List<ObserverForm> observers = new List<ObserverForm>();
		private int obsCount;

		private ToolTip tooltip = new ToolTip();

		public SourceForm()
		{
			InitializeComponent();

			AddEvent("A");
			AddEvent("B");
			AddEvent("C");
		}
		
		public void AddEvent(string eventName)
		{
			events.Add(eventName, new Event());
		}

		public void RemoveObserver(ObserverForm obsObj)
		{
			observers.Remove(obsObj);
			--obsCount;

			foreach (var e in events)
			{
				if (e.Value.Methods != null)
				{
					foreach (var method in e.Value.Methods.GetInvocationList())
					{
						if (method.Target == obsObj) this.UnRegister(e.Key, obsObj, (Action)method);
					}
				}
			}

			tooltip.SetToolTip(addObsBtn, GetObserversInfo());
			ShowInfo();
		}

		private void ShowInfo(string eventName = "")
		{
			eventALbl.Text = $"Подписчиков: {events["A"].NumMethods}";
			eventBLbl.Text = $"Подписчиков: {events["B"].NumMethods}";
			eventCLbl.Text = $"Подписчиков: {events["C"].NumMethods}";
			obsCountLbl.Text = $"Наблюдателей: {obsCount}";

			switch (eventName)
			{
				case "A": tooltip.SetToolTip(startEventABtn, GetEventInfo(eventName)); break;
				case "B": tooltip.SetToolTip(startEventBBtn, GetEventInfo(eventName)); break;
				case "C": tooltip.SetToolTip(startEventCBtn, GetEventInfo(eventName)); break;
			}

			tooltip.SetToolTip(addObsBtn, GetObserversInfo());
		}

		private void addObsBtn_Click(object sender, EventArgs e)
		{
			ObserverForm obsForm = new ObserverForm(this);
			observers.Add(obsForm);
			obsForm.Text = $"Наблюдатель №{++obsCount}";
			obsForm.Show();
			ShowInfo();
		}

		private void startEventABtn_Click(object sender, EventArgs e)
		{
			events["A"].Methods?.Invoke();
		}

		private void startEventBBtn_Click(object sender, EventArgs e)
		{
			events["B"].Methods?.Invoke();
		}

		private void startEventCBtn_Click(object sender, EventArgs e)
		{
			events["C"].Methods?.Invoke();
		}

		public void Register(string eventName, object subObj, Action method)
		{
			bool done = false;

			if (events.ContainsKey(eventName))
			{
				done = true;
				events[eventName].Methods += method;
				events[eventName].NumMethods++;
			}

			if (done)
			{
				MessageBox.Show($"Объкт {subObj} подписался на событие {eventName}");
				ShowInfo(eventName);
			}
		}

		public void UnRegister(string eventName, object subObj, Action method)
		{
			bool done = false;

			if (events.ContainsKey(eventName))
			{
				done = false;

				if (events[eventName].Methods != null)
				{
					foreach (var i in events[eventName].Methods.GetInvocationList())
					{
						if ((Delegate)method == i)
						{
							done = true;
							break;
						}
					}
				}
			}

			if (done)
			{
				events[eventName].Methods -= method;
				events[eventName].NumMethods--;
				MessageBox.Show($"Объкт {subObj} отписался от события {eventName}");
				ShowInfo(eventName);
			}
		}

		private string GetEventInfo(string eventName)
		{
			StringBuilder sb = new StringBuilder();

			Delegate[] invocationList = null;
			if (events.ContainsKey(eventName))
			{
				invocationList = events[eventName].Methods?.GetInvocationList();
			}

			if (invocationList != null)
			{
				foreach (var method in invocationList)
				{
					sb.AppendLine($"{(method.Target as Form).Text} - {method.Method}");
				}
			}

			return sb.ToString();
		}

		private string GetObserversInfo()
		{
			StringBuilder sb = new StringBuilder();

			foreach (var obs in observers)
			{
				sb.Append(obs.Text + " - ");

				int subCount = 0;

				foreach (var e in events)
				{
					if (e.Value.Methods != null)
					{
						foreach (var method in e.Value.Methods.GetInvocationList())
						{
							if (method.Target as ObserverForm == obs) ++subCount;
						}
					}
				}

				sb.AppendLine(subCount.ToString());
			}

			return sb.ToString();
		}
	}
}