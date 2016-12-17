using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using courseProject.logic;
using courseProject.CustomControls;
using System.Windows;
using MySql.Data.MySqlClient;
using System.Data;

namespace courseProject.logic
{
    class DBcontroler
    {
        public static string connStr = "SERVER=localhost;DATABASE=test;UID=root;PASSWORD=root;";
        public MySqlConnection mConn = new MySqlConnection(connStr);

        private List<HotelRoom> mHotelRoomList = new List<HotelRoom>();
        private List<Client> mClientList = new List<Client>();

        public DBcontroler() { }

        public void DBconnect()
        {
            try
            {
                mConn.Open();
                MessageBox.Show("con");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void BDdisconnect()
        {
            try
            {
                mConn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public List<HotelRoom> showHotelRoomList()
        {
            MySqlCommand cmd = new MySqlCommand("select * from test.HotelRoom");

            using (MySqlDataReader dReader = cmd.ExecuteReader())
            {
                while (dReader.Read())
                {
                    HotelRoom room;
                    //TODO
                    Random rand = new Random();
                    int rng =  rand.Next(1, 4);
                    switch (rng)
                    {
                        case 1:
                        //case "Simple Apartment":
                            {
                                room = new SimpleApartment(dReader["roomClass"].ToString(),
                            Int32.Parse(dReader["amountOfPeople"].ToString()), Int32.Parse(dReader["priceForRoom"].ToString()),
                            Boolean.Parse(dReader["isVip"].ToString()), Double.Parse(dReader["priceForBonusDiner"].ToString()),
                            Double.Parse(dReader["priceForVipRoom"].ToString()));
                                break;
                            }
                       // case "Loft Apartment":
                        case 2:
                            {
                                room = new LoftApartment(dReader["roomClass"].ToString(),
                            Int32.Parse(dReader["amountOfPeople"].ToString()), Int32.Parse(dReader["priceForRoom"].ToString()),
                            Int32.Parse(dReader["numberOfRooms"].ToString()));
                                break;
                            }
                        //case "Family Apartment":
                        case 3:
                            {
                                room = new FamilyApartment(dReader["roomClass"].ToString(),
                            Int32.Parse(dReader["amountOfPeople"].ToString()), Int32.Parse(dReader["priceForRoom"].ToString()),
                            Int32.Parse(dReader["numberOfBeds"].ToString()), Double.Parse(dReader["priceForChildRoom"].ToString()),
                            Boolean.Parse(dReader["hasChildRoom"].ToString()));
                                break;
                            }
                        default:
                            {
                                room = new FamilyApartment(dReader["roomClass"].ToString(),
                            Int32.Parse(dReader["amountOfPeople"].ToString()), Int32.Parse(dReader["priceForRoom"].ToString()),
                            Int32.Parse(dReader["numberOfBeds"].ToString()), Double.Parse(dReader["priceForChildRoom"].ToString()),
                            Boolean.Parse(dReader["hasChildRoom"].ToString()));
                                break;
                            }
                    }
                    mHotelRoomList.Add(room);
                }
            }
            return mHotelRoomList;
        }
        public List<Client> showClientList()
        {
            MySqlCommand cmd = new MySqlCommand("select * from test.Client");

            using (MySqlDataReader dReader = cmd.ExecuteReader())
            {
                while (dReader.Read())
                {
                    Client client;
                    //TODO
                    Random rand = new Random();
                    int rng = rand.Next(1, 4);
                    switch (rng)
                    {
                        case 1:
                        //case "Single Client":
                            {
                                client = new SingleClient(Int32.Parse(dReader["passportData"].ToString()), Int32.Parse(dReader["accomodationDate"].ToString()),
                                    Int32.Parse(dReader["checkOutDate"].ToString()), Int32.Parse(dReader["roomNumber"].ToString()),
                                    Boolean.Parse(dReader["hasPet"].ToString()));
                                break;
                            }
                        case 2:
                       // case "Group of Clients":
                            {
                                client = new GroupOfClients(Int32.Parse(dReader["passportData"].ToString()), Int32.Parse(dReader["accomodationDate"].ToString()),
                                    Int32.Parse(dReader["checkOutDate"].ToString()), Int32.Parse(dReader["roomNumber"].ToString()),
                                    Int32.Parse(dReader["amountOfPeople"].ToString()));
                                break;
                            }
                        case 3:
                        //case "Family":
                            {
                                client = new CoupleClients(Int32.Parse(dReader["passportData"].ToString()), Int32.Parse(dReader["accomodationDate"].ToString()),
                                    Int32.Parse(dReader["checkOutDate"].ToString()), Int32.Parse(dReader["roomNumber"].ToString()),
                                    Boolean.Parse(dReader["haveChildren"].ToString()), Int32.Parse(dReader["amountOfChildren"].ToString()));
                                break;
                            }
                        default:
                            {
                                client = new CoupleClients(Int32.Parse(dReader["passportData"].ToString()), Int32.Parse(dReader["accomodationDate"].ToString()),
                                    Int32.Parse(dReader["checkOutDate"].ToString()), Int32.Parse(dReader["roomNumber"].ToString()),
                                    Boolean.Parse(dReader["haveChildren"].ToString()), Int32.Parse(dReader["amountOfChildren"].ToString()));
                                break;
                            }
                    }
                    mClientList.Add(client);
                }
            }
            return mClientList;
        }
    }
}

