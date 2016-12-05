using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using courseProject.CustomControls;
using courseProject.logic;

namespace courseProject.logic
{
    class Settlement
    {
        private Dictionary<Client, HotelRoom> mClientSettlement;
        public Settlement() { mClientSettlement = new Dictionary<Client, HotelRoom>(); }

        public void clientSettlement(Client client, HotelRoom hotelRoom)
        {
            if (mClientSettlement.Count == 0)
                mClientSettlement.Add(client, hotelRoom);
            else
            {
                foreach (var newClient in mClientSettlement.Keys)
                {
                    if (newClient.RoomNumber == client.RoomNumber)
                        MessageBox.Show("This room is busym choose another one");
                    else
                        mClientSettlement.Add(client, hotelRoom);

                    
                }
            }
        }
    }
}
