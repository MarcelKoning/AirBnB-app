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
    public class LandlordViewModel
    {
        public Landlord SelectedLandlord { get; set; }
        public ObservableCollection<Landlord> AllLandlords { get; set; }
        public ICommand UpdateClick { get; set; }
        public ICommand DeleteClick { get; set; }

        private DatabaseContext _db;
        public LandlordViewModel()
        {
            _db = new DatabaseContext();

            _db.Landlords.Load();

            AllLandlords = _db.Landlords.Local.ToObservableCollection();

            UpdateClick = new RelayCommand(UpdateLandlord);
            DeleteClick = new RelayCommand(DeleteLandlord);

        }
        private void UpdateLandlord(object a)
        {
            _db.SaveChanges();
        }
        private void DeleteLandlord(object a)
        {
            AllLandlords.Remove(SelectedLandlord);
            _db.SaveChanges();
        }
    }
}