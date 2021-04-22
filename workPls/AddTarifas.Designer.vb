<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddTarifas
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
        Me.TXT_ADD_NAME_TARIF = New System.Windows.Forms.TextBox()
        Me.TXT_ADD_FREC_TARIF = New System.Windows.Forms.TextBox()
        Me.TXT_ADD_BASIC_TARIF = New System.Windows.Forms.TextBox()
        Me.TXT_ADD_INTER_TARIF = New System.Windows.Forms.TextBox()
        Me.TXT_ADD_EXCE_TARIF = New System.Windows.Forms.TextBox()
        Me.RD_ADD_TYPE_D_TARIF = New System.Windows.Forms.RadioButton()
        Me.RD_ADD_TYPE_I_TARIF = New System.Windows.Forms.RadioButton()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.BTN_ADD_TARIF = New System.Windows.Forms.Button()
        Me.BTN_CNCL_TARIF = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(83, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(164, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "NOMBRE DE LA TARIFA"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(308, 29)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(115, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "TIPO DE TARIFA"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(510, 29)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(94, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "FRECUENCIA"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(83, 155)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(133, 17)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "CONSUMO BASICO"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(308, 155)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(168, 17)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "CONSUMO INTERMEDIO"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(537, 154)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(166, 17)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "CONSUMO EXCEDENTE"
        '
        'TXT_ADD_NAME_TARIF
        '
        Me.TXT_ADD_NAME_TARIF.Location = New System.Drawing.Point(98, 55)
        Me.TXT_ADD_NAME_TARIF.Name = "TXT_ADD_NAME_TARIF"
        Me.TXT_ADD_NAME_TARIF.Size = New System.Drawing.Size(130, 22)
        Me.TXT_ADD_NAME_TARIF.TabIndex = 6
        '
        'TXT_ADD_FREC_TARIF
        '
        Me.TXT_ADD_FREC_TARIF.Location = New System.Drawing.Point(504, 55)
        Me.TXT_ADD_FREC_TARIF.Name = "TXT_ADD_FREC_TARIF"
        Me.TXT_ADD_FREC_TARIF.Size = New System.Drawing.Size(114, 22)
        Me.TXT_ADD_FREC_TARIF.TabIndex = 8
        '
        'TXT_ADD_BASIC_TARIF
        '
        Me.TXT_ADD_BASIC_TARIF.Location = New System.Drawing.Point(86, 190)
        Me.TXT_ADD_BASIC_TARIF.Name = "TXT_ADD_BASIC_TARIF"
        Me.TXT_ADD_BASIC_TARIF.Size = New System.Drawing.Size(100, 22)
        Me.TXT_ADD_BASIC_TARIF.TabIndex = 9
        '
        'TXT_ADD_INTER_TARIF
        '
        Me.TXT_ADD_INTER_TARIF.Location = New System.Drawing.Point(315, 190)
        Me.TXT_ADD_INTER_TARIF.Name = "TXT_ADD_INTER_TARIF"
        Me.TXT_ADD_INTER_TARIF.Size = New System.Drawing.Size(100, 22)
        Me.TXT_ADD_INTER_TARIF.TabIndex = 10
        '
        'TXT_ADD_EXCE_TARIF
        '
        Me.TXT_ADD_EXCE_TARIF.Location = New System.Drawing.Point(540, 190)
        Me.TXT_ADD_EXCE_TARIF.Name = "TXT_ADD_EXCE_TARIF"
        Me.TXT_ADD_EXCE_TARIF.Size = New System.Drawing.Size(100, 22)
        Me.TXT_ADD_EXCE_TARIF.TabIndex = 11
        '
        'RD_ADD_TYPE_D_TARIF
        '
        Me.RD_ADD_TYPE_D_TARIF.AutoSize = True
        Me.RD_ADD_TYPE_D_TARIF.Location = New System.Drawing.Point(311, 55)
        Me.RD_ADD_TYPE_D_TARIF.Name = "RD_ADD_TYPE_D_TARIF"
        Me.RD_ADD_TYPE_D_TARIF.Size = New System.Drawing.Size(95, 21)
        Me.RD_ADD_TYPE_D_TARIF.TabIndex = 12
        Me.RD_ADD_TYPE_D_TARIF.TabStop = True
        Me.RD_ADD_TYPE_D_TARIF.Text = "Domestica"
        Me.RD_ADD_TYPE_D_TARIF.UseVisualStyleBackColor = True
        '
        'RD_ADD_TYPE_I_TARIF
        '
        Me.RD_ADD_TYPE_I_TARIF.AutoSize = True
        Me.RD_ADD_TYPE_I_TARIF.Location = New System.Drawing.Point(311, 90)
        Me.RD_ADD_TYPE_I_TARIF.Name = "RD_ADD_TYPE_I_TARIF"
        Me.RD_ADD_TYPE_I_TARIF.Size = New System.Drawing.Size(86, 21)
        Me.RD_ADD_TYPE_I_TARIF.TabIndex = 13
        Me.RD_ADD_TYPE_I_TARIF.TabStop = True
        Me.RD_ADD_TYPE_I_TARIF.Text = "Industrial"
        Me.RD_ADD_TYPE_I_TARIF.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(196, 195)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(47, 17)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "KW/hr"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(441, 194)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(47, 17)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "KW/hr"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(663, 194)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(47, 17)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "KW/hr"
        '
        'BTN_ADD_TARIF
        '
        Me.BTN_ADD_TARIF.Location = New System.Drawing.Point(537, 288)
        Me.BTN_ADD_TARIF.Name = "BTN_ADD_TARIF"
        Me.BTN_ADD_TARIF.Size = New System.Drawing.Size(116, 29)
        Me.BTN_ADD_TARIF.TabIndex = 17
        Me.BTN_ADD_TARIF.Text = "Agregar Tarifa"
        Me.BTN_ADD_TARIF.UseVisualStyleBackColor = True
        '
        'BTN_CNCL_TARIF
        '
        Me.BTN_CNCL_TARIF.Location = New System.Drawing.Point(677, 288)
        Me.BTN_CNCL_TARIF.Name = "BTN_CNCL_TARIF"
        Me.BTN_CNCL_TARIF.Size = New System.Drawing.Size(87, 28)
        Me.BTN_CNCL_TARIF.TabIndex = 18
        Me.BTN_CNCL_TARIF.Text = "Cancelar"
        Me.BTN_CNCL_TARIF.UseVisualStyleBackColor = True
        '
        'AddTarifas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(774, 334)
        Me.Controls.Add(Me.BTN_CNCL_TARIF)
        Me.Controls.Add(Me.BTN_ADD_TARIF)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.RD_ADD_TYPE_I_TARIF)
        Me.Controls.Add(Me.RD_ADD_TYPE_D_TARIF)
        Me.Controls.Add(Me.TXT_ADD_EXCE_TARIF)
        Me.Controls.Add(Me.TXT_ADD_INTER_TARIF)
        Me.Controls.Add(Me.TXT_ADD_BASIC_TARIF)
        Me.Controls.Add(Me.TXT_ADD_FREC_TARIF)
        Me.Controls.Add(Me.TXT_ADD_NAME_TARIF)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "AddTarifas"
        Me.Text = "AÑADIR TARIFAS"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TXT_ADD_NAME_TARIF As TextBox
    Friend WithEvents TXT_ADD_FREC_TARIF As TextBox
    Friend WithEvents TXT_ADD_BASIC_TARIF As TextBox
    Friend WithEvents TXT_ADD_INTER_TARIF As TextBox
    Friend WithEvents TXT_ADD_EXCE_TARIF As TextBox
    Friend WithEvents RD_ADD_TYPE_D_TARIF As RadioButton
    Friend WithEvents RD_ADD_TYPE_I_TARIF As RadioButton
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents BTN_ADD_TARIF As Button
    Friend WithEvents BTN_CNCL_TARIF As Button
End Class
