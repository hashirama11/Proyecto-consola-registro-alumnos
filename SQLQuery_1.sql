-- Ampliacion de la tabla identificacion con nuevos campos de datos de los alumnos
ALTER TABLE identificacion ADD apellidos VARCHAR(30) NULL, edad TINYINT NULL, direccion VARCHAR(100), email VARCHAR(60);

-- Por cuestion de conexion
USE dato;
-- Por cuestiones de modificacion
DROP TABLE materias;
DROP TABLE identificacion;

-- Creacion de tabla identificacion
CREATE TABLE identificacion (
    id INT PRIMARY KEY,
    nameAlumno VARCHAR(15),
    apellidos VARCHAR(30),
    email VARCHAR(60),
    direccion VARCHAR(60),
    telefono VARCHAR(12),
    observaciones VARCHAR(80),
    etapa VARCHAR(30)
);

-- Creacion de una nueva tabla materias
CREATE TABLE Materias (
    idmateria INT IDENTITY(1,1) PRIMARY KEY,
    IdentificacionID INT,
    Castellano DECIMAL(5, 2),
    Matematicas DECIMAL(5, 2),
    Quimica DECIMAL(5, 2),
    Fisica DECIMAL(5, 2),
    Historio DECIMAL(5, 2),
    Dibujo DECIMAL(5, 2),
    Arte DECIMAL(5, 2),
    Salud DECIMAL(5, 2),
    Ingles DECIMAL(5, 2),
    Biologia DECIMAL(5, 2),
    Computacion DECIMAL(18, 2),
    CONSTRAINT FK_Identificacion
        FOREIGN KEY (IdentificacionID)
        REFERENCES identificacion (id) 
        ON DELETE CASCADE 
        ON UPDATE CASCADE
);

-- Para mostrar datos registrados
SELECT * FROM identificacion;
SELECT * FROM Materias;

-- Seccion con query que informa sobre el numero de registros segun id de la tabla identificacion

SELECT COUNT(*) id FROM identificacion;
SELECT COUNT(*) FROM identificacion;

-- Ultimo id
SELECT IDENT_CURRENT('id') AS identificacion; --ESto queda pendiente
