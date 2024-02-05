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

go