using LibraryDemo.Data;
using LibraryDemo.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryDemo.DesktopClient.ViewModels
{
    public class ShowBooksByKeyWordViewModel
    {
        private BusinessContex context;
        private string keyWord;


        public ShowBooksByKeyWordViewModel(string keyWord)
        {
            this.keyWord = keyWord;
            context = new BusinessContex();
        }

        public List<Book> ListOfBooks
        {
            get
            {
                return context.SearchForBooks(keyWord);
            }
        }
    }
}
