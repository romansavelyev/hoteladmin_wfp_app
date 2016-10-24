using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

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

        //test

        void DataBaseConnect()
        {
            SqlConnection con = new SqlConnection();
            SqlDataAdapter ad = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand();
            String str = "SELECT id , roomclass , amountofpeople, priceforroom FROM HotelRoom";
            cmd.CommandText = str;
            ad.SelectCommand = cmd;
            con.ConnectionString = "Data Source=localhost; Initial Catalog=Northwind; Integrated Security=True";
            cmd.Connection = con;
            DataSet ds = new DataSet();
            ad.Fill(ds);
            
           // ListViewHotel.DataContext = ds.Tables[0].DefaultView;
            con.Close();
        }


    }
}
