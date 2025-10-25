
namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 2;
            int b = 1;
            int c = 6;
            int d = 7;
            int i = 1;
            do
            {
                a++;
                b -= a;
                c = b - a;
                d = (c + a) + i;
                i++;
            } while (i < 5);
            Console.WriteLine(d);
        }
    }
}
