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

                if (input.ToLower() == "y")
                {
                    continue;
                }
                else
                {
                    break;
                }

            }
        }
    }
}





//Console.WriteLine("PLEASE ENTER A NUMBER ? ");

//            Console.WriteLine();
//            int input = int.Parse(Console.ReadLine());

//Console.WriteLine("***"+ "   ***"+ "      ***");

//            for (int i = 1; i <= input; i++)
//            {
//                double sqr = Math.Pow(i, 2);

//double cubed = Math.Pow(i, 3);
//Console.Write(i + " ");

//                Console.Write(sqr + "  ");

//                Console.WriteLine(cubed + "  ");

//            }