// See https://aka.ms/new-console-template for more information
using System;

namespace Csharp_Interfaces {
    internal class Program {
        static void Main(string[] args) {
            string line = "====================";
            string inputNow = "Input width and height, in that order";
            string notFound = "No such calculation exists, input again \n==================";
            string whatToDo = "What do you wish to calculate? \nArea, Circumferance or Both?";

            int loop = 0;
            int width;
            int height;

            Console.Write("Input which shape you'd like to edit: ");
            string answer = Console.ReadLine();
            if(answer == "Cylinder") {
                
            } else if(answer == "Rectangle") {

            } else if(answer == "Shape") {

            } else if(answer == "Circle") {

            } else if(answer == "Triangle") {

            } else {

            }
        }
    }
}