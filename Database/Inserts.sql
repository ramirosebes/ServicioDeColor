use DB_SDC

go

insert into Persona(NombreCompleto,Correo,Documento)
values ('Administrador','administrador@gmail.com','10'),('Ramiro Sebes','ramirosebes@gmail.com','11')

go

insert into Usuario(IdPersona,Clave,Estado)
values (1,'10',1),(2,'11',1)

go

insert into Componente (Nombre, TipoComponente, Estado) 
	values	('Ver menu seguridad', 'Permiso', 1),
			('Ver menu ventas', 'Permiso', 1), 
			('Ver menu compras', 'Permiso', 1),
			('Ver menu reportes', 'Permiso', 1),
			('Ver menu configuracion', 'Permiso', 1),
			('Gestionar seguridad', 'GrupoPermiso', 1), 
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

go

insert into Permiso (IdComponente, NombreMenu)
	values	(1, 'menuSeguridad'), 
			(2, 'menuVentas'),
			(3, 'menuCompras'),
			(4, 'menuReportes'),
			(5, 'menuConfiguracion'),
			(7, 'menuSeguridad'),
			(9, 'menuUsuarios'),
			(10, 'menuVerDetalleUsuario'),
			(11, 'menuAgregarUsuario'),
			(12, 'menuEditarUsuario'),
			(13, 'menuRestablecerClave'),
			(14, 'menuEliminarUsuario'),
			(16, 'menuPermisos'),
			(18, 'menuPermisosSimples'),
			(19, 'menuVerDetallePerisoSimple'),
			(20, 'menuEditarEstadoPermisoSimple'),
			(22, 'menuGruposPermisos'),
			(23, 'menuVerDetalleGrupoPermisos'),
			(24, 'menuAgregarGrupoPermisos'),
			(25, 'menuEditarGrupoPermisos'),
			(26, 'menuEliminarGrupoPermisos'),
			(28, 'menuPermisosUsuarios'),
			(29, 'menuVerPermisosUsuario'),
			(30, 'menuEditarPermisosUsuario');

go

insert into GrupoPermiso(IdComponente,NombreGrupo)
	values	(6, 'Gestionar seguridad'),
			(8, 'Gestionar usuarios'),
			(15, 'Gestionar permisos'),
			(17, 'Gestionar permisos simples'),
			(21, 'Gestionar grupos permisos'),
			(27, 'Gestionar permisos usuarios')

go

insert into GrupoPermisoComponente(IdGrupoPermiso,IdComponente)
	values	(6,30),
			(6,29),
			(6,28),
			(5,26),
			(5,25),
			(5,24),
			(5,23),
			(5,22),
			(4,20),
			(4,19),
			(4,18),
			(3,27),
			(3,21),
			(3,17),
			(3,16),
			(2,14),
			(2,13),
			(2,12),
			(2,11),
			(2,10),
			(2,9),
			(1,15),
			(1,8),
			(1,7)

insert into Componente (Nombre, TipoComponente, Estado) 
	values ('Administrador', 'GrupoPermiso', 1);

insert into GrupoPermiso(IdComponente,NombreGrupo)
	values (31, 'Administrador');

insert into GrupoPermisoComponente(IdGrupoPermiso,IdComponente)
	values (7,6); --El IdComponente es Gestionar seguridad, siguientemente debere colocar Gestionar compras, Gestioanr ventas, Gestionar reportes y Gestionar configuracion

insert into UsuarioComponente(IdUsuario,IdComponente)
	values (1,31);

--UPDATE Permiso
--SET NombreMenu = 'menuEliminarGrupoPermisos'
--WHERE IdComponente = 26 AND NombreMenu = 'menuEliminarGrupoPermiso';

insert into GrupoPermisoComponente(IdGrupoPermiso,IdComponente)
	values	(6,16),
			(6,1),
			(5,16),
			(5,1),
			(4,16),
			(4,1),
			(3,1),
			(2,1)

--INSERT NEGOCIO--
insert into Negocio (IdNegocio, Nombre, CUIT, Direccion)
	values (1, 'Servicio De Color', '20-12345678-9')

--INSERT COMPRA--
insert into Compra ( IdUsuario, IdProveedor, TipoDocumento, NumeroDocumento, MontoTotal)
	values  (2, 2, 'Factura', 00001, 100)