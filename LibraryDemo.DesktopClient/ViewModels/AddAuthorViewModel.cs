using LibraryDemo.Data.Models;
using LibraryDemo.DesktopClient.Command;
using LibraryDemo.DesktopClient.Views;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Controls;

namespace LibraryDemo.DesktopClient.ViewModels
{
    class AddAuthorViewModel : BaseNotifyPropertyChangedViewModel
    {
        #region Declaration
        private string _name;
        private string _gender;
        private string _mail;
        private ActionCommand addCommand;
        private UserControl currentView;
        private string errMasage;
        #endregion

        #region Proparties
        public IEnumerable<string> ListOfGenders
        {
            get
            {
                return content.Genders();
            }
        }

        public string SGender
        {
            get { return _gender; }
            set
            {
                _gender = value;
            }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string Mail
        {
            get { return _mail; }
            set { _mail = value; }
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

        public string NameContent
        {
            get
            {
                return content.NameHeader();
            }
        }
        public string GenderContent
        {
            get
            {
                return content.GenderHeader();
            }
        }
        public string MailContent
        {
            get
            {
                return content.MailHeader();
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

                var author = new Author()
                {
                    Name = _name,
                    Gender = content.GenderTranslate(_gender),
                    Email = _mail
                };

                context.AddNewAuthor(author);
                SuccessfulOperationViewModel viewModel = new SuccessfulOperationViewModel(content.SuccessfullyAddedAuthor());
                SuccessfulOperationView view = new SuccessfulOperationView();
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
            if (_name != null && _name.Length > 2)
            {
                if (_gender != null)
                {
                    if(_mail != null && _mail.Length > 4)
                    {
                        return true;
                    }
                    errMasage = content.ErrSelectMail();
                    return false;
                }
                errMasage = content.ErrSelectGender();
                return false;
            }
            errMasage = content.ErrSelectName();
            return false;
        }
        #endregion
    }
}
