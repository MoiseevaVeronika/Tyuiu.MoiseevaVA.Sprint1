using Tyuiu.MoiseevaVA.Sprint1.Task4.V16.Lib;
namespace Tyuiu.MoiseevaVA.Sprint1.Task4.V16.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 4;
            double wait = 0.125;
            var res = ds.Calculate(x);
            Assert.AreEqual(wait, res);
        }
    }
}
