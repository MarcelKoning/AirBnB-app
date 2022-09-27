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

namespace Eindopdracht.View
{
    /// <summary>
    /// Interaction logic for AddHouse.xaml
    /// </summary>
    public partial class AddHouse : Page
    {
        public AddHouse()
        {
            InitializeComponent();

            DataContext = new AddHouseViewModel();
        }
    }
}
