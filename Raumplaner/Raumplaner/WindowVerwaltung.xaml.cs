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
    /// Interaktionslogik für WindowVerwaltung.xaml
    /// </summary>
    public partial class WindowVerwaltung : Window
    {
        public WindowVerwaltung()
        {
            InitializeComponent();
            dgReservations.ItemsSource = new entitiesDataContext().Reservation;
        }
        //ONCLOSE
        private void Window_Closed(object sender, EventArgs e)
        {
            new MainWindow().Show();
        }
        //NEW RESERVATION
        private void btnNeu_Click(object sender, RoutedEventArgs e)
        {
            new WindowReservation(this).Show();
        }
        //EDIT RESERVATION
        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {
            new WindowReservation(this, dgReservations.SelectedItem as Reservation).Show();
        }
        //DELETE RESERVATION
        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            if(dgReservations.SelectedItem != null)
            {
                var entities = new entitiesDataContext();
                var selected = dgReservations.SelectedItem as Reservation;

                entities.Reservation.DeleteOnSubmit(entities.Reservation.Where(r => r.ReservationId == selected.ReservationId).FirstOrDefault());
                entities.SubmitChanges();
                entities.Refresh(System.Data.Linq.RefreshMode.OverwriteCurrentValues);
                dgReservations.ItemsSource = entities.Reservation;
            }
        }
    }
}
