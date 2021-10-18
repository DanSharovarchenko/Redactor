using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Redactor
{
    class Triangle : Specifications
    {
public int Length { get; set; }
        public Triangle(ConsoleColor color, int x, int y, int width, int length)
            : base(color, x, y, width)
        {
            Length = length;
        }
        public Triangle()
        {
            Color = color;
            X = x;
            Y = y;
            Width = width;
            Length = Length;
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
                Console.SetCursorPosition(X + i, Y + i);
                Console.Write("*");
                Console.SetCursorPosition(X - i, Y+i);
                Console.Write("*");
            }
            for (int i = 0; i < Length+1; i++)
            {
                Console.Write("*");
            }

        }
    }
}
