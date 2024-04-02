<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Form4))
        Label1 = New Label()
        DataGridView1 = New DataGridView()
        Label7 = New Label()
        PictureBox1 = New PictureBox()
        Label2 = New Label()
        TextBox1 = New TextBox()
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        Label3 = New Label()
        DataGridView2 = New DataGridView()
        Label4 = New Label()
        TextBox2 = New TextBox()
        TextBox3 = New TextBox()
        Label5 = New Label()
        TextBox4 = New TextBox()
        Label6 = New Label()
        Button4 = New Button()
        Label8 = New Label()
        TextBox5 = New TextBox()
        PictureBox3 = New PictureBox()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(DataGridView2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(12, 133)
        Label1.Name = "Label1"
        Label1.Size = New Size(112, 23)
        Label1.TabIndex = 1
        Label1.Text = "PRODUCTOS:"
        ' 
        ' DataGridView1
        ' 
        DataGridView1.BackgroundColor = Color.White
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(12, 166)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowTemplate.Height = 25
        DataGridView1.Size = New Size(398, 417)
        DataGridView1.TabIndex = 2
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point)
        Label7.Location = New Point(12, 9)
        Label7.Name = "Label7"
        Label7.Size = New Size(210, 65)
        Label7.TabIndex = 26
        Label7.Text = "VENTAS"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(387, 60)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(52, 50)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 29
        PictureBox1.TabStop = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(445, 60)
        Label2.Name = "Label2"
        Label2.Size = New Size(73, 20)
        Label2.TabIndex = 28
        Label2.Text = "Buscador:"
        ' 
        ' TextBox1
        ' 
        TextBox1.BackColor = SystemColors.ControlLightLight
        TextBox1.BorderStyle = BorderStyle.FixedSingle
        TextBox1.Cursor = Cursors.IBeam
        TextBox1.Location = New Point(445, 87)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(319, 23)
        TextBox1.TabIndex = 27
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Segoe UI", 12.75F, FontStyle.Regular, GraphicsUnit.Point)
        Button1.Location = New Point(524, 186)
        Button1.Name = "Button1"
        Button1.Size = New Size(167, 63)
        Button1.TabIndex = 30
        Button1.Text = "CATEGORIAS"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Font = New Font("Segoe UI", 12.75F, FontStyle.Regular, GraphicsUnit.Point)
        Button2.Location = New Point(524, 284)
        Button2.Name = "Button2"
        Button2.Size = New Size(167, 63)
        Button2.TabIndex = 31
        Button2.Text = "DEVOLUCIONES"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Font = New Font("Segoe UI", 12.75F, FontStyle.Regular, GraphicsUnit.Point)
        Button3.Location = New Point(524, 458)
        Button3.Name = "Button3"
        Button3.Size = New Size(168, 64)
        Button3.TabIndex = 32
        Button3.Text = "AGREGAR"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 12.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(763, 133)
        Label3.Name = "Label3"
        Label3.Size = New Size(67, 23)
        Label3.TabIndex = 33
        Label3.Text = "TICKET:"
        ' 
        ' DataGridView2
        ' 
        DataGridView2.BackgroundColor = Color.White
        DataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView2.Location = New Point(763, 166)
        DataGridView2.Name = "DataGridView2"
        DataGridView2.RowTemplate.Height = 25
        DataGridView2.Size = New Size(400, 238)
        DataGridView2.TabIndex = 34
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 12.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.Location = New Point(762, 428)
        Label4.Name = "Label4"
        Label4.Size = New Size(135, 23)
        Label4.TabIndex = 35
        Label4.Text = "TOTAL A PAGAR:"
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(903, 428)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(156, 23)
        TextBox2.TabIndex = 36
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(903, 476)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(156, 23)
        TextBox3.TabIndex = 38
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 12.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label5.Location = New Point(762, 476)
        Label5.Name = "Label5"
        Label5.Size = New Size(89, 23)
        Label5.TabIndex = 37
        Label5.Text = "RECIBIDO:"
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(903, 522)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(156, 23)
        TextBox4.TabIndex = 40
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 12.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label6.Location = New Point(762, 522)
        Label6.Name = "Label6"
        Label6.Size = New Size(79, 23)
        Label6.TabIndex = 39
        Label6.Text = "CAMBIO:"
        ' 
        ' Button4
        ' 
        Button4.Font = New Font("Segoe UI", 12.75F, FontStyle.Regular, GraphicsUnit.Point)
        Button4.Location = New Point(524, 370)
        Button4.Name = "Button4"
        Button4.Size = New Size(167, 62)
        Button4.TabIndex = 41
        Button4.Text = "ELIMINAR"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 12.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label8.Location = New Point(515, 546)
        Label8.Name = "Label8"
        Label8.Size = New Size(58, 23)
        Label8.TabIndex = 42
        Label8.Text = "CANT."
        ' 
        ' TextBox5
        ' 
        TextBox5.Location = New Point(579, 546)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(112, 23)
        TextBox5.TabIndex = 43
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), Image)
        PictureBox3.Location = New Point(1111, 590)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(52, 50)
        PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox3.TabIndex = 44
        PictureBox3.TabStop = False
        ' 
        ' Form4
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.GradientInactiveCaption
        ClientSize = New Size(1175, 652)
        Controls.Add(PictureBox3)
        Controls.Add(TextBox5)
        Controls.Add(Label8)
        Controls.Add(Button4)
        Controls.Add(TextBox4)
        Controls.Add(Label6)
        Controls.Add(TextBox3)
        Controls.Add(Label5)
        Controls.Add(TextBox2)
        Controls.Add(Label4)
        Controls.Add(DataGridView2)
        Controls.Add(Label3)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(PictureBox1)
        Controls.Add(Label2)
        Controls.Add(TextBox1)
        Controls.Add(Label7)
        Controls.Add(DataGridView1)
        Controls.Add(Label1)
        Name = "Form4"
        Text = "Form4"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(DataGridView2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label7 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Button4 As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents PictureBox3 As PictureBox
End Class
