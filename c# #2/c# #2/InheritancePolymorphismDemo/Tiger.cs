using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c___2.InheritancePolymorphismDemo
{
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
}
