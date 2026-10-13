using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.MoiseevaVA.Sprint1.Task6.V0.Lib
{
    public class DataService : ISprint1Task6V0
    {
        public string WorkWithText(string value)
        {
            value = value.Replace(" ", "");
            value = value.Replace("*", "");
            return value;


        }
    }
}
