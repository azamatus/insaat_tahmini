using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Estimate
    {
        private int id;
        private string denotation;
        private string unit;
        private double quantity;
        private double price;
        private double total;
        private int customerId;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Unit
        {
            get { return unit; }
            set { unit = value; }
        }

        public double Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }

        public double Price
        {
            get { return price; }
            set { price = value; }
        }


        public int CustomerId
        {
            get { return customerId; }
            set { customerId = value; }
        }

        public double Total
        {
            get { return total; }
            set { total = value; }
        }

        public string Denotation
        {
            get { return denotation; }
            set { denotation = value; }
        }
    }
}
