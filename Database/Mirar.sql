--TIPO DE DATO DETALLE DE COMPRA--
create type [dbo].[EDetalleCompra] as table (
	[IdProducto] int NULL,
	[PrecioCompra] decimal(18,2) NULL,
	[PrecioVenta] decimal(18,2) NULL,
	[Cantidad] int NULL,
	[MontoTotal] decimal(18,2) NULL
);

go

--PROCEDURE REGISTAR COMPRA--
create procedure SP_RegistrarCompra (
	@IdUsuario int,
	@IdProveedor int,
	@TipoDocumento nvarchar(500),
	@NumeroDocumento nvarchar(500),
	@MontoTotal decimal(18,2),
	@DetalleCompra [EDetalleCompra] readonly,
	@Resultado bit output,
	@Mensaje nvarchar(500) output
)
as
begin
	begin try

		declare @IdCompra int = 0
		set @Resultado = 1
		set @Mensaje = ''

		begin transaction registro

			insert into Compra(IdUsuario, IdProveedor, TipoDocumento,NumeroDocumento,MontoTotal)
			values (@IdUsuario, @IdProveedor, @TipoDocumento, @NumeroDocumento, @MontoTotal)

			set @IdCompra = SCOPE_IDENTITY()

			insert into DetalleCompra(IdCompra, IdProducto, PrecioCompra, PrecioVenta, Cantidad, MontoTotal)
			select @IdCompra, IdProducto, PrecioCompra, PrecioVenta, Cantidad, MontoTotal from @DetalleCompra

			update p set p.Stock = p.Stock + dc.Cantidad,
			p.PrecioCompra = dc.PrecioCompra,
			p.PrecioVenta = dc.PrecioVenta
			from Producto p
			inner join @DetalleCompra dc on dc.IdProducto = p.IdProducto

		commit transaction registro

	end try
	begin catch

		set @Resultado = 0
		set @Mensaje = ERROR_MESSAGE()

		rollback transaction registro

	end catch

end

go

--PROCEDURE EDITAR COMPRA--
create procedure SP_EditarCompra (
    @IdCompra int,
    @IdUsuario int,
    @IdProveedor int,
    @TipoDocumento nvarchar(500),
    @NumeroDocumento nvarchar(500),
    @MontoTotal decimal(18,2),
    @DetalleCompra [EDetalleCompra] readonly,
    @Resultado bit output,
    @Mensaje nvarchar(500) output
)
as
begin
    begin try
        set @Resultado = 1;
        set @Mensaje = '';

        begin transaction editar_compra;

        -- Eliminar detalles de compra existentes
        delete from DetalleCompra where IdCompra = @IdCompra;

        -- Actualizar la información de la compra
        update Compra
        set IdUsuario = @IdUsuario,
            IdProveedor = @IdProveedor,
            TipoDocumento = @TipoDocumento,
            NumeroDocumento = @NumeroDocumento,
            MontoTotal = @MontoTotal
        where IdCompra = @IdCompra;

        -- Insertar nuevos detalles de compra
        insert into DetalleCompra(IdCompra, IdProducto, PrecioCompra, PrecioVenta, Cantidad, MontoTotal)
        select @IdCompra, IdProducto, PrecioCompra, PrecioVenta, Cantidad, MontoTotal from @DetalleCompra;

        -- Actualizar el stock y precios de los productos
        update p
        set p.Stock = p.Stock - dc.Cantidad,
            p.PrecioCompra = dc.PrecioCompra,
            p.PrecioVenta = dc.PrecioVenta
        from Producto p
        inner join @DetalleCompra dc on dc.IdProducto = p.IdProducto;

        commit transaction editar_compra;
    end try
    begin catch
        set @Resultado = 0;
        set @Mensaje = ERROR_MESSAGE();
        rollback transaction editar_compra;
    end catch
end;

go

--PROCEDURE ELIMINAR COMPRA--
create procedure SP_EliminarCompra (
    @IdCompra int,
    @Resultado bit output,
    @Mensaje nvarchar(500) output
)
as
begin
    begin try
        set @Resultado = 1;
        set @Mensaje = '';

        begin TRANSACTION eliminar_compra;

        -- Obtener los detalles de la compra para actualizar el stock
        declare @DetalleCompra table (
            IdProducto int,
            Cantidad int
        );

        INSERT INTO @DetalleCompra (IdProducto, Cantidad)
        SELECT IdProducto, Cantidad from DetalleCompra where IdCompra = @IdCompra;

        -- Actualizar el stock de los productos
        update p
        set p.Stock = p.Stock - dc.Cantidad
        from Producto p
        inner join @DetalleCompra dc on dc.IdProducto = p.IdProducto;

        -- Eliminar detalles de la compra
        DELETE FROM DetalleCompra where IdCompra = @IdCompra;

        -- Eliminar la compra
        delete from Compra where IdCompra = @IdCompra;

        commit TRANSACTION eliminar_compra;
    end try
    begin catch
        set @Resultado = 0;
        set @Mensaje = ERROR_MESSAGE();
        rollback transaction eliminar_compra;
    end v
end;

GO

go

--TIPO DE DATO DETALLE DE VENTA--
create type [dbo].[EDetalleVenta] as table (
	[IdProducto] int NULL,
	[PrecioVenta] decimal(18,2) NULL,
	[Cantidad] int NULL,
	[SubTotal] decimal(18,2) NULL
);

go

--PROCEDURE REGISTRAR VENTA--
create procedure SP_RegistrarVenta (
	@IdUsuario int,
	@TipoDocumento nvarchar(500),
	@NumeroDocumento nvarchar(500),
	@DocumentoCliente nvarchar(500),
	@NombreCliente nvarchar(500),
	@MontoPago decimal(18,2),
	@MontoCambio decimal(18,2),
	@MontoTotal decimal(18,2),
	@DetalleVenta [EDetalleVenta] readonly,
	@Resultado bit output,
	@Mensaje nvarchar(500) output
)
as
begin
	begin try
		declare @IdVenta int = 0
		set @Resultado = 1
		set @Mensaje = ''

		begin transaction registro

			insert into Venta(IdUsuario, TipoDocumento, NumeroDocumento, DocumentoCliente, NombreCliente, MontoPago, MontoCambio, MontoTotal)
			values (@IdUsuario, @TipoDocumento, @NumeroDocumento, @DocumentoCliente, @NombreCliente, @MontoPago, @MontoCambio, @MontoTotal)

			set @IdVenta = SCOPE_IDENTITY()

			insert into DetalleVenta(IdVenta, IdProducto, PrecioVenta, Cantidad, SubTotal)
			select @IdVenta, IdProducto, PrecioVenta, Cantidad, SubTotal from @DetalleVenta

		commit transaction registro
		
	end try
	begin catch
			set @Resultado = 0
			set @Mensaje = ERROR_MESSAGE()
			rollback transaction registro
	end catch
end

--PROCEDURE EDITAR VENTA--
create procedure SP_EditarVenta (
    @IdVenta int,
    @IdUsuario int,
    @TipoDocumento nvarchar(500),
    @NumeroDocumento nvarchar(500),
    @DocumentoCliente nvarchar(500),
    @NombreCliente nvarchar(500),
    @MontoPago decimal(18,2),
    @MontoCambio decimal(18,2),
    @MontoTotal decimal(18,2),
    @DetalleVenta [EDetalleVenta] readonly,
    @Resultado bit output,
    @Mensaje nvarchar(500) output
)
as
begin
    begin try
        set @Resultado = 1;
        set @Mensaje = '';

        begin transaction editar_venta;

        -- Eliminar detalles de venta existentes
        delete from DetalleVenta where IdVenta = @IdVenta;

        -- Actualizar la información de la venta
        update Venta
        set IdUsuario = @IdUsuario,
            TipoDocumento = @TipoDocumento,
            NumeroDocumento = @NumeroDocumento,
            DocumentoCliente = @DocumentoCliente,
            NombreCliente = @NombreCliente,
            MontoPago = @MontoPago,
            MontoCambio = @MontoCambio,
            MontoTotal = @MontoTotal
        where IdVenta = @IdVenta;

        -- Insertar nuevos detalles de venta
        insert into DetalleVenta(IdVenta, IdProducto, PrecioVenta, Cantidad, SubTotal)
        select @IdVenta, IdProducto, PrecioVenta, Cantidad, SubTotal from @DetalleVenta;

        commit transaction editar_venta;
    end try
    begin catch
        set @Resultado = 0;
        set @Mensaje = ERROR_MESSAGE();
        rollback transaction editar_venta;
    end catch
end;

GO

--PROCEDURE ELIMINAR VENTA--
create procedure SP_EliminarVenta (
    @IdVenta int,
    @Resultado bit output,
    @Mensaje nvarchar(500) output
)
as
BEGIN
    begin try
        set @Resultado = 1;
        set @Mensaje = '';

        begin transaction eliminar_venta;

        -- Eliminar detalles de la venta
        delete from DetalleVenta where IdVenta = @IdVenta;

        -- Eliminar la venta
        delete from Venta where IdVenta = @IdVenta;

        commit transaction eliminar_venta;
    end TRY
    begin catch
        set @Resultado = 0;
        set @Mensaje = ERROR_MESSAGE();
        rollback transaction eliminar_venta;
    end catch
end;

GO