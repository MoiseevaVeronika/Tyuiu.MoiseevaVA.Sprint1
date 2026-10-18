using Tyuiu.MoiseevaVA.Sprint1.Task7.V26.Lib;
namespace Tyuiu.MoiseevaVA.Sprint1.Task7.V26.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 1;
            double y = 2;
            double wait = 1.233;
            var res = ds.Calculate (x, y);

        }
    }
}
