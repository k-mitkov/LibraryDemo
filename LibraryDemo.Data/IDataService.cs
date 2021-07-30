using LibraryDemo.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryDemo.Data
{
    public interface IDataService
    {
        public Author AddNewAuthor(Author author);
        public Author FindAuthor(string name);
        public List<Author> GetAuthors();
        public Library AddNewLibrary(Library library);
        public Library FindLibrary(string name);
        public List<Library> GetLibraries();
        public Book AddNewBook(Book book);
        public List<Book> GetBooksByLibraryId(int id);
        public List<Book> GetBooksByAuthorId(int id);
        public List<Book> GetBooks();
        public List<Book> SearchForBooks(string keyWord);
        public bool DeleteBook(int id);
    }
}
