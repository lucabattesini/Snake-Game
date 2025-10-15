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

        public void Draw(int snakeX, int snakeY, int fruitX, int fruitY, List<int> bodyX, List<int> bodyY)
        {
            Console.Clear();
            Console.WriteLine(new string('=', 15) + "SNAKE GAME" + new string('=', 15));

            for (int y = 0; y < Height; y++)
            {
                for (int x = 0; x < Width; x++)
                {
                    var toDraw = "  ";

                    if (y == 0 || y == Height - 1 || x == 0 || x == Width - 1)
                        toDraw = "# " ;

                    if (x == snakeX && y == snakeY)
                        toDraw = "0 ";

                    for (int i = 0; i < bodyX.Count && i < bodyY.Count; i++)
                    {
                        if (bodyX[i] == x && bodyY[i] == y)
                        {
                            toDraw = "o ";
                        }
                    }

                    if (x == fruitX && y == fruitY)
                        toDraw = "* ";

                    Console.Write(toDraw);
                }
                Console.WriteLine();
            }
        }
    }
}