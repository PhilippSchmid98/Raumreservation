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
using System.Windows.Shapes;

namespace Raumplaner
{
    /// <summary>
    /// Interaktionslogik für WindowMieter.xaml
    /// </summary>
    public partial class WindowMieter : Window
    {
        //Konstruktor
        public WindowMieter()
        {
            InitializeComponent();

            var entities = new entitiesDataContext();

            dgRooms.ItemsSource = entities.TblRoom;
            StartDate.SelectedDate = DateTime.Today;
            EndDate.SelectedDate = DateTime.Today;

        }
        //OnCLose
        private void Window_Closed(object sender, EventArgs e)
        {
            new MainWindow().Show();
        }
        //ResetFilter
        private void btnFilter_Click(object sender, RoutedEventArgs e)
        {
            var entities = new entitiesDataContext();

            var rooms = entities.TblRoom.ToList();
            var newRooms = new List<TblRoom>();
            foreach(var r in rooms){
                var isBooked = false;

                if(entities.Reservation.Where(res => res.RoomFK == r.RoomId && res.StartDate < StartDate.SelectedDate && res.EndDate > EndDate.SelectedDate).Count() != 0)
                {
                    MessageBox.Show("" + entities.Reservation.Where(res => res.RoomFK == r.RoomId && res.StartDate < StartDate.SelectedDate && res.EndDate > EndDate.SelectedDate).Count());
                    isBooked = true;
                }
                else if(entities.Reservation.Where(res => res.RoomFK == r.RoomId && (res.StartDate > StartDate.SelectedDate && res.StartDate < EndDate.SelectedDate)).Count() != 0)
                {
                    isBooked = true;
                }
                else if (entities.Reservation.Where(res => res.RoomFK == r.RoomId && (res.EndDate > StartDate.SelectedDate && res.EndDate < EndDate.SelectedDate)).Count() != 0)
                {
                    isBooked = true;
                }

                if (!isBooked)
                {
                    newRooms.Add(r);
                }
                
            }
            dgRooms.ItemsSource = newRooms;

            //dgRooms.ItemsSource = entities.TblRoom.Where(room => entities.Reservation.Where(res => res.RoomFK == room.RoomId && (res.EndDate >= StartDate.SelectedDate && res.EndDate <= EndDate.SelectedDate) || (res.StartDate >= StartDate.SelectedDate && res.StartDate <= EndDate.SelectedDate) || (res.StartDate <= StartDate.SelectedDate && res.EndDate <= EndDate.SelectedDate)).Count() == 0);
        }
    }
}
