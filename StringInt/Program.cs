using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace StringInt
{
    class Program
    {
        static void Main(string[] args)
        {
            string Nombre;
            int Edad;
            Console.WriteLine(" Escriba su nombre: ");
            Nombre = Console. ReadLine ();
            Console.WriteLine(" \n Ingrese su edad: ");
            Edad = int.Parse(Console.ReadLine());
            Console.WriteLine(" \n Tu Nombre es: " + Nombre + " y tienes: " + Edad + " años ");
            Console.WriteLine(" \n Presiona una tecla para finalizar ");
            Console.ReadKey();
        }
    }
}
