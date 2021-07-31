using LibraryDemo.Data.Models;
using LibraryDemo.DesktopClient.Command;
using LibraryDemo.DesktopClient.Views;
using System;
using System.Collections.Generic;
using System.Windows.Controls;

namespace LibraryDemo.DesktopClient.ViewModels
{
    public class BooksByLibraryViewModel : BaseNotifyPropertyChangedViewModel
    {
        #region Declaraion
        private Library _slibrary;
        private ActionCommand showCommand;
        private UserControl currentView;
        private string errMasage;
        #endregion

        #region Proparties
        public List<Library> ListOfLibraries
        {
            get
            {
                return context.GetLibraries();
            }
        }

        public Library SLibrary
        {
            get { return _slibrary; }
            set
            {
                _slibrary = value;
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
            if (_slibrary != null)
            {
                ErrMasage = "";
                ShowBooksByLibraryViewModel viewModel = new ShowBooksByLibraryViewModel(_slibrary);
                ShowBooksView view = new ShowBooksView();
                view.DataContext = viewModel;
                CurentView = view;
            }
            else
            {
                ErrMasage = "Моля изберете библиотека";
                CurentView = null;
            }
            
        }
        #endregion
    }
}
