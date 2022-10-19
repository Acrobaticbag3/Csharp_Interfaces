using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Csharp_Interfaces {
    public class Cylinder : Ishape {
        //Variables list
        private int height; 
        private int radius;
        private string spacing = "==================";

        public Cylinder() { // A default constructor 
            
        }

        // === === Calculations === === \\
        public void Circumference() { 
            InputData();
            double circumference = 3.14 * radius * 2;
            Console.WriteLine("the circumference of this cylinder is: " + circumference);
            Console.WriteLine(spacing);
        }
        public void Area() { 
            InputData();
            double area = 2 * 3.14 * radius * height + 2 * 3.14 * radius * radius;
            Console.WriteLine("the area of this cylinder is: " + area);
            Console.WriteLine(spacing);
        }
        private void InputData() {
            Console.WriteLine(spacing);
            Console.Write("Input height: ");
            height = int.Parse(Console.ReadLine());

            Console.Write("Input radius: ");
            radius = int.Parse(Console.ReadLine());
            Console.WriteLine(spacing);
        }
    }
}