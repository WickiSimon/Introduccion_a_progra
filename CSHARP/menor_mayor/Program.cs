using System;

namespace menor_mayor
{
    class Program
    {
        static void Main(string[] args)
        {
            int edad;
            Console.WriteLine("Ingrese Edad:");
            edad = Convert.ToInt32(Console.ReadLine());

            if(edad >= 0 && edad <= 130)
            {
                
                if(edad >= 18)
                {
                    Console.WriteLine("Es mayor de edad");
                }
                else
                {
                    Console.WriteLine("Es menor de edad");
                }
             } 
             else
             {
                 Console.WriteLine("Error");
             }  
        }

    }
}
