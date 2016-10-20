using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace courseProject
{
    abstract class Hotel
    {

        public Hotel()
        {
            ClientL = new List<Client>();
            HotelRoomL = new List<HotelRoom>();
        }


        public virtual List<Client> ClientL{get; set;}
        public virtual List<HotelRoom> HotelRoomL{get;set;} 
    }
}
