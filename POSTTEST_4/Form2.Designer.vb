<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Panel1 = New Panel()
        lblHobbyKartu = New Label()
        lblKontakKartu = New Label()
        lblKomunitasKartu = New Label()
        lblIDKartu = New Label()
        lblNamaKartu = New Label()
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackgroundImage = My.Resources.Resources.card1
        Panel1.BackgroundImageLayout = ImageLayout.Stretch
        Panel1.Controls.Add(lblHobbyKartu)
        Panel1.Controls.Add(lblKontakKartu)
        Panel1.Controls.Add(lblKomunitasKartu)
        Panel1.Controls.Add(lblIDKartu)
        Panel1.Controls.Add(lblNamaKartu)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(PictureBox1)
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(801, 451)
        Panel1.TabIndex = 0
        ' 
        ' lblHobbyKartu
        ' 
        lblHobbyKartu.AutoSize = True
        lblHobbyKartu.BackColor = Color.Transparent
        lblHobbyKartu.Font = New Font("Segoe UI Semibold", 13.8F, FontStyle.Bold)
        lblHobbyKartu.ForeColor = Color.White
        lblHobbyKartu.Location = New Point(493, 286)
        lblHobbyKartu.Name = "lblHobbyKartu"
        lblHobbyKartu.Size = New Size(47, 31)
        lblHobbyKartu.TabIndex = 11
        lblHobbyKartu.Text = "Tes"
        ' 
        ' lblKontakKartu
        ' 
        lblKontakKartu.AutoSize = True
        lblKontakKartu.BackColor = Color.Transparent
        lblKontakKartu.Font = New Font("Segoe UI Semibold", 13.8F, FontStyle.Bold)
        lblKontakKartu.ForeColor = Color.White
        lblKontakKartu.Location = New Point(493, 237)
        lblKontakKartu.Name = "lblKontakKartu"
        lblKontakKartu.Size = New Size(47, 31)
        lblKontakKartu.TabIndex = 10
        lblKontakKartu.Text = "Tes"
        ' 
        ' lblKomunitasKartu
        ' 
        lblKomunitasKartu.AutoSize = True
        lblKomunitasKartu.BackColor = Color.Transparent
        lblKomunitasKartu.Font = New Font("Segoe UI Semibold", 13.8F, FontStyle.Bold)
        lblKomunitasKartu.ForeColor = Color.White
        lblKomunitasKartu.Location = New Point(493, 190)
        lblKomunitasKartu.Name = "lblKomunitasKartu"
        lblKomunitasKartu.Size = New Size(47, 31)
        lblKomunitasKartu.TabIndex = 9
        lblKomunitasKartu.Text = "Tes"
        ' 
        ' lblIDKartu
        ' 
        lblIDKartu.AutoSize = True
        lblIDKartu.BackColor = Color.Transparent
        lblIDKartu.Font = New Font("Segoe UI Semibold", 13.8F, FontStyle.Bold)
        lblIDKartu.ForeColor = Color.White
        lblIDKartu.Location = New Point(493, 142)
        lblIDKartu.Name = "lblIDKartu"
        lblIDKartu.Size = New Size(47, 31)
        lblIDKartu.TabIndex = 8
        lblIDKartu.Text = "Tes"
        ' 
        ' lblNamaKartu
        ' 
        lblNamaKartu.AutoSize = True
        lblNamaKartu.BackColor = Color.Transparent
        lblNamaKartu.Font = New Font("Segoe UI Semibold", 13.8F, FontStyle.Bold)
        lblNamaKartu.ForeColor = Color.White
        lblNamaKartu.Location = New Point(493, 92)
        lblNamaKartu.Name = "lblNamaKartu"
        lblNamaKartu.Size = New Size(47, 31)
        lblNamaKartu.TabIndex = 7
        lblNamaKartu.Text = "Tes"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Times New Roman", 22.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(279, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(297, 42)
        Label1.TabIndex = 1
        Label1.Text = "Kartu Komunitas"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Location = New Point(39, 45)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(209, 301)
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Panel1)
        Name = "Form2"
        Text = "Form2"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblHobbyKartu As Label
    Friend WithEvents lblKontakKartu As Label
    Friend WithEvents lblKomunitasKartu As Label
    Friend WithEvents lblIDKartu As Label
    Friend WithEvents lblNamaKartu As Label
End Class
