using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp46
{
    class Program
    {
        static void Main(string[] args)
        {
            int wybor;
            double a, b, w, c;

            Console.WriteLine("Program calculates volumes. ");
            do
            {
                Console.WriteLine("For globe, press 1");
                Console.WriteLine("For cone, press 2");
                Console.WriteLine("For cylinder, press 3");   //sorry if I translated this wrong
                Console.WriteLine("For cuboid, press 4");
                Console.WriteLine("For cube, press 5");
                Console.WriteLine("To exit, press 0");
                wybor = Convert.ToInt16(Console.ReadLine());
                switch (wybor)
                {
                    case 0: break;
                    case 1:
                        Console.Write("r=");
                        a = Convert.ToDouble(Console.ReadLine());
                        w = (4/3) * Math.PI * a * a; Console.WriteLine("Volume is equal to {0}", w);
                        break;
                    case 2:
                        Console.Write("r= ");
                        a = Convert.ToDouble(Console.ReadLine());
                        Console.Write("h= ");
                        b = Convert.ToDouble(Console.ReadLine());
                        w = (1/3) * a * a * b * 2 * Math.PI; Console.WriteLine("Volume is equal to {0}", w);
                        break;
                    case 3:
                        Console.Write("r= ");
                        a = Convert.ToDouble(Console.ReadLine());
                        Console.Write("h= ");
                        b = Convert.ToDouble(Console.ReadLine());
                        w = Math.PI * a * a * b; Console.WriteLine("Volume is equal to  {0}", w);
                        break;
                    case 4: Console.Write("a= ");
                        a = Convert.ToDouble(Console.ReadLine());
                        Console.Write("b= ");
                        b = Convert.ToDouble(Console.ReadLine());
                        Console.Write("H= ");
                        c = Convert.ToDouble(Console.ReadLine());
                        w = a * b * c; Console.WriteLine("Volume is equal to  {0}", w);
                        break;
                    case 5: Console.Write("a= ");
                        a = Convert.ToDouble(Console.ReadLine());
                        w = a * a * a; Console.WriteLine("Volume is equal to {0}", w);
                        break;
                    default:
                        Console.WriteLine("You must've been mistaken.");
                        break;

                }
            } while (wybor != 0);
            //Console.ReadKey(true);
        }
    }
}
