using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Csharp_Interfaces {
    public class Circle : Ishape {
        private int radius;
        private int diameter;
        public Circle() {

        }

        public void circumference() {

        }
        public void Area() {

        }

        public void Input_Data() {
            Console.WriteLine(value: "Input radius: ");
            radius = int.Parse(s: Console.ReadLine());
            
            Console.WriteLine(value: "Input diameter: ");
            diameter = int.Parse(s: Console.ReadLine());
        }
        public void Print_Data() {

        }
    }
}