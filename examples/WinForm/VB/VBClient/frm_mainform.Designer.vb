<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_mainform
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_mainform))
        Me.txt_result_box = New System.Windows.Forms.TextBox()
        Me.txt_plc_IP1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_plc_dump = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.tc_tabpages = New System.Windows.Forms.TabControl()
        Me.tp_data_transfer = New System.Windows.Forms.TabPage()
        Me.chb_sql_debbuger = New System.Windows.Forms.CheckBox()
        Me.lbl_debug_text_direction = New System.Windows.Forms.Label()
        Me.btn_clear_plc_dump = New System.Windows.Forms.Button()
        Me.p_fail_plc2 = New System.Windows.Forms.Panel()
        Me.lbl_fail_plc2 = New System.Windows.Forms.Label()
        Me.p_status_plc2 = New System.Windows.Forms.Panel()
        Me.lbl_status_plc2 = New System.Windows.Forms.Label()
        Me.chb_enable_data_logger = New System.Windows.Forms.CheckBox()
        Me.p_fail_plc1 = New System.Windows.Forms.Panel()
        Me.lbl_fail_plc1 = New System.Windows.Forms.Label()
        Me.p_status_plc1 = New System.Windows.Forms.Panel()
        Me.lbl_status_plc1 = New System.Windows.Forms.Label()
        Me.btn_stop_fault_data = New System.Windows.Forms.Button()
        Me.btn_start_fault_data = New System.Windows.Forms.Button()
        Me.btn_stop_status_data = New System.Windows.Forms.Button()
        Me.btn_start_status_data = New System.Windows.Forms.Button()
        Me.tp_data_settings = New System.Windows.Forms.TabPage()
        Me.btd_save_data_settings = New System.Windows.Forms.Button()
        Me.dgw_field_definitions = New System.Windows.Forms.DataGridView()
        Me.plc_no = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.db_no = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.db_start_bit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.db_type_length = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.byte_type = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.save_when = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.sql_table = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sql_fieldname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sql_specific = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tp_settings = New System.Windows.Forms.TabPage()
        Me.num_sql_timeout = New System.Windows.Forms.NumericUpDown()
        Me.lbl_supported_plc = New System.Windows.Forms.Label()
        Me.lbl_plc_part = New System.Windows.Forms.Label()
        Me.lbl_mssql_part = New System.Windows.Forms.Label()
        Me.lbl_time_interval = New System.Windows.Forms.Label()
        Me.lbl_password = New System.Windows.Forms.Label()
        Me.lbl_dn_name = New System.Windows.Forms.Label()
        Me.txt_db_password = New System.Windows.Forms.TextBox()
        Me.btn_mssql_test_connection = New System.Windows.Forms.Button()
        Me.txt_db_loginname = New System.Windows.Forms.TextBox()
        Me.txt_db_name = New System.Windows.Forms.TextBox()
        Me.lbl_db_name = New System.Windows.Forms.Label()
        Me.txt_serverSQL = New System.Windows.Forms.TextBox()
        Me.lbl_serverSQL = New System.Windows.Forms.Label()
        Me.txt_plc_IP2 = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lbl_help = New System.Windows.Forms.LinkLabel()
        Me.num_plc2_fault_db_size = New System.Windows.Forms.NumericUpDown()
        Me.num_slot2 = New System.Windows.Forms.NumericUpDown()
        Me.num_plc1_fault_db_size = New System.Windows.Forms.NumericUpDown()
        Me.num_rack2 = New System.Windows.Forms.NumericUpDown()
        Me.num_plc2_status_db_size = New System.Windows.Forms.NumericUpDown()
        Me.num_plc1_status_db_size = New System.Windows.Forms.NumericUpDown()
        Me.num_slot1 = New System.Windows.Forms.NumericUpDown()
        Me.lbl_plc2_db_size = New System.Windows.Forms.Label()
        Me.num_rack1 = New System.Windows.Forms.NumericUpDown()
        Me.lbl_plc1_db_size = New System.Windows.Forms.Label()
        Me.lbl_plc2_fault_db = New System.Windows.Forms.Label()
        Me.lbl_plc2_status_db = New System.Windows.Forms.Label()
        Me.num_plc2_fault_db = New System.Windows.Forms.NumericUpDown()
        Me.num_plc2_status_db = New System.Windows.Forms.NumericUpDown()
        Me.lbl_plc1_fault_db = New System.Windows.Forms.Label()
        Me.lbl_plc1_status_db = New System.Windows.Forms.Label()
        Me.num_plc1_fault_db = New System.Windows.Forms.NumericUpDown()
        Me.num_plc1_status_db = New System.Windows.Forms.NumericUpDown()
        Me.btn_plc1_test_connection = New System.Windows.Forms.Button()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.btn_plc2_test_connection = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.chb_enable_schleduler = New System.Windows.Forms.CheckBox()
        Me.lbl_monitor_stop_time = New System.Windows.Forms.Label()
        Me.dt_monitor_stop_time = New System.Windows.Forms.DateTimePicker()
        Me.lbl_monitor_start_time = New System.Windows.Forms.Label()
        Me.dt_monitor_start_time = New System.Windows.Forms.DateTimePicker()
        Me.num_fault_time_settings = New System.Windows.Forms.NumericUpDown()
        Me.lbl_fault_time_settings = New System.Windows.Forms.Label()
        Me.num_status_time_settings = New System.Windows.Forms.NumericUpDown()
        Me.lbl_status_time_setting = New System.Windows.Forms.Label()
        Me.lbl_time_part = New System.Windows.Forms.Label()
        Me.Timer = New System.Windows.Forms.Timer(Me.components)
        Me.ni_tray_menu = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.chb_status_communication_autorun = New System.Windows.Forms.CheckBox()
        Me.chb_fault_communication_autostart = New System.Windows.Forms.CheckBox()
        Me.tc_tabpages.SuspendLayout()
        Me.tp_data_transfer.SuspendLayout()
        Me.p_fail_plc2.SuspendLayout()
        Me.p_status_plc2.SuspendLayout()
        Me.p_fail_plc1.SuspendLayout()
        Me.p_status_plc1.SuspendLayout()
        Me.tp_data_settings.SuspendLayout()
        CType(Me.dgw_field_definitions, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tp_settings.SuspendLayout()
        CType(Me.num_sql_timeout, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.num_plc2_fault_db_size, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.num_slot2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.num_plc1_fault_db_size, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.num_rack2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.num_plc2_status_db_size, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.num_plc1_status_db_size, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.num_slot1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.num_rack1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.num_plc2_fault_db, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.num_plc2_status_db, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.num_plc1_fault_db, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.num_plc1_status_db, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.num_fault_time_settings, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.num_status_time_settings, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txt_result_box
        '
        Me.txt_result_box.BackColor = System.Drawing.Color.White
        Me.txt_result_box.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.txt_result_box.ForeColor = System.Drawing.Color.Black
        Me.txt_result_box.Location = New System.Drawing.Point(0, 382)
        Me.txt_result_box.Name = "txt_result_box"
        Me.txt_result_box.ReadOnly = True
        Me.txt_result_box.Size = New System.Drawing.Size(975, 20)
        Me.txt_result_box.TabIndex = 0
        '
        'txt_plc_IP1
        '
        Me.txt_plc_IP1.Location = New System.Drawing.Point(6, 41)
        Me.txt_plc_IP1.Name = "txt_plc_IP1"
        Me.txt_plc_IP1.Size = New System.Drawing.Size(100, 20)
        Me.txt_plc_IP1.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Gainsboro
        Me.Label1.Location = New System.Drawing.Point(7, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "IP address PLC1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Gainsboro
        Me.Label2.Location = New System.Drawing.Point(107, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(33, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Rack"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Gainsboro
        Me.Label3.Location = New System.Drawing.Point(107, 41)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(25, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Slot"
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Gainsboro
        Me.Label4.Location = New System.Drawing.Point(799, 29)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(38, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "S7300"
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Gainsboro
        Me.Label5.Location = New System.Drawing.Point(799, 55)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(73, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "S71200/1500"
        '
        'txt_plc_dump
        '
        Me.txt_plc_dump.BackColor = System.Drawing.Color.White
        Me.txt_plc_dump.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_plc_dump.ForeColor = System.Drawing.Color.Black
        Me.txt_plc_dump.Location = New System.Drawing.Point(320, 18)
        Me.txt_plc_dump.Multiline = True
        Me.txt_plc_dump.Name = "txt_plc_dump"
        Me.txt_plc_dump.ReadOnly = True
        Me.txt_plc_dump.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txt_plc_dump.Size = New System.Drawing.Size(644, 335)
        Me.txt_plc_dump.TabIndex = 35
        '
        'Label8
        '
        Me.Label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Gainsboro
        Me.Label8.Location = New System.Drawing.Point(799, 42)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(76, 13)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "S7400/WinAC"
        '
        'Label9
        '
        Me.Label9.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Gainsboro
        Me.Label9.Location = New System.Drawing.Point(881, 29)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(81, 13)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "Rack=0, Slot=2"
        '
        'Label10
        '
        Me.Label10.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Gainsboro
        Me.Label10.Location = New System.Drawing.Point(881, 42)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(81, 13)
        Me.Label10.TabIndex = 19
        Me.Label10.Text = "See HW Config"
        '
        'Label11
        '
        Me.Label11.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Gainsboro
        Me.Label11.Location = New System.Drawing.Point(881, 55)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(81, 13)
        Me.Label11.TabIndex = 20
        Me.Label11.Text = "Rack=0, Slot=0"
        '
        'tc_tabpages
        '
        Me.tc_tabpages.Controls.Add(Me.tp_data_transfer)
        Me.tc_tabpages.Controls.Add(Me.tp_data_settings)
        Me.tc_tabpages.Controls.Add(Me.tp_settings)
        Me.tc_tabpages.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tc_tabpages.Location = New System.Drawing.Point(0, 0)
        Me.tc_tabpages.Name = "tc_tabpages"
        Me.tc_tabpages.SelectedIndex = 0
        Me.tc_tabpages.Size = New System.Drawing.Size(975, 382)
        Me.tc_tabpages.TabIndex = 2
        '
        'tp_data_transfer
        '
        Me.tp_data_transfer.Controls.Add(Me.txt_plc_dump)
        Me.tp_data_transfer.Controls.Add(Me.chb_sql_debbuger)
        Me.tp_data_transfer.Controls.Add(Me.lbl_debug_text_direction)
        Me.tp_data_transfer.Controls.Add(Me.btn_clear_plc_dump)
        Me.tp_data_transfer.Controls.Add(Me.p_fail_plc2)
        Me.tp_data_transfer.Controls.Add(Me.p_status_plc2)
        Me.tp_data_transfer.Controls.Add(Me.chb_enable_data_logger)
        Me.tp_data_transfer.Controls.Add(Me.p_fail_plc1)
        Me.tp_data_transfer.Controls.Add(Me.p_status_plc1)
        Me.tp_data_transfer.Controls.Add(Me.btn_stop_fault_data)
        Me.tp_data_transfer.Controls.Add(Me.btn_start_fault_data)
        Me.tp_data_transfer.Controls.Add(Me.btn_stop_status_data)
        Me.tp_data_transfer.Controls.Add(Me.btn_start_status_data)
        Me.tp_data_transfer.Location = New System.Drawing.Point(4, 22)
        Me.tp_data_transfer.Name = "tp_data_transfer"
        Me.tp_data_transfer.Padding = New System.Windows.Forms.Padding(3)
        Me.tp_data_transfer.Size = New System.Drawing.Size(967, 356)
        Me.tp_data_transfer.TabIndex = 0
        Me.tp_data_transfer.Text = "Data Transfer"
        Me.tp_data_transfer.UseVisualStyleBackColor = True
        '
        'chb_sql_debbuger
        '
        Me.chb_sql_debbuger.AutoSize = True
        Me.chb_sql_debbuger.Location = New System.Drawing.Point(727, 1)
        Me.chb_sql_debbuger.Name = "chb_sql_debbuger"
        Me.chb_sql_debbuger.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.chb_sql_debbuger.Size = New System.Drawing.Size(97, 17)
        Me.chb_sql_debbuger.TabIndex = 401
        Me.chb_sql_debbuger.Text = "SQL Debbuger"
        Me.chb_sql_debbuger.UseVisualStyleBackColor = True
        '
        'lbl_debug_text_direction
        '
        Me.lbl_debug_text_direction.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lbl_debug_text_direction.Location = New System.Drawing.Point(302, 4)
        Me.lbl_debug_text_direction.Name = "lbl_debug_text_direction"
        Me.lbl_debug_text_direction.Size = New System.Drawing.Size(16, 277)
        Me.lbl_debug_text_direction.TabIndex = 36
        Me.lbl_debug_text_direction.Text = "NEW TO OLD "
        Me.lbl_debug_text_direction.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btn_clear_plc_dump
        '
        Me.btn_clear_plc_dump.BackgroundImage = Global.PLC_to_MSSQL.My.Resources.Resources.clear
        Me.btn_clear_plc_dump.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_clear_plc_dump.Location = New System.Drawing.Point(320, 0)
        Me.btn_clear_plc_dump.Name = "btn_clear_plc_dump"
        Me.btn_clear_plc_dump.Size = New System.Drawing.Size(20, 18)
        Me.btn_clear_plc_dump.TabIndex = 25
        Me.btn_clear_plc_dump.UseVisualStyleBackColor = True
        '
        'p_fail_plc2
        '
        Me.p_fail_plc2.BackColor = System.Drawing.Color.Red
        Me.p_fail_plc2.Controls.Add(Me.lbl_fail_plc2)
        Me.p_fail_plc2.Location = New System.Drawing.Point(122, 173)
        Me.p_fail_plc2.Name = "p_fail_plc2"
        Me.p_fail_plc2.Size = New System.Drawing.Size(32, 20)
        Me.p_fail_plc2.TabIndex = 23
        '
        'lbl_fail_plc2
        '
        Me.lbl_fail_plc2.AutoSize = True
        Me.lbl_fail_plc2.Location = New System.Drawing.Point(0, 3)
        Me.lbl_fail_plc2.Name = "lbl_fail_plc2"
        Me.lbl_fail_plc2.Size = New System.Drawing.Size(33, 13)
        Me.lbl_fail_plc2.TabIndex = 257
        Me.lbl_fail_plc2.Text = "PLC2"
        '
        'p_status_plc2
        '
        Me.p_status_plc2.BackColor = System.Drawing.Color.Red
        Me.p_status_plc2.Controls.Add(Me.lbl_status_plc2)
        Me.p_status_plc2.Location = New System.Drawing.Point(122, 64)
        Me.p_status_plc2.Name = "p_status_plc2"
        Me.p_status_plc2.Size = New System.Drawing.Size(32, 20)
        Me.p_status_plc2.TabIndex = 22
        '
        'lbl_status_plc2
        '
        Me.lbl_status_plc2.AutoSize = True
        Me.lbl_status_plc2.Location = New System.Drawing.Point(-1, 4)
        Me.lbl_status_plc2.Name = "lbl_status_plc2"
        Me.lbl_status_plc2.Size = New System.Drawing.Size(33, 13)
        Me.lbl_status_plc2.TabIndex = 258
        Me.lbl_status_plc2.Text = "PLC2"
        '
        'chb_enable_data_logger
        '
        Me.chb_enable_data_logger.AutoSize = True
        Me.chb_enable_data_logger.Location = New System.Drawing.Point(842, 1)
        Me.chb_enable_data_logger.Name = "chb_enable_data_logger"
        Me.chb_enable_data_logger.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.chb_enable_data_logger.Size = New System.Drawing.Size(121, 17)
        Me.chb_enable_data_logger.TabIndex = 30
        Me.chb_enable_data_logger.Text = "Enable Data Logger"
        Me.chb_enable_data_logger.UseVisualStyleBackColor = True
        '
        'p_fail_plc1
        '
        Me.p_fail_plc1.BackColor = System.Drawing.Color.Red
        Me.p_fail_plc1.Controls.Add(Me.lbl_fail_plc1)
        Me.p_fail_plc1.Location = New System.Drawing.Point(122, 147)
        Me.p_fail_plc1.Name = "p_fail_plc1"
        Me.p_fail_plc1.Size = New System.Drawing.Size(32, 20)
        Me.p_fail_plc1.TabIndex = 22
        Me.p_fail_plc1.Tag = ""
        '
        'lbl_fail_plc1
        '
        Me.lbl_fail_plc1.AutoSize = True
        Me.lbl_fail_plc1.Location = New System.Drawing.Point(0, 4)
        Me.lbl_fail_plc1.Name = "lbl_fail_plc1"
        Me.lbl_fail_plc1.Size = New System.Drawing.Size(33, 13)
        Me.lbl_fail_plc1.TabIndex = 256
        Me.lbl_fail_plc1.Text = "PLC1"
        '
        'p_status_plc1
        '
        Me.p_status_plc1.BackColor = System.Drawing.Color.Red
        Me.p_status_plc1.Controls.Add(Me.lbl_status_plc1)
        Me.p_status_plc1.Location = New System.Drawing.Point(122, 38)
        Me.p_status_plc1.Name = "p_status_plc1"
        Me.p_status_plc1.Size = New System.Drawing.Size(32, 20)
        Me.p_status_plc1.TabIndex = 21
        '
        'lbl_status_plc1
        '
        Me.lbl_status_plc1.AutoSize = True
        Me.lbl_status_plc1.Location = New System.Drawing.Point(0, 4)
        Me.lbl_status_plc1.Name = "lbl_status_plc1"
        Me.lbl_status_plc1.Size = New System.Drawing.Size(33, 13)
        Me.lbl_status_plc1.TabIndex = 255
        Me.lbl_status_plc1.Text = "PLC1"
        '
        'btn_stop_fault_data
        '
        Me.btn_stop_fault_data.Enabled = False
        Me.btn_stop_fault_data.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.btn_stop_fault_data.Location = New System.Drawing.Point(161, 126)
        Me.btn_stop_fault_data.Name = "btn_stop_fault_data"
        Me.btn_stop_fault_data.Size = New System.Drawing.Size(108, 85)
        Me.btn_stop_fault_data.TabIndex = 20
        Me.btn_stop_fault_data.Text = "STOP FAULT data transfer"
        Me.btn_stop_fault_data.UseVisualStyleBackColor = True
        '
        'btn_start_fault_data
        '
        Me.btn_start_fault_data.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.btn_start_fault_data.Location = New System.Drawing.Point(8, 126)
        Me.btn_start_fault_data.Name = "btn_start_fault_data"
        Me.btn_start_fault_data.Size = New System.Drawing.Size(108, 85)
        Me.btn_start_fault_data.TabIndex = 15
        Me.btn_start_fault_data.Text = "START FAULT data transfer"
        Me.btn_start_fault_data.UseVisualStyleBackColor = True
        '
        'btn_stop_status_data
        '
        Me.btn_stop_status_data.Enabled = False
        Me.btn_stop_status_data.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.btn_stop_status_data.Location = New System.Drawing.Point(161, 18)
        Me.btn_stop_status_data.Name = "btn_stop_status_data"
        Me.btn_stop_status_data.Size = New System.Drawing.Size(108, 85)
        Me.btn_stop_status_data.TabIndex = 10
        Me.btn_stop_status_data.Text = "STOP STATUS data transfer"
        Me.btn_stop_status_data.UseVisualStyleBackColor = True
        '
        'btn_start_status_data
        '
        Me.btn_start_status_data.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.btn_start_status_data.Location = New System.Drawing.Point(8, 18)
        Me.btn_start_status_data.Name = "btn_start_status_data"
        Me.btn_start_status_data.Size = New System.Drawing.Size(108, 85)
        Me.btn_start_status_data.TabIndex = 5
        Me.btn_start_status_data.Text = "START STATUS data transfer"
        Me.btn_start_status_data.UseVisualStyleBackColor = True
        '
        'tp_data_settings
        '
        Me.tp_data_settings.Controls.Add(Me.btd_save_data_settings)
        Me.tp_data_settings.Controls.Add(Me.dgw_field_definitions)
        Me.tp_data_settings.Location = New System.Drawing.Point(4, 22)
        Me.tp_data_settings.Name = "tp_data_settings"
        Me.tp_data_settings.Size = New System.Drawing.Size(967, 356)
        Me.tp_data_settings.TabIndex = 2
        Me.tp_data_settings.Text = "PLC-MSSQL"
        Me.tp_data_settings.UseVisualStyleBackColor = True
        '
        'btd_save_data_settings
        '
        Me.btd_save_data_settings.BackgroundImage = Global.PLC_to_MSSQL.My.Resources.Resources.save
        Me.btd_save_data_settings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btd_save_data_settings.Enabled = False
        Me.btd_save_data_settings.Location = New System.Drawing.Point(2, 2)
        Me.btd_save_data_settings.Name = "btd_save_data_settings"
        Me.btd_save_data_settings.Size = New System.Drawing.Size(23, 21)
        Me.btd_save_data_settings.TabIndex = 1
        Me.btd_save_data_settings.UseVisualStyleBackColor = True
        '
        'dgw_field_definitions
        '
        Me.dgw_field_definitions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgw_field_definitions.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.plc_no, Me.db_no, Me.db_start_bit, Me.db_type_length, Me.byte_type, Me.save_when, Me.sql_table, Me.sql_fieldname, Me.sql_specific})
        Me.dgw_field_definitions.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgw_field_definitions.Location = New System.Drawing.Point(0, 0)
        Me.dgw_field_definitions.MultiSelect = False
        Me.dgw_field_definitions.Name = "dgw_field_definitions"
        Me.dgw_field_definitions.RowHeadersWidth = 25
        Me.dgw_field_definitions.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgw_field_definitions.Size = New System.Drawing.Size(967, 356)
        Me.dgw_field_definitions.TabIndex = 0
        '
        'plc_no
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.Format = "N1"
        Me.plc_no.DefaultCellStyle = DataGridViewCellStyle1
        Me.plc_no.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox
        Me.plc_no.DisplayStyleForCurrentCellOnly = True
        Me.plc_no.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.plc_no.HeaderText = "PLC No"
        Me.plc_no.Items.AddRange(New Object() {"1", "2"})
        Me.plc_no.Name = "plc_no"
        Me.plc_no.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.plc_no.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.plc_no.ToolTipText = "Insert 1 or 2 for selected connection"
        Me.plc_no.Width = 50
        '
        'db_no
        '
        Me.db_no.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox
        Me.db_no.DisplayStyleForCurrentCellOnly = True
        Me.db_no.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.db_no.HeaderText = "Data Type"
        Me.db_no.Items.AddRange(New Object() {"fault", "status"})
        Me.db_no.Name = "db_no"
        Me.db_no.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.db_no.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.db_no.ToolTipText = "DB type for reading"
        Me.db_no.Width = 70
        '
        'db_start_bit
        '
        DataGridViewCellStyle2.Format = "N6"
        Me.db_start_bit.DefaultCellStyle = DataGridViewCellStyle2
        Me.db_start_bit.HeaderText = "DB Start bit"
        Me.db_start_bit.MaxInputLength = 6
        Me.db_start_bit.Name = "db_start_bit"
        Me.db_start_bit.ToolTipText = "First bit of value in DB"
        Me.db_start_bit.Width = 70
        '
        'db_type_length
        '
        DataGridViewCellStyle3.Format = "N6"
        Me.db_type_length.DefaultCellStyle = DataGridViewCellStyle3
        Me.db_type_length.HeaderText = "DB Field Length"
        Me.db_type_length.MaxInputLength = 6
        Me.db_type_length.Name = "db_type_length"
        Me.db_type_length.ToolTipText = "count of bits of value {1,16,32}"
        Me.db_type_length.Width = 90
        '
        'byte_type
        '
        Me.byte_type.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox
        Me.byte_type.DisplayStyleForCurrentCellOnly = True
        Me.byte_type.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.byte_type.HeaderText = "Byte Type"
        Me.byte_type.Items.AddRange(New Object() {"number", "char"})
        Me.byte_type.Name = "byte_type"
        Me.byte_type.Width = 70
        '
        'save_when
        '
        Me.save_when.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox
        Me.save_when.DisplayStyleForCurrentCellOnly = True
        Me.save_when.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.save_when.HeaderText = "Save When"
        Me.save_when.Items.AddRange(New Object() {"Always", "True", "False", "Never"})
        Me.save_when.Name = "save_when"
        Me.save_when.ToolTipText = "Save record when value is"
        Me.save_when.Width = 70
        '
        'sql_table
        '
        Me.sql_table.HeaderText = "SQL Table"
        Me.sql_table.MaxInputLength = 100
        Me.sql_table.Name = "sql_table"
        Me.sql_table.ToolTipText = "Target SQL table"
        '
        'sql_fieldname
        '
        Me.sql_fieldname.HeaderText = "SQL Field Name"
        Me.sql_fieldname.MaxInputLength = 100
        Me.sql_fieldname.Name = "sql_fieldname"
        Me.sql_fieldname.ToolTipText = "Target SQL column"
        Me.sql_fieldname.Width = 120
        '
        'sql_specific
        '
        Me.sql_specific.HeaderText = "SQL Spec Field Command"
        Me.sql_specific.Name = "sql_specific"
        Me.sql_specific.ToolTipText = "Specific SQL *SQL fieldname* from preview column will be replaced with value"
        Me.sql_specific.Width = 300
        '
        'tp_settings
        '
        Me.tp_settings.BackColor = System.Drawing.Color.Transparent
        Me.tp_settings.Controls.Add(Me.num_sql_timeout)
        Me.tp_settings.Controls.Add(Me.lbl_supported_plc)
        Me.tp_settings.Controls.Add(Me.lbl_plc_part)
        Me.tp_settings.Controls.Add(Me.lbl_mssql_part)
        Me.tp_settings.Controls.Add(Me.lbl_time_interval)
        Me.tp_settings.Controls.Add(Me.lbl_password)
        Me.tp_settings.Controls.Add(Me.lbl_dn_name)
        Me.tp_settings.Controls.Add(Me.txt_db_password)
        Me.tp_settings.Controls.Add(Me.btn_mssql_test_connection)
        Me.tp_settings.Controls.Add(Me.txt_db_loginname)
        Me.tp_settings.Controls.Add(Me.txt_db_name)
        Me.tp_settings.Controls.Add(Me.lbl_db_name)
        Me.tp_settings.Controls.Add(Me.txt_serverSQL)
        Me.tp_settings.Controls.Add(Me.lbl_serverSQL)
        Me.tp_settings.Controls.Add(Me.txt_plc_IP2)
        Me.tp_settings.Controls.Add(Me.Label12)
        Me.tp_settings.Controls.Add(Me.Label13)
        Me.tp_settings.Controls.Add(Me.txt_plc_IP1)
        Me.tp_settings.Controls.Add(Me.Label11)
        Me.tp_settings.Controls.Add(Me.Label1)
        Me.tp_settings.Controls.Add(Me.Label10)
        Me.tp_settings.Controls.Add(Me.Label9)
        Me.tp_settings.Controls.Add(Me.Label8)
        Me.tp_settings.Controls.Add(Me.Label4)
        Me.tp_settings.Controls.Add(Me.Label5)
        Me.tp_settings.Controls.Add(Me.Panel1)
        Me.tp_settings.Controls.Add(Me.Panel2)
        Me.tp_settings.Location = New System.Drawing.Point(4, 22)
        Me.tp_settings.Name = "tp_settings"
        Me.tp_settings.Padding = New System.Windows.Forms.Padding(3)
        Me.tp_settings.Size = New System.Drawing.Size(967, 356)
        Me.tp_settings.TabIndex = 1
        Me.tp_settings.Text = "Settings"
        '
        'num_sql_timeout
        '
        Me.num_sql_timeout.Location = New System.Drawing.Point(149, 201)
        Me.num_sql_timeout.Maximum = New Decimal(New Integer() {999, 0, 0, 0})
        Me.num_sql_timeout.Name = "num_sql_timeout"
        Me.num_sql_timeout.Size = New System.Drawing.Size(190, 20)
        Me.num_sql_timeout.TabIndex = 210
        Me.num_sql_timeout.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lbl_supported_plc
        '
        Me.lbl_supported_plc.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_supported_plc.AutoSize = True
        Me.lbl_supported_plc.BackColor = System.Drawing.Color.Gainsboro
        Me.lbl_supported_plc.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lbl_supported_plc.Location = New System.Drawing.Point(819, 7)
        Me.lbl_supported_plc.Name = "lbl_supported_plc"
        Me.lbl_supported_plc.Size = New System.Drawing.Size(131, 20)
        Me.lbl_supported_plc.TabIndex = 250
        Me.lbl_supported_plc.Text = "Supported PLC"
        '
        'lbl_plc_part
        '
        Me.lbl_plc_part.AutoSize = True
        Me.lbl_plc_part.BackColor = System.Drawing.Color.Gainsboro
        Me.lbl_plc_part.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lbl_plc_part.Location = New System.Drawing.Point(6, 5)
        Me.lbl_plc_part.Name = "lbl_plc_part"
        Me.lbl_plc_part.Size = New System.Drawing.Size(80, 20)
        Me.lbl_plc_part.TabIndex = 249
        Me.lbl_plc_part.Text = "PLC Part"
        '
        'lbl_mssql_part
        '
        Me.lbl_mssql_part.AutoSize = True
        Me.lbl_mssql_part.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lbl_mssql_part.Location = New System.Drawing.Point(6, 136)
        Me.lbl_mssql_part.Name = "lbl_mssql_part"
        Me.lbl_mssql_part.Size = New System.Drawing.Size(108, 20)
        Me.lbl_mssql_part.TabIndex = 248
        Me.lbl_mssql_part.Text = "MSSQL Part"
        '
        'lbl_time_interval
        '
        Me.lbl_time_interval.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lbl_time_interval.Location = New System.Drawing.Point(6, 205)
        Me.lbl_time_interval.Name = "lbl_time_interval"
        Me.lbl_time_interval.Size = New System.Drawing.Size(142, 16)
        Me.lbl_time_interval.TabIndex = 247
        Me.lbl_time_interval.Text = "SQL Timeout (sec):"
        Me.lbl_time_interval.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl_password
        '
        Me.lbl_password.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lbl_password.Location = New System.Drawing.Point(6, 249)
        Me.lbl_password.Name = "lbl_password"
        Me.lbl_password.Size = New System.Drawing.Size(142, 16)
        Me.lbl_password.TabIndex = 246
        Me.lbl_password.Text = "DB Login Password:"
        Me.lbl_password.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl_dn_name
        '
        Me.lbl_dn_name.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lbl_dn_name.Location = New System.Drawing.Point(6, 227)
        Me.lbl_dn_name.Name = "lbl_dn_name"
        Me.lbl_dn_name.Size = New System.Drawing.Size(142, 16)
        Me.lbl_dn_name.TabIndex = 245
        Me.lbl_dn_name.Text = "DB Login Name:"
        Me.lbl_dn_name.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_db_password
        '
        Me.txt_db_password.Location = New System.Drawing.Point(149, 245)
        Me.txt_db_password.Name = "txt_db_password"
        Me.txt_db_password.Size = New System.Drawing.Size(190, 20)
        Me.txt_db_password.TabIndex = 220
        Me.txt_db_password.UseSystemPasswordChar = True
        '
        'btn_mssql_test_connection
        '
        Me.btn_mssql_test_connection.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.btn_mssql_test_connection.Location = New System.Drawing.Point(242, 271)
        Me.btn_mssql_test_connection.Name = "btn_mssql_test_connection"
        Me.btn_mssql_test_connection.Size = New System.Drawing.Size(98, 23)
        Me.btn_mssql_test_connection.TabIndex = 225
        Me.btn_mssql_test_connection.Text = "Test Connection"
        Me.btn_mssql_test_connection.UseVisualStyleBackColor = True
        '
        'txt_db_loginname
        '
        Me.txt_db_loginname.Location = New System.Drawing.Point(149, 223)
        Me.txt_db_loginname.Name = "txt_db_loginname"
        Me.txt_db_loginname.Size = New System.Drawing.Size(190, 20)
        Me.txt_db_loginname.TabIndex = 215
        '
        'txt_db_name
        '
        Me.txt_db_name.Location = New System.Drawing.Point(149, 179)
        Me.txt_db_name.Name = "txt_db_name"
        Me.txt_db_name.Size = New System.Drawing.Size(190, 20)
        Me.txt_db_name.TabIndex = 205
        '
        'lbl_db_name
        '
        Me.lbl_db_name.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lbl_db_name.Location = New System.Drawing.Point(6, 183)
        Me.lbl_db_name.Name = "lbl_db_name"
        Me.lbl_db_name.Size = New System.Drawing.Size(142, 16)
        Me.lbl_db_name.TabIndex = 244
        Me.lbl_db_name.Text = "Database Name:"
        Me.lbl_db_name.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_serverSQL
        '
        Me.txt_serverSQL.Location = New System.Drawing.Point(149, 157)
        Me.txt_serverSQL.Name = "txt_serverSQL"
        Me.txt_serverSQL.Size = New System.Drawing.Size(190, 20)
        Me.txt_serverSQL.TabIndex = 200
        '
        'lbl_serverSQL
        '
        Me.lbl_serverSQL.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lbl_serverSQL.Location = New System.Drawing.Point(6, 161)
        Me.lbl_serverSQL.Name = "lbl_serverSQL"
        Me.lbl_serverSQL.Size = New System.Drawing.Size(142, 16)
        Me.lbl_serverSQL.TabIndex = 243
        Me.lbl_serverSQL.Text = "Server MSSQL:"
        Me.lbl_serverSQL.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_plc_IP2
        '
        Me.txt_plc_IP2.Location = New System.Drawing.Point(6, 101)
        Me.txt_plc_IP2.Name = "txt_plc_IP2"
        Me.txt_plc_IP2.Size = New System.Drawing.Size(100, 20)
        Me.txt_plc_IP2.TabIndex = 100
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Gainsboro
        Me.Label12.Location = New System.Drawing.Point(6, 84)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(86, 13)
        Me.Label12.TabIndex = 23
        Me.Label12.Text = "IP address PLC2"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Gainsboro
        Me.Label13.Location = New System.Drawing.Point(107, 84)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(33, 13)
        Me.Label13.TabIndex = 26
        Me.Label13.Text = "Rack"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Gainsboro
        Me.Panel1.Controls.Add(Me.lbl_help)
        Me.Panel1.Controls.Add(Me.num_plc2_fault_db_size)
        Me.Panel1.Controls.Add(Me.num_slot2)
        Me.Panel1.Controls.Add(Me.num_plc1_fault_db_size)
        Me.Panel1.Controls.Add(Me.num_rack2)
        Me.Panel1.Controls.Add(Me.num_plc2_status_db_size)
        Me.Panel1.Controls.Add(Me.num_plc1_status_db_size)
        Me.Panel1.Controls.Add(Me.num_slot1)
        Me.Panel1.Controls.Add(Me.lbl_plc2_db_size)
        Me.Panel1.Controls.Add(Me.num_rack1)
        Me.Panel1.Controls.Add(Me.lbl_plc1_db_size)
        Me.Panel1.Controls.Add(Me.lbl_plc2_fault_db)
        Me.Panel1.Controls.Add(Me.lbl_plc2_status_db)
        Me.Panel1.Controls.Add(Me.num_plc2_fault_db)
        Me.Panel1.Controls.Add(Me.num_plc2_status_db)
        Me.Panel1.Controls.Add(Me.lbl_plc1_fault_db)
        Me.Panel1.Controls.Add(Me.lbl_plc1_status_db)
        Me.Panel1.Controls.Add(Me.num_plc1_fault_db)
        Me.Panel1.Controls.Add(Me.num_plc1_status_db)
        Me.Panel1.Controls.Add(Me.btn_plc1_test_connection)
        Me.Panel1.Controls.Add(Me.Label14)
        Me.Panel1.Controls.Add(Me.btn_plc2_test_connection)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(961, 133)
        Me.Panel1.TabIndex = 258
        '
        'lbl_help
        '
        Me.lbl_help.Location = New System.Drawing.Point(654, 107)
        Me.lbl_help.Name = "lbl_help"
        Me.lbl_help.Size = New System.Drawing.Size(302, 19)
        Me.lbl_help.TabIndex = 269
        Me.lbl_help.TabStop = True
        Me.lbl_help.Tag = ""
        Me.lbl_help.Text = "http://plc-automatizace.cz/knihovna/data/data-typy-dat.htm"
        '
        'num_plc2_fault_db_size
        '
        Me.num_plc2_fault_db_size.Location = New System.Drawing.Point(336, 101)
        Me.num_plc2_fault_db_size.Maximum = New Decimal(New Integer() {999999, 0, 0, 0})
        Me.num_plc2_fault_db_size.Name = "num_plc2_fault_db_size"
        Me.num_plc2_fault_db_size.Size = New System.Drawing.Size(52, 20)
        Me.num_plc2_fault_db_size.TabIndex = 130
        Me.num_plc2_fault_db_size.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'num_slot2
        '
        Me.num_slot2.Location = New System.Drawing.Point(138, 101)
        Me.num_slot2.Name = "num_slot2"
        Me.num_slot2.Size = New System.Drawing.Size(44, 20)
        Me.num_slot2.TabIndex = 110
        Me.num_slot2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.num_slot2.Value = New Decimal(New Integer() {2, 0, 0, 0})
        '
        'num_plc1_fault_db_size
        '
        Me.num_plc1_fault_db_size.Location = New System.Drawing.Point(336, 41)
        Me.num_plc1_fault_db_size.Maximum = New Decimal(New Integer() {999999, 0, 0, 0})
        Me.num_plc1_fault_db_size.Name = "num_plc1_fault_db_size"
        Me.num_plc1_fault_db_size.Size = New System.Drawing.Size(52, 20)
        Me.num_plc1_fault_db_size.TabIndex = 35
        Me.num_plc1_fault_db_size.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'num_rack2
        '
        Me.num_rack2.Location = New System.Drawing.Point(138, 78)
        Me.num_rack2.Name = "num_rack2"
        Me.num_rack2.Size = New System.Drawing.Size(44, 20)
        Me.num_rack2.TabIndex = 105
        Me.num_rack2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'num_plc2_status_db_size
        '
        Me.num_plc2_status_db_size.Location = New System.Drawing.Point(336, 78)
        Me.num_plc2_status_db_size.Maximum = New Decimal(New Integer() {999999, 0, 0, 0})
        Me.num_plc2_status_db_size.Name = "num_plc2_status_db_size"
        Me.num_plc2_status_db_size.Size = New System.Drawing.Size(52, 20)
        Me.num_plc2_status_db_size.TabIndex = 125
        Me.num_plc2_status_db_size.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'num_plc1_status_db_size
        '
        Me.num_plc1_status_db_size.Location = New System.Drawing.Point(336, 19)
        Me.num_plc1_status_db_size.Maximum = New Decimal(New Integer() {999999, 0, 0, 0})
        Me.num_plc1_status_db_size.Name = "num_plc1_status_db_size"
        Me.num_plc1_status_db_size.Size = New System.Drawing.Size(52, 20)
        Me.num_plc1_status_db_size.TabIndex = 30
        Me.num_plc1_status_db_size.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'num_slot1
        '
        Me.num_slot1.Location = New System.Drawing.Point(138, 41)
        Me.num_slot1.Name = "num_slot1"
        Me.num_slot1.Size = New System.Drawing.Size(44, 20)
        Me.num_slot1.TabIndex = 15
        Me.num_slot1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.num_slot1.Value = New Decimal(New Integer() {2, 0, 0, 0})
        '
        'lbl_plc2_db_size
        '
        Me.lbl_plc2_db_size.BackColor = System.Drawing.Color.Gainsboro
        Me.lbl_plc2_db_size.Location = New System.Drawing.Point(322, 62)
        Me.lbl_plc2_db_size.Name = "lbl_plc2_db_size"
        Me.lbl_plc2_db_size.Size = New System.Drawing.Size(87, 16)
        Me.lbl_plc2_db_size.TabIndex = 268
        Me.lbl_plc2_db_size.Text = "DB Size (Bytes)"
        Me.lbl_plc2_db_size.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'num_rack1
        '
        Me.num_rack1.Location = New System.Drawing.Point(138, 19)
        Me.num_rack1.Name = "num_rack1"
        Me.num_rack1.Size = New System.Drawing.Size(44, 20)
        Me.num_rack1.TabIndex = 10
        Me.num_rack1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lbl_plc1_db_size
        '
        Me.lbl_plc1_db_size.BackColor = System.Drawing.Color.Gainsboro
        Me.lbl_plc1_db_size.Location = New System.Drawing.Point(322, 2)
        Me.lbl_plc1_db_size.Name = "lbl_plc1_db_size"
        Me.lbl_plc1_db_size.Size = New System.Drawing.Size(88, 17)
        Me.lbl_plc1_db_size.TabIndex = 267
        Me.lbl_plc1_db_size.Text = "DB Size (Bytes)"
        Me.lbl_plc1_db_size.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_plc2_fault_db
        '
        Me.lbl_plc2_fault_db.BackColor = System.Drawing.Color.Gainsboro
        Me.lbl_plc2_fault_db.Location = New System.Drawing.Point(184, 101)
        Me.lbl_plc2_fault_db.Name = "lbl_plc2_fault_db"
        Me.lbl_plc2_fault_db.Size = New System.Drawing.Size(55, 13)
        Me.lbl_plc2_fault_db.TabIndex = 266
        Me.lbl_plc2_fault_db.Text = "Fault DB"
        '
        'lbl_plc2_status_db
        '
        Me.lbl_plc2_status_db.BackColor = System.Drawing.Color.Gainsboro
        Me.lbl_plc2_status_db.Location = New System.Drawing.Point(184, 84)
        Me.lbl_plc2_status_db.Name = "lbl_plc2_status_db"
        Me.lbl_plc2_status_db.Size = New System.Drawing.Size(55, 13)
        Me.lbl_plc2_status_db.TabIndex = 263
        Me.lbl_plc2_status_db.Text = "Status DB"
        '
        'num_plc2_fault_db
        '
        Me.num_plc2_fault_db.Location = New System.Drawing.Point(245, 101)
        Me.num_plc2_fault_db.Maximum = New Decimal(New Integer() {999999, 0, 0, 0})
        Me.num_plc2_fault_db.Name = "num_plc2_fault_db"
        Me.num_plc2_fault_db.Size = New System.Drawing.Size(71, 20)
        Me.num_plc2_fault_db.TabIndex = 120
        Me.num_plc2_fault_db.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'num_plc2_status_db
        '
        Me.num_plc2_status_db.Location = New System.Drawing.Point(245, 78)
        Me.num_plc2_status_db.Maximum = New Decimal(New Integer() {999999, 0, 0, 0})
        Me.num_plc2_status_db.Name = "num_plc2_status_db"
        Me.num_plc2_status_db.Size = New System.Drawing.Size(71, 20)
        Me.num_plc2_status_db.TabIndex = 115
        Me.num_plc2_status_db.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lbl_plc1_fault_db
        '
        Me.lbl_plc1_fault_db.BackColor = System.Drawing.Color.Gainsboro
        Me.lbl_plc1_fault_db.Location = New System.Drawing.Point(184, 41)
        Me.lbl_plc1_fault_db.Name = "lbl_plc1_fault_db"
        Me.lbl_plc1_fault_db.Size = New System.Drawing.Size(55, 13)
        Me.lbl_plc1_fault_db.TabIndex = 262
        Me.lbl_plc1_fault_db.Text = "Fault DB"
        '
        'lbl_plc1_status_db
        '
        Me.lbl_plc1_status_db.BackColor = System.Drawing.Color.Gainsboro
        Me.lbl_plc1_status_db.Location = New System.Drawing.Point(184, 22)
        Me.lbl_plc1_status_db.Name = "lbl_plc1_status_db"
        Me.lbl_plc1_status_db.Size = New System.Drawing.Size(55, 13)
        Me.lbl_plc1_status_db.TabIndex = 260
        Me.lbl_plc1_status_db.Text = "Status DB"
        '
        'num_plc1_fault_db
        '
        Me.num_plc1_fault_db.Location = New System.Drawing.Point(245, 41)
        Me.num_plc1_fault_db.Maximum = New Decimal(New Integer() {999999, 0, 0, 0})
        Me.num_plc1_fault_db.Name = "num_plc1_fault_db"
        Me.num_plc1_fault_db.Size = New System.Drawing.Size(71, 20)
        Me.num_plc1_fault_db.TabIndex = 25
        Me.num_plc1_fault_db.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'num_plc1_status_db
        '
        Me.num_plc1_status_db.Location = New System.Drawing.Point(245, 19)
        Me.num_plc1_status_db.Maximum = New Decimal(New Integer() {999999, 0, 0, 0})
        Me.num_plc1_status_db.Name = "num_plc1_status_db"
        Me.num_plc1_status_db.Size = New System.Drawing.Size(71, 20)
        Me.num_plc1_status_db.TabIndex = 20
        Me.num_plc1_status_db.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btn_plc1_test_connection
        '
        Me.btn_plc1_test_connection.Location = New System.Drawing.Point(417, 4)
        Me.btn_plc1_test_connection.Name = "btn_plc1_test_connection"
        Me.btn_plc1_test_connection.Size = New System.Drawing.Size(76, 54)
        Me.btn_plc1_test_connection.TabIndex = 40
        Me.btn_plc1_test_connection.Text = "Test Connection"
        Me.btn_plc1_test_connection.UseVisualStyleBackColor = True
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Gainsboro
        Me.Label14.Location = New System.Drawing.Point(107, 101)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(25, 13)
        Me.Label14.TabIndex = 27
        Me.Label14.Text = "Slot"
        '
        'btn_plc2_test_connection
        '
        Me.btn_plc2_test_connection.Location = New System.Drawing.Point(417, 72)
        Me.btn_plc2_test_connection.Name = "btn_plc2_test_connection"
        Me.btn_plc2_test_connection.Size = New System.Drawing.Size(76, 54)
        Me.btn_plc2_test_connection.TabIndex = 135
        Me.btn_plc2_test_connection.Text = "Test Connection"
        Me.btn_plc2_test_connection.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Silver
        Me.Panel2.Controls.Add(Me.chb_fault_communication_autostart)
        Me.Panel2.Controls.Add(Me.chb_status_communication_autorun)
        Me.Panel2.Controls.Add(Me.chb_enable_schleduler)
        Me.Panel2.Controls.Add(Me.lbl_monitor_stop_time)
        Me.Panel2.Controls.Add(Me.dt_monitor_stop_time)
        Me.Panel2.Controls.Add(Me.lbl_monitor_start_time)
        Me.Panel2.Controls.Add(Me.dt_monitor_start_time)
        Me.Panel2.Controls.Add(Me.num_fault_time_settings)
        Me.Panel2.Controls.Add(Me.lbl_fault_time_settings)
        Me.Panel2.Controls.Add(Me.num_status_time_settings)
        Me.Panel2.Controls.Add(Me.lbl_status_time_setting)
        Me.Panel2.Controls.Add(Me.lbl_time_part)
        Me.Panel2.Location = New System.Drawing.Point(508, 136)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(456, 220)
        Me.Panel2.TabIndex = 259
        '
        'chb_enable_schleduler
        '
        Me.chb_enable_schleduler.AutoSize = True
        Me.chb_enable_schleduler.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.chb_enable_schleduler.Location = New System.Drawing.Point(9, 87)
        Me.chb_enable_schleduler.Name = "chb_enable_schleduler"
        Me.chb_enable_schleduler.Size = New System.Drawing.Size(170, 24)
        Me.chb_enable_schleduler.TabIndex = 401
        Me.chb_enable_schleduler.Text = "Enable Scheduler"
        Me.chb_enable_schleduler.UseVisualStyleBackColor = True
        '
        'lbl_monitor_stop_time
        '
        Me.lbl_monitor_stop_time.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lbl_monitor_stop_time.Location = New System.Drawing.Point(14, 139)
        Me.lbl_monitor_stop_time.Name = "lbl_monitor_stop_time"
        Me.lbl_monitor_stop_time.Size = New System.Drawing.Size(144, 16)
        Me.lbl_monitor_stop_time.TabIndex = 309
        Me.lbl_monitor_stop_time.Text = "Stop Monitoring Time:"
        Me.lbl_monitor_stop_time.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'dt_monitor_stop_time
        '
        Me.dt_monitor_stop_time.Enabled = False
        Me.dt_monitor_stop_time.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.dt_monitor_stop_time.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dt_monitor_stop_time.Location = New System.Drawing.Point(182, 136)
        Me.dt_monitor_stop_time.Name = "dt_monitor_stop_time"
        Me.dt_monitor_stop_time.ShowUpDown = True
        Me.dt_monitor_stop_time.Size = New System.Drawing.Size(136, 22)
        Me.dt_monitor_stop_time.TabIndex = 308
        Me.dt_monitor_stop_time.Value = New Date(2018, 4, 23, 7, 22, 0, 0)
        '
        'lbl_monitor_start_time
        '
        Me.lbl_monitor_start_time.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lbl_monitor_start_time.Location = New System.Drawing.Point(13, 115)
        Me.lbl_monitor_start_time.Name = "lbl_monitor_start_time"
        Me.lbl_monitor_start_time.Size = New System.Drawing.Size(144, 16)
        Me.lbl_monitor_start_time.TabIndex = 307
        Me.lbl_monitor_start_time.Text = "Start Monitoring Time:"
        Me.lbl_monitor_start_time.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'dt_monitor_start_time
        '
        Me.dt_monitor_start_time.Enabled = False
        Me.dt_monitor_start_time.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.dt_monitor_start_time.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dt_monitor_start_time.Location = New System.Drawing.Point(182, 112)
        Me.dt_monitor_start_time.Name = "dt_monitor_start_time"
        Me.dt_monitor_start_time.ShowUpDown = True
        Me.dt_monitor_start_time.Size = New System.Drawing.Size(136, 22)
        Me.dt_monitor_start_time.TabIndex = 306
        Me.dt_monitor_start_time.Value = New Date(2018, 4, 23, 7, 22, 0, 0)
        '
        'num_fault_time_settings
        '
        Me.num_fault_time_settings.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.num_fault_time_settings.Location = New System.Drawing.Point(174, 48)
        Me.num_fault_time_settings.Maximum = New Decimal(New Integer() {999, 0, 0, 0})
        Me.num_fault_time_settings.Name = "num_fault_time_settings"
        Me.num_fault_time_settings.Size = New System.Drawing.Size(136, 22)
        Me.num_fault_time_settings.TabIndex = 305
        Me.num_fault_time_settings.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lbl_fault_time_settings
        '
        Me.lbl_fault_time_settings.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lbl_fault_time_settings.Location = New System.Drawing.Point(5, 51)
        Me.lbl_fault_time_settings.Name = "lbl_fault_time_settings"
        Me.lbl_fault_time_settings.Size = New System.Drawing.Size(144, 16)
        Me.lbl_fault_time_settings.TabIndex = 262
        Me.lbl_fault_time_settings.Text = "Fault Time (sec):"
        Me.lbl_fault_time_settings.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'num_status_time_settings
        '
        Me.num_status_time_settings.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.num_status_time_settings.Location = New System.Drawing.Point(174, 25)
        Me.num_status_time_settings.Maximum = New Decimal(New Integer() {999, 0, 0, 0})
        Me.num_status_time_settings.Name = "num_status_time_settings"
        Me.num_status_time_settings.Size = New System.Drawing.Size(136, 22)
        Me.num_status_time_settings.TabIndex = 300
        Me.num_status_time_settings.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lbl_status_time_setting
        '
        Me.lbl_status_time_setting.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lbl_status_time_setting.Location = New System.Drawing.Point(6, 28)
        Me.lbl_status_time_setting.Name = "lbl_status_time_setting"
        Me.lbl_status_time_setting.Size = New System.Drawing.Size(144, 16)
        Me.lbl_status_time_setting.TabIndex = 260
        Me.lbl_status_time_setting.Text = "Status Time (sec):"
        Me.lbl_status_time_setting.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl_time_part
        '
        Me.lbl_time_part.AutoSize = True
        Me.lbl_time_part.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lbl_time_part.Location = New System.Drawing.Point(3, 3)
        Me.lbl_time_part.Name = "lbl_time_part"
        Me.lbl_time_part.Size = New System.Drawing.Size(85, 20)
        Me.lbl_time_part.TabIndex = 257
        Me.lbl_time_part.Text = "Time Part"
        '
        'Timer
        '
        Me.Timer.Enabled = True
        '
        'ni_tray_menu
        '
        Me.ni_tray_menu.Icon = CType(resources.GetObject("ni_tray_menu.Icon"), System.Drawing.Icon)
        Me.ni_tray_menu.Text = "PLC ->MSSQL DATA Loader"
        Me.ni_tray_menu.Visible = True
        '
        'chb_status_communication_autorun
        '
        Me.chb_status_communication_autorun.AutoSize = True
        Me.chb_status_communication_autorun.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.chb_status_communication_autorun.Location = New System.Drawing.Point(9, 170)
        Me.chb_status_communication_autorun.Name = "chb_status_communication_autorun"
        Me.chb_status_communication_autorun.Size = New System.Drawing.Size(259, 24)
        Me.chb_status_communication_autorun.TabIndex = 402
        Me.chb_status_communication_autorun.Text = "Status Communication Autostart"
        Me.chb_status_communication_autorun.UseVisualStyleBackColor = True
        '
        'chb_fault_communication_autostart
        '
        Me.chb_fault_communication_autostart.AutoSize = True
        Me.chb_fault_communication_autostart.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.chb_fault_communication_autostart.Location = New System.Drawing.Point(9, 190)
        Me.chb_fault_communication_autostart.Name = "chb_fault_communication_autostart"
        Me.chb_fault_communication_autostart.Size = New System.Drawing.Size(248, 24)
        Me.chb_fault_communication_autostart.TabIndex = 403
        Me.chb_fault_communication_autostart.Text = "Fault Communication Autostart"
        Me.chb_fault_communication_autostart.UseVisualStyleBackColor = True
        '
        'frm_mainform
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(975, 402)
        Me.Controls.Add(Me.tc_tabpages)
        Me.Controls.Add(Me.txt_result_box)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frm_mainform"
        Me.ShowInTaskbar = False
        Me.Text = "PLC->MSSQL DATA Loader"
        Me.TopMost = True
        Me.tc_tabpages.ResumeLayout(False)
        Me.tp_data_transfer.ResumeLayout(False)
        Me.tp_data_transfer.PerformLayout()
        Me.p_fail_plc2.ResumeLayout(False)
        Me.p_fail_plc2.PerformLayout()
        Me.p_status_plc2.ResumeLayout(False)
        Me.p_status_plc2.PerformLayout()
        Me.p_fail_plc1.ResumeLayout(False)
        Me.p_fail_plc1.PerformLayout()
        Me.p_status_plc1.ResumeLayout(False)
        Me.p_status_plc1.PerformLayout()
        Me.tp_data_settings.ResumeLayout(False)
        CType(Me.dgw_field_definitions, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tp_settings.ResumeLayout(False)
        Me.tp_settings.PerformLayout()
        CType(Me.num_sql_timeout, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.num_plc2_fault_db_size, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.num_slot2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.num_plc1_fault_db_size, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.num_rack2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.num_plc2_status_db_size, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.num_plc1_status_db_size, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.num_slot1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.num_rack1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.num_plc2_fault_db, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.num_plc2_status_db, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.num_plc1_fault_db, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.num_plc1_status_db, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.num_fault_time_settings, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.num_status_time_settings, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txt_result_box As System.Windows.Forms.TextBox
    Friend WithEvents txt_plc_IP1 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txt_plc_dump As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents tc_tabpages As System.Windows.Forms.TabControl
    Friend WithEvents tp_data_transfer As System.Windows.Forms.TabPage
    Friend WithEvents tp_settings As System.Windows.Forms.TabPage
    Friend WithEvents tp_data_settings As System.Windows.Forms.TabPage
    Friend WithEvents btn_plc2_test_connection As System.Windows.Forms.Button
    Friend WithEvents txt_plc_IP2 As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents btn_plc1_test_connection As System.Windows.Forms.Button
    Friend WithEvents dgw_field_definitions As System.Windows.Forms.DataGridView
    Friend WithEvents lbl_supported_plc As System.Windows.Forms.Label
    Friend WithEvents lbl_plc_part As System.Windows.Forms.Label
    Friend WithEvents lbl_mssql_part As System.Windows.Forms.Label
    Friend WithEvents lbl_time_interval As System.Windows.Forms.Label
    Friend WithEvents lbl_password As System.Windows.Forms.Label
    Friend WithEvents lbl_dn_name As System.Windows.Forms.Label
    Friend WithEvents txt_db_password As System.Windows.Forms.TextBox
    Friend WithEvents btn_mssql_test_connection As System.Windows.Forms.Button
    Friend WithEvents txt_db_name As System.Windows.Forms.TextBox
    Friend WithEvents lbl_db_name As System.Windows.Forms.Label
    Friend WithEvents txt_serverSQL As System.Windows.Forms.TextBox
    Friend WithEvents lbl_serverSQL As System.Windows.Forms.Label
    Friend WithEvents num_sql_timeout As System.Windows.Forms.NumericUpDown
    Friend WithEvents txt_db_loginname As System.Windows.Forms.TextBox
    Friend WithEvents num_rack1 As System.Windows.Forms.NumericUpDown
    Friend WithEvents num_slot1 As System.Windows.Forms.NumericUpDown
    Friend WithEvents num_slot2 As System.Windows.Forms.NumericUpDown
    Friend WithEvents num_rack2 As System.Windows.Forms.NumericUpDown
    Friend WithEvents Timer As System.Windows.Forms.Timer
    Friend WithEvents btd_save_data_settings As System.Windows.Forms.Button
    Friend WithEvents ni_tray_menu As System.Windows.Forms.NotifyIcon
    Friend WithEvents btn_start_status_data As System.Windows.Forms.Button
    Friend WithEvents lbl_time_part As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents num_status_time_settings As System.Windows.Forms.NumericUpDown
    Friend WithEvents lbl_status_time_setting As System.Windows.Forms.Label
    Friend WithEvents num_fault_time_settings As System.Windows.Forms.NumericUpDown
    Friend WithEvents lbl_fault_time_settings As System.Windows.Forms.Label
    Friend WithEvents lbl_plc2_fault_db As System.Windows.Forms.Label
    Friend WithEvents lbl_plc2_status_db As System.Windows.Forms.Label
    Friend WithEvents num_plc2_fault_db As System.Windows.Forms.NumericUpDown
    Friend WithEvents num_plc2_status_db As System.Windows.Forms.NumericUpDown
    Friend WithEvents lbl_plc1_fault_db As System.Windows.Forms.Label
    Friend WithEvents lbl_plc1_status_db As System.Windows.Forms.Label
    Friend WithEvents num_plc1_fault_db As System.Windows.Forms.NumericUpDown
    Friend WithEvents num_plc1_status_db As System.Windows.Forms.NumericUpDown
    Friend WithEvents p_fail_plc1 As System.Windows.Forms.Panel
    Friend WithEvents p_status_plc1 As System.Windows.Forms.Panel
    Friend WithEvents btn_stop_fault_data As System.Windows.Forms.Button
    Friend WithEvents btn_start_fault_data As System.Windows.Forms.Button
    Friend WithEvents btn_stop_status_data As System.Windows.Forms.Button
    Friend WithEvents num_plc2_status_db_size As System.Windows.Forms.NumericUpDown
    Friend WithEvents num_plc1_status_db_size As System.Windows.Forms.NumericUpDown
    Friend WithEvents lbl_plc2_db_size As System.Windows.Forms.Label
    Friend WithEvents lbl_plc1_db_size As System.Windows.Forms.Label
    Friend WithEvents chb_enable_data_logger As System.Windows.Forms.CheckBox
    Friend WithEvents p_fail_plc2 As System.Windows.Forms.Panel
    Friend WithEvents lbl_fail_plc2 As System.Windows.Forms.Label
    Friend WithEvents p_status_plc2 As System.Windows.Forms.Panel
    Friend WithEvents lbl_status_plc2 As System.Windows.Forms.Label
    Friend WithEvents lbl_fail_plc1 As System.Windows.Forms.Label
    Friend WithEvents lbl_status_plc1 As System.Windows.Forms.Label
    Friend WithEvents num_plc1_fault_db_size As System.Windows.Forms.NumericUpDown
    Friend WithEvents num_plc2_fault_db_size As System.Windows.Forms.NumericUpDown
    Friend WithEvents btn_clear_plc_dump As System.Windows.Forms.Button
    Friend WithEvents lbl_monitor_start_time As System.Windows.Forms.Label
    Friend WithEvents dt_monitor_start_time As System.Windows.Forms.DateTimePicker
    Friend WithEvents chb_enable_schleduler As System.Windows.Forms.CheckBox
    Friend WithEvents lbl_monitor_stop_time As System.Windows.Forms.Label
    Friend WithEvents dt_monitor_stop_time As System.Windows.Forms.DateTimePicker
    Friend WithEvents lbl_debug_text_direction As System.Windows.Forms.Label
    Friend WithEvents chb_sql_debbuger As System.Windows.Forms.CheckBox
    Friend WithEvents plc_no As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents db_no As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents db_start_bit As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents db_type_length As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents byte_type As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents save_when As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents sql_table As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents sql_fieldname As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents sql_specific As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lbl_help As System.Windows.Forms.LinkLabel
    Friend WithEvents chb_fault_communication_autostart As System.Windows.Forms.CheckBox
    Friend WithEvents chb_status_communication_autorun As System.Windows.Forms.CheckBox

End Class
