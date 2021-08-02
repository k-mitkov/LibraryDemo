using LibraryDemo.Data.Models;
using LibraryDemo.DesktopClient.Command;
using LibraryDemo.DesktopClient.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Controls;

namespace LibraryDemo.DesktopClient.ViewModels
{
    public class BooksByLibraryViewModel : BaseNotifyPropertyChangedViewModel
    {
        #region Declaraion
        private Library selected;
        private ActionCommand showCommand;
        private UserControl currentView;
        private string errMasage;
        #endregion

        #region Proparties
        public IEnumerable<Library> ListOfT
        {
            get
            {
                return context.GetLibraries().ToList();
            }
        }

        public Library Selected
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
                return content.SelectLibrayText();
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
            if (selected != null)
            {
                ErrMasage = "";
                ShowBooksByLibraryViewModel viewModel = new ShowBooksByLibraryViewModel(selected);
                ShowBooksView view = new ShowBooksView();
                view.DataContext = viewModel;
                CurentView = view;
            }
            else
            {
                ErrMasage = content.ErrSelectLibrary();
                CurentView = null;
            }
            
        }
        #endregion
    }
}
