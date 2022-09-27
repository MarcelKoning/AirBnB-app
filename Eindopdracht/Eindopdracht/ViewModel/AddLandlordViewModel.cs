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
    public class AddLandlordViewModel
    {
        public Landlord SelectedLandlord { get; set; }
        public ObservableCollection<Landlord> AllLandlords { get; set; }
        public string _FirstName {get; set;}
        public string _LastName { get; set; }
        public ICommand AddNewClick { get; set; }

        private DatabaseContext _db;
        public AddLandlordViewModel()
        {
            _db = new DatabaseContext();

            _db.Landlords.Load();

            AllLandlords = _db.Landlords.Local.ToObservableCollection();

            AddNewClick = new RelayCommand(AddNewLandlord);
        }

        private void AddNewLandlord(object a)
        {
            Landlord newLandlord = new Landlord
            {
                FirstName = _FirstName,
                LastName = _LastName,
            };

            AllLandlords.Add(newLandlord);

            _db.SaveChanges();
        }
    }
}
