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
        Label1 = New Label()
        Label2 = New Label()
        GroupBox1 = New GroupBox()
        btnTambah = New Button()
        txtGenre = New TextBox()
        txtJudul = New TextBox()
        GroupBox3 = New GroupBox()
        btnHapus = New Button()
        txthpsJudul = New TextBox()
        Label3 = New Label()
        dgvList = New DataGridView()
        Column1 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        GroupBox1.SuspendLayout()
        GroupBox3.SuspendLayout()
        CType(dgvList, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(6, 37)
        Label1.Name = "Label1"
        Label1.Size = New Size(79, 20)
        Label1.TabIndex = 0
        Label1.Text = "Judul Buku"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(6, 77)
        Label2.Name = "Label2"
        Label2.Size = New Size(48, 20)
        Label2.TabIndex = 1
        Label2.Text = "Genre"
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = Color.NavajoWhite
        GroupBox1.Controls.Add(btnTambah)
        GroupBox1.Controls.Add(txtGenre)
        GroupBox1.Controls.Add(txtJudul)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Location = New Point(12, 24)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(317, 174)
        GroupBox1.TabIndex = 2
        GroupBox1.TabStop = False
        GroupBox1.Text = "Tambah Buku"
        ' 
        ' btnTambah
        ' 
        btnTambah.BackColor = Color.LimeGreen
        btnTambah.Location = New Point(178, 126)
        btnTambah.Name = "btnTambah"
        btnTambah.Size = New Size(94, 32)
        btnTambah.TabIndex = 4
        btnTambah.Text = "Tambah"
        btnTambah.UseVisualStyleBackColor = False
        ' 
        ' txtGenre
        ' 
        txtGenre.Location = New Point(109, 73)
        txtGenre.Name = "txtGenre"
        txtGenre.Size = New Size(146, 27)
        txtGenre.TabIndex = 3
        ' 
        ' txtJudul
        ' 
        txtJudul.Location = New Point(109, 37)
        txtJudul.Name = "txtJudul"
        txtJudul.Size = New Size(146, 27)
        txtJudul.TabIndex = 2
        ' 
        ' GroupBox3
        ' 
        GroupBox3.BackColor = Color.NavajoWhite
        GroupBox3.Controls.Add(btnHapus)
        GroupBox3.Controls.Add(txthpsJudul)
        GroupBox3.Controls.Add(Label3)
        GroupBox3.Location = New Point(12, 221)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Size = New Size(317, 172)
        GroupBox3.TabIndex = 4
        GroupBox3.TabStop = False
        GroupBox3.Text = "Hapus Buku"
        ' 
        ' btnHapus
        ' 
        btnHapus.BackColor = Color.IndianRed
        btnHapus.Location = New Point(178, 114)
        btnHapus.Name = "btnHapus"
        btnHapus.Size = New Size(94, 29)
        btnHapus.TabIndex = 3
        btnHapus.Text = "Hapus"
        btnHapus.UseVisualStyleBackColor = False
        ' 
        ' txthpsJudul
        ' 
        txthpsJudul.Location = New Point(109, 37)
        txthpsJudul.Name = "txthpsJudul"
        txthpsJudul.Size = New Size(146, 27)
        txthpsJudul.TabIndex = 2
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(6, 37)
        Label3.Name = "Label3"
        Label3.Size = New Size(79, 20)
        Label3.TabIndex = 0
        Label3.Text = "Judul Buku"
        ' 
        ' dgvList
        ' 
        dgvList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvList.Columns.AddRange(New DataGridViewColumn() {Column1, Column2})
        dgvList.Location = New Point(347, 29)
        dgvList.Name = "dgvList"
        dgvList.RowHeadersWidth = 51
        dgvList.Size = New Size(431, 364)
        dgvList.TabIndex = 5
        ' 
        ' Column1
        ' 
        Column1.HeaderText = "Judul Buku"
        Column1.MinimumWidth = 6
        Column1.Name = "Column1"
        Column1.Width = 125
        ' 
        ' Column2
        ' 
        Column2.HeaderText = "Genre"
        Column2.MinimumWidth = 6
        Column2.Name = "Column2"
        Column2.Width = 125
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Khaki
        ClientSize = New Size(797, 440)
        Controls.Add(dgvList)
        Controls.Add(GroupBox3)
        Controls.Add(GroupBox1)
        ForeColor = SystemColors.ActiveCaptionText
        Name = "Form1"
        Text = "Posttest 2"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox3.ResumeLayout(False)
        GroupBox3.PerformLayout()
        CType(dgvList, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtGenre As TextBox
    Friend WithEvents txtJudul As TextBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents txthpsJudul As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents dgvList As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents btnTambah As Button
    Friend WithEvents btnHapus As Button

End Class
