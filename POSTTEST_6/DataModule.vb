Imports MySqlConnector
Module DataModule
    Public Function GetAllBuah() As DataTable
        Dim dt As New DataTable()
        Using conn = GetConnection()
            Dim query As String = "SELECT buah.id_buah, tbsupplier.nama_supplier AS 'Supplier', " &
                             "buah.nama_buah, buah.harga, buah.stok " &
                             "FROM buah " &
                             "INNER JOIN tbsupplier ON buah.id_supplier = tbsupplier.id_supplier " &
                             "ORDER BY buah.id_buah ASC"
            Dim da As New MySqlDataAdapter(query, conn)
            da.Fill(dt)
        End Using
        Return dt
    End Function

    Public Function GetAllSupplier() As DataTable
        Dim dt As New DataTable()
        Using conn = GetConnection()
            Dim da As New MySqlDataAdapter("SELECT * FROM tbsupplier ORDER BY nama_supplier ASC", conn)
            da.Fill(dt)
        End Using
        Return dt
    End Function

    Public Function SearchBuah(keyword As String) As DataTable
        Dim dt As New DataTable()
        Dim query As String = "SELECT * FROM buah WHERE nama_buah LIKE @key OR id_buah LIKE @key"
        Using conn = GetConnection()
            Using da As New MySqlDataAdapter(query, conn)
                da.SelectCommand.Parameters.AddWithValue("@key", "%" & keyword & "%")
                da.Fill(dt)
            End Using
        End Using
        Return dt
    End Function
    Public Function SimpanBuah(id As String, idSup As String, nama As String, harga As Integer, stok As Integer) As Boolean
        Try
            Using conn = GetConnection()
                conn.Open()
                Dim query As String = "INSERT INTO buah (id_buah, id_supplier, nama_buah, harga, stok) VALUES (@id, @idSup, @nama, @harga, @stok)"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@id", id)
                    cmd.Parameters.AddWithValue("@idSup", idSup)
                    cmd.Parameters.AddWithValue("@nama", nama)
                    cmd.Parameters.AddWithValue("@harga", harga)
                    cmd.Parameters.AddWithValue("@stok", stok)
                    Return cmd.ExecuteNonQuery() > 0
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal menyimpan: " & ex.Message)
            Return False
        End Try
    End Function

    Public Function UbahBuah(id As String, nama As String, harga As Integer, stok As Integer) As Boolean
        Try
            Using conn = GetConnection()
                conn.Open()
                Dim query As String = "UPDATE buah SET nama_buah=@nama, harga=@harga, stok=@stok WHERE id_buah=@id"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@id", id)
                    cmd.Parameters.AddWithValue("@nama", nama)
                    cmd.Parameters.AddWithValue("@harga", harga)
                    cmd.Parameters.AddWithValue("@stok", stok)
                    Return cmd.ExecuteNonQuery() > 0
                End Using
            End Using
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Function HapusBuah(id As String) As Boolean
        Try
            Using conn = GetConnection()
                conn.Open()
                Dim query As String = "DELETE FROM buah WHERE id_buah=@id"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@id", id)
                    Return cmd.ExecuteNonQuery() > 0
                End Using
            End Using
        Catch ex As Exception
            Return False
        End Try
    End Function
End Module