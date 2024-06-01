//Dependencias
using System;
using System.Data.SqlClient;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

//Referecnias de archivos del proyecto
using funciones;

namespace delete
{
    public class deleteDato
    {
        public string connectionString = @"Data Source=Turin\SQLEXPRESS;Initial Catalog=dato;Integrated Security=True";

        private readonly string deleteQuery = "DELETE FROM identificacion WHERE id = @id";
        funcionesProyecto a = new funcionesProyecto();

        public deleteDato()
        {
            
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                Console.WriteLine("Ingrese id del alumno a Eliminar");
                int i = a.idUsuario();

                using (SqlCommand command = new SqlCommand(deleteQuery, connection))
                {
                    command.Parameters.AddWithValue("@id", i); // Valor del ID
                    command.ExecuteNonQuery();
                    
                }
                connection.Close();
            }
        }

    }
}

