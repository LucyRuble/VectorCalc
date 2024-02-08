using System;

namespace Vector_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Vector test1 = new Vector(2, 7, 4);
            Vector test2 = new Vector(-4, -1, 4);


            // This should be 0, 4, 0
            Console.WriteLine("insert scale number");
            double usarnumber3 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("This is direction");
            Console.WriteLine(Vector.Add(test1, test2));
            Console.WriteLine("This is add");
            Console.WriteLine(Vector.Subtract(test1, test2));
            Console.WriteLine("This is negate");
            Console.WriteLine(Vector.Negate(test1));
            Console.WriteLine("This is subtract");
            Console.WriteLine(test1.GetMagnitude());
            Console.WriteLine("This is scale");
            Console.WriteLine(test1.GetDirection());
            Console.WriteLine("This is normalize");
            Console.WriteLine(Vector.Scale(test1, usarnumber3));
            Console.WriteLine("This is dot");
            Console.WriteLine(Vector.Normalize(test1));
            Console.WriteLine("This is cross");
            Console.WriteLine(Vector.DotProduct(test1, test2));
            Console.WriteLine("This is AngleBetween");
            Console.WriteLine(Vector.CrossProduct(test1, test2));
            Console.WriteLine("This is Project");
            Console.WriteLine(Vector.ProjectOnto(test1, test2));
        }
    }
}
