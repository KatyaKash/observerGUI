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

namespace observerGui
{
    /// <summary>
    /// Логика взаимодействия для CurrentConditionsDisplay.xaml
    /// </summary>
    public partial class CurrentConditionsDisplay : Window, Observer
    {
        private Subject weatherData;
        public CurrentConditionsDisplay(Subject weatherData)
        {
            InitializeComponent();
            this.weatherData = weatherData;
        }

        public void Update(float temp, float humidity, float pressure)
        {
            Label1.Content = temp.ToString();
            Label2.Content = humidity.ToString();
            Label3.Content = pressure.ToString();
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            weatherData.registerObserver(this);
        }
        private void CheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            weatherData.removeObserver(this);
        }

    }
}
