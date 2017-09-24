<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AdminDashboard
    Inherits MaterialSkin.Controls.MaterialForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.mtcAdminDashboard = New MaterialSkin.Controls.MaterialTabControl()
        Me.tabExaminee = New System.Windows.Forms.TabPage()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.MaterialDivider6 = New MaterialSkin.Controls.MaterialDivider()
        Me.rbNoResultFilter = New System.Windows.Forms.RadioButton()
        Me.rbFailedFilter = New System.Windows.Forms.RadioButton()
        Me.rbPassedFilter = New System.Windows.Forms.RadioButton()
        Me.chkDateFilter = New System.Windows.Forms.CheckBox()
        Me.dtpToFilter = New System.Windows.Forms.DateTimePicker()
        Me.dtpFromFilter = New System.Windows.Forms.DateTimePicker()
        Me.btnSearch = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.btnClearFilter = New MaterialSkin.Controls.MaterialFlatButton()
        Me.cboPositionFilter = New System.Windows.Forms.ComboBox()
        Me.cboLevelFilter = New System.Windows.Forms.ComboBox()
        Me.Label44 = New System.Windows.Forms.Label()
        Me.Label42 = New System.Windows.Forms.Label()
        Me.Label46 = New System.Windows.Forms.Label()
        Me.Label45 = New System.Windows.Forms.Label()
        Me.Label43 = New System.Windows.Forms.Label()
        Me.Label47 = New System.Windows.Forms.Label()
        Me.txtFirstNameFilter = New System.Windows.Forms.TextBox()
        Me.txtLastNameFilter = New System.Windows.Forms.TextBox()
        Me.Label48 = New System.Windows.Forms.Label()
        Me.btnChangePicture = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.cboExamineeSet = New System.Windows.Forms.ComboBox()
        Me.btnExportToExcel = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.MaterialDivider5 = New MaterialSkin.Controls.MaterialDivider()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.btnRefreshExamineeDgv = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.btnPrintExamineeDgv = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.picExaminee = New System.Windows.Forms.PictureBox()
        Me.lblExamineeCount = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.lblExamineeError = New System.Windows.Forms.Label()
        Me.picExamineeError = New System.Windows.Forms.PictureBox()
        Me.dgvExaminee = New System.Windows.Forms.DataGridView()
        Me.cmsPrintExaminee = New MaterialSkin.Controls.MaterialContextMenuStrip()
        Me.tsmPrintExaminee = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnExamineeClear = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.btnExamineeEdit = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.btnExamineeRegister = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.lblExamineeID = New System.Windows.Forms.Label()
        Me.cboExamineePosition = New System.Windows.Forms.ComboBox()
        Me.cboExamineeLevel = New System.Windows.Forms.ComboBox()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.tabExam = New System.Windows.Forms.TabPage()
        Me.MaterialDivider3 = New MaterialSkin.Controls.MaterialDivider()
        Me.lblExamSet = New System.Windows.Forms.Label()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.cboExamSet = New System.Windows.Forms.ComboBox()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.lblExamError = New System.Windows.Forms.Label()
        Me.lblKindID = New System.Windows.Forms.Label()
        Me.lblExamLevelID = New System.Windows.Forms.Label()
        Me.lblExamTypeID = New System.Windows.Forms.Label()
        Me.lblQuestionID = New System.Windows.Forms.Label()
        Me.btnExamClear = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.btnQuestionDelete = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.btnQuestionSave = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.txtChoice4 = New System.Windows.Forms.TextBox()
        Me.txtChoice3 = New System.Windows.Forms.TextBox()
        Me.txtChoice2 = New System.Windows.Forms.TextBox()
        Me.txtChoice1 = New System.Windows.Forms.TextBox()
        Me.rbChoice4 = New MaterialSkin.Controls.MaterialRadioButton()
        Me.rbChoice3 = New MaterialSkin.Controls.MaterialRadioButton()
        Me.rbChoice2 = New MaterialSkin.Controls.MaterialRadioButton()
        Me.rbChoice1 = New MaterialSkin.Controls.MaterialRadioButton()
        Me.tscQuestion = New System.Windows.Forms.ToolStripContainer()
        Me.rtfQuestion = New System.Windows.Forms.RichTextBox()
        Me.tsQuestion = New System.Windows.Forms.ToolStrip()
        Me.tsbInsertImage = New System.Windows.Forms.ToolStripButton()
        Me.tslInsertImage = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbChangeFont = New System.Windows.Forms.ToolStripButton()
        Me.tslChangeFont = New System.Windows.Forms.ToolStripLabel()
        Me.dgvExam = New System.Windows.Forms.DataGridView()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblQuestionCounter = New System.Windows.Forms.Label()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cboExamType = New System.Windows.Forms.ComboBox()
        Me.cboExamLevel = New System.Windows.Forms.ComboBox()
        Me.picExamError = New System.Windows.Forms.PictureBox()
        Me.tabConfiguration = New System.Windows.Forms.TabPage()
        Me.dgvTempo = New System.Windows.Forms.DataGridView()
        Me.btnTempoAdd = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.btnTempoDelete = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.txtTempoPass = New System.Windows.Forms.TextBox()
        Me.txtTempoUser = New System.Windows.Forms.TextBox()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.Label41 = New System.Windows.Forms.Label()
        Me.chkShowPassword = New MaterialSkin.Controls.MaterialCheckBox()
        Me.btnChangePassword = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.txtNewPassword = New System.Windows.Forms.TextBox()
        Me.txtCurrentPassword = New System.Windows.Forms.TextBox()
        Me.btnRestore = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.btnBrowse = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.txtClericalVerbalTime = New System.Windows.Forms.TextBox()
        Me.txtAbstractReasoningTime = New System.Windows.Forms.TextBox()
        Me.txtNonSupervisoryVerbalTime = New System.Windows.Forms.TextBox()
        Me.txtClericalNumericalTime = New System.Windows.Forms.TextBox()
        Me.txtSupervisoryVerbalTime = New System.Windows.Forms.TextBox()
        Me.txtClericalReasoningTime = New System.Windows.Forms.TextBox()
        Me.txtGeneralInfoTime = New System.Windows.Forms.TextBox()
        Me.txtNonSupervisoryNumericalTime = New System.Windows.Forms.TextBox()
        Me.txtReadingComprehensionTime = New System.Windows.Forms.TextBox()
        Me.txtSupervisoryNumericalTime = New System.Windows.Forms.TextBox()
        Me.txtManagementTime = New System.Windows.Forms.TextBox()
        Me.MaterialDivider2 = New MaterialSkin.Controls.MaterialDivider()
        Me.MaterialDivider1 = New MaterialSkin.Controls.MaterialDivider()
        Me.btnTimerSave = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.lblLastRestore = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.lblLastBackup = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.mtsAdminDashboard = New MaterialSkin.Controls.MaterialTabSelector()
        Me.sfdBackup = New System.Windows.Forms.SaveFileDialog()
        Me.ofdRestore = New System.Windows.Forms.OpenFileDialog()
        Me.btnBackLogin = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.btnUserManual = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.fdChangeFont = New System.Windows.Forms.FontDialog()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.MaterialDivider4 = New MaterialSkin.Controls.MaterialDivider()
        Me.sfdExcel = New System.Windows.Forms.SaveFileDialog()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.mtcAdminDashboard.SuspendLayout()
        Me.tabExaminee.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.picExaminee, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picExamineeError, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvExaminee, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cmsPrintExaminee.SuspendLayout()
        Me.tabExam.SuspendLayout()
        Me.tscQuestion.ContentPanel.SuspendLayout()
        Me.tscQuestion.TopToolStripPanel.SuspendLayout()
        Me.tscQuestion.SuspendLayout()
        Me.tsQuestion.SuspendLayout()
        CType(Me.dgvExam, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picExamError, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabConfiguration.SuspendLayout()
        CType(Me.dgvTempo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(233, 81)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Examinee ID:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(243, 107)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 16)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "First Name:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(245, 135)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 16)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Last Name:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(231, 193)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(88, 16)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Position Title:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(246, 162)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(73, 16)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Level Title:"
        '
        'txtFirstName
        '
        Me.txtFirstName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFirstName.Location = New System.Drawing.Point(326, 106)
        Me.txtFirstName.MaxLength = 50
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(294, 22)
        Me.txtFirstName.TabIndex = 0
        '
        'txtLastName
        '
        Me.txtLastName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLastName.Location = New System.Drawing.Point(326, 134)
        Me.txtLastName.MaxLength = 50
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(294, 22)
        Me.txtLastName.TabIndex = 1
        '
        'mtcAdminDashboard
        '
        Me.mtcAdminDashboard.Controls.Add(Me.tabExaminee)
        Me.mtcAdminDashboard.Controls.Add(Me.tabExam)
        Me.mtcAdminDashboard.Controls.Add(Me.tabConfiguration)
        Me.mtcAdminDashboard.Depth = 0
        Me.mtcAdminDashboard.Location = New System.Drawing.Point(12, 207)
        Me.mtcAdminDashboard.MouseState = MaterialSkin.MouseState.HOVER
        Me.mtcAdminDashboard.Name = "mtcAdminDashboard"
        Me.mtcAdminDashboard.SelectedIndex = 0
        Me.mtcAdminDashboard.Size = New System.Drawing.Size(1256, 549)
        Me.mtcAdminDashboard.TabIndex = 0
        '
        'tabExaminee
        '
        Me.tabExaminee.BackColor = System.Drawing.Color.WhiteSmoke
        Me.tabExaminee.Controls.Add(Me.GroupBox1)
        Me.tabExaminee.Controls.Add(Me.btnChangePicture)
        Me.tabExaminee.Controls.Add(Me.cboExamineeSet)
        Me.tabExaminee.Controls.Add(Me.btnExportToExcel)
        Me.tabExaminee.Controls.Add(Me.MaterialDivider5)
        Me.tabExaminee.Controls.Add(Me.Label34)
        Me.tabExaminee.Controls.Add(Me.btnRefreshExamineeDgv)
        Me.tabExaminee.Controls.Add(Me.btnPrintExamineeDgv)
        Me.tabExaminee.Controls.Add(Me.picExaminee)
        Me.tabExaminee.Controls.Add(Me.lblExamineeCount)
        Me.tabExaminee.Controls.Add(Me.Label30)
        Me.tabExaminee.Controls.Add(Me.lblExamineeError)
        Me.tabExaminee.Controls.Add(Me.picExamineeError)
        Me.tabExaminee.Controls.Add(Me.dgvExaminee)
        Me.tabExaminee.Controls.Add(Me.btnExamineeClear)
        Me.tabExaminee.Controls.Add(Me.btnExamineeEdit)
        Me.tabExaminee.Controls.Add(Me.btnExamineeRegister)
        Me.tabExaminee.Controls.Add(Me.lblExamineeID)
        Me.tabExaminee.Controls.Add(Me.cboExamineePosition)
        Me.tabExaminee.Controls.Add(Me.cboExamineeLevel)
        Me.tabExaminee.Controls.Add(Me.Label1)
        Me.tabExaminee.Controls.Add(Me.txtLastName)
        Me.tabExaminee.Controls.Add(Me.Label2)
        Me.tabExaminee.Controls.Add(Me.txtFirstName)
        Me.tabExaminee.Controls.Add(Me.Label3)
        Me.tabExaminee.Controls.Add(Me.Label38)
        Me.tabExaminee.Controls.Add(Me.Label4)
        Me.tabExaminee.Controls.Add(Me.Label5)
        Me.tabExaminee.Location = New System.Drawing.Point(4, 22)
        Me.tabExaminee.Name = "tabExaminee"
        Me.tabExaminee.Padding = New System.Windows.Forms.Padding(3)
        Me.tabExaminee.Size = New System.Drawing.Size(1248, 523)
        Me.tabExaminee.TabIndex = 0
        Me.tabExaminee.Text = "Examinee"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.MaterialDivider6)
        Me.GroupBox1.Controls.Add(Me.rbNoResultFilter)
        Me.GroupBox1.Controls.Add(Me.rbFailedFilter)
        Me.GroupBox1.Controls.Add(Me.rbPassedFilter)
        Me.GroupBox1.Controls.Add(Me.chkDateFilter)
        Me.GroupBox1.Controls.Add(Me.dtpToFilter)
        Me.GroupBox1.Controls.Add(Me.dtpFromFilter)
        Me.GroupBox1.Controls.Add(Me.btnSearch)
        Me.GroupBox1.Controls.Add(Me.btnClearFilter)
        Me.GroupBox1.Controls.Add(Me.cboPositionFilter)
        Me.GroupBox1.Controls.Add(Me.cboLevelFilter)
        Me.GroupBox1.Controls.Add(Me.Label44)
        Me.GroupBox1.Controls.Add(Me.Label42)
        Me.GroupBox1.Controls.Add(Me.Label46)
        Me.GroupBox1.Controls.Add(Me.Label45)
        Me.GroupBox1.Controls.Add(Me.Label43)
        Me.GroupBox1.Controls.Add(Me.Label47)
        Me.GroupBox1.Controls.Add(Me.txtFirstNameFilter)
        Me.GroupBox1.Controls.Add(Me.txtLastNameFilter)
        Me.GroupBox1.Controls.Add(Me.Label48)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(822, 13)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(404, 244)
        Me.GroupBox1.TabIndex = 17
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Search Filters"
        '
        'MaterialDivider6
        '
        Me.MaterialDivider6.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialDivider6.Depth = 0
        Me.MaterialDivider6.Location = New System.Drawing.Point(120, 151)
        Me.MaterialDivider6.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialDivider6.Name = "MaterialDivider6"
        Me.MaterialDivider6.Size = New System.Drawing.Size(1, 45)
        Me.MaterialDivider6.TabIndex = 19
        Me.MaterialDivider6.Text = "MaterialDivider6"
        '
        'rbNoResultFilter
        '
        Me.rbNoResultFilter.AutoSize = True
        Me.rbNoResultFilter.Location = New System.Drawing.Point(247, 70)
        Me.rbNoResultFilter.Name = "rbNoResultFilter"
        Me.rbNoResultFilter.Size = New System.Drawing.Size(81, 17)
        Me.rbNoResultFilter.TabIndex = 6
        Me.rbNoResultFilter.TabStop = True
        Me.rbNoResultFilter.Text = "No Result"
        Me.rbNoResultFilter.UseVisualStyleBackColor = True
        '
        'rbFailedFilter
        '
        Me.rbFailedFilter.AutoSize = True
        Me.rbFailedFilter.Location = New System.Drawing.Point(188, 70)
        Me.rbFailedFilter.Name = "rbFailedFilter"
        Me.rbFailedFilter.Size = New System.Drawing.Size(59, 17)
        Me.rbFailedFilter.TabIndex = 6
        Me.rbFailedFilter.TabStop = True
        Me.rbFailedFilter.Text = "Failed"
        Me.rbFailedFilter.UseVisualStyleBackColor = True
        '
        'rbPassedFilter
        '
        Me.rbPassedFilter.AutoSize = True
        Me.rbPassedFilter.Location = New System.Drawing.Point(120, 70)
        Me.rbPassedFilter.Name = "rbPassedFilter"
        Me.rbPassedFilter.Size = New System.Drawing.Size(66, 17)
        Me.rbPassedFilter.TabIndex = 6
        Me.rbPassedFilter.TabStop = True
        Me.rbPassedFilter.Text = "Passed"
        Me.rbPassedFilter.UseVisualStyleBackColor = True
        '
        'chkDateFilter
        '
        Me.chkDateFilter.AutoSize = True
        Me.chkDateFilter.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkDateFilter.Location = New System.Drawing.Point(56, 152)
        Me.chkDateFilter.Name = "chkDateFilter"
        Me.chkDateFilter.Size = New System.Drawing.Size(60, 19)
        Me.chkDateFilter.TabIndex = 5
        Me.chkDateFilter.Text = "DATE:"
        Me.chkDateFilter.UseVisualStyleBackColor = True
        '
        'dtpToFilter
        '
        Me.dtpToFilter.Location = New System.Drawing.Point(173, 176)
        Me.dtpToFilter.Name = "dtpToFilter"
        Me.dtpToFilter.Size = New System.Drawing.Size(207, 20)
        Me.dtpToFilter.TabIndex = 4
        '
        'dtpFromFilter
        '
        Me.dtpFromFilter.Location = New System.Drawing.Point(173, 148)
        Me.dtpFromFilter.Name = "dtpFromFilter"
        Me.dtpFromFilter.Size = New System.Drawing.Size(207, 20)
        Me.dtpFromFilter.TabIndex = 4
        '
        'btnSearch
        '
        Me.btnSearch.Depth = 0
        Me.btnSearch.Location = New System.Drawing.Point(298, 206)
        Me.btnSearch.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Primary = True
        Me.btnSearch.Size = New System.Drawing.Size(82, 28)
        Me.btnSearch.TabIndex = 3
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'btnClearFilter
        '
        Me.btnClearFilter.AutoSize = True
        Me.btnClearFilter.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnClearFilter.Depth = 0
        Me.btnClearFilter.Location = New System.Drawing.Point(7, 198)
        Me.btnClearFilter.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnClearFilter.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnClearFilter.Name = "btnClearFilter"
        Me.btnClearFilter.Primary = False
        Me.btnClearFilter.Size = New System.Drawing.Size(109, 36)
        Me.btnClearFilter.TabIndex = 2
        Me.btnClearFilter.Text = "Clear Filters"
        Me.btnClearFilter.UseVisualStyleBackColor = True
        '
        'cboPositionFilter
        '
        Me.cboPositionFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPositionFilter.FormattingEnabled = True
        Me.cboPositionFilter.Location = New System.Drawing.Point(120, 119)
        Me.cboPositionFilter.Name = "cboPositionFilter"
        Me.cboPositionFilter.Size = New System.Drawing.Size(260, 21)
        Me.cboPositionFilter.TabIndex = 1
        '
        'cboLevelFilter
        '
        Me.cboLevelFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboLevelFilter.FormattingEnabled = True
        Me.cboLevelFilter.Location = New System.Drawing.Point(120, 93)
        Me.cboLevelFilter.Name = "cboLevelFilter"
        Me.cboLevelFilter.Size = New System.Drawing.Size(260, 21)
        Me.cboLevelFilter.TabIndex = 1
        '
        'Label44
        '
        Me.Label44.AutoSize = True
        Me.Label44.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label44.Location = New System.Drawing.Point(69, 70)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(45, 15)
        Me.Label44.TabIndex = 0
        Me.Label44.Text = "Result:"
        '
        'Label42
        '
        Me.Label42.AutoSize = True
        Me.Label42.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label42.Location = New System.Drawing.Point(49, 96)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(65, 15)
        Me.Label42.TabIndex = 0
        Me.Label42.Text = "Level Title:"
        '
        'Label46
        '
        Me.Label46.AutoSize = True
        Me.Label46.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label46.Location = New System.Drawing.Point(124, 153)
        Me.Label46.Name = "Label46"
        Me.Label46.Size = New System.Drawing.Size(43, 15)
        Me.Label46.TabIndex = 0
        Me.Label46.Text = "FROM"
        '
        'Label45
        '
        Me.Label45.AutoSize = True
        Me.Label45.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label45.Location = New System.Drawing.Point(144, 178)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(23, 15)
        Me.Label45.TabIndex = 0
        Me.Label45.Text = "TO"
        '
        'Label43
        '
        Me.Label43.AutoSize = True
        Me.Label43.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label43.Location = New System.Drawing.Point(34, 122)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(80, 15)
        Me.Label43.TabIndex = 0
        Me.Label43.Text = "Position Title:"
        '
        'Label47
        '
        Me.Label47.AutoSize = True
        Me.Label47.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label47.Location = New System.Drawing.Point(44, 21)
        Me.Label47.Name = "Label47"
        Me.Label47.Size = New System.Drawing.Size(70, 15)
        Me.Label47.TabIndex = 0
        Me.Label47.Text = "First Name:"
        '
        'txtFirstNameFilter
        '
        Me.txtFirstNameFilter.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFirstNameFilter.Location = New System.Drawing.Point(120, 18)
        Me.txtFirstNameFilter.MaxLength = 50
        Me.txtFirstNameFilter.Name = "txtFirstNameFilter"
        Me.txtFirstNameFilter.Size = New System.Drawing.Size(260, 22)
        Me.txtFirstNameFilter.TabIndex = 0
        '
        'txtLastNameFilter
        '
        Me.txtLastNameFilter.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLastNameFilter.Location = New System.Drawing.Point(120, 44)
        Me.txtLastNameFilter.MaxLength = 50
        Me.txtLastNameFilter.Name = "txtLastNameFilter"
        Me.txtLastNameFilter.Size = New System.Drawing.Size(260, 22)
        Me.txtLastNameFilter.TabIndex = 1
        '
        'Label48
        '
        Me.Label48.AutoSize = True
        Me.Label48.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label48.Location = New System.Drawing.Point(44, 47)
        Me.Label48.Name = "Label48"
        Me.Label48.Size = New System.Drawing.Size(70, 15)
        Me.Label48.TabIndex = 0
        Me.Label48.Text = "Last Name:"
        '
        'btnChangePicture
        '
        Me.btnChangePicture.Depth = 0
        Me.btnChangePicture.Location = New System.Drawing.Point(88, 195)
        Me.btnChangePicture.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnChangePicture.Name = "btnChangePicture"
        Me.btnChangePicture.Primary = True
        Me.btnChangePicture.Size = New System.Drawing.Size(120, 26)
        Me.btnChangePicture.TabIndex = 16
        Me.btnChangePicture.Text = "Change Picture"
        Me.btnChangePicture.UseVisualStyleBackColor = True
        Me.btnChangePicture.Visible = False
        '
        'cboExamineeSet
        '
        Me.cboExamineeSet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboExamineeSet.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboExamineeSet.FormattingEnabled = True
        Me.cboExamineeSet.Location = New System.Drawing.Point(158, 260)
        Me.cboExamineeSet.Name = "cboExamineeSet"
        Me.cboExamineeSet.Size = New System.Drawing.Size(50, 24)
        Me.cboExamineeSet.TabIndex = 15
        '
        'btnExportToExcel
        '
        Me.btnExportToExcel.Depth = 0
        Me.btnExportToExcel.Location = New System.Drawing.Point(1085, 491)
        Me.btnExportToExcel.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnExportToExcel.Name = "btnExportToExcel"
        Me.btnExportToExcel.Primary = True
        Me.btnExportToExcel.Size = New System.Drawing.Size(157, 23)
        Me.btnExportToExcel.TabIndex = 14
        Me.btnExportToExcel.Text = "Export to excel"
        Me.btnExportToExcel.UseVisualStyleBackColor = True
        '
        'MaterialDivider5
        '
        Me.MaterialDivider5.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialDivider5.Depth = 0
        Me.MaterialDivider5.Location = New System.Drawing.Point(19, 255)
        Me.MaterialDivider5.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialDivider5.Name = "MaterialDivider5"
        Me.MaterialDivider5.Size = New System.Drawing.Size(1207, 1)
        Me.MaterialDivider5.TabIndex = 13
        Me.MaterialDivider5.Text = "MaterialDivider5"
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Location = New System.Drawing.Point(633, 86)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(170, 13)
        Me.Label34.TabIndex = 12
        Me.Label34.Text = "Register Button behind Edit Button"
        Me.Label34.Visible = False
        '
        'btnRefreshExamineeDgv
        '
        Me.btnRefreshExamineeDgv.Depth = 0
        Me.btnRefreshExamineeDgv.Location = New System.Drawing.Point(791, 491)
        Me.btnRefreshExamineeDgv.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnRefreshExamineeDgv.Name = "btnRefreshExamineeDgv"
        Me.btnRefreshExamineeDgv.Primary = True
        Me.btnRefreshExamineeDgv.Size = New System.Drawing.Size(141, 23)
        Me.btnRefreshExamineeDgv.TabIndex = 11
        Me.btnRefreshExamineeDgv.Text = "Refresh Table"
        Me.btnRefreshExamineeDgv.UseVisualStyleBackColor = True
        '
        'btnPrintExamineeDgv
        '
        Me.btnPrintExamineeDgv.Depth = 0
        Me.btnPrintExamineeDgv.Location = New System.Drawing.Point(938, 491)
        Me.btnPrintExamineeDgv.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnPrintExamineeDgv.Name = "btnPrintExamineeDgv"
        Me.btnPrintExamineeDgv.Primary = True
        Me.btnPrintExamineeDgv.Size = New System.Drawing.Size(141, 23)
        Me.btnPrintExamineeDgv.TabIndex = 10
        Me.btnPrintExamineeDgv.Text = "Print Table"
        Me.btnPrintExamineeDgv.UseVisualStyleBackColor = True
        '
        'picExaminee
        '
        Me.picExaminee.BackColor = System.Drawing.Color.DimGray
        Me.picExaminee.Image = Global.PQE.My.Resources.Resources.NoExamineePic
        Me.picExaminee.Location = New System.Drawing.Point(88, 72)
        Me.picExaminee.Name = "picExaminee"
        Me.picExaminee.Size = New System.Drawing.Size(120, 120)
        Me.picExaminee.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picExaminee.TabIndex = 9
        Me.picExaminee.TabStop = False
        '
        'lblExamineeCount
        '
        Me.lblExamineeCount.AutoSize = True
        Me.lblExamineeCount.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblExamineeCount.Location = New System.Drawing.Point(1137, 266)
        Me.lblExamineeCount.Name = "lblExamineeCount"
        Me.lblExamineeCount.Size = New System.Drawing.Size(105, 16)
        Me.lblExamineeCount.TabIndex = 8
        Me.lblExamineeCount.Text = "Examinee Count"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.Location = New System.Drawing.Point(990, 266)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(141, 16)
        Me.Label30.TabIndex = 7
        Me.Label30.Text = "Registered Examinee:"
        '
        'lblExamineeError
        '
        Me.lblExamineeError.AutoSize = True
        Me.lblExamineeError.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblExamineeError.Location = New System.Drawing.Point(692, 67)
        Me.lblExamineeError.Name = "lblExamineeError"
        Me.lblExamineeError.Size = New System.Drawing.Size(97, 16)
        Me.lblExamineeError.TabIndex = 7
        Me.lblExamineeError.Text = "Error Message"
        Me.lblExamineeError.Visible = False
        '
        'picExamineeError
        '
        Me.picExamineeError.Image = Global.PQE.My.Resources.Resources.error1
        Me.picExamineeError.Location = New System.Drawing.Point(636, 50)
        Me.picExamineeError.Name = "picExamineeError"
        Me.picExamineeError.Size = New System.Drawing.Size(50, 50)
        Me.picExamineeError.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picExamineeError.TabIndex = 6
        Me.picExamineeError.TabStop = False
        Me.picExamineeError.Visible = False
        '
        'dgvExaminee
        '
        Me.dgvExaminee.AllowUserToAddRows = False
        Me.dgvExaminee.AllowUserToDeleteRows = False
        Me.dgvExaminee.AllowUserToResizeColumns = False
        Me.dgvExaminee.AllowUserToResizeRows = False
        Me.dgvExaminee.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvExaminee.BackgroundColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.MenuHighlight
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvExaminee.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvExaminee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvExaminee.ContextMenuStrip = Me.cmsPrintExaminee
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvExaminee.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvExaminee.EnableHeadersVisualStyles = False
        Me.dgvExaminee.GridColor = System.Drawing.SystemColors.MenuBar
        Me.dgvExaminee.Location = New System.Drawing.Point(6, 289)
        Me.dgvExaminee.Name = "dgvExaminee"
        Me.dgvExaminee.ReadOnly = True
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.MenuHighlight
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvExaminee.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvExaminee.RowHeadersVisible = False
        Me.dgvExaminee.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvExaminee.Size = New System.Drawing.Size(1236, 196)
        Me.dgvExaminee.TabIndex = 5
        '
        'cmsPrintExaminee
        '
        Me.cmsPrintExaminee.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmsPrintExaminee.Depth = 0
        Me.cmsPrintExaminee.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmPrintExaminee})
        Me.cmsPrintExaminee.MouseState = MaterialSkin.MouseState.HOVER
        Me.cmsPrintExaminee.Name = "cmsPrintExaminee"
        Me.cmsPrintExaminee.Size = New System.Drawing.Size(153, 26)
        '
        'tsmPrintExaminee
        '
        Me.tsmPrintExaminee.Name = "tsmPrintExaminee"
        Me.tsmPrintExaminee.Size = New System.Drawing.Size(152, 22)
        Me.tsmPrintExaminee.Text = "Print Examinee"
        '
        'btnExamineeClear
        '
        Me.btnExamineeClear.Depth = 0
        Me.btnExamineeClear.Location = New System.Drawing.Point(636, 168)
        Me.btnExamineeClear.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnExamineeClear.Name = "btnExamineeClear"
        Me.btnExamineeClear.Primary = True
        Me.btnExamineeClear.Size = New System.Drawing.Size(130, 44)
        Me.btnExamineeClear.TabIndex = 4
        Me.btnExamineeClear.Text = "Clear Fields"
        Me.btnExamineeClear.UseVisualStyleBackColor = True
        '
        'btnExamineeEdit
        '
        Me.btnExamineeEdit.Depth = 0
        Me.btnExamineeEdit.Location = New System.Drawing.Point(636, 115)
        Me.btnExamineeEdit.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnExamineeEdit.Name = "btnExamineeEdit"
        Me.btnExamineeEdit.Primary = True
        Me.btnExamineeEdit.Size = New System.Drawing.Size(130, 44)
        Me.btnExamineeEdit.TabIndex = 4
        Me.btnExamineeEdit.Text = "Edit"
        Me.btnExamineeEdit.UseVisualStyleBackColor = True
        '
        'btnExamineeRegister
        '
        Me.btnExamineeRegister.Depth = 0
        Me.btnExamineeRegister.Location = New System.Drawing.Point(636, 114)
        Me.btnExamineeRegister.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnExamineeRegister.Name = "btnExamineeRegister"
        Me.btnExamineeRegister.Primary = True
        Me.btnExamineeRegister.Size = New System.Drawing.Size(130, 44)
        Me.btnExamineeRegister.TabIndex = 4
        Me.btnExamineeRegister.Text = "Register"
        Me.btnExamineeRegister.UseVisualStyleBackColor = True
        '
        'lblExamineeID
        '
        Me.lblExamineeID.AutoSize = True
        Me.lblExamineeID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblExamineeID.Location = New System.Drawing.Point(326, 80)
        Me.lblExamineeID.Name = "lblExamineeID"
        Me.lblExamineeID.Size = New System.Drawing.Size(95, 16)
        Me.lblExamineeID.TabIndex = 3
        Me.lblExamineeID.Text = "Examinee ID"
        '
        'cboExamineePosition
        '
        Me.cboExamineePosition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboExamineePosition.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboExamineePosition.FormattingEnabled = True
        Me.cboExamineePosition.Location = New System.Drawing.Point(326, 192)
        Me.cboExamineePosition.Name = "cboExamineePosition"
        Me.cboExamineePosition.Size = New System.Drawing.Size(294, 24)
        Me.cboExamineePosition.TabIndex = 3
        '
        'cboExamineeLevel
        '
        Me.cboExamineeLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboExamineeLevel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboExamineeLevel.FormattingEnabled = True
        Me.cboExamineeLevel.Location = New System.Drawing.Point(326, 162)
        Me.cboExamineeLevel.Name = "cboExamineeLevel"
        Me.cboExamineeLevel.Size = New System.Drawing.Size(294, 24)
        Me.cboExamineeLevel.TabIndex = 2
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label38.Location = New System.Drawing.Point(58, 264)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(94, 16)
        Me.Label38.TabIndex = 0
        Me.Label38.Text = "Examinee Set:"
        '
        'tabExam
        '
        Me.tabExam.BackColor = System.Drawing.Color.WhiteSmoke
        Me.tabExam.Controls.Add(Me.MaterialDivider3)
        Me.tabExam.Controls.Add(Me.lblExamSet)
        Me.tabExam.Controls.Add(Me.Label37)
        Me.tabExam.Controls.Add(Me.cboExamSet)
        Me.tabExam.Controls.Add(Me.txtSearch)
        Me.tabExam.Controls.Add(Me.lblExamError)
        Me.tabExam.Controls.Add(Me.lblKindID)
        Me.tabExam.Controls.Add(Me.lblExamLevelID)
        Me.tabExam.Controls.Add(Me.lblExamTypeID)
        Me.tabExam.Controls.Add(Me.lblQuestionID)
        Me.tabExam.Controls.Add(Me.btnExamClear)
        Me.tabExam.Controls.Add(Me.btnQuestionDelete)
        Me.tabExam.Controls.Add(Me.btnQuestionSave)
        Me.tabExam.Controls.Add(Me.txtChoice4)
        Me.tabExam.Controls.Add(Me.txtChoice3)
        Me.tabExam.Controls.Add(Me.txtChoice2)
        Me.tabExam.Controls.Add(Me.txtChoice1)
        Me.tabExam.Controls.Add(Me.rbChoice4)
        Me.tabExam.Controls.Add(Me.rbChoice3)
        Me.tabExam.Controls.Add(Me.rbChoice2)
        Me.tabExam.Controls.Add(Me.rbChoice1)
        Me.tabExam.Controls.Add(Me.tscQuestion)
        Me.tabExam.Controls.Add(Me.dgvExam)
        Me.tabExam.Controls.Add(Me.Label35)
        Me.tabExam.Controls.Add(Me.Label8)
        Me.tabExam.Controls.Add(Me.lblQuestionCounter)
        Me.tabExam.Controls.Add(Me.Label36)
        Me.tabExam.Controls.Add(Me.Label7)
        Me.tabExam.Controls.Add(Me.Label6)
        Me.tabExam.Controls.Add(Me.cboExamType)
        Me.tabExam.Controls.Add(Me.cboExamLevel)
        Me.tabExam.Controls.Add(Me.picExamError)
        Me.tabExam.Location = New System.Drawing.Point(4, 22)
        Me.tabExam.Name = "tabExam"
        Me.tabExam.Padding = New System.Windows.Forms.Padding(3)
        Me.tabExam.Size = New System.Drawing.Size(1248, 523)
        Me.tabExam.TabIndex = 1
        Me.tabExam.Text = "Exam"
        '
        'MaterialDivider3
        '
        Me.MaterialDivider3.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialDivider3.Depth = 0
        Me.MaterialDivider3.Location = New System.Drawing.Point(168, 17)
        Me.MaterialDivider3.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialDivider3.Name = "MaterialDivider3"
        Me.MaterialDivider3.Size = New System.Drawing.Size(2, 50)
        Me.MaterialDivider3.TabIndex = 18
        Me.MaterialDivider3.Text = "MaterialDivider3"
        '
        'lblExamSet
        '
        Me.lblExamSet.AutoSize = True
        Me.lblExamSet.Location = New System.Drawing.Point(1031, 21)
        Me.lblExamSet.Name = "lblExamSet"
        Me.lblExamSet.Size = New System.Drawing.Size(37, 13)
        Me.lblExamSet.TabIndex = 17
        Me.lblExamSet.Text = "Set ID"
        Me.lblExamSet.Visible = False
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label37.Location = New System.Drawing.Point(34, 18)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(68, 16)
        Me.Label37.TabIndex = 16
        Me.Label37.Text = "Exam Set:"
        '
        'cboExamSet
        '
        Me.cboExamSet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboExamSet.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboExamSet.FormattingEnabled = True
        Me.cboExamSet.Location = New System.Drawing.Point(108, 14)
        Me.cboExamSet.Name = "cboExamSet"
        Me.cboExamSet.Size = New System.Drawing.Size(50, 24)
        Me.cboExamSet.TabIndex = 0
        '
        'txtSearch
        '
        Me.txtSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.Location = New System.Drawing.Point(1122, 87)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(122, 22)
        Me.txtSearch.TabIndex = 14
        '
        'lblExamError
        '
        Me.lblExamError.AutoSize = True
        Me.lblExamError.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblExamError.Location = New System.Drawing.Point(821, 39)
        Me.lblExamError.Name = "lblExamError"
        Me.lblExamError.Size = New System.Drawing.Size(97, 16)
        Me.lblExamError.TabIndex = 13
        Me.lblExamError.Text = "Error Message"
        Me.lblExamError.Visible = False
        '
        'lblKindID
        '
        Me.lblKindID.AutoSize = True
        Me.lblKindID.Location = New System.Drawing.Point(1087, 42)
        Me.lblKindID.Name = "lblKindID"
        Me.lblKindID.Size = New System.Drawing.Size(42, 13)
        Me.lblKindID.TabIndex = 11
        Me.lblKindID.Text = "Kind ID"
        Me.lblKindID.Visible = False
        '
        'lblExamLevelID
        '
        Me.lblExamLevelID.AutoSize = True
        Me.lblExamLevelID.Location = New System.Drawing.Point(1087, 20)
        Me.lblExamLevelID.Name = "lblExamLevelID"
        Me.lblExamLevelID.Size = New System.Drawing.Size(62, 13)
        Me.lblExamLevelID.TabIndex = 11
        Me.lblExamLevelID.Text = "Exam Level"
        Me.lblExamLevelID.Visible = False
        '
        'lblExamTypeID
        '
        Me.lblExamTypeID.AutoSize = True
        Me.lblExamTypeID.Location = New System.Drawing.Point(1160, 20)
        Me.lblExamTypeID.Name = "lblExamTypeID"
        Me.lblExamTypeID.Size = New System.Drawing.Size(60, 13)
        Me.lblExamTypeID.TabIndex = 11
        Me.lblExamTypeID.Text = "Exam Type"
        Me.lblExamTypeID.Visible = False
        '
        'lblQuestionID
        '
        Me.lblQuestionID.AutoSize = True
        Me.lblQuestionID.Location = New System.Drawing.Point(1160, 42)
        Me.lblQuestionID.Name = "lblQuestionID"
        Me.lblQuestionID.Size = New System.Drawing.Size(63, 13)
        Me.lblQuestionID.TabIndex = 11
        Me.lblQuestionID.Text = "Question ID"
        Me.lblQuestionID.Visible = False
        '
        'btnExamClear
        '
        Me.btnExamClear.Depth = 0
        Me.btnExamClear.Location = New System.Drawing.Point(834, 484)
        Me.btnExamClear.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnExamClear.Name = "btnExamClear"
        Me.btnExamClear.Primary = True
        Me.btnExamClear.Size = New System.Drawing.Size(208, 32)
        Me.btnExamClear.TabIndex = 10
        Me.btnExamClear.Text = "Clear Fields"
        Me.btnExamClear.UseVisualStyleBackColor = True
        '
        'btnQuestionDelete
        '
        Me.btnQuestionDelete.Depth = 0
        Me.btnQuestionDelete.Location = New System.Drawing.Point(834, 446)
        Me.btnQuestionDelete.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnQuestionDelete.Name = "btnQuestionDelete"
        Me.btnQuestionDelete.Primary = True
        Me.btnQuestionDelete.Size = New System.Drawing.Size(208, 32)
        Me.btnQuestionDelete.TabIndex = 10
        Me.btnQuestionDelete.Text = "Delete Question"
        Me.btnQuestionDelete.UseVisualStyleBackColor = True
        '
        'btnQuestionSave
        '
        Me.btnQuestionSave.Depth = 0
        Me.btnQuestionSave.Location = New System.Drawing.Point(834, 410)
        Me.btnQuestionSave.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnQuestionSave.Name = "btnQuestionSave"
        Me.btnQuestionSave.Primary = True
        Me.btnQuestionSave.Size = New System.Drawing.Size(208, 32)
        Me.btnQuestionSave.TabIndex = 10
        Me.btnQuestionSave.Text = "Save Question"
        Me.btnQuestionSave.UseVisualStyleBackColor = True
        '
        'txtChoice4
        '
        Me.txtChoice4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtChoice4.Location = New System.Drawing.Point(75, 494)
        Me.txtChoice4.Name = "txtChoice4"
        Me.txtChoice4.Size = New System.Drawing.Size(735, 22)
        Me.txtChoice4.TabIndex = 6
        '
        'txtChoice3
        '
        Me.txtChoice3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtChoice3.Location = New System.Drawing.Point(75, 466)
        Me.txtChoice3.Name = "txtChoice3"
        Me.txtChoice3.Size = New System.Drawing.Size(735, 22)
        Me.txtChoice3.TabIndex = 5
        '
        'txtChoice2
        '
        Me.txtChoice2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtChoice2.Location = New System.Drawing.Point(75, 438)
        Me.txtChoice2.Name = "txtChoice2"
        Me.txtChoice2.Size = New System.Drawing.Size(735, 22)
        Me.txtChoice2.TabIndex = 4
        '
        'txtChoice1
        '
        Me.txtChoice1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtChoice1.Location = New System.Drawing.Point(75, 410)
        Me.txtChoice1.Name = "txtChoice1"
        Me.txtChoice1.Size = New System.Drawing.Size(735, 22)
        Me.txtChoice1.TabIndex = 3
        '
        'rbChoice4
        '
        Me.rbChoice4.AutoSize = True
        Me.rbChoice4.Depth = 0
        Me.rbChoice4.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.rbChoice4.Location = New System.Drawing.Point(27, 491)
        Me.rbChoice4.Margin = New System.Windows.Forms.Padding(0)
        Me.rbChoice4.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.rbChoice4.MouseState = MaterialSkin.MouseState.HOVER
        Me.rbChoice4.Name = "rbChoice4"
        Me.rbChoice4.Ripple = True
        Me.rbChoice4.Size = New System.Drawing.Size(38, 30)
        Me.rbChoice4.TabIndex = 8
        Me.rbChoice4.TabStop = True
        Me.rbChoice4.Text = "D"
        Me.rbChoice4.UseVisualStyleBackColor = True
        '
        'rbChoice3
        '
        Me.rbChoice3.AutoSize = True
        Me.rbChoice3.Depth = 0
        Me.rbChoice3.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.rbChoice3.Location = New System.Drawing.Point(27, 463)
        Me.rbChoice3.Margin = New System.Windows.Forms.Padding(0)
        Me.rbChoice3.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.rbChoice3.MouseState = MaterialSkin.MouseState.HOVER
        Me.rbChoice3.Name = "rbChoice3"
        Me.rbChoice3.Ripple = True
        Me.rbChoice3.Size = New System.Drawing.Size(38, 30)
        Me.rbChoice3.TabIndex = 8
        Me.rbChoice3.TabStop = True
        Me.rbChoice3.Text = "C"
        Me.rbChoice3.UseVisualStyleBackColor = True
        '
        'rbChoice2
        '
        Me.rbChoice2.AutoSize = True
        Me.rbChoice2.Depth = 0
        Me.rbChoice2.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.rbChoice2.Location = New System.Drawing.Point(27, 435)
        Me.rbChoice2.Margin = New System.Windows.Forms.Padding(0)
        Me.rbChoice2.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.rbChoice2.MouseState = MaterialSkin.MouseState.HOVER
        Me.rbChoice2.Name = "rbChoice2"
        Me.rbChoice2.Ripple = True
        Me.rbChoice2.Size = New System.Drawing.Size(38, 30)
        Me.rbChoice2.TabIndex = 8
        Me.rbChoice2.TabStop = True
        Me.rbChoice2.Text = "B"
        Me.rbChoice2.UseVisualStyleBackColor = True
        '
        'rbChoice1
        '
        Me.rbChoice1.AutoSize = True
        Me.rbChoice1.Depth = 0
        Me.rbChoice1.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.rbChoice1.Location = New System.Drawing.Point(27, 407)
        Me.rbChoice1.Margin = New System.Windows.Forms.Padding(0)
        Me.rbChoice1.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.rbChoice1.MouseState = MaterialSkin.MouseState.HOVER
        Me.rbChoice1.Name = "rbChoice1"
        Me.rbChoice1.Ripple = True
        Me.rbChoice1.Size = New System.Drawing.Size(38, 30)
        Me.rbChoice1.TabIndex = 8
        Me.rbChoice1.TabStop = True
        Me.rbChoice1.Text = "A"
        Me.rbChoice1.UseVisualStyleBackColor = True
        '
        'tscQuestion
        '
        '
        'tscQuestion.ContentPanel
        '
        Me.tscQuestion.ContentPanel.Controls.Add(Me.rtfQuestion)
        Me.tscQuestion.ContentPanel.Size = New System.Drawing.Size(1041, 275)
        Me.tscQuestion.Location = New System.Drawing.Point(16, 85)
        Me.tscQuestion.Name = "tscQuestion"
        Me.tscQuestion.Size = New System.Drawing.Size(1041, 300)
        Me.tscQuestion.TabIndex = 7
        Me.tscQuestion.Text = "ToolStripContainer1"
        '
        'tscQuestion.TopToolStripPanel
        '
        Me.tscQuestion.TopToolStripPanel.Controls.Add(Me.tsQuestion)
        '
        'rtfQuestion
        '
        Me.rtfQuestion.Location = New System.Drawing.Point(0, 0)
        Me.rtfQuestion.Name = "rtfQuestion"
        Me.rtfQuestion.Size = New System.Drawing.Size(1041, 275)
        Me.rtfQuestion.TabIndex = 0
        Me.rtfQuestion.Text = ""
        '
        'tsQuestion
        '
        Me.tsQuestion.Dock = System.Windows.Forms.DockStyle.None
        Me.tsQuestion.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbInsertImage, Me.tslInsertImage, Me.ToolStripSeparator1, Me.tsbChangeFont, Me.tslChangeFont})
        Me.tsQuestion.Location = New System.Drawing.Point(3, 0)
        Me.tsQuestion.Name = "tsQuestion"
        Me.tsQuestion.Size = New System.Drawing.Size(167, 25)
        Me.tsQuestion.TabIndex = 0
        '
        'tsbInsertImage
        '
        Me.tsbInsertImage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbInsertImage.Image = Global.PQE.My.Resources.Resources.AddImage
        Me.tsbInsertImage.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbInsertImage.Name = "tsbInsertImage"
        Me.tsbInsertImage.Size = New System.Drawing.Size(23, 22)
        Me.tsbInsertImage.Text = "Insert Image"
        '
        'tslInsertImage
        '
        Me.tslInsertImage.Name = "tslInsertImage"
        Me.tslInsertImage.Size = New System.Drawing.Size(72, 22)
        Me.tslInsertImage.Text = "Insert Image"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'tsbChangeFont
        '
        Me.tsbChangeFont.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbChangeFont.Image = Global.PQE.My.Resources.Resources.ChangeFont
        Me.tsbChangeFont.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbChangeFont.Name = "tsbChangeFont"
        Me.tsbChangeFont.Size = New System.Drawing.Size(23, 22)
        Me.tsbChangeFont.Text = "Change Font"
        '
        'tslChangeFont
        '
        Me.tslChangeFont.Name = "tslChangeFont"
        Me.tslChangeFont.Size = New System.Drawing.Size(31, 22)
        Me.tslChangeFont.Text = "Font"
        '
        'dgvExam
        '
        Me.dgvExam.AllowUserToAddRows = False
        Me.dgvExam.AllowUserToDeleteRows = False
        Me.dgvExam.AllowUserToResizeColumns = False
        Me.dgvExam.AllowUserToResizeRows = False
        Me.dgvExam.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvExam.BackgroundColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.MenuHighlight
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvExam.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvExam.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvExam.DefaultCellStyle = DataGridViewCellStyle5
        Me.dgvExam.EnableHeadersVisualStyles = False
        Me.dgvExam.GridColor = System.Drawing.SystemColors.MenuBar
        Me.dgvExam.Location = New System.Drawing.Point(1059, 109)
        Me.dgvExam.Name = "dgvExam"
        Me.dgvExam.ReadOnly = True
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.MenuHighlight
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvExam.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.dgvExam.RowHeadersVisible = False
        Me.dgvExam.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvExam.Size = New System.Drawing.Size(185, 411)
        Me.dgvExam.TabIndex = 6
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label35.Location = New System.Drawing.Point(1057, 88)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(54, 16)
        Me.Label35.TabIndex = 1
        Me.Label35.Text = "Search:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(1055, 57)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(113, 16)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "Question Counter:"
        '
        'lblQuestionCounter
        '
        Me.lblQuestionCounter.AutoSize = True
        Me.lblQuestionCounter.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQuestionCounter.Location = New System.Drawing.Point(1182, 58)
        Me.lblQuestionCounter.Name = "lblQuestionCounter"
        Me.lblQuestionCounter.Size = New System.Drawing.Size(15, 16)
        Me.lblQuestionCounter.TabIndex = 1
        Me.lblQuestionCounter.Text = "0"
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label36.Location = New System.Drawing.Point(18, 388)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(101, 16)
        Me.Label36.TabIndex = 1
        Me.Label36.Text = "Correct Answer:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(178, 47)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(80, 16)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Exam Type:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(177, 17)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(81, 16)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Exam Level:"
        '
        'cboExamType
        '
        Me.cboExamType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboExamType.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboExamType.FormattingEnabled = True
        Me.cboExamType.Location = New System.Drawing.Point(264, 44)
        Me.cboExamType.Name = "cboExamType"
        Me.cboExamType.Size = New System.Drawing.Size(265, 24)
        Me.cboExamType.TabIndex = 2
        '
        'cboExamLevel
        '
        Me.cboExamLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboExamLevel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboExamLevel.FormattingEnabled = True
        Me.cboExamLevel.Location = New System.Drawing.Point(264, 14)
        Me.cboExamLevel.Name = "cboExamLevel"
        Me.cboExamLevel.Size = New System.Drawing.Size(265, 24)
        Me.cboExamLevel.TabIndex = 1
        '
        'picExamError
        '
        Me.picExamError.Image = Global.PQE.My.Resources.Resources.error1
        Me.picExamError.Location = New System.Drawing.Point(765, 22)
        Me.picExamError.Name = "picExamError"
        Me.picExamError.Size = New System.Drawing.Size(50, 50)
        Me.picExamError.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picExamError.TabIndex = 12
        Me.picExamError.TabStop = False
        Me.picExamError.Visible = False
        '
        'tabConfiguration
        '
        Me.tabConfiguration.BackColor = System.Drawing.Color.WhiteSmoke
        Me.tabConfiguration.Controls.Add(Me.dgvTempo)
        Me.tabConfiguration.Controls.Add(Me.btnTempoAdd)
        Me.tabConfiguration.Controls.Add(Me.btnTempoDelete)
        Me.tabConfiguration.Controls.Add(Me.txtTempoPass)
        Me.tabConfiguration.Controls.Add(Me.txtTempoUser)
        Me.tabConfiguration.Controls.Add(Me.Label39)
        Me.tabConfiguration.Controls.Add(Me.Label40)
        Me.tabConfiguration.Controls.Add(Me.Label41)
        Me.tabConfiguration.Controls.Add(Me.chkShowPassword)
        Me.tabConfiguration.Controls.Add(Me.btnChangePassword)
        Me.tabConfiguration.Controls.Add(Me.txtNewPassword)
        Me.tabConfiguration.Controls.Add(Me.txtCurrentPassword)
        Me.tabConfiguration.Controls.Add(Me.btnRestore)
        Me.tabConfiguration.Controls.Add(Me.btnBrowse)
        Me.tabConfiguration.Controls.Add(Me.txtClericalVerbalTime)
        Me.tabConfiguration.Controls.Add(Me.txtAbstractReasoningTime)
        Me.tabConfiguration.Controls.Add(Me.txtNonSupervisoryVerbalTime)
        Me.tabConfiguration.Controls.Add(Me.txtClericalNumericalTime)
        Me.tabConfiguration.Controls.Add(Me.txtSupervisoryVerbalTime)
        Me.tabConfiguration.Controls.Add(Me.txtClericalReasoningTime)
        Me.tabConfiguration.Controls.Add(Me.txtGeneralInfoTime)
        Me.tabConfiguration.Controls.Add(Me.txtNonSupervisoryNumericalTime)
        Me.tabConfiguration.Controls.Add(Me.txtReadingComprehensionTime)
        Me.tabConfiguration.Controls.Add(Me.txtSupervisoryNumericalTime)
        Me.tabConfiguration.Controls.Add(Me.txtManagementTime)
        Me.tabConfiguration.Controls.Add(Me.MaterialDivider2)
        Me.tabConfiguration.Controls.Add(Me.MaterialDivider1)
        Me.tabConfiguration.Controls.Add(Me.btnTimerSave)
        Me.tabConfiguration.Controls.Add(Me.Label23)
        Me.tabConfiguration.Controls.Add(Me.Label21)
        Me.tabConfiguration.Controls.Add(Me.Label22)
        Me.tabConfiguration.Controls.Add(Me.Label18)
        Me.tabConfiguration.Controls.Add(Me.Label20)
        Me.tabConfiguration.Controls.Add(Me.Label15)
        Me.tabConfiguration.Controls.Add(Me.Label19)
        Me.tabConfiguration.Controls.Add(Me.Label17)
        Me.tabConfiguration.Controls.Add(Me.Label29)
        Me.tabConfiguration.Controls.Add(Me.Label26)
        Me.tabConfiguration.Controls.Add(Me.lblLastRestore)
        Me.tabConfiguration.Controls.Add(Me.Label28)
        Me.tabConfiguration.Controls.Add(Me.lblLastBackup)
        Me.tabConfiguration.Controls.Add(Me.Label25)
        Me.tabConfiguration.Controls.Add(Me.Label16)
        Me.tabConfiguration.Controls.Add(Me.Label14)
        Me.tabConfiguration.Controls.Add(Me.Label13)
        Me.tabConfiguration.Controls.Add(Me.Label12)
        Me.tabConfiguration.Controls.Add(Me.Label27)
        Me.tabConfiguration.Controls.Add(Me.Label24)
        Me.tabConfiguration.Controls.Add(Me.Label11)
        Me.tabConfiguration.Controls.Add(Me.Label10)
        Me.tabConfiguration.Controls.Add(Me.Label32)
        Me.tabConfiguration.Controls.Add(Me.Label9)
        Me.tabConfiguration.Location = New System.Drawing.Point(4, 22)
        Me.tabConfiguration.Name = "tabConfiguration"
        Me.tabConfiguration.Padding = New System.Windows.Forms.Padding(3)
        Me.tabConfiguration.Size = New System.Drawing.Size(1248, 523)
        Me.tabConfiguration.TabIndex = 2
        Me.tabConfiguration.Text = "Configuration"
        '
        'dgvTempo
        '
        Me.dgvTempo.AllowUserToAddRows = False
        Me.dgvTempo.AllowUserToDeleteRows = False
        Me.dgvTempo.AllowUserToResizeColumns = False
        Me.dgvTempo.AllowUserToResizeRows = False
        Me.dgvTempo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvTempo.BackgroundColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.MenuHighlight
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvTempo.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.dgvTempo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTempo.ContextMenuStrip = Me.cmsPrintExaminee
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvTempo.DefaultCellStyle = DataGridViewCellStyle8
        Me.dgvTempo.EnableHeadersVisualStyles = False
        Me.dgvTempo.GridColor = System.Drawing.SystemColors.MenuBar
        Me.dgvTempo.Location = New System.Drawing.Point(769, 435)
        Me.dgvTempo.Name = "dgvTempo"
        Me.dgvTempo.ReadOnly = True
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.MenuHighlight
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvTempo.RowHeadersDefaultCellStyle = DataGridViewCellStyle9
        Me.dgvTempo.RowHeadersVisible = False
        Me.dgvTempo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvTempo.Size = New System.Drawing.Size(422, 67)
        Me.dgvTempo.TabIndex = 74
        '
        'btnTempoAdd
        '
        Me.btnTempoAdd.Depth = 0
        Me.btnTempoAdd.Location = New System.Drawing.Point(1098, 369)
        Me.btnTempoAdd.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnTempoAdd.Name = "btnTempoAdd"
        Me.btnTempoAdd.Primary = True
        Me.btnTempoAdd.Size = New System.Drawing.Size(93, 23)
        Me.btnTempoAdd.TabIndex = 73
        Me.btnTempoAdd.Text = "Add"
        Me.btnTempoAdd.UseVisualStyleBackColor = True
        '
        'btnTempoDelete
        '
        Me.btnTempoDelete.Depth = 0
        Me.btnTempoDelete.Location = New System.Drawing.Point(1098, 397)
        Me.btnTempoDelete.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnTempoDelete.Name = "btnTempoDelete"
        Me.btnTempoDelete.Primary = True
        Me.btnTempoDelete.Size = New System.Drawing.Size(93, 23)
        Me.btnTempoDelete.TabIndex = 72
        Me.btnTempoDelete.Text = "Delete"
        Me.btnTempoDelete.UseVisualStyleBackColor = True
        '
        'txtTempoPass
        '
        Me.txtTempoPass.Location = New System.Drawing.Point(897, 397)
        Me.txtTempoPass.Name = "txtTempoPass"
        Me.txtTempoPass.Size = New System.Drawing.Size(180, 20)
        Me.txtTempoPass.TabIndex = 71
        '
        'txtTempoUser
        '
        Me.txtTempoUser.Location = New System.Drawing.Point(897, 374)
        Me.txtTempoUser.Name = "txtTempoUser"
        Me.txtTempoUser.Size = New System.Drawing.Size(180, 20)
        Me.txtTempoUser.TabIndex = 70
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label39.Location = New System.Drawing.Point(811, 398)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(71, 16)
        Me.Label39.TabIndex = 68
        Me.Label39.Text = "Password:"
        '
        'Label40
        '
        Me.Label40.AutoSize = True
        Me.Label40.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label40.Location = New System.Drawing.Point(826, 374)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(56, 16)
        Me.Label40.TabIndex = 69
        Me.Label40.Text = "User ID:"
        '
        'Label41
        '
        Me.Label41.AutoSize = True
        Me.Label41.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label41.Location = New System.Drawing.Point(905, 336)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(143, 17)
        Me.Label41.TabIndex = 67
        Me.Label41.Text = "Temporary Admins"
        '
        'chkShowPassword
        '
        Me.chkShowPassword.AutoSize = True
        Me.chkShowPassword.Depth = 0
        Me.chkShowPassword.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.chkShowPassword.Location = New System.Drawing.Point(897, 286)
        Me.chkShowPassword.Margin = New System.Windows.Forms.Padding(0)
        Me.chkShowPassword.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.chkShowPassword.MouseState = MaterialSkin.MouseState.HOVER
        Me.chkShowPassword.Name = "chkShowPassword"
        Me.chkShowPassword.Ripple = True
        Me.chkShowPassword.Size = New System.Drawing.Size(128, 30)
        Me.chkShowPassword.TabIndex = 10
        Me.chkShowPassword.Text = "Show Password"
        Me.chkShowPassword.UseVisualStyleBackColor = True
        '
        'btnChangePassword
        '
        Me.btnChangePassword.Depth = 0
        Me.btnChangePassword.Location = New System.Drawing.Point(1098, 234)
        Me.btnChangePassword.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnChangePassword.Name = "btnChangePassword"
        Me.btnChangePassword.Primary = True
        Me.btnChangePassword.Size = New System.Drawing.Size(93, 50)
        Me.btnChangePassword.TabIndex = 9
        Me.btnChangePassword.Text = "Change Password"
        Me.btnChangePassword.UseVisualStyleBackColor = True
        '
        'txtNewPassword
        '
        Me.txtNewPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNewPassword.Location = New System.Drawing.Point(897, 259)
        Me.txtNewPassword.Name = "txtNewPassword"
        Me.txtNewPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtNewPassword.Size = New System.Drawing.Size(180, 22)
        Me.txtNewPassword.TabIndex = 12
        '
        'txtCurrentPassword
        '
        Me.txtCurrentPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCurrentPassword.Location = New System.Drawing.Point(897, 234)
        Me.txtCurrentPassword.Name = "txtCurrentPassword"
        Me.txtCurrentPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtCurrentPassword.Size = New System.Drawing.Size(180, 22)
        Me.txtCurrentPassword.TabIndex = 11
        '
        'btnRestore
        '
        Me.btnRestore.Depth = 0
        Me.btnRestore.Location = New System.Drawing.Point(1098, 144)
        Me.btnRestore.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnRestore.Name = "btnRestore"
        Me.btnRestore.Primary = True
        Me.btnRestore.Size = New System.Drawing.Size(93, 23)
        Me.btnRestore.TabIndex = 7
        Me.btnRestore.Text = "Restore"
        Me.btnRestore.UseVisualStyleBackColor = True
        '
        'btnBrowse
        '
        Me.btnBrowse.Depth = 0
        Me.btnBrowse.Location = New System.Drawing.Point(1098, 116)
        Me.btnBrowse.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Primary = True
        Me.btnBrowse.Size = New System.Drawing.Size(93, 23)
        Me.btnBrowse.TabIndex = 7
        Me.btnBrowse.Text = "Backup"
        Me.btnBrowse.UseVisualStyleBackColor = True
        '
        'txtClericalVerbalTime
        '
        Me.txtClericalVerbalTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtClericalVerbalTime.Location = New System.Drawing.Point(545, 331)
        Me.txtClericalVerbalTime.Name = "txtClericalVerbalTime"
        Me.txtClericalVerbalTime.Size = New System.Drawing.Size(45, 22)
        Me.txtClericalVerbalTime.TabIndex = 10
        '
        'txtAbstractReasoningTime
        '
        Me.txtAbstractReasoningTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAbstractReasoningTime.Location = New System.Drawing.Point(269, 362)
        Me.txtAbstractReasoningTime.Name = "txtAbstractReasoningTime"
        Me.txtAbstractReasoningTime.Size = New System.Drawing.Size(45, 22)
        Me.txtAbstractReasoningTime.TabIndex = 8
        '
        'txtNonSupervisoryVerbalTime
        '
        Me.txtNonSupervisoryVerbalTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNonSupervisoryVerbalTime.Location = New System.Drawing.Point(545, 178)
        Me.txtNonSupervisoryVerbalTime.Name = "txtNonSupervisoryVerbalTime"
        Me.txtNonSupervisoryVerbalTime.Size = New System.Drawing.Size(45, 22)
        Me.txtNonSupervisoryVerbalTime.TabIndex = 5
        '
        'txtClericalNumericalTime
        '
        Me.txtClericalNumericalTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtClericalNumericalTime.Location = New System.Drawing.Point(545, 303)
        Me.txtClericalNumericalTime.Name = "txtClericalNumericalTime"
        Me.txtClericalNumericalTime.Size = New System.Drawing.Size(45, 22)
        Me.txtClericalNumericalTime.TabIndex = 9
        '
        'txtSupervisoryVerbalTime
        '
        Me.txtSupervisoryVerbalTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSupervisoryVerbalTime.Location = New System.Drawing.Point(269, 178)
        Me.txtSupervisoryVerbalTime.Name = "txtSupervisoryVerbalTime"
        Me.txtSupervisoryVerbalTime.Size = New System.Drawing.Size(45, 22)
        Me.txtSupervisoryVerbalTime.TabIndex = 2
        '
        'txtClericalReasoningTime
        '
        Me.txtClericalReasoningTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtClericalReasoningTime.Location = New System.Drawing.Point(269, 334)
        Me.txtClericalReasoningTime.Name = "txtClericalReasoningTime"
        Me.txtClericalReasoningTime.Size = New System.Drawing.Size(45, 22)
        Me.txtClericalReasoningTime.TabIndex = 7
        '
        'txtGeneralInfoTime
        '
        Me.txtGeneralInfoTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGeneralInfoTime.Location = New System.Drawing.Point(269, 306)
        Me.txtGeneralInfoTime.Name = "txtGeneralInfoTime"
        Me.txtGeneralInfoTime.Size = New System.Drawing.Size(45, 22)
        Me.txtGeneralInfoTime.TabIndex = 6
        '
        'txtNonSupervisoryNumericalTime
        '
        Me.txtNonSupervisoryNumericalTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNonSupervisoryNumericalTime.Location = New System.Drawing.Point(545, 148)
        Me.txtNonSupervisoryNumericalTime.Name = "txtNonSupervisoryNumericalTime"
        Me.txtNonSupervisoryNumericalTime.Size = New System.Drawing.Size(45, 22)
        Me.txtNonSupervisoryNumericalTime.TabIndex = 4
        '
        'txtReadingComprehensionTime
        '
        Me.txtReadingComprehensionTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtReadingComprehensionTime.Location = New System.Drawing.Point(545, 117)
        Me.txtReadingComprehensionTime.Name = "txtReadingComprehensionTime"
        Me.txtReadingComprehensionTime.Size = New System.Drawing.Size(45, 22)
        Me.txtReadingComprehensionTime.TabIndex = 3
        '
        'txtSupervisoryNumericalTime
        '
        Me.txtSupervisoryNumericalTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSupervisoryNumericalTime.Location = New System.Drawing.Point(269, 148)
        Me.txtSupervisoryNumericalTime.Name = "txtSupervisoryNumericalTime"
        Me.txtSupervisoryNumericalTime.Size = New System.Drawing.Size(45, 22)
        Me.txtSupervisoryNumericalTime.TabIndex = 1
        '
        'txtManagementTime
        '
        Me.txtManagementTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtManagementTime.Location = New System.Drawing.Point(269, 117)
        Me.txtManagementTime.Name = "txtManagementTime"
        Me.txtManagementTime.Size = New System.Drawing.Size(45, 22)
        Me.txtManagementTime.TabIndex = 0
        '
        'MaterialDivider2
        '
        Me.MaterialDivider2.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialDivider2.Depth = 0
        Me.MaterialDivider2.Location = New System.Drawing.Point(658, 59)
        Me.MaterialDivider2.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialDivider2.Name = "MaterialDivider2"
        Me.MaterialDivider2.Size = New System.Drawing.Size(2, 453)
        Me.MaterialDivider2.TabIndex = 5
        Me.MaterialDivider2.Text = "MaterialDivider2"
        '
        'MaterialDivider1
        '
        Me.MaterialDivider1.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialDivider1.Depth = 0
        Me.MaterialDivider1.Location = New System.Drawing.Point(6, 48)
        Me.MaterialDivider1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialDivider1.Name = "MaterialDivider1"
        Me.MaterialDivider1.Size = New System.Drawing.Size(1236, 3)
        Me.MaterialDivider1.TabIndex = 4
        Me.MaterialDivider1.Text = "MaterialDivider1"
        '
        'btnTimerSave
        '
        Me.btnTimerSave.Depth = 0
        Me.btnTimerSave.Location = New System.Drawing.Point(223, 435)
        Me.btnTimerSave.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnTimerSave.Name = "btnTimerSave"
        Me.btnTimerSave.Primary = True
        Me.btnTimerSave.Size = New System.Drawing.Size(255, 37)
        Me.btnTimerSave.TabIndex = 3
        Me.btnTimerSave.Text = "Save All Timers"
        Me.btnTimerSave.UseVisualStyleBackColor = True
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(452, 334)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(87, 16)
        Me.Label23.TabIndex = 2
        Me.Label23.Text = "Verbal Ability"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(137, 365)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(126, 16)
        Me.Label21.TabIndex = 2
        Me.Label21.Text = "Abstract Reasoning"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(431, 306)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(108, 16)
        Me.Label22.TabIndex = 2
        Me.Label22.Text = "Numerical Ability"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(452, 181)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(87, 16)
        Me.Label18.TabIndex = 2
        Me.Label18.Text = "Verbal Ability"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(141, 337)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(122, 16)
        Me.Label20.TabIndex = 2
        Me.Label20.Text = "Clerical Reasoning"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(176, 178)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(87, 16)
        Me.Label15.TabIndex = 2
        Me.Label15.Text = "Verbal Ability"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(53, 309)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(210, 16)
        Me.Label19.TabIndex = 2
        Me.Label19.Text = "General Information and Concepts"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(431, 154)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(108, 16)
        Me.Label17.TabIndex = 2
        Me.Label17.Text = "Numerical Ability"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.Location = New System.Drawing.Point(781, 262)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(101, 16)
        Me.Label29.TabIndex = 2
        Me.Label29.Text = "New Password:"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(795, 147)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(87, 16)
        Me.Label26.TabIndex = 2
        Me.Label26.Text = "Last Restore:"
        '
        'lblLastRestore
        '
        Me.lblLastRestore.AutoSize = True
        Me.lblLastRestore.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLastRestore.Location = New System.Drawing.Point(894, 147)
        Me.lblLastRestore.Name = "lblLastRestore"
        Me.lblLastRestore.Size = New System.Drawing.Size(155, 16)
        Me.lblLastRestore.TabIndex = 2
        Me.lblLastRestore.Text = "Month 00, YYYY, HH-MM"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.Location = New System.Drawing.Point(766, 237)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(116, 16)
        Me.Label28.TabIndex = 2
        Me.Label28.Text = "Current Password:"
        '
        'lblLastBackup
        '
        Me.lblLastBackup.AutoSize = True
        Me.lblLastBackup.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLastBackup.Location = New System.Drawing.Point(894, 119)
        Me.lblLastBackup.Name = "lblLastBackup"
        Me.lblLastBackup.Size = New System.Drawing.Size(155, 16)
        Me.lblLastBackup.TabIndex = 2
        Me.lblLastBackup.Text = "Month 00, YYYY, HH-MM"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(797, 119)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(85, 16)
        Me.Label25.TabIndex = 2
        Me.Label25.Text = "Last Backup:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(381, 123)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(158, 16)
        Me.Label16.TabIndex = 2
        Me.Label16.Text = "Reading Comprehension"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(155, 148)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(108, 16)
        Me.Label14.TabIndex = 2
        Me.Label14.Text = "Numerical Ability"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(26, 117)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(237, 16)
        Me.Label13.TabIndex = 2
        Me.Label13.Text = "Management and Leadership Concept"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(308, 265)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(61, 16)
        Me.Label12.TabIndex = 1
        Me.Label12.Text = "Clerical"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.Location = New System.Drawing.Point(915, 204)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(123, 16)
        Me.Label27.TabIndex = 1
        Me.Label27.Text = "Admin Password"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(882, 78)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(192, 16)
        Me.Label24.TabIndex = 1
        Me.Label24.Text = "Backup/Restore Database"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(431, 78)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(124, 16)
        Me.Label11.TabIndex = 1
        Me.Label11.Text = "Non-Supervisory"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(104, 78)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(91, 16)
        Me.Label10.TabIndex = 1
        Me.Label10.Text = "Supervisory"
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.Location = New System.Drawing.Point(678, 19)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(116, 20)
        Me.Label32.TabIndex = 0
        Me.Label32.Text = "Administrator"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(10, 19)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(182, 20)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Exam Timer (minutes)"
        '
        'mtsAdminDashboard
        '
        Me.mtsAdminDashboard.BaseTabControl = Me.mtcAdminDashboard
        Me.mtsAdminDashboard.Depth = 0
        Me.mtsAdminDashboard.Location = New System.Drawing.Point(12, 179)
        Me.mtsAdminDashboard.MouseState = MaterialSkin.MouseState.HOVER
        Me.mtsAdminDashboard.Name = "mtsAdminDashboard"
        Me.mtsAdminDashboard.Size = New System.Drawing.Size(1252, 23)
        Me.mtsAdminDashboard.TabIndex = 3
        Me.mtsAdminDashboard.Text = "MaterialTabSelector1"
        '
        'ofdRestore
        '
        Me.ofdRestore.FileName = "OpenFileDialog1"
        '
        'btnBackLogin
        '
        Me.btnBackLogin.Depth = 0
        Me.btnBackLogin.Location = New System.Drawing.Point(1152, 73)
        Me.btnBackLogin.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnBackLogin.Name = "btnBackLogin"
        Me.btnBackLogin.Primary = True
        Me.btnBackLogin.Size = New System.Drawing.Size(112, 37)
        Me.btnBackLogin.TabIndex = 5
        Me.btnBackLogin.Text = "Back to Login"
        Me.btnBackLogin.UseVisualStyleBackColor = True
        '
        'btnUserManual
        '
        Me.btnUserManual.Depth = 0
        Me.btnUserManual.Location = New System.Drawing.Point(1152, 135)
        Me.btnUserManual.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnUserManual.Name = "btnUserManual"
        Me.btnUserManual.Primary = True
        Me.btnUserManual.Size = New System.Drawing.Size(112, 37)
        Me.btnUserManual.TabIndex = 6
        Me.btnUserManual.Text = "User Manual"
        Me.btnUserManual.UseVisualStyleBackColor = True
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.Location = New System.Drawing.Point(116, 86)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(653, 24)
        Me.Label31.TabIndex = 8
        Me.Label31.Text = "Republic of the Philippines - Department Of Science and Technology"
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.Location = New System.Drawing.Point(117, 135)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(399, 31)
        Me.Label33.TabIndex = 10
        Me.Label33.Text = "Pre-Qualification Examination"
        '
        'MaterialDivider4
        '
        Me.MaterialDivider4.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialDivider4.Depth = 0
        Me.MaterialDivider4.Location = New System.Drawing.Point(117, 120)
        Me.MaterialDivider4.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialDivider4.Name = "MaterialDivider4"
        Me.MaterialDivider4.Size = New System.Drawing.Size(1147, 6)
        Me.MaterialDivider4.TabIndex = 9
        Me.MaterialDivider4.Text = "MaterialDivider3"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.PQE.My.Resources.Resources.dost
        Me.PictureBox1.Location = New System.Drawing.Point(11, 72)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 100)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'AdminDashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1280, 768)
        Me.Controls.Add(Me.Label33)
        Me.Controls.Add(Me.MaterialDivider4)
        Me.Controls.Add(Me.Label31)
        Me.Controls.Add(Me.btnUserManual)
        Me.Controls.Add(Me.btnBackLogin)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.mtsAdminDashboard)
        Me.Controls.Add(Me.mtcAdminDashboard)
        Me.Name = "AdminDashboard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Admin Dashboard"
        Me.mtcAdminDashboard.ResumeLayout(False)
        Me.tabExaminee.ResumeLayout(False)
        Me.tabExaminee.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.picExaminee, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picExamineeError, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvExaminee, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cmsPrintExaminee.ResumeLayout(False)
        Me.tabExam.ResumeLayout(False)
        Me.tabExam.PerformLayout()
        Me.tscQuestion.ContentPanel.ResumeLayout(False)
        Me.tscQuestion.TopToolStripPanel.ResumeLayout(False)
        Me.tscQuestion.TopToolStripPanel.PerformLayout()
        Me.tscQuestion.ResumeLayout(False)
        Me.tscQuestion.PerformLayout()
        Me.tsQuestion.ResumeLayout(False)
        Me.tsQuestion.PerformLayout()
        CType(Me.dgvExam, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picExamError, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabConfiguration.ResumeLayout(False)
        Me.tabConfiguration.PerformLayout()
        CType(Me.dgvTempo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents mtcAdminDashboard As MaterialSkin.Controls.MaterialTabControl
    Friend WithEvents tabExaminee As TabPage
    Friend WithEvents cboExamineePosition As ComboBox
    Friend WithEvents cboExamineeLevel As ComboBox
    Friend WithEvents tabExam As TabPage
    Friend WithEvents tabConfiguration As TabPage
    Friend WithEvents mtsAdminDashboard As MaterialSkin.Controls.MaterialTabSelector
    Friend WithEvents lblExamineeID As Label
    Friend WithEvents dgvExaminee As DataGridView
    Friend WithEvents btnExamineeClear As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents btnExamineeEdit As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents btnExamineeRegister As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents cboExamType As ComboBox
    Friend WithEvents cboExamLevel As ComboBox
    Friend WithEvents btnExamClear As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents btnQuestionDelete As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents btnQuestionSave As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents txtChoice4 As TextBox
    Friend WithEvents txtChoice3 As TextBox
    Friend WithEvents txtChoice2 As TextBox
    Friend WithEvents txtChoice1 As TextBox
    Friend WithEvents rbChoice4 As MaterialSkin.Controls.MaterialRadioButton
    Friend WithEvents rbChoice3 As MaterialSkin.Controls.MaterialRadioButton
    Friend WithEvents rbChoice2 As MaterialSkin.Controls.MaterialRadioButton
    Friend WithEvents rbChoice1 As MaterialSkin.Controls.MaterialRadioButton
    Friend WithEvents tscQuestion As ToolStripContainer
    Friend WithEvents rtfQuestion As RichTextBox
    Friend WithEvents tsQuestion As ToolStrip
    Friend WithEvents tsbInsertImage As ToolStripButton
    Friend WithEvents dgvExam As DataGridView
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lblKindID As Label
    Friend WithEvents lblExamLevelID As Label
    Friend WithEvents lblExamTypeID As Label
    Friend WithEvents lblQuestionID As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents lblQuestionCounter As Label
    Friend WithEvents txtClericalVerbalTime As TextBox
    Friend WithEvents txtAbstractReasoningTime As TextBox
    Friend WithEvents txtNonSupervisoryVerbalTime As TextBox
    Friend WithEvents txtClericalNumericalTime As TextBox
    Friend WithEvents txtSupervisoryVerbalTime As TextBox
    Friend WithEvents txtClericalReasoningTime As TextBox
    Friend WithEvents txtGeneralInfoTime As TextBox
    Friend WithEvents txtNonSupervisoryNumericalTime As TextBox
    Friend WithEvents txtReadingComprehensionTime As TextBox
    Friend WithEvents txtSupervisoryNumericalTime As TextBox
    Friend WithEvents txtManagementTime As TextBox
    Friend WithEvents MaterialDivider2 As MaterialSkin.Controls.MaterialDivider
    Friend WithEvents MaterialDivider1 As MaterialSkin.Controls.MaterialDivider
    Friend WithEvents btnTimerSave As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents Label23 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents lblExamineeError As Label
    Friend WithEvents picExamineeError As PictureBox
    Friend WithEvents lblExamError As Label
    Friend WithEvents picExamError As PictureBox
    Friend WithEvents lblExamineeCount As Label
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents picExaminee As PictureBox
    Friend WithEvents btnRestore As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents btnBrowse As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents Label26 As Label
    Friend WithEvents lblLastRestore As Label
    Friend WithEvents lblLastBackup As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents sfdBackup As SaveFileDialog
    Friend WithEvents ofdRestore As OpenFileDialog
    Friend WithEvents btnChangePassword As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents txtNewPassword As TextBox
    Friend WithEvents txtCurrentPassword As TextBox
    Friend WithEvents Label29 As Label
    Friend WithEvents Label28 As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents chkShowPassword As MaterialSkin.Controls.MaterialCheckBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnBackLogin As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents btnUserManual As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents btnPrintExamineeDgv As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents btnRefreshExamineeDgv As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents Label30 As Label
    Friend WithEvents tslInsertImage As ToolStripLabel
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents tsbChangeFont As ToolStripButton
    Friend WithEvents tslChangeFont As ToolStripLabel
    Friend WithEvents cmsPrintExaminee As MaterialSkin.Controls.MaterialContextMenuStrip
    Friend WithEvents tsmPrintExaminee As ToolStripMenuItem
    Friend WithEvents fdChangeFont As FontDialog
    Friend WithEvents Label31 As Label
    Friend WithEvents Label33 As Label
    Friend WithEvents MaterialDivider4 As MaterialSkin.Controls.MaterialDivider
    Friend WithEvents Label34 As Label
    Friend WithEvents MaterialDivider5 As MaterialSkin.Controls.MaterialDivider
    Friend WithEvents Label35 As Label
    Friend WithEvents Label36 As Label
    Friend WithEvents btnExportToExcel As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents sfdExcel As SaveFileDialog
    Friend WithEvents Label37 As Label
    Friend WithEvents cboExamSet As ComboBox
    Friend WithEvents lblExamSet As Label
    Friend WithEvents cboExamineeSet As ComboBox
    Friend WithEvents Label38 As Label
    Friend WithEvents btnTempoAdd As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents btnTempoDelete As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents txtTempoPass As TextBox
    Friend WithEvents txtTempoUser As TextBox
    Friend WithEvents Label39 As Label
    Friend WithEvents Label40 As Label
    Friend WithEvents Label41 As Label
    Friend WithEvents dgvTempo As DataGridView
    Friend WithEvents btnChangePicture As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cboPositionFilter As ComboBox
    Friend WithEvents cboLevelFilter As ComboBox
    Friend WithEvents Label42 As Label
    Friend WithEvents Label43 As Label
    Friend WithEvents Label44 As Label
    Friend WithEvents btnSearch As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents btnClearFilter As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents Label46 As Label
    Friend WithEvents Label45 As Label
    Friend WithEvents dtpFromFilter As DateTimePicker
    Friend WithEvents chkDateFilter As CheckBox
    Friend WithEvents dtpToFilter As DateTimePicker
    Friend WithEvents rbNoResultFilter As RadioButton
    Friend WithEvents rbFailedFilter As RadioButton
    Friend WithEvents rbPassedFilter As RadioButton
    Friend WithEvents Label47 As Label
    Friend WithEvents txtFirstNameFilter As TextBox
    Friend WithEvents txtLastNameFilter As TextBox
    Friend WithEvents Label48 As Label
    Friend WithEvents MaterialDivider3 As MaterialSkin.Controls.MaterialDivider
    Friend WithEvents MaterialDivider6 As MaterialSkin.Controls.MaterialDivider
    Friend WithEvents Label32 As Label
End Class
