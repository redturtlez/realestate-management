using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApp4
{
    public class Apartment: Property
    {
        private double rent;
        private AddressApartment location;
        public Apartment(string descriptionx, string statusx, string stylex, double sizex, int agex, double rentx, AddressApartment locationx, int idx, Owner ownerx, Agent agentx) : base(descriptionx, statusx, stylex, sizex, agex, idx, ownerx, agentx)
        {
            Rent = rentx;
            Location = locationx;
        }
        public AddressApartment Location
        {
            get { return location; }
            set { location = value; }
        }
        public double Rent
        {
            get { return rent; }
            set { rent = value; }
        }
        public string ApartmentAddress()
        {
            return Location.Housenumber + " " + Location.Street + ", " + Location.City + ", " + Location.State + ", " + Location.Zip+", apt "+Location.ApartmentNumber;
        }
    }
}
