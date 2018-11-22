﻿using System;
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
            }else if (consoleKey.Key == ConsoleKey.D2)
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
            }else if (consoleKey.Key == ConsoleKey.D3)
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


    public interface IFigure
    {
        double GetArea();
        double GetPerimeter();
    }


    public class Triangle : IFigure
    {
        double _sideA;
        double _sideB;
        double _sideC;
        double _height;

        public Triangle(double sideA, double sideB, double sideC)
        {
            _sideA = sideA;
            _sideB = sideB;
            _sideC = sideC;
        }

        public Triangle(double sideA, double sideB, double sideC, double height)
        {
            _sideA = sideA;
            _sideB = sideB;
            _sideC = sideC;
            _height = height;
        }
       public double GetArea()
        {
            var area = 1 / 2 * (_height * _sideC);
            return area;
        }

        public double GetPerimeter()
        {
            var perimeter = _sideA + _sideB + _sideC;
            return perimeter;
        }
    }

    class Rectangle : IFigure
    {
        double _sideA; // Length
        double _sideB; // Width
        public Rectangle(double length, double width) 
        {
            _sideA = length;
            _sideB = width;
        }

        public virtual double GetArea()
        {
            var area = _sideA * _sideB; // Length * Width
            return area;
        }

        public virtual double GetPerimeter()
        {
            var perimeter = (2 * _sideA) + (2 * _sideB); // (2 * Length) + (2 * Width)
            return perimeter;
        }
    }


    class Paralellogram
    {
        double _height;
        double _length;
        double _width;

        public Paralellogram(double length, double width)
        {
            _length = length;
            _width = width;
        }

        public Paralellogram(double length, double width,double height)
        {
            _length = length;
            _width = width;
            _height = height;
        }

        public double GetArea()
        {
            var area = (_height * _length);
            return area;
        }

        public double GetPerimeter()
        {
            var Perimeter = 2 * (_length + _width);
            Console.WriteLine($"Parallelogram's Perimeter: {Perimeter}");
            return Perimeter;
        }
    }

   class Circle 
    {
        float _PI = 3.14f;
        double _Radius;

        public Circle(double Radius)
        {
            _Radius = Radius;
        }
        public double GetArea()
        {
            var Area = _PI * _Radius * _Radius;
            return Area;
        }
    }

    class Sphere : Circle
    {
        public Sphere(double Radius) : base(Radius)
        {

        }
    }
}

