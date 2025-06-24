Imports MySql.Data.MySqlClient
Public Class Conexion
    Private myconexion As MySqlConnection

    Public Sub New()
        Dim cadena As String = "server=localhost;user=root;password=password;database=login;"
        myconexion = New MySqlConnection(cadena)
    End Sub

    Public Function Open() As MySqlConnection
        If myconexion.State = ConnectionState.Closed Then
            myconexion.Open()
            'MessageBox.Show("Hola la conexion es exitosa")

        End If
        Return myconexion
    End Function

    Public Sub Cerrar()
        If myconexion.State = ConnectionState.Open Then
            myconexion.Close()
            'MessageBox.Show("Hola la conexion se cerró correctamente")
        End If
    End Sub
End Class
