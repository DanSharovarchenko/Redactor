using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Redactor
{
    class Rectangle : Specifications
    {
public int Length { get; set; }
        public Rectangle(ConsoleColor color, int x, int y, int width, int length)
            : base(color, x, y, width)
        {
            Length = length;
        }
        public Rectangle()
        {
            Color = color;
            X = x;
            Y = y;
            Width = width;
            Length = length;
        }
        public ConsoleColor color;
        public int x;
        public int y;
        public int width;
        public int length;

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
                Console.SetCursorPosition(X + Length, Y - i);
                Console.Write("*");

            }
        }
    }
}
