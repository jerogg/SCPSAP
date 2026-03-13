CREATE DATABASE SCAPT; 
CREATE TABLE RolUsuario (
    IdRol  INT IDENTITY (1,1) PRIMARY KEY,
    Descripcion VARCHAR(100) NOT NULL,

);  
CREATE TABLE UsuarioSIstema (
    IdUsuarioSistema  INT IDENTITY (1,1) PRIMARY KEY,
    NombreUsuario VARCHAR(50) NOT NULL,
    PasswordHash VARCHAR(256) NOT NULL,
     IdRol INT,
    CONSTRAINT FK_UsuarioSIstema_Rol 
        FOREIGN     KEY (IdRol) REFERENCES rol(IdRol)

);   