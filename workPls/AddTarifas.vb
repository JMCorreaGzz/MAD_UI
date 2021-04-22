Public Class AddTarifas
    Private Sub AddTarifas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim RTRN_CFE = New WND_CFE
        RTRN_CFE.Show()
        Me.Hide()
    End Sub
End Class