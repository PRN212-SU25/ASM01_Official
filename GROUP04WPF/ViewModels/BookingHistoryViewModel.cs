using GROUP04DataAccess.Models;
using GROUP04DataAccess.Repositories;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;

namespace GROUP04WPF.ViewModels
{
    public class BookingHistoryViewModel : INotifyPropertyChanged
    {
        private ObservableCollection<BookingReservation> bookings;
        private readonly Customer customer;

        public ObservableCollection<BookingReservation> Bookings
        {
            get => bookings;
            set { bookings = value; OnPropertyChanged(nameof(Bookings)); }
        }

        public BookingHistoryViewModel(Customer customer)
        {
            this.customer = customer;
            Bookings = new ObservableCollection<BookingReservation>(BookingReservationRepository.Instance.GetAll().Where(b => b.CustomerID == customer.CustomerID));
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}