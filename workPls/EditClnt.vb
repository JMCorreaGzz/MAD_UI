Public Class WND_EDIT_CLNT
    Private Sub WND_EDIT_CLNT_Close(sender As Object, e As EventArgs) Handles MyBase.Closed
        Dim RTRN_CFE = New WND_CFE
        RTRN_CFE.Show()
        Me.Hide()
    End Sub
End Class