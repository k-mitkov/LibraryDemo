﻿using LibraryDemo.Data;
using LibraryDemo.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryDemo.DesktopClient.ViewModels
{
    public class AllBooksViewModel
    {
        private BusinessContex context;

        public AllBooksViewModel()
        {
            context = new BusinessContex();
        }

        public List<Book> ListOfBooks
        {
            get
            {
                return context.GetBooks();
            }
        }
    }
}
