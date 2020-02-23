using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
	public abstract class Figure
	{
		private double _x;
		public double X
		{
			get => _x;
			set
			{
				if (Math.Abs(value) <= 8) _x = value;
			}
		}

		private double _y;
		public double Y
		{
			get => _y;
			set
			{
				if (Math.Abs(value) <= 8) _y = value;
			}
		}

		public Figure() { }

		public Figure(double x, double y)
		{
			X = x;
			Y = y;
		}

		public abstract double S { get; set; }

		public void MoveTo(double x, double y)
		{
			X = x;
			Y = y;
		}

		public void MoveRel(double dx, double dy)
		{
			X += dx;
			Y += dy;
		}

		public abstract bool Equal(Figure other);
		public abstract bool Crossing(Figure other);
		public abstract bool ZeroIn();
		public abstract override string ToString();
	}
}
