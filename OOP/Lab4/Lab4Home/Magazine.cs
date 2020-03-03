using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4Home
{
	public class Magazine : Publication
	{
		public Magazine(uint num, string name) : base(num, name)
		{
		}

		public override string ToString()
		{
			return $"Журнал «{Name}» №{Num}";
		}
	}
}
