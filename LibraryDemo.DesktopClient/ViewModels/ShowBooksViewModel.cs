using LibraryDemo.Data;
using LibraryDemo.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryDemo.DesktopClient.ViewModels
{
    class ShowBooksViewModel
    {
        private BusinessContex context;
        private Author author;


        public ShowBooksViewModel(Author author)
        {
            this.author = author;
            context = new BusinessContex();
        }

        public List<Book> ListOfBooks
        {
            get
            {
                return context.GetBooksByAuthorId(author.Id);
            }
        }
    }
}
