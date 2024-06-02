using System;
using System.IO;
using System.Data.SqlClient;


namespace configuracion
{

    public class conexionProgram
    {
        // COnexion para Linux
        private string connectionStringL = "Server=localhost;Database=dato;User Id=sa;Password=Turinturambar11;";
        // Conexion para windows
        private string connectionStringW = @"Data Source=Turin\SQLEXPRESS;Initial Catalog=dato;Integrated Security=True";
        
        public string obtenerconnL()
        {
            return connectionStringL;
            
        }
        public string obtenerconnW()
        {
            return connectionStringW;
        }
    }
}