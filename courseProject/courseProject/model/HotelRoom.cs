using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace courseProject
{
   abstract class HotelRoom : Hotel
    {       
        //private string mRoomClass;
        //private int mAmountOfPeople;
        //private double mPriceForRoom;

        public HotelRoom() {}

        public string RoomClass { set; get; }
        public int AmountOfPeople { set; get; }
        public double PriceForRoom { set; get; }

        public virtual double showPriceForRoom() { return PriceForRoom; }
    
    }
}
