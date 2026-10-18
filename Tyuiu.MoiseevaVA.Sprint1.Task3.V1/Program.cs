using Tyuiu.MoiseevaVA.Sprint1.Task3.V1.Lib;
namespace Tyuiu.MoiseevaVA.Sprint1.Task3.V1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();


            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            double r;
            double h;

            Console.WriteLine("Введите первое число:");
            r = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе число:");
            h = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(ds.CylinderVolume(r,h));
            Console.ReadLine();
        }
    }
}
