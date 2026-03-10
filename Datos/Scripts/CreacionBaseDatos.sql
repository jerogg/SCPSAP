-- crear base de datos SCPSAP
CREATE DATABASE [SCPSAP]
GO

USE SCPSAP
IF OBJECT_ID('dbo.UsuarioRol','U') IS NULL
BEGIN
CREATE TABLE dbo.UsuarioRol 
( 
     IdRol INT IDENTITY(1,1) NOT NULL PRIMARY KEY
    ,Descripcion VARCHAR(256) NOT NULL
);
INSERT INTO dbo.UsuarioRol (Descripcion) VALUES ('Administrador')
INSERT INTO dbo.UsuarioRol (Descripcion) VALUES ('Usuario')
END
GO

IF OBJECT_ID('dbo.UsuarioSistema','U') IS NULL
BEGIN
CREATE TABLE dbo.UsuarioSistema 
( 
     IdUsuarioSistema INT IDENTITY(1,1) NOT NULL PRIMARY KEY
    ,NombreUsuario VARCHAR(50) NOT NULL 
    ,PasswordHash VARCHAR(256) NOT NULL 
    ,IdRol INT
    ,Activo BIT
    ,CONSTRAINT FK_UsuarioSistema_Rol FOREIGN KEY (IdRol) REFERENCES dbo.UsuarioRol(IdRol)
);
INSERT INTO dbo.UsuarioSistema (NombreUsuario, PasswordHash, IdRol, Activo) VALUES ('admin', '8c6976e5b5410415bde908bd4dee15dfb167a9c873fc4bb8a81f6f2ab448a918', 1, 1)
INSERT INTO dbo.UsuarioSistema (NombreUsuario, PasswordHash, IdRol, Activo) VALUES ('user', '04f8996da763b7a969b1028ee3007569eaf3a635486ddab211d512c85b9df8fb', 2, 1)
END
GO

-- Crear tablas de referencia si no existen: Estado, Tarifa
IF OBJECT_ID('dbo.Estado','U') IS NULL
BEGIN
    CREATE TABLE dbo.Estado
    (
        IdEstado INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
        Descripcion VARCHAR(50) NOT NULL,
    );
    INSERT INTO dbo.Estado (Descripcion) VALUES ('Activo'), ('Suspendido'), ('Baja');
END
GO

IF OBJECT_ID('dbo.Tarifa','U') IS NULL
BEGIN
    CREATE TABLE dbo.Tarifa
    (
        IdTarifa INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
        NombreTarifa VARCHAR(150) NOT NULL,
        MontoMensual DECIMAL(18,2) NOT NULL DEFAULT (0.00)
    );
    INSERT INTO dbo.Tarifa (NombreTarifa, MontoMensual) VALUES ('Tarifa General', 80.00);
END
GO


IF OBJECT_ID('dbo.Contribuyente','U') IS NULL
BEGIN
    CREATE TABLE dbo.Contribuyente
(
    IdContribuyente INT NOT NULL PRIMARY KEY, -- Identificador único
    Nombre VARCHAR(150) NOT NULL,                           -- Nombre completo
    Direccion VARCHAR(200) NULL,                            -- Dirección
    Telefono VARCHAR(20) NULL,                              -- Teléfono
    FechaAlta DATETIME NOT NULL DEFAULT (GETDATE()),        -- Fecha de registro
    IdEstado INT NOT NULL,                                  -- FK a Estado (Activo/Suspendido/Baja)
    IdTarifa INT NULL,                                      -- FK a Tarifa asignada
    Email VARCHAR(200) NULL,                                -- Correo electrónico para notificaciones
    FechaUltimoAviso DATETIME NULL,                         -- Fecha del último aviso enviado
    FechaLimitePago DATETIME NULL,                          -- Fecha máxima antes de suspensión
    DiasGracia INT NULL,                                    -- Días permitidos antes de aplicar corte
    CONSTRAINT FK_Contribuyente_Estado FOREIGN KEY (IdEstado) REFERENCES dbo.Estado(IdEstado),
    CONSTRAINT FK_Contribuyente_Tarifa FOREIGN KEY (IdTarifa) REFERENCES dbo.Tarifa(IdTarifa)
);
END
GO