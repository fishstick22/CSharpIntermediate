using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpIntermediate.AbstractClasses
{
    public class Rectangle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Draw a rectangle");
        }

        public new void Copy() /// hide-- C# is wierd 
        {
            Console.WriteLine("Copy rectangle into clipboard.");
        }
    }
}
