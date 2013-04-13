using System;

    class Quotations
    {
        static void Main(string[] args)
        {
            string quote1 = "The \"use\" of quotations causes difficulties";
            string quote2 = @"The ""use"" of quotations causes difficulties";

            Console.WriteLine("The two ways of escaping: {4} and {5}.", quote1, quote2);

        }
    }

