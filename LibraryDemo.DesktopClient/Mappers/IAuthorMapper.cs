using LibraryDemo.Data.Models;
using LibraryDemo.DesktopClient.BusinessModels;
using System.Collections.Generic;
using System.Linq;

namespace LibraryDemo.DesktopClient.Mappers
{
    interface IAuthorMapper
    {
        public BAuthor Map(Author author);
        public Author Map(BAuthor author);
        public IEnumerable<BAuthor> Map(IQueryable<Author> authors);
    }
}
