using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace courseProject
{
   abstract class Client : Hotel
    {
       //private int mPassportData;
       //private int mAccomodationDate;
       //private int mCheckOutDate;
       //private int mRoomNumber;

       public Client(){ }

       public virtual double showAmoutOfMoney() { return AmountOfMoney; }
       public int PassportData { get; set; }
       public double AmountOfMoney { get; set; }
       private int AccomodationDate { get; set; }
       private int CheckOutDate{get; set; }
       private int RoomNumber { get; set; }
    }
}
