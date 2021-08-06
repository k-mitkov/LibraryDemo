using LibraryDemo.DesktopClient.BusinessModels;
using LibraryDemo.DesktopClient.Views;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LibraryDemo.DesktopClient.ViewModels
{
    public class SearchBookToDeleteViewModel : BaseSearchViewModel
    {
        #region Proparties 
        public string SelectContent
        {
            get
            {
                return content.SearchTitle();
            }
        }
        #endregion

        #region Methods
        public override void Search(Object o)
        {
            List<BBook> books = bookService.SearchForBooks(_keyWord).ToList();
            if (books.Count!=0)
            {
                ErrMasage = "";
                DeleteBookViewModel viewModel = new DeleteBookViewModel(books);
                DeleteBookView view = new DeleteBookView();
                view.DataContext = viewModel;
                CurentView = view;
            }
            else
            {
                ErrMasage = content.ErrBooksNotFound(); ;
                CurentView = null;
            }
        }
        #endregion
    }
}
