CREATE DATABASE vacunasBD;

USE vacunasBD;


CREATE TABLE paciente (
    id_paciente INT IDENTITY(1,1) PRIMARY KEY,
    nombre VARCHAR(100) NOT NULL,
    dni VARCHAR(20) DEFAULT NULL,
    fecha_nacimiento DATE NOT NULL
);


CREATE TABLE vacuna (
    id_vacuna INT IDENTITY(1,1) PRIMARY KEY,
    nombre_vacuna VARCHAR(100) NOT NULL,
    tipo VARCHAR(50) NOT NULL,
    fecha_aplicacion DATE NOT NULL,
    dosis VARCHAR(50) NOT NULL,
    id_paciente INT,
    FOREIGN KEY (id_paciente) REFERENCES paciente(id_paciente)
);

GO

CREATE PROCEDURE InsertarPaciente
    @nombre VARCHAR(100),
    @dni VARCHAR(20),
    @fecha_nacimiento DATE
AS
BEGIN
    INSERT INTO paciente (nombre, dni, fecha_nacimiento)
    VALUES (@nombre, @dni, @fecha_nacimiento);
END;
GO

CREATE PROCEDURE InsertarVacuna
    @nombre_vacuna VARCHAR(100),
    @tipo VARCHAR(50),
    @fecha_aplicacion DATE,
    @dosis VARCHAR(50),
    @id_paciente INT
AS
BEGIN
    INSERT INTO vacuna (nombre_vacuna, tipo, fecha_aplicacion, dosis, id_paciente)
    VALUES (@nombre_vacuna, @tipo, @fecha_aplicacion, @dosis, @id_paciente);
END;
GO

CREATE PROCEDURE ActualizarPaciente
    @id_paciente INT,
    @nuevo_nombre VARCHAR(100),
    @nuevo_dni VARCHAR(20),
    @nuevo_fecha_nacimiento DATE
AS
BEGIN
    UPDATE paciente
    SET nombre = @nuevo_nombre,
        dni = @nuevo_dni,
        fecha_nacimiento = @nuevo_fecha_nacimiento
    WHERE id_paciente = @id_paciente;
END;
GO

CREATE PROCEDURE ActualizarVacuna
    @id_vacuna INT,
    @nuevo_nombre_vacuna VARCHAR(100),
    @nuevo_tipo VARCHAR(50),
    @nuevo_fecha DATE,
    @nuevo_dosis VARCHAR(50),
    @nuevo_id_paciente INT
AS
BEGIN
    UPDATE vacuna
    SET nombre_vacuna = @nuevo_nombre_vacuna,
        tipo = @nuevo_tipo,
        fecha_aplicacion = @nuevo_fecha,
        dosis = @nuevo_dosis,
        id_paciente = @nuevo_id_paciente
    WHERE id_vacuna = @id_vacuna;
END;
GO

CREATE PROCEDURE EliminarPaciente
    @id_paciente INT
AS
BEGIN
    DELETE FROM paciente WHERE id_paciente = @id_paciente;
END;
GO

CREATE PROCEDURE EliminarVacuna
    @id_vacuna INT
AS
BEGIN
    DELETE FROM vacuna WHERE id_vacuna = @id_vacuna;
END;
GO

CREATE PROCEDURE ObtenerTodasVacunas
AS
BEGIN
    SELECT v.id_vacuna, v.nombre_vacuna, v.tipo, v.fecha_aplicacion, v.dosis, p.nombre AS paciente
    FROM vacuna v
    JOIN paciente p ON v.id_paciente = p.id_paciente;
END;
GO

CREATE PROCEDURE ObtenerVacunasPorPaciente
    @id_paciente INT
AS
BEGIN
    SELECT v.id_vacuna, v.nombre_vacuna, v.tipo, v.fecha_aplicacion, v.dosis
    FROM vacuna v
    WHERE v.id_paciente = @id_paciente;
END;
GO

CREATE PROCEDURE ObtenerVacunasPorTipo
    @tipo VARCHAR(50)
AS
BEGIN
    SELECT v.id_vacuna, v.nombre_vacuna, v.tipo, v.fecha_aplicacion, v.dosis, p.nombre AS paciente
    FROM vacuna v
    JOIN paciente p ON v.id_paciente = p.id_paciente
    WHERE v.tipo = @tipo;
END;
GO
