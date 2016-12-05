using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace courseProject
{
    class GroupOfClients : Client
    {
        public GroupOfClients() { }

        public GroupOfClients(int passportData, int accomodationDate, int checkOutDate, int roomNumber, int amountOfPeople)
            :base()
        {
            amountOfPeople = AmountOfPeople;
        }

        public int AmountOfPeople { set; get; }
        public override double showAmoutOfMoney() { return AmountOfMoney * AmountOfPeople; }

    }
}
