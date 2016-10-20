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

        public bool HaveChilden { set; get; }
        public int AmountOfChildren { set; get; }

        public override double showAmoutOfMoney() { return AmountOfMoney; }
    }
}
