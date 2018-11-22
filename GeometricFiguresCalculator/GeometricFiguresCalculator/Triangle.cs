using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricFiguresCalculator {
    public class Triangle : IFigure {
        double _sideA;
        double _sideB;
        double _sideC;
        double _height;

        public Triangle(double sideA, double sideB, double sideC) {
            _sideA = sideA;
            _sideB = sideB;
            _sideC = sideC;
        }

        public Triangle(double sideA, double sideB, double sideC, double height) {
            _sideA = sideA;
            _sideB = sideB;
            _sideC = sideC;
            _height = height;
        }

        public double GetArea() {
            var area = 1 / 2 * (_height * _sideC);
            return area;
        }

        public double GetPerimeter() {
            var perimeter = _sideA + _sideB + _sideC;
            return perimeter;
        }
    }
}
