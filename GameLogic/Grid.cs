using System;

namespace Grid {
    class Create
    {

        private static void PopulateGrid(String[,] grid)
        {
            for (int i = 0; i < grid.GetLength(0); i++)
            {
                //Console.WriteLine(grid.GetLength(0));
                Console.WriteLine(grid.GetLength(1));
                for (int j = 0; j < grid.GetLength(1); j++)
                {
                    grid[i, j] = i + "|" + j;
                }
            }
        }

        public static void Change(String[,] grid, String change)
        {
            foreach (String cell in grid)
            {
                grid[int.Parse(cell.Split("|")[0]), int.Parse(cell.Split("|")[1])] = change;
            }
        }
        public static void Print(String[,] grid)
        {
            for (int i = 0; i < grid.GetLength(0); i++)
            {
                for (int j = 0; j < grid.GetLength(1); j++)
                {
                    Console.Write("|" + grid[i, j] + "|");
                }
                Console.WriteLine();
            }
        }
        public static String[,] New(int cells)
        {
            String[,] temp = new string[cells, cells];
            PopulateGrid(temp);
            return temp;
        }
    
    }
}