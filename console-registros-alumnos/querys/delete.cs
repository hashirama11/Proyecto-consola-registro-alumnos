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

namespace delete
{
    public class deleteDato
    {
        // Querys SqlServer del programa
        querysProm q = new querysProm();
        //
        
        funcionesProyecto a = new funcionesProyecto();
        conexionProgram conn = new conexionProgram();

        public deleteDato()
        {
            
            using (SqlConnection connection = new SqlConnection(conn.obtenerconnL()))
            {
                connection.Open();
                Console.WriteLine("Ingrese id del alumno a Eliminar");
                int i = a.idUsuario();

                using (SqlCommand command = new SqlCommand(q.querydelete(), connection))
                {
                    command.Parameters.AddWithValue("@id", i); // Valor del ID
                    command.ExecuteNonQuery();
                    
                }
                connection.Close();
            }
        }

    }
}

