use DB_SDC;

go

--PROCEDURE REGISTRAR USUARIO--
create procedure SP_RegistrarUsuario (
	@NombreCompleto nvarchar(100),
	@Correo nvarchar(100),
	@Documento nvarchar(100),
	@Clave nvarchar(400),
	@Estado bit,
	@Mensaje nvarchar(400) output,
	@IdUsuarioRegistrado int output
)
as
begin
	begin try
		set @IdUsuarioRegistrado = 0
		set @Mensaje = ''
		declare @IdPersona int = 0

		begin transaction registro
		
			if not exists(
				select * 
				from Usuario
				inner join Persona on Usuario.IdPersona = Persona.IdPersona
				where Persona.Documento = @Documento
			)
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
@Clave nvarchar(400),
@Mensaje nvarchar(400) output,
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
@Mensaje nvarchar(400) output,
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
		set @Mensaje = @Mensaje + 'No se puede eliminar porue el usuario se encuentra relacionado a una compra\n'
		set @pasoreglas = 0
	end

	if exists (
		select * from VENTA v
		inner join USUARIO u on u.IdUsuario = v.IdUsuario
		where u.IdUsuario = @IdUsuario
	)
	begin
		set @Resultado = 0
		set @Mensaje = @Mensaje + 'No se puede eliminar porue el usuario se encuentra relacionado a una venta\n'
		set @pasoreglas = 0
	end

	if (@pasoreglas = 1)
	begin
		delete from Usuario where IdUsuario = @IdUsuario
		delete from Persona where IdPersona = @IdPersona
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
@NombreGrupo nvarchar(60),
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
    @NombreGrupo nvarchar(60),
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
@Mensaje nvarchar(400) output,
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
@Documento nvarchar(100),
@Telefono nvarchar(60),
@Direccion nvarchar(100),
@Estado bit,
@Mensaje nvarchar(400) output,
@IdClienteRegistrado int output
)
as
begin
	begin try
		set @IdClienteRegistrado = 0
		set @Mensaje = ''
		declare @IdPersona int = 0

		begin transaction registro
		
			if not exists(
				select * 
				from Cliente
				inner join Persona on Cliente.IdPersona = Persona.IdPersona
				where Persona.Documento = @Documento
			)
			begin
				insert into Persona(NombreCompleto,Correo,Documento) values
				(@NombreCompleto,@Correo,@Documento)

				set @IdPersona = SCOPE_IDENTITY()

				if (@IdPersona != 0)
				begin
					insert into Cliente(IdPersona,Telefono,Direccion,Estado) values
					(@IdPersona,@Telefono,@Direccion,@Estado)

					set @IdClienteRegistrado = SCOPE_IDENTITY()
				end
			end
			else
			begin
				set @Mensaje = 'Ya existe un cliente con este documento'
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
@Documento nvarchar(100),
@Telefono nvarchar(60),
@Direccion nvarchar(100),
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
				Direccion = @Direccion,
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
@Mensaje nvarchar(400) output,
@Resultado bit output
)
as
begin
	set @Resultado = 0;
    set @Mensaje = '';

	begin try
		begin transaction editar
			delete from Cliente where IdCliente = @IdCliente;
			delete from Persona where IdPersona = @IdPersona;
		commit transaction editar
			set @Resultado = 1
	end try
	begin catch
		rollback transaction editar
        set @Mensaje = 'Error: ' + ERROR_MESSAGE() + ' (' + CAST(ERROR_NUMBER() AS NVARCHAR) + ')';
	end catch
end;
go