using Characters;
using Map;
using Food;

namespace Game
{
    public class GameRunner
    {
        private DefaultSnake snake;
        private DefaultMap map;
        private Apple fruit;

        public GameRunner()
        {
            map = new DefaultMap(20, 20);
            snake = new DefaultSnake(5, 5);
            fruit = new Apple(10, 10);
            Console.CursorVisible = false;
        }

        private void ReadKeys()
        {
            if (Console.KeyAvailable)
            {
                var key = Console.ReadKey(true).Key;

                switch (key)
                {
                    case ConsoleKey.UpArrow:
                        snake.ChangeDirection(0, -1);
                        break;

                    case ConsoleKey.DownArrow:
                        snake.ChangeDirection(0, 1);
                        break;

                    case ConsoleKey.RightArrow:
                        snake.ChangeDirection(1, 0);
                        break;

                    case ConsoleKey.LeftArrow:
                        snake.ChangeDirection(-1, 0);
                        break;
                }
            }
        }
        public void Run()
        {
            while (snake.isAlive)
            {
                ReadKeys();
                snake.Move();

                if (snake.X < 1 || snake.X >= map.Width - 1||
                snake.Y < 1 || snake.Y >= map.Height -1)
                {
                    snake.isAlive = false;
                }

                for (int i = 0; i < snake.BodyX.Count && i < snake.BodyY.Count; i++)
                {
                    if (snake.BodyX[i] == snake.X && snake.BodyY[i] == snake.Y)
                    {
                        snake.isAlive = false;
                    }
                }

                if (snake.X == fruit.X && snake.Y == fruit.Y)
                {
                    fruit.Eaten(map.Width, map.Height);
                    snake.Increase();
                }

                map.Draw(snake.X, snake.Y, fruit.X, fruit.Y, snake.BodyX, snake.BodyY);
                Thread.Sleep(100);
            }

            Console.Clear();
            Console.WriteLine("The game has ended");
            Console.WriteLine($"You have {fruit.Points} points");
        }
    }
}