// Dependencias
using System;
using mapeotablas;


// Referecnias
using select;

namespace funciones
{
    public class funcionesProyecto
    {
        // Muestra de los registros ingresados en la tabla identificacion
        public void muestraIden()
        {
            selectDAto sele = new selectDAto();
            List<tablaIdentificacion> selelist = sele.selectregistro();

            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine($"{selelist[i].nameAlumno}\t{selelist[i].apellidos}\t{selelist[i].email}\t{selelist[i].direccion}\t{selelist[i].telefono}\t{selelist[i].observaciones}\t{selelist[i].etapa}");
            }


        }
        // Muestra de los registros de la tabla sqlserver. Para asi saber cuantas filas van registradas
        public void conteoRegistros()
        {
            selectDAto numid = new selectDAto();
            int n = numid.selectid();
            Console.WriteLine($"Registros actuales de la base de datos identificacion {n}");
        }
        
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