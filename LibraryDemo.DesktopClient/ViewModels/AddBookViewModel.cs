using LibraryDemo.Data.Models;
using LibraryDemo.DesktopClient.Command;
using LibraryDemo.DesktopClient.Views;
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
                SuccessfulAddedBookViewModel viewModel = new SuccessfulAddedBookViewModel();
                SuccessfulAddedBookView view = new SuccessfulAddedBookView();
                view.DataContext = viewModel;
                CurentView = view;
            }
            else
            {
                ErrMasage = errMasage;
            }
        }
        
        private bool ValidateInput()
        {
            if(_title != null && _title.Length > 2)
            {
                if(Decimal.TryParse(_price, out price) && price > 0)
                {
                    if (_sauthor != null)
                    {
                        if(_slibrary != null)
                        {
                            return true;
                        }
                        errMasage = "Моля изберете библиотека!";
                        return false;

                    }
                    errMasage = "Моля изберете автор!";
                    return false;
                }
                errMasage = "Цената тябва да е по-голяма от 0 и изписана с цифри.";
                return false;
            }
            errMasage = "Заглавието трябва да е поне 3 символа.";
            return false;
        }
        #endregion
    }
}
