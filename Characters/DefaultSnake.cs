namespace Characters
{
    public class DefaultSnake
    {
        private int Dx = 1;
        private int Dy = 0;

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

        public List<int> BodyX = new List<int>();
        public List<int> BodyY = new List<int>();

        public bool isAlive
        {
            get;
            set;
        }

        public DefaultSnake(int startX, int startY)
        {
            isAlive = true;
            X = startX;
            Y = startY;
            BodyX.AddRange(new int[] { X-1, X-2 });
            BodyY.AddRange(new int[] { Y-1, Y-2 });
        }

        public void Move()
        {
            BodyX.Add(X);
            BodyY.Add(Y);

            BodyX.RemoveAt(0);
            BodyY.RemoveAt(0);

            X += Dx;
            Y += Dy;
        }
        public void ChangeDirection(int newDx, int newDy)
        {
            Dx = newDx;
            Dy = newDy;
        }

        public void Increase()
        {
            BodyX.Insert(0, BodyX[0]);
            BodyY.Insert(0, BodyY[0]);
        }
        
    }
}