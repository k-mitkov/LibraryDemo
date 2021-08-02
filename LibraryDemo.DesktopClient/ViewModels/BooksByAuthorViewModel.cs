using LibraryDemo.Data.Models;
using LibraryDemo.DesktopClient.Command;
using LibraryDemo.DesktopClient.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Controls;

namespace LibraryDemo.DesktopClient.ViewModels
{
    public class BooksByAuthorViewModel : BaseNotifyPropertyChangedViewModel
    {
        #region Declaration
        private Author selected;
        private ActionCommand showCommand;
        private UserControl currentView;
        private string errMasage;
        #endregion

        #region Proparties
        public IEnumerable<Author> ListOfT
        {
            get
            {
                return context.GetAuthors().ToList();
            }
        }

        public Author Selected
        {
            get { return selected; }
            set 
            { 
                selected = value; 
            }
        }

        public ActionCommand ShowCommand
        {
            get
            {
                if (showCommand == null)
                {
                    showCommand = new ActionCommand(Show, CanExecuteShow);
                }
                return showCommand;
            }
        }

        public string SelectContent
        {
            get
            {
                return content.SelectAuthorText();
            }
        }

        public string SearchButtonContent
        {
            get
            {
                return content.SearchButton();
            }
        }

        public UserControl CurentView
        {
            get
            {
                return currentView;
            }

            set
            {
                currentView = value;
                OnPropertyChanged();
            }
        }
        public string ErrMasage
        {
            get
            {
                return errMasage;
            }
            set
            {
                errMasage = value;
                OnPropertyChanged();
            }
        }
        #endregion

        #region Methods
        public bool CanExecuteShow(Object o)
        {
            return true;
        }

        public void Show(Object o)
        {
            if (selected!=null)
            {
                ErrMasage = "";
                ShowBooksByAuthorViewModel viewModel = new ShowBooksByAuthorViewModel(selected);
                ShowBooksView view = new ShowBooksView();
                view.DataContext = viewModel;
                CurentView = view;
            }
            else
            {
                ErrMasage = content.ErrSelectAuthor();
                CurentView = null;
            }
        }
        #endregion
    }
}
