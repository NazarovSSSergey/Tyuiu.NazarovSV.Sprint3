using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.NazarovSV.Sprint3.Task0.V29.Lib
{
    public class DataService : ISprint3Task0V29
    {
        public double GetSumSeries(double t, int k, int s)
        {
            double res = 0;
            int i;
            for (i = k; i <= s; i++)
            {
                res = res + (Math.Cos(t) * (Math.Pow(t, 2*i) + (1/(i+1))));
            }
            return Math.Round(res, 3);
        }
    }
}