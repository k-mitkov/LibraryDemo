using LibraryDemo.Data.Models;
using LibraryDemo.DesktopClient.Command;
using LibraryDemo.DesktopClient.Views;
using System;
using System.Collections.Generic;
using System.Windows.Controls;

namespace LibraryDemo.DesktopClient.ViewModels
{
    public class BooksByAuthorViewModel : BaseNotifyPropertyChangedViewModel
    {
        #region Declaration
        private Author _sauthor;
        private ActionCommand showCommand;
        private UserControl currentView;
        private string errMasage;
        #endregion

        #region Proparties
        public List<Author> ListOfAuthors
        {
            get
            {
                return context.GetAuthors();
            }
        }

        public Author SAuthor
        {
            get { return _sauthor; }
            set 
            { 
                _sauthor = value; 
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
            if (_sauthor!=null)
            {
                ErrMasage = "";
                ShowBooksViewModel viewModel = new ShowBooksViewModel(_sauthor);
                ShowBooksView view = new ShowBooksView();
                view.DataContext = viewModel;
                CurentView = view;
            }
            else
            {
                ErrMasage = "Моля изберете автор";
                CurentView = null;
            }
        }
        #endregion
    }
}
