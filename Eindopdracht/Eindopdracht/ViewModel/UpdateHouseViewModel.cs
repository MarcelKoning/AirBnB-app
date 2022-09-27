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
    public class UpdateHouseViewModel
    {
        public House SelectedHouse { get; set; }
        public Landlord SelectedLandlord { get; set; }
        public ObservableCollection<House> AllHouses { get; set; }
        public ObservableCollection<Landlord> AllLandlords { get; set; }
        public ObservableCollection<House.HouseTypes> AllHouseTypes { get; set; }

        public Landlord _Landlord { get; set; }
        public ICommand UpdateHouseClick { get; set; }

        private DatabaseContext _db;
        public UpdateHouseViewModel()
        {
            _db = new DatabaseContext();

            _db.Houses.Load();
            _db.Landlords.Load();

            AllHouses = _db.Houses.Local.ToObservableCollection();

            AllLandlords = _db.Landlords.Local.ToObservableCollection();

            AllHouseTypes = new ObservableCollection<House.HouseTypes> { House.HouseTypes.Apartment, House.HouseTypes.Bungalow, House.HouseTypes.Castle, House.HouseTypes.House, House.HouseTypes.Hotel };

            UpdateHouseClick = new RelayCommand(UpdateHouse);
        }
        private void UpdateHouse(object a)
        {
            _db.SaveChanges();
        }
    }
}
