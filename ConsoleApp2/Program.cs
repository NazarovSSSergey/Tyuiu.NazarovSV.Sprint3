namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count1 = 0;
            int x;
            for (x = 4; x <= 8; x++)
            {
                for (int d = 1; d <= x; d++)
                {
                    if (x % d == 0)
                    {
                        if (d > 4)
                        {
                            count1 += d;
                        }
                    }
                }
            }
            Console.WriteLine(count1);
        }
    }
}
