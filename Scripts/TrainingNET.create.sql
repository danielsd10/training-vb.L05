/* Base de Datos */

CREATE DATABASE TrainingNET
GO

USE TrainingNET
GO

CREATE TABLE Contactos(
	id_contacto INTEGER IDENTITY(1,1) NOT NULL,
	tipo CHAR(1) NOT NULL,
	nombre VARCHAR(200) NOT NULL,
	apellido VARCHAR(100),
	ruc VARCHAR(11),
	dni VARCHAR(8),
	fecha_nacimiento DATE,
	direccion VARCHAR(200),
	fecha_registro DATETIME DEFAULT GETDATE(),
	PRIMARY KEY (id_contacto),
	CHECK (tipo IN ('P', 'E'))
)
GO

/* Tablas */

CREATE TABLE Telefonos(
	id_contacto INTEGER NOT NULL,
	id_telefono INTEGER IDENTITY(1,1) NOT NULL,
	telefono VARCHAR(40),
	PRIMARY KEY (id_contacto, id_telefono),
	FOREIGN KEY (id_contacto) REFERENCES Contactos(id_contacto)
)
GO

CREATE TABLE Correos(
	id_contacto INTEGER NOT NULL,
	id_correo INTEGER IDENTITY(1,1) NOT NULL,
	correo VARCHAR(100),
	PRIMARY KEY (id_contacto, id_correo),
	FOREIGN KEY (id_contacto) REFERENCES Contactos(id_contacto)
)
GO

/* Procedimientos */

CREATE PROCEDURE ListarPersonas (
	@Buscar	VARCHAR(100) = NULL
)
AS
BEGIN
	SELECT * FROM Contactos c
	WHERE c.tipo = 'P'
	AND (@Buscar IS NULL OR (c.nombre LIKE '%' + @Buscar + '%' OR c.apellido LIKE '%' + @Buscar + '%'))
	ORDER BY c.apellido ASC, c.nombre ASC
END
GO

CREATE PROCEDURE ListarEmpresas (
	@Buscar	VARCHAR(100) = NULL
)
AS
BEGIN
	SELECT * FROM Contactos c
	WHERE c.tipo = 'E'
	AND (@Buscar IS NULL OR c.nombre LIKE '%' + @Buscar + '%')
	ORDER BY c.nombre ASC
END
GO

CREATE PROCEDURE ListarTelefonos (
	@Id	INTEGER
)
AS
BEGIN
	SELECT t.telefono FROM Telefonos t
	WHERE t.id_contacto = @Id
END
GO

CREATE PROCEDURE ListarCorreos (
	@Id	INTEGER
)
AS
BEGIN
	SELECT c.correo FROM Correos c
	WHERE c.id_contacto = @Id
END
GO

CREATE PROCEDURE RegistrarPersona (
	@Nombre				VARCHAR(200),
	@Apellido			VARCHAR(100),
	@DNI				VARCHAR(8),
	@FechaNacimiento	DATE,
	@Direccion			VARCHAR(200),
	@Id					INTEGER OUT
) AS
BEGIN
	
	INSERT INTO Contactos (tipo, nombre, apellido, dni, fecha_nacimiento, direccion)
	VALUES ('P', @Nombre, @Apellido, @DNI, @FechaNacimiento, @Direccion)

	SELECT @Id = ISNULL(SCOPE_IDENTITY(),-1)

END
GO

CREATE PROCEDURE RegistrarEmpresa (
	@Nombre				VARCHAR(200),
	@RUC				VARCHAR(11),
	@Direccion			VARCHAR(200),
	@Id					INTEGER OUT
) AS
BEGIN
	
	INSERT INTO Contactos (tipo, nombre, ruc, direccion)
	VALUES ('E', @Nombre, @RUC, @Direccion)

	SELECT @Id = ISNULL(SCOPE_IDENTITY(),-1)

END
GO

CREATE PROCEDURE RegistrarTelefono (
	@IdContacto			INTEGER,
	@Telefono			VARCHAR(40),
	@Id					INTEGER OUT
) AS
BEGIN
	
	INSERT INTO Telefonos (id_contacto, telefono)
	VALUES (@IdContacto, @Telefono)

	SELECT @Id = ISNULL(SCOPE_IDENTITY(),-1)

END
GO

CREATE PROCEDURE RegistrarCorreo (
	@IdContacto			INTEGER,
	@Correo				VARCHAR(100),
	@Id					INTEGER OUT
) AS
BEGIN
	
	INSERT INTO Correos (id_contacto, correo)
	VALUES (@IdContacto, @Correo)

	SELECT @Id = ISNULL(SCOPE_IDENTITY(),-1)

END
GO

CREATE PROCEDURE EliminarContacto (
	@Id		INTEGER
) AS
BEGIN
	
	DELETE FROM Telefonos WHERE Telefonos.id_contacto = @Id
	DELETE FROM Correos WHERE Correos.id_contacto = @Id
	DELETE FROM Contactos WHERE Contactos.id_contacto = @Id

END
GO