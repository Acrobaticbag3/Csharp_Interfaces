// See https://aka.ms/new-console-template for more information
using System;

namespace Csharp_Interfaces {
    internal class Program {
        static void Main(string[] args) {
            string mainQuestion = "Calculate circumference, Area or Both?";
            string mainAnswer;

            List<Ishape> shapes = new List<Ishape>();
            shapes.Add(item: new Circle());
            shapes.Add(item: new Cylinder());
            shapes.Add(item: new Rectangle());
            shapes.Add(item: new Sphere());
            shapes.Add(item: new Triangle());

            Console.Write(value: "Choose which shape to edit: "); 
            string answerTwo = Console.ReadLine();
            switch (answerTwo) {
            case "Triangle" :
                foreach (Ishape shape in shapes) {
                    if(shape is Triangle) {
                        Console.WriteLine(value: mainQuestion);
                        mainAnswer = Console.ReadLine();

                        switch (mainAnswer) {
                            case "Circumference" :
                                shape.Circumference();
                                break;

                            case "Area" :
                                shape.Area();
                                break;

                            case "Both" :
                                shape.Circumference();
                                shape.Area();
                                break;

                            default :
                                Console.Write(value: "Err: N/A");
                                break;
                        }
                    }
                    Console.ReadKey();
                }
                break;

            case "Sphere" :
                foreach (Ishape shape in shapes) {
                    if(shape is Sphere) {
                        Console.WriteLine(value: mainQuestion);
                        mainAnswer = Console.ReadLine();

                        switch (mainAnswer) {
                            case "Circumference" :
                                shape.Circumference();
                                break;

                            case "Area" :
                                shape.Area();
                                break;

                            case "Both" :
                                shape.Circumference();
                                shape.Area();
                                break;

                            default :
                                Console.Write(value: "Err: N/A");
                                break;
                        }
                    }
                    Console.ReadKey();
                }
                break;

            case "Rectangle" :
                foreach (Ishape shape in shapes) {
                    if(shape is Rectangle) {
                        Console.WriteLine(value: mainQuestion);
                        mainAnswer = Console.ReadLine();

                        switch (mainAnswer) {
                            case "Circumference" :
                                shape.Circumference();
                                break;

                            case "Area" :
                                shape.Area();
                                break;

                            case "Both" :
                                shape.Circumference();
                                shape.Area();
                                break;

                            default :
                                Console.Write(value: "Err: N/A");
                                break;
                        }
                    }
                    Console.ReadKey();
                }
                break;

            case "Cylinder" :
                foreach (Ishape shape in shapes) {
                    if(shape is Cylinder) {
                        Console.WriteLine(value: mainQuestion);
                        mainAnswer = Console.ReadLine();

                        switch (mainAnswer) {
                            case "Circumference" :
                                shape.Circumference();
                                break;

                            case "Area" :
                                shape.Area();
                                break;

                            case "Both" :
                                shape.Circumference();
                                shape.Area();
                                break;

                            default :
                                Console.Write(value: "Err: N/A");
                                break;
                        }
                    }
                    Console.ReadKey();
                }
                break;

            case "Circle" :
                foreach (Ishape shape in shapes) {
                    if(shape is Circle) {
                        Console.WriteLine(value: mainQuestion);
                        mainAnswer = Console.ReadLine();

                        switch (mainAnswer) {
                            case "Circumference" :
                                shape.Circumference();
                                break;

                            case "Area" :
                                shape.Area();
                                break;

                            case "Both" :
                                shape.Circumference();
                                shape.Area();
                                break;

                            default :
                                Console.Write(value: "Err: N/A");
                                break;
                        }
                    }
                    Console.ReadKey();
                }
                break;

            default :
                Console.WriteLine(value: "Not a viable shape.");
                break;
            }
        }
    }
}