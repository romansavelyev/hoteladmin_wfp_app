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

        public bool HasPet { set; get; }


        public override double showAmoutOfMoney() { return AmountOfMoney; }
    }
}
