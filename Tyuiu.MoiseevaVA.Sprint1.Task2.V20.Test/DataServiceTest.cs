using Tyuiu.MoiseevaVA.Sprint1.Task2.V20.Lib;
namespace Tyuiu.MoiseevaVA.Sprint1.Task2.V20.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int value = 3;
            int valueTwo = 3;
            var res = ds.CalculateSquaresSumm(value, valueTwo);
            Assert.AreEqual(18, res);
        }
    }
}
