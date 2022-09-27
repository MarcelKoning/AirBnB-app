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
using Eindopdracht.Model;
using Eindopdracht.View;
using Eindopdracht.ViewModel;
using System.Collections.ObjectModel;

namespace Eindopdracht.View
{
    /// <summary>
    /// Interaction logic for HouseOverview.xaml
    /// </summary>
    public partial class HouseOverview : Page
    {
        public HouseOverview()
        {
            InitializeComponent();

            DataContext = new HouseViewModel();
        }

        private void OpenAddHousePage_Click(object sender, RoutedEventArgs e)
        {
            _NavigationFrame.Navigate(new AddHouse());
            this.NavigationService.Navigate(new Uri("View/AddHouse.xaml", UriKind.Relative));
        }
        private void OpenUpdateHousePage_Click(object sender, RoutedEventArgs e)
        {
            _NavigationFrame.Navigate(new UpdateHouse());
            this.NavigationService.Navigate(new Uri("View/UpdateHouse.xaml", UriKind.Relative));
        }
    }
}
