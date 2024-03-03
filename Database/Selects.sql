select * from Componente;
select * from Permiso;
select * from GrupoPermiso;
select * from GrupoPermisoComponente;
select * from UsuarioComponente;

--LISTAR COMPRAS--
SELECT c.IdCompra, c.IdUsuario, u.IdPersona, ps.NombreCompleto, c.IdProveedor,TipoDocumento, NumeroDocumento, MontoTotal, FechaRegistro FROM Compra c
INNER JOIN Usuario u ON c.IdUsuario = u.IdUsuario
INNER JOIN Proveedor p ON c.IdProveedor = p.IdProveedor
INNER JOIN Persona ps ON u.IdPersona = ps.IdPersona

SELECT c.IdCompra, c.IdUsuario, u.IdPersona, ps.NombreCompleto, c.IdProveedor,TipoDocumento, NumeroDocumento, MontoTotal, FechaRegistro FROM Compra c
INNER JOIN Usuario u ON c.IdUsuario = u.IdUsuario
INNER JOIN Proveedor p ON c.IdProveedor = p.IdProveedor
INNER JOIN Persona ps ON u.IdPersona = ps.IdPersona

select c.IdCompra, c.IdUsuario, ps.NombreCompleto, pr.CUIT, pr.RazonSocial, c.TipoDocumento, c.NumeroDocumento, c.MontoTotal, convert(char(10), c.FechaRegistro, 103)[FechaRegistro] from Compra c
inner join Usuario u on u.IdUsuario = c.IdUsuario
inner join Persona ps on ps.IdPersona = u.IdPersona
inner join Proveedor pr on pr.IdProveedor = c.IdProveedor
where c.NumeroDocumento = 1

--OBTENER VENTA--
select v.IdVenta,
u.IdUsuario, pu.NombreCompleto[NombreCompletoUsuario], pu.Documento[DocumentoUsuario], pu.IdPersona[IdPersonaUsuario],
c.IdCliente, pc.NombreCompleto[NombreCompletoCliente], pc.Documento[DocumentoCliente], pc.IdPersona[IdPersonaCliente],
v.TipoDocumento, v.NumeroDocumento, v.MontoPago, v.MontoCambio, v.MontoTotal, v.TipoDescuento, v.MontoDescuento, convert(char(10),v.FechaRegistro,103)[FechaRegistro]
from Venta v
inner join Usuario u on u.IdUsuario = v.IdUsuario
inner join Persona pu on pu.IdPersona = u.IdPersona
inner join Cliente c on c.IdCliente = v.IdCliente
inner join Persona pc on pc.IdPersona = c.IdPersona
where v.NumeroDocumento = @numero

--LISTAR VENTAS--
select v.IdVenta,
u.IdUsuario, pu.NombreCompleto[NombreCompletoUsuario], pu.Documento[DocumentoUsuario], pu.IdPersona[IdPersonaUsuario],
c.IdCliente, pc.NombreCompleto[NombreCompletoCliente], pc.Documento[DocumentoCliente], pc.IdPersona[IdPersonaCliente],
v.TipoDocumento, v.NumeroDocumento, v.MontoPago, v.MontoCambio, v.MontoTotal, v.TipoDescuento, v.MontoDescuento, convert(char(10),v.FechaRegistro,103)[FechaRegistro]
from Venta v
inner join Usuario u on u.IdUsuario = v.IdUsuario
inner join Persona pu on pu.IdPersona = u.IdPersona
inner join Cliente c on c.IdCliente = v.IdCliente
inner join Persona pc on pc.IdPersona = c.IdPersona

--LISTAR REPORTES VENTAS--
select
	convert(char(10), v.FechaRegistro,103) as FechaRegistro, v.TipoDocumento, v.NumeroDocumento, v.MontoTotal,
	u.IdUsuario, pu.NombreCompleto as NombreCompletoUsuario, pu.Documento as DocumentoUsuario,
	c.IdCliente, pc.NombreCompleto as NombreCompletoCliente, pc.Documento as DocumentoCliente,
	p.Codigo as CodigoProducto, p.Nombre as NombreProducto,
	ca.Descripcion as Categoria,
	dv.PrecioVenta, dv.Cantidad, dv.SubTotal
from Venta v
	inner join Usuario u on u.IdUsuario = v.IdUsuario
	inner join Persona pu on pu.IdPersona = u.IdPersona
	inner join Cliente c on c.IdCliente = v.IdCliente
	inner join Persona pc on pc.IdPersona = c.IdPersona
	inner join DetalleVenta dv on dv.IdVenta = v.IdVenta
	inner join Producto p on p.IdProducto = dv.IdProducto
	inner join Categoria ca on ca.IdCategoria = p.IdCategoria
where convert(date, v.FechaRegistro, 103) between '01/01/2024' and '06/02/2024'

select
	convert(char(10), v.FechaRegistro,103)[FechaRegistro], v.TipoDocumento, v.NumeroDocumento, v.MontoTotal,
	u.IdUsuario, pu.NombreCompleto[NombreCompletoUsuario], pu.Documento[DocumentoUsuario],
	c.IdCliente, pc.NombreCompleto[NombreCompletoCliente], pc.Documento[DocumentoCliente],
	p.Codigo[CodigoProducto], p.Nombre[NombreProducto],
	ca.Descripcion[Categoria],
	dv.PrecioVenta, dv.Cantidad, dv.SubTotal
from Venta v
	inner join Usuario u on u.IdUsuario = v.IdUsuario
	inner join Persona pu on pu.IdPersona = u.IdPersona
	inner join Cliente c on c.IdCliente = v.IdCliente
	inner join Persona pc on pc.IdPersona = c.IdPersona
	inner join DetalleVenta dv on dv.IdVenta = v.IdVenta
	inner join Producto p on p.IdProducto = dv.IdProducto
	inner join Categoria ca on ca.IdCategoria = p.IdCategoria
where convert(date, v.FechaRegistro, 103) between '01/01/2024' and '06/02/2024'
--FIN LISTAR REPORTE VENTAS--

/*---------- AUDITORIA ----------*/
--SELECT LISTAR AUDICTORIA COMPRAS--
select 
ac.IdAuditoriaCompra,
ac.IdUsuarioAuditoria, ua.IdPersona[IdPersonaUsuarioAuditoria], pa.NombreCompleto[NombreCompletoUsuarioAuditoria], pa.Documento[DocumentoUsuarioAuditoria], --pa.Correo, ua.estado,
ac.IdProveedor, pv.RazonSocial, pv.CUIT, pv.Correo,
DescripcionAuditoria, FechaAuditoria, IdCompra, TipoDocumento, NumeroDocumento, MontoTotal, FechaRegistro,
ac.IdUsuario, uc.IdPersona[IdPersonaUsuarioCompra], pc.NombreCompleto[NombreCompletoUsuarioCompra], pc.Documento[DocumentoUsuarioCompra]
from AuditoriaCompra ac
--Usuario Auditoria ua--
inner join Usuario ua on ac.IdUsuarioAuditoria = ua.IdUsuario
inner join Persona pa on ua.IdUsuario = pa.IdPersona
--Usuario Compra uc--
inner join Usuario uc on ac.IdUsuario = uc.IdUsuario
inner join Persona pc on uc.IdPersona = pc.IdPersona
--Proveedor pv--
inner join Proveedor pv on ac.IdProveedor = pv.IdProveedor

--SELECT OBTENER AUDITORIA COMPRA--
select 
ac.IdAuditoriaCompra,
ac.IdUsuarioAuditoria, ua.IdPersona[IdPersonaUsuarioAuditoria], pa.NombreCompleto[NombreCompletoUsuarioAuditoria], pa.Documento[DocumentoUsuarioAuditoria], --pa.Correo, ua.estado,
ac.IdProveedor, pv.RazonSocial, pv.CUIT, pv.Correo,
DescripcionAuditoria, FechaAuditoria, IdCompra, TipoDocumento, NumeroDocumento, MontoTotal, FechaRegistro,
ac.IdUsuario, uc.IdPersona[IdPersonaUsuarioCompra], pc.NombreCompleto[NombreCompletoUsuarioCompra], pc.Documento[DocumentoUsuarioCompra]
from AuditoriaCompra ac
inner join Usuario ua on ac.IdUsuarioAuditoria = ua.IdUsuario
inner join Persona pa on ua.IdUsuario = pa.IdPersona
inner join Usuario uc on ac.IdUsuario = uc.IdUsuario
inner join Persona pc on uc.IdPersona = pc.IdPersona
inner join Proveedor pv on ac.IdProveedor = pv.IdProveedor
where ac.IdAuditoriaCompra = @idAuditoriaCompra
--where ac.IdCompra = @idCompra

--SELECT OBTENER AUDITORIA DETALLE COMPRA--
select p.Nombre,
adc.DescripcionAuditoria, adc.FechaAuditoria,
adc.PrecioCompra, adc.Cantidad, adc.MontoTotal
from AuditoriaDetalleCompra adc
inner join Producto p on p.IdProducto = adc.IdProducto
where adc.IdAuditoriaCompra = @idAuditoriaCompra

--SELECT LISTAR AUDITORIA VENTAS--
select
av.IdAuditoriaVenta,
av.IdUsuarioAuditoria, ua.IdPersona[IdPersonaUsuarioAuditoria], pa.NombreCompleto[NombreCompletoUsuarioAuditoria], pa.Documento[DocumentoUsuarioAuditoria],
av.DescripcionAuditoria, av.FechaAuditoria,
av.IdVenta,
av.IdUsuario, uv.IdPersona[IdPersonaUsuarioVenta], pv.NombreCompleto[NombreCompletoUsuarioVenta], pv.Documento[DocumentoUsuarioVenta],
av.IdCliente, pc.IdPersona[IdPersonaClienteVenta], pc.NombreCompleto[NombreCompletoClienteVenta], pc.Documento[DocumentoClienteVenta],
TipoDocumento, NumeroDocumento, TipoDescuento, MontoDescuento, SubTotal, MontoPago, MontoCambio, MontoTotal, FechaRegistro
from AuditoriaVenta av
--Usuario Auditoria ua--
inner join Usuario ua on av.IdUsuarioAuditoria = ua.IdUsuario
inner join Persona pa on ua.IdUsuario = pa.IdPersona
--Usuario Venta uv--
inner join Usuario uv on av.IdUsuario = uv.IdUsuario
inner join Persona pv on uv.IdPersona = pv.IdPersona
--Cliente Venta cv--
inner join Cliente cv on av.IdCliente = cv.IdCliente
inner join Persona pc on cv.IdPersona = pc.IdPersona

--SELECT OBTENER AUDTIROA VENTA--
select
av.IdAuditoriaVenta,
av.IdUsuarioAuditoria, ua.IdPersona[IdPersonaUsuarioAuditoria], pa.NombreCompleto[NombreCompletoUsuarioAuditoria], pa.Documento[DocumentoUsuarioAuditoria],
av.DescripcionAuditoria, av.FechaAuditoria,
av.IdVenta,
av.IdUsuario, uv.IdPersona[IdPersonaUsuarioVenta], pv.NombreCompleto[NombreCompletoUsuarioVenta], pv.Documento[DocumentoUsuarioVenta],
av.IdCliente, pc.IdPersona[IdPersonaClienteVenta], pc.NombreCompleto[NombreCompletoClienteVenta], pc.Documento[DocumentoClienteVenta],
TipoDocumento, NumeroDocumento, TipoDescuento, MontoDescuento, SubTotal, MontoPago, MontoCambio, MontoTotal, FechaRegistro
from AuditoriaVenta av
--Usuario Auditoria ua--
inner join Usuario ua on av.IdUsuarioAuditoria = ua.IdUsuario
inner join Persona pa on ua.IdUsuario = pa.IdPersona
--Usuario Venta uv--
inner join Usuario uv on av.IdUsuario = uv.IdUsuario
inner join Persona pv on uv.IdPersona = pv.IdPersona
--Cliente Venta cv--
inner join Cliente cv on av.IdCliente = cv.IdCliente
inner join Persona pc on cv.IdPersona = pc.IdPersona
where av.IdAuditoriaVenta = @idAuditoriaVenta

--SELECT OBTENER AUDITORIA DETALLE VENTA--
select p.Nombre,
adv.DescripcionAuditoria, adv.FechaAuditoria,
adv.PrecioVenta, adv.Cantidad, adv.SubTotal
from AuditoriaDetalleVenta adv
inner join Producto p on p.IdProducto = adv.IdProducto
where adv.IdAuditoriaVenta = @idAuditoriaVenta