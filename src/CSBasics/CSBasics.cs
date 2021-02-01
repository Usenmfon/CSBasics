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

            // woodLength = 2 * ( width + height) * 3.25;
            // glassArea = 2 * ( width * height );

            // Console.WriteLine ( "The length of the wood is " +
            //     woodLength + " feet");
            // Console.WriteLine ( "The area of the glass is " +
            //     glassArea + " square metres");

            int[,] numbers = new int[,] {
                {1,2,3},
                {4,5,6},
                {7,8,9}
            };
            var val = 0;
            for(int i = 0; i < numbers.GetLength(0); i++)
            {
                for(int j = 0; j < numbers.GetLength(1); j++)
                {
                    val = numbers[i,j];
                }
                Console.WriteLine(val);
            }

            double windowWidth = UsefulMethod.ReadValue(
                "Enter width of window: ", UsefulMethod.MIN_WIDTH, UsefulMethod.MAX_WIDTH);
            Console.WriteLine("Width: " + windowWidth);

            double age = UsefulMethod.ReadValue("Enter your age: ", 0, 70);
            Console.WriteLine("Age: " + age);

        }
    }
}
