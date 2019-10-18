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



namespace Turner
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
       static int czas;
        public MainWindow()
        {
            InitializeComponent();
            {
              

            }
          
        }



        private void Button_Click(object sender, RoutedEventArgs e) //przycisk OFF
        {
            if (textTime.Text == "")
            {
                MessageBox.Show("Wpisz wartość w minutach");
            }
            else
            {
                czas = Convert.ToInt32(textTime.Text);
                Offuj offuj = new Offuj();
                offuj.turnoff(czas);
            }
            ProgressOff.Maximum = czas;
            ProgressOff.Minimum = 0;
            ProgressOff.IsEnabled = true;
          
            Duration duration = new Duration(TimeSpan.FromMinutes(czas));
            System.Windows.Media.Animation.DoubleAnimation doubleanimation = new System.Windows.Media.Animation.DoubleAnimation(czas, duration);
            ProgressOff.BeginAnimation(ProgressBar.ValueProperty , doubleanimation); //pasek statusu postępu, działa należycie
            
        }

        

        private void stopOff_Click(object sender, RoutedEventArgs e) //zatrzymanie wylaczenia systemu
        {
            Offuj offuj = new Offuj();
            offuj.turnOffStop();

            
            
        }

        private void MenuSudoku_Click(object sender, RoutedEventArgs e) //przycisk sudoku w menu
        {
            resultOptionGrid.Visibility = Visibility.Hidden;

        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Szymon i Dawid");

        }
    }

   
}
