using System;

    class ObjectToString
    {
        static void Main(string[] args)
        {
            string line1 = "Hello";
            string line2 = "World";
            object lineSum = line1 + " " + line2;
            string line3 = (string)lineSum;


            Console.WriteLine("The combined string from object is {3}", line3);

        }
    }

