using System;

namespace InheritancePolymorphismDemo
{
    public class Animal
    {
        protected double weight;
        protected string name;

        public Animal(double weight, string name)
        {
            this.weight = weight;
            this.name = name;
        }

        public void SetMe(double weight, string name)
        {
            this.weight = weight;
            this.name = name;
        }

        public virtual void Show()
        {
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Weight: {weight} kg");
        }
    }

    public class Lion : Animal
    {
        public Lion(double weight, string name) : base(weight, name)
        {
        }

        public override void Show()
        {
            Console.WriteLine("Lion Information:");
            base.Show();
        }
    }

    public class Tiger : Animal
    {
        public Tiger(double weight, string name) : base(weight, name)
        {
        }

        public override void Show()
        {
            Console.WriteLine("Tiger Information:");
            base.Show();
        }
    }

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