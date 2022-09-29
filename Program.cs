using System;

namespace CycleWithParameter
{
    class Program
    {
        static void Main(string[] args)
        {
            int startPoint = 5;
            int endPoint = 96;
            int step = 7;

            for (int i = startPoint; i <= endPoint; i+=step)
            {
                Console.Write($"{i} ");
            }

            Console.WriteLine();
        }
    }
}
