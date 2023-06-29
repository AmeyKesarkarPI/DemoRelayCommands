using System;
using System.Windows.Input;

namespace Demo
{
    public class HomeViewModel : BaseViewModel
    {
        public string ProductName { get; set; }
        public string ProductName1 { get; set; }
        public ICommand SaveCommand{ get; set; }

        public HomeViewModel()
        {
            SaveCommand = new RelayCommand(OnSaveClick);
        }

        private void OnSaveClick(object obj)
        {
            ProductName1 = ProductName;
            OnPropertyChanged(nameof(ProductName1));
        }
    }
}