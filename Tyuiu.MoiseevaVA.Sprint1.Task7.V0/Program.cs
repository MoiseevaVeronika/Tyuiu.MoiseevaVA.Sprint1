using Tyuiu.MoiseevaVA.Sprint1.Task7.V0.Lib;
namespace Tyuiu.MoiseevaVA.Sprint1.Task7.V0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       * ");
            Console.WriteLine("**************************************************************************");

            Console.WriteLine("           y-z");
            Console.WriteLine("         -------");
            Console.WriteLine("          (y-x)");
            Console.WriteLine("f=(y-x)-------------");
            Console.WriteLine("                    2");
            Console.WriteLine("           1+(y-x)");
            double x, y, z;
            Console.WriteLine("Введите значение X:");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите значение Y:");
            y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите значение Z:");
            z = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("*                                                                       * ");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                             * ");
            Console.WriteLine("**************************************************************************");

            Console.WriteLine(ds.Calculate(x,y,z));
            Console.ReadKey();

        }

    }
}
