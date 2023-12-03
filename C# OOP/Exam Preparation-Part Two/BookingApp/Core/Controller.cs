using BookingApp.Core.Contracts;
using BookingApp.Models.Hotels;
using BookingApp.Models.Hotels.Contacts;
using BookingApp.Models.Rooms;
using BookingApp.Models.Rooms.Contracts;
using BookingApp.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingApp.Core
{
    public class Controller : IController
    {
        private RoomRepository rooms;
        private BookingRepository bookings;
        private HotelRepository hotels;

        public Controller()
        {
            rooms = new RoomRepository();
            bookings = new BookingRepository();
            hotels = new HotelRepository();
        }

        public string AddHotel(string hotelName, int category)
        {
            IHotel hotel = hotels.Select(hotelName);

            if (hotel != null)
            {
                return $"Hotel {hotelName} is already registered in our platform.";
            }

            hotel = new Hotel(hotelName, category);

            hotels.AddNew(hotel);

            return $"{category} stars hotel {hotelName} is registered in our platform and expects room availability to be uploaded.";
        }

        public string BookAvailableRoom(int adults, int children, int duration, int category)
        {
            throw new NotImplementedException();
        }

        public string HotelReport(string hotelName)
        {
            throw new NotImplementedException();
        }

        public string SetRoomPrices(string hotelName, string roomTypeName, double price)
        {
            throw new NotImplementedException();
        }

        public string UploadRoomTypes(string hotelName, string roomTypeName)
        {
            IHotel hotel = hotels.Select(hotelName);
            IRoom room = hotel.Rooms.Select(roomTypeName);

            if (hotel == null)
            {
                return $"Profile {hotelName} doesn’t exist!";
            }
            if (room != null)
            {
                return $"Room type is already created!";
            }
            if (roomTypeName != typeof(Apartment).Name && roomTypeName != typeof(Studio).Name && roomTypeName != typeof(DoubleBed).Name)
            {
                throw new ArgumentException("Incorrect room type!");
            }
            if (roomTypeName == typeof(Apartment).Name)
            {
                room = new Apartment();
            }
            if (roomTypeName == typeof(Studio).Name)
            {
                room = new Studio();
            }
            if (roomTypeName == typeof(DoubleBed).Name)
            {
                room = new DoubleBed();
            }
            
            rooms.AddNew(room);

            return $"Successfully added {roomTypeName} room type in {hotelName} hotel!";
        }
    }
}
