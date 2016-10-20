using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace courseProject
{
    class SimpleApartment : HotelRoom
    {
        public SimpleApartment() { }

        public bool isVip { set; get; }
        public double PriceForBonusDinner { set; get; }
        public double PriceForVipRoom { set; get; }
        public double getPriceForBonusDinner()
        {
            if (isVip == true)
            {
                return PriceForBonusDinner + PriceForVipRoom;
            }
            else return 0;
        }

        public override double showPriceForRoom()
        {
            return PriceForRoom + getPriceForBonusDinner() ;
        }

    }
}
