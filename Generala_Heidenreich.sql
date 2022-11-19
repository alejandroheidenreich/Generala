create database Generala
go

use Generala
go

create table Jugadores (
	id INT IDENTITY(1,1) NOT NULL,
	nombre VARCHAR(50),
);

create table Juego (
	id int IDENTITY(1,1) NOT NULL,
	idJugador int,
	puntaje int
);

create table Partida (
	id int IDENTITY(1,1) NOT NULL,
	idJuegoUno int,
	idJuegoDos int,
	idGanador int
);

create table Usuarios(
	id int IDENTITY(1,1) NOT NULL,
	usuario VARCHAR(50),
	contraseña VARCHAR(50)
);

insert into Jugadores (nombre) values ('njankiewicz0');
insert into Jugadores (nombre) values ('dkerner1');
insert into Jugadores (nombre) values ('nleyre2');
insert into Jugadores (nombre) values ('mkellog3');
insert into Jugadores (nombre) values ('fsilversmid4');
insert into Jugadores (nombre) values ('dkimm5');
insert into Jugadores (nombre) values ('eharsnipe6');
insert into Jugadores (nombre) values ('mduinbleton7');
insert into Jugadores (nombre) values ('rmcgroarty8');
insert into Jugadores (nombre) values ('hcorser9');

insert into Usuarios (usuario,contraseña) values ('admin','Admin!10');

