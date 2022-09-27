using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Collections.ObjectModel;


namespace Eindopdracht.Model
{
    public class Reservation : INotifyPropertyChanged
    {
        private DateTime start_date;
        private DateTime end_date;
        private House house;
        private float price;

        public int Id { get; set; }
        public DateTime Start_date
        {
            get
            {
                return start_date;
            }
            set
            {
                start_date = value;
                OnPropertyChanged("Start_date");
            }
        }
        public DateTime End_date
        {
            get
            {
                return end_date;
            }
            set
            {
                end_date = value;
                OnPropertyChanged("End_date");
            }
        }
        public virtual House House
        {
            get
            {
                return house;
            }
            set
            {
                house = value;
                OnPropertyChanged("House");
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
        public virtual Customer Customer { get; set; }

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
