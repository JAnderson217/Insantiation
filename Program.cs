using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;  
using System.Threading.Tasks;

namespace ExampleTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
              //  Console.WriteLine(i + ": Hello World");
              //  Console.WriteLine("{0}: Hello World", i);
                Console.WriteLine($"{i}: Hello World");
            }

            //Instantiation
            Mathfunction arith = new Mathfunction();
            int sum = arith.Add(3, 6);
            Console.WriteLine();
            Console.WriteLine($"Sum is: {sum}");
            Console.WriteLine("12+32 is: " + arith.Add(12,32));

            int product = Multiply(3, 6);
            Console.WriteLine("Product: " + product);
            
            
            Console.ReadLine();


        }

        public static int Multiply(int v1, int v2)
        {
            return v1*v2;
        }

    }
}
