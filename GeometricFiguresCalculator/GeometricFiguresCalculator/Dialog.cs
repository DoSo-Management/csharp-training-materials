using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricFiguresCalculator {
    class Dialog {
        ConsoleWrapper _cWrapper;
        string _welcomeText;
        string _choiceText;

        public Dialog() {
            _cWrapper = new ConsoleWrapper();
            _welcomeText = @"Welcome to Geometric Figures Calculator.
Choose figure you want to work with:";
            _choiceText = @"1. Circle
2. Triangle
3. Rectangle
4. Parallelogram";
        }

        public void Welcome() {
            _cWrapper.WriteLine(_welcomeText);
            _cWrapper.ReadKey();
        }

        public void MakeChoice() {

        }
    }
}
