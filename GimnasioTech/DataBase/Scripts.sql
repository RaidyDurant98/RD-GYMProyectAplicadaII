create table Clientes(
ClienteId int identity(1,1) primary key,
Nombres varchar(80),
Sexo varchar(100),
FechaInscripcion date,
Direccion varchar(255),
NumeroCelular varchar(12),
Email varchar(255)
);

create table Productos(
ProductoId int identity(1,1) primary key,
Descripcion varchar(250),
Cantidad decimal,
Costo decimal,
Precio decimal,
FechaIngreso date,
FechaVencimiento date
);

create table Usuarios(
UsuarioId int identity(1,1) primary key,
Nombres varchar(80),
NombreUsuario varchar(80),
Clave varchar(40),
ConfirmarClave varchar(40),
Cargo varchar(60)
);

create table Facturas(
FacturaId int identity(1,1) primary key,
NombreCliente varchar(80),
Fecha date,
Monto decimal,
Devuelta decimal,
DineroPagado decimal,
ProductoId int
);

create table FacturasProductos(
Id int identity(1,1) primary key,
ProductoId int,
FacturaId int,
Cantidad decimal,
Precio decimal,
Descripcion varchar(255) 
);