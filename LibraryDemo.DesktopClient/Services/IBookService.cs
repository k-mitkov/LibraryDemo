using LibraryDemo.DesktopClient.BusinessModels;
using System.Collections.Generic;

namespace LibraryDemo.DesktopClient.Services
{
    public interface IBookService
    {
        public BBook Add(string title, BAuthor author, decimal price, BLibrary bLibrary);

        public IEnumerable<BBook> SearchForBooks(string keyWord);

        public bool Delete(int id);

        public IEnumerable<BBook> GetBooks();

        public IEnumerable<BBook> GetBooksByLibraryId(int id);

        public IEnumerable<BBook> GetBooksByAuthorId(int id);
    }
}
