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
    public class UpdateReservationViewModel
    {
        public Reservation SelectedReservation{ get; set; }
        public ObservableCollection<House> AllHouses { get; set; }
        public ObservableCollection<Reservation> AllReservations { get; set; }

        public ObservableCollection<Customer> AllCustomers { get; set; }

        public ICommand UpdateReservationClick { get; set; }

        private DatabaseContext _db;

        public UpdateReservationViewModel()
        {
            _db = new DatabaseContext();

            _db.Houses.Load();
            _db.Reservations.Load();

            AllHouses = _db.Houses.Local.ToObservableCollection();

            AllReservations = _db.Reservations.Local.ToObservableCollection();

            AllCustomers = _db.Customers.Local.ToObservableCollection();

            UpdateReservationClick = new RelayCommand(UpdateReservation);
        }
        private void UpdateReservation(object a)
        {
            double totalDays = (SelectedReservation.End_date - SelectedReservation.Start_date).TotalDays;

            SelectedReservation.Price = SelectedReservation.House.Price * (float)totalDays;

            _db.SaveChanges();
        }
    }
}
