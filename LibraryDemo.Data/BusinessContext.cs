using LibraryDemo.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace LibraryDemo.Data
{
    public class BusinessContext : IDataService , IDisposable
    {
        #region Definition
        private readonly DataContext context;
        private bool disposed;
        #endregion

        #region Constructor
        public BusinessContext()
        {
            context = new DataContext();
        }
        #endregion

        #region Methods
        public Author AddNewAuthor(Author author)
        {
            context.Authors.Add(author);
            context.SaveChanges();
            return author;
        }

        public Author FindAuthor(string name)
        {
            Author author= context.Authors.FirstOrDefault((a) => a.Name.Equals(name));
            author.Books = this.GetBooksByAuthorId(author.Id).ToList();
            return author;
        }

        public IQueryable<Author> SearchForAutors(string keyWord)
        {
            return context.Authors.Include("Books").Where(a => a.Name.Contains(keyWord)).AsQueryable();
        }

        public IQueryable<Author> GetAuthors()
        {
            return context.Authors.AsQueryable();
        }

        public bool DeleteAuthor(int id)
        {
            context.Authors.Remove(context.Authors.Find(id));

            foreach(Book book in this.GetBooksByAuthorId(id))
            {
                context.Books.Remove(book);
            }

            context.SaveChanges();

            return true;
        }

        public Library AddNewLibrary(Library library)
        {
            context.Libraries.Add(library);
            context.SaveChanges();
            return library;
        }

        public Library FindLibrary(string name)
        {
            Library library = context.Libraries.FirstOrDefault((l) => l.Name.Equals(name));
            library.Books = this.GetBooksByLibraryId(library.Id).ToList();
            return library;
        }

        public IQueryable<Library> GetLibraries()
        {
            return context.Libraries.AsQueryable();
        }

        public IQueryable<Library> SearchForLibraries(string keyWord)
        {
            return context.Libraries.Include("Books").Where(a => a.Name.Contains(keyWord)).AsQueryable();
        }

        public bool DeleteLibrary(int id)
        {
            context.Libraries.Remove(context.Libraries.Find(id));

            foreach (Book book in this.GetBooksByLibraryId(id))
            {
                context.Books.Remove(book);
            }

            context.SaveChanges();

            return true;
        }

        public Book AddNewBook(Book book)
        {
            context.Books.Add(book);
            context.SaveChanges();

            return book;
        }
        public IQueryable<Book> GetBooksByLibraryId(int id)
        {
            return context.Books.Include("Author").Include("Library").Where((b)=>b.Library.Id==id).AsQueryable();
        }

        public IQueryable<Book> GetBooksByAuthorId(int id)
        {
            return context.Books.Include("Author").Include("Library").Where((b) => b.Author.Id == id).AsQueryable();
        }

        public IQueryable<Book> GetBooks()
        {
            return context.Books.Include("Author").Include("Library").AsQueryable();
        }

        public Book FindBook(string title)
        {
            return context.Books.FirstOrDefault((b) => b.Library.Equals(title));
        }

        public IQueryable<Book> SearchForBooks(string keyWord)
        {
            return context.Books.Include("Author").Include("Library").Where((b) => b.Title.Contains(keyWord)).AsQueryable();
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
