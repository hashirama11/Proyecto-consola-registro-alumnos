
//Dependencias
using System;
using System.Data.SqlClient;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

//Referecnias de archivos del proyecto
using funciones;
using configuracion;
using querysprom;

namespace insert
{
    public class insertDato
    {
        // Querys SqlServer del programa
        querysProm q = new querysProm();
        //
        funcionesProyecto a = new funcionesProyecto();
        conexionProgram conn = new conexionProgram();
        public  insertDato()
        {
            
            using (SqlConnection connection = new SqlConnection(conn.obtenerconnL()))
            {
                connection.Open();
                Console.WriteLine("Ingrese el id asignado al nuevo Alumno");
                int idU = a.idUsuario();
                Console.WriteLine("Ingrese el nombre del nuevo Alumno");
                string? nameU = a.idName();

                using (SqlCommand command = new SqlCommand(q.queryinsert(), connection))
                {
                    command.Parameters.AddWithValue("@id", idU); // Valor del ID
                    command.Parameters.AddWithValue("@name", nameU); // Valor del nombre
                    command.ExecuteNonQuery();
                    
                }
                connection.Close();
            }
        }

    }


}