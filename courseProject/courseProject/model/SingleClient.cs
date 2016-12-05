using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace courseProject
{
    class SingleClient : Client
    {
        public SingleClient() { }
        public SingleClient(int passportData, int accomodationDate, int checkOutDate, int roomNumber,bool hasPet)
            :base()
        {
            hasPet = HasPet;
        }


        public bool HasPet { set; get; }


        public override double showAmoutOfMoney() { return AmountOfMoney; }
    }
}
