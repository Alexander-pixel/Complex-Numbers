using System;

namespace ComplexNumbers
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Complex z = new Complex() {Real = 1, Imaginary = 1};
            Complex z1 = z - (z * z * z - 1) / (3 * z * z);
            Console.WriteLine(z1);
        }
    }
}