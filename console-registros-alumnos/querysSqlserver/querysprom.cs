// Dependencias
using System;

namespace querysprom
{
    public class querysProm
    {
        // CRUD de la tabla "identificacion" de la base de datos "dato"
        private readonly string insertQuery = "INSERT INTO identificacion (id, nameAlumno) VALUES (@id, @name)";
        private readonly string deleteQuery = "DELETE FROM identificacion WHERE id = @id";
        private readonly string updateQuery = "UPDATE identificacion SET nameAlumno = @newName WHERE id = @id";

        // CRUD de la tabla "Materias" de la base de datos "dato"
        private readonly string insertidmaterias = @"INSERT INTO Materias 
        (IdentificacionID,Castellano,Matematicas,Quimica,Fisica,Historio,Dibujo,Arte,Salud,Ingles,Biologia,Computacion) 
        VALUES (@identificacionID,@castellano,@matematicas,@quimica,@fisica,@historio,@dibujo,@arte,@salud,@ingles,@biologia,@computacion)";
        private readonly string deleteQuerymaterias = "DELETE FROM Materias WHERE id = @id";
        private readonly string updateQuerymaterias = @"UPDATE Materias SET Identificacion = @identificacion,
        Castellano = @castellano, Matematicas = @matematicas, Quimica = @quimica, Fisica = @fisica, Historico = @historico,
        Dibujo = @dibujo, Arte = @arte, Salud = @salud, Ingles = @ingles, Biologia = @biologia, Computacion = @computacion WHERE idmateria = @id";

        
        // Metodos
        public string? queryinsert()
        {
            return insertQuery;
        }
        public string? querydelete()
        {
            return deleteQuery;
        }
        public string? queryupdate()
        {
            return updateQuery;
        }

        public string? queryinsertmaterias()
        {
            return insertidmaterias;
        }

        public string? querydeletematerias()
        {
            return deleteQuerymaterias;
        }

        public string? updatequerymaterias()
        {
            return updateQuerymaterias;
        }

    }
}