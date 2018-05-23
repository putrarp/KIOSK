<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Login
    Inherits System.Windows.Forms.Form

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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Personel_ActionDataSet = New KIOSK.Personel_ActionDataSet()
        Me.EmployeeTableAdapter = New KIOSK.EmployeeDataSetTableAdapters.EmployeeTableAdapter()
        Me.EmployeeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EmployeeDataSet = New KIOSK.EmployeeDataSet()
        Me.cutikuPanel = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel7 = New System.Windows.Forms.TableLayoutPanel()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.TableLayoutPanel8 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lbSaldoAwal = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lbBonus = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.lbTerpakai = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.lbPending = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.lbSaldoAkhir = New System.Windows.Forms.Label()
        Me.btnRiwayat = New System.Windows.Forms.FlowLayoutPanel()
        Me.btnRequest = New System.Windows.Forms.FlowLayoutPanel()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.PersonelActionDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.menuPanel = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.FlowLayoutPanel3 = New System.Windows.Forms.FlowLayoutPanel()
        Me.btnSeragamku = New System.Windows.Forms.FlowLayoutPanel()
        Me.btnCutiku = New System.Windows.Forms.FlowLayoutPanel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbKPK = New System.Windows.Forms.TextBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.loginPanel = New System.Windows.Forms.Panel()
        Me.ActionCodeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.requestCutiPanel = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel5 = New System.Windows.Forms.TableLayoutPanel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.TableLayoutPanel6 = New System.Windows.Forms.TableLayoutPanel()
        Me.cbTipeCuti = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.dtMulai = New System.Windows.Forms.DateTimePicker()
        Me.dtAkhir = New System.Windows.Forms.DateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.tbNomorDarurat = New System.Windows.Forms.TextBox()
        Me.submitCuti = New System.Windows.Forms.FlowLayoutPanel()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.ActionCodeTableAdapter = New KIOSK.Personel_ActionDataSetTableAdapters.actionCodeTableAdapter()
        Me.PersonelActionTableAdapter = New KIOSK.Personel_ActionDataSetTableAdapters.personelActionTableAdapter()
        Me.ApprovalTableAdapter = New KIOSK.Personel_ActionDataSetTableAdapters.approvalTableAdapter()
        Me.SectionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DeptTableAdapter = New KIOSK.EmployeeDataSetTableAdapters.deptTableAdapter()
        Me.TipeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ActionCodeBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ApprovalBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.seragamkuPanel = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel11 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel12 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel14 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnOpt2Pants = New System.Windows.Forms.Button()
        Me.btnOpt2Shirt = New System.Windows.Forms.Button()
        Me.opt2Panel = New System.Windows.Forms.Panel()
        Me.opt2PanelShirt = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel15 = New System.Windows.Forms.TableLayoutPanel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button11 = New System.Windows.Forms.Button()
        Me.Button12 = New System.Windows.Forms.Button()
        Me.Button13 = New System.Windows.Forms.Button()
        Me.Button14 = New System.Windows.Forms.Button()
        Me.Button15 = New System.Windows.Forms.Button()
        Me.Button16 = New System.Windows.Forms.Button()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.opt2PanelPants = New System.Windows.Forms.Panel()
        Me.opt1Panel = New System.Windows.Forms.Panel()
        Me.opt1PanelShirt = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel16 = New System.Windows.Forms.TableLayoutPanel()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.opt1PanelPants = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel13 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnOpt1Shirt = New System.Windows.Forms.Button()
        Me.btnOpt1Pants = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.PictureBox10 = New System.Windows.Forms.PictureBox()
        Me.riwayatCuti = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel9 = New System.Windows.Forms.TableLayoutPanel()
        Me.PictureBox8 = New System.Windows.Forms.PictureBox()
        Me.TableLayoutPanel10 = New System.Windows.Forms.TableLayoutPanel()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.PictureBox9 = New System.Windows.Forms.PictureBox()
        Me.PersonelActionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PersonelActionDataSetBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.PersonelActionDataSetBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.EmailBindinSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EmailTableAdapter = New KIOSK.EmployeeDataSetTableAdapters.emailTableAdapter()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SubmitDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ActionCodeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EffDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FinDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmergencyNumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StatusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Remarks = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.Personel_ActionDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmployeeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmployeeDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cutikuPanel.SuspendLayout()
        Me.TableLayoutPanel7.SuspendLayout()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel8.SuspendLayout()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PersonelActionDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.menuPanel.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.TableLayoutPanel4.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.loginPanel.SuspendLayout()
        CType(Me.ActionCodeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.requestCutiPanel.SuspendLayout()
        Me.TableLayoutPanel5.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel6.SuspendLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SectionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TipeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ActionCodeBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ApprovalBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.seragamkuPanel.SuspendLayout()
        Me.TableLayoutPanel11.SuspendLayout()
        Me.TableLayoutPanel12.SuspendLayout()
        Me.TableLayoutPanel14.SuspendLayout()
        Me.opt2Panel.SuspendLayout()
        Me.opt2PanelShirt.SuspendLayout()
        Me.TableLayoutPanel15.SuspendLayout()
        Me.opt1Panel.SuspendLayout()
        Me.opt1PanelShirt.SuspendLayout()
        Me.TableLayoutPanel16.SuspendLayout()
        Me.TableLayoutPanel13.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.riwayatCuti.SuspendLayout()
        Me.TableLayoutPanel9.SuspendLayout()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel10.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PersonelActionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PersonelActionDataSetBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PersonelActionDataSetBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmailBindinSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Personel_ActionDataSet
        '
        Me.Personel_ActionDataSet.DataSetName = "Personel_ActionDataSet"
        Me.Personel_ActionDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'EmployeeTableAdapter
        '
        Me.EmployeeTableAdapter.ClearBeforeFill = True
        '
        'EmployeeBindingSource
        '
        Me.EmployeeBindingSource.DataMember = "Employee"
        Me.EmployeeBindingSource.DataSource = Me.EmployeeDataSet
        '
        'EmployeeDataSet
        '
        Me.EmployeeDataSet.DataSetName = "EmployeeDataSet"
        Me.EmployeeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'cutikuPanel
        '
        Me.cutikuPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.cutikuPanel.Controls.Add(Me.TableLayoutPanel7)
        Me.cutikuPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cutikuPanel.Location = New System.Drawing.Point(0, 0)
        Me.cutikuPanel.Name = "cutikuPanel"
        Me.cutikuPanel.Size = New System.Drawing.Size(1276, 862)
        Me.cutikuPanel.TabIndex = 4
        Me.cutikuPanel.Visible = False
        '
        'TableLayoutPanel7
        '
        Me.TableLayoutPanel7.ColumnCount = 3
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334!))
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334!))
        Me.TableLayoutPanel7.Controls.Add(Me.PictureBox6, 2, 2)
        Me.TableLayoutPanel7.Controls.Add(Me.TableLayoutPanel8, 1, 1)
        Me.TableLayoutPanel7.Controls.Add(Me.Label13, 1, 0)
        Me.TableLayoutPanel7.Controls.Add(Me.PictureBox7, 2, 0)
        Me.TableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel7.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel7.Name = "TableLayoutPanel7"
        Me.TableLayoutPanel7.RowCount = 3
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.53377!))
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 62.93245!))
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.53377!))
        Me.TableLayoutPanel7.Size = New System.Drawing.Size(1276, 862)
        Me.TableLayoutPanel7.TabIndex = 0
        '
        'PictureBox6
        '
        Me.PictureBox6.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox6.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox6.Image = CType(resources.GetObject("PictureBox6.Image"), System.Drawing.Image)
        Me.PictureBox6.Location = New System.Drawing.Point(1219, 814)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(54, 45)
        Me.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox6.TabIndex = 2
        Me.PictureBox6.TabStop = False
        '
        'TableLayoutPanel8
        '
        Me.TableLayoutPanel8.ColumnCount = 1
        Me.TableLayoutPanel8.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel8.Controls.Add(Me.Label9, 0, 0)
        Me.TableLayoutPanel8.Controls.Add(Me.lbSaldoAwal, 0, 1)
        Me.TableLayoutPanel8.Controls.Add(Me.Label11, 0, 2)
        Me.TableLayoutPanel8.Controls.Add(Me.lbBonus, 0, 3)
        Me.TableLayoutPanel8.Controls.Add(Me.Label14, 0, 4)
        Me.TableLayoutPanel8.Controls.Add(Me.lbTerpakai, 0, 5)
        Me.TableLayoutPanel8.Controls.Add(Me.Label16, 0, 6)
        Me.TableLayoutPanel8.Controls.Add(Me.lbPending, 0, 7)
        Me.TableLayoutPanel8.Controls.Add(Me.Label18, 0, 8)
        Me.TableLayoutPanel8.Controls.Add(Me.lbSaldoAkhir, 0, 9)
        Me.TableLayoutPanel8.Controls.Add(Me.btnRiwayat, 0, 10)
        Me.TableLayoutPanel8.Controls.Add(Me.btnRequest, 0, 11)
        Me.TableLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel8.Location = New System.Drawing.Point(428, 162)
        Me.TableLayoutPanel8.Name = "TableLayoutPanel8"
        Me.TableLayoutPanel8.RowCount = 13
        Me.TableLayoutPanel8.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.973094!))
        Me.TableLayoutPanel8.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.973094!))
        Me.TableLayoutPanel8.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.973094!))
        Me.TableLayoutPanel8.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.973094!))
        Me.TableLayoutPanel8.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.973094!))
        Me.TableLayoutPanel8.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.973094!))
        Me.TableLayoutPanel8.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.973094!))
        Me.TableLayoutPanel8.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.973094!))
        Me.TableLayoutPanel8.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.973094!))
        Me.TableLayoutPanel8.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.289813!))
        Me.TableLayoutPanel8.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.52729!))
        Me.TableLayoutPanel8.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.52729!))
        Me.TableLayoutPanel8.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.89776!))
        Me.TableLayoutPanel8.Size = New System.Drawing.Size(419, 536)
        Me.TableLayoutPanel8.TabIndex = 0
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(3, 8)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(413, 18)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Saldo Awal"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'lbSaldoAwal
        '
        Me.lbSaldoAwal.AutoSize = True
        Me.lbSaldoAwal.Dock = System.Windows.Forms.DockStyle.Top
        Me.lbSaldoAwal.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbSaldoAwal.Location = New System.Drawing.Point(3, 26)
        Me.lbSaldoAwal.Name = "lbSaldoAwal"
        Me.lbSaldoAwal.Size = New System.Drawing.Size(413, 25)
        Me.lbSaldoAwal.TabIndex = 1
        Me.lbSaldoAwal.Text = "Label10"
        Me.lbSaldoAwal.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(3, 60)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(413, 18)
        Me.Label11.TabIndex = 2
        Me.Label11.Text = "Bonus"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'lbBonus
        '
        Me.lbBonus.AutoSize = True
        Me.lbBonus.Dock = System.Windows.Forms.DockStyle.Top
        Me.lbBonus.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbBonus.Location = New System.Drawing.Point(3, 78)
        Me.lbBonus.Name = "lbBonus"
        Me.lbBonus.Size = New System.Drawing.Size(413, 25)
        Me.lbBonus.TabIndex = 3
        Me.lbBonus.Text = "Label12"
        Me.lbBonus.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(3, 112)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(413, 18)
        Me.Label14.TabIndex = 4
        Me.Label14.Text = "Terpakai"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'lbTerpakai
        '
        Me.lbTerpakai.AutoSize = True
        Me.lbTerpakai.Dock = System.Windows.Forms.DockStyle.Top
        Me.lbTerpakai.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbTerpakai.Location = New System.Drawing.Point(3, 130)
        Me.lbTerpakai.Name = "lbTerpakai"
        Me.lbTerpakai.Size = New System.Drawing.Size(413, 25)
        Me.lbTerpakai.TabIndex = 5
        Me.lbTerpakai.Text = "Label15"
        Me.lbTerpakai.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(3, 164)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(413, 18)
        Me.Label16.TabIndex = 6
        Me.Label16.Text = "Pending"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'lbPending
        '
        Me.lbPending.AutoSize = True
        Me.lbPending.Dock = System.Windows.Forms.DockStyle.Top
        Me.lbPending.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbPending.Location = New System.Drawing.Point(3, 182)
        Me.lbPending.Name = "lbPending"
        Me.lbPending.Size = New System.Drawing.Size(413, 25)
        Me.lbPending.TabIndex = 7
        Me.lbPending.Text = "Label17"
        Me.lbPending.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(3, 216)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(413, 18)
        Me.Label18.TabIndex = 8
        Me.Label18.Text = "Saldo Akhir"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'lbSaldoAkhir
        '
        Me.lbSaldoAkhir.AutoSize = True
        Me.lbSaldoAkhir.Dock = System.Windows.Forms.DockStyle.Top
        Me.lbSaldoAkhir.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbSaldoAkhir.Location = New System.Drawing.Point(3, 234)
        Me.lbSaldoAkhir.Name = "lbSaldoAkhir"
        Me.lbSaldoAkhir.Size = New System.Drawing.Size(413, 25)
        Me.lbSaldoAkhir.TabIndex = 9
        Me.lbSaldoAkhir.Text = "Label19"
        Me.lbSaldoAkhir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'btnRiwayat
        '
        Me.btnRiwayat.BackColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.btnRiwayat.BackgroundImage = CType(resources.GetObject("btnRiwayat.BackgroundImage"), System.Drawing.Image)
        Me.btnRiwayat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnRiwayat.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnRiwayat.Location = New System.Drawing.Point(3, 276)
        Me.btnRiwayat.Name = "btnRiwayat"
        Me.btnRiwayat.Size = New System.Drawing.Size(413, 71)
        Me.btnRiwayat.TabIndex = 10
        '
        'btnRequest
        '
        Me.btnRequest.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.btnRequest.BackgroundImage = CType(resources.GetObject("btnRequest.BackgroundImage"), System.Drawing.Image)
        Me.btnRequest.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnRequest.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnRequest.Location = New System.Drawing.Point(3, 353)
        Me.btnRequest.Name = "btnRequest"
        Me.btnRequest.Size = New System.Drawing.Size(413, 71)
        Me.btnRequest.TabIndex = 11
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Label13.Font = New System.Drawing.Font("Bebas Neue Bold", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(428, 117)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(419, 42)
        Me.Label13.TabIndex = 1
        Me.Label13.Text = "Cutiku"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox7
        '
        Me.PictureBox7.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox7.BackgroundImage = CType(resources.GetObject("PictureBox7.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox7.Location = New System.Drawing.Point(1219, 3)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(54, 50)
        Me.PictureBox7.TabIndex = 3
        Me.PictureBox7.TabStop = False
        '
        'PersonelActionDataSetBindingSource
        '
        Me.PersonelActionDataSetBindingSource.DataMember = "personelAction"
        Me.PersonelActionDataSetBindingSource.DataSource = Me.Personel_ActionDataSet
        '
        'menuPanel
        '
        Me.menuPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.menuPanel.Controls.Add(Me.TableLayoutPanel3)
        Me.menuPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.menuPanel.Location = New System.Drawing.Point(0, 0)
        Me.menuPanel.Name = "menuPanel"
        Me.menuPanel.Size = New System.Drawing.Size(1276, 862)
        Me.menuPanel.TabIndex = 2
        Me.menuPanel.Visible = False
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 3
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334!))
        Me.TableLayoutPanel3.Controls.Add(Me.TableLayoutPanel4, 1, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.Label2, 1, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.PictureBox1, 2, 2)
        Me.TableLayoutPanel3.Controls.Add(Me.PictureBox4, 2, 0)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 3
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.53377!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 62.93245!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.53377!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(1276, 862)
        Me.TableLayoutPanel3.TabIndex = 0
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.ColumnCount = 1
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel4.Controls.Add(Me.FlowLayoutPanel3, 0, 2)
        Me.TableLayoutPanel4.Controls.Add(Me.btnSeragamku, 0, 1)
        Me.TableLayoutPanel4.Controls.Add(Me.btnCutiku, 0, 0)
        Me.TableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(428, 162)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 3
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(419, 536)
        Me.TableLayoutPanel4.TabIndex = 0
        '
        'FlowLayoutPanel3
        '
        Me.FlowLayoutPanel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(143, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.FlowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel3.Location = New System.Drawing.Point(3, 359)
        Me.FlowLayoutPanel3.Name = "FlowLayoutPanel3"
        Me.FlowLayoutPanel3.Size = New System.Drawing.Size(413, 174)
        Me.FlowLayoutPanel3.TabIndex = 2
        '
        'btnSeragamku
        '
        Me.btnSeragamku.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.btnSeragamku.BackgroundImage = CType(resources.GetObject("btnSeragamku.BackgroundImage"), System.Drawing.Image)
        Me.btnSeragamku.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnSeragamku.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnSeragamku.Location = New System.Drawing.Point(3, 181)
        Me.btnSeragamku.Name = "btnSeragamku"
        Me.btnSeragamku.Size = New System.Drawing.Size(413, 172)
        Me.btnSeragamku.TabIndex = 1
        '
        'btnCutiku
        '
        Me.btnCutiku.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.btnCutiku.BackgroundImage = CType(resources.GetObject("btnCutiku.BackgroundImage"), System.Drawing.Image)
        Me.btnCutiku.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnCutiku.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnCutiku.Location = New System.Drawing.Point(3, 3)
        Me.btnCutiku.Name = "btnCutiku"
        Me.btnCutiku.Size = New System.Drawing.Size(413, 172)
        Me.btnCutiku.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Label2.Font = New System.Drawing.Font("Bebas Neue Bold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(428, 134)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(419, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Welcome"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(1219, 814)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(54, 45)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox4.BackgroundImage = CType(resources.GetObject("PictureBox4.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox4.Location = New System.Drawing.Point(1219, 3)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(54, 50)
        Me.PictureBox4.TabIndex = 4
        Me.PictureBox4.TabStop = False
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.PictureBox3, 2, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Label8, 0, 2)
        Me.TableLayoutPanel1.Font = New System.Drawing.Font("Trebuchet MS", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1276, 859)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel2.ColumnCount = 1
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.tbKPK, 0, 1)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(428, 289)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 2
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(419, 280)
        Me.TableLayoutPanel2.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Label1.Font = New System.Drawing.Font("Trebuchet MS", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 113)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(413, 27)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "SCAN KPK ANDA"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tbKPK
        '
        Me.tbKPK.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbKPK.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(79, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.tbKPK.Font = New System.Drawing.Font("Trebuchet MS", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbKPK.Location = New System.Drawing.Point(3, 143)
        Me.tbKPK.Name = "tbKPK"
        Me.tbKPK.Size = New System.Drawing.Size(413, 32)
        Me.tbKPK.TabIndex = 2
        Me.tbKPK.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.tbKPK.UseSystemPasswordChar = True
        '
        'PictureBox3
        '
        Me.PictureBox3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(1219, 811)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(54, 45)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 3
        Me.PictureBox3.TabStop = False
        '
        'Label8
        '
        Me.Label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(3, 841)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(231, 18)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = "Tekan Alt + F4 untuk menutupaplikasi ini"
        '
        'loginPanel
        '
        Me.loginPanel.BackColor = System.Drawing.Color.Transparent
        Me.loginPanel.Controls.Add(Me.TableLayoutPanel1)
        Me.loginPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.loginPanel.Location = New System.Drawing.Point(0, 0)
        Me.loginPanel.Name = "loginPanel"
        Me.loginPanel.Size = New System.Drawing.Size(1276, 862)
        Me.loginPanel.TabIndex = 2
        Me.loginPanel.Visible = False
        '
        'ActionCodeBindingSource
        '
        Me.ActionCodeBindingSource.DataMember = "actionCode"
        Me.ActionCodeBindingSource.DataSource = Me.Personel_ActionDataSet
        '
        'requestCutiPanel
        '
        Me.requestCutiPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.requestCutiPanel.Controls.Add(Me.TableLayoutPanel5)
        Me.requestCutiPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.requestCutiPanel.Location = New System.Drawing.Point(0, 0)
        Me.requestCutiPanel.Name = "requestCutiPanel"
        Me.requestCutiPanel.Size = New System.Drawing.Size(1276, 862)
        Me.requestCutiPanel.TabIndex = 3
        Me.requestCutiPanel.Visible = False
        '
        'TableLayoutPanel5
        '
        Me.TableLayoutPanel5.ColumnCount = 3
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334!))
        Me.TableLayoutPanel5.Controls.Add(Me.PictureBox2, 2, 2)
        Me.TableLayoutPanel5.Controls.Add(Me.TableLayoutPanel6, 1, 1)
        Me.TableLayoutPanel5.Controls.Add(Me.Label3, 1, 0)
        Me.TableLayoutPanel5.Controls.Add(Me.PictureBox5, 2, 0)
        Me.TableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel5.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel5.Name = "TableLayoutPanel5"
        Me.TableLayoutPanel5.RowCount = 3
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.53377!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 62.93245!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.53377!))
        Me.TableLayoutPanel5.Size = New System.Drawing.Size(1276, 862)
        Me.TableLayoutPanel5.TabIndex = 0
        '
        'PictureBox2
        '
        Me.PictureBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(1219, 814)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(54, 45)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 2
        Me.PictureBox2.TabStop = False
        '
        'TableLayoutPanel6
        '
        Me.TableLayoutPanel6.ColumnCount = 1
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel6.Controls.Add(Me.cbTipeCuti, 0, 1)
        Me.TableLayoutPanel6.Controls.Add(Me.Label4, 0, 0)
        Me.TableLayoutPanel6.Controls.Add(Me.Label5, 0, 2)
        Me.TableLayoutPanel6.Controls.Add(Me.Label6, 0, 4)
        Me.TableLayoutPanel6.Controls.Add(Me.dtMulai, 0, 3)
        Me.TableLayoutPanel6.Controls.Add(Me.dtAkhir, 0, 5)
        Me.TableLayoutPanel6.Controls.Add(Me.Label7, 0, 6)
        Me.TableLayoutPanel6.Controls.Add(Me.tbNomorDarurat, 0, 7)
        Me.TableLayoutPanel6.Controls.Add(Me.submitCuti, 0, 9)
        Me.TableLayoutPanel6.Controls.Add(Me.ProgressBar1, 0, 8)
        Me.TableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel6.Location = New System.Drawing.Point(428, 162)
        Me.TableLayoutPanel6.Name = "TableLayoutPanel6"
        Me.TableLayoutPanel6.RowCount = 10
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.171642!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.276119!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.731343!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.902985!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.544776!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.902985!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.544776!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.089552!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.850746!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 54.47761!))
        Me.TableLayoutPanel6.Size = New System.Drawing.Size(419, 536)
        Me.TableLayoutPanel6.TabIndex = 0
        '
        'cbTipeCuti
        '
        Me.cbTipeCuti.DataSource = Me.ActionCodeBindingSource
        Me.cbTipeCuti.DisplayMember = "Description"
        Me.cbTipeCuti.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cbTipeCuti.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbTipeCuti.FormattingEnabled = True
        Me.cbTipeCuti.Location = New System.Drawing.Point(3, 19)
        Me.cbTipeCuti.Name = "cbTipeCuti"
        Me.cbTipeCuti.Size = New System.Drawing.Size(413, 33)
        Me.cbTipeCuti.TabIndex = 0
        Me.cbTipeCuti.ValueMember = "ID"
        '
        'Label4
        '
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(3, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(413, 16)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Tipe Cuti"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(3, 55)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(413, 18)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Tanggal Mulai"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(3, 109)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(413, 18)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Tanggal Akhir"
        '
        'dtMulai
        '
        Me.dtMulai.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dtMulai.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtMulai.Location = New System.Drawing.Point(3, 76)
        Me.dtMulai.Name = "dtMulai"
        Me.dtMulai.Size = New System.Drawing.Size(413, 31)
        Me.dtMulai.TabIndex = 4
        '
        'dtAkhir
        '
        Me.dtAkhir.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dtAkhir.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtAkhir.Location = New System.Drawing.Point(3, 130)
        Me.dtAkhir.Name = "dtAkhir"
        Me.dtAkhir.Size = New System.Drawing.Size(413, 31)
        Me.dtAkhir.TabIndex = 5
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(3, 163)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(413, 18)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Nomor yang dapat di hubungi"
        '
        'tbNomorDarurat
        '
        Me.tbNomorDarurat.BackColor = System.Drawing.Color.WhiteSmoke
        Me.tbNomorDarurat.Dock = System.Windows.Forms.DockStyle.Top
        Me.tbNomorDarurat.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbNomorDarurat.Location = New System.Drawing.Point(3, 184)
        Me.tbNomorDarurat.Name = "tbNomorDarurat"
        Me.tbNomorDarurat.Size = New System.Drawing.Size(413, 31)
        Me.tbNomorDarurat.TabIndex = 7
        '
        'submitCuti
        '
        Me.submitCuti.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.submitCuti.BackgroundImage = CType(resources.GetObject("submitCuti.BackgroundImage"), System.Drawing.Image)
        Me.submitCuti.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.submitCuti.Dock = System.Windows.Forms.DockStyle.Top
        Me.submitCuti.Location = New System.Drawing.Point(3, 246)
        Me.submitCuti.Name = "submitCuti"
        Me.submitCuti.Size = New System.Drawing.Size(413, 88)
        Me.submitCuti.TabIndex = 8
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ProgressBar1.Location = New System.Drawing.Point(3, 221)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(413, 19)
        Me.ProgressBar1.TabIndex = 9
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Label3.Font = New System.Drawing.Font("Bebas Neue Bold", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(428, 117)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(419, 42)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Cutiku"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox5
        '
        Me.PictureBox5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox5.BackgroundImage = CType(resources.GetObject("PictureBox5.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox5.Location = New System.Drawing.Point(1219, 3)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(54, 50)
        Me.PictureBox5.TabIndex = 3
        Me.PictureBox5.TabStop = False
        '
        'ActionCodeTableAdapter
        '
        Me.ActionCodeTableAdapter.ClearBeforeFill = True
        '
        'PersonelActionTableAdapter
        '
        Me.PersonelActionTableAdapter.ClearBeforeFill = True
        '
        'ApprovalTableAdapter
        '
        Me.ApprovalTableAdapter.ClearBeforeFill = True
        '
        'SectionBindingSource
        '
        Me.SectionBindingSource.DataMember = "dept"
        Me.SectionBindingSource.DataSource = Me.EmployeeDataSet
        '
        'DeptTableAdapter
        '
        Me.DeptTableAdapter.ClearBeforeFill = True
        '
        'TipeBindingSource
        '
        Me.TipeBindingSource.DataMember = "actionCode"
        Me.TipeBindingSource.DataSource = Me.Personel_ActionDataSet
        '
        'ActionCodeBindingSource1
        '
        Me.ActionCodeBindingSource1.DataMember = "actionCode"
        Me.ActionCodeBindingSource1.DataSource = Me.PersonelActionDataSetBindingSource
        '
        'ApprovalBindingSource
        '
        Me.ApprovalBindingSource.DataSource = Me.PersonelActionDataSetBindingSource
        '
        'seragamkuPanel
        '
        Me.seragamkuPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.seragamkuPanel.Controls.Add(Me.TableLayoutPanel11)
        Me.seragamkuPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.seragamkuPanel.Location = New System.Drawing.Point(0, 0)
        Me.seragamkuPanel.Name = "seragamkuPanel"
        Me.seragamkuPanel.Size = New System.Drawing.Size(1276, 862)
        Me.seragamkuPanel.TabIndex = 1
        '
        'TableLayoutPanel11
        '
        Me.TableLayoutPanel11.ColumnCount = 3
        Me.TableLayoutPanel11.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
        Me.TableLayoutPanel11.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 71.42857!))
        Me.TableLayoutPanel11.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
        Me.TableLayoutPanel11.Controls.Add(Me.TableLayoutPanel12, 1, 1)
        Me.TableLayoutPanel11.Controls.Add(Me.PictureBox10, 2, 0)
        Me.TableLayoutPanel11.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel11.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel11.Name = "TableLayoutPanel11"
        Me.TableLayoutPanel11.RowCount = 3
        Me.TableLayoutPanel11.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel11.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80.0!))
        Me.TableLayoutPanel11.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel11.Size = New System.Drawing.Size(1276, 862)
        Me.TableLayoutPanel11.TabIndex = 6
        '
        'TableLayoutPanel12
        '
        Me.TableLayoutPanel12.ColumnCount = 2
        Me.TableLayoutPanel12.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel12.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 90.0!))
        Me.TableLayoutPanel12.Controls.Add(Me.TableLayoutPanel14, 0, 3)
        Me.TableLayoutPanel12.Controls.Add(Me.opt2Panel, 1, 3)
        Me.TableLayoutPanel12.Controls.Add(Me.opt1Panel, 1, 1)
        Me.TableLayoutPanel12.Controls.Add(Me.TableLayoutPanel13, 0, 1)
        Me.TableLayoutPanel12.Controls.Add(Me.Panel1, 0, 0)
        Me.TableLayoutPanel12.Controls.Add(Me.Panel3, 0, 2)
        Me.TableLayoutPanel12.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel12.Location = New System.Drawing.Point(185, 89)
        Me.TableLayoutPanel12.Name = "TableLayoutPanel12"
        Me.TableLayoutPanel12.RowCount = 4
        Me.TableLayoutPanel12.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.TableLayoutPanel12.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45.0!))
        Me.TableLayoutPanel12.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.TableLayoutPanel12.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45.0!))
        Me.TableLayoutPanel12.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel12.Size = New System.Drawing.Size(905, 683)
        Me.TableLayoutPanel12.TabIndex = 0
        '
        'TableLayoutPanel14
        '
        Me.TableLayoutPanel14.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.TableLayoutPanel14.ColumnCount = 1
        Me.TableLayoutPanel14.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel14.Controls.Add(Me.btnOpt2Pants, 0, 1)
        Me.TableLayoutPanel14.Controls.Add(Me.btnOpt2Shirt, 0, 0)
        Me.TableLayoutPanel14.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel14.Location = New System.Drawing.Point(3, 378)
        Me.TableLayoutPanel14.Name = "TableLayoutPanel14"
        Me.TableLayoutPanel14.RowCount = 2
        Me.TableLayoutPanel14.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel14.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel14.Size = New System.Drawing.Size(84, 302)
        Me.TableLayoutPanel14.TabIndex = 5
        '
        'btnOpt2Pants
        '
        Me.btnOpt2Pants.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnOpt2Pants.BackgroundImage = CType(resources.GetObject("btnOpt2Pants.BackgroundImage"), System.Drawing.Image)
        Me.btnOpt2Pants.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnOpt2Pants.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnOpt2Pants.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOpt2Pants.Location = New System.Drawing.Point(3, 154)
        Me.btnOpt2Pants.Name = "btnOpt2Pants"
        Me.btnOpt2Pants.Size = New System.Drawing.Size(78, 145)
        Me.btnOpt2Pants.TabIndex = 2
        Me.btnOpt2Pants.UseVisualStyleBackColor = False
        '
        'btnOpt2Shirt
        '
        Me.btnOpt2Shirt.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnOpt2Shirt.BackgroundImage = CType(resources.GetObject("btnOpt2Shirt.BackgroundImage"), System.Drawing.Image)
        Me.btnOpt2Shirt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnOpt2Shirt.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnOpt2Shirt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOpt2Shirt.Location = New System.Drawing.Point(3, 3)
        Me.btnOpt2Shirt.Name = "btnOpt2Shirt"
        Me.btnOpt2Shirt.Size = New System.Drawing.Size(78, 145)
        Me.btnOpt2Shirt.TabIndex = 1
        Me.btnOpt2Shirt.UseVisualStyleBackColor = False
        '
        'opt2Panel
        '
        Me.opt2Panel.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.opt2Panel.Controls.Add(Me.opt2PanelShirt)
        Me.opt2Panel.Controls.Add(Me.opt2PanelPants)
        Me.opt2Panel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.opt2Panel.Location = New System.Drawing.Point(93, 378)
        Me.opt2Panel.Name = "opt2Panel"
        Me.opt2Panel.Size = New System.Drawing.Size(809, 302)
        Me.opt2Panel.TabIndex = 1
        '
        'opt2PanelShirt
        '
        Me.opt2PanelShirt.Controls.Add(Me.TableLayoutPanel15)
        Me.opt2PanelShirt.Dock = System.Windows.Forms.DockStyle.Fill
        Me.opt2PanelShirt.Location = New System.Drawing.Point(0, 0)
        Me.opt2PanelShirt.Name = "opt2PanelShirt"
        Me.opt2PanelShirt.Size = New System.Drawing.Size(809, 302)
        Me.opt2PanelShirt.TabIndex = 3
        '
        'TableLayoutPanel15
        '
        Me.TableLayoutPanel15.ColumnCount = 6
        Me.TableLayoutPanel15.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel15.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel15.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel15.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel15.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel15.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel15.Controls.Add(Me.Button1, 0, 1)
        Me.TableLayoutPanel15.Controls.Add(Me.Button2, 1, 1)
        Me.TableLayoutPanel15.Controls.Add(Me.Button11, 2, 1)
        Me.TableLayoutPanel15.Controls.Add(Me.Button12, 3, 1)
        Me.TableLayoutPanel15.Controls.Add(Me.Button13, 4, 1)
        Me.TableLayoutPanel15.Controls.Add(Me.Button14, 5, 1)
        Me.TableLayoutPanel15.Controls.Add(Me.Button15, 0, 3)
        Me.TableLayoutPanel15.Controls.Add(Me.Button16, 1, 3)
        Me.TableLayoutPanel15.Controls.Add(Me.Label19, 0, 0)
        Me.TableLayoutPanel15.Controls.Add(Me.Label20, 0, 2)
        Me.TableLayoutPanel15.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel15.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel15.Name = "TableLayoutPanel15"
        Me.TableLayoutPanel15.RowCount = 4
        Me.TableLayoutPanel15.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.TableLayoutPanel15.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45.0!))
        Me.TableLayoutPanel15.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.TableLayoutPanel15.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45.0!))
        Me.TableLayoutPanel15.Size = New System.Drawing.Size(809, 302)
        Me.TableLayoutPanel15.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(3, 18)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(128, 129)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "S"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(137, 18)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(128, 129)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "M"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button11
        '
        Me.Button11.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button11.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button11.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button11.Location = New System.Drawing.Point(271, 18)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(128, 129)
        Me.Button11.TabIndex = 2
        Me.Button11.Text = "L"
        Me.Button11.UseVisualStyleBackColor = False
        '
        'Button12
        '
        Me.Button12.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button12.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button12.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button12.Location = New System.Drawing.Point(405, 18)
        Me.Button12.Name = "Button12"
        Me.Button12.Size = New System.Drawing.Size(128, 129)
        Me.Button12.TabIndex = 3
        Me.Button12.Text = "XL"
        Me.Button12.UseVisualStyleBackColor = False
        '
        'Button13
        '
        Me.Button13.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button13.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Button13.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button13.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button13.Location = New System.Drawing.Point(539, 18)
        Me.Button13.Name = "Button13"
        Me.Button13.Size = New System.Drawing.Size(128, 129)
        Me.Button13.TabIndex = 4
        Me.Button13.Text = "XXL"
        Me.Button13.UseVisualStyleBackColor = False
        '
        'Button14
        '
        Me.Button14.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button14.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Button14.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button14.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button14.Location = New System.Drawing.Point(673, 18)
        Me.Button14.Name = "Button14"
        Me.Button14.Size = New System.Drawing.Size(133, 129)
        Me.Button14.TabIndex = 5
        Me.Button14.Text = "DL"
        Me.Button14.UseVisualStyleBackColor = False
        '
        'Button15
        '
        Me.Button15.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button15.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Button15.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button15.Location = New System.Drawing.Point(3, 168)
        Me.Button15.Name = "Button15"
        Me.Button15.Size = New System.Drawing.Size(128, 131)
        Me.Button15.TabIndex = 6
        Me.Button15.Text = "Button15"
        Me.Button15.UseVisualStyleBackColor = False
        '
        'Button16
        '
        Me.Button16.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button16.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Button16.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button16.Location = New System.Drawing.Point(137, 168)
        Me.Button16.Name = "Button16"
        Me.Button16.Size = New System.Drawing.Size(128, 131)
        Me.Button16.TabIndex = 7
        Me.Button16.Text = "Button16"
        Me.Button16.UseVisualStyleBackColor = False
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Label19.Location = New System.Drawing.Point(3, 2)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(128, 13)
        Me.Label19.TabIndex = 8
        Me.Label19.Text = "Ukuran"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Label20.Location = New System.Drawing.Point(3, 152)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(128, 13)
        Me.Label20.TabIndex = 9
        Me.Label20.Text = "Lengan"
        '
        'opt2PanelPants
        '
        Me.opt2PanelPants.Dock = System.Windows.Forms.DockStyle.Fill
        Me.opt2PanelPants.Location = New System.Drawing.Point(0, 0)
        Me.opt2PanelPants.Name = "opt2PanelPants"
        Me.opt2PanelPants.Size = New System.Drawing.Size(809, 302)
        Me.opt2PanelPants.TabIndex = 4
        '
        'opt1Panel
        '
        Me.opt1Panel.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.opt1Panel.Controls.Add(Me.opt1PanelShirt)
        Me.opt1Panel.Controls.Add(Me.opt1PanelPants)
        Me.opt1Panel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.opt1Panel.Location = New System.Drawing.Point(93, 37)
        Me.opt1Panel.Name = "opt1Panel"
        Me.opt1Panel.Size = New System.Drawing.Size(809, 301)
        Me.opt1Panel.TabIndex = 3
        '
        'opt1PanelShirt
        '
        Me.opt1PanelShirt.Controls.Add(Me.TableLayoutPanel16)
        Me.opt1PanelShirt.Dock = System.Windows.Forms.DockStyle.Fill
        Me.opt1PanelShirt.Location = New System.Drawing.Point(0, 0)
        Me.opt1PanelShirt.Name = "opt1PanelShirt"
        Me.opt1PanelShirt.Size = New System.Drawing.Size(809, 301)
        Me.opt1PanelShirt.TabIndex = 2
        '
        'TableLayoutPanel16
        '
        Me.TableLayoutPanel16.ColumnCount = 6
        Me.TableLayoutPanel16.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel16.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel16.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel16.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel16.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel16.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel16.Controls.Add(Me.Button3, 0, 1)
        Me.TableLayoutPanel16.Controls.Add(Me.Button4, 1, 1)
        Me.TableLayoutPanel16.Controls.Add(Me.Button5, 2, 1)
        Me.TableLayoutPanel16.Controls.Add(Me.Button6, 3, 1)
        Me.TableLayoutPanel16.Controls.Add(Me.Button7, 4, 1)
        Me.TableLayoutPanel16.Controls.Add(Me.Button8, 5, 1)
        Me.TableLayoutPanel16.Controls.Add(Me.Button9, 0, 3)
        Me.TableLayoutPanel16.Controls.Add(Me.Button10, 1, 3)
        Me.TableLayoutPanel16.Controls.Add(Me.Label15, 0, 0)
        Me.TableLayoutPanel16.Controls.Add(Me.Label17, 0, 2)
        Me.TableLayoutPanel16.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel16.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel16.Name = "TableLayoutPanel16"
        Me.TableLayoutPanel16.RowCount = 4
        Me.TableLayoutPanel16.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.TableLayoutPanel16.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45.0!))
        Me.TableLayoutPanel16.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.TableLayoutPanel16.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45.0!))
        Me.TableLayoutPanel16.Size = New System.Drawing.Size(809, 301)
        Me.TableLayoutPanel16.TabIndex = 0
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(3, 18)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(128, 129)
        Me.Button3.TabIndex = 0
        Me.Button3.Text = "S"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(137, 18)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(128, 129)
        Me.Button4.TabIndex = 1
        Me.Button4.Text = "M"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(271, 18)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(128, 129)
        Me.Button5.TabIndex = 2
        Me.Button5.Text = "L"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.Location = New System.Drawing.Point(405, 18)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(128, 129)
        Me.Button6.TabIndex = 3
        Me.Button6.Text = "XL"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button7.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button7.Location = New System.Drawing.Point(539, 18)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(128, 129)
        Me.Button7.TabIndex = 4
        Me.Button7.Text = "XXL"
        Me.Button7.UseVisualStyleBackColor = False
        '
        'Button8
        '
        Me.Button8.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button8.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button8.Location = New System.Drawing.Point(673, 18)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(133, 129)
        Me.Button8.TabIndex = 5
        Me.Button8.Text = "DL"
        Me.Button8.UseVisualStyleBackColor = False
        '
        'Button9
        '
        Me.Button9.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button9.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button9.Location = New System.Drawing.Point(3, 168)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(128, 130)
        Me.Button9.TabIndex = 6
        Me.Button9.Text = "Button9"
        Me.Button9.UseVisualStyleBackColor = False
        '
        'Button10
        '
        Me.Button10.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button10.Location = New System.Drawing.Point(137, 168)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(128, 130)
        Me.Button10.TabIndex = 7
        Me.Button10.Text = "Button10"
        Me.Button10.UseVisualStyleBackColor = False
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Label15.Location = New System.Drawing.Point(3, 2)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(128, 13)
        Me.Label15.TabIndex = 8
        Me.Label15.Text = "Ukuran"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Label17.Location = New System.Drawing.Point(3, 152)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(128, 13)
        Me.Label17.TabIndex = 9
        Me.Label17.Text = "Lengan"
        '
        'opt1PanelPants
        '
        Me.opt1PanelPants.Dock = System.Windows.Forms.DockStyle.Fill
        Me.opt1PanelPants.Location = New System.Drawing.Point(0, 0)
        Me.opt1PanelPants.Name = "opt1PanelPants"
        Me.opt1PanelPants.Size = New System.Drawing.Size(809, 301)
        Me.opt1PanelPants.TabIndex = 1
        '
        'TableLayoutPanel13
        '
        Me.TableLayoutPanel13.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.TableLayoutPanel13.ColumnCount = 1
        Me.TableLayoutPanel13.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel13.Controls.Add(Me.btnOpt1Shirt, 0, 0)
        Me.TableLayoutPanel13.Controls.Add(Me.btnOpt1Pants, 0, 1)
        Me.TableLayoutPanel13.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel13.Location = New System.Drawing.Point(3, 37)
        Me.TableLayoutPanel13.Name = "TableLayoutPanel13"
        Me.TableLayoutPanel13.RowCount = 2
        Me.TableLayoutPanel13.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel13.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel13.Size = New System.Drawing.Size(84, 301)
        Me.TableLayoutPanel13.TabIndex = 4
        '
        'btnOpt1Shirt
        '
        Me.btnOpt1Shirt.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnOpt1Shirt.BackgroundImage = CType(resources.GetObject("btnOpt1Shirt.BackgroundImage"), System.Drawing.Image)
        Me.btnOpt1Shirt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnOpt1Shirt.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnOpt1Shirt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOpt1Shirt.Location = New System.Drawing.Point(3, 3)
        Me.btnOpt1Shirt.Name = "btnOpt1Shirt"
        Me.btnOpt1Shirt.Size = New System.Drawing.Size(78, 144)
        Me.btnOpt1Shirt.TabIndex = 0
        Me.btnOpt1Shirt.UseVisualStyleBackColor = False
        '
        'btnOpt1Pants
        '
        Me.btnOpt1Pants.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnOpt1Pants.BackgroundImage = CType(resources.GetObject("btnOpt1Pants.BackgroundImage"), System.Drawing.Image)
        Me.btnOpt1Pants.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnOpt1Pants.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnOpt1Pants.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOpt1Pants.Location = New System.Drawing.Point(3, 153)
        Me.btnOpt1Pants.Name = "btnOpt1Pants"
        Me.btnOpt1Pants.Size = New System.Drawing.Size(78, 145)
        Me.btnOpt1Pants.TabIndex = 1
        Me.btnOpt1Pants.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.TableLayoutPanel12.SetColumnSpan(Me.Panel1, 2)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(899, 28)
        Me.Panel1.TabIndex = 8
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label10.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Label10.Font = New System.Drawing.Font("Trebuchet MS", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(0, 1)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(899, 27)
        Me.Label10.TabIndex = 8
        Me.Label10.Text = "Opsi 1"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel3
        '
        Me.TableLayoutPanel12.SetColumnSpan(Me.Panel3, 2)
        Me.Panel3.Controls.Add(Me.Label12)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(3, 344)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(899, 28)
        Me.Panel3.TabIndex = 9
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label12.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Label12.Font = New System.Drawing.Font("Trebuchet MS", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(0, 1)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(899, 27)
        Me.Label12.TabIndex = 8
        Me.Label12.Text = "Opsi 2"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox10
        '
        Me.PictureBox10.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox10.BackgroundImage = CType(resources.GetObject("PictureBox10.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox10.Location = New System.Drawing.Point(1219, 3)
        Me.PictureBox10.Name = "PictureBox10"
        Me.PictureBox10.Size = New System.Drawing.Size(54, 50)
        Me.PictureBox10.TabIndex = 4
        Me.PictureBox10.TabStop = False
        '
        'riwayatCuti
        '
        Me.riwayatCuti.BackColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.riwayatCuti.Controls.Add(Me.TableLayoutPanel9)
        Me.riwayatCuti.Dock = System.Windows.Forms.DockStyle.Fill
        Me.riwayatCuti.Location = New System.Drawing.Point(0, 0)
        Me.riwayatCuti.Name = "riwayatCuti"
        Me.riwayatCuti.Size = New System.Drawing.Size(1276, 862)
        Me.riwayatCuti.TabIndex = 5
        Me.riwayatCuti.Visible = False
        '
        'TableLayoutPanel9
        '
        Me.TableLayoutPanel9.AutoScroll = True
        Me.TableLayoutPanel9.ColumnCount = 3
        Me.TableLayoutPanel9.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.65416!))
        Me.TableLayoutPanel9.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.69168!))
        Me.TableLayoutPanel9.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.65416!))
        Me.TableLayoutPanel9.Controls.Add(Me.PictureBox8, 2, 2)
        Me.TableLayoutPanel9.Controls.Add(Me.TableLayoutPanel10, 1, 1)
        Me.TableLayoutPanel9.Controls.Add(Me.Label25, 1, 0)
        Me.TableLayoutPanel9.Controls.Add(Me.PictureBox9, 2, 0)
        Me.TableLayoutPanel9.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel9.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel9.Name = "TableLayoutPanel9"
        Me.TableLayoutPanel9.RowCount = 3
        Me.TableLayoutPanel9.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.53377!))
        Me.TableLayoutPanel9.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 62.93246!))
        Me.TableLayoutPanel9.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.53377!))
        Me.TableLayoutPanel9.Size = New System.Drawing.Size(1276, 862)
        Me.TableLayoutPanel9.TabIndex = 0
        '
        'PictureBox8
        '
        Me.PictureBox8.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox8.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox8.Image = CType(resources.GetObject("PictureBox8.Image"), System.Drawing.Image)
        Me.PictureBox8.Location = New System.Drawing.Point(1219, 814)
        Me.PictureBox8.Name = "PictureBox8"
        Me.PictureBox8.Size = New System.Drawing.Size(54, 45)
        Me.PictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox8.TabIndex = 2
        Me.PictureBox8.TabStop = False
        '
        'TableLayoutPanel10
        '
        Me.TableLayoutPanel10.ColumnCount = 1
        Me.TableLayoutPanel10.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel10.Controls.Add(Me.DataGridView1, 0, 0)
        Me.TableLayoutPanel10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel10.Location = New System.Drawing.Point(189, 162)
        Me.TableLayoutPanel10.Name = "TableLayoutPanel10"
        Me.TableLayoutPanel10.RowCount = 1
        Me.TableLayoutPanel10.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.973094!))
        Me.TableLayoutPanel10.Size = New System.Drawing.Size(896, 536)
        Me.TableLayoutPanel10.TabIndex = 0
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.SubmitDateDataGridViewTextBoxColumn, Me.ActionCodeDataGridViewTextBoxColumn, Me.EffDateDataGridViewTextBoxColumn, Me.FinDateDataGridViewTextBoxColumn, Me.TotDateDataGridViewTextBoxColumn, Me.EmergencyNumberDataGridViewTextBoxColumn, Me.StatusDataGridViewTextBoxColumn, Me.Remarks})
        Me.DataGridView1.DataSource = Me.PersonelActionBindingSource
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.GridColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.DataGridView1.Location = New System.Drawing.Point(3, 3)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView1.Size = New System.Drawing.Size(890, 530)
        Me.DataGridView1.TabIndex = 0
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Label25.Font = New System.Drawing.Font("Bebas Neue Bold", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(189, 117)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(896, 42)
        Me.Label25.TabIndex = 1
        Me.Label25.Text = "Cutiku"
        Me.Label25.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox9
        '
        Me.PictureBox9.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox9.BackgroundImage = CType(resources.GetObject("PictureBox9.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox9.Location = New System.Drawing.Point(1219, 3)
        Me.PictureBox9.Name = "PictureBox9"
        Me.PictureBox9.Size = New System.Drawing.Size(54, 50)
        Me.PictureBox9.TabIndex = 3
        Me.PictureBox9.TabStop = False
        '
        'PersonelActionBindingSource
        '
        Me.PersonelActionBindingSource.DataSource = Me.PersonelActionDataSetBindingSource
        '
        'PersonelActionDataSetBindingSource1
        '
        Me.PersonelActionDataSetBindingSource1.DataSource = Me.Personel_ActionDataSet
        Me.PersonelActionDataSetBindingSource1.Position = 0
        '
        'PersonelActionDataSetBindingSource2
        '
        Me.PersonelActionDataSetBindingSource2.DataSource = Me.Personel_ActionDataSet
        Me.PersonelActionDataSetBindingSource2.Position = 0
        '
        'EmailBindinSource
        '
        Me.EmailBindinSource.DataMember = "email"
        Me.EmailBindinSource.DataSource = Me.EmployeeDataSet
        '
        'EmailTableAdapter
        '
        Me.EmailTableAdapter.ClearBeforeFill = True
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID Cuti"
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        Me.IDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SubmitDateDataGridViewTextBoxColumn
        '
        Me.SubmitDateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.SubmitDateDataGridViewTextBoxColumn.DataPropertyName = "submitDate"
        Me.SubmitDateDataGridViewTextBoxColumn.HeaderText = "Tanggal Input"
        Me.SubmitDateDataGridViewTextBoxColumn.Name = "SubmitDateDataGridViewTextBoxColumn"
        Me.SubmitDateDataGridViewTextBoxColumn.ReadOnly = True
        Me.SubmitDateDataGridViewTextBoxColumn.Width = 128
        '
        'ActionCodeDataGridViewTextBoxColumn
        '
        Me.ActionCodeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ActionCodeDataGridViewTextBoxColumn.DataPropertyName = "actionCode"
        Me.ActionCodeDataGridViewTextBoxColumn.HeaderText = "Kode Cuti"
        Me.ActionCodeDataGridViewTextBoxColumn.Name = "ActionCodeDataGridViewTextBoxColumn"
        Me.ActionCodeDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EffDateDataGridViewTextBoxColumn
        '
        Me.EffDateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.EffDateDataGridViewTextBoxColumn.DataPropertyName = "effDate"
        Me.EffDateDataGridViewTextBoxColumn.HeaderText = "Tanggal Mulai"
        Me.EffDateDataGridViewTextBoxColumn.Name = "EffDateDataGridViewTextBoxColumn"
        Me.EffDateDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FinDateDataGridViewTextBoxColumn
        '
        Me.FinDateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.FinDateDataGridViewTextBoxColumn.DataPropertyName = "finDate"
        Me.FinDateDataGridViewTextBoxColumn.HeaderText = "Tanggal Akhir"
        Me.FinDateDataGridViewTextBoxColumn.Name = "FinDateDataGridViewTextBoxColumn"
        Me.FinDateDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TotDateDataGridViewTextBoxColumn
        '
        Me.TotDateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.TotDateDataGridViewTextBoxColumn.DataPropertyName = "totDate"
        Me.TotDateDataGridViewTextBoxColumn.HeaderText = "Total Hari"
        Me.TotDateDataGridViewTextBoxColumn.Name = "TotDateDataGridViewTextBoxColumn"
        Me.TotDateDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EmergencyNumberDataGridViewTextBoxColumn
        '
        Me.EmergencyNumberDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.EmergencyNumberDataGridViewTextBoxColumn.DataPropertyName = "emergencyNumber"
        Me.EmergencyNumberDataGridViewTextBoxColumn.HeaderText = "Nomor HP"
        Me.EmergencyNumberDataGridViewTextBoxColumn.Name = "EmergencyNumberDataGridViewTextBoxColumn"
        Me.EmergencyNumberDataGridViewTextBoxColumn.ReadOnly = True
        Me.EmergencyNumberDataGridViewTextBoxColumn.Width = 106
        '
        'StatusDataGridViewTextBoxColumn
        '
        Me.StatusDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.StatusDataGridViewTextBoxColumn.DataPropertyName = "status"
        Me.StatusDataGridViewTextBoxColumn.HeaderText = "Status"
        Me.StatusDataGridViewTextBoxColumn.Name = "StatusDataGridViewTextBoxColumn"
        Me.StatusDataGridViewTextBoxColumn.ReadOnly = True
        '
        'Remarks
        '
        Me.Remarks.DataPropertyName = "remarks"
        Me.Remarks.HeaderText = "Remarks"
        Me.Remarks.Name = "Remarks"
        Me.Remarks.ReadOnly = True
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(1276, 862)
        Me.ControlBox = False
        Me.Controls.Add(Me.riwayatCuti)
        Me.Controls.Add(Me.loginPanel)
        Me.Controls.Add(Me.menuPanel)
        Me.Controls.Add(Me.cutikuPanel)
        Me.Controls.Add(Me.requestCutiPanel)
        Me.Controls.Add(Me.seragamkuPanel)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Login"
        Me.Text = "KIOSK"
        CType(Me.Personel_ActionDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmployeeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmployeeDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cutikuPanel.ResumeLayout(False)
        Me.TableLayoutPanel7.ResumeLayout(False)
        Me.TableLayoutPanel7.PerformLayout()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel8.ResumeLayout(False)
        Me.TableLayoutPanel8.PerformLayout()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PersonelActionDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.menuPanel.ResumeLayout(False)
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        Me.TableLayoutPanel4.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.loginPanel.ResumeLayout(False)
        CType(Me.ActionCodeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.requestCutiPanel.ResumeLayout(False)
        Me.TableLayoutPanel5.ResumeLayout(False)
        Me.TableLayoutPanel5.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel6.ResumeLayout(False)
        Me.TableLayoutPanel6.PerformLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SectionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TipeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ActionCodeBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ApprovalBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.seragamkuPanel.ResumeLayout(False)
        Me.TableLayoutPanel11.ResumeLayout(False)
        Me.TableLayoutPanel12.ResumeLayout(False)
        Me.TableLayoutPanel14.ResumeLayout(False)
        Me.opt2Panel.ResumeLayout(False)
        Me.opt2PanelShirt.ResumeLayout(False)
        Me.TableLayoutPanel15.ResumeLayout(False)
        Me.TableLayoutPanel15.PerformLayout()
        Me.opt1Panel.ResumeLayout(False)
        Me.opt1PanelShirt.ResumeLayout(False)
        Me.TableLayoutPanel16.ResumeLayout(False)
        Me.TableLayoutPanel16.PerformLayout()
        Me.TableLayoutPanel13.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).EndInit()
        Me.riwayatCuti.ResumeLayout(False)
        Me.TableLayoutPanel9.ResumeLayout(False)
        Me.TableLayoutPanel9.PerformLayout()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel10.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PersonelActionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PersonelActionDataSetBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PersonelActionDataSetBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmailBindinSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Personel_ActionDataSet As Personel_ActionDataSet
    Friend WithEvents EmployeeTableAdapter As EmployeeDataSetTableAdapters.EmployeeTableAdapter
    Friend WithEvents EmployeeBindingSource As BindingSource
    Friend WithEvents EmployeeDataSet As EmployeeDataSet
    Friend WithEvents cutikuPanel As Panel
    Friend WithEvents TableLayoutPanel7 As TableLayoutPanel
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents TableLayoutPanel8 As TableLayoutPanel
    Friend WithEvents Label9 As Label
    Friend WithEvents lbSaldoAwal As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents lbBonus As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents lbTerpakai As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents lbPending As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents lbSaldoAkhir As Label
    Friend WithEvents btnRiwayat As FlowLayoutPanel
    Friend WithEvents btnRequest As FlowLayoutPanel
    Friend WithEvents Label13 As Label
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents PersonelActionDataSetBindingSource As BindingSource
    Friend WithEvents menuPanel As Panel
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents FlowLayoutPanel3 As FlowLayoutPanel
    Friend WithEvents btnSeragamku As FlowLayoutPanel
    Friend WithEvents btnCutiku As FlowLayoutPanel
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents tbKPK As TextBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Label8 As Label
    Friend WithEvents loginPanel As Panel
    Friend WithEvents ActionCodeBindingSource As BindingSource
    Friend WithEvents requestCutiPanel As Panel
    Friend WithEvents TableLayoutPanel5 As TableLayoutPanel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents TableLayoutPanel6 As TableLayoutPanel
    Friend WithEvents cbTipeCuti As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents dtMulai As DateTimePicker
    Friend WithEvents dtAkhir As DateTimePicker
    Friend WithEvents Label7 As Label
    Friend WithEvents tbNomorDarurat As TextBox
    Friend WithEvents submitCuti As FlowLayoutPanel
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents ActionCodeTableAdapter As Personel_ActionDataSetTableAdapters.actionCodeTableAdapter
    Friend WithEvents PersonelActionTableAdapter As Personel_ActionDataSetTableAdapters.personelActionTableAdapter
    Friend WithEvents ApprovalTableAdapter As Personel_ActionDataSetTableAdapters.approvalTableAdapter
    Friend WithEvents SectionBindingSource As BindingSource
    Friend WithEvents DeptTableAdapter As EmployeeDataSetTableAdapters.deptTableAdapter
    Friend WithEvents TipeBindingSource As BindingSource
    Friend WithEvents ActionCodeBindingSource1 As BindingSource
    Friend WithEvents ApprovalBindingSource As BindingSource
    Friend WithEvents seragamkuPanel As Panel
    Friend WithEvents TableLayoutPanel11 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel12 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel14 As TableLayoutPanel
    Friend WithEvents btnOpt2Pants As Button
    Friend WithEvents btnOpt2Shirt As Button
    Friend WithEvents TableLayoutPanel13 As TableLayoutPanel
    Friend WithEvents btnOpt1Shirt As Button
    Friend WithEvents btnOpt1Pants As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label10 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label12 As Label
    Friend WithEvents riwayatCuti As Panel
    Friend WithEvents TableLayoutPanel9 As TableLayoutPanel
    Friend WithEvents PictureBox8 As PictureBox
    Friend WithEvents TableLayoutPanel10 As TableLayoutPanel
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label25 As Label
    Friend WithEvents PictureBox9 As PictureBox
    Friend WithEvents PersonelActionBindingSource As BindingSource
    Friend WithEvents PictureBox10 As PictureBox
    Friend WithEvents opt2Panel As Panel
    Friend WithEvents opt1Panel As Panel
    Friend WithEvents opt1PanelShirt As Panel
    Friend WithEvents TableLayoutPanel16 As TableLayoutPanel
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents Button9 As Button
    Friend WithEvents Button10 As Button
    Friend WithEvents opt1PanelPants As Panel
    Friend WithEvents Label15 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents opt2PanelShirt As Panel
    Friend WithEvents TableLayoutPanel15 As TableLayoutPanel
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button11 As Button
    Friend WithEvents Button12 As Button
    Friend WithEvents Button13 As Button
    Friend WithEvents Button14 As Button
    Friend WithEvents Button15 As Button
    Friend WithEvents Button16 As Button
    Friend WithEvents Label19 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents opt2PanelPants As Panel
    Friend WithEvents PersonelActionDataSetBindingSource2 As BindingSource
    Friend WithEvents PersonelActionDataSetBindingSource1 As BindingSource
    Friend WithEvents EmailBindinSource As BindingSource
    Friend WithEvents EmailTableAdapter As EmployeeDataSetTableAdapters.emailTableAdapter
    Friend WithEvents IDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SubmitDateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ActionCodeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EffDateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FinDateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TotDateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EmergencyNumberDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StatusDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Remarks As DataGridViewTextBoxColumn
End Class
