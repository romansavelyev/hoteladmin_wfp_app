﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace courseProject
{
    class LoftApartment : HotelRoom
    {
        public LoftApartment() { }

        public int NumberOfRooms { set; get; }

        public override double showPriceForRoom()
        {
            return PriceForRoom;
        }


    }
}
