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
    public class AuthorService : IAuthorService
    {
        #region Declaration
        private IDataService dataService;
        private IAuthorMapper authorMapper;
        #endregion

        #region Constructor
        public AuthorService()
        {
            dataService = new BusinessContext();
            authorMapper = new AuthorMapper();
        }
        #endregion

        #region Methods
        public BAuthor Add(string name, char gender, string mail)
        {
            try{
                var author = new Author()
                {
                    Name = name,
                    Gender = gender,
                    Email = mail
                };

                return authorMapper.Map(dataService.AddNewAuthor(author));
            }
            catch (Exception e)
            {
                ExceptionLogger.LoggException(e);
                return new BAuthor();
            }
        }

        public bool Delete(int id)
        {
            try
            {
                return dataService.DeleteAuthor(id);
            }
            catch (Exception e)
            {
                ExceptionLogger.LoggException(e);
                return false;
            }
        }

        public IEnumerable<BAuthor> GetAuthors()
        {
            try
            {
                return authorMapper.Map(dataService.GetAuthors());
            }
            catch (Exception e)
            {
                ExceptionLogger.LoggException(e);
                return new List<BAuthor>();
            }
        }

        public IEnumerable<BAuthor> SearchForAutors(string keyWord)
        {
            try
            {
                return authorMapper.Map(dataService.SearchForAutors(keyWord));
            }
            catch (Exception e)
            {
                ExceptionLogger.LoggException(e);
                return new List<BAuthor>();
            }
        }
        #endregion
    }
}
