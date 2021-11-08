using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticClasses
{
    static class Program
    {

        static void Main(string[] args)
        {
            User.name = "Davit Margaryan";
            User.location = "Armenia";
            User.age = 20;
            Console.WriteLine("Name: {0}", User.name);
            Console.WriteLine("Location: {0}", User.location);
            Console.WriteLine("Age: {0}", User.age);

            Console.WriteLine();

            Variables.a = 50;
            Variables.b = 60;
            Variables.Operations();

            Console.WriteLine();

            var result = Calculator.Sum(20, 30);  // calling static method
            Calculator.Store(result);
            Console.WriteLine($"result = {result}");

            Console.WriteLine();

            var t = new int[] { 11, 35, 23 }._IsAllMembersEven();

            Console.WriteLine(t);

            Console.ReadKey();

        }
        static class User
        {
            // Static Variables
            public static string name;
            public static string location;
            public static int age;
        }

        public static class Variables
        {
            public static int a, b;

            static Variables()
            {
                a = 5;
                b = 19;
            }
            public static void Operations()
            {

                Console.WriteLine($"Sum = {a + b}");
            }
        }

        public static class Calculator
        {
            private static int _resultStorage = 0;

            public static int Sum(int num1, int num2)
            {
                return num1 + num2;
            }

            public static void Store(int result)
            {
                _resultStorage = result;
            }
        }

        public static bool _IsAllMembersEven(this int[] source)
        {
            int total = 0;
            int[] arr = new int[] { };
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    total = total + 1;
                }
            }
            return total == arr.Length;

        }

        public static bool _IsOdd(this int value)
        {
            return value % 2 == 1;
        }
    }
}

