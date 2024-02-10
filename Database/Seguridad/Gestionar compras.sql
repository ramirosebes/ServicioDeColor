insert into Componente (Nombre, TipoComponente, Estado) 
	values	('Gestionar compras', 'GrupoPermiso', 1),
			('Ver menu compras', 'Permiso', 1),
			('Gestionar categorias', 'GrupoPermiso', 1),
			('Ver menu categorias', 'Permiso', 1),
			('Ver detalle categoria', 'Permiso', 1),
			('Agregar categoria', 'Permiso', 1),
			('Editar categoria', 'Permiso', 1),
			('Eliminar categoria', 'Permiso', 1),
			('Gestionar productos', 'GrupoPermiso', 1),
			('Ver menu productos', 'Permiso', 1),
			('Ver detalle productos', 'Permiso', 1),
			('Agregar producto', 'Permiso', 1),
			('Editar producto', 'Permiso', 1),
			('Eliminar producto', 'Permiso', 1),
			('Gestionar proveedores', 'GrupoPermiso', 1),
			('Ver menu proveedores', 'Permiso', 1),
			('Ver detalle proveedor', 'Permiso', 1),
			('Agregar proveedor', 'Permiso', 1),
			('Editar proveedor', 'Permiso', 1),
			('Eliminar proveedor', 'Permiso', 1),
			('Gestionar ordenes compras', 'GrupoPermiso', 1),
			('Ver menu ordenes compras', 'Permiso', 1),
			('Ver detalle orden compra', 'Permiso', 1),
			('Agregar orden compra', 'Permiso', 1),
			('Eliminar orden compra', 'Permiso', 1)

insert into Permiso (IdComponente, NombreMenu)
	values	(40, 'menuCompras'), 
			(42, 'menuCategorias'),
			(43, 'menuVerDetalleCategoria'),
			(44, 'menuAgregarCategoria'),
			(45, 'menuEditarCategoria'),
			(46, 'menuEliminarCategoria'),
			(48, 'menuProductos'),
			(49, 'menuVerDetalleProducto'),
			(50, 'menuAgregarProducto'),
			(51, 'menuEditarProducto'),
			(52, 'menuEliminarProducto'),
			(54, 'menuProveedores'),
			(55, 'menuVerDetalleProveedor'),
			(56, 'menuAgregarProveedor'),
			(57, 'menuEditarProveedor'),
			(58, 'menuEliminarProveedor'),
			(60, 'menuOrdenesCompras'),
			(61, 'menuVerDetalleOrdenCompra'),
			(62, 'menuAgregarOrdenCompra'),
			(63, 'menuEliminarOrdenCompra')

insert into GrupoPermiso(IdComponente,NombreGrupo)
	values	(39, 'Gestionar compras'),			--10
			(41, 'Gestionar categorias'),		--11
			(47, 'Gestionar productos'),		--12
			(53, 'Gestionar proveedores'),		--13
			(59, 'Gestionar ordenes compras')	--14

insert into GrupoPermisoComponente(IdGrupoPermiso,IdComponente)
	values	(14,63),
			(14,62),
			(14,61),
			(14,60),
			(14,40),	--Ver menu compras --Eliminar
			(13,58),
			(13,57),
			(13,56),
			(13,55),
			(13,54),
			(13,40),	--Ver menu compras --Eliminar
			(12,52),
			(12,51),
			(12,50),
			(12,49),
			(12,48),
			(12,40),	--Ver menu compras --Eliminar
			(11,46),
			(11,45),
			(11,44),
			(11,43),
			(11,42),
			(11,40),	--Ver menu compras --Eliminar
			(10,59),
			(10,53),
			(10,47),
			(10,41),
			(10,40) --Ver menu compras

