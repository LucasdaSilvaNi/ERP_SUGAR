﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class gestionAlmacenes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(gestionAlmacenes))
        Me.nuevo = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label46 = New System.Windows.Forms.Label()
        Me.cbTipoAlmacen = New System.Windows.Forms.ComboBox()
        Me.cbDirecciones = New System.Windows.Forms.ComboBox()
        Me.ckActivo = New System.Windows.Forms.CheckBox()
        Me.lvAlmacenes = New System.Windows.Forms.ListView()
        Me.lvidAlmacen = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lvAlmacen = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lvTipo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Almacen = New System.Windows.Forms.TextBox()
        Me.descripcion = New System.Windows.Forms.TextBox()
        Me.borrar = New System.Windows.Forms.Button()
        Me.guardar = New System.Windows.Forms.Button()
        Me.bSalir = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'nuevo
        '
        Me.nuevo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.nuevo.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nuevo.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.nuevo.Location = New System.Drawing.Point(220, 22)
        Me.nuevo.Margin = New System.Windows.Forms.Padding(4)
        Me.nuevo.Name = "nuevo"
        Me.nuevo.Size = New System.Drawing.Size(87, 50)
        Me.nuevo.TabIndex = 1
        Me.nuevo.Text = "NUEVO"
        Me.nuevo.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label46)
        Me.GroupBox1.Controls.Add(Me.cbTipoAlmacen)
        Me.GroupBox1.Controls.Add(Me.cbDirecciones)
        Me.GroupBox1.Controls.Add(Me.ckActivo)
        Me.GroupBox1.Controls.Add(Me.lvAlmacenes)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label19)
        Me.GroupBox1.Controls.Add(Me.Label18)
        Me.GroupBox1.Controls.Add(Me.Almacen)
        Me.GroupBox1.Controls.Add(Me.descripcion)
        Me.GroupBox1.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(11, 92)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(584, 571)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.UseCompatibleTextRendering = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label2.Location = New System.Drawing.Point(10, 88)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 17)
        Me.Label2.TabIndex = 99
        Me.Label2.Text = "TIPO"
        '
        'Label46
        '
        Me.Label46.AutoSize = True
        Me.Label46.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label46.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label46.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label46.Location = New System.Drawing.Point(10, 23)
        Me.Label46.Name = "Label46"
        Me.Label46.Size = New System.Drawing.Size(82, 17)
        Me.Label46.TabIndex = 99
        Me.Label46.Text = "DIRECCIÓN"
        '
        'cbTipoAlmacen
        '
        Me.cbTipoAlmacen.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbTipoAlmacen.FormattingEnabled = True
        Me.cbTipoAlmacen.Location = New System.Drawing.Point(109, 83)
        Me.cbTipoAlmacen.MaxLength = 6
        Me.cbTipoAlmacen.Name = "cbTipoAlmacen"
        Me.cbTipoAlmacen.Size = New System.Drawing.Size(370, 25)
        Me.cbTipoAlmacen.TabIndex = 3
        '
        'cbDirecciones
        '
        Me.cbDirecciones.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbDirecciones.FormattingEnabled = True
        Me.cbDirecciones.Location = New System.Drawing.Point(109, 20)
        Me.cbDirecciones.MaxLength = 6
        Me.cbDirecciones.Name = "cbDirecciones"
        Me.cbDirecciones.Size = New System.Drawing.Size(463, 25)
        Me.cbDirecciones.TabIndex = 0
        '
        'ckActivo
        '
        Me.ckActivo.AutoSize = True
        Me.ckActivo.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ckActivo.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ckActivo.ForeColor = System.Drawing.Color.DarkBlue
        Me.ckActivo.Location = New System.Drawing.Point(497, 55)
        Me.ckActivo.Margin = New System.Windows.Forms.Padding(4)
        Me.ckActivo.Name = "ckActivo"
        Me.ckActivo.Size = New System.Drawing.Size(75, 21)
        Me.ckActivo.TabIndex = 2
        Me.ckActivo.Text = "ACTIVO"
        Me.ckActivo.UseVisualStyleBackColor = True
        '
        'lvAlmacenes
        '
        Me.lvAlmacenes.Activation = System.Windows.Forms.ItemActivation.OneClick
        Me.lvAlmacenes.AllowColumnReorder = True
        Me.lvAlmacenes.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lvAlmacenes.AutoArrange = False
        Me.lvAlmacenes.BackgroundImageTiled = True
        Me.lvAlmacenes.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.lvidAlmacen, Me.lvAlmacen, Me.lvTipo})
        Me.lvAlmacenes.Cursor = System.Windows.Forms.Cursors.Default
        Me.lvAlmacenes.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvAlmacenes.FullRowSelect = True
        Me.lvAlmacenes.GridLines = True
        Me.lvAlmacenes.HideSelection = False
        Me.lvAlmacenes.Location = New System.Drawing.Point(12, 163)
        Me.lvAlmacenes.Margin = New System.Windows.Forms.Padding(4)
        Me.lvAlmacenes.Name = "lvAlmacenes"
        Me.lvAlmacenes.Size = New System.Drawing.Size(560, 392)
        Me.lvAlmacenes.TabIndex = 5
        Me.lvAlmacenes.UseCompatibleStateImageBehavior = False
        Me.lvAlmacenes.View = System.Windows.Forms.View.Details
        '
        'lvidAlmacen
        '
        Me.lvidAlmacen.Text = "idAlmacen"
        Me.lvidAlmacen.Width = 0
        '
        'lvAlmacen
        '
        Me.lvAlmacen.Text = "ALMACÉN"
        Me.lvAlmacen.Width = 220
        '
        'lvTipo
        '
        Me.lvTipo.Text = "TIPO"
        Me.lvTipo.Width = 186
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(10, 118)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 17)
        Me.Label1.TabIndex = 32
        Me.Label1.Text = "DESCRIPCION"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label19.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label19.Location = New System.Drawing.Point(10, 56)
        Me.Label19.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(71, 17)
        Me.Label19.TabIndex = 32
        Me.Label19.Text = "ALMACÉN"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.Label18.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label18.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label18.Location = New System.Drawing.Point(-120, 123)
        Me.Label18.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(47, 17)
        Me.Label18.TabIndex = 31
        Me.Label18.Text = "E-MAIL"
        '
        'Almacen
        '
        Me.Almacen.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Almacen.Location = New System.Drawing.Point(109, 53)
        Me.Almacen.Margin = New System.Windows.Forms.Padding(4)
        Me.Almacen.MaxLength = 50
        Me.Almacen.Name = "Almacen"
        Me.Almacen.Size = New System.Drawing.Size(371, 23)
        Me.Almacen.TabIndex = 1
        '
        'descripcion
        '
        Me.descripcion.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.descripcion.Location = New System.Drawing.Point(109, 115)
        Me.descripcion.Margin = New System.Windows.Forms.Padding(4)
        Me.descripcion.MaxLength = 150
        Me.descripcion.Multiline = True
        Me.descripcion.Name = "descripcion"
        Me.descripcion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.descripcion.Size = New System.Drawing.Size(463, 40)
        Me.descripcion.TabIndex = 4
        '
        'borrar
        '
        Me.borrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.borrar.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.borrar.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.borrar.Location = New System.Drawing.Point(404, 22)
        Me.borrar.Margin = New System.Windows.Forms.Padding(4)
        Me.borrar.Name = "borrar"
        Me.borrar.Size = New System.Drawing.Size(87, 50)
        Me.borrar.TabIndex = 3
        Me.borrar.Text = "BORRAR"
        Me.borrar.UseVisualStyleBackColor = True
        '
        'guardar
        '
        Me.guardar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.guardar.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.guardar.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.guardar.Location = New System.Drawing.Point(312, 22)
        Me.guardar.Margin = New System.Windows.Forms.Padding(4)
        Me.guardar.Name = "guardar"
        Me.guardar.Size = New System.Drawing.Size(87, 50)
        Me.guardar.TabIndex = 2
        Me.guardar.Text = "GUARDAR"
        Me.guardar.UseVisualStyleBackColor = True
        '
        'bSalir
        '
        Me.bSalir.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bSalir.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bSalir.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.bSalir.Location = New System.Drawing.Point(496, 22)
        Me.bSalir.Margin = New System.Windows.Forms.Padding(4)
        Me.bSalir.Name = "bSalir"
        Me.bSalir.Size = New System.Drawing.Size(87, 50)
        Me.bSalir.TabIndex = 4
        Me.bSalir.Text = "SALIR"
        Me.bSalir.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.ERP_SUGAR.My.Resources.Resources.LOGO_SUGAR_1_150
        Me.PictureBox1.Location = New System.Drawing.Point(12, 21)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(150, 53)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 13
        Me.PictureBox1.TabStop = False
        '
        'gestionAlmacenes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(607, 673)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.bSalir)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.borrar)
        Me.Controls.Add(Me.nuevo)
        Me.Controls.Add(Me.guardar)
        Me.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "gestionAlmacenes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "GESTIÓN DE ALMACENES"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents nuevo As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents borrar As System.Windows.Forms.Button
    Friend WithEvents guardar As System.Windows.Forms.Button
    Friend WithEvents lvAlmacenes As System.Windows.Forms.ListView
    Friend WithEvents lvAlmacen As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents descripcion As System.Windows.Forms.TextBox
    Friend WithEvents bSalir As System.Windows.Forms.Button
    Friend WithEvents ckActivo As System.Windows.Forms.CheckBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Almacen As System.Windows.Forms.TextBox
    Friend WithEvents lvidAlmacen As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label46 As System.Windows.Forms.Label
    Friend WithEvents cbDirecciones As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cbTipoAlmacen As System.Windows.Forms.ComboBox
    Friend WithEvents lvTipo As System.Windows.Forms.ColumnHeader
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
