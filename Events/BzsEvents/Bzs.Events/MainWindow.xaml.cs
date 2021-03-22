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

namespace Bzs.Events
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private TemperaturFuehler fuehler;

        public MainWindow()
        {
            this.InitializeComponent();
            this.fuehler = new TemperaturFuehler(18.5);
        }

        private void ButtonThermometer_Click(object sender, RoutedEventArgs e)
        {
            TemperaturAnzeigeView view = new TemperaturAnzeigeView(this.fuehler);
            view.Show();
        }

        private void ButtonErhoehen_Click(object sender, RoutedEventArgs e)
        {
            this.fuehler.SetTemperatur(this.fuehler.Temperatur + 0.5);
        }

        private void ButtonReduzieren_Click(object sender, RoutedEventArgs e)
        {
            this.fuehler.SetTemperatur(this.fuehler.Temperatur - 0.5);
        }
    }
}
