<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmInventory
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmInventory))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbModel = New System.Windows.Forms.ComboBox()
        Me.cmbCondition = New System.Windows.Forms.ComboBox()
        Me.cmbCompany = New System.Windows.Forms.ComboBox()
        Me.cmbYear = New System.Windows.Forms.ComboBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.rbV12 = New System.Windows.Forms.RadioButton()
        Me.rbV10 = New System.Windows.Forms.RadioButton()
        Me.rbV8 = New System.Windows.Forms.RadioButton()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox = New System.Windows.Forms.GroupBox()
        Me.rbManual = New System.Windows.Forms.RadioButton()
        Me.rbDual = New System.Windows.Forms.RadioButton()
        Me.rbAuto = New System.Windows.Forms.RadioButton()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.rbAll = New System.Windows.Forms.RadioButton()
        Me.rbBack = New System.Windows.Forms.RadioButton()
        Me.rbFront = New System.Windows.Forms.RadioButton()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.rbWhite = New System.Windows.Forms.RadioButton()
        Me.rbRed = New System.Windows.Forms.RadioButton()
        Me.rbBlack = New System.Windows.Forms.RadioButton()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.cb12 = New System.Windows.Forms.CheckBox()
        Me.cb11 = New System.Windows.Forms.CheckBox()
        Me.cb10 = New System.Windows.Forms.CheckBox()
        Me.cb9 = New System.Windows.Forms.CheckBox()
        Me.cb8 = New System.Windows.Forms.CheckBox()
        Me.cb7 = New System.Windows.Forms.CheckBox()
        Me.cb6 = New System.Windows.Forms.CheckBox()
        Me.cb5 = New System.Windows.Forms.CheckBox()
        Me.cb4 = New System.Windows.Forms.CheckBox()
        Me.cb3 = New System.Windows.Forms.CheckBox()
        Me.cb2 = New System.Windows.Forms.CheckBox()
        Me.cb1 = New System.Windows.Forms.CheckBox()
        Me.lstOutput = New System.Windows.Forms.ListBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveAsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChangeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VINToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CompressToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DecompressToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.picA1 = New System.Windows.Forms.PictureBox()
        Me.lblVIN = New System.Windows.Forms.Label()
        Me.picA2 = New System.Windows.Forms.PictureBox()
        Me.picA3 = New System.Windows.Forms.PictureBox()
        Me.picB1 = New System.Windows.Forms.PictureBox()
        Me.picB2 = New System.Windows.Forms.PictureBox()
        Me.picB3 = New System.Windows.Forms.PictureBox()
        Me.picM1 = New System.Windows.Forms.PictureBox()
        Me.picM2 = New System.Windows.Forms.PictureBox()
        Me.picM3 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.picA1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picA2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picA3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picB1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picB2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picB3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picM1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picM2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picM3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.cmbModel)
        Me.GroupBox1.Controls.Add(Me.cmbCondition)
        Me.GroupBox1.Controls.Add(Me.cmbCompany)
        Me.GroupBox1.Controls.Add(Me.cmbYear)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 27)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(438, 72)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.DarkRed
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(339, 12)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(93, 21)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Model"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.DarkRed
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(117, 12)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(93, 21)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Condition"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.DarkRed
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(228, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(93, 21)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Company"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.DarkRed
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(6, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(93, 21)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Year"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'cmbModel
        '
        Me.cmbModel.ForeColor = System.Drawing.Color.Black
        Me.cmbModel.FormattingEnabled = True
        Me.cmbModel.Location = New System.Drawing.Point(339, 36)
        Me.cmbModel.Name = "cmbModel"
        Me.cmbModel.Size = New System.Drawing.Size(93, 21)
        Me.cmbModel.TabIndex = 3
        '
        'cmbCondition
        '
        Me.cmbCondition.ForeColor = System.Drawing.Color.Black
        Me.cmbCondition.FormattingEnabled = True
        Me.cmbCondition.Location = New System.Drawing.Point(117, 36)
        Me.cmbCondition.Name = "cmbCondition"
        Me.cmbCondition.Size = New System.Drawing.Size(93, 21)
        Me.cmbCondition.TabIndex = 2
        '
        'cmbCompany
        '
        Me.cmbCompany.ForeColor = System.Drawing.Color.Black
        Me.cmbCompany.FormattingEnabled = True
        Me.cmbCompany.Location = New System.Drawing.Point(228, 36)
        Me.cmbCompany.Name = "cmbCompany"
        Me.cmbCompany.Size = New System.Drawing.Size(93, 21)
        Me.cmbCompany.TabIndex = 1
        '
        'cmbYear
        '
        Me.cmbYear.ForeColor = System.Drawing.Color.Black
        Me.cmbYear.FormattingEnabled = True
        Me.cmbYear.Location = New System.Drawing.Point(6, 36)
        Me.cmbYear.Name = "cmbYear"
        Me.cmbYear.Size = New System.Drawing.Size(93, 21)
        Me.cmbYear.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.rbV12)
        Me.GroupBox2.Controls.Add(Me.rbV10)
        Me.GroupBox2.Controls.Add(Me.rbV8)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.ForeColor = System.Drawing.Color.White
        Me.GroupBox2.Location = New System.Drawing.Point(12, 105)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(105, 110)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        '
        'rbV12
        '
        Me.rbV12.AutoSize = True
        Me.rbV12.Location = New System.Drawing.Point(6, 86)
        Me.rbV12.Name = "rbV12"
        Me.rbV12.Size = New System.Drawing.Size(44, 17)
        Me.rbV12.TabIndex = 3
        Me.rbV12.TabStop = True
        Me.rbV12.Text = "V12"
        Me.rbV12.UseVisualStyleBackColor = True
        '
        'rbV10
        '
        Me.rbV10.AutoSize = True
        Me.rbV10.Location = New System.Drawing.Point(6, 63)
        Me.rbV10.Name = "rbV10"
        Me.rbV10.Size = New System.Drawing.Size(44, 17)
        Me.rbV10.TabIndex = 2
        Me.rbV10.TabStop = True
        Me.rbV10.Text = "V10"
        Me.rbV10.UseVisualStyleBackColor = True
        '
        'rbV8
        '
        Me.rbV8.AutoSize = True
        Me.rbV8.Location = New System.Drawing.Point(6, 40)
        Me.rbV8.Name = "rbV8"
        Me.rbV8.Size = New System.Drawing.Size(38, 17)
        Me.rbV8.TabIndex = 1
        Me.rbV8.TabStop = True
        Me.rbV8.Text = "V8"
        Me.rbV8.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.DarkRed
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(6, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(93, 21)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Engine"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'GroupBox
        '
        Me.GroupBox.Controls.Add(Me.rbManual)
        Me.GroupBox.Controls.Add(Me.rbDual)
        Me.GroupBox.Controls.Add(Me.rbAuto)
        Me.GroupBox.Controls.Add(Me.Label6)
        Me.GroupBox.ForeColor = System.Drawing.Color.White
        Me.GroupBox.Location = New System.Drawing.Point(123, 105)
        Me.GroupBox.Name = "GroupBox"
        Me.GroupBox.Size = New System.Drawing.Size(105, 110)
        Me.GroupBox.TabIndex = 4
        Me.GroupBox.TabStop = False
        '
        'rbManual
        '
        Me.rbManual.AutoSize = True
        Me.rbManual.Location = New System.Drawing.Point(6, 86)
        Me.rbManual.Name = "rbManual"
        Me.rbManual.Size = New System.Drawing.Size(60, 17)
        Me.rbManual.TabIndex = 3
        Me.rbManual.TabStop = True
        Me.rbManual.Text = "Manual"
        Me.rbManual.UseVisualStyleBackColor = True
        '
        'rbDual
        '
        Me.rbDual.AutoSize = True
        Me.rbDual.Location = New System.Drawing.Point(6, 63)
        Me.rbDual.Name = "rbDual"
        Me.rbDual.Size = New System.Drawing.Size(80, 17)
        Me.rbDual.TabIndex = 2
        Me.rbDual.TabStop = True
        Me.rbDual.Text = "Dual Clutch"
        Me.rbDual.UseVisualStyleBackColor = True
        '
        'rbAuto
        '
        Me.rbAuto.AutoSize = True
        Me.rbAuto.Location = New System.Drawing.Point(6, 40)
        Me.rbAuto.Name = "rbAuto"
        Me.rbAuto.Size = New System.Drawing.Size(72, 17)
        Me.rbAuto.TabIndex = 1
        Me.rbAuto.TabStop = True
        Me.rbAuto.Text = "Automatic"
        Me.rbAuto.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.DarkRed
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(6, 16)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(93, 21)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Transmission"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.rbAll)
        Me.GroupBox4.Controls.Add(Me.rbBack)
        Me.GroupBox4.Controls.Add(Me.rbFront)
        Me.GroupBox4.Controls.Add(Me.Label7)
        Me.GroupBox4.ForeColor = System.Drawing.Color.White
        Me.GroupBox4.Location = New System.Drawing.Point(234, 105)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(105, 110)
        Me.GroupBox4.TabIndex = 4
        Me.GroupBox4.TabStop = False
        '
        'rbAll
        '
        Me.rbAll.AutoSize = True
        Me.rbAll.Location = New System.Drawing.Point(6, 86)
        Me.rbAll.Name = "rbAll"
        Me.rbAll.Size = New System.Drawing.Size(67, 17)
        Me.rbAll.TabIndex = 3
        Me.rbAll.TabStop = True
        Me.rbAll.Text = "All wheel"
        Me.rbAll.UseVisualStyleBackColor = True
        '
        'rbBack
        '
        Me.rbBack.AutoSize = True
        Me.rbBack.Location = New System.Drawing.Point(6, 63)
        Me.rbBack.Name = "rbBack"
        Me.rbBack.Size = New System.Drawing.Size(84, 17)
        Me.rbBack.TabIndex = 2
        Me.rbBack.TabStop = True
        Me.rbBack.Text = "Back Wheel"
        Me.rbBack.UseVisualStyleBackColor = True
        '
        'rbFront
        '
        Me.rbFront.AutoSize = True
        Me.rbFront.Location = New System.Drawing.Point(6, 40)
        Me.rbFront.Name = "rbFront"
        Me.rbFront.Size = New System.Drawing.Size(83, 17)
        Me.rbFront.TabIndex = 1
        Me.rbFront.TabStop = True
        Me.rbFront.Text = "Front Wheel"
        Me.rbFront.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.DarkRed
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(6, 16)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(93, 21)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Drive Train"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'GroupBox5
        '
        Me.GroupBox5.BackColor = System.Drawing.Color.Black
        Me.GroupBox5.Controls.Add(Me.rbWhite)
        Me.GroupBox5.Controls.Add(Me.rbRed)
        Me.GroupBox5.Controls.Add(Me.rbBlack)
        Me.GroupBox5.Controls.Add(Me.Label8)
        Me.GroupBox5.ForeColor = System.Drawing.Color.White
        Me.GroupBox5.Location = New System.Drawing.Point(345, 105)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(105, 110)
        Me.GroupBox5.TabIndex = 4
        Me.GroupBox5.TabStop = False
        '
        'rbWhite
        '
        Me.rbWhite.AutoSize = True
        Me.rbWhite.Location = New System.Drawing.Point(6, 86)
        Me.rbWhite.Name = "rbWhite"
        Me.rbWhite.Size = New System.Drawing.Size(53, 17)
        Me.rbWhite.TabIndex = 3
        Me.rbWhite.TabStop = True
        Me.rbWhite.Text = "White"
        Me.rbWhite.UseVisualStyleBackColor = True
        '
        'rbRed
        '
        Me.rbRed.AutoSize = True
        Me.rbRed.Location = New System.Drawing.Point(6, 63)
        Me.rbRed.Name = "rbRed"
        Me.rbRed.Size = New System.Drawing.Size(45, 17)
        Me.rbRed.TabIndex = 2
        Me.rbRed.TabStop = True
        Me.rbRed.Text = "Red"
        Me.rbRed.UseVisualStyleBackColor = True
        '
        'rbBlack
        '
        Me.rbBlack.AutoSize = True
        Me.rbBlack.Location = New System.Drawing.Point(6, 40)
        Me.rbBlack.Name = "rbBlack"
        Me.rbBlack.Size = New System.Drawing.Size(52, 17)
        Me.rbBlack.TabIndex = 1
        Me.rbBlack.TabStop = True
        Me.rbBlack.Text = "Black"
        Me.rbBlack.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.DarkRed
        Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(6, 16)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(93, 21)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Color"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.cb12)
        Me.GroupBox6.Controls.Add(Me.cb11)
        Me.GroupBox6.Controls.Add(Me.cb10)
        Me.GroupBox6.Controls.Add(Me.cb9)
        Me.GroupBox6.Controls.Add(Me.cb8)
        Me.GroupBox6.Controls.Add(Me.cb7)
        Me.GroupBox6.Controls.Add(Me.cb6)
        Me.GroupBox6.Controls.Add(Me.cb5)
        Me.GroupBox6.Controls.Add(Me.cb4)
        Me.GroupBox6.Controls.Add(Me.cb3)
        Me.GroupBox6.Controls.Add(Me.cb2)
        Me.GroupBox6.Controls.Add(Me.cb1)
        Me.GroupBox6.ForeColor = System.Drawing.Color.White
        Me.GroupBox6.Location = New System.Drawing.Point(12, 221)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(438, 90)
        Me.GroupBox6.TabIndex = 5
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Extra Features"
        '
        'cb12
        '
        Me.cb12.AutoSize = True
        Me.cb12.Location = New System.Drawing.Point(339, 65)
        Me.cb12.Name = "cb12"
        Me.cb12.Size = New System.Drawing.Size(90, 17)
        Me.cb12.TabIndex = 11
        Me.cb12.Text = "Passive Entry"
        Me.cb12.UseVisualStyleBackColor = True
        '
        'cb11
        '
        Me.cb11.AutoSize = True
        Me.cb11.Location = New System.Drawing.Point(228, 65)
        Me.cb11.Name = "cb11"
        Me.cb11.Size = New System.Drawing.Size(61, 17)
        Me.cb11.TabIndex = 10
        Me.cb11.Text = "Carplay"
        Me.cb11.UseVisualStyleBackColor = True
        '
        'cb10
        '
        Me.cb10.AutoSize = True
        Me.cb10.Location = New System.Drawing.Point(117, 65)
        Me.cb10.Name = "cb10"
        Me.cb10.Size = New System.Drawing.Size(80, 17)
        Me.cb10.TabIndex = 9
        Me.cb10.Text = "Lane Assist"
        Me.cb10.UseVisualStyleBackColor = True
        '
        'cb9
        '
        Me.cb9.AutoSize = True
        Me.cb9.Location = New System.Drawing.Point(6, 65)
        Me.cb9.Name = "cb9"
        Me.cb9.Size = New System.Drawing.Size(77, 17)
        Me.cb9.TabIndex = 8
        Me.cb9.Text = "Navigation"
        Me.cb9.UseVisualStyleBackColor = True
        '
        'cb8
        '
        Me.cb8.AutoSize = True
        Me.cb8.Location = New System.Drawing.Point(339, 42)
        Me.cb8.Name = "cb8"
        Me.cb8.Size = New System.Drawing.Size(87, 17)
        Me.cb8.TabIndex = 7
        Me.cb8.Text = "Auto Braking"
        Me.cb8.UseVisualStyleBackColor = True
        '
        'cb7
        '
        Me.cb7.AutoSize = True
        Me.cb7.Location = New System.Drawing.Point(228, 42)
        Me.cb7.Name = "cb7"
        Me.cb7.Size = New System.Drawing.Size(100, 17)
        Me.cb7.TabIndex = 6
        Me.cb7.Text = "Adaptive Cruise"
        Me.cb7.UseVisualStyleBackColor = True
        '
        'cb6
        '
        Me.cb6.AutoSize = True
        Me.cb6.Location = New System.Drawing.Point(117, 42)
        Me.cb6.Name = "cb6"
        Me.cb6.Size = New System.Drawing.Size(102, 17)
        Me.cb6.TabIndex = 5
        Me.cb6.Text = "Backup Camera"
        Me.cb6.UseVisualStyleBackColor = True
        '
        'cb5
        '
        Me.cb5.AutoSize = True
        Me.cb5.Location = New System.Drawing.Point(6, 42)
        Me.cb5.Name = "cb5"
        Me.cb5.Size = New System.Drawing.Size(63, 17)
        Me.cb5.TabIndex = 4
        Me.cb5.Text = "Mufflers"
        Me.cb5.UseVisualStyleBackColor = True
        '
        'cb4
        '
        Me.cb4.AutoSize = True
        Me.cb4.Location = New System.Drawing.Point(339, 19)
        Me.cb4.Name = "cb4"
        Me.cb4.Size = New System.Drawing.Size(100, 17)
        Me.cb4.TabIndex = 3
        Me.cb4.Text = "LED Headlights"
        Me.cb4.UseVisualStyleBackColor = True
        '
        'cb3
        '
        Me.cb3.AutoSize = True
        Me.cb3.Location = New System.Drawing.Point(228, 19)
        Me.cb3.Name = "cb3"
        Me.cb3.Size = New System.Drawing.Size(88, 17)
        Me.cb3.TabIndex = 2
        Me.cb3.Text = "Remote Start"
        Me.cb3.UseVisualStyleBackColor = True
        '
        'cb2
        '
        Me.cb2.AutoSize = True
        Me.cb2.Location = New System.Drawing.Point(117, 19)
        Me.cb2.Name = "cb2"
        Me.cb2.Size = New System.Drawing.Size(88, 17)
        Me.cb2.TabIndex = 1
        Me.cb2.Text = "Seat Warmer"
        Me.cb2.UseVisualStyleBackColor = True
        '
        'cb1
        '
        Me.cb1.AutoSize = True
        Me.cb1.Location = New System.Drawing.Point(6, 19)
        Me.cb1.Name = "cb1"
        Me.cb1.Size = New System.Drawing.Size(92, 17)
        Me.cb1.TabIndex = 0
        Me.cb1.Text = "Leather Seats"
        Me.cb1.UseVisualStyleBackColor = True
        '
        'lstOutput
        '
        Me.lstOutput.BackColor = System.Drawing.Color.White
        Me.lstOutput.ForeColor = System.Drawing.Color.Black
        Me.lstOutput.FormattingEnabled = True
        Me.lstOutput.Location = New System.Drawing.Point(465, 32)
        Me.lstOutput.Name = "lstOutput"
        Me.lstOutput.Size = New System.Drawing.Size(169, 121)
        Me.lstOutput.TabIndex = 6
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.EditToolStripMenuItem, Me.VINToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(646, 24)
        Me.MenuStrip1.TabIndex = 8
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenToolStripMenuItem, Me.SaveAsToolStripMenuItem, Me.SaveToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'OpenToolStripMenuItem
        '
        Me.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
        Me.OpenToolStripMenuItem.Size = New System.Drawing.Size(114, 22)
        Me.OpenToolStripMenuItem.Text = "Open"
        '
        'SaveAsToolStripMenuItem
        '
        Me.SaveAsToolStripMenuItem.Name = "SaveAsToolStripMenuItem"
        Me.SaveAsToolStripMenuItem.Size = New System.Drawing.Size(114, 22)
        Me.SaveAsToolStripMenuItem.Text = "Save As"
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(114, 22)
        Me.SaveToolStripMenuItem.Text = "Save"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddToolStripMenuItem, Me.DeleteToolStripMenuItem, Me.ChangeToolStripMenuItem})
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(39, 20)
        Me.EditToolStripMenuItem.Text = "Edit"
        '
        'AddToolStripMenuItem
        '
        Me.AddToolStripMenuItem.Name = "AddToolStripMenuItem"
        Me.AddToolStripMenuItem.Size = New System.Drawing.Size(115, 22)
        Me.AddToolStripMenuItem.Text = "Add"
        '
        'DeleteToolStripMenuItem
        '
        Me.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem"
        Me.DeleteToolStripMenuItem.Size = New System.Drawing.Size(115, 22)
        Me.DeleteToolStripMenuItem.Text = "Delete"
        '
        'ChangeToolStripMenuItem
        '
        Me.ChangeToolStripMenuItem.Name = "ChangeToolStripMenuItem"
        Me.ChangeToolStripMenuItem.Size = New System.Drawing.Size(115, 22)
        Me.ChangeToolStripMenuItem.Text = "Change"
        '
        'VINToolStripMenuItem
        '
        Me.VINToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CompressToolStripMenuItem, Me.DecompressToolStripMenuItem})
        Me.VINToolStripMenuItem.Name = "VINToolStripMenuItem"
        Me.VINToolStripMenuItem.Size = New System.Drawing.Size(38, 20)
        Me.VINToolStripMenuItem.Text = "VIN"
        '
        'CompressToolStripMenuItem
        '
        Me.CompressToolStripMenuItem.Name = "CompressToolStripMenuItem"
        Me.CompressToolStripMenuItem.Size = New System.Drawing.Size(139, 22)
        Me.CompressToolStripMenuItem.Text = "Compress"
        '
        'DecompressToolStripMenuItem
        '
        Me.DecompressToolStripMenuItem.Name = "DecompressToolStripMenuItem"
        Me.DecompressToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.DecompressToolStripMenuItem.Text = "Decompress"
        '
        'picA1
        '
        Me.picA1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picA1.Image = CType(resources.GetObject("picA1.Image"), System.Drawing.Image)
        Me.picA1.Location = New System.Drawing.Point(465, 180)
        Me.picA1.Name = "picA1"
        Me.picA1.Size = New System.Drawing.Size(169, 131)
        Me.picA1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picA1.TabIndex = 9
        Me.picA1.TabStop = False
        Me.picA1.Visible = False
        '
        'lblVIN
        '
        Me.lblVIN.BackColor = System.Drawing.Color.DarkRed
        Me.lblVIN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblVIN.ForeColor = System.Drawing.Color.White
        Me.lblVIN.Location = New System.Drawing.Point(465, 156)
        Me.lblVIN.Name = "lblVIN"
        Me.lblVIN.Size = New System.Drawing.Size(169, 21)
        Me.lblVIN.TabIndex = 10
        Me.lblVIN.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'picA2
        '
        Me.picA2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picA2.Image = CType(resources.GetObject("picA2.Image"), System.Drawing.Image)
        Me.picA2.Location = New System.Drawing.Point(465, 180)
        Me.picA2.Name = "picA2"
        Me.picA2.Size = New System.Drawing.Size(169, 131)
        Me.picA2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picA2.TabIndex = 11
        Me.picA2.TabStop = False
        Me.picA2.Visible = False
        '
        'picA3
        '
        Me.picA3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picA3.Image = CType(resources.GetObject("picA3.Image"), System.Drawing.Image)
        Me.picA3.Location = New System.Drawing.Point(465, 180)
        Me.picA3.Name = "picA3"
        Me.picA3.Size = New System.Drawing.Size(169, 131)
        Me.picA3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picA3.TabIndex = 12
        Me.picA3.TabStop = False
        Me.picA3.Visible = False
        '
        'picB1
        '
        Me.picB1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picB1.Image = CType(resources.GetObject("picB1.Image"), System.Drawing.Image)
        Me.picB1.Location = New System.Drawing.Point(465, 180)
        Me.picB1.Name = "picB1"
        Me.picB1.Size = New System.Drawing.Size(169, 131)
        Me.picB1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picB1.TabIndex = 13
        Me.picB1.TabStop = False
        Me.picB1.Visible = False
        '
        'picB2
        '
        Me.picB2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picB2.Image = CType(resources.GetObject("picB2.Image"), System.Drawing.Image)
        Me.picB2.Location = New System.Drawing.Point(465, 180)
        Me.picB2.Name = "picB2"
        Me.picB2.Size = New System.Drawing.Size(169, 131)
        Me.picB2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picB2.TabIndex = 14
        Me.picB2.TabStop = False
        Me.picB2.Visible = False
        '
        'picB3
        '
        Me.picB3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picB3.Image = CType(resources.GetObject("picB3.Image"), System.Drawing.Image)
        Me.picB3.Location = New System.Drawing.Point(465, 180)
        Me.picB3.Name = "picB3"
        Me.picB3.Size = New System.Drawing.Size(169, 131)
        Me.picB3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picB3.TabIndex = 15
        Me.picB3.TabStop = False
        Me.picB3.Visible = False
        '
        'picM1
        '
        Me.picM1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picM1.Image = CType(resources.GetObject("picM1.Image"), System.Drawing.Image)
        Me.picM1.Location = New System.Drawing.Point(465, 180)
        Me.picM1.Name = "picM1"
        Me.picM1.Size = New System.Drawing.Size(169, 131)
        Me.picM1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picM1.TabIndex = 16
        Me.picM1.TabStop = False
        Me.picM1.Visible = False
        '
        'picM2
        '
        Me.picM2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picM2.Image = CType(resources.GetObject("picM2.Image"), System.Drawing.Image)
        Me.picM2.Location = New System.Drawing.Point(465, 180)
        Me.picM2.Name = "picM2"
        Me.picM2.Size = New System.Drawing.Size(169, 131)
        Me.picM2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picM2.TabIndex = 17
        Me.picM2.TabStop = False
        Me.picM2.Visible = False
        '
        'picM3
        '
        Me.picM3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picM3.Image = CType(resources.GetObject("picM3.Image"), System.Drawing.Image)
        Me.picM3.Location = New System.Drawing.Point(465, 180)
        Me.picM3.Name = "picM3"
        Me.picM3.Size = New System.Drawing.Size(169, 131)
        Me.picM3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picM3.TabIndex = 18
        Me.picM3.TabStop = False
        Me.picM3.Visible = False
        '
        'frmInventory
        '
        Me.AccessibleName = "frmInventory"
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(646, 318)
        Me.Controls.Add(Me.picM3)
        Me.Controls.Add(Me.picM2)
        Me.Controls.Add(Me.picM1)
        Me.Controls.Add(Me.picB3)
        Me.Controls.Add(Me.picB2)
        Me.Controls.Add(Me.picB1)
        Me.Controls.Add(Me.picA3)
        Me.Controls.Add(Me.picA2)
        Me.Controls.Add(Me.lblVIN)
        Me.Controls.Add(Me.picA1)
        Me.Controls.Add(Me.lstOutput)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.name = "frmInventory"
        Me.Text = "Inventory"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox.ResumeLayout(False)
        Me.GroupBox.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.picA1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picA2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picA3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picB1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picB2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picB3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picM1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picM2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picM3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents cmbModel As ComboBox
    Friend WithEvents cmbCondition As ComboBox
    Friend WithEvents cmbCompany As ComboBox
    Friend WithEvents cmbYear As ComboBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents rbV12 As RadioButton
    Friend WithEvents rbV10 As RadioButton
    Friend WithEvents rbV8 As RadioButton
    Friend WithEvents Label5 As Label
    Friend WithEvents GroupBox As GroupBox
    Friend WithEvents rbManual As RadioButton
    Friend WithEvents rbDual As RadioButton
    Friend WithEvents rbAuto As RadioButton
    Friend WithEvents Label6 As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents rbAll As RadioButton
    Friend WithEvents rbBack As RadioButton
    Friend WithEvents rbFront As RadioButton
    Friend WithEvents Label7 As Label
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents rbWhite As RadioButton
    Friend WithEvents rbRed As RadioButton
    Friend WithEvents rbBlack As RadioButton
    Friend WithEvents Label8 As Label
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents cb12 As CheckBox
    Friend WithEvents cb11 As CheckBox
    Friend WithEvents cb10 As CheckBox
    Friend WithEvents cb9 As CheckBox
    Friend WithEvents cb8 As CheckBox
    Friend WithEvents cb7 As CheckBox
    Friend WithEvents cb6 As CheckBox
    Friend WithEvents cb5 As CheckBox
    Friend WithEvents cb4 As CheckBox
    Friend WithEvents cb3 As CheckBox
    Friend WithEvents cb2 As CheckBox
    Friend WithEvents cb1 As CheckBox
    Friend WithEvents lstOutput As ListBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveAsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DeleteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ChangeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VINToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CompressToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DecompressToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents picA1 As PictureBox
    Friend WithEvents lblVIN As Label
    Friend WithEvents picA2 As PictureBox
    Friend WithEvents picA3 As PictureBox
    Friend WithEvents picB1 As PictureBox
    Friend WithEvents picB2 As PictureBox
    Friend WithEvents picB3 As PictureBox
    Friend WithEvents picM1 As PictureBox
    Friend WithEvents picM2 As PictureBox
    Friend WithEvents picM3 As PictureBox
End Class