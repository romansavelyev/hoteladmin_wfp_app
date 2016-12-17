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
    /// Interaction logic for DeletePageControl.xaml
    /// </summary>
    public partial class DeletePageControl : UserControl
    {
        private DBcontroler mDB = new DBcontroler();
        public static string connStr = "SERVER=localhost;DATABASE=HotelDB;UID=root;PASSWORD=root;";
        public MySqlConnection con = new MySqlConnection(connStr);

        public DeletePageControl()
        {
            InitializeComponent();
        }

        private void SimpleApart_Btn_Click(object sender, RoutedEventArgs e)
        {
            DataTable dt = new DataTable();
            try
            {
                con.Open();
                string command = "delete from HotelDB.SimpleApart where id=" + SimpleApart_TB.Text.ToString() + ";";

                MySqlCommand cmd = new MySqlCommand(command, con);
                dt.Load(cmd.ExecuteReader());
                MessageBox.Show("Room has been deleted from DataBase");
                con.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LoftApart_Btn_Click(object sender, RoutedEventArgs e)
        {
            DataTable dt = new DataTable();
            try
            {
                con.Open();
                string command = "delete from HotelDB.LoftApart where id=" + LoftApart_TB.Text.ToString() + ";";

                MySqlCommand cmd = new MySqlCommand(command, con);
                dt.Load(cmd.ExecuteReader());
                MessageBox.Show("Room has been deleted from DataBase");
                con.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FamilyApart_Btn_Click(object sender, RoutedEventArgs e)
        {
            DataTable dt = new DataTable();
            try
            {
                con.Open();
                string command = "delete from HotelDB.FamilyApart where id=" + FamilyApart_TB.Text.ToString() + ";";

                MySqlCommand cmd = new MySqlCommand(command, con);
                dt.Load(cmd.ExecuteReader());
                MessageBox.Show("Room has been deleted from DataBase");
                con.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SingleClient_Btn_Click(object sender, RoutedEventArgs e)
        {
            DataTable dt = new DataTable();
            try
            {
                con.Open();
                string command = "delete from HotelDB.SingleClient where PassportData=" + SingleClient_TB.Text.ToString() + ";";

                MySqlCommand cmd = new MySqlCommand(command, con);
                dt.Load(cmd.ExecuteReader());
                MessageBox.Show("Client has been deleted from DataBase");
                con.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void GroupOfClients_Btn_Click(object sender, RoutedEventArgs e)
        {
            DataTable dt = new DataTable();
            try
            {
                con.Open();
                string command = "delete from HotelDB.GroupOfClients where PassportData=" + GroupOfClients_TB.Text.ToString() + ";";

                MySqlCommand cmd = new MySqlCommand(command, con);
                dt.Load(cmd.ExecuteReader());
                MessageBox.Show("Client has been deleted from DataBase");
                con.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Family_Btn_Click(object sender, RoutedEventArgs e)
        {
            DataTable dt = new DataTable();
            try
            {
                con.Open();
                string command = "delete from HotelDB.Family where PassportData=" + Family_TB.Text.ToString() + ";";

                MySqlCommand cmd = new MySqlCommand(command, con);
                dt.Load(cmd.ExecuteReader());
                MessageBox.Show("Client has been deleted from DataBase");
                con.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
