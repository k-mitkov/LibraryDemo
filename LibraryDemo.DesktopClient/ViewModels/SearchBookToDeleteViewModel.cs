using LibraryDemo.Data;
using LibraryDemo.DesktopClient.Command;
using LibraryDemo.DesktopClient.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Controls;

namespace LibraryDemo.DesktopClient.ViewModels
{
    class SearchBookToDeleteViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private BusinessContex context;

        public SearchBookToDeleteViewModel()
        {
            context = new BusinessContex();
        }

        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }



        private ActionCommand searchCommand;

        public ActionCommand SearchCommand
        {
            get
            {
                if (searchCommand == null)
                {
                    searchCommand = new ActionCommand(SearchToDelete, CanExecuteShow);
                }
                return searchCommand;
            }
        }
        public bool CanExecuteShow(Object o)
        {
            return true;
        }

        private string _keyWord;

        public string KeyWord
        {
            get { return _keyWord; }
            set
            {
                _keyWord = value;
            }
        }

        public void SearchToDelete(Object o)
        {
            DeleteBookViewModel viewModel = new DeleteBookViewModel(context.SearchForBooks(_keyWord));
            DeleteBookView view = new DeleteBookView();
            view.DataContext = viewModel;
            CurentView = view;

        }

        private UserControl currentView;
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

    }
}
