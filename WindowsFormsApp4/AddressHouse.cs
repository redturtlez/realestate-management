using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApp4
{
    public class AddressHouse
    {
        private int housenumber, zip;
        private string street, city, state;
        public AddressHouse(int housenumberx, string streetx, string cityx, string statex, int zipx)
        {
            Housenumber = housenumberx;
            Street = streetx;
            City = cityx;
            State = statex;
            Zip = zipx;
        }
        public int Housenumber
        {
            get { return housenumber; }
            set { housenumber = value; }
        }
        public int Zip
        {
            get { return zip; }
            set { zip = value; }
        }
        public string Street
        {
            get { return street; }
            set { street = value; }
        }
        public string City
        {
            get { return city; }
            set { city = value; }
        }
        public string State
        {
            get { return state; }
            set { state = value; }
        }
       
    }
}
