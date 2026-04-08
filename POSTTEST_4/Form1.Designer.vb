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
        MenuStrip1 = New MenuStrip()
        mnInputData = New ToolStripMenuItem()
        mnLihatKartu = New ToolStripMenuItem()
        mnSimpanData = New ToolStripMenuItem()
        mnBukaData = New ToolStripMenuItem()
        mnKeluar = New ToolStripMenuItem()
        Label1 = New Label()
        picLogo = New PictureBox()
        TabPage3 = New TabPage()
        gbHobby = New GroupBox()
        cbOlahraga = New CheckBox()
        cbMusik = New CheckBox()
        cbPublicSpeaking = New CheckBox()
        cbFotografi = New CheckBox()
        cbEditing = New CheckBox()
        cbMenulis = New CheckBox()
        cbDesain = New CheckBox()
        cbNgoding = New CheckBox()
        btnCetak = New Button()
        btnSimpan = New Button()
        gbPeran = New GroupBox()
        rbAnggota = New RadioButton()
        rbMentor = New RadioButton()
        rbKoordinator = New RadioButton()
        rbAdmin = New RadioButton()
        rbBendahara = New RadioButton()
        rbSekretaris = New RadioButton()
        rbWakil = New RadioButton()
        rbKetua = New RadioButton()
        btnBrowse = New Button()
        picProfile = New PictureBox()
        TabPage2 = New TabPage()
        txtAlamat = New TextBox()
        txtEmail = New TextBox()
        mtxtTelepon = New MaskedTextBox()
        Label9 = New Label()
        Label8 = New Label()
        Label7 = New Label()
        TabPage1 = New TabPage()
        Label6 = New Label()
        cmbKomunitas = New ComboBox()
        rbPerempuan = New RadioButton()
        rbLaki = New RadioButton()
        Label5 = New Label()
        Label4 = New Label()
        dtpTanggalLahir = New DateTimePicker()
        Label3 = New Label()
        Label2 = New Label()
        txtIDAnggota = New TextBox()
        txtNama = New TextBox()
        TabControl1 = New TabControl()
        ErrorProvider1 = New ErrorProvider(components)
        OpenFileDialog1 = New OpenFileDialog()
        SaveFileDialog1 = New SaveFileDialog()
        Label10 = New Label()
        MenuStrip1.SuspendLayout()
        CType(picLogo, ComponentModel.ISupportInitialize).BeginInit()
        TabPage3.SuspendLayout()
        gbHobby.SuspendLayout()
        gbPeran.SuspendLayout()
        CType(picProfile, ComponentModel.ISupportInitialize).BeginInit()
        TabPage2.SuspendLayout()
        TabPage1.SuspendLayout()
        TabControl1.SuspendLayout()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.ImageScalingSize = New Size(20, 20)
        MenuStrip1.Items.AddRange(New ToolStripItem() {mnInputData, mnLihatKartu, mnSimpanData, mnBukaData, mnKeluar})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(800, 28)
        MenuStrip1.TabIndex = 0
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' mnInputData
        ' 
        mnInputData.Name = "mnInputData"
        mnInputData.Size = New Size(93, 24)
        mnInputData.Text = "Input Data"
        ' 
        ' mnLihatKartu
        ' 
        mnLihatKartu.Name = "mnLihatKartu"
        mnLihatKartu.Size = New Size(94, 24)
        mnLihatKartu.Text = "Lihat Kartu"
        ' 
        ' mnSimpanData
        ' 
        mnSimpanData.Name = "mnSimpanData"
        mnSimpanData.Size = New Size(109, 24)
        mnSimpanData.Text = "Simpan Data"
        ' 
        ' mnBukaData
        ' 
        mnBukaData.Name = "mnBukaData"
        mnBukaData.Size = New Size(91, 24)
        mnBukaData.Text = "Buka Data"
        ' 
        ' mnKeluar
        ' 
        mnKeluar.Name = "mnKeluar"
        mnKeluar.Size = New Size(65, 24)
        mnKeluar.Text = "Keluar"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.DodgerBlue
        Label1.Font = New Font("Times New Roman", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.Transparent
        Label1.Location = New Point(145, 42)
        Label1.Name = "Label1"
        Label1.Size = New Size(495, 38)
        Label1.TabIndex = 1
        Label1.Text = "Pembuatan Kartu Komunitas IT"
        ' 
        ' picLogo
        ' 
        picLogo.BackColor = Color.Transparent
        picLogo.BackgroundImage = My.Resources.Resources.logo
        picLogo.BackgroundImageLayout = ImageLayout.Stretch
        picLogo.Location = New Point(687, 31)
        picLogo.Name = "picLogo"
        picLogo.Size = New Size(101, 65)
        picLogo.TabIndex = 3
        picLogo.TabStop = False
        ' 
        ' TabPage3
        ' 
        TabPage3.BackgroundImage = My.Resources.Resources.form
        TabPage3.BackgroundImageLayout = ImageLayout.Stretch
        TabPage3.Controls.Add(gbHobby)
        TabPage3.Controls.Add(btnCetak)
        TabPage3.Controls.Add(btnSimpan)
        TabPage3.Controls.Add(gbPeran)
        TabPage3.Controls.Add(btnBrowse)
        TabPage3.Controls.Add(picProfile)
        TabPage3.Location = New Point(4, 29)
        TabPage3.Name = "TabPage3"
        TabPage3.Padding = New Padding(3)
        TabPage3.Size = New Size(683, 317)
        TabPage3.TabIndex = 2
        TabPage3.Text = "Profil & Aktivitas"
        TabPage3.UseVisualStyleBackColor = True
        ' 
        ' gbHobby
        ' 
        gbHobby.Controls.Add(cbOlahraga)
        gbHobby.Controls.Add(cbMusik)
        gbHobby.Controls.Add(cbPublicSpeaking)
        gbHobby.Controls.Add(cbFotografi)
        gbHobby.Controls.Add(cbEditing)
        gbHobby.Controls.Add(cbMenulis)
        gbHobby.Controls.Add(cbDesain)
        gbHobby.Controls.Add(cbNgoding)
        gbHobby.Location = New Point(216, 143)
        gbHobby.Name = "gbHobby"
        gbHobby.Size = New Size(416, 122)
        gbHobby.TabIndex = 3
        gbHobby.TabStop = False
        gbHobby.Text = "Hobby"
        ' 
        ' cbOlahraga
        ' 
        cbOlahraga.AutoSize = True
        cbOlahraga.ForeColor = Color.White
        cbOlahraga.Location = New Point(282, 56)
        cbOlahraga.Name = "cbOlahraga"
        cbOlahraga.Size = New Size(92, 24)
        cbOlahraga.TabIndex = 7
        cbOlahraga.Text = "Olahraga"
        cbOlahraga.UseVisualStyleBackColor = True
        ' 
        ' cbMusik
        ' 
        cbMusik.AutoSize = True
        cbMusik.ForeColor = Color.White
        cbMusik.Location = New Point(283, 26)
        cbMusik.Name = "cbMusik"
        cbMusik.Size = New Size(69, 24)
        cbMusik.TabIndex = 6
        cbMusik.Text = "Musik"
        cbMusik.UseVisualStyleBackColor = True
        ' 
        ' cbPublicSpeaking
        ' 
        cbPublicSpeaking.AutoSize = True
        cbPublicSpeaking.ForeColor = Color.White
        cbPublicSpeaking.Location = New Point(143, 86)
        cbPublicSpeaking.Name = "cbPublicSpeaking"
        cbPublicSpeaking.Size = New Size(136, 24)
        cbPublicSpeaking.TabIndex = 5
        cbPublicSpeaking.Text = "Public Speaking"
        cbPublicSpeaking.UseVisualStyleBackColor = True
        ' 
        ' cbFotografi
        ' 
        cbFotografi.AutoSize = True
        cbFotografi.ForeColor = Color.White
        cbFotografi.Location = New Point(143, 56)
        cbFotografi.Name = "cbFotografi"
        cbFotografi.Size = New Size(92, 24)
        cbFotografi.TabIndex = 4
        cbFotografi.Text = "Fotografi"
        cbFotografi.UseVisualStyleBackColor = True
        ' 
        ' cbEditing
        ' 
        cbEditing.AutoSize = True
        cbEditing.ForeColor = Color.White
        cbEditing.Location = New Point(143, 26)
        cbEditing.Name = "cbEditing"
        cbEditing.Size = New Size(78, 24)
        cbEditing.TabIndex = 3
        cbEditing.Text = "Editing"
        cbEditing.UseVisualStyleBackColor = True
        ' 
        ' cbMenulis
        ' 
        cbMenulis.AutoSize = True
        cbMenulis.ForeColor = Color.White
        cbMenulis.Location = New Point(26, 86)
        cbMenulis.Name = "cbMenulis"
        cbMenulis.Size = New Size(82, 24)
        cbMenulis.TabIndex = 2
        cbMenulis.Text = "Menulis"
        cbMenulis.UseVisualStyleBackColor = True
        ' 
        ' cbDesain
        ' 
        cbDesain.AutoSize = True
        cbDesain.ForeColor = Color.White
        cbDesain.Location = New Point(26, 56)
        cbDesain.Name = "cbDesain"
        cbDesain.Size = New Size(76, 24)
        cbDesain.TabIndex = 1
        cbDesain.Text = "Desain"
        cbDesain.UseVisualStyleBackColor = True
        ' 
        ' cbNgoding
        ' 
        cbNgoding.AutoSize = True
        cbNgoding.ForeColor = Color.White
        cbNgoding.Location = New Point(26, 26)
        cbNgoding.Name = "cbNgoding"
        cbNgoding.Size = New Size(90, 24)
        cbNgoding.TabIndex = 0
        cbNgoding.Text = "Ngoding"
        cbNgoding.UseVisualStyleBackColor = True
        ' 
        ' btnCetak
        ' 
        btnCetak.BackColor = Color.Cyan
        btnCetak.Location = New Point(425, 269)
        btnCetak.Name = "btnCetak"
        btnCetak.Size = New Size(94, 29)
        btnCetak.TabIndex = 5
        btnCetak.Text = "Cetak"
        btnCetak.UseVisualStyleBackColor = False
        ' 
        ' btnSimpan
        ' 
        btnSimpan.BackColor = Color.Lime
        btnSimpan.ForeColor = SystemColors.ActiveCaptionText
        btnSimpan.Location = New Point(300, 271)
        btnSimpan.Name = "btnSimpan"
        btnSimpan.Size = New Size(94, 29)
        btnSimpan.TabIndex = 4
        btnSimpan.Text = "Simpan"
        btnSimpan.UseVisualStyleBackColor = False
        ' 
        ' gbPeran
        ' 
        gbPeran.Controls.Add(rbAnggota)
        gbPeran.Controls.Add(rbMentor)
        gbPeran.Controls.Add(rbKoordinator)
        gbPeran.Controls.Add(rbAdmin)
        gbPeran.Controls.Add(rbBendahara)
        gbPeran.Controls.Add(rbSekretaris)
        gbPeran.Controls.Add(rbWakil)
        gbPeran.Controls.Add(rbKetua)
        gbPeran.Location = New Point(216, 15)
        gbPeran.Name = "gbPeran"
        gbPeran.Size = New Size(416, 122)
        gbPeran.TabIndex = 2
        gbPeran.TabStop = False
        gbPeran.Text = "Pilihan Peran"
        ' 
        ' rbAnggota
        ' 
        rbAnggota.AutoSize = True
        rbAnggota.ForeColor = Color.White
        rbAnggota.Location = New Point(270, 56)
        rbAnggota.Name = "rbAnggota"
        rbAnggota.Size = New Size(88, 24)
        rbAnggota.TabIndex = 10
        rbAnggota.TabStop = True
        rbAnggota.Text = "Anggota"
        rbAnggota.UseVisualStyleBackColor = True
        ' 
        ' rbMentor
        ' 
        rbMentor.AutoSize = True
        rbMentor.ForeColor = Color.White
        rbMentor.Location = New Point(270, 26)
        rbMentor.Name = "rbMentor"
        rbMentor.Size = New Size(78, 24)
        rbMentor.TabIndex = 9
        rbMentor.TabStop = True
        rbMentor.Text = "Mentor"
        rbMentor.UseVisualStyleBackColor = True
        ' 
        ' rbKoordinator
        ' 
        rbKoordinator.AutoSize = True
        rbKoordinator.ForeColor = Color.White
        rbKoordinator.Location = New Point(143, 86)
        rbKoordinator.Name = "rbKoordinator"
        rbKoordinator.Size = New Size(110, 24)
        rbKoordinator.TabIndex = 8
        rbKoordinator.TabStop = True
        rbKoordinator.Text = "Koordinator"
        rbKoordinator.UseVisualStyleBackColor = True
        ' 
        ' rbAdmin
        ' 
        rbAdmin.AutoSize = True
        rbAdmin.ForeColor = Color.White
        rbAdmin.Location = New Point(143, 56)
        rbAdmin.Name = "rbAdmin"
        rbAdmin.Size = New Size(74, 24)
        rbAdmin.TabIndex = 7
        rbAdmin.TabStop = True
        rbAdmin.Text = "Admin"
        rbAdmin.UseVisualStyleBackColor = True
        ' 
        ' rbBendahara
        ' 
        rbBendahara.AutoSize = True
        rbBendahara.ForeColor = Color.White
        rbBendahara.Location = New Point(143, 26)
        rbBendahara.Name = "rbBendahara"
        rbBendahara.Size = New Size(101, 24)
        rbBendahara.TabIndex = 6
        rbBendahara.TabStop = True
        rbBendahara.Text = "Bendahara"
        rbBendahara.UseVisualStyleBackColor = True
        ' 
        ' rbSekretaris
        ' 
        rbSekretaris.AutoSize = True
        rbSekretaris.ForeColor = Color.White
        rbSekretaris.Location = New Point(8, 86)
        rbSekretaris.Name = "rbSekretaris"
        rbSekretaris.Size = New Size(94, 24)
        rbSekretaris.TabIndex = 5
        rbSekretaris.TabStop = True
        rbSekretaris.Text = "Sekretaris"
        rbSekretaris.UseVisualStyleBackColor = True
        ' 
        ' rbWakil
        ' 
        rbWakil.AutoSize = True
        rbWakil.ForeColor = Color.White
        rbWakil.Location = New Point(8, 56)
        rbWakil.Name = "rbWakil"
        rbWakil.Size = New Size(66, 24)
        rbWakil.TabIndex = 4
        rbWakil.TabStop = True
        rbWakil.Text = "Wakil"
        rbWakil.UseVisualStyleBackColor = True
        ' 
        ' rbKetua
        ' 
        rbKetua.AutoSize = True
        rbKetua.ForeColor = Color.White
        rbKetua.Location = New Point(8, 26)
        rbKetua.Name = "rbKetua"
        rbKetua.Size = New Size(68, 24)
        rbKetua.TabIndex = 3
        rbKetua.Text = "Ketua"
        rbKetua.UseVisualStyleBackColor = True
        ' 
        ' btnBrowse
        ' 
        btnBrowse.Location = New Point(62, 271)
        btnBrowse.Name = "btnBrowse"
        btnBrowse.Size = New Size(94, 29)
        btnBrowse.TabIndex = 1
        btnBrowse.Text = "Browse"
        btnBrowse.UseVisualStyleBackColor = True
        ' 
        ' picProfile
        ' 
        picProfile.Location = New Point(16, 15)
        picProfile.Name = "picProfile"
        picProfile.Size = New Size(180, 248)
        picProfile.TabIndex = 0
        picProfile.TabStop = False
        ' 
        ' TabPage2
        ' 
        TabPage2.BackgroundImage = My.Resources.Resources.form
        TabPage2.BackgroundImageLayout = ImageLayout.Stretch
        TabPage2.Controls.Add(txtAlamat)
        TabPage2.Controls.Add(txtEmail)
        TabPage2.Controls.Add(mtxtTelepon)
        TabPage2.Controls.Add(Label9)
        TabPage2.Controls.Add(Label8)
        TabPage2.Controls.Add(Label7)
        TabPage2.Location = New Point(4, 29)
        TabPage2.Name = "TabPage2"
        TabPage2.Padding = New Padding(3)
        TabPage2.Size = New Size(683, 317)
        TabPage2.TabIndex = 1
        TabPage2.Text = "Kontak & Info"
        TabPage2.UseVisualStyleBackColor = True
        ' 
        ' txtAlamat
        ' 
        txtAlamat.Location = New Point(108, 76)
        txtAlamat.Name = "txtAlamat"
        txtAlamat.Size = New Size(125, 27)
        txtAlamat.TabIndex = 5
        ' 
        ' txtEmail
        ' 
        txtEmail.Location = New Point(108, 42)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(125, 27)
        txtEmail.TabIndex = 4
        ' 
        ' mtxtTelepon
        ' 
        mtxtTelepon.Location = New Point(108, 8)
        mtxtTelepon.Mask = "0000-0000-0000"
        mtxtTelepon.Name = "mtxtTelepon"
        mtxtTelepon.Size = New Size(125, 27)
        mtxtTelepon.TabIndex = 3
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.ForeColor = Color.White
        Label9.Location = New Point(6, 81)
        Label9.Name = "Label9"
        Label9.Size = New Size(57, 20)
        Label9.TabIndex = 2
        Label9.Text = "Alamat"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.ForeColor = Color.White
        Label8.Location = New Point(6, 48)
        Label8.Name = "Label8"
        Label8.Size = New Size(46, 20)
        Label8.TabIndex = 1
        Label8.Text = "Email"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.ForeColor = Color.White
        Label7.Location = New Point(6, 15)
        Label7.Name = "Label7"
        Label7.Size = New Size(86, 20)
        Label7.TabIndex = 0
        Label7.Text = "No Telepon"
        ' 
        ' TabPage1
        ' 
        TabPage1.BackgroundImage = My.Resources.Resources.form
        TabPage1.BackgroundImageLayout = ImageLayout.Stretch
        TabPage1.Controls.Add(Label6)
        TabPage1.Controls.Add(cmbKomunitas)
        TabPage1.Controls.Add(rbPerempuan)
        TabPage1.Controls.Add(rbLaki)
        TabPage1.Controls.Add(Label5)
        TabPage1.Controls.Add(Label4)
        TabPage1.Controls.Add(dtpTanggalLahir)
        TabPage1.Controls.Add(Label3)
        TabPage1.Controls.Add(Label2)
        TabPage1.Controls.Add(txtIDAnggota)
        TabPage1.Controls.Add(txtNama)
        TabPage1.Location = New Point(4, 29)
        TabPage1.Name = "TabPage1"
        TabPage1.Padding = New Padding(3)
        TabPage1.Size = New Size(683, 317)
        TabPage1.TabIndex = 0
        TabPage1.Text = "Data Utama"
        TabPage1.UseVisualStyleBackColor = True
        ' 
        ' Label6
        ' 
        Label6.AllowDrop = True
        Label6.AutoSize = True
        Label6.ForeColor = Color.White
        Label6.Location = New Point(7, 197)
        Label6.Name = "Label6"
        Label6.Size = New Size(114, 20)
        Label6.TabIndex = 10
        Label6.Text = "Jenis Komunitas"
        ' 
        ' cmbKomunitas
        ' 
        cmbKomunitas.FormattingEnabled = True
        cmbKomunitas.Items.AddRange(New Object() {"Programming", "Desain Grafis", "Multimedia", "Robotik", "Fotografi", "Gaming", "Musik", "Olahraga"})
        cmbKomunitas.Location = New Point(129, 193)
        cmbKomunitas.Name = "cmbKomunitas"
        cmbKomunitas.Size = New Size(250, 28)
        cmbKomunitas.TabIndex = 9
        ' 
        ' rbPerempuan
        ' 
        rbPerempuan.AutoSize = True
        rbPerempuan.ForeColor = Color.White
        rbPerempuan.Location = New Point(224, 150)
        rbPerempuan.Name = "rbPerempuan"
        rbPerempuan.Size = New Size(104, 24)
        rbPerempuan.TabIndex = 8
        rbPerempuan.TabStop = True
        rbPerempuan.Text = "Perempuan"
        rbPerempuan.UseVisualStyleBackColor = True
        ' 
        ' rbLaki
        ' 
        rbLaki.AutoSize = True
        rbLaki.ForeColor = Color.White
        rbLaki.Location = New Point(129, 150)
        rbLaki.Name = "rbLaki"
        rbLaki.Size = New Size(86, 24)
        rbLaki.TabIndex = 7
        rbLaki.TabStop = True
        rbLaki.Text = "Laki Laki"
        rbLaki.UseVisualStyleBackColor = True
        ' 
        ' Label5
        ' 
        Label5.AllowDrop = True
        Label5.AutoSize = True
        Label5.ForeColor = Color.White
        Label5.Location = New Point(7, 152)
        Label5.Name = "Label5"
        Label5.Size = New Size(98, 20)
        Label5.TabIndex = 6
        Label5.Text = "Jenis Kelamin"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.ForeColor = Color.White
        Label4.Location = New Point(7, 104)
        Label4.Name = "Label4"
        Label4.Size = New Size(97, 20)
        Label4.TabIndex = 5
        Label4.Text = "Tanggal Lahir"
        ' 
        ' dtpTanggalLahir
        ' 
        dtpTanggalLahir.Location = New Point(129, 102)
        dtpTanggalLahir.Name = "dtpTanggalLahir"
        dtpTanggalLahir.Size = New Size(250, 27)
        dtpTanggalLahir.TabIndex = 4
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.ForeColor = Color.White
        Label3.Location = New Point(7, 59)
        Label3.Name = "Label3"
        Label3.Size = New Size(86, 20)
        Label3.TabIndex = 3
        Label3.Text = "ID Anggota"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.ForeColor = Color.White
        Label2.Location = New Point(7, 12)
        Label2.Name = "Label2"
        Label2.Size = New Size(49, 20)
        Label2.TabIndex = 2
        Label2.Text = "Nama"
        ' 
        ' txtIDAnggota
        ' 
        txtIDAnggota.Location = New Point(129, 55)
        txtIDAnggota.Name = "txtIDAnggota"
        txtIDAnggota.Size = New Size(250, 27)
        txtIDAnggota.TabIndex = 1
        ' 
        ' txtNama
        ' 
        txtNama.Location = New Point(129, 7)
        txtNama.Name = "txtNama"
        txtNama.Size = New Size(250, 27)
        txtNama.TabIndex = 0
        ' 
        ' TabControl1
        ' 
        TabControl1.Controls.Add(TabPage1)
        TabControl1.Controls.Add(TabPage2)
        TabControl1.Controls.Add(TabPage3)
        TabControl1.Location = New Point(12, 88)
        TabControl1.Name = "TabControl1"
        TabControl1.SelectedIndex = 0
        TabControl1.Size = New Size(691, 350)
        TabControl1.TabIndex = 2
        ' 
        ' ErrorProvider1
        ' 
        ErrorProvider1.ContainerControl = Me
        ' 
        ' OpenFileDialog1
        ' 
        OpenFileDialog1.FileName = "OpenFileDialog1"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.BackColor = Color.Transparent
        Label10.ForeColor = Color.DodgerBlue
        Label10.Location = New Point(716, 86)
        Label10.Name = "Label10"
        Label10.Size = New Size(47, 20)
        Label10.TabIndex = 4
        Label10.Text = "ITKAL"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.form
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(800, 450)
        Controls.Add(Label10)
        Controls.Add(picLogo)
        Controls.Add(TabControl1)
        Controls.Add(Label1)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        Name = "Form1"
        Text = "Form1"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        CType(picLogo, ComponentModel.ISupportInitialize).EndInit()
        TabPage3.ResumeLayout(False)
        gbHobby.ResumeLayout(False)
        gbHobby.PerformLayout()
        gbPeran.ResumeLayout(False)
        gbPeran.PerformLayout()
        CType(picProfile, ComponentModel.ISupportInitialize).EndInit()
        TabPage2.ResumeLayout(False)
        TabPage2.PerformLayout()
        TabPage1.ResumeLayout(False)
        TabPage1.PerformLayout()
        TabControl1.ResumeLayout(False)
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents mnInputData As ToolStripMenuItem
    Friend WithEvents mnLihatKartu As ToolStripMenuItem
    Friend WithEvents mnSimpanData As ToolStripMenuItem
    Friend WithEvents mnBukaData As ToolStripMenuItem
    Friend WithEvents mnKeluar As ToolStripMenuItem
    Friend WithEvents Label1 As Label
    Friend WithEvents picLogo As PictureBox
    Friend WithEvents CheckBox18 As CheckBox
    Friend WithEvents CheckBox17 As CheckBox
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents gbHobby As GroupBox
    Friend WithEvents cbOlahraga As CheckBox
    Friend WithEvents cbMusik As CheckBox
    Friend WithEvents cbPublicSpeaking As CheckBox
    Friend WithEvents cbFotografi As CheckBox
    Friend WithEvents cbEditing As CheckBox
    Friend WithEvents cbMenulis As CheckBox
    Friend WithEvents cbDesain As CheckBox
    Friend WithEvents cbNgoding As CheckBox
    Friend WithEvents btnCetak As Button
    Friend WithEvents btnSimpan As Button
    Friend WithEvents gbPeran As GroupBox
    Friend WithEvents rbAnggota As RadioButton
    Friend WithEvents rbMentor As RadioButton
    Friend WithEvents rbKoordinator As RadioButton
    Friend WithEvents rbAdmin As RadioButton
    Friend WithEvents rbBendahara As RadioButton
    Friend WithEvents rbSekretaris As RadioButton
    Friend WithEvents rbWakil As RadioButton
    Friend WithEvents rbKetua As RadioButton
    Friend WithEvents btnBrowse As Button
    Friend WithEvents picProfile As PictureBox
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents txtAlamat As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents mtxtTelepon As MaskedTextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents Label6 As Label
    Friend WithEvents cmbKomunitas As ComboBox
    Friend WithEvents rbPerempuan As RadioButton
    Friend WithEvents rbLaki As RadioButton
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents dtpTanggalLahir As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtIDAnggota As TextBox
    Friend WithEvents txtNama As TextBox
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents Label10 As Label

End Class
