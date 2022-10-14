// See https://aka.ms/new-console-template for more information
using System;

namespace Csharp_Interfaces {
    internal class Program {
        static void Main(string[] args) {
            //Variabels list
            string spacing = "==================";
            string answerTwo;
            int loop = 1;
            int loopTwo = 1;

            while(loop != 0) { //Continues to as the question as long as loop != 0
                Console.WriteLine("Witch shape would you like to use? Circle, Cylinder, Rectangle, Sphare, Triangle \nInput: ");
                string answer = Console.ReadLine();
                switch(answer) {
                case "Circle": //Get and show data for the Circle
                    Console.WriteLine(spacing);
                    Circle circle = new Circle();
                    circle.InputAndPrintData();
                    Console.ReadKey();

                    Console.WriteLine("Continue? y/n");
                    answerTwo = Console.ReadLine();
                    while(loopTwo != 0) {
                        if(answerTwo == "y") {
                            loopTwo--;
                        } else if(answerTwo == "n") {
                            loop--; //sets loop to 0, which ends the loop
                            loopTwo--;
                        } else {
                            //Does nothing so that the question can repeat.
                        }
                    }
                    break;

                case "Cylinder": //Get and show data for the Cylinder
                    Console.WriteLine(spacing);
                    Cylinder cylinder = new Cylinder();
                    cylinder.InputAndPrintData();
                    Console.ReadKey();
                    
                    Console.WriteLine("Continue? y/n");
                    answerTwo = Console.ReadLine();
                    while(loopTwo != 0) {
                        if(answerTwo == "y") {
                            loopTwo--;
                        } else if(answerTwo == "n") {
                            loop--; //sets loop to 0, which ends the loop
                            loopTwo--;
                        } else {
                            //Does nothing so that the question can repeat.
                        }
                    }
                    break;

                case "Rectangle": //Get and show data for the Rectangle
                    Console.WriteLine(spacing);
                    Rectangle rectangle = new Rectangle();
                    rectangle.InputAndPrintData();
                    Console.ReadKey();
                    
                    Console.WriteLine("Continue? y/n");
                    answerTwo = Console.ReadLine();
                    while(loopTwo != 0) {
                        if(answerTwo == "y") {
                            loopTwo--;
                        } else if(answerTwo == "n") {
                            loop--; //sets loop to 0, which ends the loop
                            loopTwo--;
                        } else {
                            //Does nothing so that the question can repeat.
                        }
                    }
                    break;

                case "Sphere": //Get and show data for the Sphere
                    Console.WriteLine(spacing);
                    Sphere sphare = new Sphere();
                    sphare.InputAndPrintData();
                    Console.ReadKey();
                    
                    Console.WriteLine("Continue? y/n");
                    answerTwo = Console.ReadLine();
                    while(loopTwo != 0) {
                        if(answerTwo == "y") {
                            loopTwo--;
                        } else if(answerTwo == "n") {
                            loop--; //sets loop to 0, which ends the loop
                            loopTwo--;
                        } else {
                            //Does nothing so that the question can repeat.
                        }
                    }
                    break;

                case "Triangle": //Get and show data for the Triangle
                    Console.WriteLine(spacing);
                    Triangle triangle = new Triangle();
                    triangle.InputAndPrintData();
                    Console.ReadKey();
                    
                    Console.WriteLine("Continue? y/n");
                    answerTwo = Console.ReadLine();
                    while(loopTwo != 0) {
                        if(answerTwo == "y") {
                            loopTwo--;
                        } else if(answerTwo == "n") {
                            loop--; //sets loop to 0, which ends the loop
                            loopTwo--;
                        } else {
                            //Does nothing so that the question can repeat.
                        }
                    }
                    break;

                default :
                    Console.WriteLine(spacing);
                    Console.WriteLine("Error, not a viable shape.");
                    Console.WriteLine(spacing);
                    Console.ReadKey();
                    break;
                }      
            }
        }
    }
}