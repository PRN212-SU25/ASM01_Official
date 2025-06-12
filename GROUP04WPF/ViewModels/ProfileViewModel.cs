using GROUP04DataAccess.Models;
using GROUP04DataAccess.Repositories;
using GROUP04WPF.Helpers;
using System.ComponentModel;
using System.Windows;
using System.Windows.Input;

namespace GROUP04WPF.ViewModels
{
    public class ProfileViewModel : INotifyPropertyChanged
    {
        private Customer customer;

        public Customer Customer
        {
            get => customer;
            set { customer = value; OnPropertyChanged(nameof(Customer)); }
        }

        public ICommand UpdateCommand { get; }

        public ProfileViewModel(Customer customer)
        {
            this.customer = new Customer
            {
                CustomerID = customer.CustomerID,
                CustomerFullName = customer.CustomerFullName,
                Telephone = customer.Telephone,
                EmailAddress = customer.EmailAddress,
                CustomerBirthday = customer.CustomerBirthday,
                CustomerStatus = customer.CustomerStatus,
                Password = customer.Password
            };
            UpdateCommand = new RelayCommand(UpdateProfile);
        }

        private void UpdateProfile()
        {
            CustomerRepository.Instance.Update(customer);
            MessageBox.Show("Profile updated successfully!");
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}