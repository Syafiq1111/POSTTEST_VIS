Public Class Form1

    Private Sub PerbaruiTabel(ByVal dgv As DataGridView)
        dgv.Rows.Clear()
        For i As Integer = 0 To jumlahBuku - 1
            dgv.Rows.Add(daftarBuku(i, 0), daftarBuku(i, 1))
        Next
    End Sub

    Private Function CariJudulBuku(ByVal judulDicari As String) As Integer
        For i As Integer = 0 To jumlahBuku - 1
            If daftarBuku(i, 0).ToLower() = judulDicari.ToLower() Then
                Return i
            End If
        Next
        Return -1
    End Function

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        If txtJudul.Text <> "" And txtGenre.Text <> "" Then
            If jumlahBuku < 100 Then

                daftarBuku(jumlahBuku, 0) = txtJudul.Text
                daftarBuku(jumlahBuku, 1) = txtGenre.Text
                jumlahBuku += 1

                txtJudul.Clear()
                txtGenre.Clear()

                PerbaruiTabel(dgvList)

                MessageBox.Show("Buku berhasil ditambahkan.")
            Else
                MessageBox.Show("Kapasitas penyimpanan buku sudah penuh.")
            End If
        Else
            MessageBox.Show("Silakan isi judul dan genre buku terlebih dahulu.")
        End If
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        Dim indexHapus As Integer = CariJudulBuku(txthpsJudul.Text)

        If indexHapus <> -1 Then
            For i As Integer = indexHapus To jumlahBuku - 2
                daftarBuku(i, 0) = daftarBuku(i + 1, 0)
                daftarBuku(i, 1) = daftarBuku(i + 1, 1)
            Next
            jumlahBuku -= 1
            txthpsJudul.Clear()
            PerbaruiTabel(dgvList)
            MessageBox.Show("Data buku berhasil dihapus.")
        Else
            MessageBox.Show("Buku yang dicari tidak ditemukan.")
        End If
    End Sub
End Class
