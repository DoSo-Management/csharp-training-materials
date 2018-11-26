using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace GeometricFiguresCalculator
{
    class Program { 
        static void Main(string[] args)
        {
            Dialog dialog = new Dialog();
            dialog.Welcome();
        }
    }


    class ConsoleWrapper {
        public void WriteLine(string text) {
            Console.WriteLine(text);
        }

        public void Write(string text) {
            Console.Write(text);
        }

        public ConsoleKeyInfo ReadKey() {
            return Console.ReadKey();
        }
    }


    class FileWrapper {
        public void WriteAllText(string path, string content) {
            File.WriteAllText(path, content);
        }

        public string ReadAllText(string fileName) {
            return File.ReadAllText(fileName);
        }
    }
}
