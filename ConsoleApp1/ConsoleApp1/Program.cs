using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string str;

            int first_num;
            int second_num;
            char operation;

            int result;

            // Get First number
            Console.WriteLine("Введите первое число");
            str = Console.ReadLine();
            first_num = Convert.ToInt32(str);


            // Get second number
            Console.WriteLine("Введите второе число");
            str = Console.ReadLine();
            second_num = Convert.ToInt32(str);


            // Get operation
            Console.WriteLine("Введите операцию (+, - , *, / )");
            str = Console.ReadLine();
            operation = Convert.ToChar(str);


            NumberFunction nf = new NumberFunction();

            result = nf.func(first_num, second_num, operation);

            Console.WriteLine(first_num + " " + operation + " " + second_num + " = " + result);

        }
    }
}
