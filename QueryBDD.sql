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
  Contraseña VARCHAR(50) NOT NULL,
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

---------------------------------- LOTE DE DATOS ----------------------------------
-- Selects
SELECT * from Usuario
SELECT * from Perfil
SELECT * from Permiso
SELECT * from Categoria
SELECT * from Producto

-- Creacion de Perfiles
insert into Perfil (NombreRol, Descripcion) values ('ADMINISTRADOR', 'Este usuario administrador tiene los permisos necesarios para ingresar a todas las funcionalidades')
insert into Perfil (NombreRol, Descripcion) values ('VENDEDOR', 'Este usuario administrador tiene los permisos necesarios para manejar ventas y clientes')
insert into Perfil (NombreRol, Descripcion) values ('REPOSITOR', 'Este usuario repositor tiene los permisos necesarios para gestionar los productos')

-- Primer Usuario Admin
insert into Usuario(Nombre, Apellido, Usuario, Contraseña, DNI, Fecha_nacimiento, Correo, Baja, Perfil_id, Direccion, Telefono) 
values ('Lara','Valetto','Lara','admin','45374333','2003-11-26','lvaletto21@gmail.com',0,2,'Junin 25', '3794995322')

-- Modificar usuario
UPDATE Usuario
SET Baja = 0
WHERE Id_usuario = 3;

-- Insertar nuevos valores
UPDATE Usuario
SET	Correo = 'juanperez@hotmail.com'
WHERE Id_usuario = 4;

-- Primer Usuario Vendedor
insert into Usuario(Nombre, Apellido, Usuario, Contraseña, DNI, Fecha_nacimiento, Correo, Baja, Perfil_id, Direccion, Telefono) 
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
select u.Id_Usuario, u.Nombre, u.Apellido, u.Contraseña, u.Baja, u.Usuario, u.Direccion, u.Telefono, u.DNI, u.Fecha_nacimiento, u.Correo, r.Perfil_id, r.NombreRol from Usuario u
inner join Perfil r on r.Perfil_id = u.Perfil_id

-- Select de Proveedores
select Id_Proveedor, Descripcion, Nombre, Direccion, Telefono, Email, Baja, CUIT, Razon_social, Ciudad, Pais from Proveedor

---------------------------------- PROCEDIMIENTOS ----------------------------------
create PROC SP_REGISTRARUSUARIO(
@DNI varchar(100),
@Nombre varchar(50),
@Apellido varchar(50),
@Usuario varchar(50),
@Correo varchar(100),
@Contraseña varchar(50),
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
		insert into Usuario(DNI, Nombre, Apellido, Usuario, Correo, Contraseña, Fecha_nacimiento, Direccion, Telefono, Perfil_id, Baja) values
		(@DNI, @Nombre, @Apellido, @Usuario, @Correo, @Contraseña, @Fecha_nacimiento, @Direccion, @Telefono, @Perfil_id, @Baja)

		set @IdUsuarioResultado = SCOPE_IDENTITY()
		
	end
	else
		set @Mensaje = 'No se puede repetir el DNI para más de un usuario'

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
@Contraseña varchar(50),
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
		Contraseña = @Contraseña, 
		Fecha_nacimiento = @Fecha_nacimiento, 
		Direccion = @Direccion, 
		Telefono = @Telefono, 
		Perfil_id = @Perfil_id, 
		Baja = @Baja
		where Id_usuario = @Id_usuario

		set @Respuesta = 1
		
	end
	else
		set @Mensaje = 'No se puede repetir el DNI para más de un usuario'

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
SELECT Id_Producto, Codigo, Nombre, Descripcion, Precio_compra, Precio_venta, Stock, Stock_minimo, Imagen, Baja from Producto

create PROC SP_REGISTRARPRODUCTO(
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
		values (@Codigo, @Nombre, @Descripcion, @Id_Categoria, @Precio_compra, @Precio_venta, @stock, @Stock_min, @Imagen, @Baja)

		set @IdProductoResultado = SCOPE_IDENTITY()
	end
	ELSE 
	SET @Mensaje = 'Ya existe un producto con el mismo codigo'
end

go

create procedure SP_EDITARPRODUCTO(
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
create PROC SP_REGISTRARCLIENTE(
@DNI varchar(50),
@Nombre varchar(50),
@Apellido varchar(50),
@Direccion varchar(100),
@Telefono VARCHAR(50),
@Email varchar(50),
@Fecha_nacimiento DATE,
@Baja bit,
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
		insert into Cliente(DNI, Nombre, Apellido, Direccion, Telefono, Email, Fecha_nacimiento, Baja) values
		(@DNI, @Nombre, @Apellido, @Direccion, @Telefono, @Email, @Fecha_nacimiento, @Baja)

		set @Respuesta = SCOPE_IDENTITY()
	end
	else
		set @Mensaje = 'El numero de documento ingresado ya existe.'
end

go

-- Editar cliente
create PROC SP_EDITARCLIENTE(
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
	set @Respuesta = 0
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


-- Registrar Proveedor
create PROC SP_REGISTRARPROVEEDOR(
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
		insert into Proveedor(Nombre, Direccion, Telefono, Email, Baja, CUIT, Razon_social, Ciudad, Pais) values
		(@Nombre, @Direccion, @Telefono, @Email, @Baja, @CUIT, @Razon_social, @Ciudad, @Pais)

		set @Respuesta = SCOPE_IDENTITY()
	end
	else
		set @Mensaje = 'El numero de CUIT ingresado ya existe.'
end

-- Eliminar metodo registrar
DROP PROCEDURE IF EXISTS SP_REGISTRARPROVEEDOR;

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

-- Editar Proveedor
create PROC SP_EDITARPROVEEDOR(
@Id_Proveedor int,
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
		set @Mensaje = 'No se puede repetir el CUIT para más de un Proveedor'

end

-- Eliminar Metodo Editar
DROP PROCEDURE IF EXISTS SP_EDITARPROVEEDOR;

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
		set @Mensaje = 'No se puede repetir el CUIT para más de un Proveedor'

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

