using System;
using System.Collections.Generic;

namespace consoleApp
{
    class Program
    {
        static void Main(string[] args)
        { 
            int sTime = StartTime();
            Console.WriteLine(@"            TIMETABLE");
            Console.Write("Input Number of Rows: ");
            int numberOfRow = int.Parse(Console.ReadLine());
            Console.Write("Input Number of Columns: ");
            int numberOfCol = int.Parse(Console.ReadLine());

            for(int row = 1; row <= numberOfRow; row++)
            {
                
                for(int column = 1; column <= numberOfCol; column++)
                {
                    Console.Write($"{column} * {row} = {row * column}");
                    Console.Write("   ");
                }
                Console.WriteLine(" ");
            }

            int eTime = EndTime();
            Console.WriteLine($"Time elapsed is: {(eTime - sTime)/1000.0}");
        }

        public static int StartTime()
        {
            int stime = Environment.TickCount;
            return stime;
        }
        public static int EndTime()
        {
            int etime = Environment.TickCount;
            return etime;
        }

        // public static int TimeTable()
        // {
            
        // }    
    }
}
