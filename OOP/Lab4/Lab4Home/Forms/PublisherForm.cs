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
	public partial class PublisherForm : Form
	{
		public static DateTime gDateTime;
		public static string StringDate { get => $"{gDateTime.Day}.{gDateTime.Month}.{gDateTime.Year}"; }

		public ListBox.ObjectCollection PublicationsList{ get => pubListBox.Items; }
		public ListBox.ObjectCollection SubscribersList { get => subListBox.Items; }

		private Forms.InfoForm infoForm;

		private ToolTip tooltip = new ToolTip();

		public PublisherForm()
		{
			InitializeComponent();
		}

		private void RefreshTooltip()
		{
			StringBuilder sb = new StringBuilder();
			foreach (Publication pub in PublicationsList)
			{
				if (pub.IsPublishing)
				{
					sb.AppendLine(pub.ToString());
				}
			}
			tooltip.SetToolTip(this, sb.ToString());
		}

		public void AddNewPublication(Publication pub)
		{
			pubListBox.Items.Add(pub);
			EventSystem.AddEvent(pub.Name);
			RefreshTooltip();
			RefreshSubPubList();
		}

		public void RefreshSubPubList()
		{
			foreach (Subscriber sub in SubscribersList)
			{
				sub.Form.RefreshPubList();
			}
		}

		public void AddNewSubscriberByName(string name)
		{
			Subscriber sub = new Subscriber(name, this);
			subListBox.Items.Add(sub);
			sub.ShowForm();
		}

		public bool ContainsPublication(string pubName)
		{
			foreach (var p in pubListBox.Items)
			{
				if ((p as Publication).Name == pubName)
				{
					return true;
				}
			}
			return false;
		}

		private void openPub_Click(object sender, EventArgs e)
		{
			NewPubForm pubForm = new NewPubForm(this);
			pubForm.ShowDialog();
		}

		private void pubListBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			ListBox lb = sender as ListBox;
			if (lb.SelectedIndex != -1)
			{
				Publication pub = lb.Items[lb.SelectedIndex] as Publication;
				stopStartPubButton.Enabled = true;
				closePubButton.Enabled = true;
				if (pub.IsPublishing)
				{
					stopStartPubButton.Text = "Приостановить издание";
				}
				else
				{
					stopStartPubButton.Text = "Восстановить издание";
				}

				if (subListBox.SelectedIndex != -1)
				{
					subButton.Enabled = true;
					unsubButton.Enabled = true;
				}
				else
				{
					subButton.Enabled = false;
					unsubButton.Enabled = false;
				}
			}
			else
			{
				stopStartPubButton.Enabled = false;
				closePubButton.Enabled = false;
				subButton.Enabled = false;
				unsubButton.Enabled = false;
			}
		}

		private void closePubButton_Click(object sender, EventArgs e)
		{
			Publication pub = pubListBox.SelectedItem as Publication;
			EventSystem.DeleteEvent(pub.Name);
			pubListBox.Items.Remove(pub);
			RefreshTooltip();

			foreach (Subscriber sub in SubscribersList)
			{
				sub.UnsubsribeFrom(pub, true);
				sub.Form.RefreshPubList();
			}
		}

		private void stopStartPubButton_Click(object sender, EventArgs e)
		{
			Publication pub = pubListBox.SelectedItem as Publication;
			pub.IsPublishing = !pub.IsPublishing;
			if (pub.IsPublishing)
			{
				stopStartPubButton.Text = "Приостановить издание";
				pub.NextPublishDate = gDateTime;
			}
			else
			{
				stopStartPubButton.Text = "Восстановить издание";
			}
			RefreshTooltip();
		}

		private void regSubButton_Click(object sender, EventArgs e)
		{
			NewSubForm newSubForm = new NewSubForm(this);
			newSubForm.ShowDialog();
		}

		private void subListBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			ListBox lb = sender as ListBox;
			if (lb.SelectedIndex != -1)
			{
				if (pubListBox.SelectedIndex != -1)
				{
					subButton.Enabled = true;
					unsubButton.Enabled = true;
				}
				else
				{
					subButton.Enabled = false;
					unsubButton.Enabled = false;
				}
			}
			else
			{
				subButton.Enabled = false;
				unsubButton.Enabled = false;
			}
		}

		private void subButton_Click(object sender, EventArgs e)
		{
			Subscriber sub = subListBox.SelectedItem as Subscriber;
			Publication pub = pubListBox.SelectedItem as Publication;
			sub.SubscribeTo(pub);
		}

		private void unsubButton_Click(object sender, EventArgs e)
		{
			Subscriber sub = subListBox.SelectedItem as Subscriber;
			Publication pub = pubListBox.SelectedItem as Publication;
			sub.UnsubsribeFrom(pub);
		}

		private void dayTimer_Tick(object sender, EventArgs e)
		{
			infoForm.RefreshInfo();
			foreach (Publication pub in pubListBox.Items)
			{
				if (pub.IsPublishing && pub.IsTimeToPublish(gDateTime))
				{
					EventSystem.TriggerEvent(pub.Name, pub);

					int subs = EventSystem.GetNumberOfSubs(pub.Name);
					if (pub is Newspaper)
					{
						Log($"Выпуск газеты «{pub.Name}» №{pub.Num}. Получили {subs} подписчиков.");
					}
					else if (pub is Magazine)
					{
						Log($"Выпуск журнала «{pub.Name}» №{pub.Num}. Получили {subs} подписчиков.");
					}

					++pub.Num;
					pub.SetNextPublishDate();
				}
			}

			gDateTime = gDateTime.AddDays(1);
		}

		public void Log(string message)
		{
			logsTextBox.AppendText($"{PublisherForm.StringDate} {message}{Environment.NewLine}");
		}

		private void PublisherForm_Load(object sender, EventArgs e)
		{
			gDateTime = DateTime.Now;
			infoForm = new Forms.InfoForm(this);
		}

		private void PublisherForm_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				if (infoForm.IsDisposed)
				{
					infoForm = new Forms.InfoForm(this);
				}

				infoForm.Show();
				infoForm.RefreshInfo();
			}
		}
	}
}
