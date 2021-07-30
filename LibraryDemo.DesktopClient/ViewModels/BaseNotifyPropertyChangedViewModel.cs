using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace LibraryDemo.DesktopClient.ViewModels
{
    public class BaseNotifyPropertyChangedViewModel : BaseViewModel , INotifyPropertyChanged
    {
        #region Declaration
        public event PropertyChangedEventHandler PropertyChanged;
        #endregion

        #region Methods
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion
    }
}
