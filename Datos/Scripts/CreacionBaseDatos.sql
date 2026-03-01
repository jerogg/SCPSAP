-- crear base de datos SCPSAP
CREATE DATABASE [SCPSAP]
GO

USE SCPSAP
CREATE TABLE dbo.UsuarioSistema 
( 
     IdUsuarioSistema INT IDENTITY(1,1) NOT NULL 
    ,NombreUsuario VARCHAR(50) NOT NULL 
    ,PasswordHash VARCHAR(256) NOT NULL 
    ,IdRol INT
    ,Activo BIT 
);
GO

USE SCPSAP
CREATE TABLE dbo.UsuarioRol 
( 
     IdRol INT IDENTITY(1,1) NOT NULL 
    ,Descripcion VARCHAR(256) NOT NULL
);
GO


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