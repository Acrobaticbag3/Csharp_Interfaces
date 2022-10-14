using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Csharp_Interfaces {
    public class Triangle {
        //Variabels list
        private int width;
        private int height;
        private string spacing = "==================";
        
        public Triangle() { // A default constructor 

        }

        // === === Calculations === === \\
        public void Circumference() {
            int circumferance = width * 2 + height * 2;
            Console.WriteLine("the circumferance of this triangle is: " + circumferance);
        }
        public void Area() {
            int area = width * height / 2;
            Console.WriteLine("The area of this triangle is: " + area);
        }

        // === === Stores and declares variabels === === \\
        public void InputData() {
            Console.Write("Input width: ");
            width = int.Parse(Console.ReadLine());

            Console.Write("Input height: ");
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