using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CSharpIntermediate.Amazon;


namespace CSharpIntermediate.AccessModifiers
{
    class Program
    {
        static void Main(string[] args)
        {
            var customer = new Customer();
            //Amazon.RateCalculator calculator = new RateCalculator();
            customer.Promote();
        }
    }
}
