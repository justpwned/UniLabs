using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
	class Student
	{
		public int ID { get; set; }

		public string Surname { get; set; }
		public string Name { get; set; }
		public string Patronymic { get; set; }

		public string Spec { get; set; }
		public int Course { get; set; }

		public Student(int id, string surname, string name, string patronymic, string spec, int course)
		{
			ID = id;
			Surname = surname;
			Name = name;
			Patronymic = patronymic;
			Spec = spec;
			Course = course;
		}
	}
}
