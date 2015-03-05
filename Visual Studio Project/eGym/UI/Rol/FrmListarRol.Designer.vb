<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmListarRol
    Inherits System.Windows.Forms.UserControl

    'UserControl reemplaza a Dispose para limpiar la lista de componentes.
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.tblRoles = New MetroFramework.Controls.MetroGrid()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.txtBuscar = New MetroFramework.Controls.MetroTextBox()
        Me.MetroButton1 = New MetroFramework.Controls.MetroButton()
        Me.txtModificar = New MetroFramework.Controls.MetroButton()
        Me.txtEliminar = New MetroFramework.Controls.MetroButton()
        CType(Me.tblRoles, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tblRoles
        '
        Me.tblRoles.AllowUserToResizeRows = False
        Me.tblRoles.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tblRoles.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tblRoles.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.tblRoles.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.tblRoles.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.tblRoles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.tblRoles.DefaultCellStyle = DataGridViewCellStyle2
        Me.tblRoles.EnableHeadersVisualStyles = False
        Me.tblRoles.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.tblRoles.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tblRoles.Location = New System.Drawing.Point(29, 93)
        Me.tblRoles.Name = "tblRoles"
        Me.tblRoles.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.tblRoles.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.tblRoles.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.tblRoles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.tblRoles.Size = New System.Drawing.Size(670, 226)
        Me.tblRoles.TabIndex = 0
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.Location = New System.Drawing.Point(27, 66)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(47, 19)
        Me.MetroLabel1.TabIndex = 1
        Me.MetroLabel1.Text = "Buscar"
        '
        'txtBuscar
        '
        Me.txtBuscar.Lines = New String(-1) {}
        Me.txtBuscar.Location = New System.Drawing.Point(81, 64)
        Me.txtBuscar.MaxLength = 32767
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtBuscar.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtBuscar.SelectedText = ""
        Me.txtBuscar.Size = New System.Drawing.Size(172, 23)
        Me.txtBuscar.TabIndex = 2
        Me.txtBuscar.UseSelectable = True
        '
        'MetroButton1
        '
        Me.MetroButton1.Location = New System.Drawing.Point(461, 64)
        Me.MetroButton1.Name = "MetroButton1"
        Me.MetroButton1.Size = New System.Drawing.Size(75, 23)
        Me.MetroButton1.TabIndex = 3
        Me.MetroButton1.Text = "Agregar"
        Me.MetroButton1.UseSelectable = True
        '
        'txtModificar
        '
        Me.txtModificar.Location = New System.Drawing.Point(542, 64)
        Me.txtModificar.Name = "txtModificar"
        Me.txtModificar.Size = New System.Drawing.Size(75, 23)
        Me.txtModificar.TabIndex = 4
        Me.txtModificar.Text = "Modificar"
        Me.txtModificar.UseSelectable = True
        '
        'txtEliminar
        '
        Me.txtEliminar.Location = New System.Drawing.Point(623, 64)
        Me.txtEliminar.Name = "txtEliminar"
        Me.txtEliminar.Size = New System.Drawing.Size(75, 23)
        Me.txtEliminar.TabIndex = 5
        Me.txtEliminar.Text = "Eliminar"
        Me.txtEliminar.UseSelectable = True
        '
        'FrmListarRol
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.txtEliminar)
        Me.Controls.Add(Me.txtModificar)
        Me.Controls.Add(Me.MetroButton1)
        Me.Controls.Add(Me.txtBuscar)
        Me.Controls.Add(Me.MetroLabel1)
        Me.Controls.Add(Me.tblRoles)
        Me.Name = "FrmListarRol"
        Me.Size = New System.Drawing.Size(740, 358)
        CType(Me.tblRoles, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tblRoles As MetroFramework.Controls.MetroGrid
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtBuscar As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroButton1 As MetroFramework.Controls.MetroButton
    Friend WithEvents txtModificar As MetroFramework.Controls.MetroButton
    Friend WithEvents txtEliminar As MetroFramework.Controls.MetroButton

End Class
