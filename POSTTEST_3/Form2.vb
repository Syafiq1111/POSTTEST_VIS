Public Class FormHasil
    Private Sub FormHasil_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblNamaHasil.Text = DataModule.Nama
        lblUmurHasil.Text = DataModule.Umur
        lblTelpHasil.Text = DataModule.Telpon
        lblAlamatHasil.Text = DataModule.Alamat
        lblJKHasil.Text = DataModule.JK
        lblHobiHasil.Text = DataModule.Hobi
        lblTglLahirHasil.Text = DataModule.Tglahir.ToString("dd MMMM yyyy")


        If Not String.IsNullOrEmpty(DataModule.Foto) Then
            picHasil.Image = Image.FromFile(DataModule.Foto)
            picHasil.SizeMode = PictureBoxSizeMode.Zoom
        End If
    End Sub

End Class