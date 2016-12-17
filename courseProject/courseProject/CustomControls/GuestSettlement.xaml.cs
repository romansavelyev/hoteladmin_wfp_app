using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Data;
using MySql.Data.MySqlClient;
using courseProject.logic;
using courseProject.CustomControls;

namespace courseProject.CustomControls
{
    /// <summary>
    /// Interaction logic for GuestSettlement.xaml
    /// </summary>
    public partial class GuestSettlement : UserControl
    {
        public GuestSettlement()
        {
            InitializeComponent();    
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var element = roomSettle_RoomType_ComboBox.SelectedItem.ToString().Split(':')[1].Substring(1);

            try
            {
                switch (element)
                {
                    case ("Simple Apartment"):
                        roomSettle_VIP_CheckBox.IsEnabled = true;
                        roomSettle_PriceForDiner_TextBox.IsEnabled = true;
                        roomSettle_PriceForVIP_TextBox.IsEnabled = true;
                        roomSettle_ChildRoom_CheckBox.IsEnabled = false;
                        roomSettle_NumOfBeds_TextBox.IsEnabled = false;
                        roomSettle_PriceForChildRoom_TextBox.IsEnabled = false;
                        roomSettle_NumOfRooms_TextBox.IsEnabled = false;
                        roomSettle_Family_Button.IsEnabled = false;
                        roomSettle_LoftApart_Button.IsEnabled = false;
                        roomSettle_SimpleApart_Button.IsEnabled = true;
                        break;
                    
                    case ("Loft Apartment"):
                        roomSettle_VIP_CheckBox.IsEnabled = false;
                        roomSettle_PriceForDiner_TextBox.IsEnabled = false;
                        roomSettle_PriceForVIP_TextBox.IsEnabled = false;
                        roomSettle_ChildRoom_CheckBox.IsEnabled = false;
                        roomSettle_NumOfBeds_TextBox.IsEnabled = false;
                        roomSettle_PriceForChildRoom_TextBox.IsEnabled = false;
                        roomSettle_NumOfRooms_TextBox.IsEnabled = true;
                        roomSettle_Family_Button.IsEnabled = false;
                        roomSettle_LoftApart_Button.IsEnabled = true;
                        roomSettle_SimpleApart_Button.IsEnabled = false;
                        break;

                    case ("Family Apartment"):
                        roomSettle_VIP_CheckBox.IsEnabled = false;
                        roomSettle_PriceForDiner_TextBox.IsEnabled = false;
                        roomSettle_PriceForVIP_TextBox.IsEnabled = false;
                        roomSettle_ChildRoom_CheckBox.IsEnabled = true;
                        roomSettle_NumOfBeds_TextBox.IsEnabled = true;
                        roomSettle_PriceForChildRoom_TextBox.IsEnabled = true;
                        roomSettle_NumOfRooms_TextBox.IsEnabled = false;
                        roomSettle_Family_Button.IsEnabled = true;
                        roomSettle_LoftApart_Button.IsEnabled = false;
                        roomSettle_SimpleApart_Button.IsEnabled = false;
                        break;
                    
                    default:
                        MessageBox.Show("Select room type!");
                        break;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Something gone wrong!");
            }
        }
       

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var element = clientSettle_ClientType_ComboBox.SelectedItem.ToString().Split(':')[1].Substring(1);
            
            try
            {
                switch (element)
                {
                    case ("Single Client"):
                        clientSettle_Pet_CheckBox.IsEnabled = true;
                        clientSettle_NumberOfPeople_TextBox.IsEnabled = false;
                        clientSettle_Childrens_CheckBox.IsEnabled = false;
                        clientSettle_NumberOfChildren_TextBox.IsEnabled = false;
                        clientSettle_Family_Button.IsEnabled = false;
                        clientSettle_GroupOfClients_Button.IsEnabled = false;
                        clientSettle_SingleClient_Button.IsEnabled = true;
                      
                        break;

                    case ("Group of Clients"):
                        clientSettle_Pet_CheckBox.IsEnabled = false;
                        clientSettle_NumberOfPeople_TextBox.IsEnabled = true;
                        clientSettle_Childrens_CheckBox.IsEnabled = false;
                        clientSettle_NumberOfChildren_TextBox.IsEnabled = false;
                        clientSettle_Family_Button.IsEnabled = false;
                        clientSettle_GroupOfClients_Button.IsEnabled = true;
                        clientSettle_SingleClient_Button.IsEnabled = false;
                        break;

                    case ("Family"):
                        clientSettle_Pet_CheckBox.IsEnabled = false;
                        clientSettle_NumberOfPeople_TextBox.IsEnabled = false;
                        clientSettle_Childrens_CheckBox.IsEnabled = true;
                        clientSettle_NumberOfChildren_TextBox.IsEnabled = true;
                        clientSettle_Family_Button.IsEnabled = true;
                        clientSettle_GroupOfClients_Button.IsEnabled = false;
                        clientSettle_SingleClient_Button.IsEnabled = false;
                        break;

                    default:
                        break;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Something gone wrong!");
            }
        }
        private DBcontroler mDB = new DBcontroler();
        public static string connStr = "SERVER=localhost;DATABASE=HotelDB;UID=root;PASSWORD=root;";
        public MySqlConnection con = new MySqlConnection(connStr);
       
        

        private void clientSettle_Ok_Button_Click(object sender, RoutedEventArgs e)
        {
        }

        private void roomSettle_SimpleApart_Button_Click(object sender, RoutedEventArgs e)
        {
            DataTable dt = new DataTable();
            try
            {
                bool flag = false;
                if(roomSettle_VIP_CheckBox.IsChecked.Value == true){
                    flag  = true;
                }
                
                con.Open();
                string command = "insert into HotelDB.SimpleApart(PriceForRoom,RoomClass,IsVip,PriceForBonusDinner,PriceForVipRoom,AmountOfPeople) values(" +
                    roomSettle_PriceForRoom_TextBox.Text.ToString() + ",'" + roomSettle_RoomClass_TextBox.Text.ToString() + "'," +
                    flag.ToString() + ","+ roomSettle_PriceForDiner_TextBox.Text.ToString()+","+ roomSettle_PriceForVIP_TextBox.Text.ToString()
                    +","+roomSettle_NumOfPeople_TextBox.Text.ToString()+");";

                MySqlCommand cmd = new MySqlCommand(command, con);
                dt.Load(cmd.ExecuteReader());
                MessageBox.Show("Succesfully Inserted");
                con.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void roomSettle_Family_Button_Click(object sender, RoutedEventArgs e)
        {
            DataTable dt = new DataTable();
            try
            {
                bool flag = false;
                if (roomSettle_ChildRoom_CheckBox.IsChecked.Value == true)
                {
                    flag = true;
                }

                con.Open();
                string command = "insert into HotelDB.FamilyApart(PriceForRoom,RoomClass,HasChildRoom,numberOfBeds,PriceForChildRoom,AmountOfPeople)  values(" +
                    roomSettle_PriceForRoom_TextBox.Text.ToString() + ",'" + roomSettle_RoomClass_TextBox.Text.ToString() + "'," +
                    flag.ToString()+","+roomSettle_NumOfBeds_TextBox.Text.ToString()+","+roomSettle_PriceForChildRoom_TextBox.Text.ToString()+
                    ","+roomSettle_NumOfPeople_TextBox.Text.ToString()+");";
                MySqlCommand cmd = new MySqlCommand(command, con);
                dt.Load(cmd.ExecuteReader());
                MessageBox.Show("Succesfully Inserted");
                con.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void roomSettle_LoftApart_Button_Click(object sender, RoutedEventArgs e)
        {
            DataTable dt = new DataTable();
            try
            {
                con.Open();
                string command = "insert into HotelDB.LoftApart(PriceForRoom,RoomClass,NumberOfRooms,AmountOfPeople)  values(" +
                     roomSettle_PriceForRoom_TextBox.Text.ToString() + ",'" + roomSettle_RoomClass_TextBox.Text.ToString() + "',"
                    + roomSettle_NumOfRooms_TextBox.Text.ToString() +","+ roomSettle_NumOfPeople_TextBox.Text.ToString()+");";

                MySqlCommand cmd = new MySqlCommand(command, con);
                dt.Load(cmd.ExecuteReader());
                MessageBox.Show("Succesfully Inserted");
                con.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void clientSettle_SingleClient_Button_Click(object sender, RoutedEventArgs e)
        {
            DataTable dt = new DataTable();
            try
            {
                bool flag = false;
                if (clientSettle_Pet_CheckBox.IsChecked.Value == true)
                {
                    flag = true;
                }

                string date = clientSettle_CheckInDate_TextBox.Text.ToString();
                string date2 = clientSettle_CheckOutDate_TextBox.Text.ToString();
                string passport = clientSettle_PassportDat_TextBox.Text.ToString();
                string room = clientSettle_RoomNumber_TextBox.Text.ToString();

                con.Open();

                string command = "insert into HotelDB.SingleClient(AccomodationDate,CheckoutDate,PassportData,RoomNumber,HasPet) values('" 
                    + date + "','" 
                    + date2 + "'," + passport + ","
                    + room + "," + flag.ToString() + ");";
                MySqlCommand cmd = new MySqlCommand(command, con);
                dt.Load(cmd.ExecuteReader());
                MessageBox.Show("Succesfully Inserted");
                con.Close();
                // dtGrid.DataContext = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void clientSettle_Family_Button_Click(object sender, RoutedEventArgs e)
        {
            DataTable dt = new DataTable();
            try
            {
                bool flag = false;
                if (clientSettle_Childrens_CheckBox.IsChecked.Value == true)
                {
                    flag = true;
                }

                string date = clientSettle_CheckInDate_TextBox.Text.ToString();
                string date2 = clientSettle_CheckOutDate_TextBox.Text.ToString();
                string passport = clientSettle_PassportDat_TextBox.Text.ToString();
                string room = clientSettle_RoomNumber_TextBox.Text.ToString();
                string numOfChild = clientSettle_NumberOfChildren_TextBox.Text.ToString();


                con.Open();

                string command = "insert into HotelDB.Family(AccomodationDate,CheckoutDate,PassportData,RoomNumber,AmountOfChildren,HaveChildren) values('" 
                    + date + "','"
                    + date2 + "'," + passport + ","
                    + room + "," + numOfChild
                        + "," +flag.ToString() + ");";
                MySqlCommand cmd = new MySqlCommand(command, con);
                dt.Load(cmd.ExecuteReader());
                MessageBox.Show("Succesfully Inserted");
                con.Close();
                // dtGrid.DataContext = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void clientSettle_GroupOfClients_Button_Click(object sender, RoutedEventArgs e)
        {
            string date = clientSettle_CheckInDate_TextBox.Text.ToString();
            string date2 = clientSettle_CheckOutDate_TextBox.Text.ToString();
            string passport = clientSettle_PassportDat_TextBox.Text.ToString();
            string room = clientSettle_RoomNumber_TextBox.Text.ToString();
            string num = clientSettle_NumberOfPeople_TextBox.Text.ToString();
           
            DataTable dt = new DataTable();
            try
            {
                con.Open();

                string command = "insert into HotelDB.GroupOfClients(AccomodationDate,CheckoutDate,PassportData,RoomNumber,NumberOfPeople) values('"
                    + date + "','"
                    + date2 + "'," + passport + "," 
                    + room + "," + num + ");";
                MySqlCommand cmd = new MySqlCommand(command, con);
                dt.Load(cmd.ExecuteReader());
                MessageBox.Show("Succesfully Inserted");
                con.Close();
                // dtGrid.DataContext = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
