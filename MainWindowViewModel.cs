using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace Demo
{
    public class MainWindowViewModel : BaseViewModel
    {

        public ICommand HiCommand { get; set; }
        public ICommand HelloCommand { get; set; }

        public ICommand HomeCommand { get; set; }
        public ICommand AboutCommand { get; set; }
        public ICommand GalleryCommand { get; set; }

        public string MyProperty { get; set; }

        public List<SongViewModel> SongsList { get; set; }


        public BaseViewModel ActiveView { get; set; }

        public MainWindowViewModel()
        {
            HiCommand = new RelayCommand(HiClick);
            HelloCommand = new RelayCommand(HelloClick);


            HomeCommand = new RelayCommand(HomeCommandClick);
            AboutCommand = new RelayCommand(AboutCommandClick);
            GalleryCommand = new RelayCommand(GalleryCommandClick);

            SongsList = new List<SongViewModel>() { new SongViewModel() { SongName = "SOmeting" } };
        }

        private void GalleryCommandClick(object obj)
        {
            ActiveView = new GalleryViewModel();
            OnPropertyChanged(nameof(ActiveView));
        }

        private void AboutCommandClick(object obj)
        {
            ActiveView = new AboutViewModel();
            OnPropertyChanged(nameof(ActiveView));
        }

        private void HomeCommandClick(object obj)
        {
            ActiveView = new HomeViewModel();
            OnPropertyChanged(nameof(ActiveView));
        }

       

        public void HiClick(object parameter)
        {
            MyProperty = "Hi";
            OnPropertyChanged(nameof(MyProperty));
        }


        public void HelloClick(object parameter)
        {
            MyProperty = "Hello";
            OnPropertyChanged(nameof(MyProperty));
        }
    }


    public class RelayCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;

        Action<object> vm;
        Action vm1;

        public RelayCommand(Action<object> _vm)
        {
            vm = _vm;
        }

        public RelayCommand(Action _vm)
        {
            vm1 = _vm;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            vm(parameter);
        }
    }
}
