# ORM y unidad de reportes

Prácticas de Programación de Aplicaciones de Escritorio con Visual Basic, Windows Forms, MariaDB y .NET 10.

## Integrantes

: David Antonio, Omar, Maxbell, Antonella.

## Contenido de esta rama

| Carpeta | Contenido |
|---|---|
| Practica_ORM_EFCore | Inventario con CRUD de productos, concurrencia y ejercicios de refuerzo. Consultar su README para ejecutar y revisar pendientes. |
| Unidad-Reportes/01-PrintDocument | Material y proyecto de referencia para impresión. |
| Unidad-Reportes/02-ReportViewer-RDLC | Material y proyecto de referencia para ReportViewer y RDLC. |
| Unidad-Reportes/03-Exportacion-ClosedXML-QuestPDF | Material y proyecto de referencia para Excel y PDF. |

## Ejecución del inventario

1. Seguir [Practica_ORM_EFCore/README.md](Practica_ORM_EFCore/README.md).
2. Ejecutar el SQL del inventario en MariaDB y configurar localmente ConexionBD.vb.
3. Abrir Practica_ORM_EFCore/src/InventarioORM.sln, restaurar NuGet y ejecutar con F5.

## Integración del equipo

Este avance se prepara en la rama 1-inventario. Todavía deben incorporarse categorías y código de barras de ORM y las entregas de reportes de los compañeros.

Las guías piden que cada proyecto de reportes se entregue en Unidad-Reportes/<tema>/entregas/<nombre-del-equipo>/. Los proyectos de referencia permanecen en src. El nombre de la carpeta del equipo queda pendiente de acordar.

Para la entrega final, comprobar los cuatro proyectos juntos, actualizar sus instrucciones y recompilar ORM con Pwd=SU_CONTRASEÑA. La guía de ORM pide conservar bin/Debug; la unidad de reportes excluye bin y obj mediante su .gitignore.
