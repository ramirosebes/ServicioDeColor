--PROCEDURE REGISTRAR COMPRA--
create procedure SP_RegistrarCompra (
    @IdUsuario int,
    @IdProveedor int,
    @TipoDocumento nvarchar(50),
    @NumeroDocumento nvarchar(50),
    @MontoTotal decimal(18,2),
    @DetalleCompra [EDetalleCompra] readonly,
    @Resultado bit output,
    @Mensaje nvarchar(500) output
)
as
begin
    begin try

        declare @IdCompra int = 0
		declare @IdAuditoriaCompra int = 0
        set @Resultado = 1
        set @Mensaje = ''

        begin transaction registro

            -- Registrar la compra
            insert into Compra(IdUsuario, IdProveedor, TipoDocumento,NumeroDocumento,MontoTotal)
			values (@IdUsuario, @IdProveedor, @TipoDocumento, @NumeroDocumento, @MontoTotal)

            -- Obtener el IdCompra recién insertado
            set @IdCompra = SCOPE_IDENTITY()

            -- Insertar datos en la tabla de AuditoriaCompra
            insert into AuditoriaCompra (
                IdUsuarioAuditoria,
                DescripcionAuditoria,
                FechaAuditoria,
                IdCompra,
                IdUsuario,
                IdProveedor,
                TipoDocumento,
                NumeroDocumento,
                MontoTotal,
                FechaRegistro
            )
            values (
                @IdUsuario,
                'Se registró una compra',
                GETDATE(),
                @IdCompra,
                @IdUsuario,
                @IdProveedor,
                @TipoDocumento,
                @NumeroDocumento,
                @MontoTotal,
                GETDATE()
            )

			set @IdAuditoriaCompra = SCOPE_IDENTITY()

            -- Insertar detalles de compra y actualizar stock
            insert into DetalleCompra(IdCompra, IdProducto, PrecioCompra, PrecioVenta, Cantidad, MontoTotal)
			select @IdCompra, IdProducto, PrecioCompra, PrecioVenta, Cantidad, MontoTotal from @DetalleCompra

            -- Actualizar stock de productos
            update p set p.Stock = p.Stock + dc.Cantidad,
			p.PrecioCompra = dc.PrecioCompra,
			p.PrecioVenta = dc.PrecioVenta
			from Producto p
			inner join @DetalleCompra dc on dc.IdProducto = p.IdProducto

            -- Insertar datos en la tabla de AuditoriaDetalleCompra
            insert into AuditoriaDetalleCompra (
                IdAuditoriaCompra,
				DescripcionAuditoria,
                IdProducto,
                PrecioCompra,
                PrecioVenta,
                Cantidad,
                MontoTotal,
                FechaRegistro,
                FechaAuditoria
            )
            select
                @IdAuditoriaCompra,
				'Se registró un detalle de compra',
                dc.IdProducto,
                dc.PrecioCompra,
                dc.PrecioVenta,
                dc.Cantidad,
                dc.MontoTotal,
                GETDATE(),
                GETDATE()
            from @DetalleCompra dc

        commit transaction registro

    end try
    begin catch

        set @Resultado = 0
        set @Mensaje = ERROR_MESSAGE()

        rollback transaction registro

    end catch
end

go

--PROCEDURE ELIMINAR COMPRA--
create procedure SP_EliminarCompra (
    @IdCompra int,
	@IdUsuarioAuditoria int,
    @Resultado bit output,
    @Mensaje nvarchar(500) output
)
as
begin
    begin try

		declare @IdAuditoriaCompra int = 0
        set @Resultado = 1;
        set @Mensaje = '';

        begin TRANSACTION eliminar_compra;

        -- Obtener los detalles de la compra para actualizar el stock
        declare @DetalleCompra table (
            IdDetalleCompra int,
            IdProducto int,
            PrecioCompra decimal(10,2),
            PrecioVenta decimal(10,2),
            Cantidad int,
            MontoTotal decimal(10,2),
            FechaRegistro datetime
        );

        INSERT INTO @DetalleCompra (IdDetalleCompra, IdProducto, PrecioCompra, PrecioVenta, Cantidad, MontoTotal, FechaRegistro)
        SELECT IdDetalleCompra, IdProducto, PrecioCompra, PrecioVenta, Cantidad, MontoTotal, FechaRegistro
        from DetalleCompra where IdCompra = @IdCompra;


        -- Actualizar el stock de los productos
        update p
        set p.Stock = p.Stock - dc.Cantidad
        from Producto p
        inner join @DetalleCompra dc on dc.IdProducto = p.IdProducto;

		-- Insertar datos en la tabla de AuditoriaCompra
        insert into AuditoriaCompra (
            IdUsuarioAuditoria,
            DescripcionAuditoria,
            FechaAuditoria,
            IdCompra,
            IdUsuario,
            IdProveedor,
            TipoDocumento,
            NumeroDocumento,
            MontoTotal,
            FechaRegistro
        )
        select
            @IdUsuarioAuditoria,
            'Se eliminó una compra',
            GETDATE(),
            @IdCompra,
            c.IdUsuario,
            c.IdProveedor,
            c.TipoDocumento,
            c.NumeroDocumento,
            c.MontoTotal,
            c.FechaRegistro
        from Compra c
        where c.IdCompra = @IdCompra;

		set @IdAuditoriaCompra = SCOPE_IDENTITY()

		-- Insertar datos en la tabla de AuditoriaDetalleCompra
            insert into AuditoriaDetalleCompra (
                IdAuditoriaCompra,
				DescripcionAuditoria,
                IdProducto,
                PrecioCompra,
                PrecioVenta,
                Cantidad,
                MontoTotal,
                FechaRegistro,
                FechaAuditoria
            )
            select
                @IdAuditoriaCompra,
				'Se eliminó un detalle de compra',
                dc.IdProducto,
                dc.PrecioCompra,
                dc.PrecioVenta,
                dc.Cantidad,
                dc.MontoTotal,
                dc.FechaRegistro,
                GETDATE()
            from @DetalleCompra dc		

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
    end catch
end;

--PROCEDURE REGISTRAR VENTA--
create procedure SP_RegistrarVenta (
    @IdUsuario int,
    @IdCliente int,
    @TipoDocumento nvarchar(50),
    @NumeroDocumento nvarchar(50),
    @TipoDescuento nvarchar(50),
    @MontoDescuento decimal (10,2),
    @MontoPago decimal(10,2),
    @MontoCambio decimal(10,2),
    @SubTotal decimal (10,2),
    @MontoTotal decimal(10,2),
    @DetalleVenta [EDetalleVenta] readonly,
    @Resultado bit output,
    @Mensaje nvarchar(500) output
)
as
begin
    begin try
        declare @IdVenta int = 0
        declare @IdAuditoriaVenta int = 0
        set @Resultado = 1
        set @Mensaje = ''

        begin transaction registro

            -- Registrar la venta
            insert into Venta(IdUsuario, IdCliente,TipoDocumento, NumeroDocumento, MontoPago, MontoCambio, SubTotal, MontoTotal, TipoDescuento, MontoDescuento)
            values (@IdUsuario, @IdCliente, @TipoDocumento, @NumeroDocumento, @MontoPago, @MontoCambio, @SubTotal, @MontoTotal, @TipoDescuento, @MontoDescuento)

            -- Obtener el IdVenta recién insertado
            set @IdVenta = SCOPE_IDENTITY()

            -- Insertar datos en la tabla de AuditoriaVenta
            insert into AuditoriaVenta (
                IdUsuarioAuditoria,
                DescripcionAuditoria,
                FechaAuditoria,
                IdVenta,
                IdUsuario,
                IdCliente,
                TipoDocumento,
                NumeroDocumento,
				TipoDescuento,
                MontoDescuento,
                SubTotal,
                MontoPago,
                MontoCambio,
                MontoTotal,
                FechaRegistro
            )
            values (
                @IdUsuario,
                'Se registró una venta',
                GETDATE(),
                @IdVenta,
                @IdUsuario,
                @IdCliente,
                @TipoDocumento,
                @NumeroDocumento,
				@TipoDescuento,
                @MontoDescuento,
                @SubTotal,
                @MontoPago,
                @MontoCambio,
                @MontoTotal,
                GETDATE()
            )

            set @IdAuditoriaVenta = SCOPE_IDENTITY()

            -- Insertar detalles de venta
            insert into DetalleVenta(IdVenta, IdProducto, PrecioVenta, Cantidad, SubTotal)
            select @IdVenta, IdProducto, PrecioVenta, Cantidad, SubTotal from @DetalleVenta

            -- Insertar datos en la tabla de AuditoriaDetalleVenta
            insert into AuditoriaDetalleVenta (
                IdAuditoriaVenta,
                DescripcionAuditoria,
                IdProducto,
                PrecioVenta,
                Cantidad,
                SubTotal,
                FechaRegistro,
                FechaAuditoria
            )
            select
                @IdAuditoriaVenta,
                'Se registró un detalle de venta',
                dv.IdProducto,
                dv.PrecioVenta,
                dv.Cantidad,
                dv.SubTotal,
                GETDATE(),
                GETDATE()
            from @DetalleVenta dv

        commit transaction registro
        
    end try
    begin catch
            set @Resultado = 0
            set @Mensaje = ERROR_MESSAGE()
            rollback transaction registro
    end catch
end

--PROCEDURE ELIMINAR VENTA--
create procedure SP_EliminarVenta (
	@IdVenta int,
	@IdUsuarioAuditoria int,
    @Resultado bit output,
    @Mensaje nvarchar(500) output
)
as
begin
    begin try

		declare @IdAuditoriaVenta int = 0
        set @Resultado = 1;
        set @Mensaje = '';

        begin transaction eliminar_venta;

        -- Guardar los detalles de la venta que se eliminará
        declare @DetallesVenta table (
			IdDetalleVenta int,
            IdProducto int,
            Cantidad int,
			PrecioVenta decimal (10,2),
			SubTotal decimal (10,2),
			FechaRegistro datetime
        );

        -- Insertar los detalles de la venta en la tabla temporal
        insert into @DetallesVenta (IdDetalleVenta, IdProducto, Cantidad, PrecioVenta, SubTotal, FechaRegistro)
        select IdDetalleVenta, IdProducto, Cantidad, PrecioVenta, SubTotal, FechaRegistro
        from DetalleVenta
        where IdVenta = @IdVenta;

		-- Restaurar el stock de productos
        update Producto
        set Stock = Stock + DV.Cantidad
        from Producto P
        inner join @DetallesVenta DV on P.IdProducto = DV.IdProducto;

		insert into AuditoriaVenta (
            IdUsuarioAuditoria,
            DescripcionAuditoria,
            FechaAuditoria,
            IdVenta,
            IdUsuario,
            IdCliente,
            TipoDocumento,
            NumeroDocumento,
			TipoDescuento,
            MontoDescuento,
            SubTotal,
            MontoPago,
            MontoCambio,
            MontoTotal,
            FechaRegistro
        )
        select
            @IdUsuarioAuditoria,
            'Se eliminó una venta',
            GETDATE(),
            @IdVenta,
            V.IdUsuario,
            V.IdCliente,
            V.TipoDocumento,
            V.NumeroDocumento,
			V.TipoDescuento,
            V.MontoDescuento,
            V.SubTotal,
            V.MontoPago,
            V.MontoCambio,
            V.MontoTotal,
            V.FechaRegistro
        from Venta V
        where V.IdVenta = @IdVenta;

        set @IdAuditoriaVenta = SCOPE_IDENTITY()

		-- Insertar datos en la tabla de AuditoriaDetalleVenta
        insert into AuditoriaDetalleVenta (
            IdAuditoriaVenta,
            DescripcionAuditoria,
            IdProducto,
            PrecioVenta,
            Cantidad,
            SubTotal,
            FechaRegistro,
            FechaAuditoria
        )
        select
            @IdAuditoriaVenta,
            'Se eliminó un detalle de venta',
            dv.IdProducto,
            dv.PrecioVenta,
            dv.Cantidad,
            dv.SubTotal,
            dv.FechaRegistro,
            GETDATE()
        from @DetallesVenta dv

        -- Eliminar detalles de la venta
        delete from DetalleVenta where IdVenta = @IdVenta;

        -- Eliminar la venta
        delete from Venta where IdVenta = @IdVenta;   

        commit transaction eliminar_venta;
    end try
    begin catch
        set @Resultado = 0;
        set @Mensaje = ERROR_MESSAGE();
        rollback transaction eliminar_venta;
    end catch
end;