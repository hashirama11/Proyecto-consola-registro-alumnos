
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

                using (SqlCommand command = new SqlCommand(q.queryupdate(), connection))
                {
                    command.Parameters.AddWithValue("@id", a.idUsuario()); // Valor del ID
                    command.Parameters.AddWithValue("@newName", a.idName()); // Valor del ID
                    command.Parameters.AddWithValue("@apeU", a.apeU());
                    command.Parameters.AddWithValue("@email", a.emailU());
                    command.Parameters.AddWithValue("@addres", a.addresU());
                    command.Parameters.AddWithValue("@phoneU", a.phoneU());
                    command.Parameters.AddWithValue("@obeU", a.obU());
                    command.Parameters.AddWithValue("@etaU", a.etaU());
                    command.ExecuteNonQuery();
                    
                }
                connection.Close();
            }
        }
    }
}