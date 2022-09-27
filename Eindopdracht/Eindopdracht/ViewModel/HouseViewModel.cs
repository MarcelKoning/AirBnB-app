using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using Eindopdracht.Model;
using Eindopdracht.ViewModel;
using Eindopdracht.View;
using System.Windows.Input;
using System.ComponentModel;
using Microsoft.EntityFrameworkCore;
using Eindopdracht.Commands;

namespace Eindopdracht.ViewModel
{
    public class HouseViewModel
    {
        public House SelectedHouse { get; set; }
        public Landlord SelectedLandlord { get; set; }
        public ObservableCollection<House> AllHouses { get; set; }
        public ICommand UpdateHouseClick { get; set; }
        public ICommand DeleteHouseClick { get; set; }

        private DatabaseContext _db;

        public HouseViewModel()
        {
            _db = new DatabaseContext();

            _db.Houses.Load();

            AllHouses = _db.Houses.Local.ToObservableCollection();

            DeleteHouseClick = new RelayCommand(DeleteHouse);
        }
        private void DeleteHouse(object a)
        {
            AllHouses.Remove(SelectedHouse);
            _db.SaveChanges();
        }
    }
}
