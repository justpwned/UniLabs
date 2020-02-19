using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
	class Circle : Figure
	{
		private double _r = 1;
		public double R
		{
			get => _r;
			set
			{
				if (CalculateSquare(value) <= 100) _r = value;
			}
		}

		// Returns square of circle of a given radius
		private double CalculateSquare(double r) => Math.PI * R * R;

		// Returns radius of circle of a given square
		private double CalculateRadius(double s) => Math.Sqrt(s / Math.PI);
		
		public override double S
		{
			get => CalculateSquare(R);
			set
			{
				if (value <= 100) R = CalculateRadius(value);
			}
		}

		public Circle(double x, double y, double r = 1) : base(x, y)
		{
			R = r;
		}

		public override bool Crossing(Figure other)
		{
			if (other is Point)
			{
				return (other.X - X) * (other.X - X) + (other.Y - Y) * (other.Y - Y) <= R * R;
			}
			else if (other is Circle)
			{
				Circle o = other as Circle;
				double dx = X - o.X;
				double dy = Y - o.Y;
				double sumr = R + o.R;
				return dx * dx + dy * dy <= sumr * sumr;
			}

			return other.Crossing(this);
		}

		public override bool Equal(Figure other)
		{
			if (other is Circle)
			{
				Circle c = other as Circle;
				return X == c.X && Y == c.Y && R == c.R;
			}

			return false;
		}

		public override string ToString()
		{
			return $"Type: Circle({X:f2}, {Y:f2}), R = {R:f2}, S = {S:f2}, ZeroIn = {ZeroIn()}";
		}

		public override bool ZeroIn()
		{
			return this.Crossing(new Point(0, 0));
		}
	}
}
