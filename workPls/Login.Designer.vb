<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WND_LOGIN
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TXT_USER = New System.Windows.Forms.TextBox()
        Me.TXT_PSSWRD = New System.Windows.Forms.TextBox()
        Me.CHBOX_CLNT = New System.Windows.Forms.CheckBox()
        Me.CHBOX_RMBR = New System.Windows.Forms.CheckBox()
        Me.BTN_ENTER = New System.Windows.Forms.Button()
        Me.BTN_END = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(602, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(246, 99)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "USUARIO"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(225, 204)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(112, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "CONSTRASEÑA"
        '
        'TXT_USER
        '
        Me.TXT_USER.Location = New System.Drawing.Point(228, 128)
        Me.TXT_USER.Name = "TXT_USER"
        Me.TXT_USER.Size = New System.Drawing.Size(100, 22)
        Me.TXT_USER.TabIndex = 3
        '
        'TXT_PSSWRD
        '
        Me.TXT_PSSWRD.Location = New System.Drawing.Point(228, 245)
        Me.TXT_PSSWRD.Name = "TXT_PSSWRD"
        Me.TXT_PSSWRD.Size = New System.Drawing.Size(100, 22)
        Me.TXT_PSSWRD.TabIndex = 4
        '
        'CHBOX_CLNT
        '
        Me.CHBOX_CLNT.AutoSize = True
        Me.CHBOX_CLNT.Location = New System.Drawing.Point(435, 150)
        Me.CHBOX_CLNT.Name = "CHBOX_CLNT"
        Me.CHBOX_CLNT.Size = New System.Drawing.Size(73, 21)
        Me.CHBOX_CLNT.TabIndex = 5
        Me.CHBOX_CLNT.Text = "Cliente"
        Me.CHBOX_CLNT.UseVisualStyleBackColor = True
        '
        'CHBOX_RMBR
        '
        Me.CHBOX_RMBR.AutoSize = True
        Me.CHBOX_RMBR.Location = New System.Drawing.Point(435, 216)
        Me.CHBOX_RMBR.Name = "CHBOX_RMBR"
        Me.CHBOX_RMBR.Size = New System.Drawing.Size(108, 21)
        Me.CHBOX_RMBR.TabIndex = 6
        Me.CHBOX_RMBR.Text = "Recordarme"
        Me.CHBOX_RMBR.UseVisualStyleBackColor = True
        '
        'BTN_ENTER
        '
        Me.BTN_ENTER.Location = New System.Drawing.Point(166, 338)
        Me.BTN_ENTER.Name = "BTN_ENTER"
        Me.BTN_ENTER.Size = New System.Drawing.Size(75, 23)
        Me.BTN_ENTER.TabIndex = 7
        Me.BTN_ENTER.Text = "Entrar"
        Me.BTN_ENTER.UseVisualStyleBackColor = True
        '
        'BTN_END
        '
        Me.BTN_END.Location = New System.Drawing.Point(316, 339)
        Me.BTN_END.Name = "BTN_END"
        Me.BTN_END.Size = New System.Drawing.Size(75, 23)
        Me.BTN_END.TabIndex = 8
        Me.BTN_END.Text = "Salir"
        Me.BTN_END.UseVisualStyleBackColor = True
        '
        'WND_LOGIN
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(602, 450)
        Me.Controls.Add(Me.BTN_END)
        Me.Controls.Add(Me.BTN_ENTER)
        Me.Controls.Add(Me.CHBOX_RMBR)
        Me.Controls.Add(Me.CHBOX_CLNT)
        Me.Controls.Add(Me.TXT_PSSWRD)
        Me.Controls.Add(Me.TXT_USER)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "WND_LOGIN"
        Me.Text = "Login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TXT_USER As TextBox
    Friend WithEvents TXT_PSSWRD As TextBox
    Friend WithEvents CHBOX_CLNT As CheckBox
    Friend WithEvents CHBOX_RMBR As CheckBox
    Friend WithEvents BTN_ENTER As Button
    Friend WithEvents BTN_END As Button
End Class
