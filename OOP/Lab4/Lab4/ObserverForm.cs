using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4
{
	public partial class ObserverForm : Form
	{
		private SourceForm srcForm;

		public ObserverForm(SourceForm srcForm)
		{
			InitializeComponent();
			this.srcForm = srcForm;
		}

		public void Action1()
		{
			Color c = BackColor;
			BackColor = Color.Red;
			Refresh();
			Thread.Sleep(1000);
			BackColor = c;
			Refresh();
			Thread.Sleep(500);
		}

		public void Action2()
		{
			Left -= 20;
		}

		public void Action3()
		{
			string t = Text;
			Text = "";
			Refresh();
			Thread.Sleep(5000);
			Text = t;
			Refresh();
			Thread.Sleep(500);
		}

		public void Action4()
		{
			Visible = false;
			Thread.Sleep(1000);
			Visible = true;
		}

		private void subBtn_Click(object sender, EventArgs e)
		{
			string eventName = "A";
			if (eventBRadioBtn.Checked) eventName = "B";
			else if (eventCRadioBtn.Checked) eventName = "C";

			Action action = null;
			switch (eventListBox.SelectedIndex)
			{
				case 0: action = Action1; break;
				case 1: action = Action2; break;
				case 2: action = Action3; break;
				case 3: action = Action4; break;
			}

			if (action != null) srcForm.Register(eventName, this, action);
		}

		private void unsubBtn_Click(object sender, EventArgs e)
		{
			string eventName = "A";
			if (eventBRadioBtn.Checked) eventName = "B";
			else if (eventCRadioBtn.Checked) eventName = "C";

			Action action = null;
			switch (eventListBox.SelectedIndex)
			{
				case 0: action = Action1; break;
				case 1: action = Action2; break;
				case 2: action = Action3; break;
				case 3: action = Action4; break;
			}

			if (action != null) srcForm.UnRegister(eventName, this, action);
		}

		private void ObserverForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			srcForm.RemoveObserver(this);
		}
	}
}
