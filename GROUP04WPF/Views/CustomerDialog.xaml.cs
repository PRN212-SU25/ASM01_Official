using GROUP04DataAccess.Models;
using System;
using System.Windows;

namespace GROUP04WPF.Views
{
    public partial class CustomerDialog : Window
    {
        public Customer Customer { get; set; }

        public CustomerDialog(Customer customer)
        {
            InitializeComponent();
            Customer = customer;
            DataContext = Customer;
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(Customer.CustomerFullName) || string.IsNullOrEmpty(Customer.EmailAddress) || string.IsNullOrEmpty(Customer.Password))
            {
                MessageBox.Show("Please fill in all required fields.");
                return;
            }
            DialogResult = true;
            Close();
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
            Close();
        }
    }
}