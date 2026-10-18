using Tyuiu.MoiseevaVA.Sprint1.Task0.V24.Lib;
namespace Tyuiu.MoiseevaVA.Sprint1.Task0.V24.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            var res = ds.Calculate();
            Assert.AreEqual(2, res);
        }
    }
}
