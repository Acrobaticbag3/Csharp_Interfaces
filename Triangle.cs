using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Csharp_Interfaces {
    public class Triangle : Ishape {
        //Variables list
        private int width;
        private int height;
        private string spacing = "==================";
        
        public Triangle() { // A default constructor 

        }

        // === === Calculations === === \\
        public void Circumference() {
            InputData();
            int circumference = width * 2 + height * 2;
            Console.WriteLine("the circumference of this triangle is: " + circumference);
            Console.WriteLine(spacing);
        }
        public void Area() {
            InputData();
            int area = width * height / 2;
            Console.WriteLine("The area of this triangle is: " + area);
            Console.WriteLine(spacing);
        }
        private void InputData() {
            Console.WriteLine(spacing);
            Console.Write("Input width: ");
            width = int.Parse(Console.ReadLine());

            Console.Write("Input height: ");
            height = int.Parse(Console.ReadLine());
            Console.WriteLine(spacing);
        }
    }
}