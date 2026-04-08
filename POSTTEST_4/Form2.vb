Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblNamaKartu.Text = DataModule.Nama
        lblIDKartu.Text = DataModule.IDAnggota
        lblKomunitasKartu.Text = DataModule.Komunitas
        lblKontakKartu.Text = DataModule.NoTelp

        If Not String.IsNullOrEmpty(DataModule.Hobi) Then
            lblHobbyKartu.Text = DataModule.Hobi.TrimEnd(", ".ToCharArray())
        Else
            lblHobbyKartu.Text = "-"
        End If

        If Not String.IsNullOrEmpty(DataModule.FotoPath) AndAlso System.IO.File.Exists(DataModule.FotoPath) Then
            PictureBox1.Image = Image.FromFile(DataModule.FotoPath)
            PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        Else
            PictureBox1.Image = Nothing
        End If
    End Sub
End Class