using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Drawing.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lab2;

namespace Lab2GUI
{
	public partial class MainForm : Form
	{
		private List<Figure> figures = new List<Figure>();
		private Canvas canvas;
		private Random rnd = new Random();

		public MainForm()
		{
			InitializeComponent();
		}

		private void numObjTextBox_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == (char)Keys.Back) return;

			if (!char.IsDigit(e.KeyChar) || numObjTextBox.Text == "" && e.KeyChar == '0')
			{
				e.Handled = true;
			}
		}

		private void numObjTextBox_TextChanged(object sender, EventArgs e)
		{
			if(int.TryParse(numObjTextBox.Text, out int num))
			{
				if (num != 0)
				{
					createObjButton.Enabled = true;
				}
				return;
			}

			createObjButton.Enabled = false;
		}

		private void createObjButton_Click(object sender, EventArgs e)
		{
			int numFigures = int.Parse(numObjTextBox.Text);
			
			if (numFigures > 254)
			{
				MessageBox.Show("Невозможно создать больше, чем 254 объектов!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			else
			{
				canvas.BeginPaint();
				canvas.DrawCoordinateSystem(canvas.Width / 2, canvas.Height / 2, 20, 5);

				figures.Clear();
				for (int i = 0; i < numFigures; ++i)
				{
					switch (rnd.Next(2))
					{
						case 0: figures.Add(new Lab2.Point()); break;
						case 1: figures.Add(new Circle()); break;
						//case 2: figures.Add(new Square()); break;
					}
					objListBox.Items.Add(string.Format("{0,3} {1} ", i + 1, figures[i]));
					canvas.DrawFigure(figures[i], canvas.Width / 2, canvas.Height / 2, (i + 1).ToString());
				}

				canvas.EndPaint();

				StringBuilder outerEqualSb = new StringBuilder();
				StringBuilder innerEqualSb = new StringBuilder();

				StringBuilder outerCrossSb = new StringBuilder();
				StringBuilder innerCrossSb = new StringBuilder();

				innerEqualSb.Append("Equal  ");
				innerCrossSb.Append("Cross  ");
				for (int i = 0; i < figures.Count; ++i)
				{
					innerEqualSb.Append($"{i + 1, 3} ");
					innerCrossSb.Append($"{i + 1,3} ");
				}
				outerEqualSb.AppendLine(innerEqualSb.ToString());
				outerCrossSb.AppendLine(innerCrossSb.ToString());

				for (int i = 0; i < figures.Count; ++i)
				{
					innerEqualSb.Clear();
					innerCrossSb.Clear();
					innerEqualSb.Append($"{i + 1,6} ");
					innerCrossSb.Append($"{i + 1,6} ");
					for (int j = 0; j < figures.Count; ++j)
					{
						innerEqualSb.Append($"{(figures[i].Equal(figures[j]) ? "T" : "F"),3} ");
						innerCrossSb.Append($"{(figures[i].Crossing(figures[j]) ? "T" : "F"), 3} ");
					}
					outerEqualSb.AppendLine(innerEqualSb.ToString());
					outerCrossSb.AppendLine(innerCrossSb.ToString());
				}

				equalTextBox.Text = outerEqualSb.ToString();
				crossingTextBox.Text = outerCrossSb.ToString();
			}
		}

		private void MainForm_Load(object sender, EventArgs e)
		{
			canvas = new Canvas(graphPictureBox);
		}
	}
}
