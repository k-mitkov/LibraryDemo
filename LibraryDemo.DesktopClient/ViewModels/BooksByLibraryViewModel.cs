using LibraryDemo.Data;
using LibraryDemo.Data.Models;
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
    public class BooksByLibraryViewModel : INotifyPropertyChanged 
    {
        private BusinessContex context;
        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public BooksByLibraryViewModel()
        {
            context = new BusinessContex();
        }

        public List<Library> ListOfLibraries
        {
            get
            {
                return context.GetLibraries();
            }
        }

        private Library _slibrary;

        public Library SLibrary
        {
            get { return _slibrary; }
            set
            {
                _slibrary = value;
            }
        }

        private ActionCommand showCommand;

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
        public bool CanExecuteShow(Object o)
        {
            return true;
        }

        public void Show(Object o)
        {
            ShowBooksByLibraryViewModel viewModel = new ShowBooksByLibraryViewModel(_slibrary);
            AllBooksView view = new AllBooksView();
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
