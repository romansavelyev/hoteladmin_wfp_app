﻿using System;
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
       public int AccomodationDate { get; set; }
       public int CheckOutDate{get; set; }
       public int RoomNumber { get; set; }
    }
}