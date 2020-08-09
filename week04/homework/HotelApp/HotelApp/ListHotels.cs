using System;
using System.Collections.Generic;
using System.Text;

namespace HotelApp
{
    class ListHotels
    {

        public List<Hotel> hotels;
        public ListHotels(List<Hotel> hotels)
        {
            this.hotels = hotels;
        }
      
        public void RemoveHotel(string name, string city)
        {
            int i = 0;
           while(i<hotels.Count)
            {
                if(hotels[i].name == name && hotels[i].city == city)
                {
                    hotels.RemoveAt(i);
                    break;
                }
                else
                {
                    i++;
                }
            }
        }

        public void PrintList()
        {
            foreach(var hotel in this.hotels)
            {
                Console.WriteLine(hotel.name);
            }
        }
    }
}
