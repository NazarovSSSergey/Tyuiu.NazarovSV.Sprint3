using Tyuiu.NazarovSV.Sprint3.Task0.V29.Lib;
namespace Tyuiu.NazarovSV.Sprint3.Task0.V29
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            int startValue = 1;
            int stopValue = 10;
            double value = 0.5;
            Console.WriteLine("ada" + ds.GetSumSeries(value, startValue, stopValue));
        }
    }
}
