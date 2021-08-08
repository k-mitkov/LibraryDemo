using LibraryDemo.Data;
using LibraryDemo.Data.Models;
using LibraryDemo.DesktopClient.BusinessModels;
using LibraryDemo.DesktopClient.Mappers;
using LibraryDemo.DesktopClient.Mappers.Impl;
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
            var book = new Book
            {
                Title = title,
                Author = dataService.FindAuthor(author.Name),
                Price = price,
                Library = dataService.FindLibrary(library.Name)
            };
            return bookMapper.Map(dataService.AddNewBook(book));
        }

        public bool Delete(int id)
        {
            return dataService.DeleteBook(id);
        }

        public IEnumerable<BBook> GetBooks()
        {
            return bookMapper.Map(dataService.GetBooks());
        }

        public IEnumerable<BBook> GetBooksByAuthorId(int id)
        {
            return bookMapper.Map(dataService.GetBooksByAuthorId(id));
        }

        public IEnumerable<BBook> GetBooksByLibraryId(int id)
        {
            return bookMapper.Map(dataService.GetBooksByLibraryId(id));
        }

        public IEnumerable<BBook> SearchForBooks(string keyWord)
        {
            return bookMapper.Map(dataService.SearchForBooks(keyWord));
        }
        #endregion
    }
}
