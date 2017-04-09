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
    /// Interaktionslogik für WindowReservation.xaml
    /// </summary>
    public partial class WindowReservation : Window
    {
        public Reservation CurrentReservation { get; set; }


        public WindowReservation(bool asNew)
        {
            InitializeComponent();

            if (asNew)
            {
                SetAsNew();
            }
            else
            {
                SetAsEdit();
            }

        }

        private void SetAsNew()
        {
            Title.Content = "New Reservation";
        }
        private void SetAsEdit()
        {
            Title.Content = "Edit Reservation";
        }
    }
}
