using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
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
    /// Interaktionslogik für WindowReservation.xaml
    /// </summary>
    public partial class WindowReservation : Window, INotifyPropertyChanged
    {
        #region NotifyPropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void SendPropertyChanged(String propertyName)
        {
            if ((this.PropertyChanged != null))
            {
                this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        #endregion

        public WindowVerwaltung WF { get; set; }

        public ObservableCollection<TblRoom> Rooms { get; set; } = new ObservableCollection<TblRoom>();

        private Reservation _currentReservation;

        public Reservation CurrentReservation
        {
            get { return _currentReservation; }
            set {
                _currentReservation = value;
                SendPropertyChanged("CurrentReservation");
            }
            
        }


        //Konstruktor for New
        public WindowReservation(WindowVerwaltung wf)
        {
            this.DataContext = this;
            InitializeComponent();
            Title.Content = "New Reservation";
            CurrentReservation = new Reservation();
            CurrentReservation.EndDate = DateTime.Today;
            CurrentReservation.StartDate = DateTime.Today;
            cbRoom.ItemsSource = new ObservableCollection<TblRoom>(new entitiesDataContext().TblRoom);
            WF = wf;
        }
        //Konstruktor for Edit
        public WindowReservation(WindowVerwaltung wf,Reservation res)
        {
            this.DataContext = this;
            InitializeComponent();
            Title.Content = "Edit Reservation";
            CurrentReservation = res;
            var ro = new entitiesDataContext().TblRoom.ToList();
            cbRoom.ItemsSource = new ObservableCollection<TblRoom>(ro);
            cbRoom.SelectedItem = ro.Where<TblRoom>(r => r.RoomId == res.RoomFK).FirstOrDefault();
            WF = wf;
        }
        //Save Reservation
        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            if(string.IsNullOrWhiteSpace(CurrentReservation.LastName) || string.IsNullOrWhiteSpace(CurrentReservation.Street) || string.IsNullOrWhiteSpace(CurrentReservation.Village) || string.IsNullOrWhiteSpace(CurrentReservation.FirstName) || cbRoom.SelectedItem == null)
            {
                MessageBox.Show("Bitte fülle alle Felder korrket aus!");
                return;
            }



            CurrentReservation.RoomFK = (cbRoom.SelectedItem as TblRoom).RoomId;

            var entities = new entitiesDataContext();
            var changed = entities.Reservation.Where(r => r.ReservationId == CurrentReservation.ReservationId).FirstOrDefault();
            if(changed != null)
            {
                changed.EndDate = CurrentReservation.EndDate;
                changed.FirstName = CurrentReservation.FirstName;
                changed.LastName = CurrentReservation.LastName;
                changed.RoomFK = CurrentReservation.RoomFK;
                changed.StartDate = CurrentReservation.StartDate;
                changed.Street = CurrentReservation.Street;
                changed.Village = CurrentReservation.Village;
                entities.SubmitChanges();
            }else
            {
                
                entities.Reservation.InsertOnSubmit(CurrentReservation);
                entities.SubmitChanges();
            }
            entities.Refresh(System.Data.Linq.RefreshMode.OverwriteCurrentValues);
            WF.dgReservations.ItemsSource = new ObservableCollection<Reservation>(entities.Reservation);
            this.Close();
        }
    }
}
