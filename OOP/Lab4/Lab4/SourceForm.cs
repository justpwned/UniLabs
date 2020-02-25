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

		public SourceForm()
		{
			InitializeComponent();
		}

		private void ShowInfo()
		{
			eventALbl.Text = $"Подписчиков: {countA}";
			eventBLbl.Text = $"Подписчиков: {countB}";
			eventCLbl.Text = $"Подписчиков: {countC}";
			obsCountLbl.Text = $"Наблюдателей: {obsCount}";
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
				ShowInfo();

				Delegate[] actions = EventA.GetInvocationList();
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
				ShowInfo();
			}
		}

		private string GetEventInfo(string eventName)
		{
			//switch (eventName.ToLower())
			//{

			//}
			
			return "test";
		}

		private void SourceForm_Load(object sender, EventArgs e)
		{
			

			ToolTip tooltip = new ToolTip();
			tooltip.SetToolTip(startEventABtn, GetEventInfo("A"));
			tooltip.SetToolTip(startEventBBtn, GetEventInfo("B"));
			tooltip.SetToolTip(startEventCBtn, GetEventInfo("C"));
		}
	}
}