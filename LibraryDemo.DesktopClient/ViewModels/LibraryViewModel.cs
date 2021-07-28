using LibraryDemo.Data;
using LibraryDemo.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryDemo.DesktopClient.ViewModels
{
    class LibraryViewModel
    {
        BusinessContex businessContext;
        private List<Library> listOfLibraries;

        public LibraryViewModel()
        {
            businessContext = new BusinessContex();
        }

        public List<Library> ListOfLibraries
        {
            get
            {
                listOfLibraries = businessContext.GetLibraries();
                return listOfLibraries;
            }
        }

    }
}
