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
----hombres
INSERT INTO persona("Nombre", "Apellido","Edad","Sexo")
VALUES ('Frank Antonio', 'Piñin Ato',13,'M')
INSERT INTO persona("Nombre", "Apellido","Edad","Sexo")
VALUES ('Mario Julieto', 'Villareal Flores',14,'M')
INSERT INTO persona("Nombre", "Apellido","Edad","Sexo")
VALUES ('Alejandro', 'Cardenas Ortiz',12,'M')
INSERT INTO persona("Nombre", "Apellido","Edad","Sexo")
VALUES ('Frank Antonio', 'Piñin Ato',11,'M')
INSERT INTO persona("Nombre", "Apellido","Edad","Sexo")
VALUES ('Jose Julieta', 'Villareal Flores',14,'M')
INSERT INTO persona("Nombre", "Apellido","Edad","Sexo")
VALUES ('Alejandrin', 'Cardenas Ortiz',17,'M')
-----mujeres
INSERT INTO persona("Nombre", "Apellido","Edad","Sexo")
VALUES ('Lucia', 'Piñin Ato',13,'F')
INSERT INTO persona("Nombre", "Apellido","Edad","Sexo")
VALUES ('Maria Mercedez Julieto', 'Villareal Flores',14,'F')
INSERT INTO persona("Nombre", "Apellido","Edad","Sexo")
VALUES ('Sofia', 'Cardenas Ortiz',12,'F')
INSERT INTO persona("Nombre", "Apellido","Edad","Sexo")
VALUES ('Carmen', 'Piñin Ato',11,'F')
INSERT INTO persona("Nombre", "Apellido","Edad","Sexo")
VALUES ('Marianella', 'Villareal Flores',14,'F')
INSERT INTO persona("Nombre", "Apellido","Edad","Sexo")
VALUES ('Anabel', 'Cardenas Ortiz',17,'F')
----hombres
INSERT INTO persona("Nombre", "Apellido","Edad","Sexo")
VALUES ('Frank Antonio', 'Piñin Ato',21,'M')
INSERT INTO persona("Nombre", "Apellido","Edad","Sexo")
VALUES ('Mario Julieto', 'Villareal Flores',32,'M')
INSERT INTO persona("Nombre", "Apellido","Edad","Sexo")
VALUES ('Alejandro', 'Cardenas Ortiz',42,'M')
INSERT INTO persona("Nombre", "Apellido","Edad","Sexo")
VALUES ('Frank Antonio', 'Piñin Ato',19,'M')
INSERT INTO persona("Nombre", "Apellido","Edad","Sexo")
VALUES ('Jose Julieta', 'Villareal Flores',41,'M')
INSERT INTO persona("Nombre", "Apellido","Edad","Sexo")
VALUES ('Alejandrin', 'Cardenas Ortiz',20,'M')
-----mujeres
INSERT INTO persona("Nombre", "Apellido","Edad","Sexo")
VALUES ('Lucia', 'Piñin Ato',67,'F')
INSERT INTO persona("Nombre", "Apellido","Edad","Sexo")
VALUES ('Maria Mercedez Julieto', 'Villareal Flores',43,'F')
INSERT INTO persona("Nombre", "Apellido","Edad","Sexo")
VALUES ('Sofia', 'Cardenas Ortiz',22,'F')
INSERT INTO persona("Nombre", "Apellido","Edad","Sexo")
VALUES ('Carmen', 'Piñin Ato',24,'F')
INSERT INTO persona("Nombre", "Apellido","Edad","Sexo")
VALUES ('Marianella', 'Villareal Flores',54,'F')
INSERT INTO persona("Nombre", "Apellido","Edad","Sexo")
VALUES ('Anabel', 'Cardenas Ortiz',19,'F')

delete from persona
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
exec seleccionPME  18, 'F',@totalPME output --Ejecutamos el procedimiento donde M seria Masculino(Hombres)
select @totalPME--Mostramos el resultado
-----seleccionar tabla persona
select * from persona

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
where idPersona = 1
 
 select * from persona

 ------------------------------------------------------------------------------
 ----Elimar datos---
 CREATE procedure EliminarPersona
(
 @id int
)
as
delete  from persona
 where @id = idpersona

GO
EXEC EliminarPersona  1;  
select * from persona

---------------------------------------------------------------------------------
---------------------------------------------------------------------------------
--------------------Creamos procedimiento de vista----------------------------- 
CREATE PROCEDURE mostrarPersonasMayoresDE 
@edad int, --Parametros Entrada
@sexo varchar(20) --Parametros Entrada
AS      
   SELECT * 
   FROM persona AS p  
   Where p.Edad >= @edad and p.Sexo= @sexo  
RETURN  
GO  
exec mostrarPersonasMayoresDE 18, 'F'

CREATE PROCEDURE mostrarPersonasMenoresDE 
@edad int, --Parametros Entrada
@sexo varchar(20) --Parametros Entrada
AS      
   SELECT * 
   FROM persona AS p  
   Where p.Edad < @edad and p.Sexo= @sexo  
RETURN  
GO  
exec mostrarPersonasMenoresDE 18, 'M'

--------------------------------------------------------
--------MOSTRAR OBJETOS EN LA BASE DE DATOS-------------

sp_help --> Muestra objetos de la base de datos

sp_helptext eliminarPersona --Texto que define el objeto
sp_stored_procedures --Muestra todos los procedimientos almacenados

select *from sysobjects  -- muestra nombre y varios datos de todos los objetos de la base de datos actual



---------------------------------------------------------------------------------
---------------------------------------------------------------------------------
-----------------Manejo de BEGIN TRAN , ROLLBACK, COMMIT ------------------------

BEGIN TRAN
 INSERT INTO Users(userName, passUser) values ('empleado', 'empleado')
 select @@TRANCOUNT -- para contar cuantas tran hay almacenadas temporalmente
rollback -- si utilizo este , la tabla vuelve a la normalidad, osea antes de que se agregue este usuario
commit tran -- por ahora ese usuario esta de forma temporal, si uso este comando, el usuario se queda de forma permanente 
select * from Users
delete from Users where userName = 'empleado'


--menores de 18 
Begin tran 
delete from persona where edad <18 and sexo='M'
select * from persona 
rollback
commit tran 


--mayores de 18
Begin tran 
delete from persona where edad >=18 and sexo='M'
select * from persona 

rollback
commit tran 
