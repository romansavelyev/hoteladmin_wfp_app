using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace courseProject.logic
{
    class HotelRoomModel
    {
        private List<HotelRoom> mHotelRoomList;
        public List<HotelRoom> HotelRoomList 
        { 
            get
             { 
                return mHotelRoomList; 
             }
            set { mHotelRoomList = value;  }
        }

        public HotelRoomModel() { }

        public HotelRoomModel(List<HotelRoom> hotelRoomList) 
        {
            HotelRoomList = hotelRoomList;
        }


    }
}
