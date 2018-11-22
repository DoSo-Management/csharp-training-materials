using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricFiguresCalculator {
    class Paralellogram {
        double _height;
        double _length;
        double _width;

        public Paralellogram(double length, double width) {
            _length = length;
            _width = width;
        }

        public Paralellogram(double length, double width, double height) {
            _length = length;
            _width = width;
            _height = height;
        }

        public double GetPerimeter() {
            var Perimeter = 2 * (_length + _width);
            Console.WriteLine($"Parallelogram's Perimeter: {Perimeter}");
            return Perimeter;
        }
    }
}
