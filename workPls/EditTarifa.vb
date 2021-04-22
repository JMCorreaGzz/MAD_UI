Public Class EditTarifa
    Private Sub EditTarifa_Close(sender As Object, e As EventArgs) Handles MyBase.Closed
        Dim RTRN_CFE = New WND_CFE
        RTRN_CFE.Show()
        Me.Hide()
    End Sub
End Class