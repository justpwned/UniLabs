using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3Home
{
	class Library
	{
		private List<Book> books = new List<Book>();

		// Books actions
		public delegate void BookAction(Book b);
		public static Dictionary<string, BookAction> BookActions = new Dictionary<string, BookAction>();

		private void AddBook(Book b) => this.books.Add(b);

		private void RemoveBook(Book b) => books.Remove(b);
		// END

		// Library actions
		public delegate void LibraryAction();
		public static Dictionary<string, LibraryAction> LibraryActions = new Dictionary<string, LibraryAction>();

		private void SortBooks() => books.Sort();

		private void ClearLibrary()
		{
			books = (from b in books where b.IsImportant select b).ToList<Book>();
		}

		private void PrintLibraryContents()
		{
			books.ForEach(b => Console.WriteLine($"{b} "));
		}
		// END

		public void BookAct(BookAction bookAction, Book book) => bookAction(book);
		public void LibraryAct(LibraryAction libAction) => libAction();

		public Library()
		{
			BookActions.Add("Add", AddBook);
			BookActions.Add("Remove", RemoveBook);
			LibraryActions.Add("Sort", SortBooks);
			LibraryActions.Add("Clear", ClearLibrary);
			LibraryActions.Add("Print", PrintLibraryContents);
		}
	}
}
