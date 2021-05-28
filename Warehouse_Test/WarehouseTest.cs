using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using WarehouseLib;

namespace Warehouse_Test
{
    [TestClass]
    public class WarehouseTest
    {
        [DataTestMethod]
        [DataRow("shirt", 3)]
        [DataRow("pants", 4)]
        public void WareHouseAddStockAndCheckIfItIsAdded(string product, int amount)
        {

            IWarehouse warehouse = new Warehouse();
            var temp = new Order(product, amount);
            warehouse.AddStock(product, amount);

            Assert.AreEqual(true, warehouse.HasProduct(product));
        }
        [DataTestMethod]
        [DataRow("shirt", 3)]
        [DataRow("pants", 4)]
        public void WareHouseAddStockAndCheckTheAmount(string product, int amount)
        {

            IWarehouse warehouse = new Warehouse();
            var temp = new Order(product, amount);
            warehouse.AddStock(product, amount);

            Assert.AreEqual(amount, warehouse.CurrentStock(product));
        }

        
        [DataTestMethod]
        [DataRow("shirt", 3)]
        [DataRow("pants", 4)]
        [ExpectedException(typeof(NoSuchProductException))]
        public void WareHouseCheckAmountWithoutAdding(string product, int amount)
        {

            IWarehouse warehouse = new Warehouse();
            var temp = new Order(product, amount);

            Assert.AreEqual(amount, warehouse.CurrentStock(product));
        }
        [DataTestMethod]
        [DataRow("shirt", 3)]
        [DataRow("pants", 4)]
        [ExpectedException(typeof(NoSuchProductException))]
        public void WareHouseTakeStockWithoutProduct(string product, int amount)
        {

            IWarehouse warehouse = new Warehouse();
            var temp = new Order(product, amount);
            warehouse.TakeStock(product, 1);
        }

        [DataTestMethod]
        [DataRow("shirt", 3)]
        public void WareHouseHasStock(string product, int amount)
        {
            var mock = new Moq.Mock<IWarehouse>();

            IWarehouse warehouse = mock.Object;

            Assert.AreEqual(false, warehouse.HasProduct(product));
        }
        [DataTestMethod]
        [DataRow("shirt", 3)]
        public void WareHouseCanFillOrder(string product, int amount)
        {
            var mock = new Moq.Mock<IWarehouse>();

            IWarehouse warehouse = mock.Object;
            IOrder ord = new Order(product, amount);

            Assert.AreEqual(true, ord.CanFillOrder(warehouse));
        }
        [DataTestMethod]
        [DataRow("shirt", 3)]
        [DataRow("pants", 4)]
        [ExpectedException(typeof(InsufficientStockException))]
        public void WareHouseTakeStockWithInsufficientStock(string product, int amount)
        {

            IWarehouse warehouse = new Warehouse();
            var temp = new Order(product, amount);
            warehouse.AddStock(product, amount);
            warehouse.TakeStock(product, 100);
        }
        [DataTestMethod]
        [DataRow("", 3)]
        [ExpectedException(typeof(ArgumentException))]
        public void WareHouseHasProductInvalidName(string product, int amount)
        {

            IWarehouse warehouse = new Warehouse();
            var temp = new Order(product, amount);
            warehouse.HasProduct(product);
        }
        [DataTestMethod]
        [DataRow("", 3)]
        [ExpectedException(typeof(ArgumentException))]
        public void WareHouseCurrentStockInvalidName(string product, int amount)
        {

            IWarehouse warehouse = new Warehouse();
            var temp = new Order(product, amount);
            warehouse.CurrentStock(product);
        }
        [DataTestMethod]
        [DataRow("", 3)]
        [ExpectedException(typeof(ArgumentException))]
        public void WareHouseAddStockInvalidName(string product, int amount)
        {

            IWarehouse warehouse = new Warehouse();
            var temp = new Order(product, amount);
            warehouse.AddStock(product, amount);
        }
        [DataTestMethod]
        [DataRow("", 3)]
        [ExpectedException(typeof(ArgumentException))]
        public void WareHouseTakeStockInvalidName(string product, int amount)
        {

            IWarehouse warehouse = new Warehouse();
            var temp = new Order(product, amount);
            warehouse.TakeStock(product,amount);
        }
    }
}
