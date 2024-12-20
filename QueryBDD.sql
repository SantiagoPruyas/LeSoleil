-- Creacion de la BDD
CREATE DATABASE DBLE_SOLEIL

USE DBLE_SOLEIL

--- Creacion de las Tablas asociadas al Proyecto
CREATE TABLE Perfil
(
  Perfil_id INT IDENTITY NOT NULL,
  NombreRol VARCHAR(50) NOT NULL,
  Descripcion VARCHAR(200) NOT NULL,
  Fecha_creacion DATETIME DEFAULT getdate(),
  PRIMARY KEY (Perfil_id)
);

EXEC sp_rename 'Perfil.Nombre', 'NombreRol', 'COLUMN';

CREATE TABLE Cliente
(
  Id_cliente INT IDENTITY NOT NULL,
  DNI INT NOT NULL,
  Nombre VARCHAR(50) NOT NULL,
  Apellido VARCHAR(50) NOT NULL,
  Direccion VARCHAR(100) NOT NULL,
  Telefono INT NOT NULL,
  Email VARCHAR(50) NOT NULL,
  Baja bit,
  Fecha_creacion DATETIME DEFAULT getdate(),
  Usuario_registro INT NOT NULL,
  PRIMARY KEY (Id_cliente)
);

CREATE TABLE Proveedor
(
  Id_Proveedor INT IDENTITY NOT NULL,
  Descripcion VARCHAR(150) NOT NULL,
  Nombre VARCHAR(100) NOT NULL,
  Direccion VARCHAR(100) NOT NULL,
  Telefono INT NOT NULL,
  Email VARCHAR(50) NOT NULL,
  Fecha_creacion DATETIME DEFAULT getdate(),
  Baja bit,
  PRIMARY KEY (Id_Proveedor)
);

CREATE TABLE Categoria
(
  Id_Categoria INT IDENTITY NOT NULL,
  Nombre VARCHAR(50) NOT NULL,
  Descripcion VARCHAR(100) NOT NULL,
  Estado INT NOT NULL,
  Fecha_creacion DATETIME DEFAULT getdate(),
  PRIMARY KEY (Id_Categoria)
);

CREATE TABLE Permiso
(
  Id_permiso INT IDENTITY NOT NULL,
  Nombre VARCHAR(100) NOT NULL,
  Fecha_creacion DATETIME DEFAULT getdate(),
  Perfil_id INT NOT NULL,
  PRIMARY KEY (Id_permiso),
  FOREIGN KEY (Perfil_id) REFERENCES Perfil(Perfil_id)
);

CREATE TABLE Usuario
(
  Id_usuario INT IDENTITY NOT NULL,
  Nombre VARCHAR(50) NOT NULL,
  Apellido VARCHAR(50) NOT NULL,
  Usuario VARCHAR(100) NOT NULL,
  Contrase�a VARCHAR(50) NOT NULL,
  DNI VARCHAR(100),
  Fecha_nacimiento DATE,
  Correo VARCHAR(100),
  Direccion VARCHAR(100),
  Telefono VARCHAR(20),
  Baja bit,
  Fecha_creacion DATETIME DEFAULT getdate(),
  Perfil_id INT NOT NULL,
  PRIMARY KEY (Id_usuario),
  FOREIGN KEY (Perfil_id) REFERENCES Perfil(Perfil_id)
);

CREATE TABLE VentaCabecera
(
  Id_venta INT IDENTITY NOT NULL,
  Nro_Factura VARCHAR(50) NOT NULL,
  FechaVenta DATETIME DEFAULT getdate() NOT NULL,
  Total DECIMAL (10,2) NOT NULL,
  Monto_pago DECIMAL (10,2) NOT NULL,
  Monto_cambio DECIMAL (10,2) NOT NULL,
  Id_usuario INT NOT NULL,
  Id_cliente INT NOT NULL,
  PRIMARY KEY (Id_venta),
  FOREIGN KEY (Id_usuario) REFERENCES Usuario(Id_usuario),
  FOREIGN KEY (Id_cliente) REFERENCES Cliente(Id_cliente)
);

CREATE TABLE CompraCabecera
(
  Id_compra INT IDENTITY,
  FechaCompra DATETIME DEFAULT getdate() NOT NULL,
  Total DECIMAL (10,2) NOT NULL,
  Id_usuario INT NOT NULL,
  Id_Proveedor INT NOT NULL,
  PRIMARY KEY (Id_compra),
  FOREIGN KEY (Id_usuario) REFERENCES Usuario(Id_usuario),
  FOREIGN KEY (Id_Proveedor) REFERENCES Proveedor(Id_Proveedor)
);

CREATE TABLE Producto
(
  Id_producto INT IDENTITY NOT NULL,
  Nombre VARCHAR(50) NOT NULL,
  Descripcion VARCHAR(100) NOT NULL,
  Stock INT NOT NULL DEFAULT 0,
  Precio_compra DECIMAL (10,2) NOT NULL DEFAULT 0,
  Precio_venta DECIMAL (10,2) NOT NULL DEFAULT 0,
  Baja bit NOT NULL,
  Fecha_registro DATETIME DEFAULT getdate() NOT NULL,
  Id_compra INT NOT NULL,
  Id_Categoria INT NOT NULL,
  PRIMARY KEY (Id_producto),
  FOREIGN KEY (Id_compra) REFERENCES CompraCabecera(Id_compra),
  FOREIGN KEY (Id_Categoria) REFERENCES Categoria(Id_Categoria)
);


CREATE TABLE CompraDetalle
(
  Id_detalleCompra INT IDENTITY NOT NULL,
  Cantidad INT NOT NULL,
  Subtotal DECIMAL (10,2) NOT NULL,
  Precio_compra DECIMAL (10,2) NOT NULL,
  -- Quitar precio_venta no hace falta
  Precio_venta DECIMAL (10,2) NOT NULL,
  Fecha_registro DATETIME DEFAULT getdate(),
  Id_compra INT NOT NULL,
  Id_producto INT NOT NULL,
  PRIMARY KEY (Id_detalleCompra),
  FOREIGN KEY (Id_compra) REFERENCES CompraCabecera(Id_compra),
  FOREIGN KEY (Id_producto) REFERENCES Producto(Id_producto)
);

CREATE TABLE VentaDetalle
(
  Id_detalleVenta INT IDENTITY NOT NULL,
  Cantidad INT NOT NULL,
  Subtotal DECIMAL (10,2) NOT NULL,
  Precio_venta DECIMAL (10,2) NOT NULL,
  Fecha_registro DATETIME DEFAULT getdate() NOT NULL,
  Id_venta INT NOT NULL,
  Id_producto INT NOT NULL,
  PRIMARY KEY (Id_detalleVenta),
  FOREIGN KEY (Id_venta) REFERENCES VentaCabecera(Id_venta),
  FOREIGN KEY (Id_producto) REFERENCES Producto(Id_producto)
);

CREATE TABLE Factura
(
  Id_Factura INT IDENTITY NOT NULL,
  Tipo_Factura VARCHAR(1) NOT NULL
);
-- Modificaciones previas a la creacion de Datos
-- Nuevas Columnas a Tabla Usuario
/* ALTER TABLE Usuario
ADD 
    Direccion VARCHAR(100),
    Telefono VARCHAR(20);

ALTER TABLE Usuario
ADD 
    Correo VARCHAR(100);

ALTER TABLE Usuario
ALTER COLUMN Telefono VARCHAR(20);

ALTER TABLE Categoria
ALTER COLUMN Descripcion VARCHAR(500);

-- Drop columna Sexo
ALTER TABLE Usuario
DROP COLUMN Sexo;

-- Solucion de perfiles
SELECT name 
FROM sys.foreign_keys 
WHERE referenced_object_id = object_id('Perfil');

ALTER TABLE Permiso
DROP CONSTRAINT FK__Permiso__Perfil___5629CD9C;

ALTER TABLE Usuario
DROP CONSTRAINT FK__Usuario__Perfil___59FA5E80;

DROP TABLE IF EXISTS Perfil;

ALTER TABLE Usuario
ADD CONSTRAINT FK_Usuario_Perfil
FOREIGN KEY (Perfil_id) REFERENCES Perfil(Perfil_id);

ALTER TABLE Permiso
ADD CONSTRAINT FK_Permiso_Perfil
FOREIGN KEY (Perfil_id) REFERENCES Perfil(Perfil_id);

*/

ALTER TABLE Categoria
ALTER COLUMN Descripcion VARCHAR(500);

-- agregar atributos a la tabla Producto
ALTER TABLE Producto
Drop Column Stock_min;

-- Drop Column id_compra
ALTER TABLE Producto
DROP CONSTRAINT FK__Producto__Id_com__6A30C649;
ALTER TABLE Producto
Drop Column Id_compra;

ALTER TABLE Producto
ADD Codigo VARCHAR(50) NOT NULL;

ALTER TABLE Producto
ADD Imagen VARBINARY(MAX);

ALTER TABLE Cliente
ALTER COLUMN DNI VARCHAR(50) NOT NULL;

ALTER TABLE Cliente
ALTER COLUMN Telefono VARCHAR(50) NOT NULL;

ALTER TABLE Cliente
ADD Fecha_nacimiento DATE NOT NULL;

ALTER TABLE Proveedor
ADD CUIT VARCHAR(50) NOT NULL;

ALTER TABLE Proveedor
ADD Razon_social VARCHAR(50) NOT NULL;

ALTER TABLE Proveedor
ADD Ciudad VARCHAR(100) NOT NULL;

ALTER TABLE Proveedor
ADD Pais VARCHAR(100) NOT NULL;

ALTER TABLE Proveedor
ALTER COLUMN Descripcion VARCHAR(150) NULL;

ALTER TABLE Proveedor
ALTER COLUMN Telefono VARCHAR(50) NULL;

ALTER TABLE Factura
alter Column Tipo_Factura varchar(2);

ALTER TABLE VentaCabecera
add Id_Factura int;

ALTER TABLE Factura
ADD CONSTRAINT PK_Factura PRIMARY KEY (Id_Factura);

ALTER TABLE VentaCabecera
ADD CONSTRAINT FK_Factura_Id_Factura
FOREIGN KEY (Id_Factura) REFERENCES Factura(Id_Factura);

---------------------------------- LOTE DE DATOS ----------------------------------
-- Selects
SELECT * from Usuario
SELECT * from Perfil
SELECT * from Permiso order by Perfil_id ASC
SELECT * from Categoria
SELECT * from Producto
SELECT * from Proveedor
SELECT * from Factura
SELECT * from VentaCabecera
SELECT * from VentaDetalle
SELECT * FROM auditoria_backup

-- Creacion de Perfiles
insert into Perfil (NombreRol, Descripcion) values ('ADMINISTRADOR', 'Este usuario administrador tiene los permisos necesarios para ingresar a todas las funcionalidades')
insert into Perfil (NombreRol, Descripcion) values ('VENDEDOR', 'Este usuario administrador tiene los permisos necesarios para manejar ventas y clientes')
insert into Perfil (NombreRol, Descripcion) values ('REPOSITOR', 'Este usuario repositor tiene los permisos necesarios para gestionar los productos')
insert into Perfil (NombreRol, Descripcion) values ('GERENTE', 'Este usuario gerente tiene los permisos necesarios para gestionar toda la aplicacion excepto por funcionalidades propias del admin')

-- Primer Usuario Admin
insert into Usuario(Nombre, Apellido, Usuario, Contrase�a, DNI, Fecha_nacimiento, Correo, Baja, Perfil_id, Direccion, Telefono) 
values ('Lara','Valetto','Lara','admin','45374333','2003-11-26','lvaletto21@gmail.com',0,2,'Junin 25', '3794995322')

SELECT * FROM Usuario
WHERE Usuario = 'Lara';

UPDATE Usuario
SET Perfil_id = 1
WHERE Usuario = 'Lara';

-- Modificar usuario
UPDATE Usuario
SET Baja = 0
WHERE Id_usuario = 3;

-- Insertar nuevos valores
UPDATE Usuario
SET	Correo = 'juanperez@hotmail.com'
WHERE Id_usuario = 4;

-- Primer Usuario Vendedor
insert into Usuario(Nombre, Apellido, Usuario, Contrase�a, DNI, Fecha_nacimiento, Correo, Baja, Perfil_id, Direccion, Telefono) 
values ('Juan','Perez','Vendedor','12345','28678943','1997-11-02','juanperez@gmail.com',0,3,'En su casa', '3795687953')

-- Modificar Vendedor
UPDATE Usuario
SET Perfil_id = 2
WHERE Id_usuario = 3;

-- Insertar nuevos valores
UPDATE Usuario
SET DNI = '28345698',
    Fecha_nacimiento = '1990-10-02'
WHERE Id_usuario = 4;

-- Tratamiento de Permisos
INSERT INTO Permiso(Perfil_id,Nombre) values
(1,'MenuUsuarios'),
(1,'MenuBackup'),
(1,'MenuClientes'),
(1,'MenuProductos'),
(1,'MenuReportes'),
(1,'MenuSalir')

-- Permiso de MenuCompras para el administrador
INSERT INTO Permiso(Perfil_id,Nombre) values
(1,'MenuCompras')

-- Permiso de MenuCategorias para el administrador
INSERT INTO Permiso(Perfil_id,Nombre) values
(1,'MenuCategorias')

-- Permiso de MenuCategorias para el repositor
INSERT INTO Permiso(Perfil_id,Nombre) values
(3,'MenuCategorias')

-- Permiso de MenuProveedores para el administrador
INSERT INTO Permiso(Perfil_id,Nombre) values
(1,'MenuProveedores')

-- Permiso de MenuUsuarios para el administrador
INSERT INTO Permiso(Perfil_id,Nombre) values
(1,'MenuUsuarios')

-- Gestion de permisos de usuario Gerente
INSERT INTO Permiso(Perfil_id,Nombre) values
(4,'MenuClientes'),
(4,'MenuProveedores'),
(4,'MenuCategorias'),
(4,'MenuProductos'),
(4,'MenuReportes'),
(4,'MenuSalir')

-- Permiso de MenuReportesGerente para el Gerente
UPDATE Permiso
SET Nombre = 'MenuReportesGerente'
WHERE Id_permiso = 32

-- Permiso de MenuReportesGerente para el Gerente
UPDATE Permiso
SET Nombre = 'MenuReportesVendedor'
WHERE Id_permiso = 9

UPDATE Permiso
SET Nombre = 'MenuBackup'
WHERE Nombre = 'MenuBackUp'

INSERT INTO Permiso(Perfil_id,Nombre) values
(3,'MenuClientes'),
(3,'MenuProductos'),
(3,'MenuReportes'),
(3,'MenuSalir')

INSERT INTO Permiso(Perfil_id, Nombre) values
(1,'MenuVentas'),
(2,'MenuVentas')

INSERT INTO Permiso(Perfil_id,Nombre) values
(3,'MenuBackup'),
(3,'MenuProductos'),
(3,'MenuReportes'),
(3,'MenuSalir')

-- Insercion de Tipos de Facturas
INSERT INTO Factura(Tipo_Factura) values
('A'),
('B'),
('C')
 
-- Eliminacion del permiso "MenuProductos" al vendedor 
DELETE from Permiso where Id_permiso = 8

-- Eliminacion del permiso "MenuBackUp" al repositor 
DELETE from Permiso where Id_permiso = 22

--Eliminacion de permisos de administrador
DELETE FROM Permiso WHERE Id_permiso IN (1, 3, 4, 16, 18, 19, 20);

-- Modificar Permisos
UPDATE Permiso
SET Perfil_id = 3
WHERE Perfil_id = 4;

-- Select de Perfiles
select p.Perfil_id,p.Nombre from Permiso p 
inner join Perfil r on r.Perfil_id = p.Perfil_id
inner join Usuario u on u.Perfil_id = r.Perfil_id
where u.Id_usuario = 2

-- Select de Usuarios
select u.Id_Usuario, u.Nombre, u.Apellido, u.Contrase�a, u.Baja, u.Usuario, u.Direccion, u.Telefono, u.DNI, u.Fecha_nacimiento, u.Correo, r.Perfil_id, r.NombreRol from Usuario u
inner join Perfil r on r.Perfil_id = u.Perfil_id

-- Select de Proveedores
select Id_Proveedor, Descripcion, Nombre, Direccion, Telefono, Email, Baja, CUIT, Razon_social, Ciudad, Pais from Proveedor

-- Select de Ventas
SELECT v.Id_venta, u.Nombre[NombreVendedor], c.DNI, c.Nombre[NombreCliente], f.Tipo_Factura, v.Nro_Factura, v.Monto_pago, v.Monto_cambio, v.Total,
convert(char(10),v.FechaVenta,103)[FechaRegistro]
from VentaCabecera v
inner join Usuario u on u.Id_usuario = v.Id_usuario
inner join Cliente c on c.Id_cliente = v.Id_cliente
inner join Factura f on f.Id_Factura = v.Id_Factura
where v.Nro_Factura = '0002'

SELECT p.Nombre, vd.Precio_venta, vd.Subtotal
FROM VentaDetalle vd
INNER JOIN Producto p on p.Id_producto = vd.Id_producto
WHERE vd.Id_venta = 1

-- Select Auditoria
SELECT a.Id_auditoria, u.Nombre, a.Estado, a.Fecha_backup, a.Ubicacion_backup from auditoria_backup a 
inner join Usuario u on u.Id_usuario = a.Id_usuario  

------------ *** CORRECION DE PERFILES (Solo Lara) *** ------------ 
Select * from Perfil
select * from Permiso

INSERT INTO Permiso(Perfil_id,Nombre) values
(7,'MenuClientes'),
(7,'MenuProveedores'),
(7,'MenuCategorias'),
(7,'MenuProductos'),
(7,'MenuReportes'),
(7,'MenuSalir')

-- Permiso backup para el Admin
INSERT INTO Permiso(Perfil_id,Nombre) values
(1,'MenuBackup')

-- borrar permisos de admin
DELETE FROM Permiso
WHERE Id_permiso IN (9, 10, 13, 21, 23, 24, 25, 26, 27, 28, 30, 31, 42, 48, 50, 61, 67);

-- borrar permisos de vendedor
DELETE FROM Permiso
WHERE Id_permiso IN (2, 5, 6, 14, 43, 62);

-- Permiso de MenuReportesGerente para el Gerente
UPDATE Permiso
SET Nombre = 'MenuReportesGerente'
WHERE Id_permiso = 78

-- Permiso de MenuVentas para el Gerente
INSERT INTO Permiso(Perfil_id,Nombre) values
(7,'MenuVentas')

-- Permiso de MenuReportesGerente para el Admin
UPDATE Permiso
SET Nombre = 'MenuReportesGerente'
WHERE Id_permiso = 11

-- agregar permisos de vendedor
INSERT INTO Permiso(Perfil_id,Nombre) values
(2,'MenuVentas'),
(2,'MenuClientes'),
(2,'MenuReportesVendedor'),
(2,'MenuSalir')

-- borrar permisos de repositor
delete FROM Permiso
WHERE Id_permiso IN (15, 17, 29, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 44, 45, 46, 47, 49, 57, 58, 59, 60, 63, 64, 65, 66);

INSERT INTO Permiso(Perfil_id,Nombre) values
(3,'MenuCategorias'),
(3,'MenuProductos'),
(3,'MenuSalir')

---------------------------------- PROCEDIMIENTOS ----------------------------------
create PROC SP_REGISTRARUSUARIO(
@DNI varchar(100),
@Nombre varchar(50),
@Apellido varchar(50),
@Usuario varchar(50),
@Correo varchar(100),
@Contrase�a varchar(50),
@Fecha_nacimiento DATE,
@Direccion VARCHAR(100),
@Telefono VARCHAR(20),
@Perfil_id int,
@Baja bit,
@IdUsuarioResultado int output,
@Mensaje varchar(500) output
)
as
begin
	set @IdUsuarioResultado = 0
	set @Mensaje = ''


	if not exists(select * from Usuario where DNI = @DNI)
	begin
		insert into Usuario(DNI, Nombre, Apellido, Usuario, Correo, Contrase�a, Fecha_nacimiento, Direccion, Telefono, Perfil_id, Baja) values
		(@DNI, @Nombre, @Apellido, @Usuario, @Correo, @Contrase�a, @Fecha_nacimiento, @Direccion, @Telefono, @Perfil_id, @Baja)

		set @IdUsuarioResultado = SCOPE_IDENTITY()
		
	end
	else
		set @Mensaje = 'No se puede repetir el DNI para m�s de un usuario'

end
-- Fin SP_REGISTRARUSUARIO
-- Prueba
declare @IdUsuariogenerado int
declare @mensaje varchar(500)

exec SP_REGISTRARUSUARIO '23456789', 'Sara', 'Huarez', 'Repositora', 'SaraHuarez@gmail.com', '12345', '2000-04-05', 'Junin 80', '3456902345', 3, 0, @IdUsuariogenerado output, @mensaje output

select @IdUsuariogenerado

select @mensaje

go

create PROC SP_EDITARUSUARIO(
@Id_usuario int,
@DNI varchar(100),
@Nombre varchar(50),
@Apellido varchar(50),
@Usuario varchar(50),
@Correo varchar(100),
@Contrase�a varchar(50),
@Fecha_nacimiento DATE,
@Direccion VARCHAR(100),
@Telefono VARCHAR(20),
@Perfil_id int,
@Baja bit,
@Respuesta bit output,
@Mensaje varchar(500) output
)
as
begin
	set @Respuesta = 0
	set @Mensaje = ''


	if not exists(select * from Usuario where DNI = @DNI and Id_usuario != @Id_usuario)
	begin
		UPDATE Usuario set
		DNI = @DNI, 
		Nombre = @Nombre, 
		Apellido = @Apellido, 
		Usuario = @Usuario, 
		Correo = @Correo, 
		Contrase�a = @Contrase�a, 
		Fecha_nacimiento = @Fecha_nacimiento, 
		Direccion = @Direccion, 
		Telefono = @Telefono, 
		Perfil_id = @Perfil_id, 
		Baja = @Baja
		where Id_usuario = @Id_usuario

		set @Respuesta = 1
		
	end
	else
		set @Mensaje = 'No se puede repetir el DNI para m�s de un usuario'

end
-- Fin SP_EDITARUSUARIO
-- Prueba
declare @Respuesta bit
declare @mensaje varchar(500)

exec SP_EDITARUSUARIO 5,'43205306', 'Sara', 'Huarez', 'Repositora', 'SaraHuarez@gmail.com', '12345', '2000-04-05', 'Junin 80', '3456902345', 3, 1, @Respuesta output, @mensaje output

select @Respuesta

select @mensaje

go

create PROC SP_ELIMINARUSUARIO(
@IdUsuario int,
@Respuesta bit output,
@Mensaje varchar(500) output
)
as
begin
	set @Respuesta = 0
	set @Mensaje = ''
	declare @pasoreglas bit = 1

	IF EXISTS (SELECT * FROM CompraCabecera C 
	INNER JOIN USUARIO U ON U.Id_usuario = C.Id_usuario
	WHERE U.Id_usuario = @IdUsuario
	)
	BEGIN
		set @pasoreglas = 0
		set @Respuesta = 0
		set @Mensaje = @Mensaje + 'No se puede eliminar porque el usuario se encuentra relacionado a una COMPRA\n' 
	END

	IF EXISTS (SELECT * FROM VentaCabecera V
	INNER JOIN USUARIO U ON U.Id_usuario = V.Id_usuario
	WHERE U.Id_usuario = @IdUsuario
	)
	BEGIN
		set @pasoreglas = 0
		set @Respuesta = 0
		set @Mensaje = @Mensaje + 'No se puede eliminar porque el usuario se encuentra relacionado a una VENTA\n' 
	END

	if(@pasoreglas = 1)
	begin
		delete from USUARIO where Id_usuario = @IdUsuario
		set @Respuesta = 1 
	end
end
-- Fin SP_ELIMINARUSUARIO
-- Prueba
declare @Respuesta bit
declare @mensaje varchar(500)

exec SP_EDITARUSUARIO 5,'43205306', 'Sara', 'Huarez', 'Repositora', 'SaraHuarez@gmail.com', '12345', '2000-04-05', 'Junin 80', '3456902345', 3, 1, @Respuesta output, @mensaje output

select @Respuesta

select @mensaje

go

create PROC SP_BAJAUSUARIO(
@IdUsuario int,
@Respuesta bit output,
@Mensaje varchar(500) output
)
as
begin
	set @Respuesta = 0
	set @Mensaje = ''

	if EXISTS(select * from Usuario where Id_usuario = @IdUsuario)
		BEGIN
			UPDATE Usuario set 
			Baja = 1
			where Id_usuario = @IdUsuario

			set @Respuesta = 1 
			set @Mensaje = 'Se ejecuto con exito la baja del usuario'
		END	
		ELSE
			SET @Mensaje = 'El id de Usuario no coindice con ningun otro id';
end
-- Fin SP_BAJAUSUARIO
-- Prueba
declare @Respuesta bit
declare @mensaje varchar(500)

exec SP_BAJAUSUARIO 6, @Respuesta output, @mensaje output

select @Respuesta

select @mensaje

go

create PROC SP_ALTAUSUARIO(
@IdUsuario int,
@Respuesta bit output,
@Mensaje varchar(500) output
)
as
begin
	set @Respuesta = 0
	set @Mensaje = ''

	if EXISTS(select * from Usuario where Id_usuario = @IdUsuario)
		BEGIN
			UPDATE Usuario set 
			Baja = 0
			where Id_usuario = @IdUsuario

			set @Respuesta = 1 
			set @Mensaje = 'Se ejecuto con exito el alta del usuario'
		END	
		ELSE
			SET @Mensaje = 'El id de Usuario no coindice con ningun otro id';
end
-- Fin SP_ALTAUSUARIO

-- Prueba
declare @Respuesta bit
declare @mensaje varchar(500)

exec SP_ALTAUSUARIO 6, @Respuesta output, @mensaje output

select @Respuesta

select @mensaje

/* ---------- PROCEDIMIENTOS PARA CATEGORIA -----------------*/
create PROC SP_RegistrarCategoria(
@Nombre varchar(50),
@Descripcion varchar(500),
@Resultado int output,
@Mensaje varchar(500) output
)as
begin
	SET @Resultado = 0
	IF NOT EXISTS (SELECT * FROM CATEGORIA WHERE Nombre = @Nombre)
	begin
		insert into CATEGORIA(Nombre,Descripcion,Estado) values (@Nombre,@Descripcion,1)
		set @Resultado = SCOPE_IDENTITY()
	end
	ELSE
		set @Mensaje = 'No se puede repetir el nombre de una categoria'
	
end


go

create procedure sp_EditarCategoria(
@IdCategoria int,
@Nombre varchar(50),
@Descripcion varchar(500),
@Resultado bit output,
@Mensaje varchar(500) output
)
as
begin
	SET @Resultado = 1
	IF NOT EXISTS (SELECT * FROM CATEGORIA WHERE Nombre =@Nombre and Id_Categoria != @IdCategoria)
		update CATEGORIA set
		Nombre = @Nombre,
		Descripcion = @Descripcion
		where Id_Categoria = @IdCategoria
	ELSE
	begin
		SET @Resultado = 0
		set @Mensaje = 'No se puede repetir el nombre de una categoria'
	end

end

go

create procedure sp_EliminarCategoria(
@IdCategoria int,
@Resultado bit output,
@Mensaje varchar(500) output
)
as
begin
	SET @Resultado = 1
	IF NOT EXISTS (
	 select *  from CATEGORIA c
	 inner join PRODUCTO p on p.Id_Categoria = c.Id_Categoria
	 where c.Id_Categoria = @IdCategoria
	)
	begin
	 delete top(1) from CATEGORIA where Id_Categoria = @IdCategoria
	end
	ELSE
	begin
		SET @Resultado = 0
		set @Mensaje = 'La categoria se encuentara relacionada a un producto'
	end

end


-- Baja Categoria
create PROC SP_BAJACATEGORIA(
@IdCategoria int,
@Respuesta bit output,
@Mensaje varchar(500) output
)
as
begin
	set @Respuesta = 0
	set @Mensaje = ''

	if EXISTS(select * from Categoria where Id_Categoria = @IdCategoria)
		BEGIN
			UPDATE Categoria set 
			Estado = 0
			where Id_Categoria = @IdCategoria

			set @Respuesta = 1 
			set @Mensaje = 'Se ejecuto con exito la baja de la Categoria'
		END	
		ELSE
			SET @Mensaje = 'El id de Categoria no coindice con ningun otro id';
end
-- Fin SP_BAJACATEGORIA

go
create PROC SP_ALTACATEGORIA(
@IdCategoria int,
@Respuesta bit output,
@Mensaje varchar(500) output
)
as
begin
	set @Respuesta = 0
	set @Mensaje = ''

	if EXISTS(select * from Categoria where Id_Categoria = @IdCategoria)
		BEGIN
			UPDATE Categoria set 
			Estado = 1
			where Id_Categoria = @IdCategoria

			set @Respuesta = 1 
			set @Mensaje = 'Se ejecuto con exito el alta de la categoria'
		END	
		ELSE
			SET @Mensaje = 'El id de Categoria no coindice con ningun otro id';
end
-- Fin SP_ALTACATEGORIA
select @mensaje


---------------------------------- PROCEDIMIENTOS PRODUCTO ----------------------------------
SELECT Id_producto, Codigo, p.Nombre[NombreProducto], p.Descripcion, c.Id_Categoria, c.Nombre[NombreCategoria], Precio_compra, Precio_venta, Stock, Stock_minimo, Imagen, Baja from Producto p 
inner join Categoria c on c.Id_Categoria = p.Id_Categoria

alter PROC SP_REGISTRARPRODUCTO(
@Codigo varchar(50),
@Nombre varchar(50),
@Descripcion varchar(100),
@Precio_compra decimal (10,2),
@Precio_venta decimal (10,2),
@stock int,
@stock_min int,
@Id_Categoria int,
@Imagen VARBINARY(MAX),
@Baja bit,
@IdProductoResultado int output,
@Mensaje varchar(500) output
) as
begin 
	SET @IdProductoResultado = 0
	SET @Mensaje = ''

	IF NOT EXISTS(SELECT * FROM producto WHERE Codigo = @Codigo)
	begin 
		insert into Producto(Codigo,Nombre,Descripcion,Precio_compra,Precio_venta,Stock,Stock_minimo,Id_Categoria, Imagen, Baja) 
		values (@Codigo, @Nombre, @Descripcion, @Precio_compra, @Precio_venta, @stock, @Stock_min, @Id_Categoria, @Imagen, @Baja)

		set @IdProductoResultado = SCOPE_IDENTITY()
	end
	ELSE 
	SET @Mensaje = 'Ya existe un producto con el mismo codigo'
end

go

alter procedure SP_EDITARPRODUCTO(
@Id_producto int,
@Codigo varchar(50),
@Nombre varchar(50),
@Descripcion varchar(100),
@Precio_compra decimal (10,2),
@Precio_venta decimal (10,2),
@stock int,
@stock_min int,
@Id_Categoria int,
@Imagen VARBINARY(MAX),
@Baja bit,
@Resultado bit output,
@Mensaje varchar(500) output
)
as
begin 
	set @Resultado = 1
	set @Mensaje = ''

	if not exists (select * from Producto where Codigo = @Codigo and Id_producto != @Id_producto)
	
		update Producto set
		Codigo = @Codigo,
		Nombre = @Nombre,
		Descripcion = @Descripcion,
		Precio_compra = @Precio_compra,
		Precio_venta = @Precio_venta,
		Stock = @stock,
		Stock_minimo = @stock_min,
		Id_Categoria = @Id_Categoria,
		Imagen = @Imagen,
		Baja = @Baja
		where Id_producto = @Id_producto
	ELSE
	begin
		set @Resultado = 0
		set @Mensaje = 'Ya existe un producto con el mismo codigo'
	end
end

go

create PROC SP_ELIMINARPRODUCTO(
@Id_producto int,
@Respuesta bit output,
@Mensaje varchar(500) output
)
as
begin 
	set @Respuesta = 0
	set @Mensaje = ''
	declare @pasoreglas bit = 1

	if exists (select * from VentaDetalle dv
	inner join Producto p ON p.Id_producto = dv.Id_producto
	where p.Id_producto = @Id_producto
	)
	begin
		set @pasoreglas = 0
		set @Respuesta = 0
		set @Mensaje = @Mensaje + 'No se puede eliminar porque se encuentra relacionado a una VENTA\n'
	end

	if(@pasoreglas = 1)
	begin
		delete from Producto where Id_producto = @Id_producto
		set @Respuesta = 1
	end 
end

---- BAJA PRODUCTO
create PROC SP_BAJAPRODUCTO(
@IdProducto int,
@Respuesta bit output,
@Mensaje varchar(500) output
)
as
begin
	set @Respuesta = 0
	set @Mensaje = ''

	if EXISTS(select * from Producto where Id_producto = @IdProducto)
		BEGIN
			UPDATE Producto set 
			Baja = 1
			where Id_producto = @IdProducto

			set @Respuesta = 1 
			set @Mensaje = 'Se ejecuto con exito la baja del producto'
		END	
		ELSE
			SET @Mensaje = 'El id del Producto no coindice con ningun otro id';
end

---- ALTA PRODUCTO
create PROC SP_ALTAPRODUCTO(
@IdProducto int,
@Respuesta bit output,
@Mensaje varchar(500) output
)
as
begin
	set @Respuesta = 0
	set @Mensaje = ''

	if EXISTS(select * from Producto where Id_producto = @IdProducto)
		BEGIN
			UPDATE Producto set 
			Baja = 0
			where Id_producto = @IdProducto

			set @Respuesta = 1 
			set @Mensaje = 'Se ejecuto con exito el alta del producto'
		END	
		ELSE
			SET @Mensaje = 'El id del Producto no coindice con ningun otro id';
end


---------------------------------- PROCEDIMIENTOS CLIENTE ----------------------------------
select Id_cliente, DNI, Nombre, Apellido, Direccion, Telefono, Email, Fecha_nacimiento, Baja from Cliente

--Registrar Cliente
alter PROC SP_REGISTRARCLIENTE(
@DNI varchar(50),
@Nombre varchar(50),
@Apellido varchar(50),
@Direccion varchar(100),
@Telefono VARCHAR(50),
@Email varchar(50),
@Fecha_nacimiento DATE,
@Baja bit,
@Usuario_registro int,
@Respuesta int output,
@Mensaje varchar(500) output
)
as
begin
	set @Respuesta = 0
	set @Mensaje = ''

	DECLARE @IDPERSONA INT
	if not exists (select * from Cliente WHERE DNI = @DNI)
	begin 
		insert into Cliente(DNI, Nombre, Apellido, Direccion, Telefono, Email, Fecha_nacimiento, Usuario_registro, Baja) values
		(@DNI, @Nombre, @Apellido, @Direccion, @Telefono, @Email, @Fecha_nacimiento, @Usuario_registro, @Baja)

		set @Respuesta = SCOPE_IDENTITY()
	end
	else
		set @Mensaje = 'El numero de documento ingresado ya existe.'
end

go

-- Editar cliente
alter PROC SP_EDITARCLIENTE(
@Id_cliente int,
@DNI varchar(50),
@Nombre varchar(50),
@Apellido varchar(50),
@Direccion varchar(100),
@Telefono VARCHAR(50),
@Email varchar(50),
@Fecha_nacimiento DATE,
@Baja bit,
@Respuesta bit output,
@Mensaje varchar(500) output
)
as
begin
	set @Respuesta = 1
	set @Mensaje = ''
	DECLARE @IDPERSONA INT


	if not exists(select * from Cliente where DNI = @DNI and Id_cliente != @Id_cliente)
	begin
		UPDATE Cliente set
		DNI = @DNI, 
		Nombre = @Nombre, 
		Apellido = @Apellido, 
		Direccion = @Direccion,
		Telefono = @Telefono,
		Email = @Email,
		Fecha_nacimiento = @Fecha_nacimiento, 
		Baja = @Baja
		where Id_cliente = @Id_cliente
	end
	else
	begin 
		SET @Respuesta = 0
		SET @Mensaje = 'El numero de documento ingresado ya existe.'
	end
end

-- Baja cliente
create PROC SP_BAJACliente(
@Id_cliente int,
@Respuesta bit output,
@Mensaje varchar(500) output
)
as
begin
	set @Respuesta = 0
	set @Mensaje = ''

	if EXISTS(select * from Cliente where Id_cliente = @Id_cliente)
		BEGIN
			UPDATE Cliente set 
			Baja = 1
			where Id_cliente = @Id_cliente

			set @Respuesta = 1 
			set @Mensaje = 'Se ejecuto con exito la baja del cliente.'
		END	
		ELSE
			SET @Mensaje = 'El id de Cliente no coindice con ningun otro id';
end

go

-- Alta cliente
create PROC SP_ALTACliente(
@Id_cliente int,
@Respuesta bit output,
@Mensaje varchar(500) output
)
as
begin
	set @Respuesta = 0
	set @Mensaje = ''

	if EXISTS(select * from Cliente where Id_cliente = @Id_cliente)
		BEGIN
			UPDATE Cliente set 
			Baja = 0
			where Id_cliente = @Id_cliente

			set @Respuesta = 1 
			set @Mensaje = 'Se ejecuto con exito el alta del cliente'
		END	
		ELSE
			SET @Mensaje = 'El id de Cliente no coindice con ningun otro id';
end

---------------------------------- PROCEDIMIENTOS PROVEEDORES ----------------------------------
select * from Proveedor;

-- Metodo REGISTRAR Proveedor (con Descripcion incluida)
create PROC SP_REGISTRARPROVEEDOR(
@Descripcion VARCHAR(150),
@Nombre varchar(50),
@Direccion varchar(100),
@Telefono VARCHAR(50),
@Email varchar(50),
@Baja bit,
@CUIT varchar(50),
@Razon_social varchar(50),
@Ciudad varchar(100),
@Pais varchar(100),
@Respuesta int output,
@Mensaje varchar(500) output
)
as
begin
	set @Respuesta = 0
	set @Mensaje = ''

	DECLARE @IDPERSONA INT
	if not exists (select * from Proveedor WHERE CUIT = @CUIT)
	begin 
		insert into Proveedor(Descripcion, Nombre, Direccion, Telefono, Email, Baja, CUIT, Razon_social, Ciudad, Pais) values
		(@Descripcion, @Nombre, @Direccion, @Telefono, @Email, @Baja, @CUIT, @Razon_social, @Ciudad, @Pais)

		set @Respuesta = SCOPE_IDENTITY()
	end
	else
		set @Mensaje = 'El numero de CUIT ingresado ya existe.'
end

-- Metodo EDITAR Proveedor (con Descripcion incluida)
create PROC SP_EDITARPROVEEDOR(
@Id_Proveedor int,
@Descripcion VARCHAR(150),
@Nombre varchar(50),
@Direccion varchar(100),
@Telefono VARCHAR(50),
@Email varchar(50),
@Baja bit,
@CUIT varchar(50),
@Razon_social varchar(50),
@Ciudad varchar(100),
@Pais varchar(100),
@Respuesta bit output,
@Mensaje varchar(500) output
)
as
begin
	set @Respuesta = 0
	set @Mensaje = ''

	if not exists(select * from Proveedor where CUIT = @CUIT and Id_Proveedor != @Id_Proveedor)
	begin
		UPDATE Proveedor set
		Descripcion = @Descripcion,
		Nombre = @Nombre, 
		Direccion = @Direccion, 
		Telefono = @Telefono, 
		Email = @Email, 
		Baja = @Baja,
		CUIT = @CUIT,
		Razon_social = @Razon_social,
		Ciudad = @Ciudad,
		Pais = @Pais
		where Id_Proveedor = @Id_Proveedor

		set @Respuesta = 1
		
	end
	else
		set @Mensaje = 'No se puede repetir el CUIT para m�s de un Proveedor'

end


-- Baja Proveedor
create PROC SP_BAJAProveedor(
@Id_Proveedor int,
@Respuesta bit output,
@Mensaje varchar(500) output
)
as
begin
	set @Respuesta = 0
	set @Mensaje = ''

	if EXISTS(select * from Proveedor where Id_Proveedor = @Id_Proveedor)
		BEGIN
			UPDATE Proveedor set 
			Baja = 1
			where Id_Proveedor = @Id_Proveedor

			set @Respuesta = 1 
			set @Mensaje = 'Se ejecuto con exito la baja del Proveedor.'
		END	
		ELSE
			SET @Mensaje = 'El ID del Proveedor no coindice con ningun otro ID';
end

go

-- Alta Proveedor
create PROC SP_ALTAProveedor(
@Id_Proveedor int,
@Respuesta bit output,
@Mensaje varchar(500) output
)
as
begin
	set @Respuesta = 0
	set @Mensaje = ''

	if EXISTS(select * from Proveedor where Id_Proveedor = @Id_Proveedor)
		BEGIN
			UPDATE Proveedor set 
			Baja = 0
			where Id_Proveedor = @Id_Proveedor

			set @Respuesta = 1 
			set @Mensaje = 'Se ejecuto con exito el alta del Proveedor.'
		END	
		ELSE
			SET @Mensaje = 'El ID del Proveedor no coindice con ningun otro ID';
end

/* PROCESOS PARA REGISTRAR UNA VENTA */

CREATE TYPE [dbo].[EDetalle_Venta] AS TABLE(
	[Id_producto] int NULL,
	[Precio_venta] decimal(10,2) NULL,
	[Cantidad] int NULL,
	[Subtotal] decimal(10,2) NULL
)


GO

create procedure usp_RegistrarVenta(
@IdUsuario int,
@Id_Factura int,
@Id_cliente int,
@Nro_Factura varchar(50),
@Monto_pago decimal(10,2),
@Monto_cambio decimal(10,2),
@Total decimal(10,2),
@DetalleVenta [EDetalle_Venta] READONLY,                                      
@Resultado bit output,
@Mensaje varchar(500) output
)
as
begin
	
	begin try

		declare @idventa int = 0
		set @Resultado = 1
		set @Mensaje = ''

		begin  transaction registro

		insert into VentaCabecera(Id_usuario,Id_Factura,Nro_Factura,Id_cliente,Monto_pago,Monto_cambio,Total)
		values(@IdUsuario,@Id_Factura,@Nro_Factura,@Id_cliente,@Monto_pago,@Monto_cambio,@Total)

		set @idventa = SCOPE_IDENTITY()

		insert into VentaDetalle(Id_venta,Id_producto,Precio_venta,Cantidad,Subtotal)
		select @idventa,Id_producto,Precio_venta,Cantidad,Subtotal from @DetalleVenta

		commit transaction registro

	end try
	begin catch
		set @Resultado = 0
		set @Mensaje = ERROR_MESSAGE()
		rollback transaction registro
	end catch

end


-- Auditorias de BackUps --
CREATE TABLE auditoria_backup (
    Id_auditoria INT IDENTITY(1,1) PRIMARY KEY,
    Fecha_backup DATETIME NOT NULL DEFAULT GETDATE(),
    Id_usuario INT NOT NULL,
    Estado INT NOT NULL,
    Ubicacion_backup VARCHAR(255) NULL
);

ALTER TABLE auditoria_backup
ADD CONSTRAINT FK_Usuario_Id_usuario
FOREIGN KEY (Id_usuario) REFERENCES Usuario(Id_usuario);

-- Procedimiento para realizar Back Up
create PROCEDURE sp_realizar_backup
    @Id_usuario INT,                   -- ID del usuario que realiza el backup
    @ruta_backup NVARCHAR(255),   
    @nombre_backup VARCHAR(255),        -- Nombre del archivo de backup
    @mensaje NVARCHAR(4000) OUTPUT,    -- Mensaje de salida (�xito o error)
    @Resultado BIT OUTPUT              -- Indicador de �xito (1: �xito, 0: error)
AS
BEGIN
    -- Inicializar el indicador de resultado
    SET @Resultado = 0;

    BEGIN TRY
        -- Declarar variable para el comando de backup
        DECLARE @comando_backup NVARCHAR(MAX);

        -- Construir el comando de backup
        SET @comando_backup = 'BACKUP DATABASE ' + QUOTENAME(DB_NAME()) +
                              ' TO DISK = ''' + @ruta_backup + '\' + @nombre_backup + '''';

        -- Ejecutar el comando de backup
        EXEC sp_executesql @comando_backup;

        -- Asignar mensaje de �xito al par�metro de salida
        SET @mensaje = 'Backup realizado exitosamente en: ' + @ruta_backup;

        -- Actualizar el indicador de resultado a 1 (�xito)
        SET @Resultado = 1;

        -- Insertar en la tabla de auditor�a
        DECLARE @ubicacion NVARCHAR(255) = @ruta_backup + '\' + @nombre_backup;  -- Ubicaci�n completa del backup

        -- Insertar los datos en la tabla de auditor�a
        INSERT INTO auditoria_backup (Id_usuario, Estado, ubicacion_backup, Fecha_backup)
        VALUES (@Id_usuario, 1, @ubicacion, GETDATE());

    END TRY
    BEGIN CATCH
        -- Manejo de errores
        -- Asignar mensaje de error al par�metro de salida
        SET @mensaje = 'Error al realizar el backup: ' + ERROR_MESSAGE();

        -- @Resultado se mantiene en 0 (fallo)
        -- Insertar los datos en la tabla de auditor�a con estado de error
        INSERT INTO auditoria_backup (Id_usuario, Estado, ubicacion_backup, Fecha_backup)
        VALUES (@Id_usuario, 0, 'Error - BackUp no generado', GETDATE());
    END CATCH
END;

-- Pruebas
BACKUP DATABASE DBLE_SOLEIL
TO DISK = 'C:\BackUps\DBLE_SOLEIL.bak';


---------------------------------- PROCEDIMIENTOS REPORTES ----------------------------------
USE DBLE_SOLEIL

-- Reporte Historial de Ventas
alter PROC sp_ReporteVentas(
@fechaInicio varchar(10),
@fechaFin varchar(10)
)
AS
BEGIN
SET DATEFORMAT dmy;
SELECT
convert(char(10), vc.FechaVenta,103)[FechaVenta], f.Tipo_Factura[TipoFactura], vc.Nro_Factura[NroFactura], vc.Total[MontoTotal],
u.Usuario[UsuarioRegistro],
c.DNI[DNICliente], c.Nombre[NombreCliente],
p.Codigo[CodigoProducto], p.Nombre[NombreProducto], ca.Nombre[Categoria], vd.Precio_venta[PrecioVenta], vd.Cantidad, vd.Subtotal
from VentaCabecera vc
inner join Usuario u on u.Id_usuario = vc.Id_usuario
inner join VentaDetalle vd on vd.Id_venta = vc.Id_venta
inner join Producto p on p.Id_producto = vd.Id_producto
inner join Categoria ca on ca.Id_Categoria = p.Id_Categoria
inner join Factura f on f.Id_Factura = vc.Id_Factura
inner join Cliente c on c.Id_cliente = vc.Id_cliente
where CONVERT (date, vc.FechaVenta) between @fechaInicio and @fechaFin
end

exec sp_ReporteVentas '01/11/2024', '20/11/2024'


-- Reporte de Ventas del Vendedor
alter PROC sp_ReporteVentasVendedor
(
    @fechaInicio VARCHAR(10),
    @fechaFin VARCHAR(10),
    @Id_usuario INT -- Nuevo par�metro para filtrar por usuario
)
AS
BEGIN
    SET DATEFORMAT dmy;

    SELECT
        CONVERT(CHAR(10), vc.FechaVenta, 103) AS [FechaVenta],
        f.Tipo_Factura AS [TipoFactura],
        vc.Nro_Factura AS [NroFactura],
        vc.Total[MontoTotal],
        c.DNI AS [DNICliente],
        c.Nombre AS [NombreCliente],
        p.Codigo AS [CodigoProducto],
        p.Nombre AS [NombreProducto],
        ca.Nombre AS [Categoria],
        vd.Precio_venta[PrecioVenta],
        vd.Cantidad,
        vd.Subtotal
    FROM VentaCabecera vc
    INNER JOIN Usuario u ON u.Id_usuario = vc.Id_usuario
    INNER JOIN VentaDetalle vd ON vd.Id_venta = vc.Id_venta
    INNER JOIN Producto p ON p.Id_producto = vd.Id_producto
    INNER JOIN Categoria ca ON ca.Id_Categoria = p.Id_Categoria
    INNER JOIN Factura f ON f.Id_Factura = vc.Id_Factura
    INNER JOIN Cliente c ON c.Id_cliente = vc.Id_cliente
    WHERE CONVERT(DATE, vc.FechaVenta) BETWEEN @fechaInicio AND @fechaFin
    AND vc.Id_usuario = @Id_usuario; -- Filtro por usuario
END;

--Prueba
select * from Usuario;

exec sp_ReporteVentasVendedor '18/10/2024', '21/11/2024', 8

-- Prueba 
exec sp_ReporteVentas '19/11/2024', '20/11/2024'



-- Reporte PRODUCTOS VENDIDOS, Cantidad y Total de Venta
alter PROC sp_ProductosVendidos
    @fechaInicio varchar(10),
    @fechaFin varchar(10)
AS
BEGIN
    SET DATEFORMAT dmy;

    SELECT 
        p.Nombre AS Producto, 
        SUM(vd.Cantidad) AS UnidadesVendidas, 
        SUM(vd.Cantidad * vd.Precio_venta) AS TotalVentas
    FROM VentaDetalle vd
    INNER JOIN Producto p ON p.Id_producto = vd.Id_producto
    INNER JOIN VentaCabecera vc ON vc.Id_venta = vd.Id_venta
    WHERE CONVERT(DATE, vc.FechaVenta) BETWEEN @fechaInicio AND @fechaFin
    GROUP BY p.Nombre
    ORDER BY UnidadesVendidas DESC; -- Ordenamos por la cantidad total vendida de mayor a menor
END

-- Prueba 
exec sp_ProductosVendidos '19/11/2024', '20/11/2024'