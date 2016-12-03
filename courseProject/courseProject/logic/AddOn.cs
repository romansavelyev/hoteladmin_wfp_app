using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using courseProject.CustomControls;

namespace courseProject.logic
{
    class AddOn
    {
        public static bool IsModelValid(HotelRoom RModel, Client CModel)
        {

            if (RModel as HotelRoom != null)
            {
                var room = RModel as HotelRoom;
                if (room.RoomClass != null && room.RoomClass.Length <= 20
                    && room.PriceForRoom >= 1)
                {
                    return true;
                }
            }

            if (CModel as Client != null)
            {
                var client = CModel as Client;
                if (client.AccomodationDate != null & client.CheckOutDate != null
                    && client.PassportData != null && client.RoomNumber != null)
                {
                    return true;
                }
            }

            return false;
        }


 
        public static void CompleteMsg(string someMsg = "")
        {
            if (string.IsNullOrEmpty(someMsg))
            {
                MessageBox.Show("Succes!");
                return;
            }

            MessageBox.Show(someMsg);
        }

    }
}
