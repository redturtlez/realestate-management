using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApp4
{
    public class Agent
    {
        private string name, phone, company;
        public Agent(string namex, string phonex, string companyx)
        {
            Name = namex;
            Phone = phonex;
            Company = companyx;
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
        public string Company
        {
            get { return company; }
            set { company = value; }
        }
    }
}
