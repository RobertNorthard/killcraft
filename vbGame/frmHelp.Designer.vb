<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHelp
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
        Me.btnExit = New System.Windows.Forms.Button
        Me.grbGameInstructions = New System.Windows.Forms.GroupBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.grbGameInstructions.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(168, 246)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 1
        Me.btnExit.Text = "Ok"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'grbGameInstructions
        '
        Me.grbGameInstructions.Controls.Add(Me.Label7)
        Me.grbGameInstructions.Controls.Add(Me.Label6)
        Me.grbGameInstructions.Controls.Add(Me.Label5)
        Me.grbGameInstructions.Controls.Add(Me.Label4)
        Me.grbGameInstructions.Controls.Add(Me.Label3)
        Me.grbGameInstructions.Controls.Add(Me.Label2)
        Me.grbGameInstructions.Controls.Add(Me.Label1)
        Me.grbGameInstructions.Controls.Add(Me.btnExit)
        Me.grbGameInstructions.Location = New System.Drawing.Point(23, 12)
        Me.grbGameInstructions.Name = "grbGameInstructions"
        Me.grbGameInstructions.Size = New System.Drawing.Size(271, 275)
        Me.grbGameInstructions.TabIndex = 2
        Me.grbGameInstructions.TabStop = False
        Me.grbGameInstructions.Text = "Playing Instructions"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(26, 188)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(128, 20)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "T - to place tile"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(26, 163)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(229, 20)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Y - to bring up tile selection"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(26, 214)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(215, 20)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Space Bar - to fire fireball"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(22, 134)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(222, 20)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Right - to move sprite right"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(21, 103)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(230, 20)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Down - to move sprite down"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(22, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(201, 20)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Left - to move sprite left"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(26, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(186, 20)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Up - to move sprite up"
        '
        'frmHelp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(306, 299)
        Me.Controls.Add(Me.grbGameInstructions)
        Me.Name = "frmHelp"
        Me.Text = "Piles - Help"
        Me.grbGameInstructions.ResumeLayout(False)
        Me.grbGameInstructions.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents grbGameInstructions As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
End Class
