using LibraryDemo.DesktopClient.BusinessModels;
using System.Collections.Generic;

namespace LibraryDemo.DesktopClient.Services
{
    public interface ILibraryService
    {
        public BLibrary Add(string name, string address);

        public IEnumerable<BLibrary> SearchForLibraries(string keyWord);

        public bool Delete(int id);

        public IEnumerable<BLibrary> GetLibraries();
    }
}
