using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bzs.Events
{
    public class TemperaturFuehler
    {
        private double temperatur;

        public TemperaturFuehler(double temperatur)
        {
            this.SetTemperatur(temperatur);
        }

        public event EventHandler<double> TemperaturChanged;

        public double Temperatur
        {
            get
            {
                return this.temperatur;
            }
        }

        public void SetTemperatur(double temperatur)
        {
            if (this.temperatur != temperatur)
            {
                this.temperatur = temperatur;
                this.TemperaturChanged?.Invoke(this, this.temperatur);
            }
        }
    }
}
