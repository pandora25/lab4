using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labb4
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("please enter an interger number ?");

                int userinput = int.Parse(Console.ReadLine());

                Console.Write($"{"number",-10}");
                Console.Write($"{"sqr"}".PadRight(10));
                Console.WriteLine($"{"cube"}".PadRight(10));

                Console.Write($"{"=====",-10}");
                Console.Write($"{"=====",-10}");
                Console.WriteLine($"{"=====",-10}");

                for (int i = 0; i < userinput; i++)
                {
                    int number = i;
                    int sqr = i * i;
                    int cube = i * i * i;

                    Console.Write($"{ number,-10}");
                    Console.Write($"{sqr,-10}");
                    Console.WriteLine($"{cube}");
                }
                Console.WriteLine();
                Console.WriteLine("whould you like to Continue (y/n) ? ");

                string input = Console.ReadLine();

                if (input.ToLower() != "y")
                {
                    break;
                }
            }
        }
    }
}
