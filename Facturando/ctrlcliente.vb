Public Class ctrlcliente
    Dim texts As New Collection
    Dim Incorrect As Integer
    Dim Agregar As Boolean
    Dim Click As Boolean
    Dim click2 As Integer

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim i As Integer
        For i = 1 To texts.Count
            If texts(i).text = "" Then
                Incorrect = Incorrect + 1
            End If
        Next
        If Incorrect <> 0 Then
            MsgBox("no puede dejar espacios en blanco ")
            Incorrect = 0
        ElseIf Agregar = True Then
            MsgBox("Se a guardado los datos con exito ")
            For i = 1 To texts.Count
                texts(i).text = ""
            Next
        Else

        End If
    End Sub
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'FacturaDataSet1.clientes' Puede moverla o quitarla según sea necesario.
        Me.ClientesTableAdapter.Fill(Me.FacturaDataSet1.clientes)
        'TODO: esta línea de código carga datos en la tabla 'FacturaDataSet.clientes' Puede moverla o quitarla según sea necesario.
        Me.ClientesTableAdapter.Fill(Me.FacturaDataSet.clientes)

        texts.Add(TextBox1)
        texts.Add(TextBox2)
        texts.Add(TextBox3)
        texts.Add(TextBox4)
        texts.Add(TextBox5)
        texts.Add(TextBox6)
        submenu1.Visible = False
        submenu2.Visible = False
    End Sub
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        If (MsgBox("¿Esta seguro de salir?", vbCritical + vbYesNo) = vbYes) Then
            End
        End If
    End Sub
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If (MsgBox("¿Esta seguro que desea terminar, perdera los datos que no se allan guardadoS?", vbCritical + vbYesNo) = vbYes) Then
            GroupBox1.Visible = False
            agregarc.Enabled = True
            moddatos.Enabled = True
            factura.Enabled = True
            Agregar = True
            ComboBox2.Visible = False
        End If
    End Sub
    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles agregarc.Click
        GroupBox1.Text = "Nuevo Cliente"
        GroupBox1.Visible = True
        agregarc.Enabled = False
        moddatos.Enabled = False
        factura.Enabled = False
        ComboBox1.Visible = False
        ComboBox1.Visible = False
    End Sub
    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles moddatos.Click
        GroupBox1.Text = "Editar Datos"
        GroupBox1.Visible = True
        ComboBox2.Visible = True
        GroupBox1.Visible = True
        agregarc.Enabled = False
        moddatos.Enabled = False
        factura.Enabled = False
        'Button2.Enabled = False
        ComboBox1.Visible = False
    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles factura.Click
        ComboBox1.Visible = True
    End Sub
    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
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
    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        If (click = True) Then
            submenu1.Visible = False
            submenu2.Visible = True
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
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (MsgBox("¿Esta seguro de salir?", vbCritical + vbYesNo) = vbYes) Then
            End
        End If
    End Sub
    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged

    End Sub
End Class