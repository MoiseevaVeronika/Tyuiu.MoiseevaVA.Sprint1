using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.MoiseevaVA.Sprint1.Task3.V1.Lib
{
    public class DataService : ISprint1Task3V1
    {
        public double CylinderVolume(double r, double h)
        {
            var res = Math.PI * r * r * h;
            return Math.Round(res, 3);
        }
    }
}
