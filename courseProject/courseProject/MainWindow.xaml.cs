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
using courseProject.CustomControls;

namespace courseProject
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            contentControl.Content = new DataBaseGrid();
        }

        private void SelectDB_Button_Click(object sender, RoutedEventArgs e)
        {
            contentControl.Content = new DataBaseGrid();
        }

        private void AddElement_Button_Click(object sender, RoutedEventArgs e)
        {
            contentControl.Content = new GuestSettlement();
        }

        private void Delete_Button_Click(object sender, RoutedEventArgs e)
        {
            contentControl.Content = new DeletePageControl();
        }
    
    }
}
