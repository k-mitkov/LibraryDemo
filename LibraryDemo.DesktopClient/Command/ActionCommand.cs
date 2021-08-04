using System;
using System.Windows.Input;

namespace LibraryDemo.DesktopClient.Command
{
    public class ActionCommand : ICommand
    {
        #region Declaration
        private readonly Action<object> execute;
        private readonly Func<object, bool> canExecute;
        #endregion

        #region Constructor
        public ActionCommand(Action<object> action, Func<object, bool> func)
        {
            execute = action;
            canExecute = func;
        }
        #endregion

        #region Proparties
        public event EventHandler CanExecuteChanged
        {
            add
            {
                CommandManager.RequerySuggested += value;
            }
            remove
            {
                CommandManager.RequerySuggested -= value;
            }
        }
        #endregion

        #region Methods
        public bool CanExecute(object parameter)
        {
            if (canExecute != null)
            {
                return canExecute(parameter);
            }
            else
            {
                return false;
            }
        }

        public void Execute(object parameter)
        {
            execute(parameter);
        }
        #endregion
    }
}
