using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism
{
    class Animal
    {
        public string Name { get; set; }

        // С помощью virtual, этот getRoar можно переопределять в наследниках класса, cat, dog, rat, boozer
        public virtual void GetRoar()
        {
            Console.WriteLine("R-R-R");
        }
    }

    class Cat : Animal
    {
        // Переопределенный метод от родителя класса
        public override void GetRoar()
        {
            Console.WriteLine("Miaoo-Miaoo");
            base.GetRoar(); // Вызов родительского класса GetRoar
        }
    } 

    class Dog : Animal
    {
        public override void GetRoar()
        {
            Console.WriteLine("Aff-Aff");
        }
    }

    class Rat : Animal
    {
        public override void GetRoar()
        {
            Console.WriteLine("Pts-Pts");
        }
    }

    class Boozer : Animal
    {
        public override void GetRoar()
        {
            Console.WriteLine("ARGHHHHH-Suka");
            base.GetRoar(); // Вызов родительского класса GetRoar
        }
    }
}
