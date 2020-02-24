using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.OutputEncoding = Encoding.Unicode;

			List<Figure> figures = new List<Figure>();
			figures.Add(new Point(0, 0));
			figures.Add(new Circle(1, 1, 1));
			figures.Add(new Circle(1, 1, 2));

			figures.ForEach((Figure f) => Console.WriteLine(f));

			Console.WriteLine();

			Console.WriteLine(figures[0].Crossing(figures[1])); // Should be false
			Console.WriteLine(figures[0].Crossing(figures[2])); // Should be true
			Console.WriteLine(figures[1].Crossing(figures[2])); // Should be true

			Console.WriteLine("\nSquare-circle collision tests");
			Square s1 = new Square(2, 2, 2);
			Circle c1 = new Circle(3.5, 3.5, 1.5);
			Circle c2 = new Circle(3.5, 2, 1);
			Console.WriteLine(c1.Crossing(s1)); // True
			Console.WriteLine(c2.Crossing(s1)); // True

			return;
		}
	}
}
