Option Strict Off
Option Explicit On

Imports System
Imports Sharp7
Imports System.Data
Imports System.Data.SqlClient
Imports System.Drawing.Imaging
Imports System.Drawing.Printing


Public Class frm_mainform

    Dim starting As Boolean = True
    Dim Buffer(65536) As Byte ' Buffer  
    Dim Test_Client1 As S7Client ' Client Object
    Dim Test_Client2 As S7Client ' Client Object
    Protected Friend plc1_status_client As S7Client ' Client Object
    Protected Friend plc1_fault_client As S7Client ' Client Object
    Protected Friend plc2_status_client As S7Client ' Client Object
    Protected Friend plc2_fault_client As S7Client ' Client Object

    Protected Friend plc1_status_field_list(8, 0) As String ' table,column_name,start_bit,field_length,value,react,spec_command,orig_spec_command,byte_type
    Protected Friend plc2_status_field_list(8, 0) As String ' table,column_name,start_bit,field_length,value,react,spec_command,orig_spec_command,byte_type
    Protected Friend plc1_fault_field_list(8, 0) As String ' table,column_name,start_bit,field_length,value,react,spec_command,orig_spec_command,byte_type
    Protected Friend plc2_fault_field_list(8, 0) As String ' table,column_name,start_bit,field_length,value,react,spec_command,orig_spec_command,byte_type


    Protected Friend sql_array_count As Integer = 0
    Protected Friend sql_array(0, 0) As String
    Protected Friend result_cleaner As DateTime = DateTime.Now
    Protected Friend time_cycle_1s As DateTime = DateTime.Now
    Protected Friend status_cycle As DateTime = DateTime.Now
    Protected Friend fail_cycle As DateTime = DateTime.Now

    'application files
    Protected Friend setting_folder = System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData), Application.ProductName)
    Protected Friend configuration_file As String = "settings.ini"
    Protected Friend data_file As String = "data.ini"


    Public Sub New()
        InitializeComponent()
        Test_Client1 = New S7Client
        Test_Client2 = New S7Client
        plc1_status_client = New S7Client
        plc1_fault_client = New S7Client
        plc2_status_client = New S7Client
        plc2_fault_client = New S7Client


        If IntPtr.Size = 4 Then
            Text = Text + " - Running 32 bit Code"
        Else
            Text = Text + " - Running 64 bit Code"
        End If

    End Sub


    Private Sub frm_mainform_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        fn_file_startup_check()

        result_cleaner = Date.Now.AddSeconds(5)
        txt_result_box.Text = fn_load_setting()
        txt_result_box.Text = fn_load_data_setting()
        txt_result_box.Text = fn_prepare_monitoring_field()
        starting = False
    End Sub

    Private Sub Main_Form_Shown(sender As System.Object, e As System.EventArgs) Handles MyBase.Shown
        Main_Form_minimized(Me, e)
        Dim Result_plc1 As Integer
        Dim Result_plc2 As Integer

        If chb_status_communication_autorun.Checked Then
            Result_plc1 = plc1_status_client.ConnectTo(txt_plc_IP1.Text, num_rack1.Value, num_slot1.Value)
            Result_plc2 = plc2_status_client.ConnectTo(txt_plc_IP2.Text, num_rack2.Value, num_slot2.Value)
            Show_plc_Result(Result_plc1, 11)
            Show_plc_Result(Result_plc2, 12)
            status_cycle = DateTime.Now.AddSeconds(num_status_time_settings.Value)
        End If

        If chb_fault_communication_autostart.Checked Then
            Result_plc1 = plc1_fault_client.ConnectTo(txt_plc_IP1.Text, num_rack1.Value, num_slot1.Value)
            Result_plc2 = plc2_fault_client.ConnectTo(txt_plc_IP2.Text, num_rack2.Value, num_slot2.Value)
            Show_plc_Result(Result_plc1, 11)
            Show_plc_Result(Result_plc2, 12)
            fail_cycle = DateTime.Now.AddSeconds(num_fault_time_settings.Value)
        End If
    End Sub


    Private Sub Main_Form_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        Dim result = MsgBox("Chcete Aplikaci skutečně Ukončit?", MsgBoxStyle.YesNo)
        If result = vbYes Then
            Test_Client1.Disconnect()
            Test_Client2.Disconnect()
            plc1_status_client.Disconnect()
            plc1_fault_client.Disconnect()
            plc2_status_client.Disconnect()
            plc2_fault_client.Disconnect()

            Application.Exit()
        Else
            e.Cancel = True
        End If
    End Sub

    Private Sub Main_Form_FormClosed(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Test_Client1.Disconnect()
        Test_Client2.Disconnect()
        plc1_status_client.Disconnect()
        plc1_fault_client.Disconnect()
        plc2_status_client.Disconnect()
        plc2_fault_client.Disconnect()
        Application.Exit()
    End Sub


    Private Sub Main_Form_minimized(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        If Me.Visible = True Then
            Me.WindowState = FormWindowState.Normal
            Me.Visible = False
        End If
    End Sub



    'CONNECTION SETTINGS

    'save config
    Private Sub connection_settings_Changed(sender As Object, e As EventArgs) Handles txt_plc_IP1.TextChanged, num_rack1.ValueChanged, num_slot1.ValueChanged, txt_plc_IP2.TextChanged, num_rack2.ValueChanged, num_slot2.ValueChanged, txt_serverSQL.TextChanged, txt_db_name.TextChanged, num_sql_timeout.ValueChanged, txt_db_loginname.TextChanged, txt_db_password.TextChanged, num_fault_time_settings.ValueChanged, num_status_time_settings.ValueChanged, num_plc1_status_db_size.ValueChanged, num_plc2_status_db_size.ValueChanged, num_plc1_status_db.ValueChanged, num_plc2_status_db.ValueChanged, num_plc1_fault_db.ValueChanged, num_plc2_fault_db.ValueChanged, num_plc1_fault_db_size.ValueChanged, num_plc2_fault_db_size.ValueChanged, chb_enable_schleduler.CheckedChanged, dt_monitor_start_time.ValueChanged, dt_monitor_stop_time.ValueChanged, chb_status_communication_autorun.CheckedChanged, chb_fault_communication_autostart.CheckedChanged
        If Not starting Then
            result_cleaner = Date.Now.AddSeconds(5)
            txt_result_box.Text = fn_save_file_setting()
        End If
    End Sub


    Private Sub btn_mssql_test_connection_Click(sender As Object, e As EventArgs) Handles btn_mssql_test_connection.Click
        txt_result_box.Text = check_sql_server()
    End Sub



    Private Sub btn_plc1_test_connection_Click(sender As Object, e As EventArgs) Handles btn_plc1_test_connection.Click
        Dim Result As Integer
        fn_cursor_wait(True)
        Result = Test_Client1.ConnectTo(txt_plc_IP1.Text, num_rack1.Value, num_slot1.Value)
        Show_plc_Result(Result, 1)
        If Result = 0 Then
            Test_Client1.Disconnect()
        End If
        fn_cursor_wait(False)
    End Sub


    Private Sub btn_plc2_test_connection_Click(sender As Object, e As EventArgs) Handles btn_plc2_test_connection.Click
        Dim Result As Integer
        fn_cursor_wait(True)
        Result = Test_Client2.ConnectTo(txt_plc_IP2.Text, num_rack2.Value, num_slot2.Value)
        Show_plc_Result(Result, 2)
        If Result = 0 Then
            Test_Client2.Disconnect()
        End If
        fn_cursor_wait(False)
    End Sub


    'status
    Private Sub Show_plc_Result(ByVal Result As Integer, ByVal client_no As Integer)
        result_cleaner = Date.Now.AddSeconds(5)
        If client_no = 1 Then
            txt_result_box.Text = "Connect to PLC1: " + Test_Client1.ErrorText(Result)
        ElseIf client_no = 2 Then
            txt_result_box.Text = "Connect to PLC2: " + Test_Client2.ErrorText(Result)
        End If
    End Sub


    Private Sub Timer_Tick(sender As Object, e As EventArgs) Handles Timer.Tick
        Try
            'reset status field
            If result_cleaner < Date.Now Then
                txt_result_box.Clear()
            End If

            'check PLC connection status
            If time_cycle_1s < Date.Now Then

                If plc1_status_client.Connected Then
                    If chb_enable_schleduler.Checked = False Or (chb_enable_schleduler.Checked = True And dt_monitor_start_time.Value.TimeOfDay <= DateTime.Now.TimeOfDay And dt_monitor_stop_time.Value.TimeOfDay >= DateTime.Now.TimeOfDay) Then
                        p_status_plc1.BackColor = Color.LightSeaGreen
                        ni_tray_menu.Icon = My.Resources.siemens_run
                    Else
                        If CLng(DateTime.Now.Second) Mod 2 > 0 Then
                            p_status_plc1.BackColor = Color.LightSeaGreen
                            ni_tray_menu.Icon = My.Resources.siemens_run
                        Else
                            p_status_plc1.BackColor = Color.Orange
                            ni_tray_menu.Icon = My.Resources.siemens_waiting
                        End If

                    End If
                Else
                    p_status_plc1.BackColor = Color.Red
                    ni_tray_menu.Icon = My.Resources.siemens_stop
                End If

                If plc2_status_client.Connected Then
                    If chb_enable_schleduler.Checked = False Or (chb_enable_schleduler.Checked = True And dt_monitor_start_time.Value.TimeOfDay <= DateTime.Now.TimeOfDay And dt_monitor_stop_time.Value.TimeOfDay >= DateTime.Now.TimeOfDay) Then
                        p_status_plc2.BackColor = Color.LightSeaGreen
                        ni_tray_menu.Icon = My.Resources.siemens_run
                    Else
                        If CLng(DateTime.Now.Second) Mod 2 > 0 Then
                            p_status_plc2.BackColor = Color.LightSeaGreen
                            ni_tray_menu.Icon = My.Resources.siemens_run
                        Else
                            p_status_plc2.BackColor = Color.Orange
                            ni_tray_menu.Icon = My.Resources.siemens_waiting
                        End If

                    End If
                Else
                    p_status_plc2.BackColor = Color.Red
                    ni_tray_menu.Icon = My.Resources.siemens_stop
                End If

                If plc1_fault_client.Connected Then
                    If chb_enable_schleduler.Checked = False Or (chb_enable_schleduler.Checked = True And dt_monitor_start_time.Value.TimeOfDay <= DateTime.Now.TimeOfDay And dt_monitor_stop_time.Value.TimeOfDay >= DateTime.Now.TimeOfDay) Then
                        p_fail_plc1.BackColor = Color.LightSeaGreen
                        ni_tray_menu.Icon = My.Resources.siemens_run
                    Else
                        If CLng(DateTime.Now.Second) Mod 2 > 0 Then
                            p_fail_plc1.BackColor = Color.LightSeaGreen
                            ni_tray_menu.Icon = My.Resources.siemens_run
                        Else
                            p_fail_plc1.BackColor = Color.Orange
                            ni_tray_menu.Icon = My.Resources.siemens_waiting
                        End If
                    End If
                Else
                    p_fail_plc1.BackColor = Color.Red
                    ni_tray_menu.Icon = My.Resources.siemens_stop
                End If

                If plc2_fault_client.Connected Then
                    If chb_enable_schleduler.Checked = False Or (chb_enable_schleduler.Checked = True And dt_monitor_start_time.Value.TimeOfDay <= DateTime.Now.TimeOfDay And dt_monitor_stop_time.Value.TimeOfDay >= DateTime.Now.TimeOfDay) Then
                        p_fail_plc2.BackColor = Color.LightSeaGreen
                        ni_tray_menu.Icon = My.Resources.siemens_run
                    Else
                        If CLng(DateTime.Now.Second) Mod 2 > 0 Then
                            p_fail_plc2.BackColor = Color.LightSeaGreen
                            ni_tray_menu.Icon = My.Resources.siemens_run
                        Else
                            p_fail_plc2.BackColor = Color.Orange
                            ni_tray_menu.Icon = My.Resources.siemens_waiting
                        End If

                    End If
                Else
                    p_fail_plc2.BackColor = Color.Red
                    ni_tray_menu.Icon = My.Resources.siemens_stop
                End If


                If plc1_status_client.Connected And plc2_status_client.Connected Then btn_start_status_data.Enabled = False Else btn_start_status_data.Enabled = True
                If Not plc1_status_client.Connected And Not plc2_status_client.Connected Then btn_stop_status_data.Enabled = False Else btn_stop_status_data.Enabled = True
                If plc1_fault_client.Connected And plc2_fault_client.Connected Then btn_start_fault_data.Enabled = False Else btn_start_fault_data.Enabled = True
                If Not plc1_fault_client.Connected And Not plc2_fault_client.Connected Then btn_stop_fault_data.Enabled = False Else btn_stop_fault_data.Enabled = True
                time_cycle_1s = Date.Now.AddSeconds(1)
            End If

            If status_cycle <= DateTime.Now And (chb_enable_schleduler.Checked = False Or (chb_enable_schleduler.Checked = True And dt_monitor_start_time.Value.TimeOfDay <= DateTime.Now.TimeOfDay And dt_monitor_stop_time.Value.TimeOfDay >= DateTime.Now.TimeOfDay)) Then
                If p_status_plc2.BackColor = Color.LightSeaGreen Then
                    Show_plc_Result(fn_load_data_from_plc(2), 12)
                End If
                If p_status_plc1.BackColor = Color.LightSeaGreen Then
                    Show_plc_Result(fn_load_data_from_plc(1), 11)
                End If
                status_cycle = DateTime.Now.AddSeconds(num_status_time_settings.Value)
            End If


            If fail_cycle <= DateTime.Now And (chb_enable_schleduler.Checked = False Or (chb_enable_schleduler.Checked = True And dt_monitor_start_time.Value.TimeOfDay <= DateTime.Now.TimeOfDay And dt_monitor_stop_time.Value.TimeOfDay >= DateTime.Now.TimeOfDay)) Then
                If p_fail_plc2.BackColor = Color.LightSeaGreen Then
                    Show_plc_Result(fn_load_data_from_plc(4), 14)
                End If
                If p_fail_plc1.BackColor = Color.LightSeaGreen Then
                    Show_plc_Result(fn_load_data_from_plc(3), 13)
                End If
                fail_cycle = DateTime.Now.AddSeconds(num_fault_time_settings.Value)
            End If

        Catch ex As Exception
        End Try
    End Sub



    'data definition tab page

    Private Sub dgw_field_definitions_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles dgw_field_definitions.CellValueChanged, dgw_field_definitions.RowValidated
        If starting = False Then
            fn_check_data_format(e.RowIndex, "one")
            If data_error_count = 0 Then btd_save_data_settings.Enabled = True Else btd_save_data_settings.Enabled = False
        End If
    End Sub


    Private Sub dgw_field_definitions_rowdeleted(sender As Object, e As DataGridViewRowsRemovedEventArgs) Handles dgw_field_definitions.RowsRemoved
        If starting = False Then
            fn_check_data_format(e.RowIndex, "all")
            If data_error_count = 0 Then btd_save_data_settings.Enabled = True Else btd_save_data_settings.Enabled = False
        End If
    End Sub


    Private Sub btd_save_data_settings_Click(sender As Object, e As EventArgs) Handles btd_save_data_settings.Click
        result_cleaner = Date.Now.AddSeconds(5)
        txt_result_box.Text = fn_save_data_setting()
        fn_prepare_monitoring_field()
    End Sub


    'tray menu
    Private Sub ni_tray_menu_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles ni_tray_menu.MouseDoubleClick
        If Me.Visible = False Then
            Me.Visible = True
        Else
            Me.Visible = False
        End If
    End Sub


    'data transfer tabpage
    Private Sub btn_start_status_data_Click(sender As Object, e As EventArgs) Handles btn_start_status_data.Click
        Dim Result_plc1 As Integer
        Dim Result_plc2 As Integer
        fn_cursor_wait(True)
        Result_plc1 = plc1_status_client.ConnectTo(txt_plc_IP1.Text, num_rack1.Value, num_slot1.Value)
        Result_plc2 = plc2_status_client.ConnectTo(txt_plc_IP2.Text, num_rack2.Value, num_slot2.Value)
        Show_plc_Result(Result_plc1, 11)
        Show_plc_Result(Result_plc2, 12)

        status_cycle = DateTime.Now.AddSeconds(num_status_time_settings.Value)
        fn_cursor_wait(False)
    End Sub


    Private Sub btn_stop_status_data_Click(sender As Object, e As EventArgs) Handles btn_stop_status_data.Click
        plc1_status_client.Disconnect()
        plc2_status_client.Disconnect()
    End Sub


    Private Sub btn_start_fail_data_Click(sender As Object, e As EventArgs) Handles btn_start_fault_data.Click
        Dim Result_plc1 As Integer
        Dim Result_plc2 As Integer
        fn_cursor_wait(True)
        Result_plc1 = plc1_fault_client.ConnectTo(txt_plc_IP1.Text, num_rack1.Value, num_slot1.Value)
        Result_plc2 = plc2_fault_client.ConnectTo(txt_plc_IP2.Text, num_rack2.Value, num_slot2.Value)
        Show_plc_Result(Result_plc1, 11)
        Show_plc_Result(Result_plc2, 12)

        fail_cycle = DateTime.Now.AddSeconds(num_fault_time_settings.Value)
        fn_cursor_wait(False)
    End Sub


    Private Sub btn_stop_fail_data_Click(sender As Object, e As EventArgs) Handles btn_stop_fault_data.Click
        plc1_fault_client.Disconnect()
        plc2_fault_client.Disconnect()
    End Sub


    Private Sub btn_clear_plc_dump_Click(sender As Object, e As EventArgs) Handles btn_clear_plc_dump.Click
        txt_plc_dump.Clear()
    End Sub



    Private Sub chb_enable_schleduler_CheckedChanged(sender As Object, e As EventArgs) Handles chb_enable_schleduler.CheckedChanged
        If chb_enable_schleduler.Checked = True Then
            dt_monitor_start_time.Enabled = True
            dt_monitor_stop_time.Enabled = True
        Else
            dt_monitor_start_time.Enabled = False
            dt_monitor_stop_time.Enabled = False
        End If
    End Sub



    'help
  


    Private Sub lbl_help_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lbl_help.LinkClicked
        System.Diagnostics.Process.Start(lbl_help.Text)
    End Sub
End Class
