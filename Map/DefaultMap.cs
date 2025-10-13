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

        public void Draw(int snakeX, int snakeY)
        {
            Console.Clear();

            for (int y = 0; y < Height; y++)
            {
                for (int x = 0; x < Width; x++)
                {
                    if (x == snakeX && y == snakeY)
                        Console.Write("=");
                    else
                        Console.Write(" ");
                }
                Console.WriteLine();
            }
        }
    }
}