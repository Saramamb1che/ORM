# InventarioORM

Práctica de mantenimiento de productos de la Librería y Papelería Segovia con Visual Basic, Windows Forms, MariaDB y Entity Framework Core.

## Requisitos

- Visual Studio 2026 con desarrollo de escritorio de .NET.
- .NET 10 y MariaDB.
- Pomelo.EntityFrameworkCore.MySql 9.0.0, con sus dependencias de EF Core 9.

## Ejecución

1. Ejecutar database/libreria_segovia.sql en MariaDB para crear las tablas y los datos de ejemplo.
2. Abrir src/InventarioORM.sln en Visual Studio.
3. Ajustar puerto, usuario, contraseña y versión del servidor en ConexionBD.vb. En este equipo MariaDB utiliza el puerto 3307 y la versión 12.3.
4. Restaurar los paquetes NuGet y compilar con Ctrl+Shift+B.
5. Ejecutar con F5.

## Funciones de esta primera parte

- Listado y búsqueda de productos por nombre.
- Crear, actualizar y eliminar productos con confirmación.
- Validación del nombre y de la categoría.
- Precios en córdobas y selección de categorías.
- Operaciones asíncronas y control de concurrencia mediante version_fila.

Para comprobar la concurrencia, abrir dos instancias, seleccionar el mismo producto en ambas y actualizar primero en una y después en la otra. La segunda debe informar el conflicto y volver a cargar los datos.

## Pruebas realizadas

- Carga de las cuatro categorías y los seis productos de ejemplo.
- Validación del nombre vacío, creación, búsqueda y actualización desde el formulario.
- Comprobación de la eliminación con EF Core y del control de versión al actualizar y eliminar.
- Conflicto de actualización entre dos ventanas: se mostró el aviso y se conservó el primer cambio.

Los registros temporales de prueba se retiraron. La base conserva los seis productos originales con sus precios, existencias y versión iniciales.

## Entrega

Se conserva bin/Debug como solicita la guía. Antes de compilar la versión que se sube, dejar Pwd=SU_CONTRASEÑA en ConexionBD.vb.
