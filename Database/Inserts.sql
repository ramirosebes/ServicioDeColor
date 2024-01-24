use DB_SDC

go

insert into Persona(NombreCompleto,Correo,Documento)
values ('Administrador','administrador@gmail.com','10'),('Ramiro Sebes','ramirosebes@gmail.com','11')
go

insert into Usuario(IdPersona,Clave,Estado)
values (1,'10',1),(2,'11',1)
go