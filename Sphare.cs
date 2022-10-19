using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Csharp_Interfaces {
    public class Sphere : Ishape{
        //Variables list
        private int radius;
        private string spacing = "==================";

        public Sphere() { // A default constructor 

        }

        // === === Calculations === === \\
        public void Circumference() {
            InputData();
            double circumference = radius * 3.14;
            Console.WriteLine("the circumference of this sphere is: " + circumference);
            Console.WriteLine(spacing);
        }
        public void Area() {
            InputData();
            double area = 4 * 3.14 * radius * radius;
            Console.WriteLine("the area of this sphere is: " + area);
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