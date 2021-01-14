using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class NumberFunction
    {
        public int func(int first_num, int second_num, char operation)
        {
            int result = 0;

            switch(operation)
            {
                case '+':
                    result = first_num + second_num;
                    break;
                case '-':
                    result = first_num - second_num;
                    break;
                case '*':
                    result = first_num * second_num;
                    break;
                case '/':
                    result = first_num / second_num;
                    break;
                default:
                    result = 0;
                    break;
            }

            return result;
        }
    }
}
