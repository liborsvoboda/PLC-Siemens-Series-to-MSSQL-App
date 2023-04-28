Imports System.IO

Module Functions_SQL
    Private dgw_table_schema As DataTable


    Public Function check_sql_server() As String
        'Dim sqlConnection_string As New System.Data.SqlClient.SqlConnection("Data Source=" + Me.txt_db_name.Text + ";Initial Catalog=" + Me.txt_db_name.Text + ";Persist Security Info=True;User ID=" + Me.txt_db_loginname.Text + ";Password=" + Me.txt_db_password.Text + "")
        'Dim cmd As New System.Data.SqlClient.SqlCommand(query, sqlConnection_string)
        fn_cursor_wait(True)
        Try
            Dim sqlConnection_string As New System.Data.SqlClient.SqlConnection("Data Source=" + frm_mainform.txt_serverSQL.Text + ";Initial Catalog=" + frm_mainform.txt_db_name.Text + ";Persist Security Info=True;User ID=" + frm_mainform.txt_db_loginname.Text + ";Password=" + frm_mainform.txt_db_password.Text + "")
            sqlConnection_string.Open()
            sqlConnection_string.Close()

            frm_mainform.result_cleaner = Date.Now.AddSeconds(5)
            check_sql_server = "Connect to MSSQL: OK"
        Catch ex As Exception
            frm_mainform.result_cleaner = Date.Now.AddSeconds(5)
            check_sql_server = "Connect to MSSQL:" + ex.Message
        Finally
            'My.MySettings.Default.Item("sql_connection") = "Data Source=" + frm_mainform.txt_serverSQL.Text + ";Initial Catalog=" + frm_mainform.txt_db_name.Text + ";Persist Security Info=True;User ID=" + frm_mainform.txt_db_loginname.Text + ";Password=" + frm_mainform.txt_db_password.Text + ""
            fn_cursor_wait(False)
        End Try
    End Function




    Public Function fn_sql_request(ByVal query As String, ByVal type As String) As Boolean
        fn_sql_request = False
        If frm_mainform.chb_sql_debbuger.Checked = True Then frm_mainform.txt_plc_dump.Text = vbNewLine + query + vbNewLine + frm_mainform.txt_plc_dump.Text

        Dim sqlConnection_string As New System.Data.SqlClient.SqlConnection("Data Source=" + frm_mainform.txt_serverSQL.Text + ";Initial Catalog=" + frm_mainform.txt_db_name.Text + ";Persist Security Info=True;User ID=" + frm_mainform.txt_db_loginname.Text + ";Password=" + frm_mainform.txt_db_password.Text + "")
        Dim cmd As New System.Data.SqlClient.SqlCommand(query, sqlConnection_string)
        cmd.CommandTimeout = frm_mainform.num_sql_timeout.Value

        Dim reader As System.Data.SqlClient.SqlDataReader



        Try

            query = "BEGIN TRANSACTION" + vbNewLine + "GO" + vbNewLine + query + vbNewLine + "COMMIT TRANSACTION"

            sqlConnection_string.Open()
            reader = cmd.ExecuteReader()
            dgw_table_schema = reader.GetSchemaTable()

            If type = "INSERT" And reader.RecordsAffected > 0 Then
                fn_sql_request = True
            End If

            If type = "UPDATE" And reader.RecordsAffected > 0 Then
                fn_sql_request = True
            End If

            If type = "SELECT" Then
                Dim count As Integer = 0

                While reader.Read()
                    count += 1
                End While

                reader.Close()
                reader = cmd.ExecuteReader()
                ReDim frm_mainform.sql_array(count.ToString, (reader.GetSchemaTable.Rows.Count - 1))

                count = 0
                If reader.HasRows = True Then fn_sql_request = True
                While reader.Read()
                    'MessageBox.Show((reader.GetInt32(0) & ", " & reader.GetString(1)))
                    'MessageBox.Show(reader.GetInt16(0))
                    'MsgBox(reader.GetString(1))
                    For row As Integer = 0 To (reader.GetSchemaTable.Rows.Count - 1) Step 1
                        frm_mainform.sql_array(count, row) = reader(row).ToString()
                    Next
                    count += 1
                End While
                frm_mainform.sql_array_count = count
            End If

            reader.Close()
            sqlConnection_string.Close()
        Catch ex As Exception
            frm_mainform.txt_plc_dump.Text = vbNewLine + "SQL_error" + ex.Message + vbNewLine + frm_mainform.txt_plc_dump.Text
        End Try
    End Function



End Module