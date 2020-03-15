using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4Home
{
	public partial class SubscriberForm : Form
	{
		public new PublisherForm ParentForm { get; }
		private ToolTip tooltip = new ToolTip();

		private Subscriber subObj;

		public SubscriberForm(PublisherForm parent, Subscriber subObj)
		{
			InitializeComponent();
			ParentForm = parent;
			this.subObj = subObj;
		}

		public void RefreshTooltip()
		{
			StringBuilder sb = new StringBuilder();
			foreach (var sub in subObj.Subscriptions)
			{
				sb.AppendLine(sub.ToString());
			}
			tooltip.SetToolTip(this, sb.ToString());
		}

		private void SubscriberForm_Load(object sender, EventArgs e)
		{
			this.Text = $"Подписчик: {subObj.Name}";
			availablePubsListBox.DataSource = ParentForm.PublicationsList;
		}

		private void SubscriberForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			EventSystem.RemoveObserver(this);
			for (int i = 0; i < subObj.Subscriptions.Count; ++i)
			{
				subObj.UnsubsribeFrom(subObj.Subscriptions[i], true);
			}
			ParentForm.SubscribersList.Remove(subObj);
		}

		public void Log(string message)
		{
			logsTextBox.AppendText($"{PublisherForm.StringDate} {message}{Environment.NewLine}");
		}

		public void RefreshPubList()
		{
			availablePubsListBox.DataSource = null;
			availablePubsListBox.DataSource = ParentForm.PublicationsList;
		}

		private void availablePubsListBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			ListBox lb = sender as ListBox;
			if (lb.SelectedIndex != -1)
			{
				Publication pub = lb.Items[lb.SelectedIndex] as Publication;
				subButton.Enabled = true;
				unsubButton.Enabled = true;
			}
			else
			{
				subButton.Enabled = false;
				unsubButton.Enabled = false;
			}
		}

		private void subButton_Click(object sender, EventArgs e)
		{
			subObj.SubscribeTo(availablePubsListBox.SelectedItem as Publication);
		}

		private void unsubButton_Click(object sender, EventArgs e)
		{
			subObj.UnsubsribeFrom(availablePubsListBox.SelectedItem as Publication);
		}
	}
}
