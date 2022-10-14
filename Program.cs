// See https://aka.ms/new-console-template for more information
using System;

namespace Csharp_Interfaces {
    internal class Program {
        static void Main(string[] args) {
            Triangle triangle = new Triangle();

            triangle.InputAndPrintData();
            Console.ReadKey();
        }
    }
}