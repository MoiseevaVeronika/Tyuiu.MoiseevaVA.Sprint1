using Tyuiu.MoiseevaVA.Sprint1.Task6.V10.Lib;
namespace Tyuiu.MoiseevaVA.Sprint1.Task6.V10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #1/ Выполнила Моисеева В.А / ПИНб-26.1";
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* Спринт #1                                                             * ");
            Console.WriteLine("* Тема: Базовые навыки работы в С#                                      * ");
            Console.WriteLine("* Задание #0                                                            * ");
            Console.WriteLine("* Вариант #0                                                            * ");
            Console.WriteLine("* Выполнила Моисеева В.А / ПИНб-26.1                                    * ");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                               * ");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные, выполняет указанные расчёты* ");
            Console.WriteLine("*выполняет указанные расчёты и печатает результат на экране                             * ");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       * ");
            Console.WriteLine("**************************************************************************");

            Console.WriteLine("Введите строку: ");
            string str = Console.ReadLine();

            Console.WriteLine("*                                                                       * ");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                             * ");
            Console.WriteLine("**************************************************************************");

            Console.WriteLine(ds.WorkWithText(str));
            Console.ReadKey();

        }
    }
}
