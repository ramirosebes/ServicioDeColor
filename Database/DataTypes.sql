use DB_SDC

go

--TIPO DE DATO LISTA DE COMPONENTES--
create type [dbo].[EListaComponentes] as table(
	[IdComponente] int null
)
go

--TIPO DE DATO DETALLE DE COMPRA--
create type [dbo].[EDetalleCompra] as table (
	[IdProducto] int NULL,
	[PrecioCompra] decimal(18,2) NULL,
	[PrecioVenta] decimal(18,2) NULL,
	[Cantidad] int NULL,
	[MontoTotal] decimal(18,2) NULL
);

go

--TIPO DE DATO DETALLE DE VENTA--
create type [dbo].[EDetalleVenta] as table (
	[IdProducto] int NULL,
	[PrecioVenta] decimal(18,2) NULL,
	[Cantidad] int NULL,
	[SubTotal] decimal(18,2) NULL
);