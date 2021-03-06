using LibraryDemo.DesktopClient.Views;
using System;
using System.Collections.Generic;

namespace LibraryDemo.DesktopClient.ViewModels
{
    class AddAuthorViewModel : BaseAddViewModel
    {
        #region Declaration
        private string _name;
        private string _gender;
        private string _mail;
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

        public string NameContent
        {
            get
            {
                return content.Name();
            }
        }
        public string GenderContent
        {
            get
            {
                return content.Gender();
            }
        }
        public string MailContent
        {
            get
            {
                return content.Mail();
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
                authorService.Add(_name, content.GenderTransformation(_gender), _mail);

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
            if (_name != null && _name.Trim().Length > 2 && _name.Length < 100)
            {
                if (_gender != null)
                {
                    if(_mail != null && _mail.Trim().Length > 4 && _mail.Length < 200)
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
