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
            try
            {
                var library = new Library()
                {
                    Name = name,
                    Address = address
                };

                return libraryMapper.Map(dataService.AddNewLibrary(library));
            }
            catch (Exception e)
            {
                ExceptionLogger.LoggException(e);
                return new BLibrary();
            }
        }

        public bool Delete(int id)
        {
            try
            {
                return dataService.DeleteLibrary(id);
            }
            catch (Exception e)
            {
                ExceptionLogger.LoggException(e);
                return false;
            }
        }

        public IEnumerable<BLibrary> GetLibraries()
        {
            try
            {
                return libraryMapper.Map(dataService.GetLibraries());
            }
            catch (Exception e)
            {
                ExceptionLogger.LoggException(e);
                return new List<BLibrary>();
            }
        }

        public IEnumerable<BLibrary> SearchForLibraries(string keyWord)
        {
            try
            {
                return libraryMapper.Map(dataService.SearchForLibraries(keyWord));
            }
            catch (Exception e)
            {
                ExceptionLogger.LoggException(e);
                return new List<BLibrary>();
            }
        }
        #endregion
    }
}
