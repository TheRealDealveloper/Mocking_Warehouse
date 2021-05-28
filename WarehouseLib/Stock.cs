using System;
using System.Collections.Generic;
using System.Text;

namespace WarehouseLib
{
    public class Stock
    {
        private int amount;
        private string product;
        public int Amount 
        {
            get
            {
                return this.amount;
            }
            set
            {
                this.amount = value;
            }
        }
        public string Product
        {
            get
            {
                return this.product;
            }
            set
            {
                this.product = value;
            }
        }
    }
}
