using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApp4
{
    public class Property
    {
        private string description, status, style;
        private double size;
        private int age, id;
        private Agent realtor;
        private Owner propertyOwner;
        private Offer highestOffer;
        public Property(string descrptionx, string statusx, string stylex, double sizex, int agex, int idx, Owner propertyOwnerx, Agent realtorx)
        {
            Description = descrptionx;
            Status = statusx;
            Style = stylex;
            Size = sizex;
            Age = agex;
            Id = idx;
            PropertyOwner = propertyOwnerx;
            Realtor = realtorx;
        }
        public Owner PropertyOwner
        {
            get { return propertyOwner; }
            set { propertyOwner = value; }
        }
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public Agent Realtor
        {
            get { return realtor; }
            set { realtor = value; }
        }
        public string Description
        {
            get { return description;}
            set { description = value; }
        }
        public string Status
        {
            get { return status; }
            set { status = value; }
        }
        public string Style
        {
            get { return style; }
            set { style = value; }
        }
        public double Size
        {
            get { return size; }
            set { size = value; }
        }
        public int Age
        {
            get { return age;}
            set { age = value; }
        }
        public Offer HighestOffer
        {
            get { return highestOffer;}
            set { highestOffer = value; }
        }
        
    }
}
