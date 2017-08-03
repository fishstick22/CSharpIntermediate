using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpIntermediate.AbstractClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            // var shape = new Shape();


            var circle = new Circle();
            circle.Draw();
            circle.Copy();

            var rectangle = new Rectangle();
            rectangle.Draw();
            rectangle.Copy();
        }
    }
}
