using LibraryDemo.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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
        public Book AddNewBook(Book book);
        public IQueryable<Book> GetBooksByLibraryId(int id);
        public IQueryable<Book> GetBooksByAuthorId(int id);
        public IQueryable<Book> GetBooks();
        public IQueryable<Book> SearchForBooks(string keyWord);
        public IQueryable<Author> SearchForAutors(string keyWord);
        public bool DeleteBook(int id);
    }
}
