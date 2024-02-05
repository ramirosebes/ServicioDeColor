select * from Componente;
select * from Permiso;
select * from GrupoPermiso;
select * from GrupoPermisoComponente;
select * from UsuarioComponente;

--LISTAR COMPRAS--
SELECT c.IdCompra, c.IdUsuario, u.IdPersona, ps.NombreCompleto, c.IdProveedor, p.NombreCompleto,TipoDocumento, NumeroDocumento, MontoTotal, FechaRegistro FROM Compra c
INNER JOIN Usuario u ON c.IdUsuario = u.IdUsuario
INNER JOIN Proveedor p ON c.IdProveedor = p.IdProveedor
INNER JOIN Persona ps ON u.IdPersona = ps.IdPersona

SELECT c.IdCompra, c.IdUsuario, u.IdPersona, ps.NombreCompleto, c.IdProveedor, p.NombreCompleto,TipoDocumento, NumeroDocumento, MontoTotal, FechaRegistro FROM Compra c
INNER JOIN Usuario u ON c.IdUsuario = u.IdUsuario
INNER JOIN Proveedor p ON c.IdProveedor = p.IdProveedor
INNER JOIN Persona ps ON u.IdPersona = ps.IdPersona

select c.IdCompra, c.IdUsuario, ps.NombreCompleto, pr.CUIT, pr.RazonSocial, c.TipoDocumento, c.NumeroDocumento, c.MontoTotal, convert(char(10), c.FechaRegistro, 103)[FechaRegistro] from Compra c
inner join Usuario u on u.IdUsuario = c.IdUsuario
inner join Persona ps on ps.IdPersona = u.IdPersona
inner join Proveedor pr on pr.IdProveedor = c.IdProveedor
where c.NumeroDocumento = 1
