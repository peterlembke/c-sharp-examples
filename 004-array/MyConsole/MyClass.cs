using System;

namespace MyConsole
{
    /// <summary>Testing arrays, for-loops and codedoc</summary>
    /// <url name="codedoc">https://docs.microsoft.com/en-us/dotnet/csharp/codedoc</url>
    class MyClass
    {        
        /// <summary>Demo show arrays with data and loops trough the values</summary>
        /// <returns>A string that we are done</returns>
        public string MyFunction()
        {
            Echo(ArrayWithInt());
            Echo(ArrayWithInt(2, 4));
            Echo(ArrayWithInt(1, 5));

            Echo(ArrayWithDouble());
            Echo(ArrayWithDouble(2, 4));
            Echo(ArrayWithDouble(1, 5));

            Echo(ArrayWithString());
            Echo(ArrayWithString(2, 4));
            Echo(ArrayWithString(1, 5));

            return "execution done";
        }

        /// <summary>
        /// Demo with an array of integers that we loop and sum.
        /// The <paramref name="startIndex"/> tell where to start and
        /// the <paramref name="endIndex"/> tell where to end the summary
        ///</summary>
        /// <returns>Sum of values in the array</returns>
        /// <param name="startIndex">Where in the array we will start the sum</param>
        /// <param name="endIndex">Where in the array we will end the sum. default is -1 to the very end</param>
        protected string ArrayWithInt(int startIndex = 0, int endIndex = -1) 
        {
            var values = new int[10] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};

            if (endIndex == -1) {
                endIndex = values.Length-1;
            }

            var total = 0;

            for (var index = startIndex; index <= endIndex; index++) {
                total = total + values[index];
            }

            return "Sum of integers: " + total;
        }

        /// <summary>
        /// Demo with an array of double that we loop and sum.
        /// The <paramref name="startIndex"/> tell where to start and
        /// the <paramref name="endIndex"/> tell where to end the summary
        ///</summary>
        /// <returns>Sum of values in the array</returns>
        /// <param name="startIndex">Where in the array we will start the sum</param>
        /// <param name="endIndex">Where in the array we will end the sum. default is -1 to the very end</param>
        protected string ArrayWithDouble(int startIndex = 0, int endIndex = -1) 
        {
            var values = new double[10] {1.1, 2.2, 3.3, 4.4, 5.5, 6.6, 7.7, 8.8, 9.9, 10.0};

            if (endIndex == -1) {
                endIndex = values.Length-1;
            }

            var total = 0.0;

            for (var index = startIndex; index <= endIndex; index++) {
                total = total + values[index];
            }

            return "Sum of doubles: " + total;
        }

        /// <summary>
        /// Demo with an array of strings that we join together
        /// The <paramref name="startIndex"/> tell where to start and
        /// the <paramref name="endIndex"/> tell where to end the join
        ///</summary>
        /// <returns>Join of strings in the array</returns>
        /// <param name="startIndex">Where in the array we will start the join</param>
        /// <param name="endIndex">Where in the array will we end the join. default is -1 to the very end</param>
        protected string ArrayWithString(int startIndex = 0, int endIndex = -1) 
        {
            var values = new string[10] {"a", "b", "c", "d", "e", "f", "g", "h", "i", "j"};

            if (endIndex == -1) {
                endIndex = values.Length-1;
            }

            var total = "";

            for (var index = startIndex; index <= endIndex; index++) {
                total = total + values[index];
            }

            return "Join of strings: " + total;
        }
       
        /// <summary>Write a line to the console</summary>
        /// <param name="myRow">The string to write</param>
        protected void Echo(string myRow = "") {
            Console.WriteLine(myRow);
        }
    }
}
