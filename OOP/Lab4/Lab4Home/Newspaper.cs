using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4Home
{
	public class Newspaper : Publication
	{
		public Newspaper(string name) : base(name)
		{
		}

		public override void SetNextPublishDate()
		{
			NextPublishDate = NextPublishDate.AddDays(1);
		}

		public override string ToString()
		{
			return $"Газета «{Name}»";
		}
	}
}
