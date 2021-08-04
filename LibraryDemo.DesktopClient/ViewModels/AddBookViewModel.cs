using LibraryDemo.Data.Models;
using LibraryDemo.DesktopClient.Command;
using LibraryDemo.DesktopClient.Views;
using System;
using System.Collections.Generic;
using System.Linq;
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
        public IEnumerable<Author> ListOfAuthors
        {
            get
            {
                return context.GetAuthors().ToList();
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

        public IEnumerable<Library> ListOfLibraries
        {
            get
            {
                return context.GetLibraries().ToList();
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

        public string TitleContent
        {
            get
            {
                return content.TitleHeader();
            }
        }
        public string AuthorContent
        {
            get
            {
                return content.AuthorHeader();
            }
        }
        public string PriceContent
        {
            get
            {
                return content.PriceHeader();
            }
        }
        public string LibraryContent
        {
            get
            {
                return content.LibraryHeader();
            }
        }
        public string AddButtonContent
        {
            get
            {
                return content.AddButton();
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
                SuccessfulOperationViewModel viewModel = new SuccessfulOperationViewModel(content.SuccessfullyAddedBook());
                SuccessfulOperationView  view = new SuccessfulOperationView();
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
                if(decimal.TryParse(_price, out price) && price > 0)
                {
                    if (_sauthor != null)
                    {
                        if(_slibrary != null)
                        {
                            return true;
                        }
                        errMasage = content.ErrSelectLibrary();
                        return false;

                    }
                    errMasage = content.ErrSelectAuthor();
                    return false;
                }
                errMasage = content.ErrSelectPrice();
                return false;
            }
            errMasage = content.ErrSelectTitle();
            return false;
        }
        #endregion
    }
}
