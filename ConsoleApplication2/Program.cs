using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Calculate(int first, int second, char sign, string s)
        {

        }

        static void Calculate(int first, int second, char sign)
        {
            switch (sign)
            {
                case '+':
                    Console.WriteLine(first + second);
                    break;
                case '-':
                    Console.WriteLine(first - second);
                    break;
                case '*':
                    Console.WriteLine(first*second);
                    break;
                case '/':
                    {
                        if (second == 0)
                        {
                            Console.WriteLine("Divide by zero exception!");
                            break;
                        }
                        Console.WriteLine(first/second);
                    }
                    break;
                default:
                    Console.WriteLine("bullshit");
                    break;
            }
        }
        static void Main(string[] args)
        {
            Calculate(12, 3, 'z');
        }
    }
}