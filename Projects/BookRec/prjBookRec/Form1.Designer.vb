<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmBookRec
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
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblReader = New System.Windows.Forms.Label()
        Me.lblAuthor = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.cmdDone = New System.Windows.Forms.Button()
        Me.cmdNext = New System.Windows.Forms.Button()
        Me.RB5 = New System.Windows.Forms.RadioButton()
        Me.RB3 = New System.Windows.Forms.RadioButton()
        Me.RB1 = New System.Windows.Forms.RadioButton()
        Me.RB0 = New System.Windows.Forms.RadioButton()
        Me.RBn3 = New System.Windows.Forms.RadioButton()
        Me.RBn5 = New System.Windows.Forms.RadioButton()
        Me.txtRec = New System.Windows.Forms.TextBox()
        Me.cmbMethods = New System.Windows.Forms.ComboBox()
        Me.lstReaders = New System.Windows.Forms.ListBox()
        Me.cmbEdit = New System.Windows.Forms.ComboBox()
        Me.lstBooks = New System.Windows.Forms.ListBox()
        Me.picBookCover = New System.Windows.Forms.PictureBox()
        Me.GroupBox2.SuspendLayout()
        CType(Me.picBookCover, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblReader)
        Me.GroupBox2.Controls.Add(Me.lblAuthor)
        Me.GroupBox2.Controls.Add(Me.lblTitle)
        Me.GroupBox2.Controls.Add(Me.cmdDone)
        Me.GroupBox2.Controls.Add(Me.cmdNext)
        Me.GroupBox2.Controls.Add(Me.RB5)
        Me.GroupBox2.Controls.Add(Me.RB3)
        Me.GroupBox2.Controls.Add(Me.RB1)
        Me.GroupBox2.Controls.Add(Me.RB0)
        Me.GroupBox2.Controls.Add(Me.RBn3)
        Me.GroupBox2.Controls.Add(Me.RBn5)
        Me.GroupBox2.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(12, 190)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(418, 90)
        Me.GroupBox2.TabIndex = 9
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Rating Books"
        '
        'lblReader
        '
        Me.lblReader.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblReader.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblReader.Location = New System.Drawing.Point(6, 22)
        Me.lblReader.Name = "lblReader"
        Me.lblReader.Size = New System.Drawing.Size(130, 27)
        Me.lblReader.TabIndex = 19
        Me.lblReader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblAuthor
        '
        Me.lblAuthor.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblAuthor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblAuthor.Location = New System.Drawing.Point(283, 22)
        Me.lblAuthor.Name = "lblAuthor"
        Me.lblAuthor.Size = New System.Drawing.Size(130, 27)
        Me.lblAuthor.TabIndex = 18
        Me.lblAuthor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTitle
        '
        Me.lblTitle.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTitle.Location = New System.Drawing.Point(145, 22)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(130, 27)
        Me.lblTitle.TabIndex = 17
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cmdDone
        '
        Me.cmdDone.Location = New System.Drawing.Point(338, 56)
        Me.cmdDone.Name = "cmdDone"
        Me.cmdDone.Size = New System.Drawing.Size(73, 25)
        Me.cmdDone.TabIndex = 16
        Me.cmdDone.Text = "Done"
        Me.cmdDone.UseVisualStyleBackColor = True
        '
        'cmdNext
        '
        Me.cmdNext.Location = New System.Drawing.Point(257, 56)
        Me.cmdNext.Name = "cmdNext"
        Me.cmdNext.Size = New System.Drawing.Size(73, 25)
        Me.cmdNext.TabIndex = 15
        Me.cmdNext.Text = "Next"
        Me.cmdNext.UseVisualStyleBackColor = True
        '
        'RB5
        '
        Me.RB5.AutoSize = True
        Me.RB5.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RB5.Location = New System.Drawing.Point(209, 58)
        Me.RB5.Name = "RB5"
        Me.RB5.Size = New System.Drawing.Size(35, 21)
        Me.RB5.TabIndex = 14
        Me.RB5.Text = "5"
        Me.RB5.UseVisualStyleBackColor = True
        '
        'RB3
        '
        Me.RB3.AutoSize = True
        Me.RB3.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RB3.Location = New System.Drawing.Point(169, 58)
        Me.RB3.Name = "RB3"
        Me.RB3.Size = New System.Drawing.Size(35, 21)
        Me.RB3.TabIndex = 13
        Me.RB3.Text = "3"
        Me.RB3.UseVisualStyleBackColor = True
        '
        'RB1
        '
        Me.RB1.AutoSize = True
        Me.RB1.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RB1.Location = New System.Drawing.Point(129, 58)
        Me.RB1.Name = "RB1"
        Me.RB1.Size = New System.Drawing.Size(35, 21)
        Me.RB1.TabIndex = 12
        Me.RB1.Text = "1"
        Me.RB1.UseVisualStyleBackColor = True
        '
        'RB0
        '
        Me.RB0.AutoSize = True
        Me.RB0.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RB0.Location = New System.Drawing.Point(89, 58)
        Me.RB0.Name = "RB0"
        Me.RB0.Size = New System.Drawing.Size(35, 21)
        Me.RB0.TabIndex = 11
        Me.RB0.Text = "0"
        Me.RB0.UseVisualStyleBackColor = True
        '
        'RBn3
        '
        Me.RBn3.AutoSize = True
        Me.RBn3.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RBn3.Location = New System.Drawing.Point(49, 58)
        Me.RBn3.Name = "RBn3"
        Me.RBn3.Size = New System.Drawing.Size(40, 21)
        Me.RBn3.TabIndex = 10
        Me.RBn3.Text = "-3"
        Me.RBn3.UseVisualStyleBackColor = True
        '
        'RBn5
        '
        Me.RBn5.AutoSize = True
        Me.RBn5.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RBn5.Location = New System.Drawing.Point(9, 58)
        Me.RBn5.Name = "RBn5"
        Me.RBn5.Size = New System.Drawing.Size(40, 21)
        Me.RBn5.TabIndex = 9
        Me.RBn5.Text = "-5"
        Me.RBn5.UseVisualStyleBackColor = True
        '
        'txtRec
        '
        Me.txtRec.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtRec.Location = New System.Drawing.Point(12, 12)
        Me.txtRec.Multiline = True
        Me.txtRec.Name = "txtRec"
        Me.txtRec.ReadOnly = True
        Me.txtRec.Size = New System.Drawing.Size(275, 172)
        Me.txtRec.TabIndex = 10
        '
        'cmbMethods
        '
        Me.cmbMethods.FormattingEnabled = True
        Me.cmbMethods.Items.AddRange(New Object() {"Method A", "Method B", "Method C"})
        Me.cmbMethods.Location = New System.Drawing.Point(524, 257)
        Me.cmbMethods.Name = "cmbMethods"
        Me.cmbMethods.Size = New System.Drawing.Size(82, 21)
        Me.cmbMethods.TabIndex = 11
        Me.cmbMethods.Text = "Recommend"
        '
        'lstReaders
        '
        Me.lstReaders.FormattingEnabled = True
        Me.lstReaders.Location = New System.Drawing.Point(436, 103)
        Me.lstReaders.Name = "lstReaders"
        Me.lstReaders.Size = New System.Drawing.Size(170, 147)
        Me.lstReaders.TabIndex = 12
        '
        'cmbEdit
        '
        Me.cmbEdit.FormattingEnabled = True
        Me.cmbEdit.Items.AddRange(New Object() {"Add", "Change", "Delete"})
        Me.cmbEdit.Location = New System.Drawing.Point(436, 257)
        Me.cmbEdit.Name = "cmbEdit"
        Me.cmbEdit.Size = New System.Drawing.Size(82, 21)
        Me.cmbEdit.TabIndex = 13
        Me.cmbEdit.Text = "Edit"
        '
        'lstBooks
        '
        Me.lstBooks.FormattingEnabled = True
        Me.lstBooks.Location = New System.Drawing.Point(436, 12)
        Me.lstBooks.Name = "lstBooks"
        Me.lstBooks.Size = New System.Drawing.Size(170, 82)
        Me.lstBooks.TabIndex = 14
        '
        'picBookCover
        '
        Me.picBookCover.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.picBookCover.Location = New System.Drawing.Point(295, 12)
        Me.picBookCover.Name = "picBookCover"
        Me.picBookCover.Size = New System.Drawing.Size(130, 172)
        Me.picBookCover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBookCover.TabIndex = 15
        Me.picBookCover.TabStop = False
        '
        'frmBookRec
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(619, 288)
        Me.Controls.Add(Me.picBookCover)
        Me.Controls.Add(Me.lstBooks)
        Me.Controls.Add(Me.cmbEdit)
        Me.Controls.Add(Me.lstReaders)
        Me.Controls.Add(Me.cmbMethods)
        Me.Controls.Add(Me.txtRec)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "frmBookRec"
        Me.Text = "BookRec"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.picBookCover, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents RB5 As RadioButton
    Friend WithEvents RB3 As RadioButton
    Friend WithEvents RB1 As RadioButton
    Friend WithEvents RB0 As RadioButton
    Friend WithEvents RBn3 As RadioButton
    Friend WithEvents RBn5 As RadioButton
    Friend WithEvents cmdDone As Button
    Friend WithEvents cmdNext As Button
    Friend WithEvents lblAuthor As Label
    Friend WithEvents lblTitle As Label
    Friend WithEvents txtRec As TextBox
    Friend WithEvents cmbMethods As ComboBox
    Friend WithEvents lstReaders As ListBox
    Friend WithEvents cmbEdit As ComboBox
    Friend WithEvents lblReader As Label
    Friend WithEvents lstBooks As ListBox
    Friend WithEvents picBookCover As PictureBox
End Class
