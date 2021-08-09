using LibraryDemo.Data;
using LibraryDemo.Data.Models;
using LibraryDemo.DesktopClient.BusinessModels;
using LibraryDemo.DesktopClient.ExceptionsLogger;
using LibraryDemo.DesktopClient.Mappers;
using LibraryDemo.DesktopClient.Mappers.Impl;
using System;
using System.Collections.Generic;

namespace LibraryDemo.DesktopClient.Services.Impl
{
    public class BookService : IBookService
    {
        #region Declaration
        private IDataService dataService;
        private IBookMapper bookMapper;
        private IAuthorMapper authorMapper;
        private ILibraryMapper libraryMapper;
        #endregion

        #region Constructor
        public BookService()
        {
            dataService = new BusinessContext();
            bookMapper = new BookMapper();
            authorMapper = new AuthorMapper();
            libraryMapper = new LibraryMapper();
        }
        #endregion

        #region Methods
        public BBook Add(string title, BAuthor author, decimal price, BLibrary library)
        {
            try
            {
                var book = new Book
                {
                    Title = title,
                    Author = dataService.FindAuthor(author.Name),
                    Price = price,
                    Library = dataService.FindLibrary(library.Name)
                };
                return bookMapper.Map(dataService.AddNewBook(book));
            }
            catch (Exception e)
            {
                ExceptionLogger.LoggException(e);
                return new BBook();
            }
        }

        public bool Delete(int id)
        {
            try
            {
                return dataService.DeleteBook(id);
            }
            catch (Exception e)
            {
                ExceptionLogger.LoggException(e);
                return false;
            }
        }

        public IEnumerable<BBook> GetBooks()
        {
            try
            {
                return bookMapper.Map(dataService.GetBooks());
            }
            catch (Exception e)
            {
                ExceptionLogger.LoggException(e);
                return new List<BBook>();
            }
        }

        public IEnumerable<BBook> GetBooksByAuthorId(int id)
        {
            try
            {
                return bookMapper.Map(dataService.GetBooksByAuthorId(id));
            }
            catch (Exception e)
            {
                ExceptionLogger.LoggException(e);
                return new List<BBook>();
            }
        }

        public IEnumerable<BBook> GetBooksByLibraryId(int id)
        {
            try
            {
                return bookMapper.Map(dataService.GetBooksByLibraryId(id));
            }
            catch (Exception e)
            {
                ExceptionLogger.LoggException(e);
                return new List<BBook>();
            }
        }

        public IEnumerable<BBook> SearchForBooks(string keyWord)
        {
            try
            {
                return bookMapper.Map(dataService.SearchForBooks(keyWord));
            }
            catch (Exception e)
            {
                ExceptionLogger.LoggException(e);
                return new List<BBook>();
            }
        }
        #endregion
    }
}
