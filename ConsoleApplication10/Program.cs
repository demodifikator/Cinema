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

            List<Viewer> inHall = new List<Viewer>();

            for (int i = 0; i < viewers.GetLength(0); i++)
            {
                for (int j = 0; j < viewers.GetLength(1); j++)
                {
                    if (viewers[i, j].Age != 0)
                    {
                        Console.Write($" {viewers[i, j].Sex} ");
                        inHall.Add(viewers[i, j]);
                    }
                    else
                        Console.Write(" - ");
                }
                Console.WriteLine();
            }
            float averageAge = 0f, averageAgeOfMen = 0f, averageAgeOfWomen = 0f;
            int countOfMen = 0, countOfWomen = 0;
            Console.WriteLine(inHall.Count);
            foreach (var item in inHall)
            {
                averageAge += item.Age;
                if (item.Sex == 'M')
                {
                    countOfMen++;
                    averageAgeOfMen += item.Age;
                }

                else
                {
                    countOfWomen++;
                    averageAgeOfWomen += item.Age;
                }                            
            }

            Console.WriteLine($"Count of people: {inHall.Count}\nCount of men: {countOfMen}\nCount of women: {countOfWomen}");
            Console.WriteLine($"Average age of men: {averageAgeOfMen / countOfMen:f}");
            Console.WriteLine($"Average age of women: {averageAgeOfWomen / countOfWomen:f}");
            Console.WriteLine($"Average age of all people: {averageAge / inHall.Count:f}");

        }
    }
}
