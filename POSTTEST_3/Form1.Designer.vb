<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormCetak
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
        pbProfil = New PictureBox()
        btnBrowse = New Button()
        Nama = New Label()
        Umur = New Label()
        Telpon = New Label()
        Label4 = New Label()
        Alamat = New Label()
        txtNama = New TextBox()
        txtUmur = New TextBox()
        txtTelpon = New TextBox()
        txtAlamat = New TextBox()
        gbGender = New GroupBox()
        rbPerempuan = New RadioButton()
        rbLaki = New RadioButton()
        gbHobby = New GroupBox()
        cbCoding = New CheckBox()
        cbBerkebun = New CheckBox()
        cbMusik = New CheckBox()
        cbMenggambar = New CheckBox()
        cbTravelling = New CheckBox()
        cbMemasak = New CheckBox()
        cbFotografi = New CheckBox()
        cbOlahraga = New CheckBox()
        cbMenonton = New CheckBox()
        cbGaming = New CheckBox()
        cbMenulis = New CheckBox()
        cbMembaca = New CheckBox()
        btnCetak = New Button()
        dtpLahir = New DateTimePicker()
        CType(pbProfil, ComponentModel.ISupportInitialize).BeginInit()
        gbGender.SuspendLayout()
        gbHobby.SuspendLayout()
        SuspendLayout()
        ' 
        ' pbProfil
        ' 
        pbProfil.Location = New Point(24, 30)
        pbProfil.Name = "pbProfil"
        pbProfil.Size = New Size(164, 249)
        pbProfil.TabIndex = 0
        pbProfil.TabStop = False
        ' 
        ' btnBrowse
        ' 
        btnBrowse.Location = New Point(62, 297)
        btnBrowse.Name = "btnBrowse"
        btnBrowse.Size = New Size(87, 26)
        btnBrowse.TabIndex = 1
        btnBrowse.Text = "Browse"
        btnBrowse.UseVisualStyleBackColor = True
        ' 
        ' Nama
        ' 
        Nama.AutoSize = True
        Nama.Location = New Point(210, 30)
        Nama.Name = "Nama"
        Nama.Size = New Size(49, 20)
        Nama.TabIndex = 2
        Nama.Text = "Nama"
        ' 
        ' Umur
        ' 
        Umur.AutoSize = True
        Umur.Location = New Point(210, 66)
        Umur.Name = "Umur"
        Umur.Size = New Size(45, 20)
        Umur.TabIndex = 3
        Umur.Text = "Umur"
        ' 
        ' Telpon
        ' 
        Telpon.AutoSize = True
        Telpon.Location = New Point(210, 99)
        Telpon.Name = "Telpon"
        Telpon.Size = New Size(61, 20)
        Telpon.TabIndex = 4
        Telpon.Text = "No Telp"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(206, 132)
        Label4.Name = "Label4"
        Label4.Size = New Size(65, 20)
        Label4.TabIndex = 5
        Label4.Text = "Tgl Lahir"
        ' 
        ' Alamat
        ' 
        Alamat.AutoSize = True
        Alamat.Location = New Point(210, 164)
        Alamat.Name = "Alamat"
        Alamat.Size = New Size(57, 20)
        Alamat.TabIndex = 6
        Alamat.Text = "Alamat"
        ' 
        ' txtNama
        ' 
        txtNama.Location = New Point(278, 30)
        txtNama.Name = "txtNama"
        txtNama.Size = New Size(279, 27)
        txtNama.TabIndex = 7
        ' 
        ' txtUmur
        ' 
        txtUmur.Location = New Point(278, 63)
        txtUmur.Name = "txtUmur"
        txtUmur.Size = New Size(279, 27)
        txtUmur.TabIndex = 8
        ' 
        ' txtTelpon
        ' 
        txtTelpon.Location = New Point(278, 96)
        txtTelpon.Name = "txtTelpon"
        txtTelpon.Size = New Size(279, 27)
        txtTelpon.TabIndex = 9
        ' 
        ' txtAlamat
        ' 
        txtAlamat.Location = New Point(278, 161)
        txtAlamat.Name = "txtAlamat"
        txtAlamat.Size = New Size(279, 27)
        txtAlamat.TabIndex = 11
        ' 
        ' gbGender
        ' 
        gbGender.Controls.Add(rbPerempuan)
        gbGender.Controls.Add(rbLaki)
        gbGender.Location = New Point(563, 30)
        gbGender.Name = "gbGender"
        gbGender.Size = New Size(182, 158)
        gbGender.TabIndex = 12
        gbGender.TabStop = False
        gbGender.Text = "Jenis Kelamin"
        ' 
        ' rbPerempuan
        ' 
        rbPerempuan.AutoSize = True
        rbPerempuan.Location = New Point(6, 57)
        rbPerempuan.Name = "rbPerempuan"
        rbPerempuan.Size = New Size(104, 24)
        rbPerempuan.TabIndex = 1
        rbPerempuan.TabStop = True
        rbPerempuan.Text = "Perempuan"
        rbPerempuan.UseVisualStyleBackColor = True
        ' 
        ' rbLaki
        ' 
        rbLaki.AutoSize = True
        rbLaki.Location = New Point(6, 26)
        rbLaki.Name = "rbLaki"
        rbLaki.Size = New Size(86, 24)
        rbLaki.TabIndex = 0
        rbLaki.TabStop = True
        rbLaki.Text = "Laki Laki"
        rbLaki.UseVisualStyleBackColor = True
        ' 
        ' gbHobby
        ' 
        gbHobby.Controls.Add(cbCoding)
        gbHobby.Controls.Add(cbBerkebun)
        gbHobby.Controls.Add(cbMusik)
        gbHobby.Controls.Add(cbMenggambar)
        gbHobby.Controls.Add(cbTravelling)
        gbHobby.Controls.Add(cbMemasak)
        gbHobby.Controls.Add(cbFotografi)
        gbHobby.Controls.Add(cbOlahraga)
        gbHobby.Controls.Add(cbMenonton)
        gbHobby.Controls.Add(cbGaming)
        gbHobby.Controls.Add(cbMenulis)
        gbHobby.Controls.Add(cbMembaca)
        gbHobby.Location = New Point(210, 194)
        gbHobby.Name = "gbHobby"
        gbHobby.Size = New Size(535, 157)
        gbHobby.TabIndex = 13
        gbHobby.TabStop = False
        gbHobby.Text = "Hobby"
        ' 
        ' cbCoding
        ' 
        cbCoding.AutoSize = True
        cbCoding.Location = New Point(418, 118)
        cbCoding.Name = "cbCoding"
        cbCoding.Size = New Size(79, 24)
        cbCoding.TabIndex = 11
        cbCoding.Text = "Coding"
        cbCoding.UseVisualStyleBackColor = True
        ' 
        ' cbBerkebun
        ' 
        cbBerkebun.AutoSize = True
        cbBerkebun.Location = New Point(418, 73)
        cbBerkebun.Name = "cbBerkebun"
        cbBerkebun.Size = New Size(93, 24)
        cbBerkebun.TabIndex = 10
        cbBerkebun.Text = "Berkebun"
        cbBerkebun.UseVisualStyleBackColor = True
        ' 
        ' cbMusik
        ' 
        cbMusik.AutoSize = True
        cbMusik.Location = New Point(418, 26)
        cbMusik.Name = "cbMusik"
        cbMusik.Size = New Size(69, 24)
        cbMusik.TabIndex = 9
        cbMusik.Text = "Musik"
        cbMusik.UseVisualStyleBackColor = True
        ' 
        ' cbMenggambar
        ' 
        cbMenggambar.AutoSize = True
        cbMenggambar.Location = New Point(286, 118)
        cbMenggambar.Name = "cbMenggambar"
        cbMenggambar.Size = New Size(121, 24)
        cbMenggambar.TabIndex = 8
        cbMenggambar.Text = "Menggambar"
        cbMenggambar.UseVisualStyleBackColor = True
        ' 
        ' cbTravelling
        ' 
        cbTravelling.AutoSize = True
        cbTravelling.Location = New Point(286, 73)
        cbTravelling.Name = "cbTravelling"
        cbTravelling.Size = New Size(95, 24)
        cbTravelling.TabIndex = 7
        cbTravelling.Text = "Travelling"
        cbTravelling.UseVisualStyleBackColor = True
        ' 
        ' cbMemasak
        ' 
        cbMemasak.AutoSize = True
        cbMemasak.Location = New Point(286, 27)
        cbMemasak.Name = "cbMemasak"
        cbMemasak.Size = New Size(94, 24)
        cbMemasak.TabIndex = 6
        cbMemasak.Text = "Memasak"
        cbMemasak.UseVisualStyleBackColor = True
        ' 
        ' cbFotografi
        ' 
        cbFotografi.AutoSize = True
        cbFotografi.Location = New Point(147, 118)
        cbFotografi.Name = "cbFotografi"
        cbFotografi.Size = New Size(92, 24)
        cbFotografi.TabIndex = 5
        cbFotografi.Text = "Fotografi"
        cbFotografi.UseVisualStyleBackColor = True
        ' 
        ' cbOlahraga
        ' 
        cbOlahraga.AutoSize = True
        cbOlahraga.Location = New Point(147, 73)
        cbOlahraga.Name = "cbOlahraga"
        cbOlahraga.Size = New Size(92, 24)
        cbOlahraga.TabIndex = 4
        cbOlahraga.Text = "Olahraga"
        cbOlahraga.UseVisualStyleBackColor = True
        ' 
        ' cbMenonton
        ' 
        cbMenonton.AutoSize = True
        cbMenonton.Location = New Point(147, 27)
        cbMenonton.Name = "cbMenonton"
        cbMenonton.Size = New Size(99, 24)
        cbMenonton.TabIndex = 3
        cbMenonton.Text = "Menonton"
        cbMenonton.UseVisualStyleBackColor = True
        ' 
        ' cbGaming
        ' 
        cbGaming.AutoSize = True
        cbGaming.Location = New Point(6, 118)
        cbGaming.Name = "cbGaming"
        cbGaming.Size = New Size(83, 24)
        cbGaming.TabIndex = 2
        cbGaming.Text = "Gaming"
        cbGaming.UseVisualStyleBackColor = True
        ' 
        ' cbMenulis
        ' 
        cbMenulis.AutoSize = True
        cbMenulis.Location = New Point(6, 73)
        cbMenulis.Name = "cbMenulis"
        cbMenulis.Size = New Size(82, 24)
        cbMenulis.TabIndex = 1
        cbMenulis.Text = "Menulis"
        cbMenulis.UseVisualStyleBackColor = True
        ' 
        ' cbMembaca
        ' 
        cbMembaca.AutoSize = True
        cbMembaca.Location = New Point(6, 27)
        cbMembaca.Name = "cbMembaca"
        cbMembaca.Size = New Size(97, 24)
        cbMembaca.TabIndex = 0
        cbMembaca.Text = "Membaca"
        cbMembaca.UseVisualStyleBackColor = True
        ' 
        ' btnCetak
        ' 
        btnCetak.Location = New Point(369, 357)
        btnCetak.Name = "btnCetak"
        btnCetak.Size = New Size(230, 29)
        btnCetak.TabIndex = 14
        btnCetak.Text = "Cetak"
        btnCetak.UseVisualStyleBackColor = True
        ' 
        ' dtpLahir
        ' 
        dtpLahir.Location = New Point(278, 132)
        dtpLahir.Name = "dtpLahir"
        dtpLahir.Size = New Size(279, 27)
        dtpLahir.TabIndex = 15
        ' 
        ' FormCetak
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.Screenshot_2026_03_16_210121
        ClientSize = New Size(800, 398)
        Controls.Add(dtpLahir)
        Controls.Add(btnCetak)
        Controls.Add(gbHobby)
        Controls.Add(gbGender)
        Controls.Add(txtAlamat)
        Controls.Add(txtTelpon)
        Controls.Add(txtUmur)
        Controls.Add(txtNama)
        Controls.Add(Alamat)
        Controls.Add(Label4)
        Controls.Add(Telpon)
        Controls.Add(Umur)
        Controls.Add(Nama)
        Controls.Add(btnBrowse)
        Controls.Add(pbProfil)
        Name = "FormCetak"
        Text = "Form Cetak"
        CType(pbProfil, ComponentModel.ISupportInitialize).EndInit()
        gbGender.ResumeLayout(False)
        gbGender.PerformLayout()
        gbHobby.ResumeLayout(False)
        gbHobby.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents pbProfil As PictureBox
    Friend WithEvents btnBrowse As Button
    Friend WithEvents Nama As Label
    Friend WithEvents Umur As Label
    Friend WithEvents Telpon As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Alamat As Label
    Friend WithEvents txtNama As TextBox
    Friend WithEvents txtUmur As TextBox
    Friend WithEvents txtTelpon As TextBox
    Friend WithEvents txtAlamat As TextBox
    Friend WithEvents gbGender As GroupBox
    Friend WithEvents gbHobby As GroupBox
    Friend WithEvents rbPerempuan As RadioButton
    Friend WithEvents rbLaki As RadioButton
    Friend WithEvents cbGaming As CheckBox
    Friend WithEvents cbMenulis As CheckBox
    Friend WithEvents cbMembaca As CheckBox
    Friend WithEvents btnCetak As Button
    Friend WithEvents dtpLahir As DateTimePicker
    Friend WithEvents cbCoding As CheckBox
    Friend WithEvents cbBerkebun As CheckBox
    Friend WithEvents cbMusik As CheckBox
    Friend WithEvents cbMenggambar As CheckBox
    Friend WithEvents cbTravelling As CheckBox
    Friend WithEvents cbMemasak As CheckBox
    Friend WithEvents cbFotografi As CheckBox
    Friend WithEvents cbOlahraga As CheckBox
    Friend WithEvents cbMenonton As CheckBox

End Class
