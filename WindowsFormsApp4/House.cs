using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApp4
{
    public class House: Property
    {
        private double price;
        private AddressHouse location;
        public House(string descriptionx, string statusx, string stylex, double sizex, int agex, double pricex, AddressHouse locationx, int idx, Owner ownerx, Agent agentx) : base(descriptionx, statusx, stylex, sizex, agex, idx, ownerx, agentx)
        {
            Price = pricex;
            Location = locationx;
        }
        public AddressHouse Location
        {
            get { return location; }
            set { location = value; }
        }
        public double Price
        {
            get { return price; }
            set { price = value; }
        }
        public string HouseAddress()
        {
            return Location.Housenumber + " " + Location.Street + ", " + Location.City + ", " + Location.State + ", " + Location.Zip;
        }
    }
}
