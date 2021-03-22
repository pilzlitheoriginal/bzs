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

namespace Bzs.Events
{
    /// <summary>
    /// Interaction logic for TemperaturAnzeigeView.xaml
    /// </summary>
    public partial class TemperaturAnzeigeView : Window
    {
        private TemperaturFuehler f;

        public TemperaturAnzeigeView(TemperaturFuehler fuehler)
        {
            InitializeComponent();
            this.f = fuehler;
            this.f.TemperaturChanged += Fuehler_TemperaturChanged;
            this.TextBoxTemperatur.Text = this.f.Temperatur.ToString();
        }

        private void Fuehler_TemperaturChanged(object sender, double e)
        {
            this.TextBoxTemperatur.Text = e.ToString();
        }

        private void ButtonAbmelden_Click(object sender, RoutedEventArgs e)
        {
            this.f.TemperaturChanged -= Fuehler_TemperaturChanged;
            this.TextBoxTemperatur.Text = string.Empty;
        }
    }
}
