using LibraryDemo.DesktopClient.BusinessModels;
using System.Collections.Generic;

namespace LibraryDemo.DesktopClient.Services
{
    public interface IAuthorService
    {
        public BAuthor Add(string name, char gender, string mail);

        public IEnumerable<BAuthor> SearchForAutors(string keyWord);

        public bool Delete(int id);

        public IEnumerable<BAuthor> GetAuthors();
    }
}
