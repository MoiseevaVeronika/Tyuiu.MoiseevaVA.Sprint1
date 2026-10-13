using Tyuiu.MoiseevaVA.Sprint1.Task2.V0.Lib;
namespace Tyuiu.MoiseevaVA.Sprint1.Task2.V0.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int x = 2;
            var res = ds.Sqr(x);
            Assert.AreEqual(4, res);
            int y = 2;
            var res = ds.Sqr(y);
            Assert.AreEqual(4, res);
            

        }
    }
}
