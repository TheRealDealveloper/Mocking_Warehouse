using System;

namespace WarehouseLib
{
    public class Order : IOrder
    {
        private IWarehouse warehouse;
        private string product;
        private int amount;
        //private bool canfillorder;
        //private bool isfilled;

        //public bool Canfillorder 
        //{
        //    get
        //    {
        //        return this.canfillorder;
        //    }
        //    set
        //    {
        //        this.canfillorder = value;
        //    }
        //}
        //public bool Isfilled
        //{
        //    get
        //    {
        //        return this.isfilled;
        //    }
        //    set
        //    {
        //        this.isfilled = value;
        //    }
        //}
        public Order(string product, int amount)
        {
            this.product = product;
            this.amount = amount;
            if (String.IsNullOrWhiteSpace(product) || amount < 1)
            {
                throw new ArgumentException();
            }
        }
        public bool CanFillOrder(IWarehouse warehouse)
        {
            if (warehouse.HasProduct(this.product) && warehouse.CurrentStock(this.product) > 0)
            {
                
            }
            return true;
        }

        public void Fill(IWarehouse warehouse)
        {
            try
            {
                if (!CanFillOrder(warehouse))
                {
                    throw new OrderAlreadyFilledException();
                }
                else
                {
                    warehouse.AddStock(product, amount);
                }
            }
            catch(Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public bool IsFilled()
        {
            try
            {
                Fill(warehouse);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
