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
            map = new DefaultMap(40, 40);
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

                if (snake.X < 0 || snake.X >= map.Width ||
                snake.Y < 0 || snake.Y >= map.Height)
                {
                    snake.isAlive = false;
                }

                if (snake.X == fruit.X && snake.Y == fruit.Y)
                {
                    fruit.Eaten(map.Width, map.Height);
                    snake.Increase();
                }

                map.Draw(snake.X, snake.Y, fruit.X, fruit.Y);
                Thread.Sleep(200);
            }

            Console.Clear();
            Console.WriteLine("The game has ended");
            Console.WriteLine($"You have {fruit.Points} points");
        }
    }
}