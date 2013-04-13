using System;

    class Nulls
    {
        static void Main()
        {
            int? nullInteger = null;
            double? nullDouble = null;
            Console.WriteLine(nullInteger);
            Console.WriteLine("The null integer's value is "+nullInteger+" and the double's value is "+nullDouble);
            nullInteger = nullInteger + 5;
            nullDouble = nullDouble + 5;
            Console.WriteLine("Their values with added 5 are "+nullInteger+" and "+nullDouble);
            nullInteger = 5;
            nullDouble = 5;
            Console.WriteLine("Their values when assigned 5 are "+nullInteger+" and "+nullDouble);

        }
    }

