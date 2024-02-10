insert into Componente (Nombre, TipoComponente, Estado) 
	values	('Gestionar reportes', 'GrupoPermiso', 1),
			('Ver menu reportes', 'Permiso', 1),
			('Gestionar reportes compras', 'GrupoPermiso', 1),
			('Ver menu reportes compras', 'Permiso', 1),
			('Gestionar reportes ventas', 'GrupoPermiso', 1),
			('Ver menu reportes ventas', 'Permiso', 1)

insert into Permiso (IdComponente, NombreMenu)
	values	(65, 'menuReportes'), 
			(67, 'menuReportesCompras'),
			(69, 'menuReportesVentas')

insert into GrupoPermiso(IdComponente,NombreGrupo)
	values	(64, 'Gestionar reportes'),				--15
			(66, 'Gestionar reportes compras'),		--16
			(68, 'Gestionar reportes ventas')		--17

insert into GrupoPermisoComponente(IdGrupoPermiso,IdComponente)
	values	(17,69),
			(17,65),	--Ver menu reportes --Eliminar
			(16,67),
			(16,65),	--Ver menu reportes --Eliminar
			(15,68),
			(15,66),
			(15,65)		--Ver menu reportes --Eliminar