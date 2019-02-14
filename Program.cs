using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Welcome to the nothing doer. Here goes nothing...");
            var doer = new NothingDoer();
            doer.DoNothingWithTwoInts(2, 5);
            doer.DoNothingWithTwoInts(a: 2, b: 5);
            Console.WriteLine("All done.");
            Console.Read();
        }
    }

    class NothingDoer
    {
        public void DoNothingWithTwoInts(int a, int b)
        {
            a = a * 4;
            Console.WriteLine("Here is your result: " + b);
        }
    }
}
