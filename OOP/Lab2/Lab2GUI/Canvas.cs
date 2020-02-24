using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
using System.Drawing;
using Lab2;

namespace Lab2GUI
{
	class Canvas
	{
		public PictureBox Pb { get; }

		public int Width { get { return Pb.Width; } }
		public int Height { get { return Pb.Height; } }

		private Bitmap bitmap;

		public Canvas(PictureBox pb)
		{
			Pb = pb;
		}

		public void BeginPaint()
		{
			bitmap = new Bitmap(Width, Height);
		}

		public void EndPaint()
		{
			Pb.Image = bitmap;
		}

		public void DrawFigure(Figure f, int offsetX, int offsetY, int scale = 1, string label = "")
		{
			Graphics g = Graphics.FromImage(bitmap);

			Font font = new Font(FontFamily.GenericMonospace, 10);

			int x = offsetX + (int)(f.X * scale);
			int y = offsetY - (int)(f.Y * scale);

			if (f is Lab2.Point)
			{
				int pointSize = 8;
				Rectangle rect = new Rectangle(x - pointSize / 2, y - pointSize / 2, pointSize, pointSize);
				g.FillEllipse(Brushes.Green, rect);

				if (label != "")
				{
					g.DrawString(label, font, Brushes.Black, x + pointSize / 2, y - pointSize / 2 - font.Height);
				}
			}
			else if (f is Circle)
			{
				Circle circle = f as Circle;
				double r = circle.R * scale;
				Rectangle rect = new Rectangle(x - (int)r, y - (int)r, (int)(2 * r), (int)(2 * r));
				g.DrawEllipse(Pens.Red, rect);

				double labelMargin = Math.Sin(180 / Math.PI * 45) * r;
				if (label != "")
				{
					g.DrawString(label, font, Brushes.Black, (int)(x + labelMargin), (int)(y - labelMargin - font.Height / 2));
				}
			}
			else if (f is Square)
			{
				Square square = f as Square;
				double a = square.A * scale;
				Rectangle rect = new Rectangle(x - (int)(a / 2), y - (int)(a / 2), (int)a, (int)a);
				g.DrawRectangle(Pens.Blue, rect);

				if (label != "")
				{
					g.DrawString(label, font, Brushes.Black, x + (int)(a / 2), y - (int)(a / 2) - font.Height);
				}
			}
		}

		public void DrawCoordinateSystem(int centerX, int centerY, int spacingLength, int spacingHeight)
		{
			if (centerX < 0 || centerX > Width)
			{
				throw new Exception("centerX can not be neither less than zero nor more than width of PictureBox");
			}

			if (centerY < 0 || centerY > Height)
			{
				throw new Exception("centerY can not be neither less than zero nor more than height of PictureBox");
			}

			int pw = Pb.Width;
			int ph = Pb.Height;

			Graphics g = Graphics.FromImage(bitmap);

			// X-axis
			float posX, negX;
			float posY = centerY - spacingHeight / 2;
			float negY = centerY + spacingHeight / 2;
			g.DrawLine(Pens.Black, 0, centerY, pw, centerY);
			for (int i = 1; i <= (Width - centerX) / spacingLength; ++i)
			{
				posX = centerX + i * spacingLength;
				g.DrawLine(Pens.Black, posX, posY, posX, negY);
			}
			for (int i = 1; i <= centerX / spacingLength; ++i)
			{
				negX = centerX - i * spacingLength;
				g.DrawLine(Pens.Black, negX, posY, negX, negY);
			}

			// Y-axis
			posX = centerX + spacingHeight / 2;
			negX = centerX - spacingHeight / 2;
			g.DrawLine(Pens.Black, centerX, 0, centerX, ph);
			for (int i = 1; i <= (Height - centerY) / spacingLength; ++i)
			{
				posY = centerY + i * spacingLength;
				g.DrawLine(Pens.Black, negX, posY, posX, posY);
			}
			for (int i = 1; i <= centerY / spacingLength; ++i)
			{
				negY = centerY - i * spacingLength;
				g.DrawLine(Pens.Black, negX, negY, posX, negY);
			}
		}
	}
}
