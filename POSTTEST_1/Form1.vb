Public Class Form1
    Dim ips As Double
    Dim ipk As Double
    Dim totalIPS As Double
    Dim jumlahSemester As Integer
    Private Sub txtInput_TextChanged(sender As Object, e As EventArgs) Handles txtInput.TextChanged

    End Sub

    Private Sub lblips_Click(sender As Object, e As EventArgs) Handles lblips.Click

    End Sub

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        If Double.TryParse(txtInput.Text, ips) Then
            If ips >= 0 And ips <= 4 Then
                totalIPS += ips
                jumlahSemester += 1
                ipk = totalIPS / jumlahSemester

                txtIPK.Text = ipk.ToString("0.00")

                If ipk >= 3.01 Then
                    lblHasil.Text = "Sangat Memuaskan"
                ElseIf ipk >= 2.76 And ipk <= 3.0 Then
                    lblHasil.Text = "Memuaskan"
                ElseIf ipk >= 2.0 And ipk <= 2.75 Then
                    lblHasil.Text = "Cukup"
                Else
                    lblHasil.Text = "Kurang"
                End If
            Else
                MessageBox.Show("IPS harus 0 sampe 4")
            End If
        Else
            MessageBox.Show("Inputan harus angka")
        End If

    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        lblHasil.Text = ""
        txtInput.Clear()
        txtIPK.Clear()
        totalIPS = 0
        jumlahSemester = 0
    End Sub

    Private Sub txtIPK_TextChanged(sender As Object, e As EventArgs) Handles txtIPK.TextChanged

    End Sub

    Private Sub lblipk_Click(sender As Object, e As EventArgs) Handles lblipk.Click

    End Sub

    Private Sub lblHasil_Click(sender As Object, e As EventArgs) Handles lblHasil.Click

    End Sub
End Class
