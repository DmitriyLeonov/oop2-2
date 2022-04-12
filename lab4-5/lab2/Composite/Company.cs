using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4.Composite
{
    internal class Company : Component
    {
        public Company(string name)
        : base(name)
        { }

        List<Component> components = new List<Component>();
        public override void Add(Component c)
        {
            components.Add(c);
        }

        public override void Display()
        {
            Console.WriteLine(name);

            foreach (Component component in components)
            {
                component.Display();
            }
        }

        public override void Remove(Component c)
        {
            components.Remove(c);
        }
    }
}
