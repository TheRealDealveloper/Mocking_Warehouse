using System;
using System.Collections.Generic;
using System.Text;

namespace WarehouseLib
{
    [Serializable]
    public class InsufficientStockException : Exception
    {
        public InsufficientStockException()
        {

        }
        public InsufficientStockException(int amount)
            : base(String.Format("Amount {0} exceeds current store", amount))
        {

        }
    }
}
