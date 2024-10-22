--PROCEDURE REGISTRAR USUARIO--
create procedure SP_RegistrarUsuario (
	@NombreCompleto nvarchar(100),
	@Correo nvarchar(100),
	@Documento nvarchar(50),
	@Clave nvarchar(500),
	@Estado bit,
	@Mensaje nvarchar(500) output,
	@IdUsuarioRegistrado int output
)
as
begin
	begin try
		set @IdUsuarioRegistrado = 0
		set @Mensaje = ''
		declare @IdPersona int = 0

		begin transaction registro
		
			if exists (
				select * 
				from Persona
				where Documento = @Documento
			)
			begin
				select @IdPersona = IdPersona
				from Persona
				where Documento = @Documento

				if not exists (
					select *
					from Usuario
					where IdPersona = @IdPersona
				)
				begin
					update Persona
					set NombreCompleto = @NombreCompleto,
						Correo = @Correo
					where Documento = @Documento
				
					insert into Usuario(IdPersona,Clave,Estado) values
					(@IdPersona,@Clave,@Estado)				

					set @IdUsuarioRegistrado = SCOPE_IDENTITY()
				end
				else
				begin
					set @Mensaje = 'Ya existe un usuario con ese n�mero de documento'
				end
			end
			else
			begin
				insert into Persona(NombreCompleto,Correo,Documento) values
				(@NombreCompleto,@Correo,@Documento)

				set @IdPersona = SCOPE_IDENTITY()

				if (@IdPersona != 0)
				begin
					insert into Usuario(IdPersona,Clave,Estado) values
					(@IdPersona,@Clave,@Estado)

					set @IdUsuarioRegistrado = SCOPE_IDENTITY()
				end
			end
		commit transaction registro
	end try
	begin catch
		set @Mensaje = ERROR_MESSAGE()
		rollback transaction registro
	end catch
end

go

--PROCEDURE EDITAR USUARIO--
create procedure SP_EditarUsuario (
	@IdUsuario int,
	@IdPersona int,
	@NombreCompleto nvarchar(100),
	@Correo nvarchar(100),
	@Documento nvarchar(100),
	@Estado bit,
	@Mensaje nvarchar(400) output,
	@Resultado bit output
)
as
begin
    begin try
        set @Resultado = 0;
        set @Mensaje = '';

        begin transaction editar;

        if not exists (
                select *
                from Usuario
                         inner join Persona on Usuario.IdPersona = Persona.IdPersona
                where Persona.Documento = @Documento and IdUsuario != @IdUsuario
        )
        begin
            update Persona set
                NombreCompleto = @NombreCompleto,
                Correo = @Correo,
                Documento = @Documento
            where IdPersona = @IdPersona;

            update Usuario set
                Estado = @Estado
            where IdUsuario = @IdUsuario;

            set @Resultado = 1;
        end
		else
		begin
			set @Mensaje = 'Ya existe un usuario con ese numero de documento'
		end

        commit transaction editar;
    end try
    begin catch
        set @Mensaje = 'Error: ' + ERROR_MESSAGE() + ' (' + CAST(ERROR_NUMBER() AS NVARCHAR) + ')';
        rollback transaction editar;
    end catch
end;

go

--PROCEDURE RESTABLECER CLAVE--
create procedure SP_RestablecerClave (
@IdUsuario int,
	@Clave nvarchar(500),
	@Mensaje nvarchar(500) output,
	@Resultado bit output
)
as
begin
    begin try
        set @Resultado = 0;
        set @Mensaje = '';

        begin transaction restablecerclave;

        begin
            update Usuario set
                Clave = @Clave
            where IdUsuario = @IdUsuario;

            set @Resultado = 1;
        end
        commit transaction restablecerclave;
    end try
    begin catch
        set @Mensaje = 'Error: ' + ERROR_MESSAGE() + ' (' + CAST(ERROR_NUMBER() AS NVARCHAR) + ')';
        rollback transaction restablecerclave;
    end catch
end;

go

--PROCEDURE ELIMINAR USUARIO--
create procedure SP_EliminarUsuario (
	@IdUsuario int,
	@IdPersona int,
	@Mensaje nvarchar(500) output,
	@Resultado bit output
)
as
begin
	set @Resultado = 0;
    set @Mensaje = '';
	declare @pasoreglas bit = 1

	--Si el usuario esta involucrado en una compra no se puede eliminar
	if exists (
		select * from Compra c
		inner join Usuario u on u.IdUsuario = c.IdUsuario
		where u.IdUsuario = @IdUsuario
	)
	begin
		set @Resultado = 0
		set @Mensaje = @Mensaje + 'No se puede eliminar el usuario porque se encuentra relacionado a una compra'
		set @pasoreglas = 0
	end

	if exists (
		select * from Venta v
		inner join USUARIO u on u.IdUsuario = v.IdUsuario
		where u.IdUsuario = @IdUsuario
	)
	begin
		set @Resultado = 0
		set @Mensaje = @Mensaje + 'No se puede eliminar el usuario porque se encuentra relacionado a una venta'
		set @pasoreglas = 0
	end

	if exists (
		select * from UsuarioComponente uc
		inner join USUARIO u on u.IdUsuario = uc.IdUsuario
		where u.IdUsuario = @IdUsuario
	)
	begin
		set @Resultado = 0
		set @Mensaje = @Mensaje + 'No se puede eliminar el usuario porque se encuentra relacionado a un permiso o grupo de permisos'
		set @pasoreglas = 0
	end

	if (@pasoreglas = 1)
	begin
		delete from Usuario where IdUsuario = @IdUsuario
		--delete from Persona where IdPersona = @IdPersona
		set @Resultado = 1
	end
end;

go

--PROCEDURE REGISTRAR GRUPO PERMISO--
--USO ESTO COMO UN PARAMETRO PARA CREAR UN GRUPO PERMISO-- PARTE 15 MINTUO 44
create type [dbo].[EListaComponentes] as table(
	[IdComponente] int null
)

go
create procedure SP_RegistrarGrupoPermiso(
@NombreGrupo nvarchar(100),
@Estado bit,
@Componentes [EListaComponentes] readonly,
@Resultado bit output,
@Mensaje nvarchar(500) output
)
as
begin
	begin try
		declare @IdGrupoPermiso int = 0
		declare @IdComponente int = 0
		set @Resultado = 1
		set @Mensaje = ''
		declare @TipoComponente nvarchar(20) = 'GrupoPermiso'

		begin transaction registro
			
			insert into Componente(Nombre,TipoComponente,Estado)
			values (@NombreGrupo,@TipoComponente,@Estado)

			set @IdComponente = SCOPE_IDENTITY()

			insert into GrupoPermiso(NombreGrupo,IdComponente)
			values (@NombreGrupo,@IdComponente)

			set @IdGrupoPermiso = SCOPE_IDENTITY()

			insert into GrupoPermisoComponente(IdGrupoPermiso,IdComponente)
			select @IdGrupoPermiso,IdComponente from @Componentes

		commit transaction registro
	end try
	begin catch
		set @Resultado = 0
		set @Mensaje = ERROR_MESSAGE()
		rollback transaction registro
	end catch
end

go

--PROCEDURE EDITAR GRUPO PERMISO--
create procedure SP_EditarGrupoPermiso(
    @IdGrupoPermiso int,
	@IdComponente int,
    @NombreGrupo nvarchar(100),
    @Estado bit,
    @Componentes [EListaComponentes] readonly,
    @Resultado bit output,
    @Mensaje nvarchar(500) output
)
as
begin
    begin try
        set @Resultado = 1
        set @Mensaje = ''
        declare @TipoComponente nvarchar(20) = 'GrupoPermiso'

        begin transaction edicion

            -- Actualizar el nombre y estado del componente asociado al grupo
            update Componente
            set Nombre = @NombreGrupo, Estado = @Estado
            where IdComponente = @IdComponente

            -- Actualizar el nombre del grupo en la tabla GrupoPermiso
            update GrupoPermiso
            set NombreGrupo = @NombreGrupo
            where IdGrupoPermiso = @IdGrupoPermiso

            -- Eliminar las asociaciones existentes de componentes con el grupo
            delete from GrupoPermisoComponente
            where IdGrupoPermiso = @IdGrupoPermiso

            -- Insertar las nuevas asociaciones de componentes con el grupo
            insert into GrupoPermisoComponente(IdGrupoPermiso, IdComponente)
            select @IdGrupoPermiso, IdComponente
            from @Componentes

        commit transaction edicion
    end try
    begin catch
        set @Resultado = 0
        set @Mensaje = ERROR_MESSAGE()
        rollback transaction edicion
    end catch
end

go

--PROCEDURE ELIMINAR GRUPO PERMISO--
create procedure SP_EliminarGrupoPermiso(
    @IdGrupoPermiso int,
	@IdComponente int,
    @Resultado bit output,
    @Mensaje nvarchar(500) output
)
as
begin
    begin try
        set @Resultado = 1
        set @Mensaje = ''

        begin transaction eliminacion
			-- Eliminar las relaciones del grupo con usuarios
			delete from UsuarioComponente
			where IdComponente = @IdComponente

            -- Eliminar las relaciones del grupo con componentes
            delete from GrupoPermisoComponente
            where IdGrupoPermiso = @IdGrupoPermiso

            -- Eliminar el grupo de permisos
            delete from GrupoPermiso
            where IdGrupoPermiso = @IdGrupoPermiso

            -- Eliminar el componente asociado al grupo
            delete from Componente
            where IdComponente = @IdComponente

        commit transaction eliminacion
    end try
    begin catch
        set @Resultado = 0
        set @Mensaje = ERROR_MESSAGE()
        rollback transaction eliminacion
    end catch
end

go

--PROCEDURE EDITAR ESTADO DE PERMISO--
create procedure SP_EditarEstadoPermiso(
	@IdComponente int,
    @Estado bit,
    @Resultado bit output,
    @Mensaje nvarchar(500) output
)
as
begin
    begin try
        set @Resultado = 1
        set @Mensaje = ''

        begin transaction edicion

            -- Actualizar el estado del componente asociado al grupo
            update Componente
            set Estado = @Estado
            where IdComponente = @IdComponente

        commit transaction edicion
    end try
    begin catch
        set @Resultado = 0
        set @Mensaje = ERROR_MESSAGE()
        rollback transaction edicion
    end catch
end

go

--PROCEDURE EDITAR PERMISOS DEL USUARIO--
create procedure SP_EditarUsuarioPermiso(
    @IdUsuario int,
    @Componentes [EListaComponentes] readonly,
    @Resultado bit output,
    @Mensaje nvarchar(500) output
)
as
begin
    begin try
        set @Resultado = 1
        set @Mensaje = ''

        begin transaction edicion

            if exists(
				select *
				from UsuarioComponente
				where IdUsuario = @IdUsuario
			)
			begin
				-- Eliminar las asociaciones existentes de componentes con el grupo
				delete from UsuarioComponente
				where IdUsuario = @IdUsuario
			end

            -- Insertar las nuevas asociaciones de componentes con el grupo
            insert into UsuarioComponente(IdUsuario, IdComponente)
            select @IdUsuario, IdComponente
            from @Componentes

        commit transaction edicion
    end try
    begin catch
        set @Resultado = 0
        set @Mensaje = ERROR_MESSAGE()
        rollback transaction edicion
    end catch
end

go

------------------------------------------------------------------------------------------------------------------------
--PROCEDURE CREAR PERMISO (USO SOLO EN BASE DE DATOS NO LO USO EN EL CODIGO)--
create procedure SP_RegistrarPermiso(
@Nombre nvarchar(100),
@NombreMenu nvarchar(100),
@Mensaje nvarchar(500) output,
@IdPermisoRegistrado int output
)
as
begin
	begin try
		set @IdPermisoRegistrado = 0
		set @Mensaje = ''
		declare @IdComponente int = 0
		declare @TipoComponente nvarchar(60) = 'Permiso'
		declare @Estado bit = 1

		begin transaction registro
		
			insert into Componente(Nombre,TipoComponente,Estado) values
			(@Nombre,@TipoComponente,@Estado)

			set @IdComponente = SCOPE_IDENTITY()

			if (@IdComponente != 0)
			begin
				insert into Permiso(IdComponente,NombreMenu) values
				(@IdComponente,@NombreMenu)

				set @IdPermisoRegistrado = SCOPE_IDENTITY()
			end
		commit transaction registro
	end try
	begin catch
		set @Mensaje = ERROR_MESSAGE()
		rollback transaction registro
	end catch
end

go

--EXEC DEL PROCEDURE AGREGAR PERMISO--
declare @IdPermisoRegistrado int
declare @Mensaje nvarchar(500)

--FRAN PERMISOS--
--exec SP_RegistrarPermiso 'Agregar Usuario','menuagregarusuario',@IdPermisoRegistrado output,@Mensaje output
--exec SP_RegistrarPermiso 'Modificar Usuario','menumodificarusuario',@IdPermisoRegistrado output,@Mensaje output
--exec SP_RegistrarPermiso 'Restablecer Clave','menurestablecerclave',@IdPermisoRegistrado output,@Mensaje output
--exec SP_RegistrarPermiso 'Eliminar Usuario','menueliminarusuario',@IdPermisoRegistrado output,@Mensaje output
--exec SP_RegistrarPermiso 'Ver Menu Permiso','menupermiso',@IdPermisoRegistrado output,@Mensaje output
--exec SP_RegistrarPermiso 'Ver Menu Permiso Simple','menupermisosimple',@IdPermisoRegistrado output,@Mensaje output
--exec SP_RegistrarPermiso 'Ver Menu Permiso Usuario','menupermisousuario',@IdPermisoRegistrado output,@Mensaje output
--exec SP_RegistrarPermiso 'Agregar Grupo','menuagregargrupo',@IdPermisoRegistrado output,@Mensaje output
--exec SP_RegistrarPermiso 'Modificar Grupo','menumodificargrupo',@IdPermisoRegistrado output,@Mensaje output
--exec SP_RegistrarPermiso 'Eliminar Grupo','menueliminargrupo',@IdPermisoRegistrado output,@Mensaje output
--exec SP_RegistrarPermiso 'Modificar Estado de Permiso','menumodificarestadopermiso',@IdPermisoRegistrado output,@Mensaje output
--exec SP_RegistrarPermiso 'Modificar Permisos del Usuario','menueditarpermisousuario',@IdPermisoRegistrado output,@Mensaje output
--exec SP_RegistrarPermiso 'Agregar Cliente','menuagregarcliente',@IdPermisoRegistrado output,@Mensaje output
--exec SP_RegistrarPermiso 'Modificar Cliente','menumodificarcliente',@IdPermisoRegistrado output,@Mensaje output
--exec SP_RegistrarPermiso 'Eliminar Cliente','menueliminarcliente',@IdPermisoRegistrado output,@Mensaje output
--exec SP_RegistrarPermiso 'Agregar Producto','menuagregarproducto',@IdPermisoRegistrado output,@Mensaje output
--exec SP_RegistrarPermiso 'Modificar Producto','menumodificarproducto',@IdPermisoRegistrado output,@Mensaje output
--exec SP_RegistrarPermiso 'Eliminar Producto','menueliminarproducto',@IdPermisoRegistrado output,@Mensaje output

--RAMA PERMISOS--
--Todavia no agregarlos
--exec SP_RegistrarPermiso 'Agregar Usuario','menuAgregarUsuario',@IdPermisoRegistrado output,@Mensaje output
--exec SP_RegistrarPermiso 'Modificar Usuario','menuModificarUsuario',@IdPermisoRegistrado output,@Mensaje output
--exec SP_RegistrarPermiso 'Restablecer Clave','menuRestablecerClave',@IdPermisoRegistrado output,@Mensaje output
--exec SP_RegistrarPermiso 'Eliminar Usuario','menuEliminarUsuario',@IdPermisoRegistrado output,@Mensaje output

select @IdPermisoRegistrado

select @Mensaje

select * from Permiso
inner join Componente on Permiso.IdComponente = Componente.IdComponente
------------------------------------------------------------------------------------------------------------------------

go

--PROCEDURE REGISTRAR CLIENTE--
create procedure SP_RegistrarCliente(
	@NombreCompleto nvarchar(100),
	@Correo nvarchar(100),
	@Documento nvarchar(50),
	@Telefono nvarchar(50),
	--@Direccion nvarchar(100),
	--@Localidad nvarchar(50),
	@Estado bit,
	@Mensaje nvarchar(500) output,
	@IdClienteRegistrado int output
)
as
begin
	begin try
		set @IdClienteRegistrado = 0
		set @Mensaje = ''
		declare @IdPersona int = 0

		begin transaction registro

			if exists (
				select * 
				from Persona
				where Documento = @Documento
			)
			begin
				select @IdPersona = IdPersona
				from Persona
				where Documento = @Documento

				if not exists (
					select *
					from Cliente
					where IdPersona = @IdPersona
				)
				begin
					update Persona
					set NombreCompleto = @NombreCompleto,
						Correo = @Correo
					where Documento = @Documento

					insert into Cliente(IdPersona, Telefono, Estado) values
					(@IdPersona, @Telefono, @Estado)

					set @IdClienteRegistrado = SCOPE_IDENTITY()
				end
				else
				begin
					set @Mensaje = 'Ya existe un cliente con ese numero de documento'
				end
			end
			else
			begin
				insert into Persona(NombreCompleto,Correo,Documento) values
				(@NombreCompleto,@Correo,@Documento)

				set @IdPersona = SCOPE_IDENTITY()

				if (@IdPersona != 0)
				begin
					insert into Cliente(IdPersona, Telefono, Estado) values
					(@IdPersona, @Telefono, @Estado)

					set @IdClienteRegistrado = SCOPE_IDENTITY()
				end
			end
		commit transaction registro
	end try
	begin catch
		set @Mensaje = ERROR_MESSAGE()
		rollback transaction registro
	end catch
end

go

--PROCEDURE EDITAR CLIENTE--
create procedure SP_EditarCliente(
	@IdCliente int,
	@IdPersona int,
	@NombreCompleto nvarchar(100),
	@Correo nvarchar(100),
	@Documento nvarchar(50),
	@Telefono nvarchar(50),
	--@Direccion nvarchar(100),
	--@Localidad nvarchar(50),
	@Estado bit,
	@Mensaje nvarchar(500) output,
	@Resultado bit output
)
as
begin
    begin try
        set @Resultado = 0;
        set @Mensaje = '';

        begin transaction editar;

        if not exists (
                select *
                from Cliente
                inner join Persona on Cliente.IdPersona = Persona.IdPersona
                where Persona.Documento = @Documento and IdCliente != @IdCliente
        )
        begin
            update Persona set
                NombreCompleto = @NombreCompleto,
                Correo = @Correo,
                Documento = @Documento
            where IdPersona = @IdPersona;

            update Cliente set
				--Direccion = @Direccion,
				--Localidad = @Localidad,
				Telefono = @Telefono,
                Estado = @Estado
            where IdCliente = @IdCliente;

            set @Resultado = 1;
        end
		else
		begin
			set @Mensaje = 'Ya existe un cliente con ese numero de documento'
		end

        commit transaction editar;
    end try
    begin catch
        set @Mensaje = 'Error: ' + ERROR_MESSAGE() + ' (' + CAST(ERROR_NUMBER() AS NVARCHAR) + ')';
        rollback transaction editar;
    end catch
end;

go

--PROCEDURE ELIMINAR CLIENTE--
create procedure SP_EliminarCliente(
	@IdCliente int,
	@IdPersona int,
	@Mensaje nvarchar(500) output,
	@Resultado bit output
)
as
begin
	set @Resultado = 0;
    set @Mensaje = '';
	declare @pasoreglas bit = 1

	if exists(
		select *
		from Venta
		where IdCliente = @IdCliente
	)
	begin
		set @Resultado = 0
		set @Mensaje = @Mensaje + 'No se puede eliminar el cliente porque se encuentra relacionado a una venta'
		set @pasoreglas = 0
	end

	if (@pasoreglas = 1)
	begin
		delete from Cliente where IdCliente = @IdCliente
		--delete from Persona where IdPersona = @IdPersona
		set @Resultado = 1
	end
end;

go

--PROCEDURE AGREGAR CATEGORIA--
create proc SP_RegistrarCategoria (
	@Descripcion nvarchar(50),
	@Estado bit,
	@Resultado int output,
	@Mensaje nvarchar(500) output
)
as
begin
	set @Resultado = 0
	--set @Mensaje = ''
	if not exists (select * from Categoria where Descripcion = @Descripcion)
	begin
		insert into Categoria(Descripcion, Estado) values (@Descripcion, @Estado)
		set @Resultado = SCOPE_IDENTITY()
	end
	else
		set	@Mensaje = 'Ya existe una categoria con esa descipcion' --'No se puede repetir la descripcion de una caterogria'
end

go

--PROCEDURE EDITAR CATEGORIA--
create procedure SP_EditarCategoria (
	@IdCategoria int,
	@Descripcion nvarchar(50),
	@Estado bit,
	@Resultado bit output,
	@Mensaje nvarchar(500) output
)
as
begin
	set @Resultado = 1
	--set @Mensaje = ''
	if not exists (select * from Categoria where Descripcion = @Descripcion and IdCategoria != @IdCategoria)
		update Categoria set
		Descripcion = @Descripcion,
		Estado = @Estado
		where IdCategoria = @IdCategoria
	else
	begin
		set @Resultado = 0
		set	@Mensaje = 'Ya existe una categoria con esa descipcion' --'No se puede repetir la descripcion de una caterogria'
	end
end

go

--PROCEDURE ELIMINAR CATEGORIA--
create procedure SP_EliminarCategoria (
	@IdCategoria int,
	@Resultado bit output,
	@Mensaje nvarchar(500) output
)
as
begin
	set @Resultado = 1
	if not exists (
		select * from Categoria c
		inner join PRODUCTO p on p.IdCategoria = c.IdCategoria
		where c.IdCategoria = @IdCategoria
	)
	begin
		delete top(1) from Categoria where IdCategoria = @IdCategoria
	end
	else
	begin
		set @Resultado = 0
		set @Mensaje = 'No se puede eliminar la categoria porque se encuentra relacionada a un producto'
	end
end

go

--PROCEDURE AGREGAR PRODUCTO--
create proc SP_RegistrarProducto (
	@Codigo nvarchar(50),
	@Nombre nvarchar(50),
	@Descripcion nvarchar(50),
	@IdCategoria int,
	@Stock int,
	@PrecioCompra decimal(10,2),
	@PrecioVenta decimal(10,2),
	@Estado bit,
	@Resultado int output,
	@Mensaje nvarchar(500) output
)
as
begin
	set @Resultado = 0
	if not exists (select * from Producto where Codigo = @Codigo)
	begin
		insert into Producto(Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) 
			values (@Codigo, @Nombre, @Descripcion, @IdCategoria, @Stock, @PrecioCompra, @PrecioVenta, @Estado)
		set @Resultado = SCOPE_IDENTITY()
	end
	else
		set @Mensaje = 'Ya existe un producto con el mismo codigo'
end

go

--PROCEDURE EDITAR PRODUCTO--
create procedure SP_EditarProducto (
	@IdProducto int,
	@Codigo nvarchar(50),
	@Nombre nvarchar(50),
	@Descripcion nvarchar(50),
	@IdCategoria int,
	@Stock int,
	@PrecioCompra decimal(10,2),
	@PrecioVenta decimal(10,2),
	@Estado bit,
	@Resultado bit output,
	@Mensaje nvarchar(500) output
)
as
begin
	set @Resultado = 1
	if not exists (select * from Producto where Codigo = @Codigo and IdProducto != @IdProducto)
		update Producto set
		Codigo = @Codigo,
		Nombre = @Nombre,
		Descripcion = @Descripcion,
		IdCategoria = @IdCategoria,
		Stock = @Stock,
		PrecioCompra = @PrecioCompra,
		PrecioVenta = @PrecioVenta,
		Estado = @Estado
		where IdProducto = @IdProducto
	else
	begin
		set @Resultado = 0
		set @Mensaje = 'Ya existe un producto con el mismo codigo'
	end
end

go

--PROCEDURE ELIMINAR PRODUCTO--
create proc SP_EliminarProducto (
	@IdProducto int,
	@Resultado bit output,
	@Mensaje nvarchar(500) output
)
as
begin
	set @Resultado = 0
	set @Mensaje = ''
	declare @pasoreglas bit = 1

	if exists (select * from DetalleCompra dc
	inner join Producto p on p.IdProducto = dc.IdProducto
	where p.IdProducto = @IdProducto
	)
	begin
		set @pasoreglas = 0
		set @Resultado = 0
		set @Mensaje = @Mensaje + 'No se puede eliminar el producto porque se encuentra relacionado a una compra'
	end

	if exists (select * from DetalleVenta dv
	inner join Producto p on p.IdProducto = dv.IdProducto
	where p.IdProducto = @IdProducto
	)
	begin
		set @pasoreglas = 0
		set @Resultado = 0
		set @Mensaje = @Mensaje + 'No se puede eliminar el producto porque se encuentra relacioado a una venta'
	end

	if (@pasoreglas = 1)
	begin
		delete from PRODUCTO where IdProducto = @IdProducto
		set @Resultado = 1
	end
end

go

--PROCEDURE AGREGAR PROVEEDOR--
create proc SP_RegistrarProveedor (
	@CUIT nvarchar(50),
	@RazonSocial nvarchar(50),
	@Correo nvarchar(50),
	@Telefono nvarchar(50),
	@Estado bit,
	@Resultado int output,
	@Mensaje nvarchar(500) output
)
as
begin
	set @Resultado = 0
	declare @IdPersona int
	if not exists (select * from Proveedor where CUIT = @CUIT)
	begin
		insert into Proveedor(RazonSocial, CUIT, Correo, Telefono, Estado)
			values (@RazonSocial, @CUIT, @Correo, @Telefono, @Estado)

		set @Resultado = SCOPE_IDENTITY()
	end
	else
		set @Mensaje = 'Ya existe un proveedor registrado con ese CUIT'
end

go

--PROCEDURE EDITAR PROVEEDOR--
create proc SP_EditarProveedor (
	@IdProveedor int,
	@CUIT nvarchar(50),
	@RazonSocial nvarchar(50),
	@Correo nvarchar(50),
	@Telefono nvarchar(50),
	@Estado bit,
	@Resultado bit output,
	@Mensaje nvarchar(500) output
)
as
begin
	set @Resultado = 1
	declare @IdPersona int
	if not exists (select * from Proveedor where CUIT = @CUIT and IdProveedor != @IdProveedor)
	begin
		update Proveedor set
		RazonSocial = @RazonSocial,
		CUIT = @CUIT,
		Correo = @Correo,
		Telefono = @Telefono,
		Estado = @Estado
		where IdProveedor = @IdProveedor
	end
	else
	begin
		set @Resultado = 0
		set @Mensaje = 'Ya existe un proveedor registrado con ese CUIT'
	end
end

go

--PROCEDURE ELIMINAR PROVEEDOR--
create proc SP_EliminarProveedor (
	@IdProveedor int,
	@Resultado bit output,
	@Mensaje nvarchar(500) output
)
as
begin
	set @Resultado = 1
	if not exists (
	select * from Proveedor p
	inner join Compra c on p.IdProveedor = c.IdProveedor
	where p.IdProveedor = @IdProveedor
	)
	begin
		delete top(1) from Proveedor where IdProveedor = @IdProveedor
	end
	else
	begin
		set @Resultado = 0
		set @Mensaje = 'No se puede eliminar el proveedor porque se encuentra relacionado a una compra'
	end
end

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

--PROCEDURE REGISTAR COMPRA--
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
    end catch
end;

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
		set @Resultado = 1
		set @Mensaje = ''

		begin transaction registro

			insert into Venta(IdUsuario, IdCliente,TipoDocumento, NumeroDocumento, MontoPago, MontoCambio, SubTotal, MontoTotal, TipoDescuento, MontoDescuento)
			values (@IdUsuario, @IdCliente, @TipoDocumento, @NumeroDocumento, @MontoPago, @MontoCambio, @SubTotal, @MontoTotal, @TipoDescuento, @MontoDescuento)

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

go

--PROCEDURE ELIMINAR VENTA--
create procedure SP_EliminarVenta (
    @IdVenta int,
    @Resultado bit output,
    @Mensaje nvarchar(500) output
)
as
begin
    begin try
        set @Resultado = 1;
        set @Mensaje = '';

        begin transaction eliminar_venta;

        -- Guardar los detalles de la venta que se eliminar�
        declare @DetallesVenta table (
            IdProducto int,
            Cantidad int
        );

        -- Insertar los detalles de la venta en la tabla temporal
        insert into @DetallesVenta (IdProducto, Cantidad)
        select IdProducto, Cantidad
        from DetalleVenta
        where IdVenta = @IdVenta;

        -- Eliminar detalles de la venta
        delete from DetalleVenta where IdVenta = @IdVenta;

        -- Eliminar la venta
        delete from Venta where IdVenta = @IdVenta;

        -- Restaurar el stock de productos
        update Producto
        set Stock = Stock + DV.Cantidad
        from Producto P
        inner join @DetallesVenta DV on P.IdProducto = DV.IdProducto;

        commit transaction eliminar_venta;
    end try
    begin catch
        set @Resultado = 0;
        set @Mensaje = ERROR_MESSAGE();
        rollback transaction eliminar_venta;
    end catch
end;

go

--PROCEDURE REPORTE VENTAS--
create proc SP_ReporteVentas (
	@FechaInicio nvarchar(10),
	@FechaFin nvarchar(10),
	@IdCliente int
)
as
begin
	set dateformat dmy;

	select
		convert(char(10), v.FechaRegistro,103)[FechaRegistro], v.TipoDocumento, v.NumeroDocumento, v.TipoDescuento, v.MontoDescuento, v.SubTotal, v.MontoTotal,
		u.IdUsuario, pu.NombreCompleto[NombreCompletoUsuario], pu.Documento[DocumentoUsuario],
		c.IdCliente, pc.NombreCompleto[NombreCompletoCliente], pc.Documento[DocumentoCliente],
		p.Codigo[CodigoProducto], p.Nombre[NombreProducto],
		ca.Descripcion[Categoria],
		dv.PrecioVenta, dv.Cantidad --, dv.SubTotal
	from Venta v
		inner join Usuario u on u.IdUsuario = v.IdUsuario
		inner join Persona pu on pu.IdPersona = u.IdPersona
		inner join Cliente c on c.IdCliente = v.IdCliente
		inner join Persona pc on pc.IdPersona = c.IdPersona
		inner join DetalleVenta dv on dv.IdVenta = v.IdVenta
		inner join Producto p on p.IdProducto = dv.IdProducto
		inner join Categoria ca on ca.IdCategoria = p.IdCategoria
	where convert(date, v.FechaRegistro, 103) between @FechaInicio and @FechaFin
		and c.IdCliente = iif(@IdCliente = 0, c.IdCliente, @IdCliente)

	set dateformat mdy;
end

go

--PROCEDURE REPORTE COMPRAS--
create proc SP_ReporteCompras (
	@FechaInicio nvarchar(10),
	@FechaFin nvarchar(10),
	@IdProveedor int
)
as
begin
	set dateformat dmy;

	select
	convert(char(10), c.FechaRegistro,103)[FechaRegistro], c.TipoDocumento, c.NumeroDocumento, c.MontoTotal,
	u.IdUsuario, u.IdPersona, ps.NombreCompleto[NombreCompletoUsuario], ps.Documento[DocumentoUsuario],
	pr.CUIT, pr.RazonSocial,
	p.Codigo[CodigoProducto], p.Nombre[NombreProducto], 
	ca.Descripcion[Categoria], 
	dc.PrecioCompra, dc.PrecioVenta, dc.Cantidad, dc.MontoTotal[SubTotal]
	from COMPRA c
	inner join Usuario u on u.IdUsuario = c.IdUsuario
	inner join Persona ps on ps.IdPersona = u.IdPersona
	inner join Proveedor pr on pr.IdProveedor = c.IdProveedor
	inner join DetalleCompra dc on dc.IdCompra = c.IdCompra
	inner join Producto p on p.IdProducto = dc.IdProducto
	inner join Categoria ca on ca.IdCategoria = p.IdCategoria
	where convert(date, c.FechaRegistro, 103) between @FechaInicio and @FechaFin
	and pr.IdProveedor = iif(@IdProveedor = 0, pr.IdProveedor, @IdProveedor)

	set dateformat mdy;
end