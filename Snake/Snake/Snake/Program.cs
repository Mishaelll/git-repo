using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetBufferSize(80, 25);
            Console.SetWindowSize(80, 25);
        
            HorizontalLine upLine = new HorizontalLine(0,Console.WindowWidth-1,0,'-');
            HorizontalLine downLine = new HorizontalLine(0, Console.WindowWidth - 2, Console.WindowHeight-1, '-');
            upLine.Draw();
            downLine.Draw();

            VerticalLine leftLine = new VerticalLine(1, Console.WindowHeight - 2, 0, '|');
            VerticalLine rightLine = new VerticalLine(1, Console.WindowHeight - 2, Console.WindowWidth - 1, '|');
            leftLine.Draw();
            rightLine.Draw();

            Point p = new Point(4, 5, '*');
            p.Draw();

            Snake snake = new Snake(p, 4, Direction.RIGHT);
            snake.Draw();
            
            while(true)
            {
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.HandleKey(key.Key);
                }
                System.Threading.Thread.Sleep(100);
                snake.Move();
            }

            Console.ReadLine();
        }
    }
}
