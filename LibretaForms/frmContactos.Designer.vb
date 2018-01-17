<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmContactos
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.tabContactos = New System.Windows.Forms.TabControl()
        Me.tabPersonas = New System.Windows.Forms.TabPage()
        Me.btnAgregarPersona = New System.Windows.Forms.Button()
        Me.lstPersonas = New System.Windows.Forms.ListBox()
        Me.tabEmpresas = New System.Windows.Forms.TabPage()
        Me.pnlPersonas = New System.Windows.Forms.Panel()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtDirec = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dtpFecNac = New System.Windows.Forms.DateTimePicker()
        Me.txtDNI = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtApellido = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.tabContactos.SuspendLayout()
        Me.tabPersonas.SuspendLayout()
        Me.pnlPersonas.SuspendLayout()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.tabContactos)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.pnlPersonas)
        Me.SplitContainer1.Size = New System.Drawing.Size(755, 460)
        Me.SplitContainer1.SplitterDistance = 251
        Me.SplitContainer1.TabIndex = 0
        '
        'tabContactos
        '
        Me.tabContactos.Controls.Add(Me.tabPersonas)
        Me.tabContactos.Controls.Add(Me.tabEmpresas)
        Me.tabContactos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabContactos.Location = New System.Drawing.Point(0, 0)
        Me.tabContactos.Name = "tabContactos"
        Me.tabContactos.SelectedIndex = 0
        Me.tabContactos.Size = New System.Drawing.Size(251, 460)
        Me.tabContactos.TabIndex = 0
        '
        'tabPersonas
        '
        Me.tabPersonas.Controls.Add(Me.btnAgregarPersona)
        Me.tabPersonas.Controls.Add(Me.lstPersonas)
        Me.tabPersonas.Location = New System.Drawing.Point(4, 22)
        Me.tabPersonas.Name = "tabPersonas"
        Me.tabPersonas.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPersonas.Size = New System.Drawing.Size(243, 434)
        Me.tabPersonas.TabIndex = 0
        Me.tabPersonas.Text = "Personas"
        Me.tabPersonas.UseVisualStyleBackColor = True
        '
        'btnAgregarPersona
        '
        Me.btnAgregarPersona.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.btnAgregarPersona.Location = New System.Drawing.Point(8, 7)
        Me.btnAgregarPersona.Name = "btnAgregarPersona"
        Me.btnAgregarPersona.Size = New System.Drawing.Size(75, 23)
        Me.btnAgregarPersona.TabIndex = 31
        Me.btnAgregarPersona.Text = "Agregar"
        Me.btnAgregarPersona.UseVisualStyleBackColor = True
        '
        'lstPersonas
        '
        Me.lstPersonas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lstPersonas.FormattingEnabled = True
        Me.lstPersonas.Location = New System.Drawing.Point(8, 36)
        Me.lstPersonas.Name = "lstPersonas"
        Me.lstPersonas.Size = New System.Drawing.Size(229, 394)
        Me.lstPersonas.TabIndex = 0
        '
        'tabEmpresas
        '
        Me.tabEmpresas.Location = New System.Drawing.Point(4, 22)
        Me.tabEmpresas.Name = "tabEmpresas"
        Me.tabEmpresas.Padding = New System.Windows.Forms.Padding(3)
        Me.tabEmpresas.Size = New System.Drawing.Size(243, 434)
        Me.tabEmpresas.TabIndex = 1
        Me.tabEmpresas.Text = "Empresas"
        Me.tabEmpresas.UseVisualStyleBackColor = True
        '
        'pnlPersonas
        '
        Me.pnlPersonas.Controls.Add(Me.btnEliminar)
        Me.pnlPersonas.Controls.Add(Me.btnGuardar)
        Me.pnlPersonas.Controls.Add(Me.Label7)
        Me.pnlPersonas.Controls.Add(Me.txtDirec)
        Me.pnlPersonas.Controls.Add(Me.Label4)
        Me.pnlPersonas.Controls.Add(Me.dtpFecNac)
        Me.pnlPersonas.Controls.Add(Me.txtDNI)
        Me.pnlPersonas.Controls.Add(Me.Label3)
        Me.pnlPersonas.Controls.Add(Me.txtApellido)
        Me.pnlPersonas.Controls.Add(Me.Label2)
        Me.pnlPersonas.Controls.Add(Me.Label1)
        Me.pnlPersonas.Controls.Add(Me.txtNombre)
        Me.pnlPersonas.Location = New System.Drawing.Point(12, 12)
        Me.pnlPersonas.Name = "pnlPersonas"
        Me.pnlPersonas.Size = New System.Drawing.Size(413, 287)
        Me.pnlPersonas.TabIndex = 0
        '
        'btnEliminar
        '
        Me.btnEliminar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEliminar.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.btnEliminar.Enabled = False
        Me.btnEliminar.Location = New System.Drawing.Point(322, 250)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(75, 23)
        Me.btnEliminar.TabIndex = 31
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnGuardar
        '
        Me.btnGuardar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnGuardar.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.btnGuardar.Enabled = False
        Me.btnGuardar.Location = New System.Drawing.Point(241, 250)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(75, 23)
        Me.btnGuardar.TabIndex = 30
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(19, 122)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(52, 13)
        Me.Label7.TabIndex = 25
        Me.Label7.Text = "Dirección"
        '
        'txtDirec
        '
        Me.txtDirec.AcceptsReturn = True
        Me.txtDirec.Location = New System.Drawing.Point(133, 122)
        Me.txtDirec.Multiline = True
        Me.txtDirec.Name = "txtDirec"
        Me.txtDirec.Size = New System.Drawing.Size(264, 60)
        Me.txtDirec.TabIndex = 24
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(19, 96)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(108, 13)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "Fecha de Nacimiento"
        '
        'dtpFecNac
        '
        Me.dtpFecNac.Location = New System.Drawing.Point(133, 96)
        Me.dtpFecNac.Name = "dtpFecNac"
        Me.dtpFecNac.Size = New System.Drawing.Size(264, 20)
        Me.dtpFecNac.TabIndex = 22
        '
        'txtDNI
        '
        Me.txtDNI.Location = New System.Drawing.Point(133, 69)
        Me.txtDNI.Name = "txtDNI"
        Me.txtDNI.Size = New System.Drawing.Size(264, 20)
        Me.txtDNI.TabIndex = 21
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(19, 69)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(26, 13)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "DNI"
        '
        'txtApellido
        '
        Me.txtApellido.Location = New System.Drawing.Point(133, 43)
        Me.txtApellido.Name = "txtApellido"
        Me.txtApellido.Size = New System.Drawing.Size(264, 20)
        Me.txtApellido.TabIndex = 19
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(19, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Apellido"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(19, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Nombre"
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(133, 17)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(264, 20)
        Me.txtNombre.TabIndex = 16
        '
        'frmContactos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(755, 460)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "frmContactos"
        Me.Text = "Libreta de Contactos"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.tabContactos.ResumeLayout(False)
        Me.tabPersonas.ResumeLayout(False)
        Me.pnlPersonas.ResumeLayout(False)
        Me.pnlPersonas.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents tabContactos As TabControl
    Friend WithEvents tabPersonas As TabPage
    Friend WithEvents btnAgregarPersona As Button
    Friend WithEvents lstPersonas As ListBox
    Friend WithEvents tabEmpresas As TabPage
    Friend WithEvents pnlPersonas As Panel
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnGuardar As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents txtDirec As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents dtpFecNac As DateTimePicker
    Friend WithEvents txtDNI As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtApellido As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtNombre As TextBox
End Class
