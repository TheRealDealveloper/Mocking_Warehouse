using System;
using System.Collections.Generic;
using System.Text;

namespace WarehouseLib
{
    [Serializable]
    public class OrderAlreadyFilledException : Exception
    {
        public OrderAlreadyFilledException()
        {

        }
        public OrderAlreadyFilledException(string product)
            : base(String.Format("Order already filled: {0}", product))
        {

        }
    }
}
