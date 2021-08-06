using LibraryDemo.Data;
using LibraryDemo.Data.Models;
using LibraryDemo.DesktopClient.BusinessModels;
using LibraryDemo.DesktopClient.Mappers;
using LibraryDemo.DesktopClient.Mappers.Impl;
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
            var author = new Author()
            {
                Name = name,
                Gender = gender,
                Email = mail
            };

           return authorMapper.Map(dataService.AddNewAuthor(author));
        }

        public bool Delete(int id)
        {
            return dataService.DeleteAuthor(id);
        }

        public IEnumerable<BAuthor> GetAuthors()
        {
            return authorMapper.Map(dataService.GetAuthors());
        }

        public IEnumerable<BAuthor> SearchForAutors(string keyWord)
        {
            return authorMapper.Map(dataService.SearchForAutors(keyWord));
        }
        #endregion
    }
}
