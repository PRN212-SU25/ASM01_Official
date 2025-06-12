using GROUP04DataAccess.Models;
using GROUP04DataAccess.Repositories;
using GROUP04WPF.Helpers;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Windows;
using System.Windows.Input;
using GROUP04WPF.Views; // Thêm dòng này nếu thiếu

namespace GROUP04WPF.ViewModels
{
    public class CustomerManagementViewModel : INotifyPropertyChanged
    {
        private ObservableCollection<Customer> customers;
        private Customer selectedCustomer;
        private string searchKeyword;

        public ObservableCollection<Customer> Customers
        {
            get => customers;
            set { customers = value; OnPropertyChanged(nameof(Customers)); }
        }
        public Customer SelectedCustomer
        {
            get => selectedCustomer;
            set { selectedCustomer = value; OnPropertyChanged(nameof(SelectedCustomer)); }
        }
        public string SearchKeyword
        {
            get => searchKeyword;
            set { searchKeyword = value; OnPropertyChanged(nameof(SearchKeyword)); SearchCustomers(); }
        }

        public ICommand AddCommand { get; }
        public ICommand UpdateCommand { get; }
        public ICommand DeleteCommand { get; }

        public CustomerManagementViewModel()
        {
            Customers = new ObservableCollection<Customer>(CustomerRepository.Instance.GetAll());
            AddCommand = new RelayCommand(AddCustomer);
            UpdateCommand = new RelayCommand(UpdateCustomer, () => SelectedCustomer != null);
            DeleteCommand = new RelayCommand(DeleteCustomer, () => SelectedCustomer != null);
        }

        private void AddCustomer()
        {
            var customer = new Customer { CustomerID = CustomerRepository.Instance.GetAll().Max(c => c.CustomerID) + 1 };
            var dialog = new CustomerDialog(customer);
            if (dialog.ShowDialog() == true)
            {
                CustomerRepository.Instance.Add(customer);
                Customers.Add(customer);
            }
        }

        private void UpdateCustomer()
        {
            if (SelectedCustomer != null)
            {
                var dialog = new CustomerDialog(SelectedCustomer);
                if (dialog.ShowDialog() == true)
                {
                    CustomerRepository.Instance.Update(SelectedCustomer);
                    Customers = new ObservableCollection<Customer>(CustomerRepository.Instance.GetAll());
                }
            }
        }

        private void DeleteCustomer()
        {
            if (SelectedCustomer != null && MessageBox.Show($"Are you sure to delete {SelectedCustomer.CustomerFullName}?", "Confirm Delete", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                CustomerRepository.Instance.Delete(SelectedCustomer.CustomerID);
                Customers.Remove(SelectedCustomer);
            }
        }

        private void SearchCustomers()
        {
            Customers = new ObservableCollection<Customer>(CustomerRepository.Instance.Search(SearchKeyword ?? ""));
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}

