using Microsoft.VisualStudio.TestTools.UnitTesting;
using WarehouseLib;

namespace Warehouse_Test
{
    [TestClass]
    public class WarehouseTest
    {
        [DataTestMethod]
        [DataRow("shirt", 3)]
        [DataRow("shoes", 4)]
        public void WareHouseHasStock(string product, int amount)
        {
            
            
            var mock = new Moq.Mock<IWarehouse>();
            mock.Setup(o => o.HasProduct(product)).Returns(true);

            IWarehouse warehouse = mock.Object;
            var temp = new Order(product, amount);

            
            Assert.AreEqual(true, temp.CanFillOrder(warehouse));
            mock.Verify(o => o.HasProduct(product), Moq.Times.Once);
        }
        //[DataTestMethod]
        //[DataRow("shirt", 3)]
        //[DataRow("shoes", 4)]
        //public void WareHouseHasStock(string product, int amount)
        //{
        //    var temp = new Warehouse(new Order(product, amount));

        //    Assert.AreEqual(false, temp.HasProduct(product));
        //}
        //[DataTestMethod]
        //[DataRow("shirt", 3)]
        //[DataRow("shoes", 4)]
        //public void WareHouseAddStock(string product, int amount)
        //{
        //    IWarehouse obj = new Warehouse(new Order(product, amount);
        //    var mock = new Moq.Mock<IOrder>();
        //    mock.Setup(od => od.Fill(obj)).Verifiable(void);
        //    IOrder ord = mock.Object;
        //    var temp = new Warehouse(ord);

        //    Assert.AreEqual(void, temp.AddStock(product, amount));
        //}

        //[DataTestMethod]
        //[DataRow("shirt", 3)]
        //[DataRow("shoes", 4)]
        //public void WareHouseHasStockMock(string product, int amount)
        //{
        //    var mock = new Moq.Mock<IOrder>();
        //    IOrder ord = mock.Object;
        //    var temp = new Warehouse(ord);

        //    Assert.AreEqual(false, temp.HasProduct(product));
        //}
    }
}
