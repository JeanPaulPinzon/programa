using System;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography;
using System.Threading.Channels;


namespace Ejemplos
{
    class Program
    {
        static void Main(string[] args)
        {
            //Codigo #1

            //var datos = new[] { "Jean", "Pinzón", 15 };

            //var valores = new[] { 15, 28, 75.5, 30.30 };   //Todo a double

            //Empleados Ana = new Empleados("Ana", 27);

            //Empleados[] arrayEmpleados = new Empleados[2];

            //arrayEmpleados[0] = new Empleados("Sara", 37);

            //arrayEmpleados[1] = Ana;

            //// array de tipos o clases anónimas

            //var personas = new[]
            //{
            //    new {Nombre = "Jean Paul", Edad = 19},

            //    new {Nombre = "María", Edad = 49 },

            //    new {Nombre = "Diana", Edad = 35 }
            //};

            //Console.WriteLine(personas[0]);

            //Codigo #2

            Console.WriteLine("Por favor ingresa tu nombre completo: ");

            string nombre = Console.ReadLine();

            Console.WriteLine("Por favor ingresa tus apellidos: ");

            string apellido = Console.ReadLine();

            Console.WriteLine("Por favor ingresa tu edad: ");

            int edad = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Por favor, ingresa tu numero de documento: ");

            int documento = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Por favor, ingresa tu nombre de usuario: ");

            string nombre_usuario = Console.ReadLine();

            Console.WriteLine();

            Console.WriteLine("Tu nombre es: " + nombre);

            Console.WriteLine("Tu apellido es: " + apellido);

            Console.WriteLine("Tienes: " + edad + " años ");

            Console.WriteLine("Tu numero de documento es: " + documento);

            Console.WriteLine("Tu nombre de usuario es: " + nombre_usuario);


        }

    }

    //class Empleados
    //{
    //    public Empleados(String nombre, int edad) 
    //    {
    //        this.nombre = nombre;

    //        this.edad = edad;
    //    }

    //    String nombre; 

    //    int edad;

    //}      
}