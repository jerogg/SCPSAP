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

-- Tabla para calles (almacena el nombre de la calle por separado)
IF OBJECT_ID('dbo.Calle','U') IS NULL
BEGIN
    CREATE TABLE dbo.Calle
    (
        IdCalle INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
        Nombre VARCHAR(200) NOT NULL
    );
END
GO

----Insertar calles en la tabla Calle
INSERT INTO Calle (Nombre) VALUES ( 'Avenida del Norte' ); 
INSERT INTO Calle (Nombre) VALUES ( 'Calle Luis Donaldo Colosio' ); 
INSERT INTO Calle (Nombre) VALUES ( 'Calle Norte 2' ); 
INSERT INTO Calle (Nombre) VALUES ( 'Calle Oriente 2' ); 
INSERT INTO Calle (Nombre) VALUES ( 'Calle Oriente 1' ); 
INSERT INTO Calle (Nombre) VALUES ( 'Calle Oriente 4' ); 
INSERT INTO Calle (Nombre) VALUES ( 'Calle Oriente 5' ); 
INSERT INTO Calle (Nombre) VALUES ( 'Calle Oriente 6' ); 
INSERT INTO Calle (Nombre) VALUES ( 'Calle Poniente 3' ); 
INSERT INTO Calle (Nombre) VALUES ( 'Calle Poniente 4' ); 
INSERT INTO Calle (Nombre) VALUES ( 'Calle Poniente 5' ); 
INSERT INTO Calle (Nombre) VALUES ( 'Cerrada Avenida del Norte' ); 
INSERT INTO Calle (Nombre) VALUES ( 'Cerrada Poniente' ); 
INSERT INTO Calle (Nombre) VALUES ( 'Privada Oriente 3' ); 
INSERT INTO Calle (Nombre) VALUES ( 'Privada Oriente 4' ); 
INSERT INTO Calle (Nombre) VALUES ( 'Privada Poniene Norte' ); 
INSERT INTO Calle (Nombre) VALUES ( 'Privada Poniente 1' ); 
INSERT INTO Calle (Nombre) VALUES ( 'Privada Poniente 2' ); 
INSERT INTO Calle (Nombre) VALUES ( 'Privada Quetzalcóatl' ); 
INSERT INTO Calle (Nombre) VALUES ( 'Privada Tollan' ); 


-- Si la tabla Contribuyente no existe, créala con la nueva estructura (IdCalle + Numero)
IF OBJECT_ID('dbo.Contribuyente','U') IS NULL
BEGIN
    CREATE TABLE dbo.Contribuyente
    (
        IdContribuyente INT NOT NULL PRIMARY KEY, -- Identificador único (mantener esquema existente)
        Nombre VARCHAR(150) NOT NULL,              -- Nombre completo
        IdCalle INT NOT NULL,                      -- FK a dbo.Calle
        Numero VARCHAR(50) NOT NULL,               -- Número / referencia (antes Direccion)
        Telefono VARCHAR(20) NULL,                 -- Teléfono
        FechaAlta DATETIME NOT NULL DEFAULT (GETDATE()),
        IdEstado INT NOT NULL,
        IdTarifa INT NOT NULL,
        Email VARCHAR(200) NULL,
        FechaUltimoAviso DATETIME NULL,
        FechaLimitePago DATETIME NULL,
        DiasGracia INT NOT NULL,
        CONSTRAINT FK_Contribuyente_Estado FOREIGN KEY (IdEstado) REFERENCES dbo.Estado(IdEstado),
        CONSTRAINT FK_Contribuyente_Tarifa FOREIGN KEY (IdTarifa) REFERENCES dbo.Tarifa(IdTarifa),
        CONSTRAINT FK_Contribuyente_Calle FOREIGN KEY (IdCalle) REFERENCES dbo.Calle(IdCalle)
    );
END
GO

IF OBJECT_ID(N'dbo.Adeudo', N'U') IS NULL
BEGIN
    CREATE TABLE dbo.Adeudo
    (
        IdAdeudo INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
        Periodo VARCHAR(20) NOT NULL,
        Concepto VARCHAR(100) NULL,
        EsMontoDiferente BIT NOT NULL DEFAULT 0,
        Monto DECIMAL(10,2) NOT NULL CONSTRAINT DF_Adeudo_Monto DEFAULT (0.00),
        FechaGeneracion DATETIME NOT NULL CONSTRAINT DF_Adeudo_FechaGeneracion DEFAULT (GETDATE()),
        FechaVencimiento DATETIME NOT NULL CONSTRAINT DF_Adeudo_FechaVencimiento DEFAULT (GETDATE())
    );
END;

-- Script para crear la tabla Adeudo
IF OBJECT_ID(N'dbo.AdeudoContribuyente', N'U') IS NULL
BEGIN
    CREATE TABLE dbo.AdeudoContribuyente
    (
        IdAdeudoContribuyente INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
        IdContribuyente INT NOT NULL,
        IdAdeudo INT NOT NULL,
        Periodo VARCHAR(20) NOT NULL,
        Concepto VARCHAR(100) NULL,
        MontoOriginal DECIMAL(10,2) NOT NULL CONSTRAINT DF_AdeudoContribuyente_MontoOriginal DEFAULT (0.00),
        Recargo DECIMAL(10,2) NOT NULL CONSTRAINT DF_AdeudoContribuyente_Recargo DEFAULT (0.00),
        OtrosCargos DECIMAL(10,2) NOT NULL CONSTRAINT DF_AdeudoContribuyente_OtrosCargos DEFAULT (0.00),
        -- Total calculado para evitar desincronías; si prefieres almacenarlo, cámbialo a columna normal.
        TotalAdeudo AS (CONVERT(DECIMAL(10,2), ISNULL(MontoOriginal,0) + ISNULL(Recargo,0) + ISNULL(OtrosCargos,0))) PERSISTED,
        Estado VARCHAR(20) NOT NULL CONSTRAINT DF_AdeudoContribuyente_Estado DEFAULT ('Pendiente'),
        FechaGeneracion DATETIME NOT NULL CONSTRAINT DF_AdeudoContribuyente_FechaGeneracion DEFAULT (GETDATE()),
        FechaVencimiento DATETIME NULL,
        CONSTRAINT FK_AdeudoContribuyente_Contribuyente FOREIGN KEY (IdContribuyente) REFERENCES dbo.Contribuyente (IdContribuyente),
        CONSTRAINT FK_Adeudo_AdeudoContribuyente FOREIGN KEY (IdAdeudo) REFERENCES dbo.Adeudo (IdAdeudo)
    );

    CREATE INDEX IX_AdeudoContribuyente_IdContribuyente ON dbo.AdeudoContribuyente (IdContribuyente);
    CREATE INDEX IX_AdeudoContribuyente_FechaVencimiento ON dbo.AdeudoContribuyente (FechaVencimiento);

    ALTER TABLE dbo.AdeudoContribuyente
        ADD CONSTRAINT CK_AdeudoContribuyente_Estado CHECK (Estado IN ('Pendiente','Pagado','Vencido'));
END;



-- Crea tablas Pago y DetallePago con claves foráneas, índices y defaults.
IF OBJECT_ID(N'dbo.Pago', N'U') IS NULL
BEGIN
    CREATE TABLE dbo.Pago
    (
        IdPago INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
        IdContribuyente INT NOT NULL,
        FechaPago DATETIME NOT NULL CONSTRAINT DF_Pago_FechaPago DEFAULT (GETDATE()),
        TotalPagado DECIMAL(18,2) NOT NULL CONSTRAINT DF_Pago_TotalPagado DEFAULT (0.00),
        MetodoPago VARCHAR(50) NULL,
        PagaCon DECIMAL(18,2) NOT NULL DEFAULT (0.00),
        Cambio DECIMAL(18,2) NOT NULL DEFAULT (0.00),
        IdUsuarioSistema INT NOT NULL,
        CONSTRAINT FK_Pago_Contribuyente FOREIGN KEY (IdContribuyente) REFERENCES dbo.Contribuyente (IdContribuyente),
        CONSTRAINT FK_Pago_UsuarioSistema FOREIGN KEY (IdUsuarioSistema) REFERENCES dbo.UsuarioSistema (IdUsuarioSistema),
        CONSTRAINT CK_Pago_MetodoPago CHECK (MetodoPago IS NULL OR MetodoPago IN ('Efectivo','Transferencia','Tarjeta'))
    );

    CREATE INDEX IX_Pago_IdContribuyente ON dbo.Pago (IdContribuyente);
    CREATE INDEX IX_Pago_FechaPago ON dbo.Pago (FechaPago);
END

IF OBJECT_ID(N'dbo.DetallePago', N'U') IS NULL
BEGIN
    CREATE TABLE dbo.DetallePago
    (
        IdDetallePago INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
        IdPago INT NOT NULL,
        IdAdeudoContribuyente INT NOT NULL,
        MontoAplicado DECIMAL(10,2) NOT NULL CONSTRAINT DF_DetallePago_MontoAplicado DEFAULT (0.00),
        CONSTRAINT FK_DetallePago_Pago FOREIGN KEY (IdPago) REFERENCES dbo.Pago (IdPago),
        CONSTRAINT FK_DetallePago_AdeudoContribuyente FOREIGN KEY (IdAdeudoContribuyente) REFERENCES dbo.AdeudoContribuyente (IdAdeudoContribuyente)
    );

    CREATE INDEX IX_DetallePago_IdPago ON dbo.DetallePago (IdPago);
    CREATE INDEX IX_DetallePago_IdAdeudoContribuyente ON dbo.DetallePago (IdAdeudoContribuyente);
END

IF OBJECT_ID(N'dbo.Material', N'U') IS NULL
BEGIN
    CREATE TABLE dbo.Material
    (
        IdMaterial INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
        Nombre VARCHAR(150) NOT NULL,
        UnidadMedida VARCHAR(50) NOT NULL,
        StockActual INT NOT NULL CONSTRAINT DF_Material_StockActual DEFAULT (0),
        StockMinimo INT NOT NULL CONSTRAINT DF_Material_StockMinimo DEFAULT (0),
        Activo BIT NOT NULL CONSTRAINT DF_Material_Activo DEFAULT (1)
    );

    CREATE INDEX IX_Material_Nombre ON dbo.Material (Nombre);
END
GO


IF OBJECT_ID(N'dbo.MovimientoInventario', N'U') IS NULL
BEGIN
    CREATE TABLE dbo.MovimientoInventario
    (
        IdMovimiento INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
        IdMaterial INT NOT NULL,
        TipoMovimiento VARCHAR(50) NOT NULL,
        Observaciones VARCHAR(50) NOT NULL,
        Cantidad INT NOT NULL,
        FechaMovimiento DATETIME NOT NULL CONSTRAINT DF_MovimientoInventario_FechaMovimiento DEFAULT (GETDATE()),
        IdUsuarioSistema INT NOT NULL,
        CONSTRAINT FK_MovimientoInventario_Material FOREIGN KEY (IdMaterial) REFERENCES dbo.Material (IdMaterial),
        CONSTRAINT FK_MovimientoInventario_UsuarioSistema FOREIGN KEY (IdUsuarioSistema) REFERENCES dbo.UsuarioSistema (IdUsuarioSistema)
    );

    CREATE INDEX IX_MovimientoInventario_IdMaterial ON dbo.MovimientoInventario (IdMaterial);
    CREATE INDEX IX_MovimientoInventario_FechaMovimiento ON dbo.MovimientoInventario (FechaMovimiento);
END
GO

IF OBJECT_ID(N'dbo.Egreso', N'U') IS NULL
BEGIN
    CREATE TABLE dbo.Egreso
    (
        IdEgreso INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
        Concepto VARCHAR(150) NOT NULL,
        Descripcion VARCHAR(250) NOT NULL,
        Monto DECIMAL(10,2) NOT NULL DEFAULT (0.00),
        FechaMovimiento DATETIME NOT NULL CONSTRAINT DF_Egreso_FechaMovimiento DEFAULT (GETDATE()),
        IdUsuarioSistema INT NOT NULL,
        CONSTRAINT FK_Egreso_UsuarioSistema FOREIGN KEY (IdUsuarioSistema) REFERENCES dbo.UsuarioSistema (IdUsuarioSistema)
    );
    CREATE INDEX IX_Egreso_FechaMovimiento ON dbo.Egreso (FechaMovimiento);
END
GO