using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
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

namespace WpfApp6
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            imgmsg.Visibility = Visibility.Hidden;
        }

        int c = 0;
        int t = 0;
        private void sasso1_Click(object sender, RoutedEventArgs e)
        {

            var sasso = 1;
            var carta = 2;
            var forbice = 3;
            var random = new Random();
            int number = random.Next(1, 4);
            if (sasso == number)
            {
                lblresult.Content = "PAREGGIO";
                Uri resourceUri = new Uri("/image/sasso.png", UriKind.Relative);
                immagine.Source = new BitmapImage(resourceUri);
                Uri resource = new Uri("/image/sasso.png", UriKind.Relative);
                immaginebot.Source = new BitmapImage(resource);
            }
            if (carta == number)
            {
                lblresult.Content = "HAI PERSO";
                Uri resourceUri = new Uri("/image/sasso.png", UriKind.Relative);
                immagine.Source = new BitmapImage(resourceUri);
                Uri resource = new Uri("/image/cartaa.png", UriKind.Relative);
                immaginebot.Source = new BitmapImage(resource);
                t = t + 1;
                lblcpu.Content = t;
            }
            if (forbice == number)
            {
                lblresult.Content = "HAI VINTO";
                Uri resourceUri = new Uri("/image/sasso.png", UriKind.Relative);
                immagine.Source = new BitmapImage(resourceUri);
                Uri resource = new Uri("/image/forbice.png", UriKind.Relative);
                immaginebot.Source = new BitmapImage(resource);
                c = c + 1;
                lbltu.Content = c;
            }
            if (c == 5)
            {
                MessageBox.Show($"BRAVO, HAI VINTO {c} a {t} ", "COMPLIMENTI", MessageBoxButton.OK, MessageBoxImage.Exclamation);
                t = 0;
                c = 0;
                lbltu.Content = 0;
                lblcpu.Content = 0;
                Uri resourc = new Uri("", UriKind.Relative);
                immaginebot.Source = new BitmapImage(resourc);
                Uri resour = new Uri("", UriKind.Relative);
                immagine.Source = new BitmapImage(resour);
                lblresult.Content = "";
            }
            if (t == 5)
            {
                MessageBox.Show($"PECCATO HAI PERSO {t} A {c}", "RIPROVA", MessageBoxButton.OK, MessageBoxImage.Exclamation);
                t = 0;
                c = 0;
                lbltu.Content = 0;
                lblcpu.Content = 0;
                Uri resourc = new Uri("", UriKind.Relative);
                immaginebot.Source = new BitmapImage(resourc);
                Uri resour = new Uri("", UriKind.Relative);
                immagine.Source = new BitmapImage(resour);
                lblresult.Content = "";

            }
           
        }

        private void carta1_Click(object sender, RoutedEventArgs e)
        {

            var sasso = 1;
            var carta = 2;
            var forbice = 3;
            var random = new Random();
            int number = random.Next(1, 4);
            if (carta == number)
            {
                lblresult.Content = "PAREGGIO";
                Uri resourceUri = new Uri("/image/cartaa.png", UriKind.Relative);
                immagine.Source = new BitmapImage(resourceUri);
                Uri resource = new Uri("/image/cartaa.png", UriKind.Relative);
                immaginebot.Source = new BitmapImage(resource);
            }
            if (forbice == number)
            {
                lblresult.Content = "HAI PERSO";
                Uri resourceUri = new Uri("/image/cartaa.png", UriKind.Relative);
                immagine.Source = new BitmapImage(resourceUri);
                Uri resource = new Uri("/image/forbice.png", UriKind.Relative);
                immaginebot.Source = new BitmapImage(resource);
                t = t + 1;
                lblcpu.Content = t;
            }
            if (sasso == number)
            {
                lblresult.Content = "HAI VINTO";
                Uri resourceUri = new Uri("/image/cartaa.png", UriKind.Relative);
                immagine.Source = new BitmapImage(resourceUri);
                Uri resource = new Uri("/image/sasso.png", UriKind.Relative);
                immaginebot.Source = new BitmapImage(resource);
                c = c + 1;
                lbltu.Content = c;
            }
            if (c == 5)
            {
                MessageBox.Show($"BRAVO, HAI VINTO {c} A {t} ", "COMPLIMENTI", MessageBoxButton.OK, MessageBoxImage.Exclamation);
                t = 0;
                c = 0;
                lbltu.Content = 0;
                lblcpu.Content = 0;
                Uri resourc = new Uri("", UriKind.Relative);
                immaginebot.Source = new BitmapImage(resourc);
                Uri resour = new Uri("", UriKind.Relative);
                immagine.Source = new BitmapImage(resour);
                lblresult.Content = "";
            }
            if (t == 5)
            {
                MessageBox.Show($"PECCATO HAI PERSO {t} A {c}", "RIPROVA", MessageBoxButton.OK, MessageBoxImage.Exclamation);
                t = 0;
                c = 0;
                lbltu.Content = 0;
                lblcpu.Content = 0;
                Uri resourc = new Uri("", UriKind.Relative);
                immaginebot.Source = new BitmapImage(resourc);
                Uri resour = new Uri("", UriKind.Relative);
                immagine.Source = new BitmapImage(resour);
                lblresult.Content = "";
            }

        }

        private void forbice1_Click(object sender, RoutedEventArgs e)
        {

            var sasso = 1;
            var carta = 2;
            var forbice = 3;
            var random = new Random();
            int number = random.Next(1, 4);
            if (forbice == number)
            {
                lblresult.Content = "PAREGGIO";
                Uri resourceUri = new Uri("/image/forbice.png", UriKind.Relative);
                immagine.Source = new BitmapImage(resourceUri);
                Uri resource = new Uri("/image/forbice.png", UriKind.Relative);
                immaginebot.Source = new BitmapImage(resource);
            }
            if (sasso == number)
            {
                lblresult.Content = "HAI PERSO";
                Uri resourceUri = new Uri("/image/forbice.png", UriKind.Relative);
                immagine.Source = new BitmapImage(resourceUri);
                Uri resource = new Uri("/image/sasso.png", UriKind.Relative);
                immaginebot.Source = new BitmapImage(resource);
                t = t + 1;
                lblcpu.Content = t;
            }
            if (carta == number)
            {
                lblresult.Content = "HAI VINTO";
                Uri resourceUri = new Uri("/image/forbice.png", UriKind.Relative);
                immagine.Source = new BitmapImage(resourceUri);
                Uri resource = new Uri("/image/cartaa.png", UriKind.Relative);
                immaginebot.Source = new BitmapImage(resource);
                c = c + 1;
                lbltu.Content = c;
            }
            if (c == 5)
            {
                MessageBox.Show($"BRAVO, HAI VINTO {c} A {t} ", "COMPLIMENTI", MessageBoxButton.OK, MessageBoxImage.Exclamation);
                t = 0;
                c = 0;
                lbltu.Content = 0;
                lblcpu.Content = 0;
                Uri resourc = new Uri("", UriKind.Relative);
                immaginebot.Source = new BitmapImage(resourc);
                Uri resour = new Uri("", UriKind.Relative);
                immagine.Source = new BitmapImage(resour);
                lblresult.Content = "";
            }
            if (t == 5)
            {
                MessageBox.Show($"PECCATO HAI PERSO {t} A {c}", "RIPROVA", MessageBoxButton.OK, MessageBoxImage.Exclamation);
                t = 0;
                c = 0;
                lbltu.Content = 0;
                lblcpu.Content = 0;
                Uri resourc = new Uri("", UriKind.Relative);
                immaginebot.Source = new BitmapImage(resourc);
                Uri resour = new Uri("", UriKind.Relative);
                immagine.Source = new BitmapImage(resour);
                lblresult.Content = "";
            }
            

        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            t = 0;
            c = 0;
            lbltu.Content = 0;
            lblcpu.Content = 0;
            Uri resource = new Uri("", UriKind.Relative);
            immaginebot.Source = new BitmapImage(resource);
            Uri resources = new Uri("", UriKind.Relative);
            immagine.Source = new BitmapImage(resources);
            lblresult.Content = "";
        }
    }
}
    

