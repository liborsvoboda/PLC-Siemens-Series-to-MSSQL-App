Module functions
    Private string_temp
    Friend data_error_count As Integer = 0

    Function fn_create_directory(ByVal directory As String)

        If Not System.IO.Directory.Exists(directory) Then
            System.IO.Directory.CreateDirectory(directory)
        End If
    End Function


    Function fn_delete_directory(ByVal directory As String)
        If System.IO.Directory.Exists(directory) Then System.IO.Directory.Delete(directory, True)
    End Function

    Function fn_check_directory(ByVal directory As String) As Boolean
        fn_check_directory = System.IO.Directory.Exists(directory)
    End Function

    Function fn_check_file(ByVal file As String) As Boolean
        fn_check_file = System.IO.File.Exists(file)
    End Function



    Function fn_create_file(ByVal file As String) As Boolean
        If Not System.IO.File.Exists(file) Then
            System.IO.File.Create(file).Close()
        End If

        If fn_check_file(file) = True Then
            fn_create_file = True
        Else
            fn_create_file = False
        End If

    End Function

    Function fn_file_startup_check()
        If fn_check_directory(frm_mainform.setting_folder) = False Then fn_create_directory(frm_mainform.setting_folder)
        If fn_check_file(System.IO.Path.Combine(frm_mainform.setting_folder, frm_mainform.configuration_file)) = False Then
            fn_copy_file(System.IO.Path.Combine(Application.StartupPath, frm_mainform.configuration_file), System.IO.Path.Combine(frm_mainform.setting_folder, frm_mainform.configuration_file))
        End If
        If fn_check_file(System.IO.Path.Combine(frm_mainform.setting_folder, frm_mainform.data_file)) = False Then
            fn_copy_file(System.IO.Path.Combine(Application.StartupPath, frm_mainform.data_file), System.IO.Path.Combine(frm_mainform.setting_folder, frm_mainform.data_file))
        End If
    End Function

    Function fn_delete_file(ByVal file As String) As Boolean
        System.IO.File.Delete(file)

        If fn_check_file(file) = False Then
            fn_delete_file = True
        Else
            fn_delete_file = False
        End If
    End Function


    Function fn_copy_file(ByVal file As String, ByVal file1 As String) As Boolean
        fn_copy_file = False
        System.IO.File.Copy(file, file1)
        If fn_check_file(file1) = True Then fn_copy_file = True
    End Function


    Function fn_detect_file_encoding(ByVal FileName As String) As System.Text.Encoding
        Dim enc As String = ""
        If System.IO.File.Exists(FileName) Then
            Dim filein As New System.IO.FileStream(FileName, IO.FileMode.Open, IO.FileAccess.Read)
            If (filein.CanSeek) Then
                Dim bom(4) As Byte
                filein.Read(bom, 0, 4)
                'EF BB BF       = utf-8
                'FF FE          = ucs-2le, ucs-4le, and ucs-16le
                'FE FF          = utf-16 and ucs-2
                '00 00 FE FF    = ucs-4
                If (((bom(0) = &HEF) And (bom(1) = &HBB) And (bom(2) = &HBF)) Or _
                    ((bom(0) = &HFF) And (bom(1) = &HFE)) Or _
                    ((bom(0) = &HFE) And (bom(1) = &HFF)) Or _
                    ((bom(0) = &H0) And (bom(1) = &H0) And (bom(2) = &HFE) And (bom(3) = &HFF))) Then
                    enc = "Unicode"
                Else
                    enc = "ASCII"
                End If
                'Position the file cursor back to the start of the file
                filein.Seek(0, System.IO.SeekOrigin.Begin)
                ' Do more stuff
            End If
            filein.Close()
        End If
        If enc = "Unicode" Then
            Return System.Text.Encoding.UTF8
        Else
            Return System.Text.Encoding.Default
        End If
    End Function



    Function fn_check_data_format(ByRef row_index As Integer, ByVal selected As String)
        Try
            If selected = "all" Then data_error_count = 0

            For Each row As DataGridViewRow In frm_mainform.dgw_field_definitions.Rows

                If selected = "all" Or (selected = "one" And row.Index = row_index) Then
                    If Not frm_mainform.dgw_field_definitions.Rows(row.Index).IsNewRow = True Then
                        For Each cell As DataGridViewCell In frm_mainform.dgw_field_definitions.Rows(row.Index).Cells
                            If cell.ColumnIndex = 0 Then
                                If Not IsNumeric(cell.Value) Then
                                    If cell.Style.BackColor <> Color.Red Then data_error_count += 1
                                    cell.Style.BackColor = Color.Red
                                Else
                                    If cell.Style.BackColor = Color.Red Then data_error_count -= 1
                                    cell.Style.BackColor = Color.White
                                End If
                            ElseIf cell.ColumnIndex = 1 Then
                                If cell.Value Is Nothing Then
                                    If cell.Style.BackColor <> Color.Red Then data_error_count += 1
                                    cell.Style.BackColor = Color.Red
                                Else
                                    If cell.Style.BackColor = Color.Red Then data_error_count -= 1
                                    cell.Style.BackColor = Color.White
                                End If
                            ElseIf cell.ColumnIndex >= 2 And cell.ColumnIndex <= 3 Then
                                If Not IsNumeric(cell.Value) Then
                                    If cell.Style.BackColor <> Color.Red Then data_error_count += 1
                                    cell.Style.BackColor = Color.Red
                                Else
                                    If cell.Style.BackColor = Color.Red Then data_error_count -= 1
                                    cell.Style.BackColor = Color.White
                                End If
                            ElseIf cell.ColumnIndex >= 4 And cell.ColumnIndex <= 7 Then
                                If cell.Value Is Nothing Then
                                    If cell.Style.BackColor <> Color.Red Then data_error_count += 1
                                    cell.Style.BackColor = Color.Red
                                Else
                                    If cell.Style.BackColor = Color.Red Then data_error_count -= 1
                                    cell.Style.BackColor = Color.White
                                End If
                            End If
                        Next
                    End If
                End If
            Next
        Catch ex As Exception
            Return ex.Message
        End Try
    End Function


    Function fn_load_setting() As String
        If fn_check_file(System.IO.Path.Combine(frm_mainform.setting_folder, frm_mainform.configuration_file)) = False Then
            frm_mainform.tc_tabpages.SelectedIndex = 1
            Return "Konfigurační soubor neexistuje, Proveďte konfiguraci"
        Else
            Dim objReader As New System.IO.StreamReader(System.IO.Path.Combine(frm_mainform.setting_folder, frm_mainform.configuration_file), fn_detect_file_encoding(System.IO.Path.Combine(frm_mainform.setting_folder, frm_mainform.configuration_file)))
            string_temp = objReader.ReadLine()
            Dim parts() As String
            Do While Not (string_temp Is Nothing)
                Try
                    parts = string_temp.Split("|")
                    If parts(0).StartsWith("txt_") Then
                        If parts(0) = "txt_db_password" Then
                            CType(frm_mainform.Controls.Find(parts(0), True).FirstOrDefault(), TextBox).Text = System.Text.Encoding.UTF8.GetString(System.Convert.FromBase64String(parts(1)))
                        Else
                            CType(frm_mainform.Controls.Find(parts(0), True).FirstOrDefault(), TextBox).Text = parts(1)
                        End If
                    ElseIf parts(0).StartsWith("num_") Then
                        CType(frm_mainform.Controls.Find(parts(0), True).FirstOrDefault(), NumericUpDown).Value = parts(1)
                    ElseIf parts(0).StartsWith("chb_") Then
                        CType(frm_mainform.Controls.Find(parts(0), True).FirstOrDefault(), CheckBox).Checked = parts(1)
                    ElseIf parts(0).StartsWith("dt_") Then
                        CType(frm_mainform.Controls.Find(parts(0), True).FirstOrDefault(), DateTimePicker).Value = parts(1)
                    Else
                    End If
                    string_temp = objReader.ReadLine()
                Catch ex As Exception
                    string_temp = objReader.ReadLine()
                End Try
            Loop
            objReader.Close()
        End If
    End Function


    Function fn_load_data_setting() As String
        frm_mainform.dgw_field_definitions.Rows.Clear()
        If fn_check_file(System.IO.Path.Combine(frm_mainform.setting_folder, frm_mainform.data_file)) = False Then
            frm_mainform.tc_tabpages.SelectedIndex = 1
            Return "Nastavení přenosu dat z PLC neexistuje, Proveďte konfiguraci"
        Else
            Dim objReader As New System.IO.StreamReader(System.IO.Path.Combine(frm_mainform.setting_folder, frm_mainform.data_file), fn_detect_file_encoding(System.IO.Path.Combine(frm_mainform.setting_folder, frm_mainform.data_file)))
            string_temp = objReader.ReadLine()
            Dim parts() As String
            Dim new_row As DataGridViewRow

            Do While Not (string_temp Is Nothing)
                Try
                    parts = string_temp.Split("|")
                    frm_mainform.dgw_field_definitions.Rows.Add(New Object() {parts(0), parts(1), parts(2), parts(3), parts(4), parts(5), parts(6), parts(7), parts(8)})

                    string_temp = objReader.ReadLine()
                Catch ex As Exception
                    string_temp = objReader.ReadLine()
                End Try
            Loop
            objReader.Close()
        End If
    End Function


    Function fn_save_data_setting() As String
        Try
            Dim data_content As String = Nothing
            fn_delete_file(System.IO.Path.Combine(frm_mainform.setting_folder, frm_mainform.data_file))
            fn_create_file(System.IO.Path.Combine(frm_mainform.setting_folder, frm_mainform.data_file))

            For Each row As DataGridViewRow In frm_mainform.dgw_field_definitions.Rows
                If Not frm_mainform.dgw_field_definitions.Rows(row.Index).IsNewRow = True Then
                    For i = 0 To 8
                        If Not row.Cells.Item(i).Value Is Nothing Then
                            data_content += row.Cells.Item(i).Value.ToString
                        End If
                        If i < 8 Then data_content += "|"
                    Next
                    data_content += vbNewLine
                End If
            Next

            Dim objWriter As New System.IO.StreamWriter(System.IO.Path.Combine(frm_mainform.setting_folder, frm_mainform.data_file), True)
            objWriter.Write(data_content)
            objWriter.Close()
            Return "nastavení dat bylo úspěšně uloženo"
        Catch ex As Exception
            Return ex.Message
        End Try
    End Function


    Function fn_save_file_setting() As String
        Try
            fn_delete_file(System.IO.Path.Combine(frm_mainform.setting_folder, frm_mainform.configuration_file))
            fn_create_file(System.IO.Path.Combine(frm_mainform.setting_folder, frm_mainform.configuration_file))
            Dim objWriter As New System.IO.StreamWriter(System.IO.Path.Combine(frm_mainform.setting_folder, frm_mainform.configuration_file), True)
            objWriter.WriteLine("txt_plc_IP1|" + frm_mainform.txt_plc_IP1.Text)
            objWriter.WriteLine("num_rack1|" + frm_mainform.num_rack1.Value.ToString)
            objWriter.WriteLine("num_slot1|" + frm_mainform.num_slot1.Value.ToString)
            objWriter.WriteLine("txt_plc_IP2|" + frm_mainform.txt_plc_IP2.Text)
            objWriter.WriteLine("num_rack2|" + frm_mainform.num_rack2.Value.ToString)
            objWriter.WriteLine("num_slot2|" + frm_mainform.num_slot2.Value.ToString)
            objWriter.WriteLine("txt_serverSQL|" + frm_mainform.txt_serverSQL.Text)
            objWriter.WriteLine("txt_db_name|" + frm_mainform.txt_db_name.Text)
            objWriter.WriteLine("txt_db_loginname|" + frm_mainform.txt_db_loginname.Text)
            objWriter.WriteLine("txt_db_password|" + System.Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(frm_mainform.txt_db_password.Text)))
            objWriter.WriteLine("num_sql_timeout|" + frm_mainform.num_sql_timeout.Value.ToString)
            objWriter.WriteLine("num_status_time_settings|" + frm_mainform.num_status_time_settings.Value.ToString)
            objWriter.WriteLine("num_fault_time_settings|" + frm_mainform.num_fault_time_settings.Value.ToString)
            objWriter.WriteLine("num_plc1_status_db|" + frm_mainform.num_plc1_status_db.Value.ToString)
            objWriter.WriteLine("num_plc1_fault_db|" + frm_mainform.num_plc1_fault_db.Value.ToString)
            objWriter.WriteLine("num_plc2_status_db|" + frm_mainform.num_plc2_status_db.Value.ToString)
            objWriter.WriteLine("num_plc2_fault_db|" + frm_mainform.num_plc2_fault_db.Value.ToString)
            objWriter.WriteLine("num_plc1_status_db_size|" + frm_mainform.num_plc1_status_db_size.Value.ToString)
            objWriter.WriteLine("num_plc2_status_db_size|" + frm_mainform.num_plc2_status_db_size.Value.ToString)
            objWriter.WriteLine("num_plc1_fault_db_size|" + frm_mainform.num_plc1_fault_db_size.Value.ToString)
            objWriter.WriteLine("num_plc2_fault_db_size|" + frm_mainform.num_plc2_fault_db_size.Value.ToString)
            objWriter.WriteLine("chb_enable_schleduler|" + frm_mainform.chb_enable_schleduler.Checked.ToString)
            objWriter.WriteLine("dt_monitor_start_time|" + frm_mainform.dt_monitor_start_time.Value.ToString)
            objWriter.WriteLine("dt_monitor_stop_time|" + frm_mainform.dt_monitor_stop_time.Value.ToString)
            objWriter.WriteLine("chb_status_communication_autorun|" + frm_mainform.chb_status_communication_autorun.Checked.ToString)
            objWriter.WriteLine("chb_fault_communication_autostart|" + frm_mainform.chb_fault_communication_autostart.Checked.ToString)

            objWriter.Close()
        Catch ex As Exception
            Return ex.Message
        End Try
    End Function



    Function fn_cursor_wait(ByVal status As Boolean)
        If status = True Then
            frm_mainform.Cursor = Cursors.WaitCursor
        Else
            frm_mainform.Cursor = Cursors.Default
        End If

    End Function



    Function fn_load_data_from_plc(ByRef selected_client As Integer) As Integer
        Dim Buffer(65536) As Byte ' Buffer  
        Dim size As Integer
        Dim c, y As Integer
        Dim s As String
        Dim loaded_plc_data As String = ""

        Select Case selected_client
            Case Is = 1
                size = frm_mainform.num_plc1_status_db_size.Value
                fn_load_data_from_plc = frm_mainform.plc1_status_client.DBRead(frm_mainform.num_plc1_status_db.Value, 0, size, Buffer)
                loaded_plc_data = "plc1_status:" + frm_mainform.plc1_status_client.ErrorText(fn_load_data_from_plc) + vbNewLine
                If frm_mainform.plc1_status_client.Connected And Not frm_mainform.plc1_status_field_list(0, 0) = Nothing Then fn_prepare_data_arrays_and_sql_send(1, "status", Buffer)
            Case Is = 2
                size = frm_mainform.num_plc2_status_db_size.Value
                fn_load_data_from_plc = frm_mainform.plc2_status_client.DBRead(frm_mainform.num_plc2_status_db.Value, 0, size, Buffer)
                loaded_plc_data = "plc2_status:" + frm_mainform.plc2_status_client.ErrorText(fn_load_data_from_plc) + vbNewLine
                If frm_mainform.plc2_status_client.Connected And Not frm_mainform.plc2_status_field_list(0, 0) = Nothing Then fn_prepare_data_arrays_and_sql_send(2, "status", Buffer)
            Case Is = 3
                size = frm_mainform.num_plc1_fault_db_size.Value
                fn_load_data_from_plc = frm_mainform.plc1_fault_client.DBRead(frm_mainform.num_plc1_fault_db.Value, 0, size, Buffer)
                loaded_plc_data = "plc1_fail:" + frm_mainform.plc1_fault_client.ErrorText(fn_load_data_from_plc) + vbNewLine
                If frm_mainform.plc1_fault_client.Connected And Not frm_mainform.plc1_fault_field_list(0, 0) = Nothing Then fn_prepare_data_arrays_and_sql_send(1, "fault", Buffer)
            Case Is = 4
                size = frm_mainform.num_plc2_fault_db_size.Value
                fn_load_data_from_plc = frm_mainform.plc2_fault_client.DBRead(frm_mainform.num_plc2_fault_db.Value, 0, size, Buffer)
                loaded_plc_data = "plc2_fail:" + frm_mainform.plc2_fault_client.ErrorText(fn_load_data_from_plc) + vbNewLine
                If frm_mainform.plc2_fault_client.Connected And Not frm_mainform.plc2_fault_field_list(0, 0) = Nothing Then fn_prepare_data_arrays_and_sql_send(2, "fault", Buffer)

        End Select

        ' If OK dumps the data (quick and dirty)

        If fn_load_data_from_plc = 0 Then
            y = 0
            For c = 0 To size - 1
                s = Hex$(Buffer(c)) 'byte result in hex format
                s = Buffer(c) 'byte result
                If s.Length = 1 Then
                    s = "0" + s
                End If
                If frm_mainform.chb_enable_data_logger.Checked Then
                    loaded_plc_data += "0x" + s + " "
                End If
                y = y + 1
                If y = 8 Then
                    y = 0
                    If frm_mainform.chb_enable_data_logger.Checked Then
                        loaded_plc_data += Chr(13) + Chr(10)
                    End If
                End If
            Next
        End If
        If frm_mainform.chb_enable_data_logger.Checked Then
            frm_mainform.txt_plc_dump.Text = vbNewLine + loaded_plc_data + vbNewLine + frm_mainform.txt_plc_dump.Text
        End If
    End Function


    Function fn_prepare_monitoring_field() As String
        Dim field_row_pointer As Integer
        Try
            ReDim frm_mainform.plc1_status_field_list(8, 0)
            ReDim frm_mainform.plc2_status_field_list(8, 0)
            ReDim frm_mainform.plc1_fault_field_list(8, 0)
            ReDim frm_mainform.plc2_fault_field_list(8, 0)

            'sorting for import to array
            frm_mainform.dgw_field_definitions.Sort(frm_mainform.dgw_field_definitions.Columns.Item(0), System.ComponentModel.ListSortDirection.Ascending)
            frm_mainform.dgw_field_definitions.Sort(frm_mainform.dgw_field_definitions.Columns.Item(1), System.ComponentModel.ListSortDirection.Ascending)
            frm_mainform.dgw_field_definitions.Sort(frm_mainform.dgw_field_definitions.Columns.Item(6), System.ComponentModel.ListSortDirection.Ascending)

            For Each row As DataGridViewRow In frm_mainform.dgw_field_definitions.Rows
                If Not frm_mainform.dgw_field_definitions.Rows(row.Index).IsNewRow = True Then

                    'preparing plc1_status_field_list
                    If row.Cells.Item(0).Value = 1 And row.Cells.Item(1).Value = "status" Then
                        If frm_mainform.plc1_status_field_list(0, (frm_mainform.plc1_status_field_list.Length / frm_mainform.plc1_status_field_list.GetLength(0)) - 1) Is Nothing Then
                            field_row_pointer = 1
                        Else
                            field_row_pointer = 0
                        End If
                        ReDim Preserve frm_mainform.plc1_status_field_list(8, (frm_mainform.plc1_status_field_list.Length / frm_mainform.plc1_status_field_list.GetLength(0)) - field_row_pointer)
                        frm_mainform.plc1_status_field_list(0, (frm_mainform.plc1_status_field_list.Length / frm_mainform.plc1_status_field_list.GetLength(0)) - 1) = row.Cells.Item(6).Value
                        frm_mainform.plc1_status_field_list(1, (frm_mainform.plc1_status_field_list.Length / frm_mainform.plc1_status_field_list.GetLength(0)) - 1) = row.Cells.Item(7).Value
                        frm_mainform.plc1_status_field_list(2, (frm_mainform.plc1_status_field_list.Length / frm_mainform.plc1_status_field_list.GetLength(0)) - 1) = row.Cells.Item(2).Value
                        frm_mainform.plc1_status_field_list(3, (frm_mainform.plc1_status_field_list.Length / frm_mainform.plc1_status_field_list.GetLength(0)) - 1) = row.Cells.Item(3).Value
                        frm_mainform.plc1_status_field_list(4, (frm_mainform.plc1_status_field_list.Length / frm_mainform.plc1_status_field_list.GetLength(0)) - 1) = vbNull
                        frm_mainform.plc1_status_field_list(5, (frm_mainform.plc1_status_field_list.Length / frm_mainform.plc1_status_field_list.GetLength(0)) - 1) = row.Cells.Item(5).Value
                        frm_mainform.plc1_status_field_list(6, (frm_mainform.plc1_status_field_list.Length / frm_mainform.plc1_status_field_list.GetLength(0)) - 1) = row.Cells.Item(8).Value
                        frm_mainform.plc1_status_field_list(7, (frm_mainform.plc1_status_field_list.Length / frm_mainform.plc1_status_field_list.GetLength(0)) - 1) = row.Cells.Item(8).Value
                        frm_mainform.plc1_status_field_list(8, (frm_mainform.plc1_status_field_list.Length / frm_mainform.plc1_status_field_list.GetLength(0)) - 1) = row.Cells.Item(4).Value
                    End If

                    'preparing plc2_status_field_list
                    If row.Cells.Item(0).Value = 2 And row.Cells.Item(1).Value = "status" Then
                        If frm_mainform.plc2_status_field_list(0, (frm_mainform.plc2_status_field_list.Length / frm_mainform.plc2_status_field_list.GetLength(0)) - 1) Is Nothing Then
                            field_row_pointer = 1
                        Else
                            field_row_pointer = 0
                        End If
                        ReDim Preserve frm_mainform.plc2_status_field_list(8, (frm_mainform.plc2_status_field_list.Length / frm_mainform.plc2_status_field_list.GetLength(0)) - field_row_pointer)
                        frm_mainform.plc2_status_field_list(0, (frm_mainform.plc2_status_field_list.Length / frm_mainform.plc2_status_field_list.GetLength(0)) - 1) = row.Cells.Item(6).Value
                        frm_mainform.plc2_status_field_list(1, (frm_mainform.plc2_status_field_list.Length / frm_mainform.plc2_status_field_list.GetLength(0)) - 1) = row.Cells.Item(7).Value
                        frm_mainform.plc2_status_field_list(2, (frm_mainform.plc2_status_field_list.Length / frm_mainform.plc2_status_field_list.GetLength(0)) - 1) = row.Cells.Item(2).Value
                        frm_mainform.plc2_status_field_list(3, (frm_mainform.plc2_status_field_list.Length / frm_mainform.plc2_status_field_list.GetLength(0)) - 1) = row.Cells.Item(3).Value
                        frm_mainform.plc2_status_field_list(4, (frm_mainform.plc2_status_field_list.Length / frm_mainform.plc2_status_field_list.GetLength(0)) - 1) = vbNull
                        frm_mainform.plc2_status_field_list(5, (frm_mainform.plc2_status_field_list.Length / frm_mainform.plc2_status_field_list.GetLength(0)) - 1) = row.Cells.Item(5).Value
                        frm_mainform.plc2_status_field_list(6, (frm_mainform.plc2_status_field_list.Length / frm_mainform.plc2_status_field_list.GetLength(0)) - 1) = row.Cells.Item(8).Value
                        frm_mainform.plc2_status_field_list(7, (frm_mainform.plc2_status_field_list.Length / frm_mainform.plc2_status_field_list.GetLength(0)) - 1) = row.Cells.Item(8).Value
                        frm_mainform.plc2_status_field_list(8, (frm_mainform.plc2_status_field_list.Length / frm_mainform.plc2_status_field_list.GetLength(0)) - 1) = row.Cells.Item(4).Value
                    End If

                    'preparing plc1_fault_field_list
                    If row.Cells.Item(0).Value = 1 And row.Cells.Item(1).Value = "fault" Then
                        If frm_mainform.plc1_fault_field_list(0, (frm_mainform.plc1_fault_field_list.Length / frm_mainform.plc1_fault_field_list.GetLength(0)) - 1) Is Nothing Then
                            field_row_pointer = 1
                        Else
                            field_row_pointer = 0
                        End If
                        ReDim Preserve frm_mainform.plc1_fault_field_list(8, (frm_mainform.plc1_fault_field_list.Length / frm_mainform.plc1_fault_field_list.GetLength(0)) - field_row_pointer)
                        frm_mainform.plc1_fault_field_list(0, (frm_mainform.plc1_fault_field_list.Length / frm_mainform.plc1_fault_field_list.GetLength(0)) - 1) = row.Cells.Item(6).Value
                        frm_mainform.plc1_fault_field_list(1, (frm_mainform.plc1_fault_field_list.Length / frm_mainform.plc1_fault_field_list.GetLength(0)) - 1) = row.Cells.Item(7).Value
                        frm_mainform.plc1_fault_field_list(2, (frm_mainform.plc1_fault_field_list.Length / frm_mainform.plc1_fault_field_list.GetLength(0)) - 1) = row.Cells.Item(2).Value
                        frm_mainform.plc1_fault_field_list(3, (frm_mainform.plc1_fault_field_list.Length / frm_mainform.plc1_fault_field_list.GetLength(0)) - 1) = row.Cells.Item(3).Value
                        frm_mainform.plc1_fault_field_list(4, (frm_mainform.plc1_fault_field_list.Length / frm_mainform.plc1_fault_field_list.GetLength(0)) - 1) = vbNull
                        frm_mainform.plc1_fault_field_list(5, (frm_mainform.plc1_fault_field_list.Length / frm_mainform.plc1_fault_field_list.GetLength(0)) - 1) = row.Cells.Item(5).Value
                        frm_mainform.plc1_fault_field_list(6, (frm_mainform.plc1_fault_field_list.Length / frm_mainform.plc1_fault_field_list.GetLength(0)) - 1) = row.Cells.Item(8).Value
                        frm_mainform.plc1_fault_field_list(7, (frm_mainform.plc1_fault_field_list.Length / frm_mainform.plc1_fault_field_list.GetLength(0)) - 1) = row.Cells.Item(8).Value
                        frm_mainform.plc1_fault_field_list(8, (frm_mainform.plc1_fault_field_list.Length / frm_mainform.plc1_fault_field_list.GetLength(0)) - 1) = row.Cells.Item(4).Value
                    End If

                    'preparing plc2_fault_field_list
                    If row.Cells.Item(0).Value = 2 And row.Cells.Item(1).Value = "fault" Then
                        If frm_mainform.plc2_fault_field_list(0, (frm_mainform.plc2_fault_field_list.Length / frm_mainform.plc2_fault_field_list.GetLength(0)) - 1) Is Nothing Then
                            field_row_pointer = 1
                        Else
                            field_row_pointer = 0
                        End If
                        ReDim Preserve frm_mainform.plc2_fault_field_list(8, (frm_mainform.plc2_fault_field_list.Length / frm_mainform.plc2_fault_field_list.GetLength(0)) - field_row_pointer)
                        frm_mainform.plc2_fault_field_list(0, (frm_mainform.plc2_fault_field_list.Length / frm_mainform.plc2_fault_field_list.GetLength(0)) - 1) = row.Cells.Item(6).Value
                        frm_mainform.plc2_fault_field_list(1, (frm_mainform.plc2_fault_field_list.Length / frm_mainform.plc2_fault_field_list.GetLength(0)) - 1) = row.Cells.Item(7).Value
                        frm_mainform.plc2_fault_field_list(2, (frm_mainform.plc2_fault_field_list.Length / frm_mainform.plc2_fault_field_list.GetLength(0)) - 1) = row.Cells.Item(2).Value
                        frm_mainform.plc2_fault_field_list(3, (frm_mainform.plc2_fault_field_list.Length / frm_mainform.plc2_fault_field_list.GetLength(0)) - 1) = row.Cells.Item(3).Value
                        frm_mainform.plc2_fault_field_list(4, (frm_mainform.plc2_fault_field_list.Length / frm_mainform.plc2_fault_field_list.GetLength(0)) - 1) = vbNull
                        frm_mainform.plc2_fault_field_list(5, (frm_mainform.plc2_fault_field_list.Length / frm_mainform.plc2_fault_field_list.GetLength(0)) - 1) = row.Cells.Item(5).Value
                        frm_mainform.plc2_fault_field_list(6, (frm_mainform.plc2_fault_field_list.Length / frm_mainform.plc2_fault_field_list.GetLength(0)) - 1) = row.Cells.Item(8).Value
                        frm_mainform.plc2_fault_field_list(7, (frm_mainform.plc2_fault_field_list.Length / frm_mainform.plc2_fault_field_list.GetLength(0)) - 1) = row.Cells.Item(8).Value
                        frm_mainform.plc2_fault_field_list(8, (frm_mainform.plc2_fault_field_list.Length / frm_mainform.plc2_fault_field_list.GetLength(0)) - 1) = row.Cells.Item(4).Value
                    End If
                End If
            Next

            'sorting back by PLC and type
            frm_mainform.dgw_field_definitions.Sort(frm_mainform.dgw_field_definitions.Columns.Item(0), System.ComponentModel.ListSortDirection.Ascending)
            'frm_mainform.dgw_field_definitions.Sort(frm_mainform.dgw_field_definitions.Columns.Item(1), System.ComponentModel.ListSortDirection.Ascending)
            'frm_mainform.dgw_field_definitions.Sort(frm_mainform.dgw_field_definitions.Columns.Item(2), System.ComponentModel.ListSortDirection.Ascending)

        Catch ex As Exception
            Return "chyba přípravy datového pole: " + ex.Message
        End Try
    End Function


    Function fn_prepare_data_arrays_and_sql_send(ByRef plc_no As Integer, ByRef data_type As String, ByRef buffer As Byte())
        Dim byte_point As Integer
        Dim bit_point As Integer
        Dim query, table_list, value_list, separator, next_table As String
        Dim field_list As String = ""
        'FILLING PLC1 status array
        Try
            If plc_no = 1 And data_type = "status" Then
                For i = 0 To frm_mainform.plc1_status_field_list.Length / frm_mainform.plc1_status_field_list.GetLength(0) - 1 'all field rows

                    'check next table
                    If i < frm_mainform.plc1_status_field_list.Length / frm_mainform.plc1_status_field_list.GetLength(0) - 1 Then
                        If Not frm_mainform.plc1_status_field_list(0, (i + 1)) = Nothing Then
                            next_table = frm_mainform.plc1_status_field_list(0, (i + 1))
                        Else
                            next_table = ""
                        End If
                    Else
                        next_table = ""
                    End If

                    'fill field array with bit information
                    If frm_mainform.plc1_status_field_list(3, i) = 1 Then
                        If frm_mainform.plc1_status_field_list(2, i) > 7 Then
                            byte_point = Math.Floor(frm_mainform.plc1_status_field_list(2, i) / 8)
                            bit_point = frm_mainform.plc1_status_field_list(2, i) - byte_point * 8
                        Else
                            byte_point = 0
                            bit_point = frm_mainform.plc1_status_field_list(2, i)
                        End If
                        Dim Source_Byte As New BitArray(System.BitConverter.GetBytes(buffer(byte_point)))
                        frm_mainform.plc1_status_field_list(4, i) = Source_Byte.Get(bit_point).ToString
                        If Not frm_mainform.plc1_status_field_list(7, i) Is Nothing Then
                            frm_mainform.plc1_status_field_list(6, i) = frm_mainform.plc1_status_field_list(7, i).ToString.Replace("*" + frm_mainform.plc1_status_field_list(1, i) + "*", Source_Byte.Get(bit_point).ToString)
                        End If
                        'frm_mainform.txt_plc_dump.Text += Source_Byte.Get(bit_point).ToString + "|" + buffer(byte_point).ToString + vbNewLine
                    End If


                    'fill all fields without bit
                    If frm_mainform.plc1_status_field_list(3, i) > 1 Then
                        Dim value = 0
                        Dim char_value As String = ""
                        Dim byte_no As Double = ((frm_mainform.plc1_status_field_list(2, i) + (frm_mainform.plc1_status_field_list(3, i) / 8)) - 1) - frm_mainform.plc1_status_field_list(2, i)
                        If frm_mainform.plc1_status_field_list(2, i) = 0 Then
                            'first bit
                            For byte_point = frm_mainform.plc1_status_field_list(2, i) To (frm_mainform.plc1_status_field_list(2, i) + (frm_mainform.plc1_status_field_list(3, i) / 8)) - 1
                                Select Case frm_mainform.plc1_status_field_list(8, i)
                                    Case Is = "number"
                                        If byte_no > 0 Then value += buffer(byte_point) * Math.Pow(256, byte_no) Else value += buffer(byte_point)
                                    Case Is = "char"
                                        char_value += Chr(buffer(byte_point)).ToString
                                End Select
                                byte_no -= 1
                            Next
                        Else
                            'another first bit
                            For byte_point = (frm_mainform.plc1_status_field_list(2, i) / 8) To ((frm_mainform.plc1_status_field_list(2, i) / 8) + (frm_mainform.plc1_status_field_list(3, i) / 8)) - 1
                                Select Case frm_mainform.plc1_status_field_list(8, i)
                                    Case Is = "number"
                                        If byte_no > 0 Then value += buffer(byte_point) * Math.Pow(256, byte_no) Else value += buffer(byte_point)
                                    Case Is = "char"
                                        char_value += Chr(buffer(byte_point)).ToString
                                End Select
                                byte_no -= 1
                            Next
                        End If


                        Select Case frm_mainform.plc1_status_field_list(8, i)
                            Case Is = "number"
                                frm_mainform.plc1_status_field_list(4, i) = value.ToString
                                If Not frm_mainform.plc1_status_field_list(7, i) Is Nothing Then
                                    frm_mainform.plc1_status_field_list(6, i) = frm_mainform.plc1_status_field_list(7, i).ToString.Replace("*" + frm_mainform.plc1_status_field_list(1, i) + "*", value)
                                End If
                            Case Is = "char"
                                frm_mainform.plc1_status_field_list(4, i) = char_value
                                If Not frm_mainform.plc1_status_field_list(7, i) Is Nothing Then
                                    frm_mainform.plc1_status_field_list(6, i) = frm_mainform.plc1_status_field_list(7, i).ToString.Replace("*" + frm_mainform.plc1_status_field_list(1, i) + "*", char_value)
                                End If
                        End Select
                    End If

                    'prepare for SQL
                    If field_list.Length = 0 Then separator = "" Else separator = ","

                    If frm_mainform.plc1_status_field_list(5, i) = "Always" Or frm_mainform.plc1_status_field_list(5, i) = frm_mainform.plc1_status_field_list(4, i) Then
                        field_list += separator + "[" + frm_mainform.plc1_status_field_list(1, i) + "]"
                        If frm_mainform.plc1_status_field_list(6, i).Length = 0 Then value_list += separator + frm_mainform.plc1_status_field_list(4, i).ToString Else value_list += separator + frm_mainform.plc1_status_field_list(6, i).ToString
                    End If

                    ''BUILD INSERT COMMAND FOR each TABLE
                    If frm_mainform.plc1_status_field_list(0, i) <> next_table And field_list.Length > 0 Then
                        query += "INSERT INTO " + frm_mainform.plc1_status_field_list(0, i) + " (" + field_list + ") VALUES (" + value_list + ");"
                        field_list = ""
                        value_list = ""
                    End If

                Next

            End If


            'FILLING plc2 status array
            If plc_no = 2 And data_type = "status" Then

                For i = 0 To frm_mainform.plc2_status_field_list.Length / frm_mainform.plc2_status_field_list.GetLength(0) - 1 'all field rows

                    'check next table
                    If i < frm_mainform.plc2_status_field_list.Length / frm_mainform.plc2_status_field_list.GetLength(0) - 1 Then
                        If Not frm_mainform.plc2_status_field_list(0, (i + 1)) = Nothing Then
                            next_table = frm_mainform.plc2_status_field_list(0, (i + 1))
                        Else
                            next_table = ""
                        End If
                    Else
                        next_table = ""
                    End If


                    'fill field array with bit information
                    If frm_mainform.plc2_status_field_list(3, i) = 1 Then
                        If frm_mainform.plc2_status_field_list(2, i) > 7 Then
                            byte_point = Math.Floor(frm_mainform.plc2_status_field_list(2, i) / 8)
                            bit_point = frm_mainform.plc2_status_field_list(2, i) - byte_point * 8
                        Else
                            byte_point = 0
                            bit_point = frm_mainform.plc2_status_field_list(2, i)
                        End If
                        Dim Source_Byte As New BitArray(System.BitConverter.GetBytes(buffer(byte_point)))
                        frm_mainform.plc2_status_field_list(4, i) = Source_Byte.Get(bit_point).ToString
                        If Not frm_mainform.plc2_status_field_list(7, i) Is Nothing Then
                            frm_mainform.plc2_status_field_list(6, i) = frm_mainform.plc2_status_field_list(7, i).ToString.Replace("*" + frm_mainform.plc2_status_field_list(1, i) + "*", Source_Byte.Get(bit_point).ToString)
                        End If
                    End If


                    'fill all fields without bit
                    If frm_mainform.plc2_status_field_list(3, i) > 1 Then
                        Dim value = 0
                        Dim char_value As String = ""
                        Dim byte_no As Double = ((frm_mainform.plc2_status_field_list(2, i) + (frm_mainform.plc2_status_field_list(3, i) / 8)) - 1) - frm_mainform.plc2_status_field_list(2, i)
                        If frm_mainform.plc2_status_field_list(2, i) = 0 Then
                            'first bit
                            For byte_point = frm_mainform.plc2_status_field_list(2, i) To (frm_mainform.plc2_status_field_list(2, i) + (frm_mainform.plc2_status_field_list(3, i) / 8)) - 1
                                Select Case frm_mainform.plc2_status_field_list(8, i)
                                    Case Is = "number"
                                        If byte_no > 0 Then value += buffer(byte_point) * Math.Pow(256, byte_no) Else value += buffer(byte_point)
                                    Case Is = "char"
                                        char_value += Chr(buffer(byte_point)).ToString
                                End Select
                                byte_no -= 1
                            Next
                        Else
                            'another first bit
                            For byte_point = (frm_mainform.plc2_status_field_list(2, i) / 8) To ((frm_mainform.plc2_status_field_list(2, i) / 8) + (frm_mainform.plc2_status_field_list(3, i) / 8)) - 1
                                Select Case frm_mainform.plc2_status_field_list(8, i)
                                    Case Is = "number"
                                        If byte_no > 0 Then value += buffer(byte_point) * Math.Pow(256, byte_no) Else value += buffer(byte_point)
                                    Case Is = "char"
                                        char_value += Chr(buffer(byte_point)).ToString
                                End Select
                                byte_no -= 1
                            Next
                        End If


                        Select Case frm_mainform.plc2_status_field_list(8, i)
                            Case Is = "number"
                                frm_mainform.plc2_status_field_list(4, i) = value.ToString
                                If Not frm_mainform.plc2_status_field_list(7, i) Is Nothing Then
                                    frm_mainform.plc2_status_field_list(6, i) = frm_mainform.plc2_status_field_list(7, i).ToString.Replace("*" + frm_mainform.plc2_status_field_list(1, i) + "*", value)
                                End If
                            Case Is = "char"
                                frm_mainform.plc2_status_field_list(4, i) = char_value
                                If Not frm_mainform.plc2_status_field_list(7, i) Is Nothing Then
                                    frm_mainform.plc2_status_field_list(6, i) = frm_mainform.plc2_status_field_list(7, i).ToString.Replace("*" + frm_mainform.plc2_status_field_list(1, i) + "*", char_value)
                                End If
                        End Select
                    End If

                    'prepare for SQL
                    If field_list.Length = 0 Then separator = "" Else separator = ","

                    If frm_mainform.plc2_status_field_list(5, i) = "Always" Or frm_mainform.plc2_status_field_list(5, i) = frm_mainform.plc2_status_field_list(4, i) Then
                        field_list += separator + "[" + frm_mainform.plc2_status_field_list(1, i) + "]"
                        If frm_mainform.plc2_status_field_list(6, i).Length = 0 Then value_list += separator + frm_mainform.plc2_status_field_list(4, i).ToString Else value_list += separator + frm_mainform.plc2_status_field_list(6, i).ToString
                    End If

                    ''BUILD INSERT COMMAND FOR each TABLE
                    If frm_mainform.plc2_status_field_list(0, i) <> next_table And field_list.Length > 0 Then
                        query += "INSERT INTO " + frm_mainform.plc2_status_field_list(0, i) + " (" + field_list + ") VALUES (" + value_list + ");"
                        field_list = ""
                        value_list = ""
                    End If

                Next
            End If


            'FILLING PLC1 fault array
            If plc_no = 1 And data_type = "fault" Then
                For i = 0 To frm_mainform.plc1_fault_field_list.Length / frm_mainform.plc1_fault_field_list.GetLength(0) - 1 'all field rows

                    'check next table
                    If i < frm_mainform.plc1_fault_field_list.Length / frm_mainform.plc1_fault_field_list.GetLength(0) - 1 Then
                        If Not frm_mainform.plc1_fault_field_list(0, (i + 1)) = Nothing Then
                            next_table = frm_mainform.plc1_fault_field_list(0, (i + 1))
                        Else
                            next_table = ""
                        End If
                    Else
                        next_table = ""
                    End If

                    'fill field array with bit information
                    If frm_mainform.plc1_fault_field_list(3, i) = 1 Then
                        If frm_mainform.plc1_fault_field_list(2, i) > 7 Then
                            byte_point = Math.Floor(frm_mainform.plc1_fault_field_list(2, i) / 8)
                            bit_point = frm_mainform.plc1_fault_field_list(2, i) - byte_point * 8
                        Else
                            byte_point = 0
                            bit_point = frm_mainform.plc1_fault_field_list(2, i)
                        End If
                        Dim Source_Byte As New BitArray(System.BitConverter.GetBytes(buffer(byte_point)))
                        frm_mainform.plc1_fault_field_list(4, i) = Source_Byte.Get(bit_point).ToString
                        If Not frm_mainform.plc1_fault_field_list(7, i) Is Nothing Then
                            frm_mainform.plc1_fault_field_list(6, i) = frm_mainform.plc1_fault_field_list(7, i).ToString.Replace("*" + frm_mainform.plc1_fault_field_list(1, i) + "*", Source_Byte.Get(bit_point).ToString)
                        End If
                    End If


                    'fill all fields without bit
                    If frm_mainform.plc1_fault_field_list(3, i) > 1 Then
                        Dim value = 0
                        Dim char_value As String = ""
                        Dim byte_no As Double = ((frm_mainform.plc1_fault_field_list(2, i) + (frm_mainform.plc1_fault_field_list(3, i) / 8)) - 1) - frm_mainform.plc1_fault_field_list(2, i)
                        If frm_mainform.plc1_fault_field_list(2, i) = 0 Then
                            'first bit
                            For byte_point = frm_mainform.plc1_fault_field_list(2, i) To (frm_mainform.plc1_fault_field_list(2, i) + (frm_mainform.plc1_fault_field_list(3, i) / 8)) - 1
                                Select Case frm_mainform.plc1_fault_field_list(8, i)
                                    Case Is = "number"
                                        If byte_no > 0 Then value += buffer(byte_point) * Math.Pow(256, byte_no) Else value += buffer(byte_point)
                                    Case Is = "char"
                                        char_value += Chr(buffer(byte_point)).ToString
                                End Select
                                byte_no -= 1
                            Next
                        Else
                            'another first bit
                            For byte_point = (frm_mainform.plc1_fault_field_list(2, i) / 8) To ((frm_mainform.plc1_fault_field_list(2, i) / 8) + (frm_mainform.plc1_fault_field_list(3, i) / 8)) - 1
                                Select Case frm_mainform.plc1_fault_field_list(8, i)
                                    Case Is = "number"
                                        If byte_no > 0 Then value += buffer(byte_point) * Math.Pow(256, byte_no) Else value += buffer(byte_point)
                                    Case Is = "char"
                                        char_value += Chr(buffer(byte_point)).ToString
                                End Select
                                byte_no -= 1
                            Next
                        End If

                        Select frm_mainform.plc1_fault_field_list(8, i)
                            Case Is = "number"
                                frm_mainform.plc1_fault_field_list(4, i) = value.ToString
                                If Not frm_mainform.plc1_fault_field_list(7, i) Is Nothing Then
                                    frm_mainform.plc1_fault_field_list(6, i) = frm_mainform.plc1_fault_field_list(7, i).ToString.Replace("*" + frm_mainform.plc1_fault_field_list(1, i) + "*", value)
                                End If
                            Case Is = "char"
                                frm_mainform.plc1_fault_field_list(4, i) = char_value
                                If Not frm_mainform.plc1_fault_field_list(7, i) Is Nothing Then
                                    frm_mainform.plc1_fault_field_list(6, i) = frm_mainform.plc1_fault_field_list(7, i).ToString.Replace("*" + frm_mainform.plc1_fault_field_list(1, i) + "*", char_value)
                                End If
                        End Select
                    End If

                    'prepare for SQL
                    If field_list.Length = 0 Then separator = "" Else separator = ","

                    If frm_mainform.plc1_fault_field_list(5, i) = "Always" Or frm_mainform.plc1_fault_field_list(5, i) = frm_mainform.plc1_fault_field_list(4, i) Then
                        field_list += separator + "[" + frm_mainform.plc1_fault_field_list(1, i) + "]"
                        If frm_mainform.plc1_fault_field_list(6, i).Length = 0 Then value_list += separator + frm_mainform.plc1_fault_field_list(4, i).ToString Else value_list += separator + frm_mainform.plc1_fault_field_list(6, i).ToString
                    End If

                    ''BUILD INSERT COMMAND FOR each TABLE
                    If frm_mainform.plc1_fault_field_list(0, i) <> next_table And field_list.Length > 0 Then
                        query += "INSERT INTO " + frm_mainform.plc1_fault_field_list(0, i) + " (" + field_list + ") VALUES (" + value_list + ");"
                        field_list = ""
                        value_list = ""
                    End If

                Next
            End If


            'FILLING plc2 fault array
            If plc_no = 2 And data_type = "fault" Then
                For i = 0 To frm_mainform.plc2_fault_field_list.Length / frm_mainform.plc2_fault_field_list.GetLength(0) - 1 'all field rows

                    'check next table
                    If i < frm_mainform.plc2_fault_field_list.Length / frm_mainform.plc2_fault_field_list.GetLength(0) - 1 Then
                        If Not frm_mainform.plc2_fault_field_list(0, (i + 1)) = Nothing Then
                            next_table = frm_mainform.plc2_fault_field_list(0, (i + 1))
                        Else
                            next_table = ""
                        End If
                    Else
                        next_table = ""
                    End If

                    'fill field array with bit information
                    If frm_mainform.plc2_fault_field_list(3, i) = 1 Then
                        If frm_mainform.plc2_fault_field_list(2, i) > 7 Then
                            byte_point = Math.Floor(frm_mainform.plc2_fault_field_list(2, i) / 8)
                            bit_point = frm_mainform.plc2_fault_field_list(2, i) - byte_point * 8
                        Else
                            byte_point = 0
                            bit_point = frm_mainform.plc2_fault_field_list(2, i)
                        End If
                        Dim Source_Byte As New BitArray(System.BitConverter.GetBytes(buffer(byte_point)))
                        frm_mainform.plc2_fault_field_list(4, i) = Source_Byte.Get(bit_point).ToString
                        If Not frm_mainform.plc2_fault_field_list(7, i) Is Nothing Then
                            frm_mainform.plc2_fault_field_list(6, i) = frm_mainform.plc2_fault_field_list(7, i).ToString.Replace("*" + frm_mainform.plc2_fault_field_list(1, i) + "*", Source_Byte.Get(bit_point).ToString)
                        End If
                    End If


                    'fill all fields without bit
                    If frm_mainform.plc2_fault_field_list(3, i) > 1 Then
                        Dim value = 0
                        Dim char_value As String = ""
                        Dim byte_no As Double = ((frm_mainform.plc2_fault_field_list(2, i) + (frm_mainform.plc2_fault_field_list(3, i) / 8)) - 1) - frm_mainform.plc2_fault_field_list(2, i)
                        If frm_mainform.plc2_fault_field_list(2, i) = 0 Then
                            'first bit
                            For byte_point = frm_mainform.plc2_fault_field_list(2, i) To (frm_mainform.plc2_fault_field_list(2, i) + (frm_mainform.plc2_fault_field_list(3, i) / 8)) - 1
                                Select Case frm_mainform.plc2_fault_field_list(8, i)
                                    Case Is = "number"
                                        If byte_no > 0 Then value += buffer(byte_point) * Math.Pow(256, byte_no) Else value += buffer(byte_point)
                                    Case Is = "char"
                                        char_value += Chr(buffer(byte_point)).ToString
                                End Select
                                byte_no -= 1
                            Next
                        Else
                            'another first bit
                            For byte_point = (frm_mainform.plc2_fault_field_list(2, i) / 8) To ((frm_mainform.plc2_fault_field_list(2, i) / 8) + (frm_mainform.plc2_fault_field_list(3, i) / 8)) - 1
                                Select Case frm_mainform.plc2_fault_field_list(8, i)
                                    Case Is = "number"
                                        If byte_no > 0 Then value += buffer(byte_point) * Math.Pow(256, byte_no) Else value += buffer(byte_point)
                                    Case Is = "char"
                                        char_value += Chr(buffer(byte_point)).ToString
                                End Select
                                byte_no -= 1
                            Next
                        End If


                        Select Case frm_mainform.plc2_fault_field_list(8, i)
                            Case Is = "number"
                                frm_mainform.plc2_fault_field_list(4, i) = value.ToString
                                If Not frm_mainform.plc2_fault_field_list(7, i) Is Nothing Then
                                    frm_mainform.plc2_fault_field_list(6, i) = frm_mainform.plc2_fault_field_list(7, i).ToString.Replace("*" + frm_mainform.plc2_fault_field_list(1, i) + "*", value)
                                End If
                            Case Is = "char"
                                frm_mainform.plc2_fault_field_list(4, i) = char_value
                                If Not frm_mainform.plc2_fault_field_list(7, i) Is Nothing Then
                                    frm_mainform.plc2_fault_field_list(6, i) = frm_mainform.plc2_fault_field_list(7, i).ToString.Replace("*" + frm_mainform.plc2_fault_field_list(1, i) + "*", char_value)
                                End If
                        End Select
                    End If

                    'prepare for SQL
                    If field_list.Length = 0 Then separator = "" Else separator = ","

                    If frm_mainform.plc2_fault_field_list(5, i) = "Always" Or frm_mainform.plc2_fault_field_list(5, i) = frm_mainform.plc2_fault_field_list(4, i) Then
                        field_list += separator + "[" + frm_mainform.plc2_fault_field_list(1, i) + "]"
                        If frm_mainform.plc2_fault_field_list(6, i).Length = 0 Then value_list += separator + frm_mainform.plc2_fault_field_list(4, i).ToString Else value_list += separator + frm_mainform.plc2_fault_field_list(6, i).ToString
                    End If

                    ''BUILD INSERT COMMAND FOR each TABLE
                    If frm_mainform.plc2_fault_field_list(0, i) <> next_table And field_list.Length > 0 Then
                        query += "INSERT INTO " + frm_mainform.plc2_fault_field_list(0, i) + " (" + field_list + ") VALUES (" + value_list + ");"
                        field_list = ""
                        value_list = ""
                    End If

                Next
            End If

            If query.Length > 0 Then
                ' frm_mainform.txt_plc_dump.Text += query
                fn_sql_request(query, "INSERT")
            End If
        Catch ex As Exception
            frm_mainform.txt_plc_dump.Text = "field array preparing error:" + ex.Message + vbNewLine
        End Try

    End Function



End Module