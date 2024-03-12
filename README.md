# Servicio De Color
> Proyecto

Este proyecto es parte del trabajo de diploma para la carrera de Analista en Sistemas Informáticos de la Universidad Abierta Interamericana (UAI). El software está desarrollado como parte de las materias de Ingeniería de Software y Trabajo de Diploma.

## Descripcion del sistema

El Sistema de Compra/Venta de mercadería, denominado Servicio De Color (SDC), es una aplicación desarrollada en C# utilizando Windows Forms. El objetivo principal de SDC es facilitar la gestión de compras y ventas relacionadas con la producción y comercialización de colores para automóviles.

## Requerimientos funcionales

* Gestion de Usuarios
* Gestion de Permisos
* Gestion de Proveedores
* Gestion de Categorias
* Gestion de Productos
* Gestion de Ordenes de compras
* Gestion de Clientes
* Gestion de Pedidos de ventas
* Gestion de Reportes
* Gestion de Auditorias

## Arquitectura

Se ha seleccionado la arquitectura de capas para el desarrollo del sistema.

* **Capa de Datos**: Maneja la conexión con la base de datos y los procesos de Alta, Baja y Modificación.
* **Capa de Entidad**: Define las entidades y su composición para su uso en el proyecto.
* **Capa Controladora**: Contiene la lógica de negocio.
* **Capa de Presentación**: Incluye todos los formularios y la interfaz de usuario.

Para los procedimientos de Alta, Baja y Modificacion se utilizaron Procedimientos Almacenados dentre de la Base de Datos.

## Patrones utilizados

* **Singleton**: Implementado para la gestión de la conexión a la base de datos.
* **Composite**: Utilizado en el módulo de Permisos para asignar permisos simples o grupos de permisos a los usuarios.
* **Strategy**: Empleado en el cálculo de descuentos en las ventas, permitiendo descuentos sin descuento, fijo o porcentual.

## Instalacion y uso

1. Clona el repositorio a tu máquina local.
2. Importa la Base de Datos
3. Abre la solución en Visual Studio.
4. Compila el proyecto y asegúrate de tener configurada la conexión a la base de datos.
5. Ejecuta la aplicación y comienza a utilizarla.

## Credenciales

**Administrador**
```sh
Documento: 00000001
Clave: 123
```

## Autor

| Nombre | Mail     | Github                | LinkedIn                |
| :-------- | :------- | :------------------------- | :------------------------- |
| Sebes Ramiro Nicolás | ramirosebes@gmail.com | [@ramirosebes](https://github.com/ramirosebes) | [Sebes Ramiro Nicolás](https://www.linkedin.com/in/ramirosebes) |
