--TABLA PERSONA--
create table Persona (
	IdPersona int primary key identity,
	NombreCompleto nvarchar(100),
	Correo nvarchar(100),
	Documento nvarchar(50)
);
go

/*--------MODULO DE SEGURIDAD--------*/
--TABLA USUARIO--
create table Usuario(
IdUsuario int primary key identity,
IdPersona int,
Clave nvarchar(500),
Estado bit,
foreign key (IdPersona) references Persona(IdPersona)
)
go

--TABLA COMPONENTE--
create table Componente(
IdComponente int primary key identity,
Nombre nvarchar(50),
TipoComponente nvarchar(50),
Estado bit
)
go

--TABLA PERMISO (HEREDA DE COMPONENTE)--
create table Permiso(
IdPermiso int primary key identity,
IdComponente int,
NombreMenu nvarchar(100) not null,
foreign key (IdComponente) references Componente(IdComponente)
)
go

--TABLA GRUPOPERMISO (HEREDA DE COMPONENTE)--
create table GrupoPermiso(
IdGrupoPermiso int primary key identity,
IdComponente int,
NombreGrupo nvarchar(100)
foreign key (IdComponente) references Componente(IdComponente)
)
go

--TABLA USUARIOCOMPONENTE (RELACION MUCHOS A MUCHOS ENTRE USUARIO Y COMPONENTE)--
create table UsuarioComponente(
IdUsuario int,
IdComponente int,
primary key (IdUsuario,IdComponente),
foreign key (IdUsuario) references Usuario(IdUsuario),
foreign key (IdComponente) references Componente(IdComponente),
)
go

--TABLA GRUPOPERMISOCOMPONENTE (RELACION MUCHOS A MUCHOS ENTRE GRUPOPERMISO Y COMPONENTE)--
create table GrupoPermisoComponente(
IdGrupoPermiso int,
IdComponente int,
primary key (IdGrupoPermiso,IdComponente),
foreign key (IdGrupoPermiso) references GrupoPermiso(IdGrupoPermiso),
foreign key (IdComponente) references Componente(IdComponente),
)
go
/*-------- CIERRE MODULO DE SEGURIDAD--------*/

--TABLA CLIENTE--
create table Cliente (
	IdCliente int primary key identity,
	IdPersona int,
	Telefono nvarchar(50),
	--Direccion nvarchar(100),
	--Localidad nvarchar (50),
	Estado bit,
	foreign key (IdPersona) references Persona(IdPersona)
);
go

--TABLA PROVEEDOR--
create table Proveedor (
	IdProveedor int primary key identity,
	CUIT nvarchar(50),
	RazonSocial nvarchar(50),
	Correo nvarchar(50),
	Telefono nvarchar(50),
	Estado bit not null default 1,
);
go

--TABLA CATEGORIA--
create table Categoria (
	IdCategoria int primary key identity,
	Descripcion nvarchar(100),
	Estado bit not null default 1,
	FechaRegistro datetime default getdate(),
);
go

--TABLA PRODUCTO--
create table Producto (
	IdProducto int primary key identity,
	Codigo nvarchar(50),
	Nombre nvarchar(50),
	Descripcion nvarchar(50),
	IdCategoria int references Categoria(IdCategoria),
	Stock int not null default 0,
	PrecioCompra decimal(10,2) default 0,
	PrecioVenta decimal(10,2) default 0,
	Estado bit not null default 1,
	FechaRegistro datetime default getdate(),
);
go

--TABLA COMPRA--
create table Compra (
	IdCompra int primary key identity,
	IdUsuario int references Usuario(IdUsuario),
	IdProveedor int references Proveedor(idProveedor),
	TipoDocumento nvarchar(50),
	NumeroDocumento nvarchar(50),
	MontoTotal decimal (10,2),
	FechaRegistro datetime default getdate(),
);
go

--TABLA DETALLE DE COMPRA--
create table DetalleCompra (
	IdDetalleCompra int primary key identity,
	IdCompra int references Compra(idCompra),
	IdProducto int references Producto(idProducto),
	PrecioCompra decimal(10,2) default 0,
	PrecioVenta decimal(10,2) default 0,
	Cantidad int,
	MontoTotal decimal(10,2),
	FechaRegistro datetime default getdate(),
);
go

--TABLA VENTA--
create table Venta (
	IdVenta int primary key identity,
	IdUsuario int references Usuario(IdUsuario),
	IdCliente int references Cliente (IdCliente),
	TipoDocumento nvarchar(50),
	NumeroDocumento nvarchar(50),
	TipoDescuento nvarchar(50),
	Descuento decimal(10, 2),
	MontoPago decimal(10,2),
	MontoCambio decimal (10,2),
	MontoTotal decimal (10,2),
	FechaRegistro datetime default getdate(),
);
go

--TABLA DETALLE DE VENTA--
create table DetalleVenta (
	IdDetalleVenta int primary key identity,
	IdVenta int references Venta(idVenta),
	IdProducto int references Producto(idProducto),
	PrecioVenta decimal(10,2) default 0,
	Cantidad int,
	SubTotal decimal(10,2),
	FechaRegistro datetime default getdate(),
);

--TABLA NEGOCIO--
create table Negocio (
	IdNegocio int primary key,
	Nombre nvarchar(50),
	RUC nvarchar(50),
	Direccion nvarchar(50),
	Logo varbinary(max) NULL,
);