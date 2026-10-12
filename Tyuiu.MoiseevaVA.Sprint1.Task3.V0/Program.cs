using Tyuiu.MoiseevaVA.Sprint1.Task3.V1.Lib;
namespace Tyuiu.MoiseevaVA.Sprint1.Task3.V1
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
            double r = 12;
            double h = 17;
            Console.WriteLine("Радиус R цилиндра=" + r);
            Console.WriteLine("Высота H цилиндра=" + h);

            Console.WriteLine("*                                                                       * ");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                             * ");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("Обьем цилиндра=" + ds.CylinderVolume(r, h));
            Console.ReadKey();

        }

    }
}
