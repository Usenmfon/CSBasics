using System;

namespace consoleApp
{
   class TimeTable
   {
       public string Name { get; set; }
       
       
       public TimeTable(string name)
       {
           Name = name;
       }

       public static void TTable(int numberOfRow, int numberOfCol)
        {
            Console.WriteLine(@"            TIMETABLE");
            for(int row = 1; row <= numberOfRow; row++)
            {
                
                for(int column = 1; column <= numberOfCol; column++)
                {
                    Console.Write($"{column} * {row} = {row * column}");
                    Console.Write("   ");
                }
                Console.WriteLine(" ");
            }
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

        public static int NumberOfRow()
        {
            Console.Write("Input Number of Rows: ");
            return int.Parse(Console.ReadLine());
        }   
        public static int NumberOfCol()
        {
            Console.Write("Input Number of Columns: ");
            return int.Parse(Console.ReadLine());
        }   
   } 
}