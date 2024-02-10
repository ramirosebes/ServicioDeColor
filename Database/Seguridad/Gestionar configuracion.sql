insert into Componente (Nombre, TipoComponente, Estado) 
	values	('Gestionar configuracion', 'GrupoPermiso', 1),
			('Ver menu configuracion', 'Permiso', 1),
			('Gestionar datos negocio', 'GrupoPermiso', 1),
			('Ver menu datos negocio', 'Permiso', 1),
			('Editar datos negcio', 'Permiso', 1)

insert into Permiso (IdComponente, NombreMenu)
	values	(71, 'menuConfiguracion'), 
			(73, 'menuDatosNegocio'),
			(74, 'menuEditarDatosNegocio')


insert into GrupoPermiso(IdComponente,NombreGrupo)
	values	(70, 'Gestionar configuracion'),	--18
			(72, 'Gestionar datos negocio')		--19

insert into GrupoPermisoComponente(IdGrupoPermiso,IdComponente)
	values	(19,74),
			(19,73),
			(19,71),	--Ver menu configuracion --Eliminar
			(18,72),
			(18,71)		--Ver menu configuracion