using System;
using System.Collections.Generic;
using System.Text;

namespace HotelApp
{
    class Hotel
    {

        public string name { get; private set; }
        public string city { get; private set; }
        private List<Room> rooms;
        public int priceForNumberOfRooms = 0;
       


        public Hotel(string name, string city, List<Room> rooms)
        {
            this.name = name;
            this.city = city;
            this.rooms = rooms;
            foreach(var room in rooms)
            {
                priceForNumberOfRooms += room.rate.ammount;
            }
        }

        public void  findRoomPriceLower(int price)
        {
            foreach(var room in rooms)
            {
                if (room.rate.ammount < price)
                {
                    room.Print();
                }
            }

        }

        public void getPriceForNumberOfRooms(int numberOfRooms)
        {
            Console.WriteLine($"Price for number of rooms {priceForNumberOfRooms}");
        }

        public void PrintHotel()
        {
            Console.WriteLine($"The name of the Hotel is {this.name}, it can be found in {this.city} it has these rooms:");
            foreach (var room in rooms)
            {
                    room.Print();
                
            }
        }

    }
}
