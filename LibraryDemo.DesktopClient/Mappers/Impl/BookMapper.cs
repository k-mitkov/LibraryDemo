using LibraryDemo.Data.Models;
using LibraryDemo.DesktopClient.BusinessModels;
using System.Collections.Generic;
using System.Linq;

namespace LibraryDemo.DesktopClient.Mappers.Impl
{
    class BookMapper : IBookMapper
    {
        #region Declaration
        private IAuthorMapper authorMapper;
        private ILibraryMapper libraryMapper;
        #endregion

        #region Constructor
        public BookMapper()
        {
            authorMapper = new AuthorMapper();
            libraryMapper = new LibraryMapper();
        }
        #endregion

        #region Methods
        public BBook Map(Book book)
        {
            return new BBook
            {
                Id = book.Id,
                Title = book.Title,
                Author = authorMapper.Map(book.Author),
                Library = libraryMapper.Map(book.Library)
            };
        }

        public Book Map(BBook book)
        {
            return new Book
            {
                Id = book.Id,
                Title = book.Title,
                Author = authorMapper.Map(book.Author),
                Library = libraryMapper.Map(book.Library)
            };
        }

        public IEnumerable<BBook> Map(IQueryable<Book> books)
        {
            books.ToList();
            List<BBook> bBookS = new List<BBook>();
            foreach (Book book in books)
            {
                bBookS.Add(Map(book));
            }
            return bBookS;
        }
        #endregion
    }
}
