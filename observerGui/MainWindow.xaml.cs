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

namespace observerGui
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, Subject
    {
        List<Observer> observers;
        private float temperature;
        private float humidity;
        private float pressure;

        public MainWindow()
        {
            InitializeComponent();
            observers = new List<Observer>();

        }
        public void setupGui()
        {
            CurrentConditionsDisplay current = new CurrentConditionsDisplay(this);
            StatisticsDisplay stat = new StatisticsDisplay(this);
            current.Show();
            stat.Show();
        }
        public void registerObserver(Observer o)
        {
            observers.Add(o);
        }
        public void removeObserver(Observer o)
        {
            observers.Remove(o);
        }

        public void notifyObservers()
        {
            for (int i = 0; i < observers.Count; i++)
            {
                observers[i].Update(temperature, humidity, pressure);
            }
        }

        public void measurmentsChanged()
        {
            notifyObservers();
        }

        public void setMeasurments(float t, float h, float p)
        {
            this.temperature = t;
            this.humidity = h;
            this.pressure = p;
            measurmentsChanged();
        }



        private void Button_Click(object sender, RoutedEventArgs e)
        {
            float temp = float.Parse(textBox.Text);
            float humidity = float.Parse(textBox2.Text);
            float pressure = float.Parse(textBox3.Text);



            setMeasurments(temp, humidity, pressure);
        }


        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            setupGui();
        }
    }
}
