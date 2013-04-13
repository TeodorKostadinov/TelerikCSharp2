using System;

    class Triangle
    {
        static void Main()
        {
            char copyright = '\u00A9';
            int side;
            side = 9;

            for (int i = 0; i < side; i++)
            {
                string a = new string(' ', side  - i);
                string b = new string(copyright, 2*i + 1);
                Console.WriteLine(a + b);
            }
        }
    }

