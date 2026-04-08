Module ValidationModule
    Public Sub HanyaHuruf(e As KeyPressEventArgs)
        If Not (Char.IsLetter(e.KeyChar) Or e.KeyChar = ControlChars.Back Or e.KeyChar = " ") Then
            e.Handled = True
        End If
    End Sub

    Public Sub HanyaAngka(e As KeyPressEventArgs)
        If Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = ControlChars.Back) Then
            e.Handled = True
        End If
    End Sub
    Public Sub ValidasiTextBox(ep As ErrorProvider, txt As TextBox, pesan As String)
        If txt.Text.Trim() = "" Then
            ep.SetError(txt, pesan)
        Else
            ep.SetError(txt, "")
        End If
    End Sub

    Public Sub ValidasiMaskedTextBox(ep As ErrorProvider, mtxt As MaskedTextBox, pesan As String)
        If Not mtxt.MaskCompleted Then
            ep.SetError(mtxt, pesan)
        Else
            ep.SetError(mtxt, "")
        End If
    End Sub

    Public Sub ValidasiHobby(ep As ErrorProvider, gb As GroupBox, pesan As String)
        Dim hobiTerpilih As Boolean = False
        For Each ctrl As Control In gb.Controls
            If TypeOf ctrl Is CheckBox AndAlso DirectCast(ctrl, CheckBox).Checked Then
                hobiTerpilih = True
                Exit For
            End If
        Next

        If Not hobiTerpilih Then
            ep.SetError(gb, pesan)
        Else
            ep.SetError(gb, "")
        End If
    End Sub

End Module