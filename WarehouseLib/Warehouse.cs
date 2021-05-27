using System;
using System.Collections.Generic;
using System.Text;

namespace WarehouseLib
{
    class Warehouse : IWarehouse
    {
        public void AddStock(string product, int amount)
        {
            if (String.IsNullOrWhiteSpace(product))
            {
                throw new ArgumentException();
            }
            throw new NotImplementedException();
        }

        public int CurrentStock(string product)
        {
            if (String.IsNullOrWhiteSpace(product))
            {
                throw new ArgumentException();
            }
            throw new NotImplementedException();
        }

        public bool HasProduct(string product)
        {
            if (String.IsNullOrWhiteSpace(product))
            {
                throw new ArgumentException();
            }
            throw new NotImplementedException();
        }

        public void TakeStock(string product, int amount)
        {
            if (String.IsNullOrWhiteSpace(product))
            {
                throw new ArgumentException();
            }
            throw new NotImplementedException();
        }
    }
}
