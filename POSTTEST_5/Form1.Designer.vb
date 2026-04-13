<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        ContextMenuStrip1 = New ContextMenuStrip(components)
        MenuStrip1 = New MenuStrip()
        MenuStrip2 = New MenuStrip()
        MenuKelolaBuah = New ToolStripMenuItem()
        MenuKeluar = New ToolStripMenuItem()
        dgvTampilanUtama = New DataGridView()
        Label1 = New Label()
        txtSearchUtama = New TextBox()
        MenuStrip2.SuspendLayout()
        CType(dgvTampilanUtama, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' ContextMenuStrip1
        ' 
        ContextMenuStrip1.ImageScalingSize = New Size(20, 20)
        ContextMenuStrip1.Name = "ContextMenuStrip1"
        ContextMenuStrip1.Size = New Size(61, 4)
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.ImageScalingSize = New Size(20, 20)
        MenuStrip1.Location = New Point(0, 28)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(800, 24)
        MenuStrip1.TabIndex = 2
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' MenuStrip2
        ' 
        MenuStrip2.ImageScalingSize = New Size(20, 20)
        MenuStrip2.Items.AddRange(New ToolStripItem() {MenuKelolaBuah, MenuKeluar})
        MenuStrip2.Location = New Point(0, 0)
        MenuStrip2.Name = "MenuStrip2"
        MenuStrip2.Size = New Size(800, 28)
        MenuStrip2.TabIndex = 3
        MenuStrip2.Text = "MenuStrip2"
        ' 
        ' MenuKelolaBuah
        ' 
        MenuKelolaBuah.Name = "MenuKelolaBuah"
        MenuKelolaBuah.Size = New Size(102, 24)
        MenuKelolaBuah.Text = "Kelola Buah"
        ' 
        ' MenuKeluar
        ' 
        MenuKeluar.Name = "MenuKeluar"
        MenuKeluar.Size = New Size(65, 24)
        MenuKeluar.Text = "Keluar"
        ' 
        ' dgvTampilanUtama
        ' 
        dgvTampilanUtama.BackgroundColor = Color.Azure
        dgvTampilanUtama.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvTampilanUtama.Location = New Point(12, 135)
        dgvTampilanUtama.Name = "dgvTampilanUtama"
        dgvTampilanUtama.RowHeadersWidth = 51
        dgvTampilanUtama.Size = New Size(776, 303)
        dgvTampilanUtama.TabIndex = 4
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Elephant", 11.999999F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(12, 68)
        Label1.Name = "Label1"
        Label1.Size = New Size(217, 26)
        Label1.TabIndex = 5
        Label1.Text = "Data dan Stok Buah"
        ' 
        ' txtSearchUtama
        ' 
        txtSearchUtama.Location = New Point(12, 102)
        txtSearchUtama.Name = "txtSearchUtama"
        txtSearchUtama.PlaceholderText = "Search"
        txtSearchUtama.Size = New Size(408, 27)
        txtSearchUtama.TabIndex = 6
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.PaleTurquoise
        ClientSize = New Size(800, 450)
        Controls.Add(txtSearchUtama)
        Controls.Add(Label1)
        Controls.Add(dgvTampilanUtama)
        Controls.Add(MenuStrip1)
        Controls.Add(MenuStrip2)
        MainMenuStrip = MenuStrip1
        Name = "Form1"
        Text = "Form1"
        MenuStrip2.ResumeLayout(False)
        MenuStrip2.PerformLayout()
        CType(dgvTampilanUtama, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MenuStrip2 As MenuStrip
    Friend WithEvents MenuKelolaBuah As ToolStripMenuItem
    Friend WithEvents MenuKeluar As ToolStripMenuItem
    Friend WithEvents dgvTampilanUtama As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents txtSearchUtama As TextBox

End Class
