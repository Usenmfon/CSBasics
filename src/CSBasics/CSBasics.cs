using System.IO;
using System.Data;
using System;

namespace CSBasics
{
    class CSBasics
    {
        static void Main(string[] args)
        {
            // double width, height, woodLength, glassArea;

            // const double MAX_WIDTH = 5.0 ;
            // const double MIN_WIDTH = 0.5 ;
            // const double MAX_HEIGHT = 3.0 ;
            // const double MIN_HEIGHT = 0.75 ;

            // string widthString, heightString;

            // Comments.SayThis();
            // do {
            //     Console.Write ("Give the width of the window between " +
            //      MIN_WIDTH + " and " + MAX_WIDTH + " :" );
            //      widthString = Console.ReadLine();
            //      width = double.Parse(widthString);
            // } while ( width < MIN_WIDTH || width > MAX_WIDTH );

            // do {
            //     Console.Write ("Give the height of the window between " +
            //      MIN_HEIGHT + " and " + MAX_HEIGHT + " :" );
            //      heightString = Console.ReadLine();
            //      height = double.Parse(heightString);
            // } while ( height < MIN_HEIGHT ||height > MAX_HEIGHT );
            #region STREAMWRITER
            // try
            // {
            // StreamWriter writer;
            // writer = new StreamWriter("file.txt");
            // writer.WriteLine("Hello, My name is Usenmfon Uko");
            // writer.Close();
            // }
            // catch(Exception e)
            // {
            //     Console.WriteLine(e.Message);
            // }
            #endregion
            
            try
            {
            string path;
            path = @"C:\Users\Usenmfon\Desktop\2019 useful website.txt";
            StreamReader reader;
            reader = new StreamReader(path);
            while(reader.EndOfStream == false)
            {
                string line = reader.ReadLine();
                Console.WriteLine(line);
            }
            reader.Close();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }

            double woodLength, glassArea;

            double windowWidth = UsefulMethod.ReadValue(
                "Enter width of window: ", UsefulMethod.MIN_WIDTH, UsefulMethod.MAX_WIDTH);
            Console.WriteLine("Width: " + windowWidth);

            double windowHeight =  UsefulMethod.ReadValue(
                "Enter height of window: ", UsefulMethod.MIN_HEIGHT, UsefulMethod.MAX_HEIGHT);
            Console.WriteLine("Height: " + windowHeight);

            woodLength = 2 * ( windowWidth + windowHeight) * 3.25;
            glassArea = 2 * ( windowWidth * windowHeight );

            Console.WriteLine ( "The length of the wood is " +
                woodLength + " feet");
            Console.WriteLine ( "The area of the glass is " +
                glassArea + " square metres");
           
        }
    }
}
