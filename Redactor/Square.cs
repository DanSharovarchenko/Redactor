using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Redactor
{
    class Square : Specifications
    {
        public Square(ConsoleColor color, int x, int y, int width)
            :base(color, x, y, width)
        {
            
        }
        public Square()
        {
            Color = color;
            X = x;
            Y = y;
            Width = width;
        }
        public ConsoleColor color;
        public int x;
        public int y;
        public int width;

        public void Draw()
        {

            for (int i = 0; i < Width; i++)
            {
                Console.SetCursorPosition(X + i, Y);
                Console.Write("* ");
                Console.SetCursorPosition(X + i, Y - Width);
                Console.Write("* ");
            }
            for (int i = 1; i < Width; i++)
            {
                Console.SetCursorPosition(X, Y - i);
                Console.WriteLine("*");
                Console.SetCursorPosition(X + Width, Y - i);
                Console.Write("*");

            }


        }
    }
}
