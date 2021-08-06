using LibraryDemo.Data;
using LibraryDemo.Data.Models;
using LibraryDemo.DesktopClient.BusinessModels;
using LibraryDemo.DesktopClient.Mappers;
using LibraryDemo.DesktopClient.Mappers.Impl;
using System.Collections.Generic;

namespace LibraryDemo.DesktopClient.Services.Impl
{
    class LibraryService : ILibraryService
    {
        #region Declaration
        private IDataService dataService;
        private ILibraryMapper libraryMapper;
        #endregion

        #region Constructor
        public LibraryService()
        {
            dataService = new BusinessContext();
            libraryMapper = new LibraryMapper();
        }
        #endregion

        #region Methods
        public BLibrary Add(string name, string address)
        {
            var library = new Library()
            {
                Name = name,
                Address = address
            };

            return libraryMapper.Map(dataService.AddNewLibrary(library));
        }

        public bool Delete(int id)
        {
            return dataService.DeleteLibrary(id);
        }

        public IEnumerable<BLibrary> GetLibraries()
        {
            return libraryMapper.Map(dataService.GetLibraries());
        }

        public IEnumerable<BLibrary> SearchForLibraries(string keyWord)
        {
            return libraryMapper.Map(dataService.SearchForLibraries(keyWord));
        }
        #endregion
    }
}
