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
	public partial class NewSubForm : Form
	{
		PublisherForm parent { get; }

		public NewSubForm(PublisherForm parent)
		{
			InitializeComponent();
			this.parent = parent;
		}

		private void regSubButton_Click(object sender, EventArgs e)
		{
			string name = subNameTextBox.Text.Trim();
			parent.AddNewSubscriberByName(name);
			this.Close();
		}

		private void subNameTextBox_TextChanged(object sender, EventArgs e)
		{
			if (subNameTextBox.Text.Trim() == "")
			{
				regSubButton.Enabled = false;
			}
			else
			{
				regSubButton.Enabled = true;
			}
		}

		private void NewSubForm_Load(object sender, EventArgs e)
		{
			this.ActiveControl = subNameTextBox;
		}
	}
}
