// Dependecias

using System;
using System.Data.SqlClient;

// Referencias
using funciones;
using querysprom;
using configuracion;
using System.Data;
using mapeotablas;

namespace select 
{
    public class selectDAto
    {
        // Objeto de consultas Sqlserver
        querysProm q = new querysProm();
        funcionesProyecto a = new funcionesProyecto();
        // Objeto de conexion con SqlSErver
        conexionProgram conn = new conexionProgram();
        public int selectid()
        {
            using (SqlConnection connection = new SqlConnection(conn.obtenerconnL()))
            {
                int count = 0;
                connection.Open();
                
                using (SqlCommand command = new SqlCommand(q.conteoTabla(), connection))
                {
                    count = (int)command.ExecuteScalar();
                    return count;
                 
                }
                
            }
        }

        public  List<tablaIdentificacion> selectregistro()
        {
            List<tablaIdentificacion> tabla = new List<tablaIdentificacion>();

            using(SqlConnection connection = new SqlConnection(conn.obtenerconnL()))
            {
                connection.Open();
                
                using(SqlCommand command = new SqlCommand(q.selectfrom(),connection))
                {
                    SqlDataReader reader = command.ExecuteReader();
                    
                    // Primero instanciando el mapeo de la clase tablaIdentificacion
                    // tablaIdentificacion tablaid = new tablaIdentificacion();
                    

                    while (reader.Read())
                    {
                        tablaIdentificacion tablaA = new tablaIdentificacion
                        {
                            id = Convert.ToInt32(reader["id"]),
                            nameAlumno = reader["nameAlumno"].ToString(),
                            email = reader["email"].ToString(),
                            direccion = reader["direccion"].ToString(),
                            telefono = reader["telefono"].ToString(),
                            observaciones = reader["observaciones"].ToString(),
                            etapa = reader["etapa"].ToString()
                            
                        };

                        tabla.Add(tablaA);

                        // Procesa los datos leídos
                        // (por ejemplo, muestra en la consola).
                    }
                }
                connection.Close();
                
            }
            return tabla; // Devolucion de la lista
        }


    }
}