Imports System.IO
Imports System.Text
Imports MySql.Data.MySqlClient
Public Class Form1

    Dim sqlCtrl As New SqlControl()

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If sqlCtrl.CheckConnection Then
            loadType(ComboBox1)
            loadType(ComboBox2)
            loadProduct()
            ProgressBar1.Visible = False
        End If



    End Sub

    Sub loadProduct()
        Try
            Dim query As String = "select p.idproduct,p.description,t.description type,p.amount,p.price,created_at
                                    from mp_product p
                                        inner join mp_type t on p.idtype=t.idtype
                                    "
            If ComboBox1.SelectedIndex > 0 Then
                Dim selectedValue As Integer = DirectCast(ComboBox1.SelectedItem, DataRowView)("idtype")
                query &= "WHERE t.idtype = " & selectedValue
            End If


            Dim resultTable As DataTable = sqlCtrl.ExecuteQuery(query)
            If resultTable IsNot Nothing AndAlso resultTable.Rows.Count > 0 Then
                DataGridView1.DataSource = resultTable
            Else
                MessageBox.Show("No data")
            End If

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
            LogError.LogError(ex.Message)
        End Try
    End Sub
    Sub loadType(cmb As ComboBox)
        Try
            Dim query As String = "SELECT description, idtype FROM mp_type order by description"
            Dim resultTable As DataTable = sqlCtrl.ExecuteQuery(query)

            If resultTable IsNot Nothing AndAlso resultTable.Rows.Count > 0 Then
                Dim selectRow As DataRow = resultTable.NewRow()
                selectRow("description") = "Select"
                selectRow("idtype") = 0
                resultTable.Rows.InsertAt(selectRow, 0)

                cmb.DataSource = resultTable
                cmb.DisplayMember = "description"
                cmb.ValueMember = "idtype"
                cmb.SelectedIndex = 0

            Else
                MessageBox.Show("No data")
            End If
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
            LogError.LogError(ex.Message)
        End Try
    End Sub


    Private Sub ComboBox1_SelectedValueChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedValueChanged
        loadProduct()
    End Sub



    Private Sub btnInsert_Click(sender As Object, e As EventArgs) Handles btnInsert.Click
        If ComboBox2.SelectedIndex = 0 Then
            MsgBox("Select type")
            txtPrice.Focus()
            Return
        ElseIf txtDescription.Text = "" Then
            MsgBox("Description could not empty")
            txtDescription.Focus()
            Return
        ElseIf txtAmount.Text = "" Then
            MsgBox("Amount could not empty")
            txtAmount.Focus()
            Return
        ElseIf txtPrice.Text = "" Then
            MsgBox("Price could not empty")
            txtPrice.Focus()
            Return
        End If
        Dim selectedValue As Integer = DirectCast(ComboBox2.SelectedItem, DataRowView)("idtype")

        sqlCtrl.InsertRecord(txtDescription.Text, selectedValue, txtAmount.Text, txtPrice.Text, 1)
        loadProduct()
        clear()

    End Sub

    Private Sub txtAmount_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAmount.KeyPress
        If Not IsNumeric(e.KeyChar) And Asc(e.KeyChar) <> 8 Then
            e.Handled = True
        End If
    End Sub


    Private Sub txtPrice_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPrice.KeyPress
        If Not IsNumeric(e.KeyChar) And Asc(e.KeyChar) <> 8 Then
            e.Handled = True
        End If
    End Sub

    Sub clear()
        ComboBox2.SelectedIndex = 0
        txtDescription.Text = ""
        txtAmount.Text = ""
        txtPrice.Text = ""
    End Sub

    Private Sub btnExport_Click(sender As Object, e As EventArgs) Handles btnExport.Click
        ProgressBar1.Visible = True
        ExportToCSV(DataGridView1, ProgressBar1)

    End Sub


    Sub ExportToCSV(dataGridView As DataGridView, progressBar As ProgressBar)
        Try
            Dim saveFileDialog As New SaveFileDialog()
            saveFileDialog.Filter = "Arquivos CSV (*.csv)|*.csv"
            saveFileDialog.Title = "Salvar Arquivo CSV"

            If saveFileDialog.ShowDialog() = DialogResult.OK Then
                Dim filePath As String = saveFileDialog.FileName

                Dim sb As New StringBuilder()

                For Each column As DataGridViewColumn In dataGridView.Columns
                    sb.Append(column.HeaderText & ",")
                Next

                sb.AppendLine()
                Dim totalRecords As Integer = dataGridView.Rows.Count
                Dim recordsProcessed As Integer = 0
                progressBar.Minimum = 0
                progressBar.Maximum = totalRecords
                progressBar.Value = 0

                For Each row As DataGridViewRow In dataGridView.Rows
                    For Each cell As DataGridViewCell In row.Cells
                        sb.Append(cell.Value.ToString() & ",")
                    Next
                    sb.AppendLine()

                    recordsProcessed += 1
                    progressBar.Value = recordsProcessed
                Next

                ' Escreve o conteúdo no arquivo CSV
                File.WriteAllText(filePath, sb.ToString())

                MessageBox.Show("Data exported to CSV file successfully!")
            End If
        Catch ex As Exception
            MessageBox.Show("Error export to CSV: " & ex.Message)
            LogError.LogError(ex.Message)
        Finally
            ' Certifique-se de que a ProgressBar seja redefinida mesmo em caso de erro
            progressBar.Value = progressBar.Minimum
        End Try
        ProgressBar1.Visible = False

    End Sub



End Class
