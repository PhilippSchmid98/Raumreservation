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

namespace Raumplaner
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnMieter_Click(object sender, RoutedEventArgs e)
        {
            new WindowMieter().Show();
            this.Close();
        }

        private void btnVerwaltung_Click(object sender, RoutedEventArgs e)
        {
            new WindowVerwaltung().Show();
            this.Close();
        }
    }
}
