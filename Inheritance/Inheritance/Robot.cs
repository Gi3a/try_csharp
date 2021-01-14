using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    // Наследование от human
    class Robot : Human
    {
        public void TalkAboutMe()
        {
            string name = this.Name;
            int age = this.Age;
            string sex = this.Sex;
            Console.WriteLine("\n Имя: " + name + "\n Возраст: " + age + "\n Пол: " + sex);
        }
    }
}
