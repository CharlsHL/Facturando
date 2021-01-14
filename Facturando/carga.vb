Public Class carga
    Dim timer As Integer
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        timer = 0
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        timer = timer + 1
        Me.Label1.Text = timer
        If timer = 5 Then
            ctrlcliente.Show()
            Me.Dispose()
        End If
    End Sub
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class
