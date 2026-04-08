Public Class Form1
    Dim ep As New ErrorProvider()

    Private Sub mnKeluar_Click(sender As Object, e As EventArgs) Handles mnKeluar.Click
        Dim hasil As DialogResult = MessageBox.Show("Apakah Anda yakin ingin keluar?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If hasil = DialogResult.Yes Then Me.Close()
    End Sub

    Private Sub mnInputData_Click(sender As Object, e As EventArgs) Handles mnInputData.Click
        TabControl1.SelectedTab = TabPage1
    End Sub
    Private Sub mnLihatKartu_Click(sender As Object, e As EventArgs) Handles mnLihatKartu.Click
        If ValidasiSemua() Then
            TransferDataKeModule()
            Form2.Show()
        Else
            MessageBox.Show("Mohon lengkapi data terlebih dahulu.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub
    Private Function AmbilFormatDataLengkap() As String
        Dim gender As String = If(rbLaki.Checked, "Laki-laki", "Perempuan")
        Dim peran As String = ""
        For Each ctrl As Control In gbPeran.Controls
            If TypeOf ctrl Is RadioButton AndAlso DirectCast(ctrl, RadioButton).Checked Then
                peran = ctrl.Text
                Exit For
            End If
        Next

        Dim daftarHobi As String = ""
        For Each ctrl As Control In gbHobby.Controls
            If TypeOf ctrl Is CheckBox AndAlso DirectCast(ctrl, CheckBox).Checked Then
                daftarHobi &= DirectCast(ctrl, CheckBox).Text & ", "
            End If
        Next
        daftarHobi = daftarHobi.TrimEnd(", ".ToCharArray())

        Return $"--- DATA ANGGOTA KOMUNITAS ---" & vbCrLf &
           $"Nama           : {txtNama.Text}" & vbCrLf &
           $"ID Anggota     : {txtIDAnggota.Text}" & vbCrLf &
           $"Tanggal Lahir  : {dtpTanggalLahir.Value.ToShortDateString()}" & vbCrLf &
           $"Jenis Kelamin  : {gender}" & vbCrLf &
           $"Komunitas      : {cmbKomunitas.Text}" & vbCrLf &
           $"No. Telepon    : {mtxtTelepon.Text}" & vbCrLf &
           $"Email          : {txtEmail.Text}" & vbCrLf &
           $"Alamat         : {txtAlamat.Text}" & vbCrLf &
           $"Peran          : {peran}" & vbCrLf &
           $"Hobi           : {daftarHobi}" & vbCrLf &
           $"Foto Path      : {DataModule.FotoPath}"
    End Function

    Private Sub mnSimpanData_Click(sender As Object, e As EventArgs) Handles mnSimpanData.Click
        If ValidasiSemua() Then
            SaveFileDialog1.Filter = "Text File *.txt|*.txt"
            SaveFileDialog1.Title = "Simpan Data Lengkap"

            If SaveFileDialog1.ShowDialog() = DialogResult.OK Then
                Dim dataLengkap As String = AmbilFormatDataLengkap()
                System.IO.File.WriteAllText(SaveFileDialog1.FileName, dataLengkap)
                MessageBox.Show("Seluruh data berhasil disimpan!", "Informasi")
            End If
        End If
    End Sub
    Private Sub mnBukaData_Click(sender As Object, e As EventArgs) Handles mnBukaData.Click
        OpenFileDialog1.Filter = "Text File *.txt|*.txt"
        OpenFileDialog1.Title = "Buka Data Anggota"

        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            Try
                Dim baris() As String = System.IO.File.ReadAllLines(OpenFileDialog1.FileName)

                For Each line As String In baris
                    Dim titikDuaPos As Integer = line.IndexOf(":")

                    If titikDuaPos > -1 Then
                        Dim key As String = line.Substring(0, titikDuaPos).Trim()
                        Dim val As String = line.Substring(titikDuaPos + 1).Trim()

                        Select Case key
                            Case "Nama" : txtNama.Text = val
                            Case "ID Anggota" : txtIDAnggota.Text = val
                            Case "Tanggal Lahir" : dtpTanggalLahir.Value = DateTime.Parse(val)
                            Case "Jenis Kelamin"
                                If val = "Laki-laki" Then rbLaki.Checked = True Else rbPerempuan.Checked = True
                            Case "Komunitas" : cmbKomunitas.Text = val
                            Case "No. Telepon" : mtxtTelepon.Text = val
                            Case "Email" : txtEmail.Text = val
                            Case "Alamat" : txtAlamat.Text = val
                            Case "Peran"
                                For Each rb As Control In gbPeran.Controls
                                    If TypeOf rb Is RadioButton AndAlso rb.Text = val Then
                                        DirectCast(rb, RadioButton).Checked = True
                                    End If
                                Next
                            Case "Hobi"
                                For Each cb As Control In gbHobby.Controls
                                    If TypeOf cb Is CheckBox Then
                                        DirectCast(cb, CheckBox).Checked = val.Contains(cb.Text)
                                    End If
                                Next
                            Case "Foto Path"
                                If val <> "" AndAlso System.IO.File.Exists(val) Then
                                    DataModule.FotoPath = val
                                    picProfile.Image = Image.FromFile(val)
                                    picProfile.SizeMode = PictureBoxSizeMode.StretchImage
                                End If
                        End Select
                    End If
                Next
                MessageBox.Show("Data dan Foto berhasil dimuat!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show("Gagal membaca file: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub txtNama_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNama.KeyPress
        HanyaHuruf(e)
    End Sub

    Private Sub txtIDAnggota_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtIDAnggota.KeyPress
        HanyaAngka(e)
    End Sub

    Private Function ValidasiSemua() As Boolean
        ErrorProvider1.Clear()

        ValidasiTextBox(ErrorProvider1, txtNama, "Inputan tidak boleh kosong")
        ValidasiTextBox(ErrorProvider1, txtIDAnggota, "Inputan tidak boleh kosong")
        ValidasiMaskedTextBox(ErrorProvider1, mtxtTelepon, "Format telepon tidak lengkap")
        ValidasiTextBox(ErrorProvider1, txtEmail, "Inputan tidak boleh kosong")
        ValidasiTextBox(ErrorProvider1, txtAlamat, "Inputan tidak boleh kosong")

        ValidasiHobby(ErrorProvider1, gbHobby, "Inputan tidak boleh kosong (pilih minimal satu)")

        If ErrorProvider1.GetError(txtNama) = "" And
           ErrorProvider1.GetError(txtIDAnggota) = "" And
           ErrorProvider1.GetError(mtxtTelepon) = "" And
           ErrorProvider1.GetError(gbHobby) = "" Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        OpenFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png"
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            DataModule.FotoPath = OpenFileDialog1.FileName
            picProfile.Image = Image.FromFile(DataModule.FotoPath)
            picProfile.SizeMode = PictureBoxSizeMode.StretchImage
        End If
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        mnSimpanData_Click(sender, e)
    End Sub
    Private Sub TransferDataKeModule()
        DataModule.Nama = txtNama.Text
        DataModule.IDAnggota = txtIDAnggota.Text
        DataModule.Komunitas = cmbKomunitas.Text
        DataModule.NoTelp = mtxtTelepon.Text
        DataModule.Email = txtEmail.Text
        DataModule.Alamat = txtAlamat.Text

        For Each rb As Control In gbPeran.Controls
            If TypeOf rb Is RadioButton AndAlso DirectCast(rb, RadioButton).Checked Then
                DataModule.Peran = rb.Text
                Exit For
            End If
        Next

        DataModule.Hobi = ""
        For Each cb As Control In gbHobby.Controls
            If TypeOf cb Is CheckBox AndAlso DirectCast(cb, CheckBox).Checked Then
                DataModule.Hobi &= DirectCast(cb, CheckBox).Text & ", "
            End If
        Next

    End Sub

    Private Sub btnCetak_Click(sender As Object, e As EventArgs) Handles btnCetak.Click
        mnLihatKartu_Click(sender, e)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

End Class