using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
	[Serializable]
	public class Stud : Person
	{
		public string Spec { get; set; }
		public string Group { get; set; }

		public override int Year
		{
			get { return _year; }
			set
			{
				if (value > 4)
				{
					_year = 4;
				}
				else if (value < 1)
				{
					_year = 1;
				}
				else
				{
					_year = value;
				}
			}
		}

		public List<string> Uncomms { get; set; } = new List<string>();

		public Stud() { }

		public Stud(string name, string surname, string patronymic, string spec, 
					string group, int year, List<string> uncomms = null)
			: base(name, surname, patronymic)
		{
			Spec = spec;
			Group = group;
			Year = year;
			if (uncomms != null)
			{
				Uncomms = uncomms;
			}
		}

		public override string BriefInfo()
		{
			return $"Студ: {Surname} {Name}, группа {Group}." +
				$"{(Uncomms.Count > 0 ? " " + Uncomms.Count + " долга." : "")}";
		}

		public override string FullInfo()
		{
			return $"{Surname} {Name} {Patronymic}, студент {Group} группы {Year} курса {Spec}." +
				$"{(Uncomms.Count > 0 ? " Долги: " + Uncomms.Repr(", "): " Долгов нет")}.";
		}

		public override void NextYear()
		{
			Year = Year + 1;
		}
	}
}
