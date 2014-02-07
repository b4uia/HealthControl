using System;
using Windows.UI.Xaml.Data;

namespace HealthControl.Tablet.Controls.TimePicker
{
    public class DoubleToText : IValueConverter
    {

        public object Convert(object value, Type targetType, object parameter, string language)
        {
            return string.Format("{0:00}", value); 
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }

}