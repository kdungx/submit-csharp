using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_.GeometryExample
{
    public class Cylinder
    {
        private double radius;
        private double height;

        public Cylinder(double radius, double height)
        {
            this.radius = radius;
            this.height = height;
        }

        public void Process()
        {
            double baseArea = radius * radius * Math.PI;
            double lateralArea = 2 * Math.PI * radius * height;
            double totalArea = 2 * Math.PI * radius * (height + radius);
            double volume = Math.PI * radius * radius * height;

            Console.WriteLine($"Base Area: {baseArea:F2}");
            Console.WriteLine($"Lateral Area: {lateralArea:F2}");
            Console.WriteLine($"Total Area: {totalArea:F2}");
            Console.WriteLine($"Volume: {volume:F2}");
        }

        public string Result()
        {
            double baseArea = radius * radius * Math.PI;
            double lateralArea = 2 * Math.PI * radius * height;
            double totalArea = 2 * Math.PI * radius * (height + radius);
            double volume = Math.PI * radius * radius * height;

            return $"Base Area: {baseArea:F2}\n" +
                   $"Lateral Area: {lateralArea:F2}\n" +
                   $"Total Area: {totalArea:F2}\n" +
                   $"Volume: {volume:F2}";
        }
    }
}
