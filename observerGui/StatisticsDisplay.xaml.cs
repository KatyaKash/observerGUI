using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
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
    /// Логика взаимодействия для StatisticsDisplay.xaml
    /// </summary>
    public partial class StatisticsDisplay : Window, Observer
    {
        private Subject weatherData;
        private float max_temp;
        private float min_temp;
        private float temp_sum;
        private float temp_hum;
        private float temp_press;
        private int num_readings;


        public StatisticsDisplay(Subject weatherData)
        {
            InitializeComponent();
            this.weatherData = weatherData;

        }
        public void Update(float temp, float humidity, float pressure)
        {
            temp_sum += temp;
            temp_hum += humidity;
            temp_press += pressure;
            num_readings += 1;
            float avg_temp = temp_sum / num_readings;
            float avg_hum = temp_hum / num_readings;
            float avg_press = temp_press / num_readings;

            if (temp > max_temp)
            {
                max_temp = temp;
            }
            if (temp < min_temp)
            {
                min_temp = temp;
            }

            Label_max_temp.Content = max_temp.ToString();
            Label_min_temp.Content = min_temp.ToString();
            Label_sum_temp.Content = temp_sum.ToString();
            Label_readings.Content = num_readings.ToString();
            Label_avg_temp.Content = avg_temp.ToString();
            Label_avg_hum.Content = avg_hum.ToString();
            Label_avg_press.Content = avg_press.ToString();

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
