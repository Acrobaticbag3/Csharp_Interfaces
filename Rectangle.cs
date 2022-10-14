using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Csharp_Interfaces {
    public class Rectangle {
        private int width;
        private int height;
        private string spacing = "==================";

        public Rectangle() {
            
        }

        public void Circumference(){
            int circumferance = width * 2 + height * 2;
            Console.WriteLine("the circumferance of this rectangle is: " + circumferance);
        }
        public void Area(){
            int area = width * height;
            Console.WriteLine("The area of this rectangle is: " + area);
        }

        public void InputData() {
            Console.WriteLine("Input width: ");
            width = int.Parse(Console.ReadLine());

            Console.WriteLine("Input height: ");
            height = int.Parse(Console.ReadLine());
        }
        public void InputAndPrintData() {
            InputData();

            Console.Write("what do you wish to calculate with this data? Area Circumference or Both\n Input: ");
            string Answer = Console.ReadLine();
            switch(Answer) {
            case "circumference":
                Console.WriteLine(spacing);
                Circumference();
                Console.WriteLine(spacing);
                break;

            case "Area":
                Console.WriteLine(spacing);
                Area();
                Console.WriteLine(spacing);
                break;

            case "Both":
                Console.WriteLine(spacing);
                Circumference();
                Area();
                Console.WriteLine(spacing);
                break;
            }
        }
    }
}