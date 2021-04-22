Public Class WND_CFE
    Private Sub EmpleadoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EmpleadoToolStripMenuItem.Click
        Dim ADD_EMPLY = New WND_ADD_EMPLY
        ADD_EMPLY.Show()
        Me.Hide()
    End Sub
    Private Sub WND_CFE_Close(sender As Object, e As EventArgs) Handles MyBase.Closed

    End Sub

    Private Sub ClienteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClienteToolStripMenuItem.Click
        Dim ADD_CLNT = New WND_ADD_CLNT
        ADD_CLNT.Show()
        Me.Hide()
    End Sub

    Private Sub CerrarSesionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CerrarSesionToolStripMenuItem.Click
        Dim RTRN_LOGIN = New WND_LOGIN
        RTRN_LOGIN.Show()
        Me.Hide()
    End Sub

    Private Sub SalirDelProgramaToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub
End Class