using Tyuiu.MoiseevaVA.Sprint1.Task0.V24.Lib;
namespace Tyuiu.MoiseevaVA.Sprint1.Task0.V24
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
            Console.WriteLine("* Написать программуЮ которая вычисляет выражение 2*4/4/2+1              * ");
            Console.WriteLine("* и печатает результат на экране                                         * ");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       * ");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* 2*4/4/2+1                                                             * ");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                             * ");
            Console.WriteLine("**************************************************************************");

            Console.WriteLine(ds.Calculate());
            Console.ReadLine();
        }
    }
}
