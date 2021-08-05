using LibraryDemo.DesktopClient.Views;
using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryDemo.DesktopClient.ViewModels
{
    class LibrayMenuViewModel : BaseMenuViewModel
    {
        #region Proparties
        public string ShowAllButtonContent
        {
            get
            {
                return content.AllLibraries();
            }
        }

        public string SearchButtonContent
        {
            get
            {
                return content.SearchLibrary();
            }
        }

        public string AddButtonContent
        {
            get
            {
                return content.AddLibrary();
            }
        }

        public string DeleteButtonContent
        {
            get
            {
                return content.DeleteLibrary();
            }
        }
        #endregion

        #region Methods
        public override void ShowAll(Object o)
        {
            ShowLibraryViewModel viewModel = new ShowLibraryViewModel();
            ShowLibrariesView view = new ShowLibrariesView();
            view.DataContext = viewModel;
            CurentView = view;
        }
        public override void Search(Object o)
        {
            SearchLibraryViewModel viewModel = new SearchLibraryViewModel();
            SearchView view = new SearchView();
            view.DataContext = viewModel;
            CurentView = view;
        }
        public override void Add(Object o)
        {
            AddLibraryViewModel viewModel = new AddLibraryViewModel();
            AddLibraryView view = new AddLibraryView();
            view.DataContext = viewModel;
            CurentView = view;
        }
        public override void Delete(Object o)
        {
            SearchLibraryToDeleteViewModel viewModel = new SearchLibraryToDeleteViewModel();
            SearchView view = new SearchView();
            view.DataContext = viewModel;
            CurentView = view;
        }
        #endregion
    }
}
