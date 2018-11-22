using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricFiguresCalculator {
    class Circle {
        float _PI = 3.14f;
        double _Radius;

        public Circle(double Radius) {
            _Radius = Radius;
        }
        public double GetArea() {
            var Area = _PI * _Radius * _Radius;
            return Area;
        }
    }
}
