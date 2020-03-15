using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4Home
{
	public abstract class Publication
	{
		public int Num { get; set; }
		public string Name { get; set; }
		public bool IsPublishing { get; set; }
		public DateTime InceptionDate { get; set; }
		public DateTime NextPublishDate { get; set; }
		public List<Subscriber> Subscribers { get; } = new List<Subscriber>();

		public Publication(string name)
		{
			Num = 1;
			Name = name;
			IsPublishing = true;
			InceptionDate = PublisherForm.gDateTime;
			NextPublishDate = InceptionDate;
		}

		public bool IsTimeToPublish(DateTime currentTime)
		{
			return NextPublishDate.Day   == currentTime.Day &&
				   NextPublishDate.Month == currentTime.Month &&
				   NextPublishDate.Year  == currentTime.Year;
		}

		public abstract void SetNextPublishDate();
		public abstract override string ToString();
	}
}
