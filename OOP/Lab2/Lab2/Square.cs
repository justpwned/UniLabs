using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
	public class Square : Figure
	{
		private double _a = 1;
		public double A
		{
			get => _a;
			set
			{
				if (value * value <= 100) _a = value;
			}
		}

		public override double S
		{
			get => A * A;
			set
			{
				if (value <= 100) A = Math.Sqrt(value);
			}
		}

		public Square() { }

		public Square(double x, double y, double a = 2) : base(x, y)
		{
			A = a;
		}

		public override bool Crossing(Figure other)
		{
			if (other is Point)
			{
				double halfA = A / 2;
				return X - halfA <= other.X && X + halfA >= other.X && 
					   Y - halfA <= other.Y && Y + halfA >= other.Y;
			}
			else if (other is Circle)
			{
				Circle o = other as Circle;
				double dx = o.X - Math.Max(X - A / 2, Math.Min(o.X, X + A / 2));
				double dy = o.Y - Math.Max(Y - A / 2, Math.Min(o.Y, Y + A / 2));
				return (dx * dx + dy * dy) <= (o.R * o.R);
			}
			else if (other is Square)
			{
				Square o = other as Square;
				double x1 = X - A / 2;
				double y1 = Y + A / 2;
				double x2 = o.X - o.A / 2;
				double y2 = o.Y + o.A / 2;
				return x1 <= x2 + o.A && x1 + A >= x2 && y1 <= y2 + o.A && y1 + o.A >= y2;
			}

			return other.Crossing(this);
		}

		public override bool Equal(Figure other)
		{
			if (other is Square)
			{
				Square o = other as Square;
				return X == o.X && Y == o.Y && A == o.A;
			}

			return false;
		}

		public override string ToString()
		{
			return $"Square x={X:f2} y={Y:f2} a={A:f2} s={S:f2} {(ZeroIn() ? "IN" : "OUT")}";
		}

		public override bool ZeroIn()
		{
			return this.Crossing(new Point(0, 0));
		}
	}
}
