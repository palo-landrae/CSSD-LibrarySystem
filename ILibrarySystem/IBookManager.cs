using LibrarySystem.Model;

namespace ILibrarySystem
{
    public interface IBookManager
    {
        public void AddBook(Book book);
        public Book[] GetBooks();
    }
}