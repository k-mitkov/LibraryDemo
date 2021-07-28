using LibraryDemo.Data;
using LibraryDemo.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryDemo.DesktopClient.ViewModels
{
    public class AuthorViewModel
    {
        private BusinessContex businessContext;

        public AuthorViewModel()
        {
            businessContext = new BusinessContex();
        }

        private List<Author> listOfAuthors;
        public List<Author> ListOfAuthors
        {
            get
            {
                listOfAuthors = businessContext.GetAuthors();
                return listOfAuthors;
            }
        }
    }
}
