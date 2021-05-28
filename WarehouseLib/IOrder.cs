using System;
using System.Collections.Generic;
using System.Text;

namespace WarehouseLib
{
    public interface IOrder
    {
        bool IsFilled();
        bool CanFillOrder(IWarehouse warehouse);
        void Fill(IWarehouse warehouse);
    }
}
