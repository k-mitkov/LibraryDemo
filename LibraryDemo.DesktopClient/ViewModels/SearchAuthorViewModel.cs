using LibraryDemo.Data.Models;
using LibraryDemo.DesktopClient.Command;
using LibraryDemo.DesktopClient.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Controls;

namespace LibraryDemo.DesktopClient.ViewModels
{
    class SearchAuthorViewModel : BaseSearchViewModel
    {
        #region Proparties 
        public string SelectContent
        {
            get
            {
                return content.SearchByName();
            }
        }
        #endregion

        #region Methods
        public override void Search(Object o)
        {
            List<Author> authors = context.SearchForAutors(_keyWord).ToList();
            if (authors.Count == 0)
            {
                ErrMasage = content.ErrAuthorNotFound();
                CurentView = null;
            }
            else
            {
                ErrMasage = "";
                ShowAuthorsViewModel viewModel = new ShowAuthorsViewModel(authors);
                ShowAuthorsView view = new ShowAuthorsView();
                view.DataContext = viewModel;
                CurentView = view;
            }
        }
        #endregion
    }
}
