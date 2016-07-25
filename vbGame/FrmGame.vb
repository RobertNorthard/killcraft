Option Explicit On

Imports System.Drawing
Imports _2DTileEngine


Public Class FrmMain

    Private Sub FrmMainLoad(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.Load
        'Set game title
        Me.Text = "Game"

        'preload games enviromental variables
        SetEnvironmentVariables()

        'Preload game map
        LoadGameMap()

        'preload Game AI
        LoadAI()

        'Tool Tip options
        tlTipHelp.InitialDelay = 1000
        tlTipHelp.ReshowDelay = 2000
        tlTipHelp.AutoPopDelay = 4000

        'Add tool tip to controls
        tlTipHelp.SetToolTip(lblStartCreativeMode, "Click to start creative mode")
        tlTipHelp.SetToolTip(lblSurvivalGameMode, "Click to play zombie survival mode")
        tlTipHelp.SetToolTip(lblHighScoreBoard, "Click to open highscore board")
        tlTipHelp.SetToolTip(lblExit, "Click to exit application")

        'Load game music
        My.Computer.Audio.Play("..\Music\01_Calm 1.wav", AudioPlayMode.Background)

        'Intiate double buffer
        SetStyle(ControlStyles.AllPaintingInWmPaint Or ControlStyles.UserPaint Or ControlStyles.DoubleBuffer, True)
    End Sub

    'Paints object on form
    Private Sub FrmMainPaint(ByVal sender As System.Object, ByVal e As Windows.Forms.PaintEventArgs) Handles MyBase.Paint

        If IsActive = True Then
            'Draw map
            _gameMap.DrawMap(e.Graphics)

            'Drawm sprites
            _sprite.DrawSprite(e.Graphics)

            If _bulletFired = True Then
                For Each _item In _sprite.BulletObjects
                    _item.FireBullet(e.Graphics)
                Next
            End If

            If _gameModeSurvival = True Then
                _ai.DrawSprite(e.Graphics)
                _ai2.DrawSprite(e.Graphics)
            End If
        End If
    End Sub


    Private Sub FrmMainKeyDown(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown

        'Invoke correct method based on keyboard input
        Select Case e.KeyCode
            Case Keys.Up
                _sprite.MoveUp()

            Case Keys.Down
                _sprite.MoveDown()

            Case Keys.Left
                _sprite.MoveLeft()

            Case Keys.Right
                _sprite.MoveRight()

            Case Keys.Space
                _bulletFired = True
                _sprite.FireBullet()

            Case Keys.T
                _sprite.PlaceTile(_sprite.SpriteRectangle.X, _sprite.SpriteRectangle.Y)

            Case Keys.Y
                If pnlTileSelection.Visible = True Then
                    pnlTileSelection.Visible = False
                Else
                    pnlTileSelection.Visible = True
                End If
        End Select

        Refresh()

    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles ExitToolStripMenuItem.Click
        'Exit program
        End

    End Sub

    Private Sub StartGameToolStripMenuItemClick(ByVal sender As System.Object, ByVal e As EventArgs) Handles StartGameToolStripMenuItem.Click
        StartGame()
    End Sub

    Private Sub PctMudClick(ByVal sender As System.Object, ByVal e As EventArgs) Handles pctMud.Click
        _sprite._selectedTile = 2
        pctSelectedTile.Image = _gameMap.BmpTextures(2)
    End Sub

    Private Sub PctGrassClick(ByVal sender As System.Object, ByVal e As EventArgs) Handles pctGrass.Click
        _sprite._selectedTile = 0
        pctSelectedTile.Image = _gameMap.BmpTextures(0)
    End Sub

    Private Sub PctWoodClick(ByVal sender As System.Object, ByVal e As EventArgs) Handles pctWood.Click
        _sprite._selectedTile = 5
        pctSelectedTile.Image = _gameMap.BmpTextures(5)
    End Sub

    Private Sub PctRoadClick(ByVal sender As System.Object, ByVal e As EventArgs) Handles pctRoad.Click
        _sprite._selectedTile = 3
        pctSelectedTile.Image = _gameMap.BmpTextures(3)
    End Sub

    Private Sub PctRockClick(ByVal sender As System.Object, ByVal e As EventArgs) Handles pctRock.Click
        _sprite._selectedTile = 4
        pctSelectedTile.Image = _gameMap.BmpTextures(4)
    End Sub

    Private Sub PctGroundClick(ByVal sender As System.Object, ByVal e As EventArgs) Handles pctGround.Click
        _sprite._selectedTile = 1
        pctSelectedTile.Image = _gameMap.BmpTextures(1)
    End Sub

    Private Sub TmrAITick(ByVal sender As System.Object, ByVal e As EventArgs) Handles tmrAI.Tick
        'Moves AI
        _ai.Attack()
        _ai2.Attack()
    End Sub


    Private Sub tmrBullets_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrBullets.Tick

        'Updates bullets position once fired
        _sprite.UpdateBulletPosition()

        'Checks for object collision detection
        ObjectCollision()

        'Invokes the repaint method
        Refresh()
    End Sub

    Private Sub tmrGameTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrGameTimer.Tick

        lblGameTimeValue.Text = Val(lblGameTimeValue.Text) - 1


        If Val(lblGameTimeValue.Text) = 0 Then
            StopGame()
            Dim gameScore = lblGamePointScore.Text
            Dim playerName = InputBox("Enter your name to be added to the highscores board. your scorF: " + lblGamePointScore.Text, "Player Name")
            'PlayerScores.ReadPlayerScore(playerName.ToString(), gameScore)
        End If
    End Sub

    Private Sub lblStartCreativeMode_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblStartCreativeMode.Click
        StartGame()
    End Sub

    Private Sub lblHighScoreBoard_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblHighScoreBoard.Click
        frmHighScoreBoard.Show()
    End Sub

    Private Sub lblSurvivalGameMode_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblSurvivalGameMode.Click
        _gameModeSurvival = True
        StartGame()
    End Sub

    Private Sub lblExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblExit.Click
        End
    End Sub

    Private Sub lblHelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblHelp.Click
        'Open Help form
        frmHelp.Show()
    End Sub

    Private Sub StartGameToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StartGameToolStripMenuItem1.Click
        StartGame()
    End Sub

    Private Sub StopGameToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StopGameToolStripMenuItem1.Click
        StopGame()
    End Sub

    Private Sub ExitToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem1.Click
        End
    End Sub

    Private Sub HelpToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HelpToolStripMenuItem1.Click
        frmHelp.Show()
    End Sub

    Private Sub lblSurvivalGameMode_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblSurvivalGameMode.MouseHover
        lblSurvivalGameMode.ForeColor = Color.Red
    End Sub

    Private Sub lblHighScoreBoard_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblHighScoreBoard.MouseHover
        lblHighScoreBoard.ForeColor = Color.Beige
    End Sub

    Private Sub lblStartCreativeMode_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblStartCreativeMode.MouseHover
        lblStartCreativeMode.ForeColor = Color.DeepPink
    End Sub

    Private Sub lblHelp_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblHelp.MouseHover
        lblHelp.ForeColor = Color.Aqua
    End Sub

    Private Sub lblExit_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblExit.MouseHover
        lblExit.ForeColor = Color.Lime
    End Sub

    Public Sub ObjectCollision()

        'Check each bullet object and checks for intersection between objects
        For Each _item In _sprite.BulletObjects

            If _ai.SpriteRectangle.IntersectsWith(_item.SpritePosition) = True Then
                _ai.HealthValue -= 25
                lblGamePointScore.Text += 25
                _item.Dispose()
            End If

            If _ai2.SpriteRectangle.IntersectsWith(_item.SpritePosition) Then
                _ai2.HealthValue -= 25
                lblGamePointScore.Text += 25
                _item.Dispose()
            End If
        Next

        'Checks to see if sprite intersects with AI opponents
        If _ai2.SpriteRectangle.IntersectsWith(_sprite.SpriteRectangle) Then
            _sprite.HealthValue -= 25
        End If
        If _ai.SpriteRectangle.IntersectsWith(_sprite.SpriteRectangle) Then
            _sprite.HealthValue -= 25
        End If

        If _sprite.HealthValue = 0 Then
            MessageBox.Show("Hmm you've seem to have died")
            StopGame()
            _sprite.HealthValue = 100
        End If
    End Sub

    Public Sub StartGame()
        IsActive = True

        'Game Timers start
        tmrAI.Enabled = False
        tmrBullets.Enabled = True

        If _gameModeSurvival = True Then
            tmrGameTimer.Enabled = True
            tmrAI.Enabled = True
            pnlGameStats.Visible = True
            lblGameTimeValue.Text = "30"
        Else
            'Hide Form  Controls
            pnlGameStats.Visible = False

        End If
        pnlGameOptions.Visible = False
        Refresh()
    End Sub

    Public Sub StopGame()

        'Disable game timers
        tmrAI.Enabled = False
        tmrBullets.Enabled = False

        _gameModeSurvival = False

        tmrGameTimer.Enabled = False

        'Show Form Controls
        pnlGameOptions.Visible = True
        pnlGameStats.Visible = False

    End Sub

    Private Sub pnlTileSelection_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles pnlTileSelection.Paint

    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        _sprite._selectedTile = 6
        pctSelectedTile.Image = _gameMap.BmpTextures(6)
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        _sprite._selectedTile = 7
        pctSelectedTile.Image = _gameMap.BmpTextures(7)
    End Sub
End Class