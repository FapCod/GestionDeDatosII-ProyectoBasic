CREATE DATABASE gestionDII --Creamos la base de datos 
use gestiondii --Usamos la base de datos
--Creamos una tabla persona con sus atributos
CREATE TABLE persona(
Idpersona int not null  IDENTITY primary key ,
Nombre varchar(40) not null,
Apellido varchar(40) not null,
Edad int not null,
Sexo char(1) not null
)
--Ingresamos una persona a la tabla persona
INSERT INTO persona("Nombre", "Apellido","Edad","Sexo")
VALUES ('Frank Antonio', 'Piñin Ato',20,'M')

--Creamos una tabla de usuarios con sus respectivos datos
create table Users(
UserID int identity(1,1) primary key,
userName varchar (100) unique not null,
passUser varchar (100) not null
)
--Insertamos un usuario a la tabla Users
insert into Users values ('admin','admin')
--Selecciones 
select * from Users
SELECT * FROM Persona;
--Eliminar datos de la tabla persona 
delete from persona
--Eliminar tabla completa Persona
drop table persona

--Procedimientos
--Creamos procedimiento que te contara todas las personas mayores de edad
create procedure seleccionPMA--Nombre Procedimiento
@edad int, --Parametros Entrada
@sexo varchar(20), --Parametros Entrada
@count int output --Parametros Salida
as
 set  @count =  (select count(idPersona) from persona where edad >=@edad and sexo = @sexo) --Contenido del procedimiento


--Creamos procedimiento que te contara todas las personas menores de edad
create procedure seleccionPME--Nombre Procedimiento
@edad int, --Parametros Entrada
@sexo varchar(20), --Parametros Entrada
@count int output --Parametros Salida
as
 set  @count =  (select count(idPersona) from persona where edad <= @edad and sexo = @sexo) --Contenido del procedimiento

--Se declara para ejecutar los procedimientos 
--Ejecutar primer procedimiento
declare @totalPMA int --Declaramos la variable
exec seleccionPMA  18, 'F',@totalPMA output --Ejecutamos el procedimiento donde F seria Femenino(Mujeres)
select @totalPMA--Mostramos el resultado

--Ejecutar Segundo procedimiento
declare @totalPME int --Declaramos la variable
exec seleccionPME  18, 'M',@totalPME output --Ejecutamos el procedimiento donde M seria Masculino(Hombres)
select @totalPME--Mostramos el resultado

