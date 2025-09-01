using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using Grid;
using Microsoft.AspNetCore.Components.Web;

namespace Main
{
    class Program
    {
        private static void Print(Player.Player robot)
        { 
          Console.WriteLine(robot.Xposition + "|" + robot.Yposition);  
        }

        public static void Main(string[] args)
        {
            Grid.Create create = new Grid.Create();
            String[,] Grid = Create.New(5);
            Player.Player robot = new(0, 0, 5);
            Print(robot);
            robot.Move(Directions.DOWN);
            Print(robot);
            robot.Move(Directions.UP);
            Print(robot);
            robot.Move(Directions.UP);
            Print(robot);
            robot.Move(Directions.LEFT);
            Print(robot);
            robot.Move(Directions.RIGHT);
            Print(robot);
            robot.Move(Directions.RIGHT);
            Print(robot);
            Create.Print(Grid);
            Console.WriteLine();

            Player.Player robot2 = new(5, 5, 5);
            Player.Player robot3 = new(8, 8, 5);

            Console.WriteLine(robot2.CheckBounds(Grid));
            Console.WriteLine(robot3.CheckBounds(Grid));
            Console.WriteLine(robot.CheckBounds(Grid));
        }
    }
}

