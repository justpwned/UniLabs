using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.OutputEncoding = Encoding.Unicode;

			Person[] list = new Person[3];
			list[0] = new Stud("Сергей", "Петров", "Витальевич", "МОиАИС", "144-1", 4, 
								new List<string>() { "Физика", "ООП", "История" });
			list[1] = new Stud("Анастасия", "Зуева", "Семёнова", "ПИ", "165", 2);
			list[2] = new Prof("Владимир", "Азаров", "Михайлович", "Математики", 12,
								new List<string>() { "Математический анализ", "Топология", "Логика" });

			for (int i = 0; i < list.Length; ++i)
			{
				Console.WriteLine("{0,3}. {1}", i + 1, list[i]);
				Console.WriteLine("{0,3}. {1}", i + 1, list[i].FullInfo());
			}

			return;
		}
	}
}
