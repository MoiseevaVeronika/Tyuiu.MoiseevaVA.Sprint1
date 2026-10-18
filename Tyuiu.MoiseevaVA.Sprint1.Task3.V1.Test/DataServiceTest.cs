using Tyuiu.MoiseevaVA.Sprint1.Task3.V1.Lib;
namespace Tyuiu.MoiseevaVA.Sprint1.Task3.V1.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double r = 3;
            double h = 3;
            double wait = 84.823;
            var res = ds.CylinderVolume(r, h);
            Assert.AreEqual(wait, res);
        }
    }
}
