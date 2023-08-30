using System;

namespace c___2.InheritancePolymorphismDemo
{


    class Program
    {
        static void Main(string[] args)
        {
            Lion lion = new Lion(100, "Lion");
            Tiger tiger = new Tiger(200, " Tiger");

            Animal[] animals = { lion, tiger };

            foreach (var animal in animals)
            {
                animal.Show();
                Console.WriteLine();
            }
        }
    }
}