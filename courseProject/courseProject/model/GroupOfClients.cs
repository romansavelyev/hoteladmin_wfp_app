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
        public int AmountOfPeople { set; get; }
        public override double showAmoutOfMoney() { return AmountOfMoney * AmountOfPeople; }

    }
}
