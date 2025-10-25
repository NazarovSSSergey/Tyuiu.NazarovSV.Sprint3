using Tyuiu.NazarovSV.Sprint3.Task3.V7.Lib;
namespace Tyuiu.NazarovSV.Sprint3.Task3.V7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       *");
            Console.WriteLine("**************************************************************************");

            string value = "gft hggt ntg";
            char replaceable = 'g';
            char replacement = '4';
            Console.WriteLine("Исходная строка - " + value);
            Console.WriteLine("Что ищем - " + replaceable);
            Console.WriteLine("На что заменяем - " + replacement);


            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                             *");
            Console.WriteLine("**************************************************************************");

            Console.WriteLine("Количество символов - " + ds.ReplaceCharOnNum(value, replaceable, replacement));
            Console.ReadKey();

        }
    }
}
