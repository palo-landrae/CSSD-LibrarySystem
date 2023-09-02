using ILibrarySystem;
using LibrarySystem.Model;
using LibrarySystemModel.Model;

namespace LibrarySystem
{
    public class BookManagement: IBookManager
    {
        private List<Book> books = new List<Book>();
        public BookManagement() { }

        public void AddBook(Book book) {
            books.Add(book);
        }
        public void RemoveBook(Book book)
        {

        }
        public Book[] GetBooks()
        {
            return books.ToArray();
        }
        public void BorrowBook(Student student, Book book) {

        }
    }
}