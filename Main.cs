using System.Reflection;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using Grid;
using Microsoft.AspNetCore.Components.Web;

namespace Main
{
    class Program
    {
        private static Directions Input()
        {
            String temp = Console.ReadLine();
            switch (temp)
            {
                case "u":
                    return Directions.UP;
                case "d":
                    return Directions.DOWN;
                case "l":
                    return Directions.LEFT;
                case "r":
                    return Directions.RIGHT;
            }
            return Directions.DOWN;
        }
        public static void Main(string[] args)
        {
            Grid.Grid Grid = new(5);
            Player.Player robot = new(0, 0, 5);
            Boolean GameOn = true;
            do
            {
                Directions InputDirect = Input();
                robot.Move(InputDirect);
                robot.Print();
                Grid.Print(robot);
            } while (GameOn);
        }
    }
}