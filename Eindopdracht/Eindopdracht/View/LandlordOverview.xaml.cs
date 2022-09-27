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
    /// Interaction logic for LandlordOverview.xaml
    /// </summary>
    public partial class LandlordOverview : Page
    {
        public LandlordOverview()
        {
            InitializeComponent();

            DataContext = new LandlordViewModel();
        }
        private void OpenAddLandlordPage_Click(object sender, RoutedEventArgs e)
        {
            _NavigationFrame.Navigate(new AddLandlord());
            this.NavigationService.Navigate(new Uri("View/AddLandlord.xaml", UriKind.Relative));
        }
    }
}
