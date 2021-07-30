using LibraryDemo.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LibraryDemo.Data
{
    public class BusinessContex : IDataService , IDisposable
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

        public Author AddNewAuthor(Author author)
        {
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

        public Library AddNewLibrary(Library library)
        {
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

        public Book AddNewBook(Book book)
        {
            context.Books.Add(book);
            context.SaveChanges();

            return book;
        }
        public List<Book> GetBooksByLibraryId(int id)
        {
            return context.Books.Include("Author").Include("Library").Where((b)=>b.Library.Id==id).ToList();
        }

        public List<Book> GetBooksByAuthorId(int id)
        {
            return context.Books.Include("Author").Include("Library").Where((b) => b.Author.Id == id).ToList();
        }

        public List<Book> GetBooks()
        {
            return context.Books.Include("Author").Include("Library").ToList();
        }

        public Book FindBook(string title)
        {
            return context.Books.FirstOrDefault((b) => b.Library.Equals(title));
        }

        public List<Book> SearchForBooks(string keyWord)
        {
            return context.Books.Include("Author").Include("Library").Where((b) => b.Title.Contains(keyWord)).ToList();
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
