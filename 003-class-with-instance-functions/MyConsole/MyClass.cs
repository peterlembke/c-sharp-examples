using System;

namespace MyConsole
{
    class MyClass
    {        
        public int Sum(int value1 = 0, int value2 = 0)
        {
            var sum = 0;
            sum = value1 + value2;

            Hello();

            return sum;
        }

        protected void Hello() {
            Console.WriteLine("Hello from MyClass");
        }
    }
}
