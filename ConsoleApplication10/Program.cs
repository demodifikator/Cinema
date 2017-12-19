using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication10
{
    class Program
    {
        struct Viewer
        {
            public char Sex;
            public byte Age;

            //public Viewer(char Sex, byte Age)
            //{
            //    this.Sex = Sex;
            //    this.Age = Age;
            //}
        }
        static void Main(string[] args)
        {
            Viewer[,] viewers = new Viewer[8, 8];
            Random rand = new Random();
            int countOfPeople = rand.Next(18, 24);
            char[] sex = { 'M', 'F' };
            int x, y;


            for (int i = 0; i < countOfPeople; i++)
            {
                while (true)
                {
                    x = rand.Next(0, 8);
                    y = rand.Next(0, 8);

                    if (viewers[x, y].Age == 0)
                    {
                        viewers[x, y] = new Viewer { Age = (byte)rand.Next(18, 60), Sex = sex[rand.Next(0, 2)] };
                        break;
                    }
                    else continue;
                }

            }

            for (int i = 0; i < viewers.GetLength(0); i++)
            {
                for (int j = 0; j < viewers.GetLength(1); j++)
                {
                    if (viewers[i, j].Age != 0)
                        Console.Write($"  {viewers[i, j].Sex}  ");
                    else
                        Console.Write("  -  ");
                }
                Console.WriteLine();
            }
        }
    }
}
