using GROUP04WPF.ViewModels;
using System.Windows;

namespace GROUP04WPF.Views
{
    public partial class AdminMainWindow : Window
    {
        public AdminMainWindow()
        {
            InitializeComponent();
            DataContext = new AdminMainViewModel();
        }
    }
}