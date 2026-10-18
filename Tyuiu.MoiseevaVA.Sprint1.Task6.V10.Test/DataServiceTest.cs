using Tyuiu.MoiseevaVA.Sprint1.Task6.V10.Lib;
namespace Tyuiu.MoiseevaVA.Sprint1.Task6.V10.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string value = "привет мир кот";
            // "привет" (6 - четное, не трогаем)
            // "мир" (3 - нечетное, удаляем 'и' -> "мр")
            // "кот" (3 - нечетное, удаляем 'о' -> "кт")
            string expected = "привет мр кт";

            // Act
            string actual = ds.DeleteMiddleLetter(value);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ValidDeleteMiddleLetterWithPunctuation()
        {
            // Arrange
            DataService ds = new DataService();
            string value = "стол, стул!";
            string expected = "стол, стул!";

            // Act
            string actual = ds.DeleteMiddleLetter(value);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
