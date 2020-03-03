using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3Home
{
	class Book : IEquatable<Book>, IComparable<Book>
	{
		public int ID { get; set; }
		public string Title { get; set; }
		public string Author { get; set; }
		public string Publisher { get; set; }
		public bool IsImportant { get; set; }

		public Book(int id, string title, string author, string publisher, bool isImportant)
		{
			ID = id;
			Title = title;
			Author = author;
			Publisher = publisher;
			IsImportant = isImportant;
		}

		public bool Equals(Book other)
		{
			if (other == null) return false;
			return this.Title == other.Title;
		}

		public override string ToString()
		{
			return $"{ID}. {Title}({Author}) published by {Publisher}";
		}

		public int CompareTo(Book other)
		{
			if (other == null) return 1;
			return Title.CompareTo(other.Title);
		}
	}
}
