using GROUP04DataAccess.Models;
using GROUP04WPF.ViewModels;
using System.Windows;

namespace GROUP04WPF.Views
{
    public partial class ProfileView : Window
    {
        public ProfileView(Customer customer)
        {
            InitializeComponent();
            DataContext = new ProfileViewModel(customer);
        }
    }
}