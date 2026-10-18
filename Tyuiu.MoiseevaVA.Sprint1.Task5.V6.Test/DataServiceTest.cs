using Tyuiu.MoiseevaVA.Sprint1.Task5.V6.Lib;
namespace Tyuiu.MoiseevaVA.Sprint1.Task5.V6.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            int k = 5;
            DataService ds = new DataService();
            int res = ds.Calculate(k);
            int wait = 5;
            Assert.AreEqual(wait, res);
        }
    }
}
