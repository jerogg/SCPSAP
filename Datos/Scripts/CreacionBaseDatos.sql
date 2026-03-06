-- crear base de datos SCPSAP
CREATE DATABASE [SCPSAP]
GO

USE SCPSAP
CREATE TABLE dbo.UsuarioRol 
( 
     IdRol INT IDENTITY(1,1) NOT NULL 
    ,Descripcion VARCHAR(256) NOT NULL
);
GO

CREATE TABLE dbo.UsuarioSistema 
( 
     IdUsuarioSistema INT IDENTITY(1,1) NOT NULL 
    ,NombreUsuario VARCHAR(50) NOT NULL 
    ,PasswordHash VARCHAR(256) NOT NULL 
    ,IdRol INT
    ,Activo BIT 
);
GO

INSERT INTO dbo.UsuarioRol (Descripcion) VALUES ('Administrador')
INSERT INTO dbo.UsuarioRol (Descripcion) VALUES ('Usuario')
INSERT INTO dbo.UsuarioSistema (NombreUsuario, PasswordHash, IdRol, Activo) VALUES ('admin', '8c6976e5b5410415bde908bd4dee15dfb167a9c873fc4bb8a81f6f2ab448a918', 1, 1)
INSERT INTO dbo.UsuarioSistema (NombreUsuario, PasswordHash, IdRol, Activo) VALUES ('user', '04f8996da763b7a969b1028ee3007569eaf3a635486ddab211d512c85b9df8fb', 2, 1)


--USE master
--GO
----Crear login SCPSAP
--create login SCPSAPLogin with password='SCPSAP'
--GO

--USE SCPSAP
--GO
----Crear un nombre de usuario SCPSAP
--create user SCPSAPUser for login SCPSAPLogin
--GO

----Asignar para ver, agregar, modificar
--USE SCPSAP
--GO
--GRANT CONTROL ON DATABASE::SCPSAP TO SCPSAPUser;
--GO