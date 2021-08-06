using LibraryDemo.DesktopClient.BusinessModels;
using LibraryDemo.DesktopClient.Views;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LibraryDemo.DesktopClient.ViewModels
{
    public class SearchBookViewModel : BaseSearchViewModel
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
            if (books.Count == 0)
            {
                ErrMasage = content.ErrBooksNotFound();
                CurentView = null;
            }
            else
            {
                ErrMasage = "";
                ShowBooksViewModel viewModel = new ShowBooksViewModel(books);
                ShowBooksView view = new ShowBooksView();
                view.DataContext = viewModel;
                CurentView = view;
            }
        }
        #endregion
    }
}
