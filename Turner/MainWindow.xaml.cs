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
            
            
           

            System.Timers.Timer timer = new System.Timers.Timer(1000); //1sekunda odświeżania 
            timer.Enabled = true; // włączenie minutnika
            timer.Start(); //start
            
            

             

        }


        private void stopOff_Click(object sender, RoutedEventArgs e)
        {
            Offuj offuj = new Offuj();
            offuj.turnOffStop();
        }
    }

   
}
