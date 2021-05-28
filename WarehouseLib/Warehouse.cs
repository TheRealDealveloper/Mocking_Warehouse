using System;
using System.Collections.Generic;
using System.Text;

namespace WarehouseLib
{
    public class Warehouse : IWarehouse
    {
        private IOrder order;
        //public List<Stock> Stocks { get; set; }
        public void AddStock(string product, int amount)
        {
            if (String.IsNullOrWhiteSpace(product))
            {
                throw new ArgumentException();
            }

            //Stocks.Add(new Stock
            //{
            //    Product = product,
            //    Amount = amount
            //});
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

            
            return 1;
        }

        public bool HasProduct(string product)
        {
            if (String.IsNullOrWhiteSpace(product))
            {
                throw new ArgumentException();
            }
            return true;
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
            
        }

        public Warehouse()
        {
        }
    }
}
