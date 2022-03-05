using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson6Library
{
    public class Library
    {
        private string LibraryName { get; set; } = string.Empty;
        private List<Book> Books { get; set; } = new List<Book>();
        public Library (string libraryName)
        {
            LibraryName = libraryName;  
        }
        public Library(string libraryName, List<Book> books)
        {
            LibraryName=libraryName;
            Books = books;
        }
        public void AddBookInLibrary(string bookName, int numberOfPages)
        {
            Books.Add(new Book(bookName, numberOfPages));
        }
        public string FindBook(int index) //поиск по индексу и отображение инфы о книге
        {
            return Books[index - 1].ToString();
        }
        public string FindBook (string bookName) //поиск книги по назвнию
        {
            string result = string.Empty;

            for (int i = 0; i < Books.Count; i++)
            {
                if(bookName == Books[i].GetBookName())
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
        public string FindBook () //поиск самой толстой книги с помощью метода расширения
        {
            return Books.FindThickBook();
        }
    }
}
