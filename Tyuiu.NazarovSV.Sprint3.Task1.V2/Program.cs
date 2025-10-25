using Tyuiu.NazarovSV.Sprint3.Task1.V2.Lib;
namespace Tyuiu.NazarovSV.Sprint3.Task1.V2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       *");
            Console.WriteLine("**************************************************************************");

            int startValue = 1;
            int stopValue = 15;

            Console.WriteLine("Старт Шага = " + startValue);
            Console.WriteLine("Конец Шага = " + stopValue);

            Console.WriteLine("**************************************************************************");
            Console.WriteLine("*РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("**************************************************************************");

            Console.WriteLine(" Произведение ряда = " + ds.GetSumSeries(startValue, stopValue));
            Console.ReadKey();
        }
    }
}
