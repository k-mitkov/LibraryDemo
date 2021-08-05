using LibraryDemo.Data.Models;
using LibraryDemo.DesktopClient.Views;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LibraryDemo.DesktopClient.ViewModels
{
    class SearchLibraryViewModel : BaseSearchViewModel
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
            List<Library> libraries = context.SearchForLibraries(_keyWord).ToList();
            if (libraries.Count == 0)
            {
                ErrMasage = content.ErrLibrariesNotFound();
                CurentView = null;
            }
            else
            {
                ErrMasage = "";
                ShowLibraryViewModel viewModel = new ShowLibraryViewModel(libraries);
                ShowLibrariesView view = new ShowLibrariesView();
                view.DataContext = viewModel;
                CurentView = view;
            }
        }
        #endregion
    }
}
