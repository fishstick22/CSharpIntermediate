using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpIntermediate.Casting
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape shape = new Text();
            Text text = (Text)shape;

            text.Width = 100;
            shape.Width = 200;

            if (text is Shape)
            {
                Console.WriteLine("var text is a Shape object");

                Console.WriteLine("text Width: " + text.Width);
                Console.WriteLine("shape Width: " + shape.Width);
            }

            text.FontName = "Arial";
            // shape.FontName = "Arial"; no worky

            var text2 = shape as Text;

            Console.WriteLine("text2 Width: " + text2.Width);

            var shape2 = text as Shape;

            Console.WriteLine("shape2 Width: " + shape2.Width);

            var shape3 = (Shape)text;

            Console.WriteLine("shape3 Width: " + shape3.Width);

            var text3 = (Text)shape;

            Console.WriteLine("text3 FontName: " + text3.FontName);

            var shape4 = new Shape();

            // make it go boom (System.InvalidCastException)
            Console.WriteLine("shape4 FontName: " + ((Text)shape4).FontName);

        }
    }
}
