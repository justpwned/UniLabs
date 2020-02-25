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
		public Action EventA;
		private int countA;

		public Action EventB;
		private int countB;

		public Action EventC;
		private int countC;

		private List<ObserverForm> observers = new List<ObserverForm>();
		private int obsCount;

		public void RemoveObserver(ObserverForm obsObj)
		{
			observers.Remove(obsObj);
			--obsCount;

			if (EventA != null)
			{
				foreach (var method in EventA.GetInvocationList())
				{
					if (method.Target == obsObj) this.UnRegister("a", obsObj, (Action)method);
				}
			}

			if (EventB != null)
			{
				foreach (var method in EventB.GetInvocationList())
				{
					if (method.Target == obsObj) this.UnRegister("b", obsObj, (Action)method);
				}
			}

			if (EventC != null)
			{
				foreach (var method in EventC.GetInvocationList())
				{
					if (method.Target == obsObj) this.UnRegister("c", obsObj, (Action)method);
				}
			}

			tooltip.SetToolTip(addObsBtn, GetObserversInfo());
		}

		private ToolTip tooltip = new ToolTip();

		public SourceForm()
		{
			InitializeComponent();
		}

		private void ShowInfo(string eventName = "")
		{
			eventALbl.Text = $"Подписчиков: {countA}";
			eventBLbl.Text = $"Подписчиков: {countB}";
			eventCLbl.Text = $"Подписчиков: {countC}";
			obsCountLbl.Text = $"Наблюдателей: {obsCount}";

			switch (eventName.ToLower())
			{
				case "a": tooltip.SetToolTip(startEventABtn, GetEventInfo(eventName)); break;
				case "b": tooltip.SetToolTip(startEventBBtn, GetEventInfo(eventName)); break;
				case "c": tooltip.SetToolTip(startEventCBtn, GetEventInfo(eventName)); break;
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
			EventA?.Invoke();
		}

		private void startEventBBtn_Click(object sender, EventArgs e)
		{
			EventB?.Invoke();
		}

		private void startEventCBtn_Click(object sender, EventArgs e)
		{
			EventC?.Invoke();
		}

		public void Register(string eventName, object subObj, Action method)
		{
			bool done = false;
			switch (eventName.ToLower())
			{
				case "a": EventA += method; ++countA; done = true; break;
				case "b": EventB += method; ++countB; done = true; break;
				case "c": EventC += method; ++countC; done = true; break;
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
			switch (eventName.ToLower())
			{
				case "a": EventA -= method; --countA; done = true; break;
				case "b": EventB -= method; --countB; done = true; break;
				case "c": EventC -= method; --countC; done = true; break;
			}

			if (done)
			{
				MessageBox.Show($"Объкт {subObj} отписался от события {eventName}");
				ShowInfo(eventName);
			}
		}

		private string GetEventInfo(string eventName)
		{
			StringBuilder sb = new StringBuilder();

			Delegate[] invocationList = null;
			switch (eventName.ToLower())
			{
				case "a": invocationList = EventA?.GetInvocationList(); break;
				case "b": invocationList = EventB?.GetInvocationList(); break;
				case "c": invocationList = EventC?.GetInvocationList(); break;
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

				if (EventA != null)
				{
					foreach (var method in EventA.GetInvocationList())
					{
						if (method.Target as ObserverForm == obs) ++subCount;
					}
				}

				if (EventB != null)
				{
					foreach (var method in EventB.GetInvocationList())
					{
						if (method.Target as ObserverForm == obs) ++subCount;
					}
				}

				if (EventC != null)
				{
					foreach (var method in EventC.GetInvocationList())
					{
						if (method.Target as ObserverForm == obs) ++subCount;
					}
				}

				sb.AppendLine(subCount.ToString());
			}

			return sb.ToString();
		}
	}
}