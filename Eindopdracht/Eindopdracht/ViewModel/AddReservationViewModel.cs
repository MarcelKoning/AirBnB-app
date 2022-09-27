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
    public class AddReservationViewModel
    {
        public ObservableCollection<House> AllHouses { get; set; }
        public ObservableCollection<Reservation> AllReservations { get; set; }

        public ObservableCollection<Customer> AllCustomers { get; set; }
        public DateTime _Start_date { get; set; }
        public DateTime _End_date { get; set; }
        public float _Price { get; set; }
        public Customer _Customer { get; set; }
        public House _House { get; set; }
        public string _FirstName { get; set; }
        public string _LastName { get; set; }
        public int _Age { get; set; }
        public string _Email { get; set; }
        public int _Phonenumber { get; set; }
        public string _Streetname { get; set; }
        public string _HouseNumber { get; set; }
        public string _City { get; set; }
        public string _PostalCode { get; set; }
        public string _Country { get; set; }

        public ICommand AddNewReservationClick { get; set; }

        private DatabaseContext _db;

        public AddReservationViewModel()
        {
            _db = new DatabaseContext();

            _db.Houses.Load();
            _db.Reservations.Load();

            AllHouses = _db.Houses.Local.ToObservableCollection();

            AllReservations = _db.Reservations.Local.ToObservableCollection();

            AllCustomers = _db.Customers.Local.ToObservableCollection();

            _Start_date = DateTime.Today;
            _End_date = DateTime.Today;

            AddNewReservationClick = new RelayCommand(AddNewReservation);

        }
        private void AddNewReservation(object a)
        {
            double totalDays = (_End_date - _Start_date).TotalDays;

            _Price = _House.Price * (float)totalDays;

            Customer newCustomer = new Customer
            {
                FirstName = _FirstName,
                LastName = _LastName,
                Age = _Age,
                Email = _Email,
                Phonenumber = _Phonenumber,
                Streetname = _Streetname,
                HouseNumber = _HouseNumber,
                City = _City,
                PostalCode = _PostalCode,
                Country = _Country,
            };

            AllCustomers.Add(newCustomer);

            Reservation newReservation = new Reservation
            {
                Start_date = _Start_date,
                End_date = _End_date,
                Price = _Price,
                Customer = newCustomer,
                House = _House
            };

            AllReservations.Add(newReservation);

            _db.SaveChanges();
        }
    }
}
