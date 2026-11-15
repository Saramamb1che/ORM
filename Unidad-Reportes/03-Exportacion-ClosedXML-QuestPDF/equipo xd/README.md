# Tema 3 · Exportación con ClosedXML y QuestPDF

Formulario con los botones **Exportar a Excel** (ClosedXML) y **Exportar a PDF** (QuestPDF) que generan archivos con formato directamente desde el `DataTable` de alumnos, sin visor y sin Office instalado.

📘 **Guía paso a paso:** abre [`guia/Guia-03-ClosedXML-QuestPDF.html`](guia/Guia-03-ClosedXML-QuestPDF.html) en el navegador.

## Contenido

| Carpeta / archivo | Descripción |
|---|---|
| `src/ExportarDatos.slnx` | Solución de Visual Studio 2026 |
| `src/ExportarDatos/` | Proyecto de referencia (VB.NET, .NET 10) |
| `src/ExportarDatos/ExportadorExcel.vb` | Genera el `.xlsx`: logo, títulos, datos, formato condicional y fórmulas |
| `src/ExportarDatos/ExportadorPdf.vb` | Genera el `.pdf`: encabezado con logo, tabla y “Página N de M” |
| `ejemplos/Alumnos.xlsx`, `ejemplos/Alumnos.pdf` | Archivos generados con este código y los 60 registros del script |

La base de datos es la del tema 1: [`01-PrintDocument/bd/reportes_pae.sql`](../01-PrintDocument/bd/reportes_pae.sql).

## Paquetes NuGet

| Paquete | Versión | Licencia |
|---|---|---|
| `MySqlConnector` | 2.4.0 | MIT |
| `ClosedXML` | 0.105.1 | MIT |
| `QuestPDF` | 2026.9.1 | Community (gratuita para docencia en instituciones académicas y para quien aprende) |

## Ejecutar la solución de referencia

1. Ejecuta el script SQL del tema 1 en MariaDB (si aún no lo hiciste).
2. Abre `src/ExportarDatos.slnx`.
3. En `ConexionBD.vb` ajusta `Uid` y `Pwd`.
4. Ejecuta con **F5** → *Cargar datos* → *Exportar a Excel* / *Exportar a PDF*.

## Entrega de la tarea

Trabaja en una rama de tu equipo y sube tu proyecto en:

```
03-Exportacion-ClosedXML-QuestPDF/entregas/<nombre-del-equipo>/
```
