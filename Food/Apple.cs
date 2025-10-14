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

            X = random.Next(0, rangeX);
            Y = random.Next(0, rangeY);
            Points += 1;
        }
    }
}