<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class WND_CFE
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.AgregarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmpleadoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClienteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmpleadoToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClienteToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.BorrarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmpleadoToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClienteToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CerrarSesionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TarifasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TarifasToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.TarifasToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AgregarToolStripMenuItem, Me.EditarToolStripMenuItem, Me.BorrarToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 28)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'AgregarToolStripMenuItem
        '
        Me.AgregarToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EmpleadoToolStripMenuItem, Me.ClienteToolStripMenuItem, Me.TarifasToolStripMenuItem})
        Me.AgregarToolStripMenuItem.Name = "AgregarToolStripMenuItem"
        Me.AgregarToolStripMenuItem.Size = New System.Drawing.Size(77, 24)
        Me.AgregarToolStripMenuItem.Text = "Agregar"
        '
        'EmpleadoToolStripMenuItem
        '
        Me.EmpleadoToolStripMenuItem.Name = "EmpleadoToolStripMenuItem"
        Me.EmpleadoToolStripMenuItem.Size = New System.Drawing.Size(160, 26)
        Me.EmpleadoToolStripMenuItem.Text = "Empleado"
        '
        'ClienteToolStripMenuItem
        '
        Me.ClienteToolStripMenuItem.Name = "ClienteToolStripMenuItem"
        Me.ClienteToolStripMenuItem.Size = New System.Drawing.Size(160, 26)
        Me.ClienteToolStripMenuItem.Text = "Cliente"
        '
        'EditarToolStripMenuItem
        '
        Me.EditarToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EmpleadoToolStripMenuItem1, Me.ClienteToolStripMenuItem1, Me.TarifasToolStripMenuItem1})
        Me.EditarToolStripMenuItem.Name = "EditarToolStripMenuItem"
        Me.EditarToolStripMenuItem.Size = New System.Drawing.Size(62, 24)
        Me.EditarToolStripMenuItem.Text = "Editar"
        '
        'EmpleadoToolStripMenuItem1
        '
        Me.EmpleadoToolStripMenuItem1.Name = "EmpleadoToolStripMenuItem1"
        Me.EmpleadoToolStripMenuItem1.Size = New System.Drawing.Size(160, 26)
        Me.EmpleadoToolStripMenuItem1.Text = "Empleado"
        '
        'ClienteToolStripMenuItem1
        '
        Me.ClienteToolStripMenuItem1.Name = "ClienteToolStripMenuItem1"
        Me.ClienteToolStripMenuItem1.Size = New System.Drawing.Size(160, 26)
        Me.ClienteToolStripMenuItem1.Text = "Cliente"
        '
        'BorrarToolStripMenuItem
        '
        Me.BorrarToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EmpleadoToolStripMenuItem2, Me.ClienteToolStripMenuItem2, Me.TarifasToolStripMenuItem2})
        Me.BorrarToolStripMenuItem.Name = "BorrarToolStripMenuItem"
        Me.BorrarToolStripMenuItem.Size = New System.Drawing.Size(64, 24)
        Me.BorrarToolStripMenuItem.Text = "Borrar"
        '
        'EmpleadoToolStripMenuItem2
        '
        Me.EmpleadoToolStripMenuItem2.Name = "EmpleadoToolStripMenuItem2"
        Me.EmpleadoToolStripMenuItem2.Size = New System.Drawing.Size(160, 26)
        Me.EmpleadoToolStripMenuItem2.Text = "Empleado"
        '
        'ClienteToolStripMenuItem2
        '
        Me.ClienteToolStripMenuItem2.Name = "ClienteToolStripMenuItem2"
        Me.ClienteToolStripMenuItem2.Size = New System.Drawing.Size(160, 26)
        Me.ClienteToolStripMenuItem2.Text = "Cliente"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CerrarSesionToolStripMenuItem})
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(52, 24)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'CerrarSesionToolStripMenuItem
        '
        Me.CerrarSesionToolStripMenuItem.Name = "CerrarSesionToolStripMenuItem"
        Me.CerrarSesionToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.CerrarSesionToolStripMenuItem.Text = "Cerrar sesion"
        '
        'TarifasToolStripMenuItem
        '
        Me.TarifasToolStripMenuItem.Name = "TarifasToolStripMenuItem"
        Me.TarifasToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.TarifasToolStripMenuItem.Text = "Tarifas"
        '
        'TarifasToolStripMenuItem1
        '
        Me.TarifasToolStripMenuItem1.Name = "TarifasToolStripMenuItem1"
        Me.TarifasToolStripMenuItem1.Size = New System.Drawing.Size(224, 26)
        Me.TarifasToolStripMenuItem1.Text = "Tarifas"
        '
        'TarifasToolStripMenuItem2
        '
        Me.TarifasToolStripMenuItem2.Name = "TarifasToolStripMenuItem2"
        Me.TarifasToolStripMenuItem2.Size = New System.Drawing.Size(224, 26)
        Me.TarifasToolStripMenuItem2.Text = "Tarifas"
        '
        'WND_CFE
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "WND_CFE"
        Me.Text = "COMISION FEDERAL DE ELECTRICIDAD"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents AgregarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EmpleadoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClienteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EmpleadoToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ClienteToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents BorrarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EmpleadoToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents ClienteToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CerrarSesionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TarifasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TarifasToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents TarifasToolStripMenuItem2 As ToolStripMenuItem
End Class
