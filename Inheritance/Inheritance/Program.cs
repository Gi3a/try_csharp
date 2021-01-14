using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Robot robot = new Robot();

            robot.Name = "Робот R #2";
            robot.Age = 999;
            robot.Sex = "Male";
            robot.SayHelloTo("Вася");

            robot.TalkAboutMe();

            Human FromRobotToHuman = robot; // Upcast приведение к общему типу, то есть к Human
            //Robot FromHumanToRobot = (Robot)FromRobotToHuman; // Если ранее он был уже конкретным данным типом, то можно привести его к нему

            Robot WasRobot = FromRobotToHuman as Robot; // если был роботом, то преобразует в робот, если не был вернет null

            if (WasRobot != null)
            {
                FromHumanToRobot.TalkAboutMe(); // Метод от класса Робот, не доступен после приведения к общему типу
            }

            Console.ReadKey();
        }
    }
}
