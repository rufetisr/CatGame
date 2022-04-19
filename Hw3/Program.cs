using System;
using System.Threading;
using Hw3;


Cat c = new("mestan", 12, 'K', 240);
Cat c1 = new("tom", 6, 'K', 130);
Cat c3 = new("Jessica", 3, 'Q', 210);
Cat c4 = new("Jerry", 5, 'Q', 145);

CatHouse house = new("CatHouse", new Cat[] { c, c1 }, 2);

CatHouse[] houses = new[] { house };

PetShop petShop = new(houses, 1);

//house.AddCat(c3);
//house.AddCat(c4);
//house.AllCatsInHouse();
//house.RemoveByNickname("Jessica");
//house.AllCatsInHouse();
//c.Eat(4);
//petShop.AllCatsInPetShop();
//c.Eat(5);
//c.Sleep();
//c.ProgressBar();


void ProgressBar()
{

    Console.Write("\n");
    Console.WriteLine("\t\t\t\t\b---Cat Game---\n");
    int a = 0;
    Console.Write("\t\t\t\t"+"Loading...\n\t\t");

    for (int i = 0; i < 40; i++)
    {
        Console.BackgroundColor = ConsoleColor.Green;
        Console.Write(" ");
        Thread.Sleep(100);
        Console.ResetColor();
    }
    Console.Clear();
}

void Menu()
{
    Console.WriteLine("Press enter go to the menu->");
    Console.ReadLine();
    Console.Clear();
    Console.WriteLine("\n\n\n\t\t1->Play, 2->Eat, 3->Sleep, 4->PetShop ");
    int a = int.Parse(Console.ReadLine());
    int mealQ;
    switch (a)
    {
        case 1: c.Play();Console.Clear();Menu(); break;
        case 2:
            Console.Write("MealQuanity: "); mealQ = int.Parse(Console.ReadLine());c.Eat(mealQ);Menu();
            break;
        case 3: c.Sleep();Menu();break;
        case 4: petShop.AllCatsInPetShop();  Menu();
            break;
        default:
            break;           
    }
}

ProgressBar();
Menu();