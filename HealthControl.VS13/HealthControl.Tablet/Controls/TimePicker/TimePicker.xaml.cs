using Windows.UI.Xaml;

namespace  HealthControl.Tablet.Controls.TimePicker
{
   
    public sealed partial class TimePicker 
    {
        public string Value1Label { get; set; }

        public string Value2Label { get; set; }

        public double Value1 { get; set; }

        public double Value2 { get; set; }

        public double Maxvalue1 { get; set; }

        public double Maxvalue2 { get; set; }

        public TimePicker()
        {
            InitializeComponent();

            DataContext = this;
        }

    }
}
