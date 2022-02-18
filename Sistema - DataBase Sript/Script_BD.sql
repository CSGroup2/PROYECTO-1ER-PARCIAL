CREATE DATABASE PYCSLosrapidos;
USE PYCSLosrapidos;



CREATE TABLE [HOSPITAL] (
  [ID_HOSPITAL] INT IDENTITY(100,1) NOT NULL,
  [NOMBRE_HOSPITAL] VARCHAR(45) NOT NULL,
  [FECHA_REGISTRO] DATETIME NOT NULL DEFAULT GETDATE(),
  [ESTADO] CHAR(1) NOT NULL DEFAULT 'A',
  CONSTRAINT [PK_HOSPITAL] PRIMARY KEY CLUSTERED (ID_HOSPITAL)
);

CREATE TABLE PERSONA(
	[ID_PERSONA] INT IDENTITY(100,1) NOT NULL,
	[CEDULA] VARCHAR(10) NOT NULL,
	[NOMBRE_1] VARCHAR(20) NOT NULL,
	[NOMBRE_2] VARCHAR(20) NOT NULL,
	[APELLIDO_1] VARCHAR(20) NOT NULL,
	[APELLIDO_2] VARCHAR(20) NOT NULL,
	[SEXO] CHAR(1) NOT NULL,
	[FECHA_NAC] DATE NOT NULL,
	[TELEFONO] VARCHAR(10) NOT NULL,
	[FECHA_REGISTRO] DATETIME NOT NULL DEFAULT GETDATE(),
	CONSTRAINT [PK_PERSONA] PRIMARY KEY CLUSTERED (ID_PERSONA)
);
ALTER TABLE PERSONA
ADD CONSTRAINT UC_PERSONA_CEDULA UNIQUE (CEDULA);

CREATE TABLE [USUARIO] (
  [ID_USUARIO] INT IDENTITY(100,1) NOT NULL,
  [USUARIO] VARCHAR(20) NOT NULL,
  [CORREO] VARCHAR(75) NOT NULL,
  [CONTRASENIA] VARCHAR(20) NOT NULL,
  [FECHA_REGISTRO] DATETIME NOT NULL DEFAULT GETDATE(),
  [ESTADO] CHAR(1) NOT NULL DEFAULT 'A',
  CONSTRAINT [PK_USUARIO] PRIMARY KEY CLUSTERED (ID_USUARIO)
);
ALTER TABLE USUARIO
ADD CONSTRAINT UC_USUARIO_NOMUSUARIO UNIQUE (USUARIO);
ALTER TABLE USUARIO
ADD CONSTRAINT UC_USUARIO_CORREO UNIQUE (CORREO);


CREATE TABLE [GERENTE] (
  [ID_GERENTE] INT IDENTITY(100,1) NOT NULL,
  [ID_PERSONA] INT NOT NULL,
  [ID_USUARIO] INT NOT NULL,
  [FECHA_REGISTRO ] DATETIME NOT NULL DEFAULT GETDATE(),
  [ESTADO] CHAR(1) NOT NULL DEFAULT 'A',
  CONSTRAINT [PK_GERENTE] PRIMARY KEY CLUSTERED (ID_GERENTE),
  Constraint [FK_G_IDPERSONA] foreign key(ID_PERSONA) references PERSONA (ID_PERSONA),
  Constraint [FK_G_IDUSUARIO] foreign key(ID_USUARIO) references USUARIO (ID_USUARIO)
);

CREATE TABLE [CLIENTE] (
  [ID_CLIENTE] INT IDENTITY(100,1) NOT NULL,
  [ID_HOSPITAL] INT NOT NULL,
  [ID_PERSONA] INT NOT NULL,
  [ID_USUARIO] INT NOT NULL,
  [FECHA_REGISTRO] DATETIME NOT NULL DEFAULT GETDATE(),
  [ESTADO] CHAR(1) NOT NULL DEFAULT 'A',
  CONSTRAINT [PK_CLIENTE] PRIMARY KEY CLUSTERED (ID_CLIENTE),
  Constraint [FK_CL_IDPERSONA] foreign key(ID_PERSONA) references PERSONA (ID_PERSONA),
  Constraint [FK_CL_IDHOSPITAL] foreign key(ID_HOSPITAL) references HOSPITAL (ID_HOSPITAL),
  Constraint [FK_CL_IDUSUARIO] foreign key(ID_USUARIO) references USUARIO (ID_USUARIO)  
);

CREATE TABLE [CONDUCTOR] (
  [ID_CONDUCTOR] INT IDENTITY(100,1) NOT NULL,
  [ID_PERSONA] INT NOT NULL,
  [FECHA_CONTRATO] DATE NOT NULL,
  [FECHA_REGISTRO] DATETIME NOT NULL DEFAULT GETDATE(),
  [ESTADO] CHAR(1) NOT NULL DEFAULT 'A',
  CONSTRAINT [PK_CONDUCTOR] PRIMARY KEY CLUSTERED (ID_CONDUCTOR),
  Constraint [FK_CON_IDPERSONA] foreign key(ID_PERSONA) references PERSONA (ID_PERSONA)
);

CREATE TABLE [FACTURA_CABECERA] (
  [ID_FACTURA_CABECERA] INT IDENTITY(100,1) NOT NULL,
  [TOTAL] DECIMAL(6,2) NOT NULL,
  [FECHA_REGISTRO] DATETIME NOT NULL DEFAULT GETDATE(),
  [ESTADO] CHAR(1) NOT NULL DEFAULT 'A',
  PRIMARY KEY ([ID_FACTURA_CABECERA])
);

CREATE TABLE [FORMA_PAGO] (
  [ID_FORMA_PAGO] INT IDENTITY(1,1) NOT NULL,
  [NOMBRE_FORMA_PAGO] INT NOT NULL,
  [FECHA_REGISTRO] DATETIME NOT NULL DEFAULT GETDATE(),
  [ESTADO] CHAR(1) NOT NULL DEFAULT 'A',
  PRIMARY KEY ([ID_FORMA_PAGO]),
);

CREATE TABLE [BANCO] (
  [ID_BANCO] INT IDENTITY(100,1) NOT NULL,
  [NOMBRE_BANCO] VARCHAR(45) NOT NULL,
  [FECHA_REGISTRO] DATETIME NOT NULL DEFAULT GETDATE(),
  [ESTADO] CHAR(1) NOT NULL DEFAULT 'A',
  PRIMARY KEY ([ID_BANCO]),
);


CREATE TABLE [PETICION] (
  [ID_PETICION] INT IDENTITY(100,1) NOT NULL,
  [ID_CLIENTE] INT NOT NULL,
  [N_AMBULANCIAS] INT NOT NULL,
  [PUNTO_ORIGEN] VARCHAR(45) NOT NULL,
  [PUNTO_DESTINO] VARCHAR(45) NOT NULL,
  [FECHA_REGISTRO] DATETIME NOT NULL DEFAULT GETDATE(),
  [ESTADO] CHAR(1) NOT NULL DEFAULT 'A',
  PRIMARY KEY ([ID_PETICION]),
  CONSTRAINT [FK_PETICION.ID_CLIENTE]
    FOREIGN KEY ([ID_CLIENTE])
      REFERENCES [CLIENTE]([ID_CLIENTE])
);

CREATE TABLE [FACTURA_DETALLE] (
  [ID_FACTURA_DETALLE] INT IDENTITY(100,1) NOT NULL,
  [ID_FACTURA_CABECERA] INT NOT NULL,
  [ID_PETICION] INT NOT NULL,
  [ID_FORMA_PAGO] INT NOT NULL,
  [ID_BANCO] INT NOT NULL,
  [VALOR_UNITARIO] DECIMAL(6,2) NOT NULL,
  [FECHA_REGISTRO] DATETIME NOT NULL DEFAULT GETDATE(),
  [ESTADO] CHAR(1) NOT NULL DEFAULT 'A',
  PRIMARY KEY ([ID_FACTURA_DETALLE]),
  CONSTRAINT [FK_FACTURA_DETALLE.ID_FACTURA_CABECERA]
    FOREIGN KEY ([ID_FACTURA_CABECERA])
	  REFERENCES [FACTURA_CABECERA]([ID_FACTURA_CABECERA]),
  CONSTRAINT [FK_FACTURA_DETALLE.ID_PETICION]
    FOREIGN KEY ([ID_PETICION])
	  REFERENCES [PETICION]([ID_PETICION]),
  CONSTRAINT [FK_FACTURA_DETALLE.ID_FORMA_PAGO]
    FOREIGN KEY ([ID_FORMA_PAGO])
      REFERENCES [FORMA_PAGO]([ID_FORMA_PAGO]),
  CONSTRAINT [FK_FACTURA_DETALLE.ID_BANCO]
    FOREIGN KEY ([ID_BANCO])
      REFERENCES [BANCO]([ID_BANCO])
);

CREATE TABLE [TIPO_AMBULANCIA] (
  [ID_TIPO_AMBULANCIA] INT IDENTITY(1,1) NOT NULL,
  [NOMBRE_TIPO_AMBULANCIA] VARCHAR(45) NOT NULL,
  [FECHA_REGISTRO] DATETIME NOT NULL DEFAULT GETDATE(),
  [ESTADO] CHAR(1) NOT NULL DEFAULT 'A',
  PRIMARY KEY ([ID_TIPO_AMBULANCIA])
);

CREATE TABLE [AMBULANCIA] (
  [ID_AMBULANCIA] INT IDENTITY(100,1) NOT NULL,
  [PLACA] VARCHAR(7) NOT NULL,
  [MODELO] VARCHAR(45) NOT NULL,
  [ID_TIPO_AMBULANCIA] INT NOT NULL,
  [CAPACIDAD] INT NOT NULL,
  [OBSERVACION] VARCHAR(45) NULL,
  [FECHA_REGISTRO] DATETIME NOT NULL DEFAULT GETDATE(),
  [ESTADO] CHAR(1) NOT NULL DEFAULT 'A',
  PRIMARY KEY ([ID_AMBULANCIA]),
  CONSTRAINT [FK_AMBULANCIA.ID_TIPO_AMBULANCIA]
    FOREIGN KEY ([ID_TIPO_AMBULANCIA])
      REFERENCES [TIPO_AMBULANCIA]([ID_TIPO_AMBULANCIA])
);

CREATE TABLE [ASIGNACION_CABECERA] (
  [ID_ASIGNACION_CABECERA] INT IDENTITY(100,1) NOT NULL,
  [ID_PETICION] INT NOT NULL,
  [ID_GERENTE] INT NOT NULL,
  [FECHA_REGISTRO] DATETIME NOT NULL DEFAULT GETDATE(),
  [ESTADO] CHAR(1) NOT NULL DEFAULT 'A',
  PRIMARY KEY ([ID_ASIGNACION_CABECERA]),
  CONSTRAINT [FK_ASIGNACION_CABECERA.ID_GERENTE]
    FOREIGN KEY ([ID_GERENTE])
      REFERENCES [GERENTE]([ID_GERENTE]),
  CONSTRAINT [FK_ASIGNACION_CABECERA.ID_PETICION]
    FOREIGN KEY ([ID_PETICION])
      REFERENCES [PETICION]([ID_PETICION])
);

CREATE TABLE [ASIGNACION_DETALLE] (
  [ID_ASIGNACION_DETALLE] INT IDENTITY(100,1) NOT NULL,
  [ID_ASIGNACION_CABECERA] INT NOT NULL,
  [ID_CONDUCTOR] INT NOT NULL,
  [ID_AMBULANCIA] INT NOT NULL,
  [FECHA_REGISTRO] DATETIME NOT NULL DEFAULT GETDATE(),
  [ESTADO] CHAR(1) NOT NULL DEFAULT 'A',
  PRIMARY KEY ([ID_ASIGNACION_DETALLE]),
  CONSTRAINT [FK_ASIGNACION_DETALLE.ID_ASIGNACION_CABECERA]
    FOREIGN KEY ([ID_ASIGNACION_CABECERA])
      REFERENCES [ASIGNACION_CABECERA]([ID_ASIGNACION_CABECERA]),
  CONSTRAINT [FK_ASIGNACION_DETALLE.ID_CONDUCTOR]
    FOREIGN KEY ([ID_CONDUCTOR])
      REFERENCES [CONDUCTOR]([ID_CONDUCTOR]),
  CONSTRAINT [FK_ASIGNACION_DETALLE.ID_AMBULANCIA]
    FOREIGN KEY ([ID_AMBULANCIA])
      REFERENCES [AMBULANCIA]([ID_AMBULANCIA])
);

CREATE TABLE [ESTADO] (
  [ID_ESTADO] INT IDENTITY(1,1) NOT NULL,
  [ESTADO] CHAR(1) NOT NULL,
  [NOMBRE_ESTADO] VARCHAR(10) NOT NULL,
  PRIMARY KEY ([ID_ESTADO])
);


INSERT INTO PERSONA (CEDULA,NOMBRE_1,NOMBRE_2,APELLIDO_1,APELLIDO_2,SEXO,FECHA_NAC,TELEFONO)
VALUES('0953581972', 'Alexander', 'Joel', 'Castro', 'Mora', 'M', GETDATE(), '0992015890'); 

INSERT INTO PERSONA (CEDULA,NOMBRE_1,NOMBRE_2,APELLIDO_1,APELLIDO_2,SEXO,FECHA_NAC,TELEFONO)
VALUES('0914201033', 'Helen', 'Lisbeth', 'Bernal', 'Veliz', 'F', GETDATE(), '0992015890'); 

INSERT INTO PERSONA (CEDULA,NOMBRE_1,NOMBRE_2,APELLIDO_1,APELLIDO_2,SEXO,FECHA_NAC,TELEFONO)
VALUES('0992015890', 'Renan', 'Oswaldo', 'Perez', 'Balladares', 'M', GETDATE(), '0992015890'); 


INSERT INTO USUARIO(USUARIO, CORREO, CONTRASENIA)
VALUES('Stefan45S','joel45alex@hotmail.es','12345');
INSERT INTO USUARIO(USUARIO, CORREO, CONTRASENIA)
VALUES('Helen45B','helenlbernalv@hotmail.com','12345');

/*INSERT INTO USUARIO(USUARIO, CORREO, CONTRASENIA)
VALUES('Renan45P','renan.opb@hotmail.com','12345');*/

INSERT INTO HOSPITAL(NOMBRE_HOSPITAL)
VALUES('HOSPITAL MONTE BELLO');


INSERT INTO GERENTE(ID_PERSONA,ID_USUARIO)
VALUES(100,100);

INSERT INTO CLIENTE(ID_PERSONA,ID_USUARIO, ID_HOSPITAL)
VALUES(101,101,100);

INSERT INTO CONDUCTOR(ID_PERSONA, FECHA_CONTRATO)
VALUES(102,GETDATE());
