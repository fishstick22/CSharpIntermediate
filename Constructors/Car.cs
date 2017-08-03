using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpIntermediate.Constructors
{
    public class Car : Vehicle
    {
        public Car()
        {
            Console.WriteLine("Car is being initialized. ");
        }
        public Car(string registrationNumber)
            : base(registrationNumber)
        {
            Console.WriteLine("Car is being initialized. {0}", registrationNumber);
        }
    }
}
