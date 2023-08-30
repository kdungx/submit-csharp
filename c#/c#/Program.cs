using c_.GeometryExample;
using System;

namespace c_.GeometryExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the radius: ");
            double radius = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the height: ");
            double height = Convert.ToDouble(Console.ReadLine());

            Cylinder cylinder = new Cylinder(radius, height);

            Console.WriteLine("\nCylinder Characteristics:");
            cylinder.Process();

           
           
        }
    }
}