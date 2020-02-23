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

		public Square(double x, double y, double a) : base(x, y)
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
				double distX = Math.Abs(o.X - X);
				double distY = Math.Abs(o.Y - Y);

				double halfA = A / 2;
				if (distX > (halfA + o.R) || distY > (halfA + o.R)) return false;

				// Makes sense only if you check the previous condition!
				if (distX <= halfA || distY <= halfA) return true;

				// Check if corner of the square located inside the circle
				Point innerIntersectionPoint = new Point(distX - halfA, distY - halfA);
				return o.Crossing(innerIntersectionPoint);
			}
			else if (other is Square)
			{
				// Typical AABB collision detection stuff

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
