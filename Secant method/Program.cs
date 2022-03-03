using System;

namespace Secant_method
{
    class Program
    {
        static void Main(string[] args)
        {
        RE:
            Console.WriteLine("Enter the value of X0 and X1");
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            double accuracy = 0.0000000000001;
            //Console.WriteLine("Enter the acurracy number");
            //double accuracy = Convert.ToDouble(Console.ReadLine());
            
            double x2;


            if (a < b && Function(a) * Function(b) < 0)
            {
               

                while (true)
                {

                    x2 = a - Function(a) * ((b-a)/(Function(b)-Function(a)));
                    Console.WriteLine("Value of X2: {0}", x2);
                    if (Math.Abs(Function(x2)) <= accuracy)
                    {
                        Console.WriteLine("Root is: {0}", x2);
                        break;
                    }

                    else
                    {

                        if (Function(x2) == 0)
                        {
                            Console.WriteLine("Root is: {0}", x2);
                            break;
                        }
                        else
                        {
                           //a = b;
                           // b = x2;

                            a = x2;
                        }
                    }

                }
            }
            else
            {
                goto RE;
            }

        }
        static double Function(double x)
        {
            return x * x * x - x - 1;
        }

    }
}
