using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson6Library
{
    public class Library
    {
        public string LibraryName { get; } = string.Empty;
        private List<Book> Books { get; set; } = new List<Book>();
        public Library (string libraryName)
        {
            LibraryName = libraryName;  
        }
        public Library (string libraryName, List<Book> books)
        {
            LibraryName=libraryName;
            Books = books;
            SetLibraryNameInBooks(books);
        }
        public Library (string libraryName, Book book) //конструктор на случай, вдруг библиотека будет создаваться с 1 книгой :)
        {
            LibraryName = libraryName;
            book.SetLibraryNameInBook(libraryName);
            Books.Add(book);
        }
        public void SetLibraryNameInBooks (List<Book> books) //установить название библиотеки в набор книг
        {
            foreach (var book in books)
            {
                book.SetLibraryNameInBook(this.LibraryName);
            }
        }
        public void AddBookInLibrary (Book book) //добавить существующую книгу в библиотеку
        {
            Books.Add(book);
            book.SetLibraryNameInBook(this.LibraryName);
        }
        public void AddBookInLibrary (List<Book> books) //добавить набор книг в библиотеку
        {
            Books.AddRange(books);
            SetLibraryNameInBooks(books);
            
        }
        public void AddBookInLibrary(string bookName, int numberOfPages, string libraryName) //добавить новую книгу в библиотеку
        {
            Books.Add(new Book(bookName, numberOfPages, libraryName));
        }
        public string FindBook(int index) //поиск по индексу и отображение инфы о книге
        {
            return Books[index - 1].ToString();
        }
        public string FindBook (string bookName) //поиск книги по назвнию
        {
            string result = string.Empty;
            var firstBook = bookName.ToUpper();

            for (int i = 0; i < Books.Count; i++)
            {
                var secondBook = Books[i].GetBookName().ToUpper();

                if (firstBook == secondBook)
                {
                    result = Books[i].ToString();
                }
            }

            if(result == string.Empty)
            {
                result = "Данная книга не найдена";
            }

            return result;
        }
        public string FindThickBook () //поиск самой толстой книги с помощью метода расширения
        {
            return Books.FindThickBook();
        }
    }
}
