using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace courseProject
{
    class FamelyRoom : HotelRoom
    {
        public FamelyRoom() { }

        public int NumberOfBeds { set; get; }
        public double PriceForChildRoom { set; get; }
        public bool HasChildRoom { set; get; }

        public double getPriceForChildRoom()
        {
            if (HasChildRoom == true)
            {
                return PriceForChildRoom;
            }
            else return 0;
        }
        public override double showPriceForRoom()
        {
            return PriceForRoom;
        }

    }
}
