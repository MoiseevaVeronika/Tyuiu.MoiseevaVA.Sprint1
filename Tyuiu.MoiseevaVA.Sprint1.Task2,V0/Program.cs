using Tyuiu.MoiseevaVA.Sprint1.Task2.V0.Lib;
namespace Tyuiu.MoiseevaVA.Sprint1.Task2.V0
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
            Console.WriteLine("* Заданы два числа. Вычислить сумму их квадратов                         * ");
            Console.WriteLine("*                                                                        * ");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       * ");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("*                                                                       * ");
            int x;
            
            Console.WriteLine("Введите значение X:");
            x = Convert.ToInt32(Console.ReadLine());
            int y;
            Console.WriteLine("Введите значение Y:");
            y = Convert.ToInt32(Console.ReadLine());
            int z;
            z = x + y;
           



            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                             x* ");
            Console.WriteLine("**************************************************************************");

            Console.WriteLine("Квадрат числа x=" + ds.Sqr(x));
            Console.WriteLine("Квадрат числа y=" + ds.Sqr(y));
            Console.WriteLine("Сумма квадратов=" + (z));
            Console.ReadLine();

        }
    }
}
