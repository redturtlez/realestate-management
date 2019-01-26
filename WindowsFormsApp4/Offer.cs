using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApp4
{
    public class Offer
    {
        private string name;
        private double amount;
        private int id;
        public Offer(int idx, string namex, double amountx)
        {
            Name = namex;
            Amount = amountx;
            Id=idx;
        }
       public int Id
         {
        get { return id; }
        set { id = value; }
         }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public double Amount
        {
            get { return amount; }
            set { amount = value; }
        }
    }
}
