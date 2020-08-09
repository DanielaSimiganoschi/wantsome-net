using System;
using System.Collections.Generic;

namespace HotelApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Rate rateHotel11 = new Rate("EURO", 23);
            Rate rateHotel12 = new Rate("EURO", 29);

            Rate rateHotel21 = new Rate("ROM", 143);
            Rate rateHotel22 = new Rate("ROM", 223);

            Room room1 = new Room("Camera vedere mare", 2, 2, rateHotel11);
            Room room2 = new Room("Camera vedere munte", 2, 1, rateHotel12);
            Room room3 = new Room("Camera king vedere munte", 2, 0, rateHotel12);


            Room room4 = new Room("Camera vedere mare2", 2, 2, rateHotel21);
            Room room5 = new Room("Camera vedere munte2", 2, 1, rateHotel22);
            Room room6 = new Room("Camera king vedere munte2", 2, 0, rateHotel22);

            List<Room> roomsHotel1 = new List<Room> { room1, room2, room3 };

            List<Room> roomsHotel2 = new List<Room> { room4, room5, room6 };

            

            room1.GetPriceForDays(3);
            //room4.GetPriceForDays(3);

            Hotel hotelTraian = new Hotel("Traian", "Iasi", roomsHotel1);
            Hotel hotelInternational = new Hotel("International", "Iasi", roomsHotel2);

            //hotelTraian.PrintHotel();


            List<Hotel> hotels = new List<Hotel> { hotelInternational, hotelTraian };

            ListHotels listHotels = new ListHotels(hotels);

            // hotelTraian.getPriceForNumberOfRooms(roomsHotel1.Count);
            //hotelInternational.getPriceForNumberOfRooms(roomsHotel2.Count);
             listHotels.RemoveHotel("Traian", "Iasi");
            //hotelTraian.findRoomPriceLower(25);

            listHotels.PrintList();
        }
    }
}
