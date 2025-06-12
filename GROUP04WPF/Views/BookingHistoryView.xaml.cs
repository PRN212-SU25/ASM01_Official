using GROUP04DataAccess.Models;
using GROUP04WPF.ViewModels;
using System.Windows;

namespace GROUP04WPF.Views
{
    public partial class BookingHistoryView : Window
    {
        public BookingHistoryView(Customer customer)
        {
            InitializeComponent();
            DataContext = new BookingHistoryViewModel(customer);
        }
    }
}