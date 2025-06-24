Public Class Form1
    Private Sub lblclave_Click(sender As Object, e As EventArgs) Handles lblclave.Click

    End Sub

    Private Sub brnSalir_Click(sender As Object, e As EventArgs) Handles brnSalir.Click
        Me.Close()

    End Sub

    Private Sub btningresar_Click(sender As Object, e As EventArgs) Handles btningresar.Click
        'Validar el nombre del usuario y la contraseña, que no este los espacios vacios' y conectar a la base de datos para comprobar que el usuario existe'
        If String.IsNullOrWhiteSpace(txtClave.Text) Then
            MessageBox.Show("Por favor, ingrese la clave.", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtClave.Focus()
            Exit Sub
        End If
    End Sub
End Class
