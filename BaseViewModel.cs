using System.ComponentModel;

namespace Demo
{
    public class BaseViewModel : INotifyPropertyChanged
    {
        public string ViewTitle { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}