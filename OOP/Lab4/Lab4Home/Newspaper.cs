using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4Home
{
	public class Newspaper : Publication
	{
		public Newspaper(uint num, string name) : base(num, name)
		{
		}

		public override string ToString()
		{
			return $"Газета «{Name}» №{Num}";
		}
	}
}
