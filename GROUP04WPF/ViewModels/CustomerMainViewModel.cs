using GROUP04DataAccess.Models;
using GROUP04WPF.Helpers;
using GROUP04WPF.Views;
using System.ComponentModel;
using System.Windows;
using System.Windows.Input;

namespace GROUP04WPF.ViewModels
{
    public class CustomerMainViewModel : INotifyPropertyChanged
    {
        private readonly Customer customer;

        public Customer Customer => customer;
        public ICommand ProfileCommand { get; }
        public ICommand BookingHistoryCommand { get; }
        public ICommand LogoutCommand { get; }

        public CustomerMainViewModel(Customer customer)
        {
            this.customer = customer;
            ProfileCommand = new RelayCommand(OpenProfile);
            BookingHistoryCommand = new RelayCommand(OpenBookingHistory);
            LogoutCommand = new RelayCommand(Logout);
        }

        private void OpenProfile()
        {
            new ProfileView(customer).ShowDialog();
        }

        private void OpenBookingHistory()
        {
            new BookingHistoryView(customer).ShowDialog();
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