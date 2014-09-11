/*Proyecto para desarrollar habilidades en temas de desarrollo de softwar con tecnólogia microsoft*/
create database bd
use bd

go


create table tblpersona(
cedula varchar(20),
nombre varchar(50),
apellido varchar(50),
fechaNacimento date,
edad int,
ciudad varchar(20)
constraint pk_persona  primary key(cedula)
)
go
/*procedimiento lamacenado*/

/*procedure Select and delete*/
create proc spPersonaSE(
@operacion varchar(1),
@cedula varchar(20),
@nombre varchar(50),
@apellido varchar(50),
@fechaNacimiento date,
@edad int,
@ciudad varchar(20)
)
as
begin
if @operacion ='S'
select * from tblpersona where cedula=@cedula
else
if @operacion ='E'
delete from tblpersona where cedula=@cedula
else 
select* from tblpersona
end
go
/*procedimiento insert and update */
create proc spPersonaIA(
@operacion varchar(1),
@cedula varchar(20),
@nombre varchar(50),
@apellido varchar(50),
@fechaNacimiento date,
@edad int,
@ciudad varchar(20)
)
as 
begin
if @operacion ='I'
insert into tblpersona values(@cedula,@nombre,@apellido,@fechaNacimiento,@edad,@ciudad)
else 
if @operacion= 'A'
update tblpersona set nombre=@nombre,apellido=@apellido,fechaNacimento=@fechaNacimiento,edad=@edad,ciudad=@ciudad where cedula=@cedula
end
