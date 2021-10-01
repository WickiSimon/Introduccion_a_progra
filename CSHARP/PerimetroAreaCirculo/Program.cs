using System;

namespace PerimetroAreaCirculo
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, perimetro, area, pi;
            Console.WriteLine("Ingrese algun diametro que le guste po wn");
            x = Convert.ToDouble(Console.ReadLine());
            while(x<=0)
            {
                Console.WriteLine("Ingrese algun diametro que le guste po wn");
                x = Convert.ToDouble(Console.ReadLine());
            }

            pi = 3.14;
                
            perimetro = pi * x;
            area = (pi*x*x)/4;

            Console.Write("El perimetro es ");
            Console.WriteLine(perimetro);
            Console.Write("El area es ");
            Console.WriteLine(area);

        }   
    }
}
