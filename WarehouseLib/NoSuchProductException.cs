using System;
using System.Collections.Generic;
using System.Text;

namespace WarehouseLib
{
    [Serializable]
    class NoSuchProductException : Exception
    {
        public NoSuchProductException()
        {

        }
        public NoSuchProductException(string product)
            : base(String.Format("No such product: {0}", product))
        {

        }
    }
}
