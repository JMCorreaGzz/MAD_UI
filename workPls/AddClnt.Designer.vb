<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WND_ADD_CLNT
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
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.TXT_NAMES_CLNT = New System.Windows.Forms.TextBox()
        Me.TXT_APP_CLNT = New System.Windows.Forms.TextBox()
        Me.TXT_APM_CLNT = New System.Windows.Forms.TextBox()
        Me.RD_G_M_CLNT = New System.Windows.Forms.RadioButton()
        Me.RD_G_F_CLNT = New System.Windows.Forms.RadioButton()
        Me.DT_BORN_CLNT = New System.Windows.Forms.DateTimePicker()
        Me.TXT_CURP_CLNT = New System.Windows.Forms.TextBox()
        Me.TXT_STATE_CLNT = New System.Windows.Forms.TextBox()
        Me.TXT_CNTRY_CLNT = New System.Windows.Forms.TextBox()
        Me.TXT_MUN_CLNT = New System.Windows.Forms.TextBox()
        Me.TXT_STREET_CLNT = New System.Windows.Forms.TextBox()
        Me.TXT_HOME_CLNT = New System.Windows.Forms.TextBox()
        Me.TXT_CP_CLNT = New System.Windows.Forms.TextBox()
        Me.TXT_USER_CLNT = New System.Windows.Forms.TextBox()
        Me.TXT_PSSWRD_CLNT = New System.Windows.Forms.TextBox()
        Me.TXT_EMAIL_CLNT = New System.Windows.Forms.TextBox()
        Me.TXT_MEDIDOR_CLNT = New System.Windows.Forms.TextBox()
        Me.DT_UPDATE_CLNT = New System.Windows.Forms.DateTimePicker()
        Me.BTN_ADD_CLNT = New System.Windows.Forms.Button()
        Me.BTN_CNCL_CLNT = New System.Windows.Forms.Button()
        Me.CHB_SHWPSS_CLNT = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(41, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "NOMBRE(S)"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(177, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(97, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "AP PATERNO"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(313, 43)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(99, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "AP MATERNO"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(452, 43)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 17)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "GENERO"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(45, 145)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 17)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "ESTADO"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(784, 145)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(122, 17)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "CODIGO POSTAL"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(831, 43)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(46, 17)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "CURP"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(194, 142)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(38, 17)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "PAIS"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(307, 142)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(77, 17)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "MUNICIPIO"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(44, 258)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(70, 17)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "USUARIO"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(351, 258)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(48, 17)
        Me.Label11.TabIndex = 10
        Me.Label11.Text = "EMAIL"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(571, 43)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(164, 17)
        Me.Label12.TabIndex = 11
        Me.Label12.Text = "FECHA DE NACIMIENTO"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(492, 143)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(51, 17)
        Me.Label13.TabIndex = 12
        Me.Label13.Text = "CALLE"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(173, 257)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(103, 17)
        Me.Label14.TabIndex = 13
        Me.Label14.Text = "CONTRASEÑA"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(685, 257)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(177, 17)
        Me.Label15.TabIndex = 14
        Me.Label15.Text = "FECHA DE MODIFICACION"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(613, 145)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(132, 17)
        Me.Label16.TabIndex = 15
        Me.Label16.Text = "NUMERO DE CASA"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(461, 259)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(160, 17)
        Me.Label17.TabIndex = 16
        Me.Label17.Text = "NUMERO DE MEDIDOR"
        '
        'TXT_NAMES_CLNT
        '
        Me.TXT_NAMES_CLNT.Location = New System.Drawing.Point(28, 77)
        Me.TXT_NAMES_CLNT.Name = "TXT_NAMES_CLNT"
        Me.TXT_NAMES_CLNT.Size = New System.Drawing.Size(116, 22)
        Me.TXT_NAMES_CLNT.TabIndex = 17
        '
        'TXT_APP_CLNT
        '
        Me.TXT_APP_CLNT.Location = New System.Drawing.Point(169, 77)
        Me.TXT_APP_CLNT.Name = "TXT_APP_CLNT"
        Me.TXT_APP_CLNT.Size = New System.Drawing.Size(113, 22)
        Me.TXT_APP_CLNT.TabIndex = 18
        '
        'TXT_APM_CLNT
        '
        Me.TXT_APM_CLNT.Location = New System.Drawing.Point(307, 76)
        Me.TXT_APM_CLNT.Name = "TXT_APM_CLNT"
        Me.TXT_APM_CLNT.Size = New System.Drawing.Size(111, 22)
        Me.TXT_APM_CLNT.TabIndex = 19
        '
        'RD_G_M_CLNT
        '
        Me.RD_G_M_CLNT.AutoSize = True
        Me.RD_G_M_CLNT.Location = New System.Drawing.Point(445, 76)
        Me.RD_G_M_CLNT.Name = "RD_G_M_CLNT"
        Me.RD_G_M_CLNT.Size = New System.Drawing.Size(40, 21)
        Me.RD_G_M_CLNT.TabIndex = 20
        Me.RD_G_M_CLNT.TabStop = True
        Me.RD_G_M_CLNT.Text = "M"
        Me.RD_G_M_CLNT.UseVisualStyleBackColor = True
        '
        'RD_G_F_CLNT
        '
        Me.RD_G_F_CLNT.AutoSize = True
        Me.RD_G_F_CLNT.Location = New System.Drawing.Point(495, 76)
        Me.RD_G_F_CLNT.Name = "RD_G_F_CLNT"
        Me.RD_G_F_CLNT.Size = New System.Drawing.Size(37, 21)
        Me.RD_G_F_CLNT.TabIndex = 21
        Me.RD_G_F_CLNT.TabStop = True
        Me.RD_G_F_CLNT.Text = "F"
        Me.RD_G_F_CLNT.UseVisualStyleBackColor = True
        '
        'DT_BORN_CLNT
        '
        Me.DT_BORN_CLNT.Location = New System.Drawing.Point(556, 76)
        Me.DT_BORN_CLNT.Name = "DT_BORN_CLNT"
        Me.DT_BORN_CLNT.Size = New System.Drawing.Size(200, 22)
        Me.DT_BORN_CLNT.TabIndex = 22
        '
        'TXT_CURP_CLNT
        '
        Me.TXT_CURP_CLNT.Location = New System.Drawing.Point(787, 75)
        Me.TXT_CURP_CLNT.Name = "TXT_CURP_CLNT"
        Me.TXT_CURP_CLNT.Size = New System.Drawing.Size(138, 22)
        Me.TXT_CURP_CLNT.TabIndex = 23
        '
        'TXT_STATE_CLNT
        '
        Me.TXT_STATE_CLNT.Location = New System.Drawing.Point(24, 181)
        Me.TXT_STATE_CLNT.Name = "TXT_STATE_CLNT"
        Me.TXT_STATE_CLNT.Size = New System.Drawing.Size(120, 22)
        Me.TXT_STATE_CLNT.TabIndex = 24
        '
        'TXT_CNTRY_CLNT
        '
        Me.TXT_CNTRY_CLNT.Location = New System.Drawing.Point(160, 181)
        Me.TXT_CNTRY_CLNT.Name = "TXT_CNTRY_CLNT"
        Me.TXT_CNTRY_CLNT.Size = New System.Drawing.Size(105, 22)
        Me.TXT_CNTRY_CLNT.TabIndex = 25
        '
        'TXT_MUN_CLNT
        '
        Me.TXT_MUN_CLNT.Location = New System.Drawing.Point(285, 181)
        Me.TXT_MUN_CLNT.Name = "TXT_MUN_CLNT"
        Me.TXT_MUN_CLNT.Size = New System.Drawing.Size(127, 22)
        Me.TXT_MUN_CLNT.TabIndex = 26
        '
        'TXT_STREET_CLNT
        '
        Me.TXT_STREET_CLNT.Location = New System.Drawing.Point(445, 181)
        Me.TXT_STREET_CLNT.Name = "TXT_STREET_CLNT"
        Me.TXT_STREET_CLNT.Size = New System.Drawing.Size(144, 22)
        Me.TXT_STREET_CLNT.TabIndex = 27
        '
        'TXT_HOME_CLNT
        '
        Me.TXT_HOME_CLNT.Location = New System.Drawing.Point(623, 180)
        Me.TXT_HOME_CLNT.Name = "TXT_HOME_CLNT"
        Me.TXT_HOME_CLNT.Size = New System.Drawing.Size(109, 22)
        Me.TXT_HOME_CLNT.TabIndex = 28
        '
        'TXT_CP_CLNT
        '
        Me.TXT_CP_CLNT.Location = New System.Drawing.Point(784, 180)
        Me.TXT_CP_CLNT.Name = "TXT_CP_CLNT"
        Me.TXT_CP_CLNT.Size = New System.Drawing.Size(119, 22)
        Me.TXT_CP_CLNT.TabIndex = 29
        '
        'TXT_USER_CLNT
        '
        Me.TXT_USER_CLNT.Location = New System.Drawing.Point(28, 287)
        Me.TXT_USER_CLNT.Name = "TXT_USER_CLNT"
        Me.TXT_USER_CLNT.Size = New System.Drawing.Size(116, 22)
        Me.TXT_USER_CLNT.TabIndex = 30
        '
        'TXT_PSSWRD_CLNT
        '
        Me.TXT_PSSWRD_CLNT.Location = New System.Drawing.Point(167, 286)
        Me.TXT_PSSWRD_CLNT.Name = "TXT_PSSWRD_CLNT"
        Me.TXT_PSSWRD_CLNT.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TXT_PSSWRD_CLNT.Size = New System.Drawing.Size(120, 22)
        Me.TXT_PSSWRD_CLNT.TabIndex = 31
        '
        'TXT_EMAIL_CLNT
        '
        Me.TXT_EMAIL_CLNT.Location = New System.Drawing.Point(309, 286)
        Me.TXT_EMAIL_CLNT.Name = "TXT_EMAIL_CLNT"
        Me.TXT_EMAIL_CLNT.Size = New System.Drawing.Size(132, 22)
        Me.TXT_EMAIL_CLNT.TabIndex = 32
        '
        'TXT_MEDIDOR_CLNT
        '
        Me.TXT_MEDIDOR_CLNT.Location = New System.Drawing.Point(464, 286)
        Me.TXT_MEDIDOR_CLNT.Name = "TXT_MEDIDOR_CLNT"
        Me.TXT_MEDIDOR_CLNT.Size = New System.Drawing.Size(157, 22)
        Me.TXT_MEDIDOR_CLNT.TabIndex = 33
        '
        'DT_UPDATE_CLNT
        '
        Me.DT_UPDATE_CLNT.Location = New System.Drawing.Point(671, 286)
        Me.DT_UPDATE_CLNT.Name = "DT_UPDATE_CLNT"
        Me.DT_UPDATE_CLNT.Size = New System.Drawing.Size(200, 22)
        Me.DT_UPDATE_CLNT.TabIndex = 34
        '
        'BTN_ADD_CLNT
        '
        Me.BTN_ADD_CLNT.Location = New System.Drawing.Point(720, 366)
        Me.BTN_ADD_CLNT.Name = "BTN_ADD_CLNT"
        Me.BTN_ADD_CLNT.Size = New System.Drawing.Size(108, 31)
        Me.BTN_ADD_CLNT.TabIndex = 35
        Me.BTN_ADD_CLNT.Text = "Añadir"
        Me.BTN_ADD_CLNT.UseVisualStyleBackColor = True
        '
        'BTN_CNCL_CLNT
        '
        Me.BTN_CNCL_CLNT.Location = New System.Drawing.Point(859, 366)
        Me.BTN_CNCL_CLNT.Name = "BTN_CNCL_CLNT"
        Me.BTN_CNCL_CLNT.Size = New System.Drawing.Size(96, 31)
        Me.BTN_CNCL_CLNT.TabIndex = 36
        Me.BTN_CNCL_CLNT.Text = "Cancelar"
        Me.BTN_CNCL_CLNT.UseVisualStyleBackColor = True
        '
        'CHB_SHWPSS_CLNT
        '
        Me.CHB_SHWPSS_CLNT.AutoSize = True
        Me.CHB_SHWPSS_CLNT.Location = New System.Drawing.Point(160, 326)
        Me.CHB_SHWPSS_CLNT.Name = "CHB_SHWPSS_CLNT"
        Me.CHB_SHWPSS_CLNT.Size = New System.Drawing.Size(155, 21)
        Me.CHB_SHWPSS_CLNT.TabIndex = 37
        Me.CHB_SHWPSS_CLNT.Text = "Mostrar Contraseña"
        Me.CHB_SHWPSS_CLNT.UseVisualStyleBackColor = True
        '
        'WND_ADD_CLNT
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(967, 406)
        Me.Controls.Add(Me.CHB_SHWPSS_CLNT)
        Me.Controls.Add(Me.BTN_CNCL_CLNT)
        Me.Controls.Add(Me.BTN_ADD_CLNT)
        Me.Controls.Add(Me.DT_UPDATE_CLNT)
        Me.Controls.Add(Me.TXT_MEDIDOR_CLNT)
        Me.Controls.Add(Me.TXT_EMAIL_CLNT)
        Me.Controls.Add(Me.TXT_PSSWRD_CLNT)
        Me.Controls.Add(Me.TXT_USER_CLNT)
        Me.Controls.Add(Me.TXT_CP_CLNT)
        Me.Controls.Add(Me.TXT_HOME_CLNT)
        Me.Controls.Add(Me.TXT_STREET_CLNT)
        Me.Controls.Add(Me.TXT_MUN_CLNT)
        Me.Controls.Add(Me.TXT_CNTRY_CLNT)
        Me.Controls.Add(Me.TXT_STATE_CLNT)
        Me.Controls.Add(Me.TXT_CURP_CLNT)
        Me.Controls.Add(Me.DT_BORN_CLNT)
        Me.Controls.Add(Me.RD_G_F_CLNT)
        Me.Controls.Add(Me.RD_G_M_CLNT)
        Me.Controls.Add(Me.TXT_APM_CLNT)
        Me.Controls.Add(Me.TXT_APP_CLNT)
        Me.Controls.Add(Me.TXT_NAMES_CLNT)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "WND_ADD_CLNT"
        Me.Text = "AÑADIR CLIENTE"
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
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents TXT_NAMES_CLNT As TextBox
    Friend WithEvents TXT_APP_CLNT As TextBox
    Friend WithEvents TXT_APM_CLNT As TextBox
    Friend WithEvents RD_G_M_CLNT As RadioButton
    Friend WithEvents RD_G_F_CLNT As RadioButton
    Friend WithEvents DT_BORN_CLNT As DateTimePicker
    Friend WithEvents TXT_CURP_CLNT As TextBox
    Friend WithEvents TXT_STATE_CLNT As TextBox
    Friend WithEvents TXT_CNTRY_CLNT As TextBox
    Friend WithEvents TXT_MUN_CLNT As TextBox
    Friend WithEvents TXT_STREET_CLNT As TextBox
    Friend WithEvents TXT_HOME_CLNT As TextBox
    Friend WithEvents TXT_CP_CLNT As TextBox
    Friend WithEvents TXT_USER_CLNT As TextBox
    Friend WithEvents TXT_PSSWRD_CLNT As TextBox
    Friend WithEvents TXT_EMAIL_CLNT As TextBox
    Friend WithEvents TXT_MEDIDOR_CLNT As TextBox
    Friend WithEvents DT_UPDATE_CLNT As DateTimePicker
    Friend WithEvents BTN_ADD_CLNT As Button
    Friend WithEvents BTN_CNCL_CLNT As Button
    Friend WithEvents CHB_SHWPSS_CLNT As CheckBox
End Class
