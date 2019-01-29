CREATE DATABASE RegistroWebDb
--DROP DATABASE  RegistroWebDb
go
Use RegistroWebDb
go
Create Table Usuarios
(
	UsuarioId int primary key identity(1,1),
	Nombre varchar(30),
	NombreUsuario varchar(20),
	Correo varchar(30),
	Clave varchar(10),
	ComprobarClave varchar(10),
	Telefono varchar(15),
	Celular varchar(15),
	Fecha DateTime,
	TipoUsuario varchar(15),
);

insert into Usuarios values('Adrian Gonzalez','Gonzalez','Adrian129407@gmail.com','1234''1234','8095877026','8097610832','28-01-2019','Admin')

select * from Usuarios;
