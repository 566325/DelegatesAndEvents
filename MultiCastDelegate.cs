using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesDemo
{
    public delegate void DelegatesDemoDelegate(int x, int y);

    public class MultiCastDelegate
    {
        public static void ImplementDelegate()
        {
            DelegatesDemoDelegate obj = Operations.Add;
            obj += Operations.Multiplication;
            obj += Operations.Divide;

            obj(10, 3);
            obj(2, 5);
        }

        public class Operations
        {
            public static void Add(int a, int b)
            {
                Console.WriteLine("Addition is :" + (a + b));
            }

            public static void Multiplication(int a, int b)
            {
                Console.WriteLine("Multiplication is :" + (a * b));
            }
            public static void Divide(int a, int b)
            {
                Console.WriteLine("Division is : " + (a / b));
            }

        }

    }
}