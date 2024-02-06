use DB_SDC;

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
v.TipoDocumento, v.NumeroDocumento, v.MontoPago, v.MontoCambio, v.MontoTotal, convert(char(10),v.FechaRegistro,103)[FechaRegistro]
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
v.TipoDocumento, v.NumeroDocumento, v.MontoPago, v.MontoCambio, v.MontoTotal, convert(char(10),v.FechaRegistro,103)[FechaRegistro]
from Venta v
inner join Usuario u on u.IdUsuario = v.IdUsuario
inner join Persona pu on pu.IdPersona = u.IdPersona
inner join Cliente c on c.IdCliente = v.IdCliente
inner join Persona pc on pc.IdPersona = c.IdPersona