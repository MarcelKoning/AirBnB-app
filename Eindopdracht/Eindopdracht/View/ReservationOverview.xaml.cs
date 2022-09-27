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
using Eindopdracht.Model;

namespace Eindopdracht.View
{
    /// <summary>
    /// Interaction logic for ReservationOverview.xaml
    /// </summary>
    public partial class ReservationOverview : Page
    {
        public ReservationOverview()
        {
            InitializeComponent();

            DataContext = new ReservationViewModel();
        }
        private void OpenAddReservationPage_Click(object sender, RoutedEventArgs e)
        {
            _NavigationFrame.Navigate(new AddReservation());
            this.NavigationService.Navigate(new Uri("View/AddReservation.xaml", UriKind.Relative));
        }
        private void OpenUpdateReservationPage_Click(object sender, RoutedEventArgs e)
        {
            _NavigationFrame.Navigate(new UpdateReservation());
            this.NavigationService.Navigate(new Uri("View/UpdateReservation.xaml", UriKind.Relative));
        }
    }
}
