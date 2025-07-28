Public Class frmMenuPrincipal
  Implements IFormularios

  Private _forzarSalida As Boolean = False

  WriteOnly Property ForzarSalida As Boolean
    Set(value As Boolean)
      _forzarSalida = value
    End Set
  End Property

  Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
    Me.Close()
  End Sub

  Public Sub AjustarPantalla() Implements IFormularios.AjustarPantalla
    PantallaManager.Inicializar(Me.pnlPantallas)

    btnConsultas.Enabled = True
    btnPersonas.Enabled = True
    btnDoctores.Enabled = True
    btnEspecialidades.Enabled = True
    btnUsuarios.Enabled = True
    btnReporte.Enabled = False


    Select Case TipoUsuario
      Case "Administrador"
        btnConsultas.Enabled = False
        btnPersonas.Enabled = False
      Case "Doctor"
        btnDoctores.Enabled = False
        btnEspecialidades.Enabled = False
        btnUsuarios.Enabled = False
      Case "Paciente"
        btnPersonas.Enabled = False
        btnDoctores.Enabled = False
        btnEspecialidades.Enabled = False
        btnUsuarios.Enabled = False
      Case "Secretaria"
        btnConsultas.Enabled = False
        btnEspecialidades.Enabled = False
        btnUsuarios.Enabled = False
        btnReporte.Enabled = True
      Case Else
        MessageBox.Show("Tipo de usuario no soportado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        btnConsultas.Enabled = False
        btnPersonas.Enabled = False
        btnDoctores.Enabled = False
        btnEspecialidades.Enabled = False
        btnUsuarios.Enabled = False
    End Select
  End Sub

  Private Sub btnUsuarios_Click(sender As Object, e As EventArgs) Handles btnUsuarios.Click
    PantallaManager.Limpiar()
    PantallaManager.LlamarPantallaHija(New frmMantUsuarios(), Me)
  End Sub

  Private Sub btnEspecialidades_Click(sender As Object, e As EventArgs) Handles btnEspecialidades.Click
    PantallaManager.Limpiar()
    PantallaManager.LlamarPantallaHija(New frmEspecialidades(), Me)
  End Sub

  Private Sub btnDoctores_Click(sender As Object, e As EventArgs) Handles btnDoctores.Click
    PantallaManager.Limpiar()
    PantallaManager.LlamarPantallaHija(New frmMantDoctores(), Me)
  End Sub

  Private Sub btnPersonas_Click(sender As Object, e As EventArgs) Handles btnPersonas.Click
    PantallaManager.Limpiar()
    PantallaManager.LlamarPantallaHija(New frmMantPacientes(), Me)
  End Sub

  Private Sub btnConsultas_Click(sender As Object, e As EventArgs) Handles btnConsultas.Click
    PantallaManager.Limpiar()
    PantallaManager.LlamarPantallaHija(New frmConsultaCitas(), Me)
  End Sub

  Private Sub btnReporte_Click(sender As Object, e As EventArgs) Handles btnReporte.Click
    PantallaManager.Limpiar()
    PantallaManager.LlamarPantallaHija(New frmReporte(), Me)
  End Sub

  Private Sub frmMenuPrincipal_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
    If Not _forzarSalida Then
      If MessageBox.Show("¿Está seguro que desea salir de la aplicación?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
        PantallaManager.Finalizar()
        frmLogin.Show()
      Else
        e.Cancel = True
      End If
    Else
      frmLogin.Show()
    End If
  End Sub
End Class