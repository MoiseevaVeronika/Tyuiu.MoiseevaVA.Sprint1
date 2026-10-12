using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.MoiseevaVA.Sprint1.Task4.V0.Lib
{
    public class DataService : ISprint1Task4V0
    {
        public double Calculate(double x, double y)
        {
            var res = 1 / (Math.Pow(x, 2) + Math.Pow(y, 2));
            return res;
        }
    }
}
