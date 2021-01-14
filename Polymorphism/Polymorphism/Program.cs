using System;

namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal[] animals = new Animal[4];

            Cat cat = new Cat();
            cat.Name = "Barsik";

            Dog dog = new Dog();
            dog.Name = "Tuzik";

            Rat rat = new Rat();
            rat.Name = "Ratatui";

            Boozer boozer = new Boozer();
            boozer.Name = "Vasya";

            animals[0] = cat;
            animals[1] = dog;
            animals[2] = rat;
            animals[3] = boozer;


            for(int i = 0; i < animals.Length; i++)
            {
                Console.WriteLine(" \n" + animals[i].Name + ": ");
                animals[i].GetRoar();
            }

            Console.ReadKey();
        }
    }
}
