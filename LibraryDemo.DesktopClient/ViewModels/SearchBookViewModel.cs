using LibraryDemo.Data.Models;
using LibraryDemo.DesktopClient.Command;
using LibraryDemo.DesktopClient.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Controls;

namespace LibraryDemo.DesktopClient.ViewModels
{
    public class SearchBookViewModel : BaseSearchViewModel
    {
        #region Proparties
        public string SelectContent
        {
            get
            {
                return content.SearchTitleText();
            }
        }
        #endregion

        #region Methods
        public override void Search(Object o)
        {
            List<Book> books = context.SearchForBooks(_keyWord).ToList();
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
