using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
	class Students
	{
		public static ArrayList Studs = new ArrayList();

		public delegate bool LessRule(Student S1, Student S2);

		public static bool LessID(Student S1, Student S2) => S1.ID <= S2.ID;
		public static bool LessName(Student S1, Student S2) => string.Compare(S1.Name, S2.Name) <= 0;
		public static bool LessSpec(Student S1, Student S2) => string.Compare(S1.Spec, S2.Spec) <= 0;
		public static bool LessCourse(Student S1, Student S2) => S1.Course <= S2.Course;

		public static void SortStud(LessRule Less)
		{
			for (int i = 0; i < Studs.Count - 1; i++)
			{
				for (int j = i + 1; j < Studs.Count; j++)
				{
					if (!Less((Studs[i] as Student), (Studs[j] as Student)))
					{
						Student s = Studs[i] as Student;
						Studs[i] = Studs[j];
						Studs[j] = s;
					}
				}
			}
		}

		public delegate string FormatRule(Student s);

		public static string FormatFull(Student s)
		{
			return $"{s.ID, 2}. {s.Surname + " " + s.Name + " " + s.Patronymic, -36} {s.Spec, -8} {s.Course} курс.";
		}

		public static string FormatShort(Student s)
		{
			return $"{s.ID,2}. {s.Surname + " " + s.Name[0] + "." + s.Patronymic[0] + ".", -20} {s.Spec,-8} {s.Course} курс.";
		}

		public static string FormatInformal(Student s)
		{
			string course = "";
			switch (s.Course)
			{
				case 1: course = "первом"; break;
				case 2: course = "втором"; break;
				case 3: course = "третьем"; break;
				case 4: course = "четвертом"; break;
			}
			
			return $"{s.Surname} обучается на {course} курсе направления {s.Spec}.";
		}

		public static void PrintStuds(string st, FormatRule Fmt)
		{
			Console.WriteLine(st);
			for (int i = 0; i < Studs.Count; i++)
			{
				Console.WriteLine(Fmt(Studs[i] as Student));
			}
		}

		static void Main(string[] args)
		{
			Console.OutputEncoding = Encoding.Unicode;

			Studs.Add(new Student(1, "Петров", "Александр", "Сергеевич", "МОиАИС", 2));
			Studs.Add(new Student(2, "Иванов", "Дмитрий", "Иванович", "ПИ", 1));
			Studs.Add(new Student(3, "Агапова", "Людмила", "Викторовна", "МОиАИС", 3));
			Studs.Add(new Student(4, "Закарян", "Ашот", "Ашотович", "ИСТ", 4));

			PrintStuds("\nСписок студентов:", FormatFull);

			SortStud(LessName);
			PrintStuds("\nСортировка по фамилии:", FormatShort);

			SortStud(LessSpec);
			PrintStuds("\nСортировка по специальности:", FormatInformal);

			SortStud(LessCourse);
			PrintStuds("\nСортировка по курсу:", FormatFull);

			SortStud(LessID);
			PrintStuds("\nСортировка по номеру:", FormatShort);

			return;
		}
	}
}
