using System;

namespace MyConsole
{
    /// <summary>Testing instantiated functions</summary>
    /// <url name="codedoc">https://docs.microsoft.com/en-us/dotnet/csharp/codedoc</url>
    class Program
    {
        /// <summary>
        /// Instantiate MyClass and run its Sum function
        /// </summary>
        static void Main(string[] args)
        {
            var MyClassInstance = new MyClass();
            var result = MyClassInstance.Sum(3, 4);
            Console.WriteLine("Result: " + result);
            Hello();
        }

        /// <summary>Static function that write to Console</summary>
        private static void Hello() {
            Console.WriteLine("Hello from Program");
        }

    }
}
