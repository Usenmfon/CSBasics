using System;
using System.Collections.Generic;

namespace consoleApp
{
    class Program
    {
        static void Main(string[] args)
        { 
            // TimeTable t = new ("Usenmfon Codes");
            // Console.WriteLine(t.Name);
            
            // int sTime = TimeTable.StartTime();  
            
            // int numberOfRow = TimeTable.NumberOfRow();
            // int numberOfCol = TimeTable.NumberOfCol();

            // TimeTable.TTable(numberOfRow, numberOfCol);

            // int eTime = TimeTable.EndTime();
            // Console.WriteLine($"Time elapsed is: {(eTime - sTime)/1000.0}");
            // #region here
            // string postText = Console.ReadLine();
            
            // Post post = new ();
            // post.Text = postText;
            // post.ShowPost();
            // #endregion
        //     string continueToRun;
        //    do
        //    {
        //        Console.Write("Enter year: ");
        //        int year = int.Parse(Console.ReadLine());
        //        IsLeapYear(year);
        //        Console.Write("Do you want to continue Y/N ? :");
        //        continueToRun = Console.ReadLine();
        //    }while(continueToRun != "N");
        Console.WriteLine(DateTime.Today.DayOfWeek);
        }
        // static void IsLeapYear(int year)
        // {
        //     Console.WriteLine(DateTime.IsLeapYear(year));
        // }
    }
}
