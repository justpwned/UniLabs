using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4Home.Forms
{
	public partial class InfoForm : Form
	{
		private new PublisherForm ParentForm;

		public InfoForm(PublisherForm parent)
		{
			InitializeComponent();
			ParentForm = parent;
		}

		public void RefreshInfo()
		{
			int selectedIndex = pubListBox.SelectedIndex;
			dateLabel.Text = PublisherForm.StringDate;
			pubListBox.DataSource = null;
			pubListBox.DataSource = ParentForm.PublicationsList;

			if (selectedIndex >= pubListBox.Items.Count)
			{
				selectedIndex = pubListBox.Items.Count - 1;
			}

			pubListBox.SelectedIndex = selectedIndex;

			if (pubListBox.SelectedIndex != -1)
			{
				Publication pub = pubListBox.SelectedItem as Publication;

				numLabel.Text = pub.Num.ToString();
				statusLabel.Text = pub.IsPublishing ? "Публикуется" : "Не публикуется";
				inceptionDateLabel.Text = $"{pub.InceptionDate.Day}.{pub.InceptionDate.Month}.{pub.InceptionDate.Year}";
				pubTypeLabel.Text = pub is Newspaper ? "Газета" : "Журнал";
				subListBox.DataSource = null;
				subListBox.DataSource = pub.Subscribers;
			}
			else
			{
				subListBox.DataSource = null;
				numLabel.Text = "";
				statusLabel.Text = "";
				inceptionDateLabel.Text = "";
				pubTypeLabel.Text = "";
			}
		}

		private void InfoForm_Load(object sender, EventArgs e)
		{
			pubListBox.DataSource = ParentForm.PublicationsList;
			RefreshInfo();
		}

		private void pubListBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			RefreshInfo();
		}
	}
}
