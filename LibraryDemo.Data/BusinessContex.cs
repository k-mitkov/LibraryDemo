using LibraryDemo.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LibraryDemo.Data
{
    public class BusinessContex : IDisposable
    {
        #region Definition
        private readonly DataContext context;
        private bool disposed;
        #endregion

        #region Methods
        public BusinessContex()
        {
            context = new DataContext();
        }
        public Author AddNewAuthor(string name,string email,char gender)
        {
            var author = new Author
            {
                Name = name,
                Email = email,
                Gender = gender
            };
            context.Authors.Add(author);
            context.SaveChanges();
            return author;
        }

        public Author FindAuthor(string name)
        {
            Author author= context.Authors.FirstOrDefault((a) => a.Name.Equals(name));
            author.Books = this.GetBooksByAuthorId(author.Id);
            return author;
        }

        public List<Author> GetAuthors()
        {
            return context.Authors.ToList();
        }

        public Library AddNewLibrary(string name, string address)
        {
            var library = new Library()
            {
                Name = name,
                Address = address
            };
            context.Libraries.Add(library);
            context.SaveChanges();
            return library;
        }

        public Library FindLibrary(string name)
        {
            Library library = context.Libraries.FirstOrDefault((l) => l.Name.Equals(name));
            library.Books = this.GetBooksByLibraryId(library.Id);
            return library;

        }

        public List<Library> GetLibraries()
        {
            return context.Libraries.ToList();
        }

        public Book AddNewBook(string title, string authorName, string libraryName,decimal price)
        {
            Author author = this.FindAuthor(authorName);
            Library library = this.FindLibrary(libraryName);
            var book = new Book
            {
                Title = title,
                Author = author,
                Price = price,
                Library = library
            };

            context.Books.Add(book);
            context.SaveChanges();

            return book;
        }

        public List<Book> GetBooksByLibraryId(int id)
        {
            return context.Books.Where((b)=>b.Library.Id==id).ToList();
        }

        public List<Book> GetBooksByAuthorId(int id)
        {
            return context.Books.Where((b) => b.Author.Id == id).ToList();
        }

        public List<Book> GetBooks()
        {
            return context.Books.ToList();
        }

        public Book FindBook(string title)
        {
            return context.Books.FirstOrDefault((b) => b.Library.Equals(title));
        }

        public List<Book> SearchForBooks(string keyWord)
        {
            return context.Books.Where((b) => b.Title.Contains(keyWord)).ToList();
        }

        public bool DeleteBook(int id)
        {
            context.Books.Remove(context.Books.Find(id));
            context.SaveChanges();
            return true;
        }
        #endregion

        #region IDesposable Members
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public void Dispose(bool disposing)
        {
            if(disposed || !disposing)
            {
                return;
            }
            if(context != null)
            {
                context.Dispose();
            }
            disposed = true;
        }
        #endregion
    }
}
