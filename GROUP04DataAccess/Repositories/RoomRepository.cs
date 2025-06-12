using GROUP04DataAccess.Models;
using System.Collections.Generic;
using System.Linq;

namespace GROUP04DataAccess.Repositories
{
    public class RoomRepository
    {
        private static RoomRepository instance;
        private List<RoomInformation> rooms;

        private RoomRepository()
        {
            rooms = new List<RoomInformation>
            {
                new RoomInformation { RoomID = 1, RoomNumber = "2364", RoomDetailDescription = "A basic room with essential amenities, suitable for individual travelers or couples.", RoomMaxCapacity = 3, RoomTypeID = 1, RoomStatus = 1, RoomPricePerDay = 149.0000M },
                new RoomInformation { RoomID = 2, RoomNumber = "3345", RoomDetailDescription = "Deluxe rooms offer additional features such as a balcony or sea view, upgraded bedding, and improved décor.", RoomMaxCapacity = 5, RoomTypeID = 3, RoomStatus = 1, RoomPricePerDay = 299.0000M },
                new RoomInformation { RoomID = 3, RoomNumber = "4432", RoomDetailDescription = "A luxurious and spacious room with separate living and sleeping areas, ideal for guests seeking extra comfort and space.", RoomMaxCapacity = 4, RoomTypeID = 2, RoomStatus = 1, RoomPricePerDay = 199.0000M },
                new RoomInformation { RoomID = 5, RoomNumber = "3342", RoomDetailDescription = "Floor 3, Window in the North West", RoomMaxCapacity = 5, RoomTypeID = 5, RoomStatus = 1, RoomPricePerDay = 219.0000M },
                new RoomInformation { RoomID = 7, RoomNumber = "4434", RoomDetailDescription = "Floor 4, main window in the South", RoomMaxCapacity = 4, RoomTypeID = 1, RoomStatus = 1, RoomPricePerDay = 179.0000M }
            };
        }

        public static RoomRepository Instance => instance ?? (instance = new RoomRepository());

        public List<RoomInformation> GetAll() => rooms;
        public RoomInformation GetById(int id) => rooms.FirstOrDefault(r => r.RoomID == id);
        public void Add(RoomInformation room) => rooms.Add(room);
        public void Update(RoomInformation room)
        {
            var existing = GetById(room.RoomID);
            if (existing != null)
            {
                existing.RoomNumber = room.RoomNumber;
                existing.RoomDetailDescription = room.RoomDetailDescription;
                existing.RoomMaxCapacity = room.RoomMaxCapacity;
                existing.RoomTypeID = room.RoomTypeID;
                existing.RoomStatus = room.RoomStatus;
                existing.RoomPricePerDay = room.RoomPricePerDay;
            }
        }
        public void Delete(int id) => rooms.RemoveAll(r => r.RoomID == id);
        public List<RoomInformation> Search(string keyword) => rooms.Where(r => r.RoomNumber.Contains(keyword, StringComparison.OrdinalIgnoreCase) || r.RoomDetailDescription.Contains(keyword, StringComparison.OrdinalIgnoreCase)).ToList();
    }
}