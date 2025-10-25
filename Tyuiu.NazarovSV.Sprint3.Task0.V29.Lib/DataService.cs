using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.NazarovSV.Sprint3.Task0.V29.Lib
{
    public class DataService : ISprint3Task0V29
    {
        public double GetSumSeries(double value, int startValue, int stopValue)
        {
            double res = 0;
            for (int i = startValue; i <= stopValue; i++)
            {
                res = res + ((Math.Pow(value, 2 * startValue) + (1 / (startValue + 1))) * Math.Cos(value));
            }
            return Math.Round(res, 3);
        }
    }
}
