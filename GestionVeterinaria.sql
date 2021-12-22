create database GestionVeterinaria

use GestionVeterinaria

select * from  [dbo].[Rol]
select * from  [dbo].[Usuario]

CREATE TABLE [dbo].[Rol](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [nvarchar](50) NULL,
	[Activo] [bit] NULL,
)

CREATE TABLE [dbo].[Usuario](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[IdRol] [int] NULL,
	[Nombre] [nvarchar](50) NULL,
	[Apellido] [nvarchar](50) NULL,
	[Correo] [nvarchar](50) NULL,
	[Telefono] [nvarchar](14) NULL,
	[Usuario] [nvarchar](50) NULL,
	[Contrasena] [nvarchar](200) NULL,
	[Activo] [bit] NULL,
)

CREATE TABLE Pacientes(
	 IdPaciente int IDENTITY(1,1) NOT NULL,
	 Nombre nvarchar(50) NULL,
	 Apellido  nvarchar(50) NULL,
	 Correo  nvarchar(50) NULL,
	 Telefono nvarchar(14) NULL,
	 Activo bit NULL,
)


--crear
--mantenimeiento
CREATE TABLE Clientes(
	 IdClientese int IDENTITY(1,1) NOT NULL,
	 Cedula nvarchar(50) NULL,
	 Nombre nvarchar(50) NULL,
	 Apellido  nvarchar(50) NULL,
	 Correo  nvarchar(50) NULL,
	 Telefono nvarchar(14) NULL,
	 Activo bit NULL,
)
CREATE TABLE Productos(
	 IdPaciente int IDENTITY(1,1) NOT NULL,
	 Descripcion  nvarchar(50) NULL,
	 Categoria  nvarchar(50) NULL,
	 Especie  nvarchar(50) NULL,
	 Suplidor nvarchar(50) NULL,
	 Activo bit NULL,
)

CREATE TABLE Consultas(
	 IdConsultase int IDENTITY(1,1) NOT NULL,
	 Cliente  nvarchar(50) NULL,
	 Cedula nvarchar(50) NULL,
	 Mascota  nvarchar(50) NULL,
	 Fecha nvarchar(50) NULL,
	 Hora nvarchar(50) NULL,
	 Activo bit NULL,
)


select *from Pacientes
select *from Clientes


INSERT Pacientes (Nombre, Apellido, Correo, Telefono,  Activo)  
	VALUES ('fido',	'fido', 'admin@correo.com',	'9999999999',1)

	CREATE TABLE Pacientes(
	 IdPaciente int IDENTITY(1,1) NOT NULL,
	 Nombre nvarchar(50) NULL,
	 Apellido  nvarchar(50) NULL,
	 Correo  nvarchar(50) NULL,
	 Telefono nvarchar(14) NULL,
	 Activo bit NULL,
)

INSERT Rol (Descripcion, Activo) VALUES ( 'Administrador',  1)
INSERT Rol (Descripcion, Activo) VALUES ( 'Supervisor',  1)
INSERT Rol (Descripcion, Activo) VALUES ( 'AgenteDeServicio',  1)

--Usuario 

INSERT Usuario (IdRol, Nombre, Apellido, Correo, Telefono, Usuario, Contrasena, Activo)  
	VALUES (1,	'Admin',	'Admin', 'admin@correo.com',	'9999999999',	'admin',	'123',	1)
INSERT Usuario (IdRol, Nombre, Apellido, Correo, Telefono, Usuario, Contrasena, Activo) 
	VALUES (1,	'Admin2',	'Admin', 'admin@correo.com',	'9999999999',	'jose',	'123',	1)
INSERT Usuario (IdRol, Nombre, Apellido, Correo, Telefono, Usuario, Contrasena, Activo) 
	VALUES (2,	'Jorge',	'Supervisor', 'Sup@correo.com',	'9999999999',	'Supervisor',	'123',	1)
INSERT Usuario (IdRol, Nombre, Apellido, Correo, Telefono, Usuario, Contrasena, Activo) 
	VALUES (3,	'Agente',	'Agente', 'Agente@correo.com',	'9999999999',	'Agente',	'123',	1)

	select * from  [dbo].[Usuario]
	


declare @Usuario nvarchar(100)='admin'
declare @Contrasena nvarchar(100)='123'
select *from Usuario where  Usuario=@Usuario and Contrasena=@Contrasena 


/*
[dbo].[Rol]
1	Administrador	1
2	Supervisor	1
3	Usuario Final	1

[dbo].[Usuario]
1	1	Administrador22	Admin	admin@admin.com	3242342	admin	123	1
2	2	usuario11	usuario1	sdasd@asdasd.com	( 12) 313-1231	usuario1	123	1
3	3	Usuario 	Finall	qwe@dasda.com	(123) 123-1231	usuariof	123	1

*/