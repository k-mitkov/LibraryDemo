using LibraryDemo.Data.Models;
using LibraryDemo.DesktopClient.Views;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LibraryDemo.DesktopClient.ViewModels
{
    class SearchAuthorToDeleteViewModel : BaseSearchViewModel
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
            if (authors.Count != 0)
            {
                ErrMasage = "";
                DeleteAuthorViewModel viewModel = new DeleteAuthorViewModel(authors);
                DeleteView view = new DeleteView();
                view.DataContext = viewModel;
                CurentView = view;
            }
            else
            {
                ErrMasage = content.ErrAuthorNotFound(); ;
                CurentView = null;
            }
        }
        #endregion
    }
}
