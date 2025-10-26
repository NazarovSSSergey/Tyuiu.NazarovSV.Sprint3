using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.NazarovSV.Sprint3.Task7.V26.Lib
{
    public class DataService : ISprint3Task7V26
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] valueArray;
            int len = (stopValue - startValue) + 1;
            valueArray = new double[len];
            double y;
            int c = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                y = Math.Round((5 - 3 * x + ((1 + Math.Sin(x)) / (2 * x - 0.5))), 2);
                valueArray[c] = y;
                c++;
                if (2 * x - 0.5 == 0)
                {
                    valueArray[c] = 0;
                    c++;
                }
            }
            return valueArray;
        }
    }
}
