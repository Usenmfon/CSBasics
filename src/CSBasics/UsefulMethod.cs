using System;

namespace CSBasics
{
    public class UsefulMethod
    {
        public static double ReadValue(string prompt, double low, double high)
        {
            double result;

            do
            {
                Console.WriteLine(prompt + " between " + low + " and " + high);
                string resultString = Console.ReadLine();
                result = double.Parse(resultString);
            } while ((result < low) || (result > high));
            return result;
        }
        public const double MAX_WIDTH = 5.0;
        public const double MIN_WIDTH = 0.5;
    }
}