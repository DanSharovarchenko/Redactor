using System;

namespace Redactor
{
    class Specifications
    {
        public ConsoleColor Color { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public int Width { get; set; }
        public Specifications(ConsoleColor color, int x, int y, int width)
        {
            Color = color;
            X = x;
            Y = y;
            Width = width;
        }
        public Specifications()
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

    }
}



