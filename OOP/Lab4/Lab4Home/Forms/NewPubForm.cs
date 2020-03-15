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
	public partial class NewPubForm : Form
	{
		private PublisherForm parent { get; }

		public NewPubForm(PublisherForm parent)
		{
			InitializeComponent();
			this.parent = parent;
		}

		private void publishButton_Click(object sender, EventArgs e)
		{
			string pubname = pubNameTextBox.Text.Trim();
			if (!parent.ContainsPublication(pubname))
			{
				Publication pub = null;
				if (magazineRadioButton.Checked)
				{
					pub = new Magazine(pubname);
				}
				else
				{
					pub = new Newspaper(pubname);
				}
				parent.AddNewPublication(pub);
				this.Close();
			}
			else
			{
				MessageBox.Show($"Название «{pubname}» не уникально!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
		}

		private void NewPubForm_Load(object sender, EventArgs e)
		{
			this.ActiveControl = pubNameTextBox;
			newsRadioButton.Checked = true;
		}
	}
}
