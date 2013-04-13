using System;

    class ASCII
    {
        static void Main(string[] args)
        {
            char symbol;
            string table=" ";
            for (int i = 0; i < 256; i++)
            {
                symbol = (char)i;
                table = table + " " + symbol;
            }
            Console.WriteLine(table);
        }
    }

