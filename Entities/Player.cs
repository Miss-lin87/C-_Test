using System.Diagnostics;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic;

namespace Player
{
    class Player
    {
        public int Xposition
        {
            get;
            set;
        }
        public int Yposition
        {
            get;
            set;
        }
        private Grid.Grid Grid;

        public Player(int Size)
        {
            this.Xposition = 0;
            this.Yposition = 0;
            this.Grid = new(Size);
        }

        public Player(int X, int Y, int Size)
        {
            this.Xposition = X;
            this.Yposition = Y;
            this.Grid = new(Size);
        }

        public void Move(Directions direction)
        {
            switch (direction)
            {
                case Directions.UP:
                    this.Xposition -= CheckBounds(this.Grid.BaseGrid, Directions.UP) ? 1 : 0;
                    break;
                case Directions.DOWN:
                    this.Xposition += CheckBounds(this.Grid.BaseGrid, Directions.DOWN) ? 1 : 0;
                    break;
                case Directions.LEFT:
                    this.Yposition += CheckBounds(this.Grid.BaseGrid, Directions.LEFT) ? 1 : 0;
                    break;
                case Directions.RIGHT:
                    this.Yposition -= CheckBounds(this.Grid.BaseGrid, Directions.RIGHT) ? 1 : 0;
                    break;
            }
        }

        public Boolean CheckBounds(String[,] grid, Directions direct)
        {
            int Xpoint = Xposition;
            int Ypoint = Yposition;
            switch (direct)
            {
                case Directions.UP:
                    Xpoint -= 1;
                    break;
                case Directions.DOWN:
                    Xpoint += 1;
                    break;
                case Directions.LEFT:
                    Ypoint += 1;
                    break;
                case Directions.RIGHT:
                    Ypoint -= 1;
                    break;
            }
            return FindCell(grid, Xpoint + "|" + Ypoint);
        }
        
        private Boolean FindCell(string[,] grid, String point)
        {
            foreach (String cell in grid)
            {
                if (cell == point)
                {
                    return true;
                }
            }
            return false;
        }


        public void Print()
        {
            Console.WriteLine(this.Xposition + "|" + this.Yposition);
        }
    }
}