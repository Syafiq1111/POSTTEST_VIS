Public Class FormBuah

    Private Sub Kosong()
        txtID.Clear()
        txtNama.Clear()
        txtHarga.Clear()
        txtStok.Clear()
        txtSearch.Clear()
        ErrorProvider1.Clear()
        txtID.Focus()
    End Sub

    Private Sub TampilData()
        dgvBuah.DataSource = GetAllBuah()
    End Sub

    Private Sub FormBuah_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbSupplier.DataSource = GetAllSupplier()
        cbSupplier.DisplayMember = "nama_supplier"
        cbSupplier.ValueMember = "id_supplier"

        TampilData()
        Kosong()
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        If txtID.Text = "" Or txtNama.Text = "" Or cbSupplier.SelectedIndex = -1 Then
            MessageBox.Show("Semua data termasuk Supplier harus diisi!")
            Exit Sub
        End If

        Dim idSup As String = cbSupplier.SelectedValue.ToString()

        If SimpanBuah(txtID.Text, idSup, txtNama.Text, Val(txtHarga.Text), Val(txtStok.Text)) Then
            MessageBox.Show("Data buah berhasil disimpan", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            TampilData()
            Kosong()
        End If
    End Sub

    Private Sub btnUbah_Click(sender As Object, e As EventArgs) Handles btnUbah.Click
        If UbahBuah(txtID.Text, txtNama.Text, Val(txtHarga.Text), Val(txtStok.Text)) Then
            MessageBox.Show("Data berhasil diubah", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            TampilData()
            Kosong()
        Else
            MessageBox.Show("Gagal mengubah data!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        If txtID.Text = "" Then
            MessageBox.Show("Pilih data yang akan dihapus!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim konfirmasi As DialogResult = MessageBox.Show("Apakah data '" & txtNama.Text & "' ingin dihapus?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If konfirmasi = DialogResult.Yes Then
            If HapusBuah(txtID.Text.Trim()) Then
                MessageBox.Show("Data berhasil dihapus", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
                TampilData()
                Kosong()
            End If
        End If
    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        Kosong()
    End Sub

    Private Sub dgvBuah_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvBuah.CellClick
        If e.RowIndex >= 0 Then
            txtID.Text = dgvBuah.Rows(e.RowIndex).Cells(0).Value.ToString()
            cbSupplier.Text = dgvBuah.Rows(e.RowIndex).Cells(1).Value.ToString() ' Menampilkan nama supplier [cite: 453]
            txtNama.Text = dgvBuah.Rows(e.RowIndex).Cells(2).Value.ToString()
            txtHarga.Text = dgvBuah.Rows(e.RowIndex).Cells(3).Value.ToString()
            txtStok.Text = dgvBuah.Rows(e.RowIndex).Cells(4).Value.ToString()
        End If
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        If txtSearch.Text.Trim() <> "" Then
            dgvBuah.DataSource = SearchBuah(txtSearch.Text.Trim())
        Else
            TampilData()
        End If
    End Sub

    Private Sub txtHarga_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtHarga.KeyPress, txtStok.KeyPress
        HanyaAngka(e)
    End Sub
    Private Sub btnKembali_Click(sender As Object, e As EventArgs) Handles btnKembali.Click
        Me.Close()
    End Sub
End Class