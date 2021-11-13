using System;

namespace Test
{
    class Program
    {
        static double Pow2(double x)
        {
            int b = 2;
            return (double)Math.Pow(x, b);
        }

        static double FindLength(double Ax, double Bx, double Ay, double By)
        {
            double d = Pow2(Ax - Bx);
            double d2 = Pow2(Ay - By);

            return (double)Math.Sqrt(d + d2);
        }

        static void Main(string[] arg)
        {
            Console.WriteLine("Enter coordinate x of dot A:");
            string AXStr = Console.ReadLine();

            Console.WriteLine("Enter coordinate y of dot A:");
            string AYStr = Console.ReadLine();

            Console.WriteLine("Enter coordinate x of dot B:");
            string BXStr = Console.ReadLine();

            Console.WriteLine("Enter coordinate y of dot B:");
            string BYStr = Console.ReadLine();

            Console.WriteLine("Enter coordinate x of dot C:");
            string CXStr = Console.ReadLine();

            Console.WriteLine("Enter coordinate y of dot C:");
            string CYStr = Console.ReadLine();
            
            double Bx = double.Parse(BXStr);
            double Ax = double.Parse(AXStr);
            double Cy = double.Parse(CYStr);
            double Cx = double.Parse(CXStr);
            double By = double.Parse(BYStr);
            double Ay = double.Parse(AYStr);

            double AB =  FindLength( Ax,  Bx,  Ay,  By);

            Console.WriteLine($"Length of AB is: '{AB}'");

            double CA = FindLength(Ax, Cx, Ay, Cy);

            Console.WriteLine($"Length of CA is: '{CA}'");

            double CB = FindLength(Bx, Cx, By, Cy);
           
            Console.WriteLine($"Length of CB is: '{CB}'");

            Console.WriteLine("");


            if (AB == CA && CA == CB)

            {
                Console.WriteLine($"Triangle IS 'Equilateral'");
            }
            else
            {
                Console.WriteLine($"Triangle IS NOT 'Equilateral'");
            }


            if (AB == CA)
            {
                Console.WriteLine($"Triangle IS 'Isosceles'");
            }
            else if (CA == CB)
            {
                Console.WriteLine($"Triangle IS 'Isosceles'");
            }

            else if (AB == CB)
            {
                Console.WriteLine($"Triangle IS 'Isosceles'");
            }
            else
            {
                Console.WriteLine($"Triangle IS NOT 'Isosceles'");
            }

            double CB2 = Pow2(CB);
            double AB2 = Pow2(AB);
            double CA2 = Pow2(CA);
            double delta = 0.9;
            double M = AB2 - CB2 - CA2;
            double M2 = CA2 - AB2 - CB2;
            double M3 = CB2 - AB2 - CA2;

            if (M <= delta || M2 <= delta|| M3 <= delta)
            {
                Console.WriteLine($"Triangle IS 'Right'");
            }
            else
            {
                Console.WriteLine($"Triangle IS NOT 'Right'");
            }

            Console.WriteLine("");

            double P = AB + CB + CA;

            Console.WriteLine($"Perimeter : '{P}'");

            Console.WriteLine("");

            Console.WriteLine($"Parity numbers in range from 0 to triangle perimeter: ");

            int i = 0 ;
            do
            {
                Console.WriteLine(i);
                i+=2;
            }
            while (i <= P);
        }
    }
}