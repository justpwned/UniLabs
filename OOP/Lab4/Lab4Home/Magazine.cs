using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4Home
{
	public class Magazine : Publication
	{
		public Magazine(string name) : base(name)
		{
		}

		public override void SetNextPublishDate()
		{
			NextPublishDate = NextPublishDate.AddDays(7);
		}

		public override string ToString()
		{
			return $"Журнал «{Name}»";
		}
	}
}
