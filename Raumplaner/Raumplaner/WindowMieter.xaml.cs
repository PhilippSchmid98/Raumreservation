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
        public WindowMieter()
        {
            InitializeComponent();

            var entities = new entitiesDataContext();

            dgRooms.ItemsSource = entities.TblRoom;

        }

        private void Window_Closed(object sender, EventArgs e)
        {
            new MainWindow().Show();
        }

        private void btnFilter_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
