using LibraryDemo.DesktopClient.Command;
using LibraryDemo.DesktopClient.Resources.AppTextContent;
using LibraryDemo.DesktopClient.Views;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;

namespace LibraryDemo.DesktopClient.ViewModels
{
    class SettingsViewModel : BaseNotifyPropertyChangedViewModel
    {

        #region Declaration
        private string s_language;
        private string errMasage;
        private ActionCommand saveCommand;
        private UserControl currentView;
        #endregion

        #region Proparties
        public IEnumerable<string> ListOfLanguages
        {
            get
            {
                List<string> languages = new List<string> { "English", "Български"};
                return languages;
            }
        }

        public string Slanguage
        {
            get { return s_language; }
            set
            {
                s_language = value;
            }
        }

        public string SelectLanguage
        {
            get
            {
                return content.SelectLanguageText();
            }
        }

        public string SaveButtonContent
        {
            get
            {
                return content.SaveButton();
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
        public ActionCommand SaveCommand
        {
            get
            {
                if (saveCommand == null)
                {
                    saveCommand = new ActionCommand(Save, CanExecuteShow);
                }
                return saveCommand;
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

        public void Save(Object o)
        {
            if (s_language != null)
            {
                ErrMasage = "";
                AppContent.SetLanguage(Slanguage);
                Application.Current.MainWindow.DataContext = new MainViewModel();
            }
            else
            {
                ErrMasage = content.ErrSelectLanguage();
            }
        }
        #endregion
    }
}
