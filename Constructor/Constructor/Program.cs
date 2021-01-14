using System;

namespace Constructor
{
    class Human
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Human()
        {
            Name = "underfined";
            Age = 0;
        }

        public Human(string name)
        {
            Name = name;
        }

        public Human(string name, int age) : this(name)
        {
            //Name = name; после того как указал : this, он ссылается выше
            Age = age;
        }

        public void ShowInfo()
        {
            Console.WriteLine(" Name: " + Name + "\n Age: " + Age);
        }


    }

    class Druggy : Human
    { 
        // Конструкторы могут использоваться лишь в наследниках
        public string DrugType { get; set; }

        public Druggy(string name, int age, string drugType) : base(name, age)
        {
            //Name = name; после того как указал : base, он ссылается выше на Human родителя
            DrugType = drugType;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Human human = new Human("Giza", 21);
            human.ShowInfo();
        }
    }
}
