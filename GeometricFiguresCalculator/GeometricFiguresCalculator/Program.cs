using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricFiguresCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Console's Geometric Figures Calculator.");
            Console.WriteLine("Choose between these options to calculate: ");
            Console.WriteLine("1.Triangle");
            Console.WriteLine("2.Rectangle");
            Console.WriteLine("3.Parallelogram");
            ConsoleKeyInfo consoleKey = Console.ReadKey();
            if (consoleKey.Key == ConsoleKey.D1)
            {
                Console.WriteLine();
                Console.Write("Enter side A: ");
                var sideA = Double.Parse(Console.ReadLine());
                Console.Write("Enter side B: ");
                var sideB = Double.Parse(Console.ReadLine());
                Console.Write("Enter side C: ");
                var sideC = Double.Parse(Console.ReadLine());
                Console.WriteLine("Do you want to Calculate Triangle's Area or Perimeter?: ");
                Console.WriteLine("1.Perimeter");
                Console.WriteLine("2.Area");
                consoleKey = Console.ReadKey();
                if (consoleKey.Key == ConsoleKey.D1)
                {
                    Console.WriteLine();
                    Triangle Triangle = new Triangle(sideA, sideB, sideC);
                    var Zeta = Triangle.GetPerimeter();
                    Console.WriteLine($"the perimeter is eqaul {Zeta}");
                    Console.ReadLine();
                }
                else if (consoleKey.Key == ConsoleKey.D2)
                {
                    Console.WriteLine();
                    Console.Write("Enter height of Triangle: ");
                    var height = Double.Parse(Console.ReadLine());
                    Triangle Triangle = new Triangle(sideA, sideB, sideC, height);
                    Triangle.GetArea();
                    Console.ReadLine();
                }
            } else if (consoleKey.Key == ConsoleKey.D2)
            {
                Console.WriteLine();
                Console.Write("Enter Length: ");
                var length = Double.Parse(Console.ReadLine());
                Console.Write("Enter Width: ");
                var width = Double.Parse(Console.ReadLine());
                var Rectangle = new Rectangle(length, width);
                Console.WriteLine("Do you want to Calculate Rectangle's Perimeter or Area?: ");
                Console.WriteLine("1.Perimeter");
                Console.WriteLine("2.Area");
                consoleKey = Console.ReadKey();
                if (consoleKey.Key == ConsoleKey.D1)
                {
                    Console.WriteLine();
                    Rectangle.GetPerimeter();
                }
                else if (consoleKey.Key == ConsoleKey.D2)
                {
                    Console.WriteLine();
                    Rectangle.GetArea();  
                }
            } else if (consoleKey.Key == ConsoleKey.D3)
            {
                Console.WriteLine();
                Console.Write("Enter Length: ");
                var length = Double.Parse(Console.ReadLine());
                Console.Write("Enter Width: ");
                var width = Double.Parse(Console.ReadLine());
                Console.WriteLine("Do you want to Calculate Parallelogram's Perimeter or Area?: ");
                Console.WriteLine("1.Perimeter");
                Console.WriteLine("2.Area");
                consoleKey = Console.ReadKey();
                if (consoleKey.Key == ConsoleKey.D1)
                {
                    Console.WriteLine();
                    Paralellogram Paralellogram = new Paralellogram(length, width);
                    Paralellogram.GetPerimeter();
                    Console.ReadLine();
                } else if (consoleKey.Key == ConsoleKey.D2) 
                {
                    Console.WriteLine();
                    Console.Write("Enter Paralellogram's Height: ");
                    var height = Double.Parse(Console.ReadLine());
                    Paralellogram Paralellogram = new Paralellogram(length, width, height);
                    Paralellogram.GetArea();
                    Console.ReadLine();
                }
            } 
        }
    }
}

