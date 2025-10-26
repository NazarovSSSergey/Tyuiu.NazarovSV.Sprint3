using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.NazarovSV.Sprint3.Task6.V18.Lib
{
    public class DataService : ISprint3Task6V18
    {
        public int GetSumTheDivisors(int startValue, int stopValue)
        {
            int sum = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                for (int k = 1; k <= x; k++)
                {
                    if (x % k == 0)
                    {
                        if (x % k < 10)
                        {
                            sum += k;
                        }
                    }
                }
            }
            return sum;
        }
    }
}
