using System;

    class Comparing
    {
        static void Main(string[] args)
        {
            float first, second;
            first = float.Parse(Console.ReadLine());
            second = float.Parse(Console.ReadLine());
            first = (float)(Math.Round(first, 6));
            second = (float)(Math.Round(second, 6));
            bool firstBigger = false;
            firstBigger = (first == second);
            Console.WriteLine("Are the numbers equal?  {0}",firstBigger);

        }
    }

