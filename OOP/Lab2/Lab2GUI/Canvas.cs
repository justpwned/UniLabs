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

		public void DrawFigure(Figure f, int offsetX, int offsetY, string label = "")
		{
			Graphics g = Graphics.FromImage(bitmap);
			if (f is Lab2.Point)
			{

			}
			else if (f is Circle)
			{

			}
			else if (f is Square)
			{

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
			posY = centerY - spacingHeight / 2;
			negY = centerY + spacingHeight / 2;
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
			posX = centerX + spacingHeight / 2;
			negX = centerX - spacingHeight / 2;
			for (int i = 1; i <= centerY / spacingLength; ++i)
			{
				negY = centerY - i * spacingLength;
				g.DrawLine(Pens.Black, negX, negY, posX, negY);
			}
		}
	}
}
