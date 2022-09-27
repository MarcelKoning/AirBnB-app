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
using Eindopdracht.ViewModel;
using Eindopdracht.View;

namespace Eindopdracht
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Page
    {
        public MainWindow()
        {
            InitializeComponent();

            DataContext = new MainWindowViewModel();
        }
        private void OpenLandlordWindow(object sender, RoutedEventArgs e)
        {
            _NavigationFrame.Navigate(new LandlordOverview());
            this.NavigationService.Navigate(new Uri("View/LandlordOverView.xaml", UriKind.Relative));
            //LandlordOverview objLandlordOverview = new LandlordOverview();
            //this.Visibility = Visibility.Hidden;
            //objLandlordOverview.Show();
        }
        private void OpenHouseWindow(object sender, RoutedEventArgs e)
        {
            _NavigationFrame.Navigate(new HouseOverview());
            this.NavigationService.Navigate(new Uri("View/HouseOverView.xaml", UriKind.Relative));
        }
        private void OpenReservationWindow(object sender, RoutedEventArgs e)
        {
            _NavigationFrame.Navigate(new ReservationOverview());
            this.NavigationService.Navigate(new Uri("View/ReservationOverView.xaml", UriKind.Relative));
        }
    }
    
}