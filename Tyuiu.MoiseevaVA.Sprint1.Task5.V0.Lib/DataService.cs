
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.MoiseevaVA.Sprint1.Task5.V6.Lib
{
    public class DataService : ISprint1Task5V6
    {
        public double Calculate(double x)
        {
            double res = Math.Pow(x, 2) / Math.Sqrt(x);
            return res;

        }

        public int Calculate(int k)
        {
            throw new NotImplementedException();
        }
    }
}
