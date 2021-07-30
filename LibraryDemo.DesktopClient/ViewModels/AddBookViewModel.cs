using LibraryDemo.Data.Models;
using LibraryDemo.DesktopClient.Command;
using System;
using System.Collections.Generic;
using System.Windows.Controls;

namespace LibraryDemo.DesktopClient.ViewModels
{
    public class AddBookViewModel : BaseNotifyPropertyChangedViewModel
    {
        #region Declaration
        private Author _sauthor;
        private Library _slibrary;
        private string _title;
        private string _price;
        private ActionCommand addCommand;
        private decimal price;
        private UserControl currentView;
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

        public string Title
        {
            get { return _title; }
            set { _title = value; }
        }

        public string Price
        {
            get { return _price; }
            set { _price = value; }
        }

        public ActionCommand AddCommand
        {
            get
            {
                if (addCommand == null)
                {
                    addCommand = new ActionCommand(Add, CanExecuteShow);
                }
                return addCommand;
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
        #endregion

        #region Methods
        public bool CanExecuteShow(Object o)
        {
            return true;
        }

        public void Add(Object o)
        {
            if (ValidateInput())
            {
                var book = new Book
                {
                    Title = _title,
                    Author = _sauthor,
                    Price = price,
                    Library = _slibrary
                };
                context.AddNewBook(book);
            }
            //view.DataContext = viewModel;
            //CurentView = view;
        }
        
        private bool ValidateInput()
        {
            return _title != null && _title.Length > 2 && Decimal.TryParse(_price, out price) && price > 0;
        }
        #endregion
    }
}
