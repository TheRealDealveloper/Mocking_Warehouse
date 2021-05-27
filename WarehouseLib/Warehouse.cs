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

            if (HasProduct(product) == false)
            {
                throw new NoSuchProductException(product);
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

            if (HasProduct(product) == false)
            {
                throw new NoSuchProductException(product);
            }

            if (CurrentStock(product) < amount)
            {
                throw new InsufficientStockException(amount);
            }

            throw new NotImplementedException();
        }
    }
}
