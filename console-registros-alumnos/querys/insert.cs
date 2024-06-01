
//Dependencias
using System;
using System.Data.SqlClient;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

//Referecnias de archivos del proyecto
using funciones;

namespace insert
{
    public class insertDato
    {
        public string connectionString = @"Data Source=Turin\SQLEXPRESS;Initial Catalog=dato;Integrated Security=True";
        private readonly string insertQuery = "INSERT INTO identificacion (id, name) VALUES (@id, @name)";
        funcionesProyecto a = new funcionesProyecto();
        public  insertDato()
        {
            
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                Console.WriteLine("Ingrese el id asignado al nuevo Alumno");
                int idU = a.idUsuario();
                Console.WriteLine("Ingrese el nombre del nuevo Alumno");
                string? nameU = a.idName();

                using (SqlCommand command = new SqlCommand(insertQuery, connection))
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