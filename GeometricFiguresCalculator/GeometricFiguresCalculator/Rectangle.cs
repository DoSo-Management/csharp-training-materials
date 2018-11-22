using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricFiguresCalculator {
    class Rectangle : IFigure {
        double _sideA; // Length
        double _sideB; // Width
        public Rectangle(double length, double width) {
            _sideA = length;
            _sideB = width;
        }

        public virtual double GetArea() {
            var area = _sideA * _sideB; // Length * Width
            return area;
        }

        public virtual double GetPerimeter() {
            var perimeter = (2 * _sideA) + (2 * _sideB); // (2 * Length) + (2 * Width)
            return perimeter;
        }
    }
}
