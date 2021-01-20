<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ctrlcliente
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ctrlcliente))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PanelMenulateral = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.submenu2 = New System.Windows.Forms.FlowLayoutPanel()
        Me.factura = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.submenu1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.agregarc = New System.Windows.Forms.Button()
        Me.moddatos = New System.Windows.Forms.Button()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.FacturaDataSet = New Facturando.FacturaDataSet()
        Me.ClientesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClientesTableAdapter = New Facturando.FacturaDataSetTableAdapters.clientesTableAdapter()
        Me.FacturaDataSet1 = New Facturando.FacturaDataSet()
        Me.FacturaDataSet1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClientesBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.PanelMenulateral.SuspendLayout()
        Me.submenu2.SuspendLayout()
        Me.submenu1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FacturaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FacturaDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FacturaDataSet1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientesBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Gray
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Location = New System.Drawing.Point(-4, -1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(779, 40)
        Me.Panel1.TabIndex = 8
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(726, 6)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(22, 26)
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Gray
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(754, 6)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(22, 26)
        Me.PictureBox2.TabIndex = 2
        Me.PictureBox2.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(27, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Nombre "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(30, 95)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Apellido"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(30, 141)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(26, 13)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "DNI"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 197)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 13)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "CUIT/ CUIL"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(233, 43)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 13)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "Telefono"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(233, 95)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(52, 13)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "Direccion"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ComboBox2)
        Me.GroupBox1.Controls.Add(Me.Button4)
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.TextBox6)
        Me.GroupBox1.Controls.Add(Me.TextBox2)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.TextBox3)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.TextBox4)
        Me.GroupBox1.Controls.Add(Me.TextBox5)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Location = New System.Drawing.Point(287, 72)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(460, 260)
        Me.GroupBox1.TabIndex = 21
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Nuevo Cliente"
        Me.GroupBox1.Visible = False
        '
        'ComboBox2
        '
        Me.ComboBox2.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.FacturaDataSet, "clientes.apellido", True))
        Me.ComboBox2.DataSource = Me.ClientesBindingSource1
        Me.ComboBox2.DisplayMember = "nombre"
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(83, 16)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(202, 21)
        Me.ComboBox2.TabIndex = 24
        Me.ComboBox2.Visible = False
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(286, 216)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(144, 37)
        Me.Button4.TabIndex = 22
        Me.Button4.Text = "&Terminar"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(286, 173)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(144, 37)
        Me.Button3.TabIndex = 21
        Me.Button3.Text = "&Guardar "
        Me.Button3.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(83, 43)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(144, 37)
        Me.TextBox1.TabIndex = 9
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(286, 95)
        Me.TextBox6.Multiline = True
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(144, 37)
        Me.TextBox6.TabIndex = 20
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(83, 95)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(144, 37)
        Me.TextBox2.TabIndex = 10
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(83, 141)
        Me.TextBox3.Multiline = True
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(144, 37)
        Me.TextBox3.TabIndex = 11
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(83, 197)
        Me.TextBox4.Multiline = True
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(144, 37)
        Me.TextBox4.TabIndex = 12
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(286, 43)
        Me.TextBox5.Multiline = True
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(144, 37)
        Me.TextBox5.TabIndex = 17
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(287, 55)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(227, 21)
        Me.ComboBox1.TabIndex = 23
        Me.ComboBox1.Visible = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Gray
        Me.Panel2.Location = New System.Drawing.Point(-4, 533)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(786, 21)
        Me.Panel2.TabIndex = 24
        '
        'PanelMenulateral
        '
        Me.PanelMenulateral.BackColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(7, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.PanelMenulateral.Controls.Add(Me.Button1)
        Me.PanelMenulateral.Controls.Add(Me.submenu2)
        Me.PanelMenulateral.Controls.Add(Me.Button7)
        Me.PanelMenulateral.Controls.Add(Me.submenu1)
        Me.PanelMenulateral.Controls.Add(Me.Button10)
        Me.PanelMenulateral.Controls.Add(Me.Panel3)
        Me.PanelMenulateral.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelMenulateral.Location = New System.Drawing.Point(0, 0)
        Me.PanelMenulateral.Name = "PanelMenulateral"
        Me.PanelMenulateral.Size = New System.Drawing.Size(246, 554)
        Me.PanelMenulateral.TabIndex = 25
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.Color.Gainsboro
        Me.Button1.Location = New System.Drawing.Point(0, 509)
        Me.Button1.Name = "Button1"
        Me.Button1.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.Button1.Size = New System.Drawing.Size(246, 45)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "&Salir"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.UseVisualStyleBackColor = False
        '
        'submenu2
        '
        Me.submenu2.Controls.Add(Me.factura)
        Me.submenu2.Controls.Add(Me.Button6)
        Me.submenu2.Dock = System.Windows.Forms.DockStyle.Top
        Me.submenu2.Location = New System.Drawing.Point(0, 317)
        Me.submenu2.Name = "submenu2"
        Me.submenu2.Size = New System.Drawing.Size(246, 104)
        Me.submenu2.TabIndex = 9
        '
        'factura
        '
        Me.factura.Dock = System.Windows.Forms.DockStyle.Top
        Me.factura.FlatAppearance.BorderSize = 0
        Me.factura.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.factura.ForeColor = System.Drawing.Color.Gainsboro
        Me.factura.Location = New System.Drawing.Point(3, 3)
        Me.factura.Name = "factura"
        Me.factura.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.factura.Size = New System.Drawing.Size(246, 45)
        Me.factura.TabIndex = 7
        Me.factura.Text = "&Generar Factura"
        Me.factura.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.factura.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button6.FlatAppearance.BorderSize = 0
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.ForeColor = System.Drawing.Color.Gainsboro
        Me.Button6.Location = New System.Drawing.Point(3, 54)
        Me.Button6.Name = "Button6"
        Me.Button6.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.Button6.Size = New System.Drawing.Size(246, 45)
        Me.Button6.TabIndex = 8
        Me.Button6.Text = "Button6"
        Me.Button6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button7.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button7.FlatAppearance.BorderSize = 0
        Me.Button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button7.ForeColor = System.Drawing.Color.Gainsboro
        Me.Button7.Location = New System.Drawing.Point(0, 272)
        Me.Button7.Name = "Button7"
        Me.Button7.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.Button7.Size = New System.Drawing.Size(246, 45)
        Me.Button7.TabIndex = 8
        Me.Button7.Text = "Contable"
        Me.Button7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button7.UseVisualStyleBackColor = False
        '
        'submenu1
        '
        Me.submenu1.Controls.Add(Me.agregarc)
        Me.submenu1.Controls.Add(Me.moddatos)
        Me.submenu1.Dock = System.Windows.Forms.DockStyle.Top
        Me.submenu1.Location = New System.Drawing.Point(0, 172)
        Me.submenu1.Name = "submenu1"
        Me.submenu1.Size = New System.Drawing.Size(246, 100)
        Me.submenu1.TabIndex = 7
        '
        'agregarc
        '
        Me.agregarc.Dock = System.Windows.Forms.DockStyle.Top
        Me.agregarc.FlatAppearance.BorderSize = 0
        Me.agregarc.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.agregarc.ForeColor = System.Drawing.Color.Gainsboro
        Me.agregarc.Location = New System.Drawing.Point(3, 3)
        Me.agregarc.Name = "agregarc"
        Me.agregarc.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.agregarc.Size = New System.Drawing.Size(246, 45)
        Me.agregarc.TabIndex = 7
        Me.agregarc.Text = "Agregar Cliente"
        Me.agregarc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.agregarc.UseVisualStyleBackColor = True
        '
        'moddatos
        '
        Me.moddatos.Dock = System.Windows.Forms.DockStyle.Top
        Me.moddatos.FlatAppearance.BorderSize = 0
        Me.moddatos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.moddatos.ForeColor = System.Drawing.Color.Gainsboro
        Me.moddatos.Location = New System.Drawing.Point(3, 54)
        Me.moddatos.Name = "moddatos"
        Me.moddatos.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.moddatos.Size = New System.Drawing.Size(246, 45)
        Me.moddatos.TabIndex = 8
        Me.moddatos.Text = "&Editar Cliente"
        Me.moddatos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.moddatos.UseVisualStyleBackColor = True
        '
        'Button10
        '
        Me.Button10.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button10.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button10.FlatAppearance.BorderSize = 0
        Me.Button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button10.ForeColor = System.Drawing.Color.Gainsboro
        Me.Button10.Location = New System.Drawing.Point(0, 127)
        Me.Button10.Name = "Button10"
        Me.Button10.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.Button10.Size = New System.Drawing.Size(246, 45)
        Me.Button10.TabIndex = 6
        Me.Button10.Text = "Facturacion"
        Me.Button10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button10.UseVisualStyleBackColor = False
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.PictureBox3)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(246, 127)
        Me.Panel3.TabIndex = 5
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(12, 33)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(211, 53)
        Me.PictureBox3.TabIndex = 0
        Me.PictureBox3.TabStop = False
        '
        'FacturaDataSet
        '
        Me.FacturaDataSet.DataSetName = "FacturaDataSet"
        Me.FacturaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ClientesBindingSource
        '
        Me.ClientesBindingSource.DataMember = "clientes"
        Me.ClientesBindingSource.DataSource = Me.FacturaDataSet
        '
        'ClientesTableAdapter
        '
        Me.ClientesTableAdapter.ClearBeforeFill = True
        '
        'FacturaDataSet1
        '
        Me.FacturaDataSet1.DataSetName = "FacturaDataSet"
        Me.FacturaDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'FacturaDataSet1BindingSource
        '
        Me.FacturaDataSet1BindingSource.DataSource = Me.FacturaDataSet1
        Me.FacturaDataSet1BindingSource.Position = 0
        '
        'ClientesBindingSource1
        '
        Me.ClientesBindingSource1.DataMember = "clientes"
        Me.ClientesBindingSource1.DataSource = Me.FacturaDataSet1BindingSource
        '
        'ctrlcliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(774, 554)
        Me.Controls.Add(Me.PanelMenulateral)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ctrlcliente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Facturacion"
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.PanelMenulateral.ResumeLayout(False)
        Me.submenu2.ResumeLayout(False)
        Me.submenu1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FacturaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FacturaDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FacturaDataSet1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientesBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Button3 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Button4 As Button
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PanelMenulateral As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents submenu2 As FlowLayoutPanel
    Friend WithEvents submenu1 As FlowLayoutPanel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents factura As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents agregarc As Button
    Friend WithEvents moddatos As Button
    Friend WithEvents Button10 As Button
    Friend WithEvents FacturaDataSet As FacturaDataSet
    Friend WithEvents ClientesBindingSource As BindingSource
    Friend WithEvents ClientesTableAdapter As FacturaDataSetTableAdapters.clientesTableAdapter
    Friend WithEvents FacturaDataSet1BindingSource As BindingSource
    Friend WithEvents FacturaDataSet1 As FacturaDataSet
    Friend WithEvents ClientesBindingSource1 As BindingSource
End Class
