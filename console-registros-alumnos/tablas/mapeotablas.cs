// Dependencias
using System;
using System.Data.SqlClient;

// Referencias

namespace mapeotablas
{
    public class tablaIdentificacion
    {
        // Mapeo de la tabla identificaion
        public int id { get; set;}
        public string? nameAlumno { get; set;}
        public string? apellidos { get; set;}
        public string? email { get; set;}
        public string? direccion { get; set;}
        public string? telefono { get; set;}
        public string? observaciones { get; set;}
        public string? etapa { get; set;}

        
    }

    public class tablaMaterias
    {
        // Mapeo de la tabla Materias
        public int idmateria { get; set;}
        public string? IdentificaionID { get; set;} 
        public decimal CAstellano { get; set;}
        public decimal Matematicas { get; set;}
        public decimal Quimica { get; set;}
        public decimal Fisica { get; set;}
        public decimal Historico { get; set;}
        public decimal Dibujo { get; set;}
        public decimal Arte { get; set;}
        public decimal Salud { get; set;}
        public decimal Ingles { get; set;}
        public decimal Biologia { get; set;}
        public decimal Computacion { get; set;}

    }
}