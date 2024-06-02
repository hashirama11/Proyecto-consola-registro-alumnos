// Dependencias
using System;

namespace querysprom
{
    public class querysProm
    {
        private readonly string insertQuery = "INSERT INTO identificacion (id, name) VALUES (@id, @name)";
        private readonly string deleteQuery = "DELETE FROM identificacion WHERE id = @id";
        private readonly string updateQuery = "UPDATE identificacion SET name = @newName WHERE id = @id";
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
    }
}