Imports MySqlConnector

' Cadena de conexión centralizada.
' ⚠ Ajusta Uid y Pwd con tus credenciales de MariaDB antes de ejecutar.
Module ConexionBD

    Public ReadOnly CadenaConexion As String =
        "Server=localhost;Port=3307;Database=reportes_pae;Uid=root;Pwd=;"

    Public Function ObtenerConexion() As MySqlConnection
        Return New MySqlConnection(CadenaConexion)
    End Function

End Module
