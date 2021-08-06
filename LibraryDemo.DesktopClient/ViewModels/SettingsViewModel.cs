using LibraryDemo.DesktopClient.Command;
using LibraryDemo.DesktopClient.Resources.AppTextContent;
using System;
using System.Collections.Generic;
using System.Windows;

namespace LibraryDemo.DesktopClient.ViewModels
{
    class SettingsViewModel : BaseViewModel
    {

        #region Declaration
        private Languages s_language;
        private ActionCommand saveCommand;
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
                return content.SelectLanguage();
            }
        }

        public string SaveButtonContent
        {
            get
            {
                return content.Save();
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
