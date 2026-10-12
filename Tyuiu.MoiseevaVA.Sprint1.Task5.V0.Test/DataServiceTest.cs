using Tyuiu.MoiseevaVA.Sprint1.Task5.V0.Lib;
namespace Tyuiu.MoiseevaVA.Sprint1.Task5.V0.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            double x = 15;
            DataService ds = new DataService();
            double res = ds.Calculate(x);
            int result = Convert.ToInt32(res);
            int wait = 58;
            Assert.AreEqual(wait, result);

        }
    }
}
