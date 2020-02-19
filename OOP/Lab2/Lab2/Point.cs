using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
	class Point : Figure
	{
		public override double S
		{
			get => 0;
			set => S = 0;
		}

		public Point(double x, double y) : base(x, y) { }

		public override bool Equal(Figure other)
		{
			if (other is Point)
			{
				return X == other.X && Y == other.Y;
			}
			
			return other.Equal(this);
		}

		public override bool Crossing(Figure other)
		{
			if (other is Point)
			{
				return X == other.X && Y == other.Y;
			}

			return other.Crossing(this);
		}

		public override bool ZeroIn()
		{
			return X == 0 && Y == 0;
		}

		public override string ToString()
		{
			return $"Type: Point({X:f2}, {Y:f2}), S = {S:f2}, ZeroIn = {ZeroIn()}";
		}
	}
}
