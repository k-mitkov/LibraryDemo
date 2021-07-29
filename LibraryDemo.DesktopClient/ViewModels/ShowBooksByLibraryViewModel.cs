using LibraryDemo.Data;
using LibraryDemo.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryDemo.DesktopClient.ViewModels
{
    class ShowBooksByLibraryViewModel
    {
        private BusinessContex context;
        private Library library;


        public ShowBooksByLibraryViewModel(Library library)
        {
            this.library = library;
            context = new BusinessContex();
        }

        public List<Book> ListOfBooks
        {
            get
            {
                return context.GetBooksByLibraryId(library.Id);
            }
        }
    }
}
