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
using Eindopdracht.Commands;
using Microsoft.EntityFrameworkCore;

namespace Eindopdracht.ViewModel
{
    public class AddHouseViewModel
    {
        public ObservableCollection<House> AllHouses { get; set; }
        public ObservableCollection<Landlord> AllLandlords { get; set; }
        public ObservableCollection<House.HouseTypes> AllHouseTypes { get; set; }

        public string _HouseName { get; set; }
        public string _HouseDescription { get; set; }
        public Landlord _Landlord { get; set; }
        public House.HouseTypes _HouseType { get; set; }
        public int _MaxPerson { get; set; }
        public float _Price { get; set; }
        public int _BedroomTotal { get; set; }
        public int _BedTotal { get; set; }
        public int _BathroomTotal { get; set; }
        public bool _SmokingAllowed { get; set; }
        public string _Streetname { get; set; }
        public string _HouseNumber { get; set; }
        public string _City { get; set; }
        public string _PostalCode { get; set; }
        public string _Country { get; set; }
        public ICommand AddNewHouseClick { get; set; }

        private DatabaseContext _db;

        public AddHouseViewModel()
        {
            _db = new DatabaseContext(); 

            _db.Houses.Load();
            _db.Landlords.Load();

            AllHouses = _db.Houses.Local.ToObservableCollection();

            AllLandlords = _db.Landlords.Local.ToObservableCollection();

            AllHouseTypes = new ObservableCollection<House.HouseTypes> { House.HouseTypes.Apartment, House.HouseTypes.Bungalow, House.HouseTypes.Castle, House.HouseTypes.House, House.HouseTypes.Hotel };

            AddNewHouseClick = new RelayCommand(AddNewHouse);
        }
        private void AddNewHouse(object a)
        {
            House newHouse = new House
            {
                HouseName = _HouseName,
                HouseDescription = _HouseDescription,
                Landlord = _Landlord,
                HouseType = _HouseType,
                MaxPerson = _MaxPerson,
                Price = _Price,
                BedroomTotal = _BedroomTotal,
                BedTotal = _BedTotal,
                BathroomTotal = _BathroomTotal,
                SmokingAllowed = _SmokingAllowed,
                Streetname = _Streetname,
                HouseNumber = _HouseNumber,
                City = _City,
                PostalCode = _PostalCode,
                Country = _Country
            };

            AllHouses.Add(newHouse);

            _db.SaveChanges();
        }
    }
}
