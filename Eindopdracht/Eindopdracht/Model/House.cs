using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Eindopdracht.Model
{
    public class House : INotifyPropertyChanged
    {
        /*
         * Type (bungalow, house, apartment), location (new model), Max (person), Bedroom, BedTotal, Bathroom
         * Landlord, Price
         * Adding png later in project to show the house. 
         */
        private string houseName;
        private string houseDescription;
        private Landlord landlord;
        private HouseTypes houseType;
        private int maxPerson;
        private float price;
        private int bedroomTotal;
        private int bedTotal;
        private int bathroomTotal;
        private bool smokingAllowed;
        private string streetname;
        private string houseNumber;
        private string city;
        private string postalCode;
        private string country;

        public int Id { get; set; }

        public string HouseName
        {
            get
            {
                return houseName;
            }
            set
            {
                houseName = value;
                OnPropertyChanged("HouseName");
            }
        }
        public string HouseDescription
        {
            get
            {
                return houseDescription;
            }
            set
            {
                houseDescription = value;
                OnPropertyChanged("HouseDescription");
            }
        }
        public virtual Landlord Landlord
        {
            get
            {
                return landlord;
            }
            set
            {
                landlord = value;
                OnPropertyChanged("Landlord");
            }
        }
        public HouseTypes HouseType
        {
            get
            {
                return houseType;
            }
            set
            {
                houseType = value;
                OnPropertyChanged("HouseType");
            }
        }
        public int MaxPerson
        {
            get
            {
                return maxPerson;
            }
            set
            {
                maxPerson = value;
                OnPropertyChanged("MaxPerson");
            }
        }
        public float Price
        {
            get
            {
                return price;
            }
            set
            {
                price = value;
                OnPropertyChanged("Price");
            }
        }
        public int BedroomTotal
        {
            get
            {
                return bedroomTotal;
            }
            set
            {
                bedroomTotal = value;
                OnPropertyChanged("BedroomTotal");
            }
        }
        public int BedTotal
        {
            get
            {
                return bedTotal;
            }
            set
            {
                bedTotal = value;
                OnPropertyChanged("BedTotal");
            }
        }
        public int BathroomTotal
        {
            get
            {
                return bathroomTotal;
            }
            set
            {
                bathroomTotal = value;
                OnPropertyChanged("BathroomTotal");
            }
        }
        public bool SmokingAllowed
        {
            get
            {
                return smokingAllowed;
            }
            set
            {
                smokingAllowed = value;
                OnPropertyChanged("SmokingAllowed");
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
        public enum HouseTypes
        {
            Bungalow,
            Apartment,
            Castle,
            House,
            Hotel
        }

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
