using System;

    class Types
    {
        static void Main(string[] args)
        {
            ushort a = 52130;
            sbyte b = -115;
            int c = 4825932;
            byte d = 97;
            short e = -10000;
            Console.WriteLine("The best types for the following numbers are " );
            Console.WriteLine("{0} - unsigned short, {1} - signed byte, {2} - integer, {3} - byte and {4} - short" ,a,b,c,d,e);
        }
    }
