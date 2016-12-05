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
        private List<HotelRoom> HotelRoomList 
        { 
            get
             { 
                return mHotelRoomList; 
             } 
            set{}
        }

        public HotelRoomModel() { }

        public HotelRoomModel(List<HotelRoom> hotelRoomList) 
        {
            hotelRoomList = HotelRoomList;
        }


    }
}
