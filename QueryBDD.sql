CREATE DATABASE DBLE_SOLEIL

USE DBLE_SOLEIL

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
  Sexo VARCHAR(50),
  Fecha_nacimiento DATE,
  Correo VARCHAR(100),
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

-- Nuevas Columnas a Tabla Usuario
ALTER TABLE Usuario
ADD 
    Direccion VARCHAR(100),
    Telefono INT;

ALTER TABLE Usuario
ADD 
    DNI VARCHAR(100),
    Sexo VARCHAR(50),
	Fecha_nacimiento DATE;


ALTER TABLE Usuario
ALTER COLUMN Telefono VARCHAR(20);

-- Lote de Datos
-- Primer Usuario

SELECT * from Usuario

select * from Perfil

select * from Permiso

-- Creacion de Perfiles
insert into Perfil (NombreRol, Descripcion) values ('ADMINISTRADOR', 'Este usuario administrador tiene los permisos necesarios para ingresar a todas las funcionalidades')
insert into Perfil (NombreRol, Descripcion) values ('VENDEDOR', 'Este usuario administrador tiene los permisos necesarios para manejar ventas y clientes')
insert into Perfil (NombreRol, Descripcion) values ('REPOSITOR', 'Este usuario repositor tiene los permisos necesarios para gestionar los productos')

-- Primer Usuario Admin
insert into Usuario(Nombre, Apellido, Usuario, Contraseña, DNI, Fecha_nacimiento, Correo, Baja, Perfil_id, Direccion, Telefono) 
values ('Lara','Valetto','Lara','admin','45374333','2003-11-26','lvaletto21@gmail.com',0,2,'Junin 25', '3794995322')

-- Modificar usuario
UPDATE Usuario
SET Perfil_id = 1
WHERE Id_usuario = 2;

-- Insertar nuevos valores
UPDATE Usuario
SET DNI = '43205306',
    Sexo = 'Masculino',
    Fecha_nacimiento = '2000-12-24'
WHERE Id_usuario = 2;

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
    Sexo = 'Masculino',
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

-- Select de Perfiles
select p.Perfil_id,p.Nombre from Permiso p 
inner join Perfil r on r.Perfil_id = p.Perfil_id
inner join Usuario u on u.Perfil_id = r.Perfil_id
where u.Id_usuario = 2

-- Select de Usuarios
select u.Id_Usuario, u.Nombre, u.Apellido, u.Contraseña, u.Baja, u.Usuario, u.Direccion, u.Telefono, u.DNI, u.Sexo, u.Fecha_nacimiento, r.Perfil_id, r.Nombre from Usuario u
inner join Perfil r on r.Perfil_id = u.Perfil_id

-- Procedimientos 
create PROC SP_REGISTRARUSUARIO(
@Documento varchar(50),
@NombreCompleto varchar(100),
@Correo varchar(100),
@Clave varchar(100),
@IdRol int,
@Estado bit,
@IdUsuarioResultado int output,
@Mensaje varchar(500) output
)
as
begin
	set @IdUsuarioResultado = 0
	set @Mensaje = ''


	if not exists(select * from USUARIO where Documento = @Documento)
	begin
		insert into usuario(Documento,NombreCompleto,Correo,Clave,IdRol,Estado) values
		(@Documento,@NombreCompleto,@Correo,@Clave,@IdRol,@Estado)

		set @IdUsuarioResultado = SCOPE_IDENTITY()
		
	end
	else
		set @Mensaje = 'No se puede repetir el documento para más de un usuario'

end