using System;

namespace MyConsole
{
    /// <summary>Testing static functions and codedoc</summary>
    /// <url name="codedoc">https://docs.microsoft.com/en-us/dotnet/csharp/codedoc</url>
    class Program
    {
        /// <summary>Starts the program</summary>
        public static void Main(string[] args)
        {
            var result = Sum(3, 4);
            Console.WriteLine("Result: " + result);

            var resultString = Sum("Hello","World");
            Console.WriteLine("Result: " + resultString);

            Console.WriteLine("Upper: " + resultString.ToUpper() );
            Console.WriteLine("Lower: " + resultString.ToLower() );

            var resultDouble = Sum(3.5, 4.456);
            Console.WriteLine("Result: " + resultDouble);

            resultDouble = Math.Round(resultDouble, 2);
            Console.WriteLine("Result: " + resultDouble);
        }

        /// <summary>Sum two integer values</summary>
        /// <returns>Sum of values</returns>
        /// <param name="value1">First integer value</param>
        /// <param name="value2">Second integer value</param>
        protected static int Sum(int value1 = 0, int value2 = 0)
        {
            var sum = 0;
            sum = value1 + value2;

            return sum;
        }

        /// <summary>Join two strings</summary>
        /// <returns>Joined strings</returns>
        /// <param name="value1">First string value</param>
        /// <param name="value2">Second string value</param>
        protected static string Sum(string value1 = "", string value2 = "")
        {
            var sum = "";
            sum = value1 + " " + value2 + "!";

            return sum;
        }

        /// <summary>Sum two double values</summary>
        /// <returns>Sum of values</returns>
        /// <param name="value1">First double value</param>
        /// <param name="value2">Second double value</param>
        protected static double Sum(double value1 = 0.0, double value2 = 0.0)
        {
            var sum = 0.0;
            sum = value1 + value2;

            return sum;
        }
    }
}
