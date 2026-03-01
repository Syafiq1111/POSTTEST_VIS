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
        lblips = New Label()
        lblipk = New Label()
        txtInput = New TextBox()
        txtIPK = New TextBox()
        btnTambah = New Button()
        btnReset = New Button()
        lblHasil = New Label()
        SuspendLayout()
        ' 
        ' lblips
        ' 
        lblips.AutoSize = True
        lblips.Location = New Point(21, 48)
        lblips.Name = "lblips"
        lblips.Size = New Size(86, 20)
        lblips.TabIndex = 0
        lblips.Text = "IP Semester"
        ' 
        ' lblipk
        ' 
        lblipk.AutoSize = True
        lblipk.Location = New Point(21, 134)
        lblipk.Name = "lblipk"
        lblipk.Size = New Size(89, 20)
        lblipk.TabIndex = 1
        lblipk.Text = "IP Kumulatif"
        ' 
        ' txtInput
        ' 
        txtInput.BackColor = SystemColors.Info
        txtInput.Location = New Point(124, 48)
        txtInput.Name = "txtInput"
        txtInput.Size = New Size(125, 27)
        txtInput.TabIndex = 2
        ' 
        ' txtIPK
        ' 
        txtIPK.BackColor = SystemColors.Info
        txtIPK.Enabled = False
        txtIPK.Location = New Point(124, 131)
        txtIPK.Name = "txtIPK"
        txtIPK.Size = New Size(125, 27)
        txtIPK.TabIndex = 3
        ' 
        ' btnTambah
        ' 
        btnTambah.Location = New Point(124, 81)
        btnTambah.Name = "btnTambah"
        btnTambah.Size = New Size(73, 29)
        btnTambah.TabIndex = 4
        btnTambah.Text = "Tambah"
        btnTambah.UseVisualStyleBackColor = True
        ' 
        ' btnReset
        ' 
        btnReset.Location = New Point(203, 81)
        btnReset.Name = "btnReset"
        btnReset.Size = New Size(73, 29)
        btnReset.TabIndex = 5
        btnReset.Text = "Reset"
        btnReset.UseVisualStyleBackColor = True
        ' 
        ' lblHasil
        ' 
        lblHasil.AutoSize = True
        lblHasil.Location = New Point(124, 180)
        lblHasil.Name = "lblHasil"
        lblHasil.Size = New Size(0, 20)
        lblHasil.TabIndex = 6
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.GradientInactiveCaption
        ClientSize = New Size(800, 450)
        Controls.Add(lblHasil)
        Controls.Add(btnReset)
        Controls.Add(btnTambah)
        Controls.Add(txtIPK)
        Controls.Add(txtInput)
        Controls.Add(lblipk)
        Controls.Add(lblips)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblips As Label
    Friend WithEvents lblipk As Label
    Friend WithEvents txtInput As TextBox
    Friend WithEvents txtIPK As TextBox
    Friend WithEvents btnTambah As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents lblHasil As Label

End Class
