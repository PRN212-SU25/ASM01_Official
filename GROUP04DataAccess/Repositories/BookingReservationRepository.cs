using GROUP04DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace GROUP04DataAccess.Repositories
{
    public class BookingReservationRepository
    {
        private static BookingReservationRepository instance;
        private List<BookingReservation> bookings;

        private BookingReservationRepository()
        {
            bookings = new List<BookingReservation>
            {
                new BookingReservation { BookingReservationID = 1, BookingDate = new DateTime(2023, 12, 20), TotalPrice = 378.0000M, CustomerID = 3, BookingStatus = 1 },
                new BookingReservation { BookingReservationID = 2, BookingDate = new DateTime(2023, 12, 21), TotalPrice = 1493.0000M, CustomerID = 3, BookingStatus = 1 }
            };
        }

        public static BookingReservationRepository Instance => instance ?? (instance = new BookingReservationRepository());

        public List<BookingReservation> GetAll() => bookings;
        public BookingReservation GetById(int id) => bookings.FirstOrDefault(b => b.BookingReservationID == id);
        public void Add(BookingReservation booking) => bookings.Add(booking);
        public void Update(BookingReservation booking)
        {
            var existing = GetById(booking.BookingReservationID);
            if (existing != null)
            {
                existing.BookingDate = booking.BookingDate;
                existing.TotalPrice = booking.TotalPrice;
                existing.CustomerID = booking.CustomerID;
                existing.BookingStatus = booking.BookingStatus;
            }
        }
        public void Delete(int id) => bookings.RemoveAll(b => b.BookingReservationID == id);
        public List<BookingReservation> GetByDateRange(DateTime startDate, DateTime endDate)
        {
            return bookings.Where(b => b.BookingDate >= startDate && b.BookingDate <= endDate)
                           .OrderByDescending(b => b.TotalPrice)
                           .ToList();
        }
    }
}