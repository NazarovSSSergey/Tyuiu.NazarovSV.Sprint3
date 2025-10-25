using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.NazarovSV.Sprint3.Task2.V22.Lib
{
    public class DataService : ISprint3Task2V22
    {
        public double GetMultiplySeries(int value, int startValue, int stopValue)
        {
            double res = 1;
            do
            {
                var z = (3 / (startValue + Math.Pow(value, (-1) * (startValue))));
                res = res * (Math.Pow(z, 2));
                startValue++;
            } while (startValue <= stopValue);
            return Math.Round(res, 3);
        }
    }
}
