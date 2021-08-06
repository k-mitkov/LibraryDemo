using LibraryDemo.Data.Models;
using LibraryDemo.DesktopClient.BusinessModels;
using System.Collections.Generic;
using System.Linq;

namespace LibraryDemo.DesktopClient.Mappers.Impl
{
    class LibraryMapper : ILibraryMapper
    {
        #region Methods
        public BLibrary Map(Library library)
        {
            return new BLibrary
            {
                Id = library.Id,
                Name = library.Name,
                Address = library.Address
            };
        }

        public Library Map(BLibrary library)
        {
            return new Library
            {
                Id = library.Id,
                Name = library.Name,
                Address = library.Address,
                Books=new List<Book>()
            };
        }

        public IEnumerable<BLibrary> Map(IQueryable<Library> libraries)
        {
            libraries.ToList();
            List<BLibrary> bLibrary = new List<BLibrary>();
            foreach (Library library in libraries)
            {
                bLibrary.Add(Map(library));
            }
            return bLibrary;
        }
        #endregion
    }
}
