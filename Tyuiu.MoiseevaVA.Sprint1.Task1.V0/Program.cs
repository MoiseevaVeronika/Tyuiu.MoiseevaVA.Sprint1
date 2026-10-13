using Tyuiu.MoiseevaVA.Sprint1.Task1.V0.Lib;
namespace Tyuiu.MoiseevaVA.Sprint1.Task1.V0
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
            Console.WriteLine("* Написать программуЮ которая запрашивает у пользователя исходные данные  * ");
            Console.WriteLine("* вычисляет результат по формуле x/(y-1) и печатает его на экране         * ");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       * ");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("*                                                             * ");
          
            double x, y;
            Console.WriteLine("Введите значение X:");
            x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение Y:");
            y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                             * ");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine(ds.Calculate(x, y));
            Console.ReadLine();


        }
    }
}
