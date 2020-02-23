using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
	public class Point : Figure
	{
		public override double S
		{
			get => 0;
			set => S = 0;
		}

		public Point() { }

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
			return $"Point  x={X:f2} y={Y:f2} s={S:f2} {(ZeroIn() ? "IN" : "OUT")}";
		}
	}
}
