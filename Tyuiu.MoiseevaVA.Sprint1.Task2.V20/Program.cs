using Tyuiu.MoiseevaVA.Sprint1.Task2.V20.Lib;
namespace Tyuiu.MoiseevaVA.Sprint1.Task2.V20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();


            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int value;
            int valueTwo;

            Console.WriteLine("Введите первое число:");
            value = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе число:");
            valueTwo = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(ds.CalculateSquaresSumm(value,valueTwo));
            Console.ReadLine();
        }
    }
}
