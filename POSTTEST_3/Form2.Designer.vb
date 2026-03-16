<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormHasil
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
        picHasil = New PictureBox()
        lblNamaHasil = New Label()
        lblUmurHasil = New Label()
        lblTelpHasil = New Label()
        lblAlamatHasil = New Label()
        lblJKHasil = New Label()
        lblHobiHasil = New Label()
        lblTglLahirHasil = New Label()
        Nama = New Label()
        Umur = New Label()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        CType(picHasil, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' picHasil
        ' 
        picHasil.Location = New Point(131, 101)
        picHasil.Name = "picHasil"
        picHasil.Size = New Size(156, 225)
        picHasil.SizeMode = PictureBoxSizeMode.Zoom
        picHasil.TabIndex = 0
        picHasil.TabStop = False
        ' 
        ' lblNamaHasil
        ' 
        lblNamaHasil.AutoSize = True
        lblNamaHasil.Location = New Point(489, 68)
        lblNamaHasil.Name = "lblNamaHasil"
        lblNamaHasil.Size = New Size(53, 20)
        lblNamaHasil.TabIndex = 1
        lblNamaHasil.Text = "Label1"
        ' 
        ' lblUmurHasil
        ' 
        lblUmurHasil.AutoSize = True
        lblUmurHasil.Location = New Point(489, 112)
        lblUmurHasil.Name = "lblUmurHasil"
        lblUmurHasil.Size = New Size(53, 20)
        lblUmurHasil.TabIndex = 2
        lblUmurHasil.Text = "Label2"
        ' 
        ' lblTelpHasil
        ' 
        lblTelpHasil.AutoSize = True
        lblTelpHasil.Location = New Point(489, 156)
        lblTelpHasil.Name = "lblTelpHasil"
        lblTelpHasil.Size = New Size(53, 20)
        lblTelpHasil.TabIndex = 3
        lblTelpHasil.Text = "Label3"
        ' 
        ' lblAlamatHasil
        ' 
        lblAlamatHasil.AutoSize = True
        lblAlamatHasil.Location = New Point(489, 197)
        lblAlamatHasil.Name = "lblAlamatHasil"
        lblAlamatHasil.Size = New Size(53, 20)
        lblAlamatHasil.TabIndex = 4
        lblAlamatHasil.Text = "Label4"
        ' 
        ' lblJKHasil
        ' 
        lblJKHasil.AutoSize = True
        lblJKHasil.Location = New Point(490, 244)
        lblJKHasil.Name = "lblJKHasil"
        lblJKHasil.Size = New Size(53, 20)
        lblJKHasil.TabIndex = 5
        lblJKHasil.Text = "Label5"
        ' 
        ' lblHobiHasil
        ' 
        lblHobiHasil.AutoSize = True
        lblHobiHasil.Location = New Point(491, 283)
        lblHobiHasil.Name = "lblHobiHasil"
        lblHobiHasil.Size = New Size(53, 20)
        lblHobiHasil.TabIndex = 6
        lblHobiHasil.Text = "Label6"
        ' 
        ' lblTglLahirHasil
        ' 
        lblTglLahirHasil.AutoSize = True
        lblTglLahirHasil.Location = New Point(492, 325)
        lblTglLahirHasil.Name = "lblTglLahirHasil"
        lblTglLahirHasil.Size = New Size(53, 20)
        lblTglLahirHasil.TabIndex = 7
        lblTglLahirHasil.Text = "Label1"
        ' 
        ' Nama
        ' 
        Nama.AutoSize = True
        Nama.BackColor = Color.Transparent
        Nama.Location = New Point(359, 68)
        Nama.Name = "Nama"
        Nama.Size = New Size(49, 20)
        Nama.TabIndex = 8
        Nama.Text = "Nama"
        ' 
        ' Umur
        ' 
        Umur.AutoSize = True
        Umur.BackColor = Color.Transparent
        Umur.Location = New Point(359, 112)
        Umur.Name = "Umur"
        Umur.Size = New Size(45, 20)
        Umur.TabIndex = 9
        Umur.Text = "Umur"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Location = New Point(361, 325)
        Label1.Name = "Label1"
        Label1.Size = New Size(97, 20)
        Label1.TabIndex = 10
        Label1.Text = "Tanggal Lahir"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Location = New Point(359, 244)
        Label2.Name = "Label2"
        Label2.Size = New Size(98, 20)
        Label2.TabIndex = 11
        Label2.Text = "Jenis Kelamin"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Location = New Point(361, 283)
        Label3.Name = "Label3"
        Label3.Size = New Size(42, 20)
        Label3.TabIndex = 12
        Label3.Text = "Hobi"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Location = New Point(360, 197)
        Label4.Name = "Label4"
        Label4.Size = New Size(57, 20)
        Label4.TabIndex = 13
        Label4.Text = "Alamat"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Location = New Point(360, 153)
        Label5.Name = "Label5"
        Label5.Size = New Size(61, 20)
        Label5.TabIndex = 14
        Label5.Text = "No Telp"
        ' 
        ' FormHasil
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.Black_White_Elegant_Minimalist_Member_Id_Card
        ClientSize = New Size(800, 401)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(Umur)
        Controls.Add(Nama)
        Controls.Add(lblTglLahirHasil)
        Controls.Add(lblHobiHasil)
        Controls.Add(lblJKHasil)
        Controls.Add(lblAlamatHasil)
        Controls.Add(lblTelpHasil)
        Controls.Add(lblUmurHasil)
        Controls.Add(lblNamaHasil)
        Controls.Add(picHasil)
        Name = "FormHasil"
        Text = "Hasil"
        CType(picHasil, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents picHasil As PictureBox
    Friend WithEvents lblNamaHasil As Label
    Friend WithEvents lblUmurHasil As Label
    Friend WithEvents lblTelpHasil As Label
    Friend WithEvents lblAlamatHasil As Label
    Friend WithEvents lblJKHasil As Label
    Friend WithEvents lblHobiHasil As Label
    Friend WithEvents lblTglLahirHasil As Label
    Friend WithEvents Nama As Label
    Friend WithEvents Umur As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
End Class
