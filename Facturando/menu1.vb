Public Class menu1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (MsgBox("¿Esta seguro de salir?", vbCritical + vbYesNo) = vbYes) Then
            End
        End If
    End Sub
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        ' Me.PictureBox2.BackColor = Color.White
        If (MsgBox("¿Esta seguro de salir?", vbCritical + vbYesNo) = vbYes) Then
            End
        End If
    End Sub
    Private Sub PictureBox2_MouseMove(sender As Object, e As MouseEventArgs) Handles PictureBox2.MouseMove
        Me.PictureBox2.BackColor = Color.White
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

    End Sub

    Private Sub Facturacion_Click(sender As Object, e As EventArgs) Handles Facturacion.Click
        Me.Hide()
        ctrlcliente.Show()

    End Sub
End Class