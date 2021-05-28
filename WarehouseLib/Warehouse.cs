using System;
using System.Collections.Generic;
using System.Text;

namespace WarehouseLib
{
    public class Warehouse : IWarehouse
    {
        private IOrder order;

        private Dictionary<string, int> stocks = new Dictionary<string, int>();
        public void AddStock(string product, int amount)
        {
            if (String.IsNullOrWhiteSpace(product))
            {
                throw new ArgumentException();
            }
            if (stocks.TryGetValue(product, out int num))
            {
                int temp = num + amount;
                stocks.Remove(product);
                stocks.Add(product, temp);
            }
            else
            {
                stocks.Add(product, amount);
            }
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

            stocks.TryGetValue(product, out int num);

            return num;
        }

        public bool HasProduct(string product)
        {
            if (String.IsNullOrWhiteSpace(product))
            {
                throw new ArgumentException();
            }
            if (stocks.ContainsKey(product))
            {
                return true;
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

            stocks.TryGetValue(product, out int num);
            int temp = num + amount;
            stocks.Remove(product);
            stocks.Add(product, temp);

        }

        public Warehouse()
        {
        }

        public Warehouse(IOrder order)
        {
            this.order = order;
        }
    }
}
