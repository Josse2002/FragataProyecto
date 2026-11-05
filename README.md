# Fragata Gift

Proyecto desarrollado en **C#** para administrar los productos, pedidos y ventas de **Fragata Gift**, un negocio dedicado a la venta de regalos y arreglos personalizados.

El sistema se divide en dos partes: una **aplicación de escritorio** para gestionar los procesos internos del negocio y una **página web** donde los clientes pueden ver los productos y realizar sus pedidos. Ambas utilizan la misma lógica de negocio y se conectan a una base de datos en SQL Server.

## ¿Qué hace el proyecto?

Desde la **aplicación de escritorio** se pueden administrar los productos, las existencias y los materiales utilizados para elaborar los arreglos. También cuenta con módulos para gestionar clientes, empleados, proveedores, pedidos, ventas, envíos y facturas. Incluye un tablero con información general, notificaciones y la opción de generar e imprimir facturas.

La **página web** permite consultar el catálogo de productos, filtrarlos por categorías como ramos, globos, dulceros y bisutería, agregar productos al carrito y realizar pedidos. Los clientes pueden registrarse e iniciar sesión, además de seleccionar si desean retirar su pedido en el negocio o solicitar un envío. El código también contempla el envío de un resumen de compra por correo electrónico.

## Tecnologías utilizadas

- **C# y .NET Framework 4.7.2** para el desarrollo del sistema.
- **Windows Forms** para la aplicación de escritorio, utilizando componentes de Guna UI2.
- **ASP.NET Web Forms**, HTML, CSS, JavaScript y Bootstrap para la página web.
- **SQL Server** para almacenar la información, con acceso mediante ADO.NET y procedimientos almacenados.
- **Crystal Reports** para generar y mostrar facturas desde la aplicación de escritorio.

## Estructura del proyecto

```text
Fragata.BL/          Lógica de negocio y operaciones del sistema
Fragata.DAL/         Acceso a la base de datos
Fragata.Entities/    Entidades y modelos utilizados
Fragata.UI.WF/       Aplicación de escritorio (Windows Forms)
Fragata.Web/         Página web (ASP.NET Web Forms)
Fragata.Proyecto.sln Solución para Visual Studio
```

Se utilizó una arquitectura por capas para separar la interfaz, la lógica de negocio y el acceso a los datos, de forma que la aplicación web y la de escritorio pudieran reutilizar las mismas clases.

## Estado del proyecto

Este proyecto fue desarrollado en **2022** y actualmente se conserva como referencia del trabajo realizado. **No se ha comprobado que pueda ejecutarse con su configuración original**, ya que utiliza tecnologías y dependencias de esa época.

Para intentar levantarlo sería necesario recuperar la base de datos de SQL Server y sus procedimientos almacenados, configurar la conexión a la base de datos y disponer de las dependencias necesarias para Windows Forms, ASP.NET Web Forms y Crystal Reports. La configuración del repositorio hace referencia a instancias locales de SQL Server, por lo que no basta con abrir la solución para garantizar que todo funcione.

El repositorio se mantiene principalmente como muestra de la estructura y funcionalidades que se desarrollaron para Fragata Gift.
