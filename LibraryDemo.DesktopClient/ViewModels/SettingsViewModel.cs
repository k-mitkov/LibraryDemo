using LibraryDemo.DesktopClient.Command;
using LibraryDemo.DesktopClient.Resources.AppTextContent;
using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

namespace LibraryDemo.DesktopClient.ViewModels
{
    class SettingsViewModel : BaseNotifyPropertyChangedViewModel
    {

        #region Declaration
        private Languages s_language;
        private ActionCommand saveCommand;
        private UserControl currentView;
        #endregion

        #region Proparties
        public IEnumerable<Languages> ListOfLanguages
        {
            get
            {
                return AppContent.GetLanguages();
            }
        }

        public Languages Slanguage
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
            AppContent.SetLanguage(Slanguage);
            Application.Current.MainWindow.DataContext = new MainViewModel();
            
        }
        #endregion
    }
}
