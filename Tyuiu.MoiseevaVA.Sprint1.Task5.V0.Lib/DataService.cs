
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.MoiseevaVA.Sprint1.Task5.V0.Lib
{
    public class DataService : ISprint1Task5V0
    {
        public double Calculate(double x)
        {
            double res = Math.Pow(x, 2) / Math.Sqrt(x);
            return res;

        }
    }
}
