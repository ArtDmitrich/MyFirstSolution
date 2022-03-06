namespace Lesson6Library
{
    public class Book
    {
        private string BookName { get; } = string.Empty;
        private string LibraryNameInBook { get; set; } = string.Empty;
        private int NumberOfPages { get; }
        public Book (string bookName, int numberOfPages, string libraryName)
        {
            BookName = bookName;
            NumberOfPages = numberOfPages;
            LibraryNameInBook = libraryName;
        }
        public Book(string bookName, int numberOfPages)
        {
            BookName = bookName;
            NumberOfPages = numberOfPages;
        }
        public void SetLibraryNameInBook(string libraryName)
        {
            LibraryNameInBook = libraryName;
        }
        public string GetBookName ()
        {
            return BookName;
        }
        public int GetBookNumberOfPages()
        {
            return NumberOfPages;
        }
        public override string ToString()
        {
            return $"Название книги: {BookName}. Кол-во страниц: {NumberOfPages}. Библиотека: {LibraryNameInBook}";
        }
    }
}