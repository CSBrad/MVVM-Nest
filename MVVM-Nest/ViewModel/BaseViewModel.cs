using MVVM_Nest.Services.Commands;
using System.ComponentModel;
using System.Windows.Input;

namespace MVVM_Nest.ViewModel
{
    public class BaseViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        // Common command implementation
        protected ICommand CreateCommand(Action execute)
        {
            return new RelayCommand(execute);
        }
    }
}
