using System;

namespace funciones
{
    public class funcionesProyecto
    {
        public int idUsuario()
        {
            // Funcion que almacena un entero
            int id;
            id = Convert.ToInt32(Console.ReadLine());
            return id;
        }
        public string? idName()
        {
            //Funcion que almacena un nombre
            string? nameU;
            nameU = Convert.ToString(Console.ReadLine());
            return nameU;
        }

        public decimal? nota()
        {
            decimal? notaU;
            notaU = Convert.ToDecimal(Console.ReadLine());
            return notaU;
        }
    }
}