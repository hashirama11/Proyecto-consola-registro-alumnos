
//Dependencias
using System;
using System.Data.SqlClient;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

//Referecnias de archivos del proyecto
using funciones;

namespace update
{
    public class updateDato
    {
        public string connectionString = @"Data Source=Turin\SQLEXPRESS;Initial Catalog=dato;Integrated Security=True";

        private readonly string updateQuery = "UPDATE identificacion SET name = @newName WHERE id = @id";
        funcionesProyecto a = new funcionesProyecto();

        public updateDato()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                Console.WriteLine("Ingrese id del Alumno a Modificar");
                int i = a.idUsuario();
                Console.WriteLine("Ingrese el nuevo nombre del Usuario");
                string? newName = a.idName();

                using (SqlCommand command = new SqlCommand(updateQuery, connection))
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