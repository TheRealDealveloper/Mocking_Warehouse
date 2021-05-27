using System;
using System.Collections.Generic;
using System.Text;

namespace WarehouseLib
{
    class Warehouse : IWarehouse
    {
        public List<Stock> Stocks { get; set; }
        public void AddStock(string product, int amount)
        {
            if (String.IsNullOrWhiteSpace(product))
            {
                throw new ArgumentException();
            }

            Stocks.Add(new Stock
            {
                Product = product,
                Amount = amount
            });
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

            foreach (var stock in Stocks)
            {
                if (stock.Product == product)
                {
                    return stock.Amount;
                }
            }
            return 0;
        }

        public bool HasProduct(string product)
        {
            if (String.IsNullOrWhiteSpace(product))
            {
                throw new ArgumentException();
            }
            foreach (var stock in Stocks)
            {
                if (stock.Product == product)
                {
                    return true;
                }
            }
            return false;
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

            foreach (var stock in Stocks)
            {
                if (stock.Product == product)
                {
                    //void
                }
            }
        }

        public Warehouse()
        {
            this.Stocks = new List<Stock>();
        }
    }
}
