<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHighScoreBoard
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

    'NOTF: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.grpHighScore = New System.Windows.Forms.GroupBox
        Me.lblPlayerScore = New System.Windows.Forms.ListBox
        Me.lblPlayerName = New System.Windows.Forms.ListBox
        Me.lblPoints = New System.Windows.Forms.Label
        Me.lblName = New System.Windows.Forms.Label
        Me.grpHighScore.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpHighScore
        '
        Me.grpHighScore.Controls.Add(Me.lblPlayerScore)
        Me.grpHighScore.Controls.Add(Me.lblPlayerName)
        Me.grpHighScore.Controls.Add(Me.lblPoints)
        Me.grpHighScore.Controls.Add(Me.lblName)
        Me.grpHighScore.Location = New System.Drawing.Point(12, 12)
        Me.grpHighScore.Name = "grpHighScore"
        Me.grpHighScore.Size = New System.Drawing.Size(283, 255)
        Me.grpHighScore.TabIndex = 0
        Me.grpHighScore.TabStop = False
        Me.grpHighScore.Text = "Highscores"
        '
        'lblPlayerScore
        '
        Me.lblPlayerScore.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPlayerScore.FormattingEnabled = True
        Me.lblPlayerScore.ItemHeight = 25
        Me.lblPlayerScore.Location = New System.Drawing.Point(171, 61)
        Me.lblPlayerScore.Name = "lblPlayerScore"
        Me.lblPlayerScore.Size = New System.Drawing.Size(105, 179)
        Me.lblPlayerScore.TabIndex = 8
        '
        'lblPlayerName
        '
        Me.lblPlayerName.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPlayerName.FormattingEnabled = True
        Me.lblPlayerName.ItemHeight = 25
        Me.lblPlayerName.Location = New System.Drawing.Point(25, 61)
        Me.lblPlayerName.Name = "lblPlayerName"
        Me.lblPlayerName.Size = New System.Drawing.Size(140, 179)
        Me.lblPlayerName.TabIndex = 7
        '
        'lblPoints
        '
        Me.lblPoints.AutoSize = True
        Me.lblPoints.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPoints.Location = New System.Drawing.Point(166, 29)
        Me.lblPoints.Name = "lblPoints"
        Me.lblPoints.Size = New System.Drawing.Size(86, 29)
        Me.lblPoints.TabIndex = 6
        Me.lblPoints.Text = "Points"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(20, 29)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(82, 29)
        Me.lblName.TabIndex = 5
        Me.lblName.Text = "Name"
        '
        'frmHighScoreBoard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(303, 274)
        Me.Controls.Add(Me.grpHighScore)
        Me.Name = "frmHighScoreBoard"
        Me.Text = "Piles - Highscore Board"
        Me.grpHighScore.ResumeLayout(False)
        Me.grpHighScore.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grpHighScore As System.Windows.Forms.GroupBox
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents lblPoints As System.Windows.Forms.Label
    Friend WithEvents lblPlayerName As System.Windows.Forms.ListBox
    Friend WithEvents lblPlayerScore As System.Windows.Forms.ListBox
End Class
