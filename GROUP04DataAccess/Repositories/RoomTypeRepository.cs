using GROUP04DataAccess.Models;
using System.Collections.Generic;
using System.Linq;

namespace GROUP04DataAccess.Repositories
{
    public class RoomTypeRepository
    {
        private static RoomTypeRepository instance;
        private List<RoomType> roomTypes;

        private RoomTypeRepository()
        {
            roomTypes = new List<RoomType>
            {
                new RoomType { RoomTypeID = 1, RoomTypeName = "Standard room", TypeDescription = "This is typically the most affordable option and provides basic amenities such as a bed, dresser, and TV.", TypeNote = "N/A" },
                new RoomType { RoomTypeID = 2, RoomTypeName = "Suite", TypeDescription = "Suites usually offer more space and amenities than standard rooms, such as a separate living area, kitchenette, and multiple bathrooms.", TypeNote = "N/A" },
                new RoomType { RoomTypeID = 3, RoomTypeName = "Deluxe room", TypeDescription = "Deluxe rooms offer additional features such as a balcony or sea view, upgraded bedding, and improved décor.", TypeNote = "N/A" },
                new RoomType { RoomTypeID = 4, RoomTypeName = "Executive room", TypeDescription = "Executive rooms are designed for business travelers and offer perks such as free breakfast, evening drink, and high-speed internet.", TypeNote = "N/A" },
                new RoomType { RoomTypeID = 5, RoomTypeName = "Family Room", TypeDescription = "A room specifically designed to accommodate families, often with multiple beds and additional space for children.", TypeNote = "N/A" },
                new RoomType { RoomTypeID = 6, RoomTypeName = "Connecting Room", TypeDescription = "Two or more rooms with a connecting door, providing flexibility for larger groups or families traveling together.", TypeNote = "N/A" },
                new RoomType { RoomTypeID = 7, RoomTypeName = "Penthouse Suite", TypeDescription = "An extravagant, top-floor suite with exceptional views and exclusive amenities, typically chosen for special occasions or VIP guests.", TypeNote = "N/A" },
                new RoomType { RoomTypeID = 8, RoomTypeName = "Bungalow", TypeDescription = "A standalone cottage-style accommodation, providing privacy and a sense of seclusion often within a resort setting", TypeNote = "N/A" }
            };
        }

        public static RoomTypeRepository Instance => instance ?? (instance = new RoomTypeRepository());

        public List<RoomType> GetAll() => roomTypes;
        public RoomType GetById(int id) => roomTypes.FirstOrDefault(rt => rt.RoomTypeID == id);
    }
}