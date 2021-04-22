<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditTarifa
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
        Me.BTN_EDIT_CNCL_TARIF = New System.Windows.Forms.Button()
        Me.BTN_EDIT_TARIF = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.RD_EDIT_TYPE_I_TARIF = New System.Windows.Forms.RadioButton()
        Me.RD_EDIT_TYPE_D_TARIF = New System.Windows.Forms.RadioButton()
        Me.TXT_EDIT_EXCE_TARIF = New System.Windows.Forms.TextBox()
        Me.TXT_EDIT_INTER_TARIF = New System.Windows.Forms.TextBox()
        Me.TXT_EDIT_BASIC_TARIF = New System.Windows.Forms.TextBox()
        Me.TXT_EDIT_FREC_TARIF = New System.Windows.Forms.TextBox()
        Me.TXT_EDIT_NAME_TARIF = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'BTN_EDIT_CNCL_TARIF
        '
        Me.BTN_EDIT_CNCL_TARIF.Location = New System.Drawing.Point(675, 295)
        Me.BTN_EDIT_CNCL_TARIF.Name = "BTN_EDIT_CNCL_TARIF"
        Me.BTN_EDIT_CNCL_TARIF.Size = New System.Drawing.Size(87, 28)
        Me.BTN_EDIT_CNCL_TARIF.TabIndex = 36
        Me.BTN_EDIT_CNCL_TARIF.Text = "Cancelar"
        Me.BTN_EDIT_CNCL_TARIF.UseVisualStyleBackColor = True
        '
        'BTN_EDIT_TARIF
        '
        Me.BTN_EDIT_TARIF.Location = New System.Drawing.Point(511, 295)
        Me.BTN_EDIT_TARIF.Name = "BTN_EDIT_TARIF"
        Me.BTN_EDIT_TARIF.Size = New System.Drawing.Size(140, 29)
        Me.BTN_EDIT_TARIF.TabIndex = 35
        Me.BTN_EDIT_TARIF.Text = "Guardar Cambios"
        Me.BTN_EDIT_TARIF.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(661, 201)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(47, 17)
        Me.Label9.TabIndex = 34
        Me.Label9.Text = "KW/hr"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(439, 201)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(47, 17)
        Me.Label8.TabIndex = 33
        Me.Label8.Text = "KW/hr"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(194, 202)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(47, 17)
        Me.Label7.TabIndex = 32
        Me.Label7.Text = "KW/hr"
        '
        'RD_EDIT_TYPE_I_TARIF
        '
        Me.RD_EDIT_TYPE_I_TARIF.AutoSize = True
        Me.RD_EDIT_TYPE_I_TARIF.Location = New System.Drawing.Point(309, 97)
        Me.RD_EDIT_TYPE_I_TARIF.Name = "RD_EDIT_TYPE_I_TARIF"
        Me.RD_EDIT_TYPE_I_TARIF.Size = New System.Drawing.Size(86, 21)
        Me.RD_EDIT_TYPE_I_TARIF.TabIndex = 31
        Me.RD_EDIT_TYPE_I_TARIF.TabStop = True
        Me.RD_EDIT_TYPE_I_TARIF.Text = "Industrial"
        Me.RD_EDIT_TYPE_I_TARIF.UseVisualStyleBackColor = True
        '
        'RD_EDIT_TYPE_D_TARIF
        '
        Me.RD_EDIT_TYPE_D_TARIF.AutoSize = True
        Me.RD_EDIT_TYPE_D_TARIF.Location = New System.Drawing.Point(309, 62)
        Me.RD_EDIT_TYPE_D_TARIF.Name = "RD_EDIT_TYPE_D_TARIF"
        Me.RD_EDIT_TYPE_D_TARIF.Size = New System.Drawing.Size(95, 21)
        Me.RD_EDIT_TYPE_D_TARIF.TabIndex = 30
        Me.RD_EDIT_TYPE_D_TARIF.TabStop = True
        Me.RD_EDIT_TYPE_D_TARIF.Text = "Domestica"
        Me.RD_EDIT_TYPE_D_TARIF.UseVisualStyleBackColor = True
        '
        'TXT_EDIT_EXCE_TARIF
        '
        Me.TXT_EDIT_EXCE_TARIF.Location = New System.Drawing.Point(538, 197)
        Me.TXT_EDIT_EXCE_TARIF.Name = "TXT_EDIT_EXCE_TARIF"
        Me.TXT_EDIT_EXCE_TARIF.Size = New System.Drawing.Size(100, 22)
        Me.TXT_EDIT_EXCE_TARIF.TabIndex = 29
        '
        'TXT_EDIT_INTER_TARIF
        '
        Me.TXT_EDIT_INTER_TARIF.Location = New System.Drawing.Point(309, 196)
        Me.TXT_EDIT_INTER_TARIF.Name = "TXT_EDIT_INTER_TARIF"
        Me.TXT_EDIT_INTER_TARIF.Size = New System.Drawing.Size(100, 22)
        Me.TXT_EDIT_INTER_TARIF.TabIndex = 28
        '
        'TXT_EDIT_BASIC_TARIF
        '
        Me.TXT_EDIT_BASIC_TARIF.Location = New System.Drawing.Point(84, 197)
        Me.TXT_EDIT_BASIC_TARIF.Name = "TXT_EDIT_BASIC_TARIF"
        Me.TXT_EDIT_BASIC_TARIF.Size = New System.Drawing.Size(100, 22)
        Me.TXT_EDIT_BASIC_TARIF.TabIndex = 27
        '
        'TXT_EDIT_FREC_TARIF
        '
        Me.TXT_EDIT_FREC_TARIF.Location = New System.Drawing.Point(502, 62)
        Me.TXT_EDIT_FREC_TARIF.Name = "TXT_EDIT_FREC_TARIF"
        Me.TXT_EDIT_FREC_TARIF.Size = New System.Drawing.Size(114, 22)
        Me.TXT_EDIT_FREC_TARIF.TabIndex = 26
        '
        'TXT_EDIT_NAME_TARIF
        '
        Me.TXT_EDIT_NAME_TARIF.Location = New System.Drawing.Point(96, 62)
        Me.TXT_EDIT_NAME_TARIF.Name = "TXT_EDIT_NAME_TARIF"
        Me.TXT_EDIT_NAME_TARIF.Size = New System.Drawing.Size(130, 22)
        Me.TXT_EDIT_NAME_TARIF.TabIndex = 25
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(535, 161)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(166, 17)
        Me.Label6.TabIndex = 24
        Me.Label6.Text = "CONSUMO EXCEDENTE"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(306, 162)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(168, 17)
        Me.Label5.TabIndex = 23
        Me.Label5.Text = "CONSUMO INTERMEDIO"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(81, 162)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(133, 17)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "CONSUMO BASICO"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(508, 36)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(94, 17)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "FRECUENCIA"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(306, 36)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(115, 17)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "TIPO DE TARIFA"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(81, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(164, 17)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "NOMBRE DE LA TARIFA"
        '
        'EditTarifa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(772, 337)
        Me.Controls.Add(Me.BTN_EDIT_CNCL_TARIF)
        Me.Controls.Add(Me.BTN_EDIT_TARIF)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.RD_EDIT_TYPE_I_TARIF)
        Me.Controls.Add(Me.RD_EDIT_TYPE_D_TARIF)
        Me.Controls.Add(Me.TXT_EDIT_EXCE_TARIF)
        Me.Controls.Add(Me.TXT_EDIT_INTER_TARIF)
        Me.Controls.Add(Me.TXT_EDIT_BASIC_TARIF)
        Me.Controls.Add(Me.TXT_EDIT_FREC_TARIF)
        Me.Controls.Add(Me.TXT_EDIT_NAME_TARIF)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "EditTarifa"
        Me.Text = "EDITAR TARIFA"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BTN_EDIT_CNCL_TARIF As Button
    Friend WithEvents BTN_EDIT_TARIF As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents RD_EDIT_TYPE_I_TARIF As RadioButton
    Friend WithEvents RD_EDIT_TYPE_D_TARIF As RadioButton
    Friend WithEvents TXT_EDIT_EXCE_TARIF As TextBox
    Friend WithEvents TXT_EDIT_INTER_TARIF As TextBox
    Friend WithEvents TXT_EDIT_BASIC_TARIF As TextBox
    Friend WithEvents TXT_EDIT_FREC_TARIF As TextBox
    Friend WithEvents TXT_EDIT_NAME_TARIF As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
