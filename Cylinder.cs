using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Csharp_Interfaces {
    public class Cylinder : Ishape {
        private int diameter;
        private int height; 
        private int radius;

        public Cylinder() {
            
        }

        public void circumference(){
            
        }
        public void Area(){
            
        }

        public void Input_Data() {
            Console.WriteLine(value: "Input Diameter: ");
            diameter = int.Parse(s: Console.ReadLine());

            Console.WriteLine(value: "Input Height: ");
            height = int.Parse(s: Console.ReadLine());

            Console.WriteLine(value: "Input radius: ");
            radius = int.Parse(s: Console.ReadLine());
        }
        public void Print_Data() {

        }
    }
}