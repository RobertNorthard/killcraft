<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMain
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMain))
        Me.mnuStirp = New System.Windows.Forms.MenuStrip
        Me.FileToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.StartGameToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.StopGameToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.ExitToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.HelpToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.StartGameToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.StopGameToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.lblMud = New System.Windows.Forms.Label
        Me.lblGrass = New System.Windows.Forms.Label
        Me.lblWood = New System.Windows.Forms.Label
        Me.lblRoad = New System.Windows.Forms.Label
        Me.lblRock = New System.Windows.Forms.Label
        Me.lblSelectedTile = New System.Windows.Forms.Label
        Me.lblGround = New System.Windows.Forms.Label
        Me.pnlTileSelection = New System.Windows.Forms.Panel
        Me.Label4 = New System.Windows.Forms.Label
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.pctGround = New System.Windows.Forms.PictureBox
        Me.pctSelectedTile = New System.Windows.Forms.PictureBox
        Me.pctRock = New System.Windows.Forms.PictureBox
        Me.pctRoad = New System.Windows.Forms.PictureBox
        Me.pctWood = New System.Windows.Forms.PictureBox
        Me.pctGrass = New System.Windows.Forms.PictureBox
        Me.pctMud = New System.Windows.Forms.PictureBox
        Me.tmrAI = New System.Windows.Forms.Timer(Me.components)
        Me.pnlGameStats = New System.Windows.Forms.Panel
        Me.lblGameTimeValue = New System.Windows.Forms.Label
        Me.lblGameTime = New System.Windows.Forms.Label
        Me.lblGamePointScore = New System.Windows.Forms.Label
        Me.lblGamePoints = New System.Windows.Forms.Label
        Me.tmrBullets = New System.Windows.Forms.Timer(Me.components)
        Me.tmrGameTimer = New System.Windows.Forms.Timer(Me.components)
        Me.tlTipHelp = New System.Windows.Forms.ToolTip(Me.components)
        Me.pnlGameOptions = New System.Windows.Forms.Panel
        Me.lblHelp = New System.Windows.Forms.Label
        Me.lblExit = New System.Windows.Forms.Label
        Me.lblHighScoreBoard = New System.Windows.Forms.Label
        Me.lblSurvivalGameMode = New System.Windows.Forms.Label
        Me.lblStartCreativeMode = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.mnuStirp.SuspendLayout()
        Me.pnlTileSelection.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctGround, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctSelectedTile, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctRock, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctRoad, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctWood, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctGrass, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctMud, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlGameStats.SuspendLayout()
        Me.pnlGameOptions.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'mnuStirp
        '
        Me.mnuStirp.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem1, Me.HelpToolStripMenuItem1})
        Me.mnuStirp.Location = New System.Drawing.Point(0, 0)
        Me.mnuStirp.Name = "mnuStirp"
        Me.mnuStirp.Size = New System.Drawing.Size(798, 24)
        Me.mnuStirp.TabIndex = 0
        Me.mnuStirp.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem1
        '
        Me.FileToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StartGameToolStripMenuItem1, Me.StopGameToolStripMenuItem1, Me.ExitToolStripMenuItem1})
        Me.FileToolStripMenuItem1.Name = "FileToolStripMenuItem1"
        Me.FileToolStripMenuItem1.Size = New System.Drawing.Size(35, 20)
        Me.FileToolStripMenuItem1.Text = "File"
        '
        'StartGameToolStripMenuItem1
        '
        Me.StartGameToolStripMenuItem1.Name = "StartGameToolStripMenuItem1"
        Me.StartGameToolStripMenuItem1.Size = New System.Drawing.Size(152, 22)
        Me.StartGameToolStripMenuItem1.Text = "Start Game"
        '
        'StopGameToolStripMenuItem1
        '
        Me.StopGameToolStripMenuItem1.Name = "StopGameToolStripMenuItem1"
        Me.StopGameToolStripMenuItem1.Size = New System.Drawing.Size(152, 22)
        Me.StopGameToolStripMenuItem1.Text = "Stop Game"
        '
        'ExitToolStripMenuItem1
        '
        Me.ExitToolStripMenuItem1.Name = "ExitToolStripMenuItem1"
        Me.ExitToolStripMenuItem1.Size = New System.Drawing.Size(152, 22)
        Me.ExitToolStripMenuItem1.Text = "Exit"
        '
        'HelpToolStripMenuItem1
        '
        Me.HelpToolStripMenuItem1.Name = "HelpToolStripMenuItem1"
        Me.HelpToolStripMenuItem1.Size = New System.Drawing.Size(41, 20)
        Me.HelpToolStripMenuItem1.Text = "Help"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StartGameToolStripMenuItem, Me.StopGameToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'StartGameToolStripMenuItem
        '
        Me.StartGameToolStripMenuItem.Name = "StartGameToolStripMenuItem"
        Me.StartGameToolStripMenuItem.Size = New System.Drawing.Size(127, 22)
        Me.StartGameToolStripMenuItem.Text = "Start Game"
        '
        'StopGameToolStripMenuItem
        '
        Me.StopGameToolStripMenuItem.Name = "StopGameToolStripMenuItem"
        Me.StopGameToolStripMenuItem.Size = New System.Drawing.Size(127, 22)
        Me.StopGameToolStripMenuItem.Text = "Stop game"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(127, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'lblMud
        '
        Me.lblMud.AutoSize = True
        Me.lblMud.Location = New System.Drawing.Point(6, 52)
        Me.lblMud.Name = "lblMud"
        Me.lblMud.Size = New System.Drawing.Size(28, 13)
        Me.lblMud.TabIndex = 8
        Me.lblMud.Text = "Mud"
        '
        'lblGrass
        '
        Me.lblGrass.AutoSize = True
        Me.lblGrass.Location = New System.Drawing.Point(59, 51)
        Me.lblGrass.Name = "lblGrass"
        Me.lblGrass.Size = New System.Drawing.Size(34, 13)
        Me.lblGrass.TabIndex = 9
        Me.lblGrass.Text = "Grass"
        '
        'lblWood
        '
        Me.lblWood.AutoSize = True
        Me.lblWood.Location = New System.Drawing.Point(108, 51)
        Me.lblWood.Name = "lblWood"
        Me.lblWood.Size = New System.Drawing.Size(36, 13)
        Me.lblWood.TabIndex = 10
        Me.lblWood.Text = "Wood"
        '
        'lblRoad
        '
        Me.lblRoad.AutoSize = True
        Me.lblRoad.Location = New System.Drawing.Point(161, 52)
        Me.lblRoad.Name = "lblRoad"
        Me.lblRoad.Size = New System.Drawing.Size(33, 13)
        Me.lblRoad.TabIndex = 11
        Me.lblRoad.Text = "Road"
        '
        'lblRock
        '
        Me.lblRock.AutoSize = True
        Me.lblRock.Location = New System.Drawing.Point(216, 52)
        Me.lblRock.Name = "lblRock"
        Me.lblRock.Size = New System.Drawing.Size(33, 13)
        Me.lblRock.TabIndex = 12
        Me.lblRock.Text = "Rock"
        '
        'lblSelectedTile
        '
        Me.lblSelectedTile.AutoSize = True
        Me.lblSelectedTile.Location = New System.Drawing.Point(374, 51)
        Me.lblSelectedTile.Name = "lblSelectedTile"
        Me.lblSelectedTile.Size = New System.Drawing.Size(31, 13)
        Me.lblSelectedTile.TabIndex = 8
        Me.lblSelectedTile.Text = "Lava"
        '
        'lblGround
        '
        Me.lblGround.AutoSize = True
        Me.lblGround.Location = New System.Drawing.Point(262, 53)
        Me.lblGround.Name = "lblGround"
        Me.lblGround.Size = New System.Drawing.Size(42, 13)
        Me.lblGround.TabIndex = 15
        Me.lblGround.Text = "Ground"
        '
        'pnlTileSelection
        '
        Me.pnlTileSelection.BackColor = System.Drawing.Color.Lavender
        Me.pnlTileSelection.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlTileSelection.Controls.Add(Me.Label4)
        Me.pnlTileSelection.Controls.Add(Me.PictureBox2)
        Me.pnlTileSelection.Controls.Add(Me.Label3)
        Me.pnlTileSelection.Controls.Add(Me.PictureBox1)
        Me.pnlTileSelection.Controls.Add(Me.lblGround)
        Me.pnlTileSelection.Controls.Add(Me.pctGround)
        Me.pnlTileSelection.Controls.Add(Me.lblSelectedTile)
        Me.pnlTileSelection.Controls.Add(Me.pctSelectedTile)
        Me.pnlTileSelection.Controls.Add(Me.lblRock)
        Me.pnlTileSelection.Controls.Add(Me.lblRoad)
        Me.pnlTileSelection.Controls.Add(Me.lblWood)
        Me.pnlTileSelection.Controls.Add(Me.lblGrass)
        Me.pnlTileSelection.Controls.Add(Me.lblMud)
        Me.pnlTileSelection.Controls.Add(Me.pctRock)
        Me.pnlTileSelection.Controls.Add(Me.pctRoad)
        Me.pnlTileSelection.Controls.Add(Me.pctWood)
        Me.pnlTileSelection.Controls.Add(Me.pctGrass)
        Me.pnlTileSelection.Controls.Add(Me.pctMud)
        Me.pnlTileSelection.Location = New System.Drawing.Point(156, 626)
        Me.pnlTileSelection.Name = "pnlTileSelection"
        Me.pnlTileSelection.Size = New System.Drawing.Size(511, 75)
        Me.pnlTileSelection.TabIndex = 1
        Me.pnlTileSelection.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(428, 51)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 13)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "Selected Tile"
        '
        'PictureBox2
        '
        Me.PictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox2.Image = Global.vbGame.My.Resources.Resources.lava
        Me.PictureBox2.Location = New System.Drawing.Point(372, 10)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(50, 38)
        Me.PictureBox2.TabIndex = 18
        Me.PictureBox2.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(315, 52)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(36, 13)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Water"
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Image = Global.vbGame.My.Resources.Resources.water
        Me.PictureBox1.Location = New System.Drawing.Point(316, 10)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(50, 38)
        Me.PictureBox1.TabIndex = 16
        Me.PictureBox1.TabStop = False
        '
        'pctGround
        '
        Me.pctGround.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pctGround.Image = Global.vbGame.My.Resources.Resources.ground
        Me.pctGround.Location = New System.Drawing.Point(264, 10)
        Me.pctGround.Name = "pctGround"
        Me.pctGround.Size = New System.Drawing.Size(46, 38)
        Me.pctGround.TabIndex = 14
        Me.pctGround.TabStop = False
        '
        'pctSelectedTile
        '
        Me.pctSelectedTile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pctSelectedTile.Location = New System.Drawing.Point(431, 10)
        Me.pctSelectedTile.Name = "pctSelectedTile"
        Me.pctSelectedTile.Size = New System.Drawing.Size(50, 38)
        Me.pctSelectedTile.TabIndex = 6
        Me.pctSelectedTile.TabStop = False
        '
        'pctRock
        '
        Me.pctRock.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pctRock.Image = Global.vbGame.My.Resources.Resources.rock
        Me.pctRock.Location = New System.Drawing.Point(212, 10)
        Me.pctRock.Name = "pctRock"
        Me.pctRock.Size = New System.Drawing.Size(46, 38)
        Me.pctRock.TabIndex = 4
        Me.pctRock.TabStop = False
        '
        'pctRoad
        '
        Me.pctRoad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pctRoad.Image = Global.vbGame.My.Resources.Resources.road
        Me.pctRoad.Location = New System.Drawing.Point(160, 10)
        Me.pctRoad.Name = "pctRoad"
        Me.pctRoad.Size = New System.Drawing.Size(46, 38)
        Me.pctRoad.TabIndex = 3
        Me.pctRoad.TabStop = False
        '
        'pctWood
        '
        Me.pctWood.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pctWood.Image = Global.vbGame.My.Resources.Resources.wood
        Me.pctWood.Location = New System.Drawing.Point(108, 10)
        Me.pctWood.Name = "pctWood"
        Me.pctWood.Size = New System.Drawing.Size(46, 38)
        Me.pctWood.TabIndex = 2
        Me.pctWood.TabStop = False
        '
        'pctGrass
        '
        Me.pctGrass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pctGrass.Image = CType(resources.GetObject("pctGrass.Image"), System.Drawing.Image)
        Me.pctGrass.Location = New System.Drawing.Point(58, 10)
        Me.pctGrass.Name = "pctGrass"
        Me.pctGrass.Size = New System.Drawing.Size(46, 38)
        Me.pctGrass.TabIndex = 1
        Me.pctGrass.TabStop = False
        '
        'pctMud
        '
        Me.pctMud.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pctMud.Image = Global.vbGame.My.Resources.Resources.mud
        Me.pctMud.Location = New System.Drawing.Point(6, 10)
        Me.pctMud.Name = "pctMud"
        Me.pctMud.Size = New System.Drawing.Size(46, 38)
        Me.pctMud.TabIndex = 0
        Me.pctMud.TabStop = False
        '
        'tmrAI
        '
        Me.tmrAI.Interval = 500
        '
        'pnlGameStats
        '
        Me.pnlGameStats.BackColor = System.Drawing.Color.Black
        Me.pnlGameStats.Controls.Add(Me.lblGameTimeValue)
        Me.pnlGameStats.Controls.Add(Me.lblGameTime)
        Me.pnlGameStats.Controls.Add(Me.lblGamePointScore)
        Me.pnlGameStats.Controls.Add(Me.lblGamePoints)
        Me.pnlGameStats.Location = New System.Drawing.Point(0, 662)
        Me.pnlGameStats.Name = "pnlGameStats"
        Me.pnlGameStats.Size = New System.Drawing.Size(798, 39)
        Me.pnlGameStats.TabIndex = 2
        Me.pnlGameStats.Visible = False
        '
        'lblGameTimeValue
        '
        Me.lblGameTimeValue.AutoSize = True
        Me.lblGameTimeValue.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGameTimeValue.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lblGameTimeValue.Location = New System.Drawing.Point(718, 10)
        Me.lblGameTimeValue.Name = "lblGameTimeValue"
        Me.lblGameTimeValue.Size = New System.Drawing.Size(18, 20)
        Me.lblGameTimeValue.TabIndex = 3
        Me.lblGameTimeValue.Text = "5"
        '
        'lblGameTime
        '
        Me.lblGameTime.AutoSize = True
        Me.lblGameTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGameTime.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lblGameTime.Location = New System.Drawing.Point(559, 10)
        Me.lblGameTime.Name = "lblGameTime"
        Me.lblGameTime.Size = New System.Drawing.Size(123, 20)
        Me.lblGameTime.TabIndex = 2
        Me.lblGameTime.Text = "Time Remaining"
        '
        'lblGamePointScore
        '
        Me.lblGamePointScore.AutoSize = True
        Me.lblGamePointScore.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGamePointScore.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lblGamePointScore.Location = New System.Drawing.Point(126, 11)
        Me.lblGamePointScore.Name = "lblGamePointScore"
        Me.lblGamePointScore.Size = New System.Drawing.Size(18, 20)
        Me.lblGamePointScore.TabIndex = 1
        Me.lblGamePointScore.Text = "0"
        '
        'lblGamePoints
        '
        Me.lblGamePoints.AutoSize = True
        Me.lblGamePoints.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGamePoints.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblGamePoints.Location = New System.Drawing.Point(16, 10)
        Me.lblGamePoints.Name = "lblGamePoints"
        Me.lblGamePoints.Size = New System.Drawing.Size(105, 20)
        Me.lblGamePoints.TabIndex = 0
        Me.lblGamePoints.Text = "Game Points:"
        '
        'tmrBullets
        '
        '
        'tmrGameTimer
        '
        Me.tmrGameTimer.Interval = 1000
        '
        'pnlGameOptions
        '
        Me.pnlGameOptions.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.pnlGameOptions.BackgroundImage = CType(resources.GetObject("pnlGameOptions.BackgroundImage"), System.Drawing.Image)
        Me.pnlGameOptions.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pnlGameOptions.Controls.Add(Me.lblHelp)
        Me.pnlGameOptions.Controls.Add(Me.lblExit)
        Me.pnlGameOptions.Controls.Add(Me.lblHighScoreBoard)
        Me.pnlGameOptions.Controls.Add(Me.lblSurvivalGameMode)
        Me.pnlGameOptions.Controls.Add(Me.lblStartCreativeMode)
        Me.pnlGameOptions.Controls.Add(Me.Panel1)
        Me.pnlGameOptions.Location = New System.Drawing.Point(0, 23)
        Me.pnlGameOptions.Name = "pnlGameOptions"
        Me.pnlGameOptions.Size = New System.Drawing.Size(798, 678)
        Me.pnlGameOptions.TabIndex = 19
        '
        'lblHelp
        '
        Me.lblHelp.AutoSize = True
        Me.lblHelp.BackColor = System.Drawing.Color.Transparent
        Me.lblHelp.Font = New System.Drawing.Font("Century Gothic", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHelp.Location = New System.Drawing.Point(324, 531)
        Me.lblHelp.Name = "lblHelp"
        Me.lblHelp.Size = New System.Drawing.Size(133, 58)
        Me.lblHelp.TabIndex = 21
        Me.lblHelp.Text = "Help"
        '
        'lblExit
        '
        Me.lblExit.AutoSize = True
        Me.lblExit.BackColor = System.Drawing.Color.Transparent
        Me.lblExit.Font = New System.Drawing.Font("Century Gothic", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblExit.Location = New System.Drawing.Point(334, 604)
        Me.lblExit.Name = "lblExit"
        Me.lblExit.Size = New System.Drawing.Size(98, 58)
        Me.lblExit.TabIndex = 3
        Me.lblExit.Text = "Exit"
        '
        'lblHighScoreBoard
        '
        Me.lblHighScoreBoard.AutoSize = True
        Me.lblHighScoreBoard.BackColor = System.Drawing.Color.Transparent
        Me.lblHighScoreBoard.Font = New System.Drawing.Font("Century Gothic", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHighScoreBoard.Location = New System.Drawing.Point(194, 461)
        Me.lblHighScoreBoard.Name = "lblHighScoreBoard"
        Me.lblHighScoreBoard.Size = New System.Drawing.Size(422, 58)
        Me.lblHighScoreBoard.TabIndex = 2
        Me.lblHighScoreBoard.Text = "High-score Board"
        '
        'lblSurvivalGameMode
        '
        Me.lblSurvivalGameMode.AutoSize = True
        Me.lblSurvivalGameMode.BackColor = System.Drawing.Color.Transparent
        Me.lblSurvivalGameMode.Font = New System.Drawing.Font("Century Gothic", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSurvivalGameMode.Location = New System.Drawing.Point(289, 403)
        Me.lblSurvivalGameMode.Name = "lblSurvivalGameMode"
        Me.lblSurvivalGameMode.Size = New System.Drawing.Size(201, 58)
        Me.lblSurvivalGameMode.TabIndex = 1
        Me.lblSurvivalGameMode.Text = "Survival"
        '
        'lblStartCreativeMode
        '
        Me.lblStartCreativeMode.AutoSize = True
        Me.lblStartCreativeMode.BackColor = System.Drawing.Color.Transparent
        Me.lblStartCreativeMode.Font = New System.Drawing.Font("Century Gothic", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStartCreativeMode.Location = New System.Drawing.Point(280, 336)
        Me.lblStartCreativeMode.Name = "lblStartCreativeMode"
        Me.lblStartCreativeMode.Size = New System.Drawing.Size(225, 58)
        Me.lblStartCreativeMode.TabIndex = 0
        Me.lblStartCreativeMode.Text = "Creative"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(3, -108)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(710, 333)
        Me.Panel1.TabIndex = 20
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(339, 590)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 58)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Exit"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(209, 520)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(422, 58)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "High-score Board"
        '
        'FrmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.ClientSize = New System.Drawing.Size(798, 702)
        Me.Controls.Add(Me.pnlGameOptions)
        Me.Controls.Add(Me.mnuStirp)
        Me.Controls.Add(Me.pnlTileSelection)
        Me.Controls.Add(Me.pnlGameStats)
        Me.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DoubleBuffered = True
        Me.MainMenuStrip = Me.mnuStirp
        Me.Name = "FrmMain"
        Me.Text = "vbGame"
        Me.mnuStirp.ResumeLayout(False)
        Me.mnuStirp.PerformLayout()
        Me.pnlTileSelection.ResumeLayout(False)
        Me.pnlTileSelection.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctGround, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctSelectedTile, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctRock, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctRoad, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctWood, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctGrass, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctMud, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlGameStats.ResumeLayout(False)
        Me.pnlGameStats.PerformLayout()
        Me.pnlGameOptions.ResumeLayout(False)
        Me.pnlGameOptions.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents mnuStirp As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StartGameToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents pctMud As System.Windows.Forms.PictureBox
    Friend WithEvents pctGrass As System.Windows.Forms.PictureBox
    Friend WithEvents pctWood As System.Windows.Forms.PictureBox
    Friend WithEvents pctRoad As System.Windows.Forms.PictureBox
    Friend WithEvents pctRock As System.Windows.Forms.PictureBox
    Friend WithEvents lblMud As System.Windows.Forms.Label
    Friend WithEvents lblGrass As System.Windows.Forms.Label
    Friend WithEvents lblWood As System.Windows.Forms.Label
    Friend WithEvents lblRoad As System.Windows.Forms.Label
    Friend WithEvents lblRock As System.Windows.Forms.Label
    Friend WithEvents pctSelectedTile As System.Windows.Forms.PictureBox
    Friend WithEvents lblSelectedTile As System.Windows.Forms.Label
    Friend WithEvents pctGround As System.Windows.Forms.PictureBox
    Friend WithEvents lblGround As System.Windows.Forms.Label
    Friend WithEvents pnlTileSelection As System.Windows.Forms.Panel
    Friend WithEvents tmrAI As System.Windows.Forms.Timer
    Friend WithEvents pnlGameStats As System.Windows.Forms.Panel
    Friend WithEvents lblGamePointScore As System.Windows.Forms.Label
    Friend WithEvents lblGamePoints As System.Windows.Forms.Label
    Friend WithEvents tmrBullets As System.Windows.Forms.Timer
    Friend WithEvents tmrGameTimer As System.Windows.Forms.Timer
    Friend WithEvents lblGameTimeValue As System.Windows.Forms.Label
    Friend WithEvents lblGameTime As System.Windows.Forms.Label
    Friend WithEvents pnlGameOptions As System.Windows.Forms.Panel
    Friend WithEvents lblStartCreativeMode As System.Windows.Forms.Label
    Friend WithEvents lblExit As System.Windows.Forms.Label
    Friend WithEvents lblHighScoreBoard As System.Windows.Forms.Label
    Friend WithEvents lblSurvivalGameMode As System.Windows.Forms.Label
    Friend WithEvents StopGameToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents tlTipHelp As System.Windows.Forms.ToolTip
    Friend WithEvents lblHelp As System.Windows.Forms.Label
    Friend WithEvents FileToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StartGameToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StopGameToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Label4 As System.Windows.Forms.Label

End Class
