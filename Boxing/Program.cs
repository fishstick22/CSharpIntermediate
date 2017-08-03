using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpIntermediate.Boxing
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new ArrayList();
            list.Add(1);
            list.Add("Mosh");
            list.Add(DateTime.Today);

            // apparently, creating a primitive then wrapping it in an object is
            // "boxing" and causes poor performance

            var anotherList = new List<int>();
            var names = new List<string>();
        }
    }
}
