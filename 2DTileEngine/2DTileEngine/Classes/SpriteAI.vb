Option Explicit On

Imports System.Drawing

''' <summary>
''' Sprite AI Class
''' </summary>
''' <remarks>Inheirts basic functions and methods from Sprite Class, which impliments the sprite interface</remarks>
Public Class SpriteAi
    Inherits Sprite

    ''' <summary>
    ''' Sprite stae
    ''' </summary>
    Private _sprite As Sprite

    ''' <summary>
    ''' Stores AI difficulty as integer
    ''' </summary>
    ''' <remarks>Higher the difficulty, further away the AI can find you from - increases their field of view</remarks>
    Private _difficulty As Integer = 200

    ''' <summary>
    ''' Stores distance between sprite and spriteAI
    ''' </summary>
    Private _distance As Integer

    'Random number to determine random AI movement
    Private _number As Integer
    ReadOnly _ranNumber As New Random

    ''' <summary>
    ''' On creating new object call the base classes construtor in order to create new Sprite. 
    ''' </summary>
    ''' <param name="spriteRectangle">Stores sprite bounding box</param>
    ''' <param name="velocity">Stores velocity of sprite</param>
    ''' <param name="playerSprite">Stores the players sprite object - used to allow AI find the location on the player</param>
    ''' <remarks></remarks>
    Public Sub New(ByRef spriteRectangle As Rectangle, ByRef velocity As Integer, ByRef playerSprite As Sprite)

        MyBase.New(spriteRectangle, velocity)
        _sprite = playerSprite

    End Sub

    ''' <summary>
    ''' Player staus methoid, determines if sprite is dead. If AI sprite is dead then spawn in new location with
    ''' parametres such as sprite health set to there default values
    ''' </summary>
    ''' <returns>Returns true or false. True if sprite is dead, false is sprite is alive</returns>
    Public Function PlayerStatus() As Boolean

        'Create new ranom AI if AI health = 0 and increase game difficulty
        If HealthValue <= 0 Then
            SpriteRectangle.X = _ranNumber.Next(1, 14) * GameMechanics.TileHeight
            SpriteRectangle.Y = _ranNumber.Next(1, 14) * GameMechanics.TileWidth
            HealthValue = 50
            _difficulty += 25
            Return True
        End If

        Return False

    End Function

    ''' <summary>
    ''' Moves AI to the positioning on the playe sprite, in order to attack
    ''' </summary>
    Public Sub Attack()

        'If distance over certain magnitude AI = random movement
        _distance = GameMechanics.GetMagnitude(SpriteRectangle.X, _sprite.SpriteRectangle.X, SpriteRectangle.Y, _sprite.SpriteRectangle.Y)

        If _distance <= _difficulty Then
            If SpriteRectangle.X < _sprite.SpriteRectangle.X Then
                MoveRight()
            ElseIf SpriteRectangle.X > _sprite.SpriteRectangle.X Then
                MoveLeft()
            ElseIf SpriteRectangle.Y < _sprite.SpriteRectangle.Y Then
                MoveDown()
            ElseIf SpriteRectangle.Y > _sprite.SpriteRectangle.Y Then
                MoveUp()
            End If
        Else
            RandomMovement()
        End If

    End Sub

    ''' <summary>
    ''' When Invokes moves AI randomly
    ''' </summary>
    ''' <remarks>Pseudo random numbe generator of a uniform distribution, making the probability of generating a number even </remarks>
    Public Sub RandomMovement()

        _number = _ranNumber.Next(1, 20) 'generate psuedo random number for AI movement 

        If _number <= 5 Then
            MoveDown()
        End If
        If _number > 5 And _number <= 10 Then
            MoveUp()
        End If
        If _number > 10 And _number <= 15 Then
            MoveRight()
        End If
        If _number > 15 Then
            MoveLeft()
        End If

    End Sub

    ''' <summary>
    ''' Overloads the base classes draw sprite method
    ''' </summary>
    ''' <param name="g">Graphics Objects requires to draw sprire on canvas</param>
    Public Overloads Sub DrawSprite(ByRef g As Graphics)

        'if player not dead then draw
        If PlayerStatus() = False Then
            g.DrawImage(MyBase._textures(MyBase.State), MyBase.SpriteRectangle) 'draw sprite

            'draw sprite health bar
            g.FillRectangle(Brushes.Red, New Rectangle(SpriteRectangle.X, SpriteRectangle.Y - 10, 50, 5))
            g.FillRectangle(Brushes.LightGreen, _
                             New Rectangle(SpriteRectangle.X, SpriteRectangle.Y - 10, MyBase.HealthValue, 5))

            If GameMechanics.GetMagnitude(SpriteRectangle.X, _sprite.SpriteRectangle.X, SpriteRectangle.Y, _sprite.SpriteRectangle.Y) < _difficulty Then
                g.DrawString("I shall kill you!", New Font("Ariel", 10), Brushes.Pink, SpriteRectangle.X, SpriteRectangle.Y - 30)
            End If
        End If
    End Sub

End Class
