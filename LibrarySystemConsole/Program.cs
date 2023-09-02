using ILibrarySystem;
using LibrarySystem;
using LibrarySystem.Model;

public class Program
{
    private static void Main(string[] args)
    {
        IBookManager bookManager = new BookManagement();

        Book book1 = new()
        {
            Title = "Harry Potter",
            Description = "Harry Potter is a series of seven fantasy novels written by British author J. K. Rowling. The novels chronicle the lives of a young wizard, Harry Potter, and his friends Hermione Granger and Ron Weasley, all of whom are students at Hogwarts School of Witchcraft and Wizardry.",
            Genre = "Fantasy",
            Author = "J. K. Rowling."
        };
        bookManager.AddBook(book1);

        Book book2 = new()
        {
            Title = "Jujutsu Kaisen",
            Description = "Jujutsu Kaisen follows the story of Yuji Itadori, an ordinary boy who crosses paths with Megumi Fushiguro, a Jujutsu Sorcerer searching for a powerful Cursed Object known as Ryomen Sukuna's finger. ",
            Genre = "Supernatural",
            Author = "Gege Akutami"
        };
        bookManager.AddBook(book2);

        Book[] books = bookManager.GetBooks();
        for (int i = 0; i < books.Length; i++)
        {
            Console.WriteLine(books[i].Title);
            Console.WriteLine(books[i].Description);
            Console.WriteLine(books[i].Genre);
            Console.WriteLine(books[i].Author);
            Console.Write("\n");
        }
    }
}