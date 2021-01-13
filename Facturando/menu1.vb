Public Class menu1
    Dim click As Boolean
    Dim click2 As Integer
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
    Private Sub Facturacion_Click(sender As Object, e As EventArgs)

    End Sub
    Private Sub menu1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        hidemenu()
    End Sub
    Private Sub hidemenu()
        submenu1.Visible = False
        submenu2.Visible = False
    End Sub
    Private Sub Factura_Click(sender As Object, e As EventArgs) Handles Factura.Click
        'Me.Hide()
        'ctrlcliente.Show()
        If (click = True) Then
            submenu1.Visible = True
            submenu2.Visible = False
        Else
            submenu1.Visible = True
            click = True
        End If
        click2 = click2 + 1
        If (click2 = 2) Then
            submenu1.Visible = False
            click2 = 0
        End If
    End Sub
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If (click = True) Then
            submenu2.Visible = True
            submenu1.Visible = False
            'submenu2.Visible = True
        Else
            submenu2.Visible = True
            click = True
        End If
        click2 = click2 + 1
        If (click2 = 2) Then
            submenu2.Visible = False
            click2 = 0
        End If
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        If (MsgBox("¿Esta seguro de salir?", vbCritical + vbYesNo) = vbYes) Then
            End
        End If
    End Sub
End Class