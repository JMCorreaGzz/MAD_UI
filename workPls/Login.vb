Public Class WND_LOGIN
    Private Sub BTN_ENTER_Click(sender As Object, e As EventArgs) Handles BTN_ENTER.Click
        Dim Start_Worker = New WND_CFE
        Start_Worker.Show()
        Me.Hide()
    End Sub

    Private Sub WND_LOGIN_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BTN_END_Click(sender As Object, e As EventArgs) Handles BTN_END.Click
        Me.Close()
    End Sub
End Class
