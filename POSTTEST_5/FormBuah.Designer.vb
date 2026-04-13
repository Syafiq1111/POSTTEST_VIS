<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormBuah
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
        components = New ComponentModel.Container()
        txtID = New TextBox()
        txtNama = New TextBox()
        txtHarga = New TextBox()
        txtStok = New TextBox()
        txtSearch = New TextBox()
        btnSimpan = New Button()
        btnUbah = New Button()
        btnHapus = New Button()
        btnBatal = New Button()
        dgvBuah = New DataGridView()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        ErrorProvider1 = New ErrorProvider(components)
        btnKembali = New Button()
        CType(dgvBuah, ComponentModel.ISupportInitialize).BeginInit()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' txtID
        ' 
        txtID.Location = New Point(11, 93)
        txtID.Name = "txtID"
        txtID.Size = New Size(324, 27)
        txtID.TabIndex = 0
        ' 
        ' txtNama
        ' 
        txtNama.Location = New Point(12, 155)
        txtNama.Name = "txtNama"
        txtNama.Size = New Size(323, 27)
        txtNama.TabIndex = 1
        ' 
        ' txtHarga
        ' 
        txtHarga.Location = New Point(11, 216)
        txtHarga.Name = "txtHarga"
        txtHarga.Size = New Size(324, 27)
        txtHarga.TabIndex = 2
        ' 
        ' txtStok
        ' 
        txtStok.Location = New Point(11, 278)
        txtStok.Name = "txtStok"
        txtStok.Size = New Size(323, 27)
        txtStok.TabIndex = 3
        ' 
        ' txtSearch
        ' 
        txtSearch.Location = New Point(369, 26)
        txtSearch.Name = "txtSearch"
        txtSearch.PlaceholderText = "Search"
        txtSearch.Size = New Size(419, 27)
        txtSearch.TabIndex = 4
        ' 
        ' btnSimpan
        ' 
        btnSimpan.BackColor = Color.FromArgb(CByte(0), CByte(192), CByte(0))
        btnSimpan.Location = New Point(12, 324)
        btnSimpan.Name = "btnSimpan"
        btnSimpan.Size = New Size(94, 29)
        btnSimpan.TabIndex = 5
        btnSimpan.Text = "Simpan"
        btnSimpan.UseVisualStyleBackColor = False
        ' 
        ' btnUbah
        ' 
        btnUbah.BackColor = Color.FromArgb(CByte(0), CByte(192), CByte(192))
        btnUbah.Location = New Point(121, 324)
        btnUbah.Name = "btnUbah"
        btnUbah.Size = New Size(94, 29)
        btnUbah.TabIndex = 6
        btnUbah.Text = "Edit"
        btnUbah.UseVisualStyleBackColor = False
        ' 
        ' btnHapus
        ' 
        btnHapus.BackColor = Color.FromArgb(CByte(192), CByte(0), CByte(0))
        btnHapus.Location = New Point(240, 324)
        btnHapus.Name = "btnHapus"
        btnHapus.Size = New Size(94, 29)
        btnHapus.TabIndex = 7
        btnHapus.Text = "Hapus"
        btnHapus.UseVisualStyleBackColor = False
        ' 
        ' btnBatal
        ' 
        btnBatal.BackColor = Color.FromArgb(CByte(192), CByte(192), CByte(0))
        btnBatal.Location = New Point(121, 359)
        btnBatal.Name = "btnBatal"
        btnBatal.Size = New Size(94, 29)
        btnBatal.TabIndex = 8
        btnBatal.Text = "Batal"
        btnBatal.UseVisualStyleBackColor = False
        ' 
        ' dgvBuah
        ' 
        dgvBuah.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvBuah.Location = New Point(369, 59)
        dgvBuah.Name = "dgvBuah"
        dgvBuah.RowHeadersWidth = 51
        dgvBuah.Size = New Size(419, 379)
        dgvBuah.TabIndex = 9
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(12, 70)
        Label1.Name = "Label1"
        Label1.Size = New Size(73, 19)
        Label1.TabIndex = 10
        Label1.Text = "ID Buah :"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(11, 133)
        Label2.Name = "Label2"
        Label2.Size = New Size(95, 19)
        Label2.TabIndex = 11
        Label2.Text = "Nama Buah :"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(10, 194)
        Label3.Name = "Label3"
        Label3.Size = New Size(58, 19)
        Label3.TabIndex = 12
        Label3.Text = "Harga :"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(10, 256)
        Label4.Name = "Label4"
        Label4.Size = New Size(49, 19)
        Label4.TabIndex = 13
        Label4.Text = "Stok :"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Elephant", 16.1999989F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(12, 9)
        Label5.Name = "Label5"
        Label5.Size = New Size(339, 35)
        Label5.TabIndex = 14
        Label5.Text = "Pengelolaan Data Buah"
        ' 
        ' ErrorProvider1
        ' 
        ErrorProvider1.ContainerControl = Me
        ' 
        ' btnKembali
        ' 
        btnKembali.BackColor = Color.FromArgb(CByte(192), CByte(64), CByte(0))
        btnKembali.Location = New Point(10, 420)
        btnKembali.Name = "btnKembali"
        btnKembali.Size = New Size(94, 29)
        btnKembali.TabIndex = 15
        btnKembali.Text = "Kembali"
        btnKembali.UseVisualStyleBackColor = False
        ' 
        ' FormBuah
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.PaleTurquoise
        ClientSize = New Size(800, 450)
        Controls.Add(btnKembali)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(dgvBuah)
        Controls.Add(btnBatal)
        Controls.Add(btnHapus)
        Controls.Add(btnUbah)
        Controls.Add(btnSimpan)
        Controls.Add(txtSearch)
        Controls.Add(txtStok)
        Controls.Add(txtHarga)
        Controls.Add(txtNama)
        Controls.Add(txtID)
        Name = "FormBuah"
        Text = "FormBuah"
        CType(dgvBuah, ComponentModel.ISupportInitialize).EndInit()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtID As TextBox
    Friend WithEvents txtNama As TextBox
    Friend WithEvents txtHarga As TextBox
    Friend WithEvents txtStok As TextBox
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents btnSimpan As Button
    Friend WithEvents btnUbah As Button
    Friend WithEvents btnHapus As Button
    Friend WithEvents btnBatal As Button
    Friend WithEvents dgvBuah As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents btnKembali As Button
End Class
