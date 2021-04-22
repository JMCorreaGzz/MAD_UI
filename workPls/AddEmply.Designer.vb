<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WND_ADD_EMPLY
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TXT_NAME_EMPLY = New System.Windows.Forms.TextBox()
        Me.TXT_APP_EMPLY = New System.Windows.Forms.TextBox()
        Me.TXT_APM_EMPLY = New System.Windows.Forms.TextBox()
        Me.TXT_RFC_EMPLY = New System.Windows.Forms.TextBox()
        Me.TXT_CURP_EMPLY = New System.Windows.Forms.TextBox()
        Me.TXT_USER_EMPLY = New System.Windows.Forms.TextBox()
        Me.TXT_PSSWRD_EMPLY = New System.Windows.Forms.TextBox()
        Me.DT_UD_EMPLY = New System.Windows.Forms.DateTimePicker()
        Me.DTM_BD_EMPLY = New System.Windows.Forms.DateTimePicker()
        Me.BTN_ADD_EMPLY = New System.Windows.Forms.Button()
        Me.BTN_CNCL_EMPLY = New System.Windows.Forms.Button()
        Me.CHB_SHWPSS_EMPLY = New System.Windows.Forms.CheckBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.RD_GENM_EMPLY = New System.Windows.Forms.RadioButton()
        Me.RD_GENF_EMPLY = New System.Windows.Forms.RadioButton()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(43, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "NOMBRE(S)"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(204, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(97, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "AP PATERNO"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(371, 38)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(99, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "AP MATERNO"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(690, 37)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(164, 17)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "FECHA DE NACIMIENTO"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(26, 166)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(177, 17)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "FECHA DE MODIFICACION"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(270, 166)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(35, 17)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "RFC"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(408, 166)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(46, 17)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "CURP"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(563, 166)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(70, 17)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "USUARIO"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(728, 166)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(103, 17)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "CONTRASEÑA"
        '
        'TXT_NAME_EMPLY
        '
        Me.TXT_NAME_EMPLY.Location = New System.Drawing.Point(12, 73)
        Me.TXT_NAME_EMPLY.Name = "TXT_NAME_EMPLY"
        Me.TXT_NAME_EMPLY.Size = New System.Drawing.Size(148, 22)
        Me.TXT_NAME_EMPLY.TabIndex = 9
        '
        'TXT_APP_EMPLY
        '
        Me.TXT_APP_EMPLY.Location = New System.Drawing.Point(174, 73)
        Me.TXT_APP_EMPLY.Name = "TXT_APP_EMPLY"
        Me.TXT_APP_EMPLY.Size = New System.Drawing.Size(154, 22)
        Me.TXT_APP_EMPLY.TabIndex = 10
        '
        'TXT_APM_EMPLY
        '
        Me.TXT_APM_EMPLY.Location = New System.Drawing.Point(339, 73)
        Me.TXT_APM_EMPLY.Name = "TXT_APM_EMPLY"
        Me.TXT_APM_EMPLY.Size = New System.Drawing.Size(163, 22)
        Me.TXT_APM_EMPLY.TabIndex = 11
        '
        'TXT_RFC_EMPLY
        '
        Me.TXT_RFC_EMPLY.Location = New System.Drawing.Point(224, 209)
        Me.TXT_RFC_EMPLY.Name = "TXT_RFC_EMPLY"
        Me.TXT_RFC_EMPLY.Size = New System.Drawing.Size(126, 22)
        Me.TXT_RFC_EMPLY.TabIndex = 14
        '
        'TXT_CURP_EMPLY
        '
        Me.TXT_CURP_EMPLY.Location = New System.Drawing.Point(363, 209)
        Me.TXT_CURP_EMPLY.Name = "TXT_CURP_EMPLY"
        Me.TXT_CURP_EMPLY.Size = New System.Drawing.Size(139, 22)
        Me.TXT_CURP_EMPLY.TabIndex = 15
        '
        'TXT_USER_EMPLY
        '
        Me.TXT_USER_EMPLY.Location = New System.Drawing.Point(523, 209)
        Me.TXT_USER_EMPLY.Name = "TXT_USER_EMPLY"
        Me.TXT_USER_EMPLY.Size = New System.Drawing.Size(147, 22)
        Me.TXT_USER_EMPLY.TabIndex = 16
        '
        'TXT_PSSWRD_EMPLY
        '
        Me.TXT_PSSWRD_EMPLY.Location = New System.Drawing.Point(693, 209)
        Me.TXT_PSSWRD_EMPLY.Name = "TXT_PSSWRD_EMPLY"
        Me.TXT_PSSWRD_EMPLY.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TXT_PSSWRD_EMPLY.Size = New System.Drawing.Size(169, 22)
        Me.TXT_PSSWRD_EMPLY.TabIndex = 17
        '
        'DT_UD_EMPLY
        '
        Me.DT_UD_EMPLY.Location = New System.Drawing.Point(12, 209)
        Me.DT_UD_EMPLY.Name = "DT_UD_EMPLY"
        Me.DT_UD_EMPLY.Size = New System.Drawing.Size(200, 22)
        Me.DT_UD_EMPLY.TabIndex = 18
        '
        'DTM_BD_EMPLY
        '
        Me.DTM_BD_EMPLY.Location = New System.Drawing.Point(675, 72)
        Me.DTM_BD_EMPLY.Name = "DTM_BD_EMPLY"
        Me.DTM_BD_EMPLY.Size = New System.Drawing.Size(200, 22)
        Me.DTM_BD_EMPLY.TabIndex = 19
        '
        'BTN_ADD_EMPLY
        '
        Me.BTN_ADD_EMPLY.Location = New System.Drawing.Point(663, 347)
        Me.BTN_ADD_EMPLY.Name = "BTN_ADD_EMPLY"
        Me.BTN_ADD_EMPLY.Size = New System.Drawing.Size(100, 27)
        Me.BTN_ADD_EMPLY.TabIndex = 20
        Me.BTN_ADD_EMPLY.Text = "Agregar"
        Me.BTN_ADD_EMPLY.UseVisualStyleBackColor = True
        '
        'BTN_CNCL_EMPLY
        '
        Me.BTN_CNCL_EMPLY.Location = New System.Drawing.Point(782, 347)
        Me.BTN_CNCL_EMPLY.Name = "BTN_CNCL_EMPLY"
        Me.BTN_CNCL_EMPLY.Size = New System.Drawing.Size(104, 27)
        Me.BTN_CNCL_EMPLY.TabIndex = 21
        Me.BTN_CNCL_EMPLY.Text = "Cancelar"
        Me.BTN_CNCL_EMPLY.UseVisualStyleBackColor = True
        '
        'CHB_SHWPSS_EMPLY
        '
        Me.CHB_SHWPSS_EMPLY.AutoSize = True
        Me.CHB_SHWPSS_EMPLY.Location = New System.Drawing.Point(699, 253)
        Me.CHB_SHWPSS_EMPLY.Name = "CHB_SHWPSS_EMPLY"
        Me.CHB_SHWPSS_EMPLY.Size = New System.Drawing.Size(155, 21)
        Me.CHB_SHWPSS_EMPLY.TabIndex = 22
        Me.CHB_SHWPSS_EMPLY.Text = "Mostrar Contraseña"
        Me.CHB_SHWPSS_EMPLY.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(566, 37)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(68, 17)
        Me.Label10.TabIndex = 23
        Me.Label10.Text = "GENERO"
        '
        'RD_GENM_EMPLY
        '
        Me.RD_GENM_EMPLY.AutoSize = True
        Me.RD_GENM_EMPLY.Location = New System.Drawing.Point(547, 73)
        Me.RD_GENM_EMPLY.Name = "RD_GENM_EMPLY"
        Me.RD_GENM_EMPLY.Size = New System.Drawing.Size(40, 21)
        Me.RD_GENM_EMPLY.TabIndex = 24
        Me.RD_GENM_EMPLY.TabStop = True
        Me.RD_GENM_EMPLY.Text = "M"
        Me.RD_GENM_EMPLY.UseVisualStyleBackColor = True
        '
        'RD_GENF_EMPLY
        '
        Me.RD_GENF_EMPLY.AutoSize = True
        Me.RD_GENF_EMPLY.Location = New System.Drawing.Point(612, 73)
        Me.RD_GENF_EMPLY.Name = "RD_GENF_EMPLY"
        Me.RD_GENF_EMPLY.Size = New System.Drawing.Size(37, 21)
        Me.RD_GENF_EMPLY.TabIndex = 25
        Me.RD_GENF_EMPLY.TabStop = True
        Me.RD_GENF_EMPLY.Text = "F"
        Me.RD_GENF_EMPLY.UseVisualStyleBackColor = True
        '
        'WND_ADD_EMPLY
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(894, 386)
        Me.Controls.Add(Me.RD_GENF_EMPLY)
        Me.Controls.Add(Me.RD_GENM_EMPLY)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.CHB_SHWPSS_EMPLY)
        Me.Controls.Add(Me.BTN_CNCL_EMPLY)
        Me.Controls.Add(Me.BTN_ADD_EMPLY)
        Me.Controls.Add(Me.DTM_BD_EMPLY)
        Me.Controls.Add(Me.DT_UD_EMPLY)
        Me.Controls.Add(Me.TXT_PSSWRD_EMPLY)
        Me.Controls.Add(Me.TXT_USER_EMPLY)
        Me.Controls.Add(Me.TXT_CURP_EMPLY)
        Me.Controls.Add(Me.TXT_RFC_EMPLY)
        Me.Controls.Add(Me.TXT_APM_EMPLY)
        Me.Controls.Add(Me.TXT_APP_EMPLY)
        Me.Controls.Add(Me.TXT_NAME_EMPLY)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "WND_ADD_EMPLY"
        Me.Text = "AÑADIR EMPLEADO"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents TXT_NAME_EMPLY As TextBox
    Friend WithEvents TXT_APP_EMPLY As TextBox
    Friend WithEvents TXT_APM_EMPLY As TextBox
    Friend WithEvents TXT_RFC_EMPLY As TextBox
    Friend WithEvents TXT_CURP_EMPLY As TextBox
    Friend WithEvents TXT_USER_EMPLY As TextBox
    Friend WithEvents TXT_PSSWRD_EMPLY As TextBox
    Friend WithEvents DT_UD_EMPLY As DateTimePicker
    Friend WithEvents DTM_BD_EMPLY As DateTimePicker
    Friend WithEvents BTN_ADD_EMPLY As Button
    Friend WithEvents BTN_CNCL_EMPLY As Button
    Friend WithEvents CHB_SHWPSS_EMPLY As CheckBox
    Friend WithEvents Label10 As Label
    Friend WithEvents RD_GENM_EMPLY As RadioButton
    Friend WithEvents RD_GENF_EMPLY As RadioButton
End Class
