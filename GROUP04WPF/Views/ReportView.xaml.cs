using GROUP04WPF.ViewModels;
using System.Windows;

namespace GROUP04WPF.Views
{
    public partial class ReportView : Window
    {
        public ReportView()
        {
            InitializeComponent();
            DataContext = new ReportViewModel();
        }
    }
}