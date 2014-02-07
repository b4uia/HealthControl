

using System;
using GalaSoft.MvvmLight;

namespace  HealthControl.Tablet.Controls.TimePicker
{
   
    public sealed partial class TimePicker 
    {
        private double _value1 = 1;

        public double Value1 { get; set; }

        public double Value2 { get; set; }

        public double Maxvalue1 { get; set; }

        public double Maxvalue2 { get; set; }

        public string Value1String {
            get
            {
                return string.Format("{0:00}",_value1);   
            } 
        }

        public TimePicker()
        {
            this.InitializeComponent();
            DataContext = this;
        }
    }
}
