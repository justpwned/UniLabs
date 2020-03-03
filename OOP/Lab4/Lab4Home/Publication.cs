using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4Home
{
	public abstract class Publication : IEquatable<Publication>
	{
		public uint Num { get; set; }
		public string Name { get; set; }

		public Publication(uint num, string name)
		{
			Num = num;
			Name = name;
		}

		public bool Equals(Publication other)
		{
			return Name == other.Name;
		}

		public abstract override string ToString();
	}
}
