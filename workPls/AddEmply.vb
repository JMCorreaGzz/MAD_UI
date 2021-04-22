Public Class WND_ADD_EMPLY
    Private Sub WND_ADD_EMPLY_Close(sender As Object, e As EventArgs) Handles MyBase.Closed
        Dim RTRN_CFE = New WND_CFE
        RTRN_CFE.Show()
        Me.Hide()
    End Sub

    Private Sub BTN_CNCL_EMPLY_Click(sender As Object, e As EventArgs) Handles BTN_CNCL_EMPLY.Click
        Dim RTRN_CFE = New WND_CFE
        RTRN_CFE.Show()
        Me.Hide()
    End Sub
End Class