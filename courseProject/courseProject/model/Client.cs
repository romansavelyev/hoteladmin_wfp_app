﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace courseProject
{
   abstract class Client : Hotel
    {
       public Client(){ }

       public Client(int passportData, int accomodationDate, int checkOutDate, int roomNumber)
       {
           passportData = PassportData;
           accomodationDate = AccomodationDate;
           checkOutDate = CheckOutDate;
           roomNumber = RoomNumber;
       }
       public virtual double showAmoutOfMoney() { return AmountOfMoney; }
       public int PassportData { get; set; }
       public double AmountOfMoney { get; set; }
       public int AccomodationDate { get; set; }
       public int CheckOutDate{get; set; }
       public int RoomNumber { get; set; }
    }
}
