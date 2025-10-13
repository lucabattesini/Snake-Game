using Characters;
using Map;

namespace Game
{
    public class GameRunner
    {
        private DefaultSnake snake;
        private DefaultMap map;

        public GameRunner()
        {
            map = new DefaultMap(40, 40);
            snake = new DefaultSnake(5, 5);
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

                map.Draw(snake.X, snake.Y);
                Thread.Sleep(200);
            }

            Console.Clear();
            Console.WriteLine("Fim de jogo");
        }
    }
}