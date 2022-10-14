using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Csharp_Interfaces {
    public class Cylinder : Ishape {
        //Variabels list
        private int height; 
        private int radius;
        private string spacing = "==================";

        public Cylinder() { // A default constructor 
            
        }

        // === === Calculations === === \\
        public void Circumference() { 
            double circumferance = 3.14 * radius * 2;
            Console.WriteLine("the circumferance of this rectangle is: " + circumferance);
        }
        public void Area() { 
            double area = 2 * 3.14 * radius * height + 2 * 3.14 * radius * radius;
            Console.WriteLine("the circumferance of this rectangle is: " + area);
        }

        // === === Stores and declares variabels === === \\
        public void InputData() { 
            Console.WriteLine("Input height: ");
            height = int.Parse(Console.ReadLine());

            Console.WriteLine("Input radius: ");
            radius = int.Parse(Console.ReadLine());
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

            default :
                Console.WriteLine(spacing);
                Console.WriteLine("Error, not a viable calulation.");
                Console.WriteLine(spacing);
                break;
            }
        }
    }
}