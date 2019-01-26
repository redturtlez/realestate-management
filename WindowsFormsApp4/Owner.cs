using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApp4
{
    public class Owner
    {
        private string name, phone;
        private Agent realtor;
        public Owner(string namex, string phonex, Agent realtorx)
        {
            Name = namex;
            Phone = phonex;
            Realtor = realtorx;
           
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Phone
        {
            get { return phone; }
            set { phone = value; }
        }
      
        public Agent Realtor
        {
            get { return realtor; }
            set { realtor = value; }
        }

    }
}
