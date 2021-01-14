using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    class Human
    {
        public string Name { get; set; }
        public string Sex { get; set; }
        public int Age { get; set; }

        public void SayHelloTo(string value)
        {
            Console.WriteLine(" Привет, " + value);
        }
    }
}
