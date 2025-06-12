using GROUP04WPF.Helpers;
using GROUP04WPF.Views;
using System.ComponentModel;
using System.Windows;
using System.Windows.Input;

namespace GROUP04WPF.ViewModels
{
    public class AdminMainViewModel : INotifyPropertyChanged
    {
        public ICommand CustomerManagementCommand { get; }
        public ICommand RoomManagementCommand { get; }
        public ICommand ReportCommand { get; }
        public ICommand LogoutCommand { get; }

        public AdminMainViewModel()
        {
            CustomerManagementCommand = new RelayCommand(OpenCustomerManagement);
            RoomManagementCommand = new RelayCommand(OpenRoomManagement);
            ReportCommand = new RelayCommand(OpenReport);
            LogoutCommand = new RelayCommand(Logout);
        }

        private void OpenCustomerManagement()
        {
            new CustomerManagementView().ShowDialog();
        }

        private void OpenRoomManagement()
        {
            new RoomManagementView().ShowDialog();
        }

        private void OpenReport()
        {
            new ReportView().ShowDialog();
        }

        private void Logout()
        {
            new LoginView().Show();
            Application.Current.Windows[0].Close();
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}