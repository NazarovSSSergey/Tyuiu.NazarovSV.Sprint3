using Tyuiu.NazarovSV.Sprint3.Task0.V29.Lib;
namespace Tyuiu.NazarovSV.Sprint3.Task0.V29
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            double t = 0.5;
            int k = 1;
            int s = 10;

            Console.WriteLine(ds.GetSumSeries(t, k, s));
        }
    }
}
