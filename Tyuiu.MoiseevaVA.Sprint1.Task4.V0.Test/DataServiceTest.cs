using Tyuiu.MoiseevaVA.Sprint1.Task4.V0.Lib;
namespace Tyuiu.MoiseevaVA.Sprint1.Task4.V0.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 2;
            double y = 2;
            double wait = 0.125;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);


        }
    }
}
