using LibraryDemo.Data.Models;
using System.Linq;

namespace LibraryDemo.Data
{
    public interface IDataService
    {
        public Author AddNewAuthor(Author author);
        public Author FindAuthor(string name);
        public IQueryable<Author> GetAuthors();
        public Library AddNewLibrary(Library library);
        public Library FindLibrary(string name);
        public IQueryable<Library> GetLibraries();
        public IQueryable<Library> SearchForLibraries(string keyWord);
        public bool DeleteLibrary(int id);
        public Book AddNewBook(Book book);
        public IQueryable<Book> GetBooksByLibraryId(int id);
        public IQueryable<Book> GetBooksByAuthorId(int id);
        public IQueryable<Book> GetBooks();
        public IQueryable<Book> SearchForBooks(string keyWord);
        public IQueryable<Author> SearchForAutors(string keyWord);
        public bool DeleteBook(int id);
        public bool DeleteAuthor(int id);
        public User AddNewUser(User user);
        public User GetUserByName(string name);
        public User GetUserByMail(string mail);
        public bool UpdateUserPassword(User user);
    }
}
