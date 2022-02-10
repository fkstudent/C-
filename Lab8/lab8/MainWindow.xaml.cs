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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                float x = float.Parse(box1.Text);
                float y = float.Parse(box2.Text);
           

               wynik.Text ="Suma "+x+"+"+y+"="+ (x + y).ToString();
            }

            catch (Exception)
            {
                MessageBox.Show("Podano błędne dane");
            }

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {
                float x = float.Parse(box1.Text);
                float y = float.Parse(box2.Text);


                wynik.Text = "Roznica " + x + "-" + y + "=" + (x - y).ToString();
            }

            catch (Exception)
            {
                MessageBox.Show("Podano błędne dane");
            }

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            try
            {
                float x = float.Parse(box1.Text);
                float y = float.Parse(box2.Text);


                wynik.Text = "Iloczyn " + x + "*" + y + "=" + (x * y).ToString();
            }

            catch (Exception)
            {
                MessageBox.Show("Podano błędne dane");
            }

        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            try
            {
                float x = float.Parse(box1.Text);
                float y = float.Parse(box2.Text);

               

                    wynik.Text = "Iloraz " + x + "/" + y + "=" + (x / y).ToString();


            }

            catch (Exception ex)
            {
                MessageBox.Show("Dzielenie przez zero !");
                wynik.Text = "Dzielenie przez zero !";
            }

        }
    }
}
