using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace courseProject
{
   abstract class HotelRoom : Hotel
    {       
        public HotelRoom() {}

        public HotelRoom(string roomClass, int amountOfPeople, double priceForRoom)
        {
            roomClass = RoomClass;
            amountOfPeople = AmountOfPeople;
            priceForRoom = PriceForRoom;
        }
        public string RoomClass { set; get; }
        public int AmountOfPeople { set; get; }
        public double PriceForRoom { set; get; }

        public virtual double showPriceForRoom() { return PriceForRoom; }
    
    }
}
