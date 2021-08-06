using LibraryDemo.DesktopClient.BusinessModels;
using LibraryDemo.DesktopClient.Views;
using System;
using System.Collections.Generic;

namespace LibraryDemo.DesktopClient.ViewModels
{
    public class AddBookViewModel : BaseAddViewModel
    {
        #region Declaration
        private BAuthor _sauthor;
        private BLibrary _slibrary;
        private string _title;
        private string _price;
        private decimal price;
        #endregion

        #region Proparties
        public IEnumerable<BAuthor> ListOfAuthors
        {
            get
            {
                return authorService.GetAuthors();
            }
        }

        public BAuthor SAuthor
        {
            get { return _sauthor; }
            set
            {
                _sauthor = value;
            }
        }

        public IEnumerable<BLibrary> ListOfLibraries
        {
            get
            {
                return libraryService.GetLibraries();
            }
        }

        public BLibrary SLibrary
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

        public string TitleContent
        {
            get
            {
                return content.Title();
            }
        }
        public string AuthorContent
        {
            get
            {
                return content.Author();
            }
        }
        public string PriceContent
        {
            get
            {
                return content.Price();
            }
        }
        public string LibraryContent
        {
            get
            {
                return content.Library();
            }
        }
        public string AddButtonContent
        {
            get
            {
                return content.Add();
            }
        }
        #endregion

        #region Methods
        public override void Add(Object o)
        {
            if (ValidateInput())
            {
                bookService.Add(_title, _sauthor, price, _slibrary);

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
