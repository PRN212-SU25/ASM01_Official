using GROUP04WPF.ViewModels;
using System.Windows;

namespace GROUP04WPF.Views
{
    public partial class CustomerManagementView : Window
    {
        public CustomerManagementView()
        {
            InitializeComponent();
            DataContext = new CustomerManagementViewModel();
        }
    }
}