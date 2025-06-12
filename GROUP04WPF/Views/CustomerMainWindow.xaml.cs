using GROUP04DataAccess.Models;
using GROUP04WPF.ViewModels;
using System.Windows;

namespace GROUP04WPF.Views
{
    public partial class CustomerMainWindow : Window
    {
        public CustomerMainWindow(Customer customer)
        {
            InitializeComponent();
            DataContext = new CustomerMainViewModel(customer);
        }
    }
}