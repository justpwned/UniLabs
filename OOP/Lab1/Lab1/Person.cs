using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
	[Serializable]
	public abstract class Person
	{
		public string Name { get; set; }
		public string Surname { get; set; }
		public string Patronymic { get; set; }

		protected int _year;
		public abstract int Year { get; set; }

		public Person() { }
		public Person(string name, string surname, string patronymic)
		{
			Name = name;
			Surname = surname;
			Patronymic = patronymic;
		}

		public abstract void NextYear();
		public abstract string BriefInfo();
		public abstract string FullInfo();
		public override string ToString()
		{
			return BriefInfo();
		}
	}
}
