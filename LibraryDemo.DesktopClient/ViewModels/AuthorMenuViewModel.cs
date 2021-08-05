using LibraryDemo.DesktopClient.Command;
using LibraryDemo.DesktopClient.Views;
using System;
using System.Windows.Controls;

namespace LibraryDemo.DesktopClient.ViewModels
{
    class AuthorMenuViewModel : BaseMenuViewModel
    {
        #region Proparties
        public string ShowAllButtonContent
        {
            get
            {
                return content.AllAuthors();
            }
        }

        public string SearchButtonContent
        {
            get
            {
                return content.SearchAuthor();
            }
        }

        public string AddButtonContent
        {
            get
            {
                return content.AddAuthor();
            }
        }

        public string DeleteButtonContent
        {
            get
            {
                return content.DeleteAuthor();
            }
        }
        #endregion

        #region Methods
        public override void ShowAll(Object o)
        {
            ShowAuthorsViewModel viewModel = new ShowAuthorsViewModel();
            ShowAuthorsView view = new ShowAuthorsView();
            view.DataContext = viewModel;
            CurentView = view;
        }
        public override void Search(Object o)
        {
            SearchAuthorViewModel viewModel = new SearchAuthorViewModel();
            SearchView view = new SearchView();
            view.DataContext = viewModel;
            CurentView = view;
        }
        public override void Add(Object o)
        {
            AddAuthorViewModel viewModel = new AddAuthorViewModel();
            AddAuthorView view = new AddAuthorView();
            view.DataContext = viewModel;
            CurentView = view;
        }
        public override void Delete(Object o)
        {
            SearchAuthorToDeleteViewModel viewModel = new SearchAuthorToDeleteViewModel();
            SearchView view = new SearchView();
            view.DataContext = viewModel;
            CurentView = view;
        }
        #endregion
    }
}
