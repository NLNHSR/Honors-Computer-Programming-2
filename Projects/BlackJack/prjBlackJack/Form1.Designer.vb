<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmBlackJack
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
        Me.gbDealer = New System.Windows.Forms.GroupBox()
        Me.D5 = New System.Windows.Forms.PictureBox()
        Me.D4 = New System.Windows.Forms.PictureBox()
        Me.D3 = New System.Windows.Forms.PictureBox()
        Me.D2 = New System.Windows.Forms.PictureBox()
        Me.D1 = New System.Windows.Forms.PictureBox()
        Me.gbPlayer = New System.Windows.Forms.GroupBox()
        Me.P5 = New System.Windows.Forms.PictureBox()
        Me.P4 = New System.Windows.Forms.PictureBox()
        Me.P3 = New System.Windows.Forms.PictureBox()
        Me.P2 = New System.Windows.Forms.PictureBox()
        Me.P1 = New System.Windows.Forms.PictureBox()
        Me.cmdHit = New System.Windows.Forms.Button()
        Me.cmdStand = New System.Windows.Forms.Button()
        Me.cmdPlay = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblPoints = New System.Windows.Forms.Label()
        Me.cmdNew = New System.Windows.Forms.Button()
        Me.lstTopTen = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.gbPlayerSplit = New System.Windows.Forms.GroupBox()
        Me.PS5 = New System.Windows.Forms.PictureBox()
        Me.PS4 = New System.Windows.Forms.PictureBox()
        Me.PS3 = New System.Windows.Forms.PictureBox()
        Me.PS2 = New System.Windows.Forms.PictureBox()
        Me.PS1 = New System.Windows.Forms.PictureBox()
        Me.picSplit = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.gbDealer.SuspendLayout()
        CType(Me.D5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.D4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.D3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.D2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.D1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbPlayer.SuspendLayout()
        CType(Me.P5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.P4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.P3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.P2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.P1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbPlayerSplit.SuspendLayout()
        CType(Me.PS5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PS4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PS3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PS2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PS1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picSplit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbDealer
        '
        Me.gbDealer.Controls.Add(Me.D5)
        Me.gbDealer.Controls.Add(Me.D4)
        Me.gbDealer.Controls.Add(Me.D3)
        Me.gbDealer.Controls.Add(Me.D2)
        Me.gbDealer.Controls.Add(Me.D1)
        Me.gbDealer.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbDealer.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.gbDealer.Location = New System.Drawing.Point(12, 171)
        Me.gbDealer.Name = "gbDealer"
        Me.gbDealer.Size = New System.Drawing.Size(557, 180)
        Me.gbDealer.TabIndex = 0
        Me.gbDealer.TabStop = False
        Me.gbDealer.Text = "Dealer BJ Score:"
        '
        'D5
        '
        Me.D5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.D5.Location = New System.Drawing.Point(446, 19)
        Me.D5.Name = "D5"
        Me.D5.Size = New System.Drawing.Size(104, 152)
        Me.D5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.D5.TabIndex = 4
        Me.D5.TabStop = False
        '
        'D4
        '
        Me.D4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.D4.Location = New System.Drawing.Point(336, 19)
        Me.D4.Name = "D4"
        Me.D4.Size = New System.Drawing.Size(104, 152)
        Me.D4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.D4.TabIndex = 3
        Me.D4.TabStop = False
        '
        'D3
        '
        Me.D3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.D3.Location = New System.Drawing.Point(226, 19)
        Me.D3.Name = "D3"
        Me.D3.Size = New System.Drawing.Size(104, 152)
        Me.D3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.D3.TabIndex = 2
        Me.D3.TabStop = False
        '
        'D2
        '
        Me.D2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.D2.Location = New System.Drawing.Point(116, 19)
        Me.D2.Name = "D2"
        Me.D2.Size = New System.Drawing.Size(104, 152)
        Me.D2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.D2.TabIndex = 1
        Me.D2.TabStop = False
        '
        'D1
        '
        Me.D1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.D1.Location = New System.Drawing.Point(6, 19)
        Me.D1.Name = "D1"
        Me.D1.Size = New System.Drawing.Size(104, 152)
        Me.D1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.D1.TabIndex = 0
        Me.D1.TabStop = False
        '
        'gbPlayer
        '
        Me.gbPlayer.Controls.Add(Me.P5)
        Me.gbPlayer.Controls.Add(Me.P4)
        Me.gbPlayer.Controls.Add(Me.P3)
        Me.gbPlayer.Controls.Add(Me.P2)
        Me.gbPlayer.Controls.Add(Me.P1)
        Me.gbPlayer.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbPlayer.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.gbPlayer.Location = New System.Drawing.Point(12, 357)
        Me.gbPlayer.Name = "gbPlayer"
        Me.gbPlayer.Size = New System.Drawing.Size(557, 180)
        Me.gbPlayer.TabIndex = 5
        Me.gbPlayer.TabStop = False
        Me.gbPlayer.Text = "Player BJ Score:"
        '
        'P5
        '
        Me.P5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.P5.Location = New System.Drawing.Point(446, 19)
        Me.P5.Name = "P5"
        Me.P5.Size = New System.Drawing.Size(104, 152)
        Me.P5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.P5.TabIndex = 4
        Me.P5.TabStop = False
        '
        'P4
        '
        Me.P4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.P4.Location = New System.Drawing.Point(336, 19)
        Me.P4.Name = "P4"
        Me.P4.Size = New System.Drawing.Size(104, 152)
        Me.P4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.P4.TabIndex = 3
        Me.P4.TabStop = False
        '
        'P3
        '
        Me.P3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.P3.Location = New System.Drawing.Point(226, 19)
        Me.P3.Name = "P3"
        Me.P3.Size = New System.Drawing.Size(104, 152)
        Me.P3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.P3.TabIndex = 2
        Me.P3.TabStop = False
        '
        'P2
        '
        Me.P2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.P2.Location = New System.Drawing.Point(116, 19)
        Me.P2.Name = "P2"
        Me.P2.Size = New System.Drawing.Size(104, 152)
        Me.P2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.P2.TabIndex = 1
        Me.P2.TabStop = False
        '
        'P1
        '
        Me.P1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.P1.Location = New System.Drawing.Point(6, 19)
        Me.P1.Name = "P1"
        Me.P1.Size = New System.Drawing.Size(104, 152)
        Me.P1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.P1.TabIndex = 0
        Me.P1.TabStop = False
        '
        'cmdHit
        '
        Me.cmdHit.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cmdHit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdHit.ForeColor = System.Drawing.Color.Gold
        Me.cmdHit.Location = New System.Drawing.Point(579, 376)
        Me.cmdHit.Name = "cmdHit"
        Me.cmdHit.Size = New System.Drawing.Size(58, 31)
        Me.cmdHit.TabIndex = 6
        Me.cmdHit.Text = "Hit"
        Me.cmdHit.UseVisualStyleBackColor = False
        '
        'cmdStand
        '
        Me.cmdStand.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cmdStand.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdStand.ForeColor = System.Drawing.Color.Gold
        Me.cmdStand.Location = New System.Drawing.Point(643, 376)
        Me.cmdStand.Name = "cmdStand"
        Me.cmdStand.Size = New System.Drawing.Size(58, 31)
        Me.cmdStand.TabIndex = 7
        Me.cmdStand.Text = "Stand"
        Me.cmdStand.UseVisualStyleBackColor = False
        '
        'cmdPlay
        '
        Me.cmdPlay.BackColor = System.Drawing.SystemColors.ControlText
        Me.cmdPlay.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdPlay.ForeColor = System.Drawing.Color.Gold
        Me.cmdPlay.Location = New System.Drawing.Point(579, 413)
        Me.cmdPlay.Name = "cmdPlay"
        Me.cmdPlay.Size = New System.Drawing.Size(122, 31)
        Me.cmdPlay.TabIndex = 8
        Me.cmdPlay.Text = "Play Again"
        Me.cmdPlay.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label3.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label3.Location = New System.Drawing.Point(579, 489)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(122, 25)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Total Points:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblPoints
        '
        Me.lblPoints.BackColor = System.Drawing.Color.Ivory
        Me.lblPoints.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPoints.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPoints.ForeColor = System.Drawing.Color.MediumBlue
        Me.lblPoints.Location = New System.Drawing.Point(579, 514)
        Me.lblPoints.Name = "lblPoints"
        Me.lblPoints.Size = New System.Drawing.Size(122, 22)
        Me.lblPoints.TabIndex = 11
        Me.lblPoints.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cmdNew
        '
        Me.cmdNew.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cmdNew.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdNew.ForeColor = System.Drawing.Color.Gold
        Me.cmdNew.Location = New System.Drawing.Point(579, 450)
        Me.cmdNew.Name = "cmdNew"
        Me.cmdNew.Size = New System.Drawing.Size(122, 31)
        Me.cmdNew.TabIndex = 13
        Me.cmdNew.Text = "New Game"
        Me.cmdNew.UseVisualStyleBackColor = False
        '
        'lstTopTen
        '
        Me.lstTopTen.BackColor = System.Drawing.Color.Ivory
        Me.lstTopTen.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstTopTen.ForeColor = System.Drawing.Color.MediumBlue
        Me.lstTopTen.FormattingEnabled = True
        Me.lstTopTen.ItemHeight = 16
        Me.lstTopTen.Location = New System.Drawing.Point(579, 196)
        Me.lstTopTen.Name = "lstTopTen"
        Me.lstTopTen.Size = New System.Drawing.Size(122, 148)
        Me.lstTopTen.TabIndex = 14
        '
        'Label1
        '
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(579, 168)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(122, 25)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Top 10"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'gbPlayerSplit
        '
        Me.gbPlayerSplit.Controls.Add(Me.PS5)
        Me.gbPlayerSplit.Controls.Add(Me.PS4)
        Me.gbPlayerSplit.Controls.Add(Me.PS3)
        Me.gbPlayerSplit.Controls.Add(Me.PS2)
        Me.gbPlayerSplit.Controls.Add(Me.PS1)
        Me.gbPlayerSplit.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbPlayerSplit.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.gbPlayerSplit.Location = New System.Drawing.Point(12, 552)
        Me.gbPlayerSplit.Name = "gbPlayerSplit"
        Me.gbPlayerSplit.Size = New System.Drawing.Size(557, 180)
        Me.gbPlayerSplit.TabIndex = 6
        Me.gbPlayerSplit.TabStop = False
        Me.gbPlayerSplit.Text = "Player BJ Score:"
        '
        'PS5
        '
        Me.PS5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PS5.Location = New System.Drawing.Point(446, 19)
        Me.PS5.Name = "PS5"
        Me.PS5.Size = New System.Drawing.Size(104, 152)
        Me.PS5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PS5.TabIndex = 4
        Me.PS5.TabStop = False
        '
        'PS4
        '
        Me.PS4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PS4.Location = New System.Drawing.Point(336, 19)
        Me.PS4.Name = "PS4"
        Me.PS4.Size = New System.Drawing.Size(104, 152)
        Me.PS4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PS4.TabIndex = 3
        Me.PS4.TabStop = False
        '
        'PS3
        '
        Me.PS3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PS3.Location = New System.Drawing.Point(226, 19)
        Me.PS3.Name = "PS3"
        Me.PS3.Size = New System.Drawing.Size(104, 152)
        Me.PS3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PS3.TabIndex = 2
        Me.PS3.TabStop = False
        '
        'PS2
        '
        Me.PS2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PS2.Location = New System.Drawing.Point(116, 19)
        Me.PS2.Name = "PS2"
        Me.PS2.Size = New System.Drawing.Size(104, 152)
        Me.PS2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PS2.TabIndex = 1
        Me.PS2.TabStop = False
        '
        'PS1
        '
        Me.PS1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PS1.Location = New System.Drawing.Point(6, 19)
        Me.PS1.Name = "PS1"
        Me.PS1.Size = New System.Drawing.Size(104, 152)
        Me.PS1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PS1.TabIndex = 0
        Me.PS1.TabStop = False
        '
        'picSplit
        '
        Me.picSplit.Image = Global.prjBlackJack.My.Resources.Resources.pointer
        Me.picSplit.Location = New System.Drawing.Point(575, 571)
        Me.picSplit.Name = "picSplit"
        Me.picSplit.Size = New System.Drawing.Size(125, 73)
        Me.picSplit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picSplit.TabIndex = 19
        Me.picSplit.TabStop = False
        Me.picSplit.Visible = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.prjBlackJack.My.Resources.Resources.cardhand
        Me.PictureBox2.Location = New System.Drawing.Point(506, -31)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(195, 234)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 17
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.prjBlackJack.My.Resources.Resources.cardhand2
        Me.PictureBox3.Location = New System.Drawing.Point(12, -31)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(195, 234)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 18
        Me.PictureBox3.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.prjBlackJack.My.Resources.Resources.blackjack
        Me.PictureBox1.Location = New System.Drawing.Point(147, 25)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(415, 140)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 16
        Me.PictureBox1.TabStop = False
        '
        'frmBlackJack
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkGreen
        Me.ClientSize = New System.Drawing.Size(716, 741)
        Me.Controls.Add(Me.picSplit)
        Me.Controls.Add(Me.gbPlayerSplit)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lstTopTen)
        Me.Controls.Add(Me.cmdNew)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblPoints)
        Me.Controls.Add(Me.cmdPlay)
        Me.Controls.Add(Me.cmdStand)
        Me.Controls.Add(Me.cmdHit)
        Me.Controls.Add(Me.gbPlayer)
        Me.Controls.Add(Me.gbDealer)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "frmBlackJack"
        Me.Text = "BlackJack"
        Me.gbDealer.ResumeLayout(False)
        CType(Me.D5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.D4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.D3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.D2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.D1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbPlayer.ResumeLayout(False)
        CType(Me.P5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.P4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.P3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.P2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.P1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbPlayerSplit.ResumeLayout(False)
        CType(Me.PS5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PS4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PS3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PS2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PS1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picSplit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gbDealer As GroupBox
    Friend WithEvents D5 As PictureBox
    Friend WithEvents D4 As PictureBox
    Friend WithEvents D3 As PictureBox
    Friend WithEvents D2 As PictureBox
    Friend WithEvents D1 As PictureBox
    Friend WithEvents gbPlayer As GroupBox
    Friend WithEvents P5 As PictureBox
    Friend WithEvents P4 As PictureBox
    Friend WithEvents P3 As PictureBox
    Friend WithEvents P2 As PictureBox
    Friend WithEvents P1 As PictureBox
    Friend WithEvents cmdHit As Button
    Friend WithEvents cmdStand As Button
    Friend WithEvents cmdPlay As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents lblPoints As Label
    Friend WithEvents cmdNew As Button
    Friend WithEvents lstTopTen As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents gbPlayerSplit As GroupBox
    Friend WithEvents PS5 As PictureBox
    Friend WithEvents PS4 As PictureBox
    Friend WithEvents PS3 As PictureBox
    Friend WithEvents PS2 As PictureBox
    Friend WithEvents PS1 As PictureBox
    Friend WithEvents picSplit As PictureBox
End Class
