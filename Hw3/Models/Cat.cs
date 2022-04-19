using System;
using System.Threading;

namespace Hw3
{
    class Cat
    {
        #region Properties
        public string Nickname { get; set; }
        public int Age { get; set; }
        public char Gender { get; set; }
        public int Energy { get; set; }
        public int Price { get; set; }
        public int MealQuantity { get; set; }
        #endregion

        public Cat(string name, int age, char gender, int price)
        {
            Nickname = name;
            Age = age;
            Gender = gender;
            Energy = 100;
            Price = price;
        }

        public void Eat(int mealQuantity)
        {
            Console.Write("Eating");
            string s = "...";
            for (int i = 0; i < 6; i++)
            {
                Console.Write(s[0]); Thread.Sleep(400);
            }
            Console.Clear();
            if (Energy < 100)
            {
                Energy += mealQuantity;
            }

            Price += 1;
            MealQuantity += mealQuantity;
        }

        public void Sleep()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            string a = "ZzzzZzzzZzzzZzzz";
            foreach (var item in a)
            {
                Console.Write(item);
                Thread.Sleep(200);
            }
            if (Energy < 50)
            {
                Energy += 50;
            }
            else if (Energy>50)
            {
                Energy = 100;
            }
            Price += 1;
            Console.WriteLine();
            Console.ResetColor();

        }

        public void Play()
        {

            for (int i = 0; i < 5; i++)
            {
                Energy -= 10;
                Console.BackgroundColor = ConsoleColor.DarkRed; Thread.Sleep(250);
                Console.Clear();

                Console.BackgroundColor = ConsoleColor.DarkYellow; Thread.Sleep(250);
                Console.Clear();
            }
            Console.ResetColor();
            Console.Clear();
            if (Energy == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Energy is 0");
                Thread.Sleep(200);
                Console.WriteLine($"Cat must go to sleep now->");
                Thread.Sleep(1000);
                Console.Clear();
                Sleep();
            }

        }



        public void Show()
        {
            Console.WriteLine($"Nickname: {Nickname}\n" +
                $"Age: {Age}\n" +
                $"Gender: {Gender}\n" +
                $"Energy: {Energy}\n" +
                $"Price: {Price}\n" +
                $"MealQuantity: {MealQuantity}\n");
        }
    }
}
