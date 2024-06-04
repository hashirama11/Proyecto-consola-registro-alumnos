using System;

namespace funciones
{
    public class funcionesProyecto
    {
        
        public int idUsuario()
        {
            // Funcion que almacena un entero
            Console.WriteLine("Ingrese id de usuario");
            int id;
            id = Convert.ToInt32(Console.ReadLine());
            return id;
        }
        public string? idName()
        {
            //Funcion que almacena un nombre
            Console.WriteLine("Ingrese nombre");
            string? nameU;
            nameU = Convert.ToString(Console.ReadLine());
            return nameU;
        }

        public decimal? nota()
        {
            // Almacena nombre
            Console.WriteLine("Ingrese Nota del alumno");
            decimal? notaU;
            notaU = Convert.ToDecimal(Console.ReadLine());
            return notaU;
        }

        public string? apeU()
        {
            //Funcion que almacena un apellido
            Console.WriteLine($"Ingrese apellido de ALumno");
            string? nameU;
            nameU = Convert.ToString(Console.ReadLine());
            return nameU;
        }

        public string? emailU()
        {
            //Funcion que almacena un email
            Console.WriteLine("Ingrese email de alumno");
            string? nameU;
            nameU = Convert.ToString(Console.ReadLine());
            return nameU;
        }

        public string? addresU()
        {
            //Funcion que almacena un direccion de usuario
            Console.WriteLine("Ingrese direccion de alumno");
            string? nameU;
            nameU = Convert.ToString(Console.ReadLine());
            return nameU;
        }

        public string? phoneU()
        {
            //Funcion que almacena un numero de telefono
            Console.WriteLine("Ingrese numero de telefono de alumno");
            string? nameU;
            nameU = Convert.ToString(Console.ReadLine());
            return nameU;
        }

        public string? obU()
        {
            //Funcion que almacena un observaciones del alumno
            Console.WriteLine("Ingrese observacion sobre el alumno");
            string? nameU;
            nameU = Convert.ToString(Console.ReadLine());
            return nameU;
        }
        public string? etaU()
        {
            //Funcion que almacena un etapa escolar del alumno
            Console.WriteLine("Ingrese etapa del alumno");
            string? nameU;
            nameU = Convert.ToString(Console.ReadLine());
            return nameU;
        }

    }
}