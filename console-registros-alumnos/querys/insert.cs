
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
using Microsoft.SqlServer.Server;

namespace insert
{
    public class insertDato
    {
        // Querys SqlServer del programa
        querysProm q = new querysProm();
        //
        funcionesProyecto a = new funcionesProyecto();
        conexionProgram conn = new conexionProgram();

        // Metodo para la table identificacion
        public  void insertDatoidentificacion()
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

        // Metodo para la tabla "Materias"
        public  void insertDatomaterias()
        {
            
            using (SqlConnection connection = new SqlConnection(conn.obtenerconnL()))
            {
                connection.Open();
                Console.WriteLine("Ingrese el id del Alumno al cual se a de ingresar calificaciones");
                int[] idU = new int[2];
                decimal?[] notaG = new decimal?[11];
                string[] campos = new string[13]{"Id materia","Id identificacion","Castellano","Matematicas","Quimica","Fisica","Historia","Dibujo","Arte","Salud","Ingles","Biologia","Computacion",};
                             
                
                idU[0] = idU[1] = a.idUsuario();
                
                
                Console.WriteLine("Ingrese la nota de cada materia respectiva");
                for(int i = 0; i < notaG.Length;i++)
                {
                    Console.WriteLine($"{campos[i]}");
                    notaG[i] = a.nota();

                }
                

                using (SqlCommand command = new SqlCommand(q.queryinsertmaterias(), connection))
                {
                    command.Parameters.AddWithValue("@idmateria", idU[0]); // Valor del ID
                    command.Parameters.AddWithValue("@identificacionID", idU[1]); // Valor del nombre
                    command.Parameters.AddWithValue("@castellano", notaG[0]);
                    command.Parameters.AddWithValue("@matematicas", notaG[1]);
                    command.Parameters.AddWithValue("@quimica", notaG[2]);
                    command.Parameters.AddWithValue("@fisica", notaG[3]);
                    command.Parameters.AddWithValue("@historio", notaG[4]);
                    command.Parameters.AddWithValue("@dibujo", notaG[5]);
                    command.Parameters.AddWithValue("@arte", notaG[6]);
                    command.Parameters.AddWithValue("@salud", notaG[7]);
                    command.Parameters.AddWithValue("@ingles", notaG[8]);
                    command.Parameters.AddWithValue("@biologia", notaG[9]);
                    command.Parameters.AddWithValue("@computacion", notaG[10]);
                    command.ExecuteNonQuery();
                    
                }
                connection.Close();
            }
        }

    }


}