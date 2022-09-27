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
    public class ReservationViewModel
    {
        public Reservation SelectedReservation { get; set; }
        public ObservableCollection<Reservation> AllReservations { get; set; }
        public ICommand DeleteReservationClick { get; set; }

        private DatabaseContext _db;
        public ReservationViewModel()
        {
            _db = new DatabaseContext();

            _db.Reservations.Load();

            AllReservations = _db.Reservations.Local.ToObservableCollection();

            DeleteReservationClick = new RelayCommand(DeleteReservation);

        }
        private void DeleteReservation(object a)
        {
            AllReservations.Remove(SelectedReservation);
            _db.SaveChanges();
        }
    }
}