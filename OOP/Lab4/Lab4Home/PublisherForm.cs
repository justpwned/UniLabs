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
		public List<Publication> publications { get; } = new List<Publication>();

		public PublisherForm()
		{
			InitializeComponent();
		}

		public void AddNewPublication(Publication pub)
		{
			publications.Add(pub);
		}

		public bool ContainsPublication(string pubName)
		{
			foreach (var p in publications)
			{
				if (p.Name == pubName)
				{
					return true;
				}
			}
			return false;
		}

		private void openPub_Click(object sender, EventArgs e)
		{
			NewPubForm pubForm = new NewPubForm();
			pubForm.ShowDialog();
		}

		private void PublisherForm_Load(object sender, EventArgs e)
		{
			pubListBox.DataSource = publications;
		}
	}
}
