<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDeckLab
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
        Me.cmdDeck = New System.Windows.Forms.Button()
        Me.cmdCard = New System.Windows.Forms.Button()
        Me.cmdShuffle = New System.Windows.Forms.Button()
        Me.lstDeck = New System.Windows.Forms.ListBox()
        Me.picCard = New System.Windows.Forms.PictureBox()
        CType(Me.picCard, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdDeck
        '
        Me.cmdDeck.BackColor = System.Drawing.Color.MidnightBlue
        Me.cmdDeck.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdDeck.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.cmdDeck.Location = New System.Drawing.Point(117, 42)
        Me.cmdDeck.Name = "cmdDeck"
        Me.cmdDeck.Size = New System.Drawing.Size(115, 32)
        Me.cmdDeck.TabIndex = 0
        Me.cmdDeck.Text = "Generate Deck"
        Me.cmdDeck.UseVisualStyleBackColor = False
        '
        'cmdCard
        '
        Me.cmdCard.BackColor = System.Drawing.Color.MidnightBlue
        Me.cmdCard.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCard.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.cmdCard.Location = New System.Drawing.Point(238, 42)
        Me.cmdCard.Name = "cmdCard"
        Me.cmdCard.Size = New System.Drawing.Size(115, 32)
        Me.cmdCard.TabIndex = 1
        Me.cmdCard.Text = "Random Card"
        Me.cmdCard.UseVisualStyleBackColor = False
        '
        'cmdShuffle
        '
        Me.cmdShuffle.BackColor = System.Drawing.Color.MidnightBlue
        Me.cmdShuffle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdShuffle.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.cmdShuffle.Location = New System.Drawing.Point(166, 80)
        Me.cmdShuffle.Name = "cmdShuffle"
        Me.cmdShuffle.Size = New System.Drawing.Size(115, 32)
        Me.cmdShuffle.TabIndex = 2
        Me.cmdShuffle.Text = "Shuffle"
        Me.cmdShuffle.UseVisualStyleBackColor = False
        '
        'lstDeck
        '
        Me.lstDeck.BackColor = System.Drawing.Color.MidnightBlue
        Me.lstDeck.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstDeck.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.lstDeck.FormattingEnabled = True
        Me.lstDeck.ItemHeight = 15
        Me.lstDeck.Location = New System.Drawing.Point(44, 42)
        Me.lstDeck.Name = "lstDeck"
        Me.lstDeck.Size = New System.Drawing.Size(67, 349)
        Me.lstDeck.TabIndex = 3
        '
        'picCard
        '
        Me.picCard.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.picCard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picCard.Location = New System.Drawing.Point(135, 114)
        Me.picCard.Name = "picCard"
        Me.picCard.Size = New System.Drawing.Size(191, 277)
        Me.picCard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picCard.TabIndex = 4
        Me.picCard.TabStop = False
        '
        'frmDeckLab
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.prjDeckLab.My.Resources.Resources.CardBack1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(395, 430)
        Me.Controls.Add(Me.lstDeck)
        Me.Controls.Add(Me.cmdShuffle)
        Me.Controls.Add(Me.cmdCard)
        Me.Controls.Add(Me.cmdDeck)
        Me.Controls.Add(Me.picCard)
        Me.DoubleBuffered = True
        Me.Name = "frmDeckLab"
        Me.Text = "Deck Lab"
        CType(Me.picCard, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents cmdDeck As Button
    Friend WithEvents cmdCard As Button
    Friend WithEvents cmdShuffle As Button
    Friend WithEvents lstDeck As ListBox
    Friend WithEvents picCard As PictureBox
End Class
