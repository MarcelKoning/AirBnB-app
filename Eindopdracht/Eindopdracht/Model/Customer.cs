using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace Eindopdracht.Model
{
    public class Customer : INotifyPropertyChanged
    {
        private string firstName;
        private string lastName;
        private int age;
        private string email;
        private int phonenumber;
        private string streetname;
        private string houseNumber;
        private string city;
        private string postalCode;
        private string country;

        [ForeignKey("Reservation")]
        public int ReservationId { get; set; }
        public int Id { get; set; }
        public string FirstName
        {
            get
            {
                return firstName;
            }
            set
            {
                firstName = value;
                OnPropertyChanged("FirstName");
            }
        }
        public string LastName
        {
            get
            {
                return lastName;
            }
            set
            {
                lastName = value;
                OnPropertyChanged("LastName");
            }
        }
        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                age = value;
                OnPropertyChanged("Age");
            }
        }
        public string Email
        {
            get
            {
                return email;
            }
            set
            {
                email = value;
                OnPropertyChanged("Email");
            }
        }
        public int Phonenumber
        {
            get
            {
                return phonenumber;
            }
            set
            {
                phonenumber = value;
                OnPropertyChanged("Phonenumber");
            }
        }
        public string Streetname
        {
            get
            {
                return streetname;
            }
            set
            {
                streetname = value;
                OnPropertyChanged("Streetname");
            }
        }
        public string HouseNumber
        {
            get
            {
                return houseNumber;
            }
            set
            {
                houseNumber = value;
                OnPropertyChanged("HouseNumber");
            }
        }
        public string City
        {
            get
            {
                return city;
            }
            set
            {
                city = value;
                OnPropertyChanged("City");
            }
        }
        public string PostalCode
        {
            get
            {
                return postalCode;
            }
            set
            {
                postalCode = value;
                OnPropertyChanged("PostalCode");
            }
        }
        public string Country
        {
            get
            {
                return country;
            }
            set
            {
                country = value;
                OnPropertyChanged("Country");
            }
        }
        public virtual Reservation Reservation { get; set; }



        #region INotifyPropertyChanged Members 

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        #endregion
    }
}
