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
    //    private DataTable dt = new DataTable();
        private DBcontroler mDB = new DBcontroler();
       // private Settlement mSettle;


        public DataBaseGrid()
        {
            InitializeComponent();
        }
        public  static string connStr = "SERVER=localhost;DATABASE=HotelDB;UID=root;PASSWORD=root;";
        public MySqlConnection con = new MySqlConnection(connStr);
       

        private void ConnBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                //mDB.DBconnect();
                con.Open();
             
                dbStatusLbl.Content = "Connection is open now!";
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void SimpleApartBtn_Click(object sender, RoutedEventArgs e)
        {
            DataTable dt = new DataTable();
            try
            {
                MySqlCommand cmd = new MySqlCommand("select * from HotelDB.SimpleApart ", con);
                dt.Load(cmd.ExecuteReader());
                dtGrid.DataContext = dt;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ClearBtn_Click(object sender, RoutedEventArgs e)
        {
            DataTable dt = new DataTable();
            dtGrid.DataContext = null;
            dtGrid.Items.Refresh();
            dt.Clear();
        }

        private void LoftApartBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();
                MySqlCommand cmd = new MySqlCommand("select * from HotelDB.LoftApart order by id", con);
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

        private void FamilyApartBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();
                MySqlCommand cmd = new MySqlCommand("select * from HotelDB.FamilyApart ", con);
                dt.Load(cmd.ExecuteReader());
                dtGrid.DataContext = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DiscBtn_Click(object sender, RoutedEventArgs e)
        {
            con.Close();
            dbStatusLbl.Content = "Connection is closed!";
        }

        private void SingleClientBtn_Click(object sender, RoutedEventArgs e)
        {
            DataTable dt = new DataTable();
            try
            {
                MySqlCommand cmd = new MySqlCommand("select * from HotelDB.SingleClient ", con);
                dt.Load(cmd.ExecuteReader());
                dtGrid.DataContext = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void GroupOfClientsBtn_Click(object sender, RoutedEventArgs e)
        {
            DataTable dt = new DataTable();
            try
            {
                MySqlCommand cmd = new MySqlCommand("select * from HotelDB.GroupOfClients ", con);
                dt.Load(cmd.ExecuteReader());
                dtGrid.DataContext = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FamilyBtn_Click(object sender, RoutedEventArgs e)
        {
            DataTable dt = new DataTable();
            try
            {
                MySqlCommand cmd = new MySqlCommand("select * from HotelDB.Family ", con);
                dt.Load(cmd.ExecuteReader());
                dtGrid.DataContext = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
