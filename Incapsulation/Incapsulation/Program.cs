using System;

namespace Incapsulation
{
    class Program
    {
        static void Main(string[] args)
        {

            string str;

            Human human = new Human();

            Console.WriteLine("Введите имя человека");
            human.Name = Console.ReadLine();

            Console.WriteLine("Введите возраст человека");
            str = Console.ReadLine();
            human.Age = Convert.ToInt32(str);


            string name = human.Name;

            int age = human.Age;

            Console.WriteLine("Создан человека: " + name + ". Возраст: " + age);
        }
    }
}
