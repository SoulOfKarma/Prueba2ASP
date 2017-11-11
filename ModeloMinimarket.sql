SET QUOTED_IDENTIFIER ON

go
                                                     
use master  

go

create database "BaseDatosMinimarket"  

go

use "BaseDatosMinimarket"  

go

create table "Usuario" ( 
	"Id_usuario" int not null,
	"Pass_usuario" nvarchar(50) not null)  

go

alter table "Usuario"
	add constraint "Usuario_PK" primary key ("Id_usuario")   


go
                                                 
create table "Minimarket" ( 
	"Id_Minimarket" int not null,
	"Nombre_Minimarket" nvarchar(50) not null,
	"Direccion_Minimarket" nvarchar(100) not null)  

go

alter table "Minimarket"
	add constraint "Minimarket_PK" primary key ("Id_Minimarket")   


go

                                                        
create table "Producto" ( 
	"Id_producto" int not null,
	"Nombre_producto" nvarchar(50) not null,
	"Marca_producto" nvarchar(100) not null,
	"Precio_producto" int not null,
	"Stock_producto" int not null,
	"Id_Minimarket" int not null)  

go

alter table "Producto"
	add constraint "Producto_PK" primary key ("Id_producto")   


go

                                          
alter table "Producto"
	add constraint "Minimarket_Producto_FK1" foreign key (
		"Id_Minimarket")
	 references "Minimarket" (
		"Id_Minimarket") 

go


INSERT INTO [BaseDatosMinimarket].[dbo].[Minimarket] VALUES (00001,'Pets','Las animas 1233')

INSERT INTO [BaseDatosMinimarket].[dbo].[Usuario] VALUES (123456,'Juan')

INSERT INTO [BaseDatosMinimarket].[dbo].[Producto] VALUES (00001,'Salsa','Carozzy',200,100,00001)
INSERT INTO [BaseDatosMinimarket].[dbo].[Producto] VALUES (00002,'Salsa','Astan',300,100,00001)
Select * from producto;

