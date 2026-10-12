using System;
using Tyuiu.MoiseevaVA.Sprint1.Task5.V6.Lib;
namespace Tyuiu.MoiseevaVA.Sprint1.Task5.V6
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

            Console.WriteLine("Введите значение X:");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("*                                                                       * ");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                             * ");
            Console.WriteLine("**************************************************************************");

            int res = Convert.ToInt32(ds.Calculate(x));
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
