using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApp4
{
    public class AddressApartment:AddressHouse
    {
        private string apartmentNumber;
        public AddressApartment(int housenumberx, string streetx, string cityx, string statex, int zipx, string apartmentnumberx):base( housenumberx, streetx, cityx, statex, zipx)
        {
            ApartmentNumber = apartmentnumberx;
        }
        public string ApartmentNumber
        {
            get { return apartmentNumber; }
            set { apartmentNumber = value; }
        }
       
    }
}
