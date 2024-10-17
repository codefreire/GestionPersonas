--Crear base de datos
create database PersonasDB;

--Crear tabla Personas
create table Personas(
	Cedula varchar(10) primary key,
	Nombre varchar(20) not null,
	Apellido varchar(20) not null,
	Edad int not null,
	Email varchar(50) check(Email like '%@%') not null
);