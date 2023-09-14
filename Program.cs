using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringReversal
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter a string you want to reverse. ");
            string input = Console.ReadLine();

            String reversed = new string(input.Reverse().ToArray());

            Console.WriteLine("The original input reversed is: "+ reversed);
        }
    }
}
