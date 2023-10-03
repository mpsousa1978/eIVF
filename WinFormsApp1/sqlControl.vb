Imports MySql.Data.MySqlClient

Public Class SqlControl
    Dim conn As MySqlConnection
    Dim cmd As MySqlCommand
    Dim reader As MySqlDataReader


    Private ConnString As String = "Server=localhost;Port=3306;Database=datamp;User ID=root;Password=marcio;"

    Public Function CheckConnection() As Boolean
        Try
            conn = New MySqlConnection
            conn.ConnectionString = ConnString
            conn.Open()
            conn.Close()
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            LogError.LogError(ex.Message)
            Return False
        End Try
    End Function


    Public Function ExecuteQuery(Query As String) As DataTable
        Dim dataTable As New DataTable()

        conn = New MySqlConnection
        conn.ConnectionString = ConnString
        Try
            conn.Open()

            cmd = New MySqlCommand(Query, conn)
            reader = cmd.ExecuteReader()

            dataTable.Load(reader)

            reader.Close()
            conn.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
            LogError.LogError(ex.Message)
        End Try

        Return dataTable
    End Function

    Public Sub InsertRecord(description As String, idType As Integer, amount As Integer, price As Double, status As Integer)
        Try
            conn = New MySqlConnection
            conn.ConnectionString = ConnString
            conn.Open()

            Dim query As String = "INSERT INTO mp_productr (description,idType, amount, price, status,created_at) VALUES (@Description,@IdType, @Amount, @Price, @Status,@Created_at)"
            cmd = New MySqlCommand(query, conn)


            cmd.Parameters.AddWithValue("@Description", description)
            cmd.Parameters.AddWithValue("@IdType", idType)
            cmd.Parameters.AddWithValue("@Amount", amount)
            cmd.Parameters.AddWithValue("@Price", price)
            cmd.Parameters.AddWithValue("@Status", status)
            cmd.Parameters.AddWithValue("@Created_at", Now())


            cmd.ExecuteNonQuery()

            conn.Close()
            MsgBox("Record inserted successfully!")
        Catch ex As Exception
            MsgBox(ex.Message)
            LogError.LogError(ex.Message)
        End Try
    End Sub

End Class

