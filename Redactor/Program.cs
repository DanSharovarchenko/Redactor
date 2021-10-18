using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Redactor
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.SetCursorPosition(0, 0);
                Console.Write("Если хотите нарисовать квадрат, напишите 1, прямоугольник 2, треугольник 3: ");
                string input = Console.ReadLine();
                int.TryParse(input, out int figure);
                
                

                switch (figure)
                {
                    case 1:
                        {
                            Console.SetCursorPosition(0, 0);
                            Console.Write("Выберите цвет фигуры: ");
                            input = Console.ReadLine();
                            int.TryParse(input, out int Color);
                            Console.ForegroundColor = (ConsoleColor)(Color);
                            Console.Write("Выберите X: ");
                            input = Console.ReadLine();
                            int.TryParse(input, out int X);

                            Console.Write("Выберите Y: ");
                            input = Console.ReadLine();
                            int.TryParse(input, out int Y);
                            if (Y > X)
                            {
                                while (Y > X)
                                {
                                    input = Console.ReadLine();
                                    int.TryParse(input, out Y);

                                }
                            }

                            Console.Write("Введите ширину фигуры: ");
                            input = Console.ReadLine();
                            int.TryParse(input, out int Width);
                            

                            
                            Square square = new Square((ConsoleColor)(Color), X, Y, Width);
                            square.Draw();
                            break;
                        }
                    case 2:
                        {
                            Console.SetCursorPosition(0, 0);
                            Console.Write("Выберите цвет фигуры: ");
                            input = Console.ReadLine();
                            int.TryParse(input, out int Color);
                            Console.ForegroundColor = (ConsoleColor)(Color);
                            Console.Write("Выберите X: ");
                            input = Console.ReadLine();
                            int.TryParse(input, out int X);

                            Console.Write("Выберите Y: ");
                            input = Console.ReadLine();
                            int.TryParse(input, out int Y);
                            if (Y > X)
                            {
                                while (Y > X)
                                {
                                    input = Console.ReadLine();
                                    int.TryParse(input, out Y);

                                }
                            }

                            Console.Write("Введите ширину фигуры: ");
                            input = Console.ReadLine();
                            int.TryParse(input, out int Width);
                            Console.Write("Введите длину фигуры: ");
                            input = Console.ReadLine();
                            int.TryParse(input, out int Length);
                            

                            Rectangle rectangle = new Rectangle((ConsoleColor)(Color), X, Y, Width, Length);


                            rectangle.Draw();
                            break;
                        }
                    case 3:
                        {
                            Console.SetCursorPosition(0, 0);
                            Console.Write("Выберите цвет фигуры: ");
                            input = Console.ReadLine();
                            int.TryParse(input, out int Color);
                            Console.ForegroundColor = (ConsoleColor)(Color);
                            Console.Write("Выберите X: ");
                            input = Console.ReadLine();
                            int.TryParse(input, out int X);
                            
                            Console.Write("Выберите Y: ");
                            input = Console.ReadLine();
                            int.TryParse(input, out int Y);
                            if (Y > X)
                            {
                                while (Y > X)
                                {
                                    input = Console.ReadLine();
                                    int.TryParse(input, out Y);

                                }
                            }
                            
                            Console.Write("Введите ширину фигуры: ");
                            input = Console.ReadLine();
                            int.TryParse(input, out int Width);
                            Console.Write("Введите длину фигуры: ");
                            input = Console.ReadLine();
                            int.TryParse(input, out int Length);
                            

                            Triangle triangle = new Triangle((ConsoleColor)(Color), X,Y,Width, Length);
                            
                            
                            triangle.Draw();
                            break;
                        }
                }
                
            }
        }
    }
}
