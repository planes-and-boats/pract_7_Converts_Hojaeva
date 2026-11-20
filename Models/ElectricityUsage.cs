using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Navigation;

namespace pract_7_Hojaeva.Models
{
    public class ElectricityUsage : INotifyPropertyChanged
    {
        private string address;
        private double consumption;
        private double rate;
        private double benefit;

        public string Address
        {
            get { return address; }
            set
            {
                if (address != value)
                {
                    address = value;
                    OnPropertyChanged();
                }
            }
        }

        public double Consumption
        {
            get { return consumption; }
            set
            {
                if (consumption != value)
                {
                    if (value < 0) consumption = 0;
                    else consumption = value;
                    OnPropertyChanged();
                    OnPropertyChanged(nameof(Payment));
                }
            }
        }

        public double Rate
        {
            get { return rate; }
            set
            {
                if (rate != value)
                {
                    if (value < 0) rate = 0;
                    else rate = value;
                    OnPropertyChanged();
                    OnPropertyChanged(nameof(Payment));
                }
            }
        }

        public double Benefit
        {
            get { return benefit; }
            set
            {
                if (benefit != value)
                {
                    if (value < 0) benefit = 0;
                    else benefit = value;
                    OnPropertyChanged();
                    OnPropertyChanged(nameof(Payment));
                }
            }
        }

        public double Payment => rate * consumption * ( 1 - benefit);

        public event PropertyChangedEventHandler? PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string? name = null)
            => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }
}
