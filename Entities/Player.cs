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
        private int Size;

        public Player(int Size)
        {
            this.Xposition = 0;
            this.Yposition = 0;
            this.Size = Size;
        }

        public Player(int X, int Y, int Size)
        {
            this.Xposition = X;
            this.Yposition = Y;
            this.Size = Size;
        }

        public void Move(Directions direction)
        {
            switch (direction)
            {
                case Directions.UP:
                    this.Xposition -= (this.Xposition > 0) ? 1 : 0;
                    break;
                case Directions.DOWN:
                    this.Xposition += (this.Xposition < Size) ? 1 : 0;
                    break;
                case Directions.LEFT:
                    this.Yposition -= (this.Yposition > 0) ? 1 : 0;
                    break;
                case Directions.RIGHT:
                    this.Yposition += (this.Yposition < Size) ? 1 : 0;
                    break;
            }
        }

        public Boolean CheckBounds(String[,] grid)
        {
            String Positioning = this.Xposition + "|" + this.Yposition;
            foreach (String cell in grid)
            {
                if (cell == Positioning)
                {
                    return true;
                }
            }
            return false;
        }
    }
}