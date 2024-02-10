insert into Componente (Nombre, TipoComponente, Estado) 
	values ('Administrador', 'GrupoPermiso', 1);

insert into GrupoPermiso(IdComponente,NombreGrupo)
	values (74, 'Administrador');

insert into GrupoPermisoComponente(IdGrupoPermiso,IdComponente)
	values	(20,70),
			(20,64),
			(20,39),
			(20,26),
			(20,1)

insert into UsuarioComponente(IdUsuario,IdComponente)
	values (1,74);