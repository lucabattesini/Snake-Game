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

        

        public bool isAlive
        {
            get;
            set;
        }

        public int length
        {
            get;
            private set;
        }

        public DefaultSnake(int startX, int startY)
        {
            isAlive = true;
            X = startX;
            Y = startY;
            length = 3;
        }

        public void Move()
        {
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
            length += 1;
        }
        
    }
}