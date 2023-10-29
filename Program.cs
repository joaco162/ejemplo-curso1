using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Persona p1 = new Persona();
            //Console.WriteLine("Ingrese su Nombre:");
            //p1.Nombre = Console.ReadLine();
            //Console.WriteLine("Ingrese su edad:");
            //p1.Edad = int.Parse(Console.ReadLine());
            //Console.WriteLine("Ingrese su sueldo:");
            //p1.Sueldo = float.Parse(Console.ReadLine());
            //Console.WriteLine(p1.saludar());
            //Console.WriteLine("La edad de la persona es:" + p1.Edad);
            //Console.WriteLine("El sueldo mensual que recibe es de:" + p1.Sueldo);
            Botella b1 = new Botella("Roja", "Plastico");
            Console.WriteLine("Capacidad Botella:" + b1.Capacidad);



            Console.ReadKey();
        }
    }
}
