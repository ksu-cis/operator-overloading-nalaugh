using System;

namespace VectorMath
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Fun with vectors");

            Vector3 one = new Vector3(5, 4, 3);
            Vector3 two = new Vector3(2, 8, 6);
            Console.WriteLine("Adding two vectores:");
            Console.WriteLine($"with a static method: {Vector3.Add(one, two)}");
            //one.Add(two);
            Console.WriteLine($"with a class method: {one}");

            Console.WriteLine($"With operator overloading: {one + two}");
            Console.WriteLine($"With scaler operartor overload: {10 * one}");
            Console.WriteLine($"With comparison: {one == two}");
            Console.WriteLine($"With comparison: {one == new Vector3(5,4,3)}");

            if (one)
            {
                Console.WriteLine("Vector one is not zero");
            }
            else
            {
                Console.WriteLine("Vector one is zero");
            }
        }
    }
}
