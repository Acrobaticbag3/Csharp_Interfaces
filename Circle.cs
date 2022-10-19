using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Csharp_Interfaces {
    public class Circle : Ishape {
        // variables list
        private int radius;
        private string spacing = "==================";

        public Circle() { // A default constructor 

        }

        // === === Calculations === === \\
        public void Circumference() { 
            InputData();
            double circumference = 2 * radius * 3.14;
            Console.WriteLine("the circumference of this circle is: " + circumference);
            Console.WriteLine(spacing);
        }
        public void Area() { 
            InputData();
            double area = 3.14 * radius * radius;
            Console.WriteLine("the Area of this circle is: " + area);
            Console.WriteLine(spacing);
        }
        private void InputData() {
            Console.WriteLine(spacing);
            Console.Write("Input radius: ");
            radius = int.Parse(Console.ReadLine());
            Console.WriteLine(spacing);
        }
    }
}