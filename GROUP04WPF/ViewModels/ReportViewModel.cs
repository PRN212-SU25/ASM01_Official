using GROUP04DataAccess.Models;
using GROUP04DataAccess.Repositories;
using GROUP04WPF.Helpers;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Input;

namespace GROUP04WPF.ViewModels
{
    public class ReportViewModel : INotifyPropertyChanged
    {
        private DateTime startDate;
        private DateTime endDate;
        private ObservableCollection<BookingReservation> bookings;

        public DateTime StartDate
        {
            get => startDate;
            set { startDate = value; OnPropertyChanged(nameof(StartDate)); }
        }
        public DateTime EndDate
        {
            get => endDate;
            set { endDate = value; OnPropertyChanged(nameof(EndDate)); }
        }
        public ObservableCollection<BookingReservation> Bookings
        {
            get => bookings;
            set { bookings = value; OnPropertyChanged(nameof(Bookings)); }
        }

        public ICommand GenerateReportCommand { get; }

        public ReportViewModel()
        {
            StartDate = DateTime.Today.AddMonths(-1);
            EndDate = DateTime.Today;
            Bookings = new ObservableCollection<BookingReservation>();
            GenerateReportCommand = new RelayCommand(GenerateReport);
        }

        private void GenerateReport()
        {
            Bookings = new ObservableCollection<BookingReservation>(BookingReservationRepository.Instance.GetByDateRange(StartDate, EndDate));
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}