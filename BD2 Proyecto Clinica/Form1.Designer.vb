<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        lblUsuario = New Label()
        lblclave = New Label()
        txtUsuario = New TextBox()
        txtClave = New TextBox()
        btningresar = New Button()
        brnSalir = New Button()
        Panel1 = New Panel()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' lblUsuario
        ' 
        lblUsuario.AutoSize = True
        lblUsuario.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblUsuario.ForeColor = SystemColors.Control
        lblUsuario.Location = New Point(56, 32)
        lblUsuario.Name = "lblUsuario"
        lblUsuario.Size = New Size(69, 21)
        lblUsuario.TabIndex = 0
        lblUsuario.Text = "Usuario"
        ' 
        ' lblclave
        ' 
        lblclave.AutoSize = True
        lblclave.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblclave.ForeColor = SystemColors.ControlLightLight
        lblclave.Location = New Point(56, 92)
        lblclave.Name = "lblclave"
        lblclave.Size = New Size(52, 21)
        lblclave.TabIndex = 1
        lblclave.Text = "Clave"
        ' 
        ' txtUsuario
        ' 
        txtUsuario.Location = New Point(56, 56)
        txtUsuario.Name = "txtUsuario"
        txtUsuario.Size = New Size(100, 23)
        txtUsuario.TabIndex = 2
        ' 
        ' txtClave
        ' 
        txtClave.Location = New Point(56, 116)
        txtClave.Name = "txtClave"
        txtClave.PasswordChar = "*"c
        txtClave.Size = New Size(100, 23)
        txtClave.TabIndex = 3
        ' 
        ' btningresar
        ' 
        btningresar.Location = New Point(17, 157)
        btningresar.Name = "btningresar"
        btningresar.Size = New Size(75, 23)
        btningresar.TabIndex = 4
        btningresar.Text = "Ingresar"
        btningresar.UseVisualStyleBackColor = True
        ' 
        ' brnSalir
        ' 
        brnSalir.Location = New Point(116, 157)
        brnSalir.Name = "brnSalir"
        brnSalir.Size = New Size(75, 23)
        brnSalir.TabIndex = 5
        brnSalir.Text = "Salir"
        brnSalir.UseVisualStyleBackColor = True
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.LightGray
        Panel1.BorderStyle = BorderStyle.Fixed3D
        Panel1.Controls.Add(lblUsuario)
        Panel1.Controls.Add(brnSalir)
        Panel1.Controls.Add(txtUsuario)
        Panel1.Controls.Add(btningresar)
        Panel1.Controls.Add(txtClave)
        Panel1.Controls.Add(lblclave)
        Panel1.Location = New Point(384, 100)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(228, 208)
        Panel1.TabIndex = 6
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(0), CByte(192), CByte(192))
        BackgroundImage = My.Resources.Resources.Login
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(656, 455)
        Controls.Add(Panel1)
        DoubleBuffered = True
        FormBorderStyle = FormBorderStyle.Fixed3D
        Name = "Form1"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents lblUsuario As Label
    Friend WithEvents lblclave As Label
    Friend WithEvents txtUsuario As TextBox
    Friend WithEvents txtClave As TextBox
    Friend WithEvents btningresar As Button
    Friend WithEvents brnSalir As Button
    Friend WithEvents Panel1 As Panel

End Class
