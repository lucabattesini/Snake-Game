using System;

namespace Map
{
    public class DefaultMap
    {
        public int Height { get; }
        public int Width { get; }

        public DefaultMap(int height, int width)
        {
            Height = height;
            Width = width;
        }

        public void Draw(int snakeX, int snakeY, int fruitX, int fruitY)
        {
            Console.Clear();

            for (int y = 0; y < Height; y++)
            {
                for (int x = 0; x < Width; x++)
                {
                    if (y == 0 || y == Height - 1 || x == 0 || x == Width - 1)
                        Console.Write("#");
                        
                    if (x == snakeX && y == snakeY)
                        Console.Write("0");

                    if (x == fruitX && y == fruitY)
                        Console.Write("*");

                    else
                        Console.Write("  ");
                }
                Console.WriteLine();
            }
        }
    }
}