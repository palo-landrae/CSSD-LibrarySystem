using LibrarySystem;
using LibrarySystem.Model;

BookManagement bookManagement = new BookManagement();

Book book1 = new Book();
book1.Title = "Harry Potter";
book1.Description = "Harry Potter is a series of seven fantasy novels written by British author J. K. Rowling. The novels chronicle the lives of a young wizard, Harry Potter, and his friends Hermione Granger and Ron Weasley, all of whom are students at Hogwarts School of Witchcraft and Wizardry.";
book1.Genre = "Fantasy";
book1.Author = "J. K. Rowling.";
bookManagement.AddBook(book1);

Book book2 = new Book();
book2.Title = "Jujutsu Kaisen";
book2.Description = "Jujutsu Kaisen follows the story of Yuji Itadori, an ordinary boy who crosses paths with Megumi Fushiguro, a Jujutsu Sorcerer searching for a powerful Cursed Object known as Ryomen Sukuna's finger. ";
book2.Genre = "Supernatural";
book2.Author = "Gege Akutami";
bookManagement.AddBook(book2);

Book[] books = bookManagement.GetBooks();
for (int i = 0; i < books.Length; i++)
{
    Console.WriteLine(books[i].Title);
}