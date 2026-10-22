# InventarioORM

Práctica de mantenimiento de productos de la Librería y Papelería Segovia con Visual Basic, Windows Forms, MariaDB y Entity Framework Core.

## Integrantes

Equipo sin nombre asignado.

- David Antonio.
- Omar.
- Maxbell.
- Antonella.

## Requisitos

- Visual Studio 2026 con desarrollo de escritorio de .NET.
- .NET 10 y MariaDB.
- Pomelo.EntityFrameworkCore.MySql 9.0.0, con sus dependencias de EF Core 9.

## Ejecución

1. Ejecutar database/libreria_segovia.sql en MariaDB para crear las tablas y los datos de ejemplo.
2. Abrir src/InventarioORM.sln en Visual Studio.
3. Ajustar puerto, usuario, contraseña y versión del servidor en src/InventarioORM/ConexionBD.vb. La configuración incluida usa MariaDB 12.3 en el puerto 3307; cambiar estos valores si la instalación utiliza otros. Sustituir SU_CONTRASEÑA únicamente en la copia local.
4. Restaurar los paquetes NuGet y compilar con Ctrl+Shift+B.
5. Ejecutar con F5.

## Funciones disponibles

- Listado y búsqueda de productos por nombre.
- Crear, actualizar y eliminar productos con confirmación.
- Validación del nombre y de la categoría.
- Precios en córdobas y selección de categorías.
- Operaciones asíncronas y control de concurrencia mediante version_fila.
- Filtro por categoría, con la opción Todas.
- Filtro de existencia menor a 10, combinado con categoría y búsqueda.
- Valor global del inventario: suma de precio por existencia de todos los productos.
- Rechazo de nombres duplicados al guardar un producto nuevo.

Para comprobar la concurrencia, abrir dos instancias, seleccionar el mismo producto en ambas y actualizar primero en una y después en la otra. La segunda debe informar el conflicto y volver a cargar los datos.

## Pruebas del CRUD inicial

- Carga de las cuatro categorías y los seis productos de ejemplo.
- Validación del nombre vacío, creación, búsqueda y actualización desde el formulario.
- Comprobación de la eliminación con EF Core y del control de versión al actualizar y eliminar.
- Conflicto de actualización entre dos ventanas: se mostró el aviso y se conservó el primer cambio.

Los registros temporales de esa comprobación se retiraron. El script de instalación contiene cuatro categorías y seis productos de ejemplo.

## Revisión de este avance

- Se corrigió la carga del filtro: primero se definen Nombre e Id y después se asigna la lista de categorías.
- Los cambios del filtro no consultan la base mientras se llena el combo.
- Los controles de filtro se bloquean durante las operaciones y muestran un aviso si la consulta falla.
- Al guardar, actualizar o eliminar, se conserva el texto de búsqueda al refrescar la lista.
- Se retiró un ComboBox vacío que no se utilizaba en el formulario.

## Pruebas de este avance (21 de octubre de 2026)

| Comprobación | Resultado |
|---|---|
| Compilación y ejecución desde Visual Studio | Compilación correcta; el formulario abrió con los seis productos. |
| Carga inicial de filtros | Todas y las cuatro categorías disponibles, sin error de conversión. |
| Filtro Papelería | Dos productos; total global C$ 27,110.00. |
| Papelería y existencia menor a 10 | Cero coincidencias; total global sin cambios. |
| Alta desde el formulario | Producto temporal con precio C$ 10.00 y existencia 5; el total global pasó a C$ 27,160.00. |
| Guardar un nombre duplicado | Apareció el aviso y no se agregó otra fila. |
| Categoría, existencia y búsqueda combinadas | Se mostró únicamente el producto temporal que cumplía los tres filtros. |
| Actualización desde el formulario | Precio C$ 11.00 y versión 2; se conservó el texto de búsqueda y el total pasó a C$ 27,165.00. |
| Búsqueda sin coincidencias | Cero productos, sin error y sin cambiar el total global. |
| CRUD y concurrencia con EF Core | Alta y consulta correctas; actualización y eliminación con una versión antigua rechazadas; el primer cambio se conservó. |
| Limpieza de pruebas | Se retiraron únicamente los productos temporales; quedaron cuatro categorías, seis productos, versiones iniciales y total C$ 27,110.00. |

Las pruebas de este avance corresponden a las funciones disponibles. Categorías y código de barras se comprobarán después de recibir e integrar esas tareas.

## Comprobaciones antes de la entrega final

1. Compilar Debug y abrir el programa con las credenciales locales.
2. Comprobar el listado inicial de cuatro categorías y seis productos, sin errores al cargar los filtros.
3. Crear, buscar, actualizar y eliminar un producto temporal. No modificar los registros originales para estas pruebas.
4. Guardar un nombre existente y comprobar que no se agrega un duplicado.
5. Combinar búsqueda, categoría y existencia menor a 10. Verificar también una búsqueda sin resultados.
6. Confirmar que el total del inventario no cambia al aplicar filtros y coincide con la suma de precio por existencia de todos los productos.
7. Repetir la prueba de concurrencia con dos ventanas.
8. Después de integrar categorías y código de barras, probar esos cambios junto con los filtros.

## Pendiente de integrar del equipo

- Mantenimiento de categorías, botón para abrirlo y recarga de los combos al cerrar.
- Impedir la eliminación de una categoría con productos y mostrar la cantidad asociada.
- Columna codigo_barras en el SQL, mapeo en las clases y búsqueda por nombre o código, incluyendo códigos nulos.

Estas funciones todavía no están incluidas en esta rama. La comprobación final se realiza cuando estén integradas.

## Entrega

La documentación de la clase está en docs/ORM_EFCore_CRUD_VBNET.html y el script de instalación en database/libreria_segovia.sql.

Se conserva src/InventarioORM/bin/Debug como solicita la guía. Después de las pruebas, dejar Pwd=SU_CONTRASEÑA en ConexionBD.vb y volver a compilar Debug. Subir la carpeta completa: ejecutable, DLL, PDB, archivos de configuración y dependencias. No subir .vs, obj, archivos .user ni bin/Release.
