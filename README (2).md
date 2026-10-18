# Unidad: Generación de Reportes en Windows Forms

**Programación de Aplicaciones de Escritorio** · VB.NET · Windows Forms · .NET 10 · MariaDB

Un reporte transforma los datos de MariaDB en un documento que se puede **ver, imprimir o guardar** (listados, constancias, facturas). La unidad avanza de lo más manual a lo más automatizado:

| # | Tema | ¿Para qué sirve? | ¿Qué se aprende a hacer? |
|---|------|------------------|--------------------------|
| 1 | [**PrintDocument + PrintPreviewDialog**](01-PrintDocument/) | Imprimir sin paquetes externos: tickets, constancias, listados simples. Es la base de cualquier herramienta de reportes. | Dibujar texto, líneas e imágenes con `Graphics`; controlar la paginación con `HasMorePages`; mostrar la vista previa, configurar la página y elegir la impresora (o *Microsoft Print to PDF*). |
| 2 | [**ReportViewer Core + RDLC**](02-ReportViewer-RDLC/) | Reportes formales de negocio diseñados visualmente, sin calcular coordenadas a mano. | Diseñar un `.rdlc`, alimentarlo con un `DataTable`, agrupar (por carrera), calcular totales, recibir parámetros y exportar a PDF, Excel o Word desde el visor. |
| 3 | [**ClosedXML / QuestPDF**](03-Exportacion-ClosedXML-QuestPDF/) | Generar archivos directamente desde un botón “Exportar”, sin abrir un visor. | Crear un `.xlsx` con formato a partir de un `DataTable` (ClosedXML) y un PDF compuesto por código (QuestPDF). |

> Idea central: en el tema 1 **tú** dibujas cada página. En el tema 2 el **motor de reportes** lo hace por ti. En el tema 3 generas **archivos** listos para enviar.

## Estructura

```
Unidad-Reportes/
├── README.md                      ← este archivo
├── recursos/logos/                ← logo UNI azul y blanco
├── 01-PrintDocument/
│   ├── README.md
│   ├── guia/Guia-01-PrintDocument.html
│   ├── bd/reportes_pae.sql        ← base de datos de toda la unidad
│   └── src/ReporteImpresion/      ← solución de referencia
├── 02-ReportViewer-RDLC/
│   ├── README.md
│   ├── guia/Guia-02-ReportViewer-RDLC.html
│   └── src/ReporteRDLC/           ← solución de referencia + Reportes/RptAlumnos.rdlc
└── 03-Exportacion-ClosedXML-QuestPDF/
    ├── README.md
    ├── guia/Guia-03-ClosedXML-QuestPDF.html
    ├── ejemplos/                  ← Alumnos.xlsx y Alumnos.pdf de referencia
    └── src/ExportarDatos/         ← solución de referencia
```

Cada tema tiene su carpeta `entregas/<nombre-del-equipo>/` para las tareas.
