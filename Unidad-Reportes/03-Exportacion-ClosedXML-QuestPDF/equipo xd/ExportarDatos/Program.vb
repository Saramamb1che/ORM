Imports System.Windows.Forms

' Punto de entrada de la aplicación.
Module Program

    <STAThread>
    Sub Main()
        Application.SetHighDpiMode(HighDpiMode.SystemAware)
        Application.EnableVisualStyles()
        Application.SetCompatibleTextRenderingDefault(False)

        ' QuestPDF exige declarar la licencia una vez, al iniciar la aplicación.
        ' Community: gratuita para docencia en instituciones académicas.
        QuestPDF.Settings.License = QuestPDF.Infrastructure.LicenseType.Community

        Application.Run(New FrmExportar())
    End Sub

End Module
