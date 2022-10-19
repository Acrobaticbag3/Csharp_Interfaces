using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Csharp_Interfaces {
    public class Rectangle : Ishape{
        //Variables list
        private int width;
        private int height;
        private string spacing = "==================";

        public Rectangle() { // A default constructor 
            
        }

        // === === Calculations === === \\
        public void Circumference(){
            InputData();
            int circumference = width * 2 + height * 2;
            Console.WriteLine("the circumference of this rectangle is: " + circumference);
            Console.WriteLine(spacing);
        }
        public void Area(){
            InputData();
            int area = width * height;
            Console.WriteLine("The area of this rectangle is: " + area);
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