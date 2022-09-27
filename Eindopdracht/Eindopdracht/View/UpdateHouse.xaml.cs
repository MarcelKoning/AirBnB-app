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
using Eindopdracht.ViewModel;
using Eindopdracht.View;
using System.ComponentModel;
using Microsoft.EntityFrameworkCore;
using Eindopdracht.Commands;

namespace Eindopdracht.View
{
    /// <summary>
    /// Interaction logic for UpdateHouse.xaml
    /// </summary>
    public partial class UpdateHouse : Page
    {
        public UpdateHouse()
        {
            InitializeComponent();

            DataContext = new UpdateHouseViewModel();   
        }
    }
}
