using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
	[Serializable]
	public class Prof : Person
	{
		public string Dep { get; set; }

		public override int Year
		{
			get { return _year; }
			set
			{
				if (value > 0)
				{
					_year = value;
				}
				else
				{
					_year = 0;
				}
			}
		}

		public List<string> Disciplines { get; set; } = new List<string>();

		public Prof() { }
		public Prof(string name, string surname, string patronymic,
					string dep, int year, List<string> disciplines = null)
			: base (name, surname, patronymic)
		{
			Dep = dep;
			Year = year;
			if (disciplines != null)
			{
				Disciplines = disciplines;
			}
		}

		public override string BriefInfo()
		{
			return $"Преп: {Surname} {Name[0]}.{Patronymic[0]}., кафедра {Dep}, " +
				$"{(Disciplines.Count > 0 ? "Читает " + Disciplines.Count + " дисциплины." : "")}";
		}

		public override string FullInfo()
		{
			return $"{Surname} {Name} {Patronymic}, преподаватель кафедры {Dep}, стаж {Year} лет" +
				$"{(Disciplines.Count > 0 ? ", курсы: " + Disciplines.Repr(", ") + "." : ".")}";
		}

		public override void NextYear()
		{
			Year++;
		}
	}
}
