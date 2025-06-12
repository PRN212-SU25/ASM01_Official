using GROUP04DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace GROUP04DataAccess.Repositories
{
    public class BookingDetailRepository
    {
        private static BookingDetailRepository instance;
        private List<BookingDetail> bookingDetails;

        private BookingDetailRepository()
        {
            bookingDetails = new List<BookingDetail>
            {
                new BookingDetail { BookingReservationID = 1, RoomID = 3, StartDate = new DateTime(2024, 1, 1), EndDate = new DateTime(2024, 1, 2), ActualPrice = 199.0000M },
                new BookingDetail { BookingReservationID = 1, RoomID = 7, StartDate = new DateTime(2024, 1, 1), EndDate = new DateTime(2024, 1, 2), ActualPrice = 179.0000M },
                new BookingDetail { BookingReservationID = 2, RoomID = 3, StartDate = new DateTime(2024, 1, 5), EndDate = new DateTime(2024, 1, 6), ActualPrice = 199.0000M },
                new BookingDetail { BookingReservationID = 2, RoomID = 5, StartDate = new DateTime(2024, 1, 5), EndDate = new DateTime(2024, 1, 9), ActualPrice = 219.0000M }
            };
        }

        public static BookingDetailRepository Instance => instance ?? (instance = new BookingDetailRepository());

        public List<BookingDetail> GetAll() => bookingDetails;
        public List<BookingDetail> GetByReservationId(int reservationId) => bookingDetails.Where(bd => bd.BookingReservationID == reservationId).ToList();
        public void Add(BookingDetail detail) => bookingDetails.Add(detail);
        public void Delete(int reservationId, int roomId) => bookingDetails.RemoveAll(bd => bd.BookingReservationID == reservationId && bd.RoomID == roomId);
    }
}