insert into Componente (Nombre, TipoComponente, Estado) 
	values	('Gestionar ventas', 'GrupoPermiso', 1),
			('Ver menu ventas', 'Permiso', 1),
			('Gestionar clientes', 'GrupoPermiso', 1),
			('Ver menu clientes', 'Permiso', 1),
			('Ver detalle cliente', 'Permiso', 1),
			('Agregar cliente', 'Permiso', 1),
			('Editar cliente', 'Permiso', 1),
			('Eliminar cliente', 'Permiso', 1),
			('Gestionar pedidos ventas', 'GrupoPermiso', 1),
			('Ver menu pedidos ventas', 'Permiso', 1),
			('Ver detalle pedido venta', 'Permiso', 1),
			('Agregar pedido venta', 'Permiso', 1),
			('Eliminar pedido venta', 'Permiso', 1)

insert into Permiso (IdComponente, NombreMenu)
	values	(27, 'menuVentas'), 
			(29, 'menuClientes'),
			(30, 'menuVerDetalleCliente'),
			(31, 'menuAgregarCliente'),
			(32, 'menuEditarCliente'),
			(33, 'menuEliminarCliente'),
			(35, 'menuPedidosVentas'),
			(36, 'menuVerDetallePedidoVenta'),
			(37, 'menuAgregarPedidoVenta'),
			(38, 'menuEliminarPedidoVenta')

insert into GrupoPermiso(IdComponente,NombreGrupo)
	values	(26, 'Gestionar ventas'),
			(28, 'Gestionar clientes'),
			(34, 'Gestionar pedidos ventas')

insert into GrupoPermisoComponente(IdGrupoPermiso,IdComponente)
	values	(9,38),
			(9,37),
			(9,36),
			(9,35),
			(9,27),	--Ver menu ventas --Eliminar
			(8,33),
			(8,32),
			(8,31),
			(8,30),
			(8,29),
			(8,27), --Ver menu ventas --Eliminar
			(7,34),
			(7,28),
			(7,27)