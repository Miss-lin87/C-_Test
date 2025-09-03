using System;
using System.Drawing;

namespace Grid {
    class Grid
    {
        public String[,] BaseGrid
        {
            get;
        }
        public Grid(int size)
        {
            this.BaseGrid = Create(size);
            PopulateGrid();
        }
        private void PopulateGrid()
        {
            for (int i = 0; i < this.BaseGrid.GetLength(0); i++)
            {
                for (int j = 0; j < this.BaseGrid.GetLength(1); j++)
                {
                    this.BaseGrid[i, j] = i + "|" + j;
                }
            }
        }

        public void Change(String[,] grid, String change)
        {
            foreach (String cell in grid)
            {
                grid[int.Parse(cell.Split("|")[0]), int.Parse(cell.Split("|")[1])] = change;
            }
        }
        public void Print(Player.Player robot)
        {
            for (int i = 0; i < this.BaseGrid.GetLength(0); i++)
            {
                for (int j = 0; j < this.BaseGrid.GetLength(1); j++)
                {
                    if (robot.Xposition + "|" + robot.Yposition == this.BaseGrid[i, j])
                    {
                        Console.Write("| X |");
                    }
                    else
                    {
                        Console.Write("|" + this.BaseGrid[i, j] + "|");    
                    }
                }
                Console.WriteLine();
            }
        }
        private String[,] Create(int cells)
        {
            String[,] temp = new string[cells, cells];
            return temp;
        }  
    }
}