using LibraryDemo.Data.Models;
using LibraryDemo.DesktopClient.BusinessModels;
using System.Collections.Generic;
using System.Linq;

namespace LibraryDemo.DesktopClient.Mappers
{
    interface ILibraryMapper
    {
        public BLibrary Map(Library library);
        public Library Map(BLibrary library);
        public IEnumerable<BLibrary> Map(IQueryable<Library> libraries);
    }
}
