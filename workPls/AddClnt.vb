Public Class WND_ADD_CLNT
    Private Sub WND_ADD_CLNT_Close(sender As Object, e As EventArgs) Handles MyBase.Closed
        Dim RTRN_CFE = New WND_CFE
        RTRN_CFE.Show()
        Me.Hide()
    End Sub

    Private Sub TXT_CURP_TextChanged(sender As Object, e As EventArgs) Handles TXT_CURP_CLNT.TextChanged

    End Sub

    Private Sub BTN_CNCL_CLNT_Click(sender As Object, e As EventArgs) Handles BTN_CNCL_CLNT.Click
        Dim RTRN_CFE = New WND_CFE
        RTRN_CFE.Show()
        Me.Hide()
    End Sub
End Class