--CREATE DATABASE gestionDII --Creamos la base de datos 
use gestionDII --Usamos la base de datos
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
INSERT INTO persona("Nombre", "Apellido","Edad","Sexo")
VALUES ('Maria Julieta', 'Villareal Flores',14,'F')
INSERT INTO persona("Nombre", "Apellido","Edad","Sexo")
VALUES ('Alejandra', 'Cardenas Ortiz',30,'F')

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

--Creamos funciones definidas por el usuario para contar todas las personas dependiendo del sexo ingresado
CREATE FUNCTION Cont_Sexo (
@ContSex char
) 
returns int
as
begin 
	declare @_ContSex int
	set @_ContSex = (select count (Idpersona) from persona where Sexo = @ContSex)
	return @_ContSex
END;

--Creamos funciones definidas por el usuario que promedie las edades de las personas dependiendo el sexo
Create Function prom_Edades(
@sexo char
)
returns int 
as
begin
		declare @_prom int
		set @_prom = (Select AVG(Edad) from persona where Sexo = @sexo) 
		return @_prom
end; 

--Creamos funciones definidas por el usuario que permita mostrar cual es la maxima Edad en varones o mujeres)

Create Function Max_Edad(
@Sex_Person char
)
returns int 
as
begin
	declare @_Max int
	set @_Max = (Select Max(Edad) from persona where Sexo = @Sex_Person )
	return @_Max
end;
 

--Se declara para ejecutar los procedimientos 
--Ejecutar primer procedimiento
declare @totalPMA int --Declaramos la variable
exec seleccionPMA  18, 'F',@totalPMA output --Ejecutamos el procedimiento donde F seria Femenino(Mujeres)
select @totalPMA--Mostramos el resultado

--Ejecutar Segundo procedimiento
declare @totalPME int --Declaramos la variable
exec seleccionPME  18, 'M',@totalPME output --Ejecutamos el procedimiento donde M seria Masculino(Hombres)
select @totalPME--Mostramos el resultado

--Ejecutar la funcion Cont_Sexo 
SELECT dbo.Cont_Sexo('F') As [Conteo de Sexos]

--Ejecutar la funcion Prom_Edades 
select dbo.prom_Edades('M') as [Sexo de persona]

--Ejecutar la funcion Max_Edad
 Select dbo.Max_Edad ('F') as [Maxima Edad] 
select * from persona

--TIPOS DE DATOS DEFINIDOS POR EL USUARIO
--CREACIÓN
CREATE TYPE udtCorreo FROM VARCHAR(50) NOT NULL
--Agregamos 2 atributos utilizando el tipo de dato definido por el usuario
ALTER TABLE persona
  ADD CorreoPersonal udtCorreo;

ALTER TABLE persona
  ADD CorreoInstitucional udtCorreo;

--CREACIÓN
CREATE TYPE udtFecha FROM DATE NOT NULL
--Agreagamos q atributo que utilice el tipo de dato definido por el usuario
ALTER TABLE persona
  ADD FechaNacimiento udtFecha;

  ------------------------------------------------------------------------
  ------------------------------------------------------------------------
  --------------------------ACTUALIZAR DATOS------------------------------

Update PERSONA set NOMBRE = 'Jorge Curioso', APELLIDO = 'Piñin Ato',
EDAD = 20, SEXO= 'M'
where idPersona = 'Jorge Curioso'
 
 select * from persona