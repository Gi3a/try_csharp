using System;
using System.Collections.Generic;
using System.Text;

namespace Incapsulation
{
    class Human
    {
        private string name;
        private int age;

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                if (value > 0)
                    age = value;
                else
                    age = value * -1;
            }
        }
    }
}
