
//Dependencias
using System;
using System.Data.SqlClient;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using configuracion;


//Referecnias de archivos del proyecto
using funciones;
using querysprom;

namespace update
{
    public class updateDato
    {
        // Querys SqlServer del programa
        querysProm q = new querysProm();
        //
        
        funcionesProyecto a = new funcionesProyecto();
        conexionProgram conn = new conexionProgram();

        public updateDato()
        {
            using (SqlConnection connection = new SqlConnection(conn.obtenerconnL()))
            {
                connection.Open();
                Console.WriteLine("Ingrese id del Alumno a Modificar");
                int i = a.idUsuario();
                Console.WriteLine("Ingrese el nuevo nombre del Usuario");
                string? newName = a.idName();

                using (SqlCommand command = new SqlCommand(q.queryupdate(), connection))
                {
                    command.Parameters.AddWithValue("@id", i); // Valor del ID
                    command.Parameters.AddWithValue("@newName", newName); // Valor del ID
                    command.ExecuteNonQuery();
                    
                }
                connection.Close();
            }
        }
    }
}