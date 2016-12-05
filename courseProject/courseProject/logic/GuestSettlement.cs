using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using courseProject.CustomControls;
using System.Windows.Controls;
using System.Windows;
using courseProject.logic;

//Future objectives: 
// 1) make my classes NOT abstract
// 2) add logic to RoomTypes and ClientTypes
namespace courseProject.logic
{
    class GuestSettlement
    {
        private GuestSettlement mGuestSettlement;



        public GuestSettlement(GuestSettlement gs)
        {
            mGuestSettlement = gs;
            //objective: set the constructors

        }

        private void PostUser_Ok_Button_Click(object sender, RoutedEventArgs e)
        {
            //var takenFilmNames = mGuestSettlement.clientSettle_SelectedRoom_ListBox.SelectedItems.OfType<string>();
            //HashSet<HotelRoom> SelectedRoom = new HashSet<HotelRoom>();

            //foreach (var item in takenFilmNames)
            //{
            //    takenFilms.Add(_uof.Films.Get().Where(x => x.Name == item).First());
            //}

            try
            {
                //Client CModel new Client
                //{
                //    AccomodationDate = mGuestSettlement.clientSettle_AccomodationDate_DatePicker.SelectedDate,
                //    CheckOutDate = mGuestSettlement.clientSettle_LastName_DatePicker.SelectedDate,
                //    PassportData = mGuestSettlement.clientSettle_PassportData_TextBox.Text,
                //    RoomNumber = mGuestSettlement.clientSettle_RoomNumber_TextBox.Text
                   
                //};

        

                //if (PostHelper.IsModelValid(user) && PostHelper.IsModelValid(contactInfo))
                //{
                //    _uof.ContactInfos.Insert(contactInfo);
                //    _uof.Commit();

                //    PostHelper.ShowSuccesMessage("Make sure that all fields filled correctly!\n(Phone only via digets, email w/o forbidden symbols, etc)");
                //    return;
                //}


                throw new Exception();
            }
            catch (Exception)
            {
                MessageBox.Show("Oh no, some error appears, check your fields again and try again");
            }
        }

        private void PostFilm_Submit_Button_Click(object sender, RoutedEventArgs e)
        {
            //var selectedActorFullNames = mGuestSettlement.roomSettle_Clients_ListBox.SelectedItems.OfType<string>().ToList();


            //foreach (var item in selectedActorFullNames)
            //{
            //    string[] fName_lName = item.Split(' ');
            //    string firstName = fName_lName[0];
            //    string lastName = fName_lName[1];
            //    selectedActors.Add(_uof.Actors.Get().Where(x => x.FirstName == firstName && x.LastName == lastName).First());
            //}

            try
            {
                //HotelRoom RModel = new HotelRoom
                //{
                //    RoomClass = mGuestSettlement.roomSettle_RoomClass_TextBox.Text,
                //    AmountOfPeople = mGuestSettlement.roomSettle_NumOfPeople_TextBox.Text,
                //    PriceForRoom = mGuestSettlement.roomSettle_PriceForRoom_TextBox.Text
              
                //};

                //if (PostHelper.IsModelValid(model))
                //{
                //    _uof.Films.Insert(model);
                //    _uof.Commit();

                //    PostHelper.ShowSuccesMessage();
                //    return;
                //}

                throw new Exception();
            }
            catch (Exception)
            {
                MessageBox.Show("Error.Please, check if fields are written up correcrly.");
            }
        }

        //private void PostTabControl_SelectionChanged(object sender, SelectionChangedEventArgs e)
        //{
        //    if (!(sender is TabControl))
        //        return;
        //    //Debug.WriteLine(((sender as TabControl).SelectedItem as TabItem).Header);
        //    string TabulateH = ((sender as TabControl).SelectedItem as TabItem).Header.ToString();

        //    mGuestSettlement.clientSettle_SelectedRoom_ListBox.Items.Clear();
        //    mGuestSettlement.postFilm_Clients_ListBox.Items.Clear();

        //    switch (TabHeader)
        //    {
        //        case "Film":
        //            foreach (var item in _uof.Actors.Get())
        //            {
        //                mGuestSettlement.postFilm_MainActors_ListBox.Items.Add(item.FirstName + " " + item.LastName);
        //            }
        //            break;

        //        case "User":
        //            foreach (var item in _uof.Rooms.Get())
        //            {
        //                mGuestSettlement.postUser_TakenFilms_ListBox.Items.Add(item.Name);
        //            }
        //            break;
        //        default:
        //            break;
        //    }
        //}
        //private void clientSettle_SelectedRoom_ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        //{
        //    e.Handled = true;
        //}
        //private void roomSettle_Clients_ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        //{
        //    e.Handled = true;
        //}
  
    }
}
