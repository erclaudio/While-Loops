using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace While_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            int a = 0;
            do { //do while enters at least once regardless of the condition 
                Console.WriteLine($"Value of a: {a}");
                a += 1;
            } while 
                (a < 10);
            int b = 0;
            while (b < 10) //while only enters if the condition is met
            {
                Console.WriteLine($"Value of b: {b}");
                b+= 1;
            }
            Console.ReadLine();
            */
            /*
            do { Console.WriteLine($"From Min: {min}");
                min += 1;
            }
            while (min <= max);
            Console.ReadLine();
            */



            Console.WriteLine("Enter the first value: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the last value: ");
            int b = Convert.ToInt32(Console.ReadLine());
            
            int count = 0;
            while (a <= b) {
                if (a%2==0) { Console.WriteLine(a); count += 1; }            
                a += 1;                
            }
            Console.WriteLine($"Totale: {count}");
            Console.ReadLine();

        }
    }
}
