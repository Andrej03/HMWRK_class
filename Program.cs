using System;

namespace HMWRK_class_2_task3
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 8;

            Console.WriteLine("Original numbers a = " + a + " b = " + b);
            a = a * b;
            b = a / b;
            a = a / b;

            Console.WriteLine("Swaped numbers a = " + a +" b = " + b);
        }
    }
}
