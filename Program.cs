// See https://aka.ms/new-console-template for more information
using System;


namespace Csharp_Interfaces {
    internal class Program {
        static void Main(string[] args) {
            string mainQuestion = "Calculate circumference, Area or Both?";
            string mainAnswer;

            List<Ishape> shapes = new List<Ishape>();
            shapes.Add(new Circle());
            shapes.Add(new Cylinder());
            shapes.Add(new Rectangle());
            shapes.Add(new Sphere());
            shapes.Add(new Triangle());

            Console.Write("Choose which shape to edit: "); 
            string answerTwo = Console.ReadLine();
            switch (answerTwo) {
            case "Triangle" :
                foreach (Ishape shape in shapes) {
                    if(shape is Triangle) {
                        Console.WriteLine(mainQuestion);
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
                                Console.Write("Err: N/A");
                                break;
                        }
                    }
                    Console.ReadKey();
                }
                break;

            case "Sphere" :
                foreach (Ishape shape in shapes) {
                    if(shape is Sphere) {
                        Console.WriteLine(mainQuestion);
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
                                Console.Write("Err: N/A");
                                break;
                        }
                    }
                    Console.ReadKey();
                }
                break;

            case "Rectangle" :
                foreach (Ishape shape in shapes) {
                    if(shape is Rectangle) {
                        Console.WriteLine(mainQuestion);
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
                                Console.Write("Err: N/A");
                                break;
                        }
                    }
                    Console.ReadKey();
                }
                break;

            case "Cylinder" :
                foreach (Ishape shape in shapes) {
                    if(shape is Cylinder) {
                        Console.WriteLine(mainQuestion);
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
                                Console.Write("Err: N/A");
                                break;
                        }
                    }
                    Console.ReadKey();
                }
                break;

            case "Circle" :
                foreach (Ishape shape in shapes) {
                    if(shape is Circle) {
                        Console.WriteLine(mainQuestion);
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
                                Console.Write("Err: N/A");
                                break;
                        }
                    }
                    Console.ReadKey();
                }
                break;

            default :
                Console.WriteLine("Not a viable shape.");
                break;
            }
        }
    }
}