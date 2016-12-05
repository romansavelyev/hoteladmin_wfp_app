using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace courseProject
{
    class CoupleClients : Client
    {
        public CoupleClients(){}
        
        public CoupleClients(int passportData, int accomodationDate, int checkOutDate, int roomNumber,bool haveChildren, int amountOfChildren)
            :base()
        {
            haveChildren = HaveChildren;
            amountOfChildren = AmountOfChildren;
        }

        public bool HaveChildren { set; get; }
        public int AmountOfChildren { set; get; }

        public override double showAmoutOfMoney() { return AmountOfMoney; }
    }
}
