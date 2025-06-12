using GROUP04WPF.ViewModels;
using System.Windows;

namespace GROUP04WPF.Views
{
    public partial class RoomManagementView : Window
    {
        public RoomManagementView()
        {
            InitializeComponent();
            DataContext = new RoomManagementViewModel();
        }
    }
}