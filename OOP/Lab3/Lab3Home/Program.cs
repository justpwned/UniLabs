using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3Home
{
	class Program
	{
		static void Main(string[] args)
		{
			Library library = new Library();

			List<Book> myBooks = new List<Book>();
			myBooks.Add(new Book(5, "The Worst Book", "A2", "P3", false));
			myBooks.Add(new Book(1, "WinAPI Reference", "A1", "P1", true));
			myBooks.Add(new Book(2, "Not a Book", "A2", "P2", false));
			myBooks.Add(new Book(4, "Best Book", "A1", "P1", true));
			myBooks.Add(new Book(3, "Very Important Book", "A3", "P2", true));

			foreach (var b in myBooks)
			{
				library.BookAct(Library.BookActions["Add"], b);
			}

			Console.WriteLine("List of Books");
			library.LibraryAct(Library.LibraryActions["Print"]);

			Console.WriteLine();

			Console.WriteLine("Clearing library...");
			library.LibraryAct(Library.LibraryActions["Clear"]);

			Console.WriteLine("Sorting books by title...");
			library.LibraryAct(Library.LibraryActions["Sort"]);

			Console.WriteLine("\nList of books:");
			library.LibraryAct(Library.LibraryActions["Print"]);

			return;
		}
	}
}
