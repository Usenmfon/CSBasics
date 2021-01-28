using System.Data;
using System;

namespace CSBasics
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string fresh = "from fresh";
            Console.WriteLine($"Learning Basics {fresh}");

            Console.WriteLine(@"This text 
                        will 
                        stand 
                        as it is");
            string one = "1";
            string two = "2";

            Console.WriteLine("{0} + {1}",one,two);
        }
    }
}
