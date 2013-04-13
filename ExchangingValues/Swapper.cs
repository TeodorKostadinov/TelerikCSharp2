using System;

    class Swapper
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 10;
            int swapper;
            swapper = a;
            a = b;
            b = swapper;
            Console.WriteLine("What was 5 is now {0} and what was 10 is {1}",a,b );
        }
    }

