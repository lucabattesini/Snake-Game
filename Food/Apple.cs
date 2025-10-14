namespace Food
{
    public class Apple
    {
        public int X
        {
            get;
            private set;
        }
        public int Y
        {
            get;
            private set;
        }

        public int Points
        {
            get;
            private set;
        }

        public Apple(int startX, int startY)
        {
            Y = startY;
            X = startX;
        }

        public void Eaten(int rangeX, int rangeY)
        {
            Random random = new Random();

            X = random.Next(1, rangeX -1);
            Y = random.Next(1, rangeY -1);
            Points += 1;
        }
    }
}