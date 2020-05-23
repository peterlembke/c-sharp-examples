using System;

namespace MyConsole
{
    class Program
    {
        /// <summary>Use of arrays</summary>
        static void Main(string[] args)
        {
            var MyClassInstance = new MyClass();
            var result = MyClassInstance.MyFunction();
            Console.WriteLine("Result: " + result);
            Done();
        }

        /// <summary>Writes to the console</summary>
        private static void Done() {
            Console.WriteLine("Done");
        }

    }
}
