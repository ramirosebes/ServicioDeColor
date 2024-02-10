insert into Componente (Nombre, TipoComponente, Estado) 
	values	('Gestionar seguridad', 'GrupoPermiso', 1),
			('Ver menu seguridad', 'Permiso', 1),
			('Gestionar usuarios', 'GrupoPermiso', 1), 
			('Ver menu usuarios', 'Permiso', 1), 
			('Ver detalle usuario', 'Permiso', 1), 
			('Agregar usuario', 'Permiso', 1), 
			('Editar usuario', 'Permiso', 1), 
			('Restablecer clave', 'Permiso', 1), 
			('Eliminar usuario', 'Permiso', 1), 
			('Gestionar permisos', 'GrupoPermiso', 1), 
			('Ver menu permisos', 'Permiso', 1), 
			('Gestionar permisos simples', 'GrupoPermiso', 1), 
			('Ver menu permisos simples', 'Permiso', 1), 
			('Ver detalle permiso simple', 'Permiso', 1), 
			('Editar estado permiso simple', 'Permiso', 1), 
			('Gestionar grupos permisos', 'GrupoPermiso', 1), 
			('Ver menu grupos permisos', 'Permiso', 1), 
			('Ver detalle grupo permisos', 'Permiso', 1), 
			('Agregar grupo permisos', 'Permiso', 1), 
			('Editar grupo permisos', 'Permiso', 1),
			('Eliminar grupo permisos', 'Permiso', 1),
			('Gestionar permisos usuarios', 'GrupoPermiso', 1),
			('Ver menu permisos usuarios', 'Permiso', 1),
			('Ver permisos usuario', 'Permiso', 1),
			('Editar permisos usuario', 'Permiso', 1);

insert into Permiso (IdComponente, NombreMenu)
	values	(2, 'menuSeguridad'), 
			(4, 'menuUsuarios'),
			(5, 'menuVerDetalleUsuario'),
			(6, 'menuAgregarUsuario'),
			(7, 'menuEditarUsuario'),
			(8, 'menuRestablecerClave'),
			(9, 'menuEliminarUsuario'),
			(11, 'menuPermisos'),
			(13, 'menuPermisosSimples'),
			(14, 'menuVerDetallePerisoSimple'),
			(15, 'menuEditarEstadoPermisoSimple'),
			(17, 'menuGruposPermisos'),
			(18, 'menuVerDetalleGrupoPermisos'),
			(19, 'menuAgregarGrupoPermisos'),
			(20, 'menuEditarGrupoPermisos'),
			(21, 'menuEliminarGrupoPermisos'),
			(23, 'menuPermisosUsuarios'),
			(24, 'menuVerPermisosUsuario'),
			(25, 'menuEditarPermisosUsuario');

insert into GrupoPermiso(IdComponente,NombreGrupo)
	values	(1, 'Gestionar seguridad'),
			(3, 'Gestionar usuarios'),
			(10, 'Gestionar permisos'),
			(12, 'Gestionar permisos simples'),
			(16, 'Gestionar grupos permisos'),
			(22, 'Gestionar permisos usuarios')

insert into GrupoPermisoComponente(IdGrupoPermiso,IdComponente)
	values	(6,25),
			(6,24),
			(6,23),
			(6,11), --Ver menu seguridad --Eliminar
			(6,2),	--Ver menu permisos --Eliminar
			(5,21),
			(5,20),
			(5,19),
			(5,18),
			(5,17),
			(5,11),	--Ver menu seguridad --Eliminar
			(5,2),	--Ver menu permisos --Eliminar
			(4,15),
			(4,14),
			(4,13),
			(4,11),	--Ver menu seguridad --Eliminar
			(4,2),	--Ver menu permisos --Eliminar
			(3,22),
			(3,16),
			(3,12),
			(3,11),
			(3,2),	--Ver menu seguridad --Eliminar
			(2,9),
			(2,8),
			(2,7),
			(2,6),
			(2,5),
			(2,4),
			(2,2),	--Ver menu seguridad --Eliminar
			(1,10),
			(1,3),
			(1,2) --Ver menu seguridad