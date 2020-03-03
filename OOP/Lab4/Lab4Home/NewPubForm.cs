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
		public NewPubForm()
		{
			InitializeComponent();
		}

		private void publishButton_Click(object sender, EventArgs e)
		{
			string pubname = pubNameTextBox.Text.Trim();
			if (!(Parent as PublisherForm).ContainsPublication(pubname))
			{
				Publication pub = null;
				if (magazineRadioButton.Checked)
				{
					pub = new Magazine(1, pubname);
				}
				else
				{
					pub = new Newspaper(1, pubname);
				}
				(Parent as PublisherForm).AddNewPublication(pub);
			}
			else
			{
				MessageBox.Show($"Название «{pubname}» не уникально!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
		}
	}
}
