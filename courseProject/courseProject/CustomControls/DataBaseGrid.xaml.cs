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


namespace courseProject.CustomControls
{

    public partial class DataBaseGrid : UserControl
    {
        private ClientModel mClientM;
        private HotelRoomModel mHotelRoomM;
        private DataTable dt = new DataTable();
        private DBcontroler mDB = new DBcontroler();
       // private Settlement mSettle;


        public DataBaseGrid()
        {
            InitializeComponent();
        }
        public  static string connStr = "SERVER=localhost;DATABASE=test;UID=root;PASSWORD=root;";
        public MySqlConnection con = new MySqlConnection(connStr);
       

        private void ConnBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                mDB.DBconnect();
               // con.Open();
                dbStatusLbl.Content = "Connection is open now!";
                //MessageBox.Show("Connection is open now!");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void ShowBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand("select * from test.people", con);
                dt.Load(cmd.ExecuteReader());
                dtGrid.DataContext = dt;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DiscBtn_Click(object sender, RoutedEventArgs e)
        {
            mDB.BDdisconnect();
            dbStatusLbl.Content = "Connection is closed!";
       
        }

        private void Select2Bnt_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand("select * from test.Hotels", con);
                dt.Load(cmd.ExecuteReader());
                dtGrid.DataContext = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ShowList_Click(object sender, RoutedEventArgs e)
        {
            mHotelRoomM = new HotelRoomModel(mDB.showHotelRoomList());
            mClientM = new ClientModel(mDB.showClientList());

            foreach(var client in mClientM.ClientList)
            {
                System.Diagnostics.Debug.WriteLine(client.RoomNumber);
            }
        }
    }
}
