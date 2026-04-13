Public Class Form1
    Public Sub TampilDataUtama()
        dgvTampilanUtama.DataSource = GetAllBuah()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TampilDataUtama()
    End Sub

    Private Sub txtSearchUtama_TextChanged(sender As Object, e As EventArgs) Handles txtSearchUtama.TextChanged
        If txtSearchUtama.Text.Trim() <> "" Then
            dgvTampilanUtama.DataSource = SearchBuah(txtSearchUtama.Text.Trim())
        Else
            TampilDataUtama()
        End If
    End Sub

    Private Sub MenuKelolaBuah_Click(sender As Object, e As EventArgs) Handles MenuKelolaBuah.Click
        FormBuah.ShowDialog()
        TampilDataUtama()
    End Sub

    Private Sub MenuKeluar_Click(sender As Object, e As EventArgs) Handles MenuKeluar.Click
        If MessageBox.Show("Keluar aplikasi?", "Konfirmasi", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub
End Class