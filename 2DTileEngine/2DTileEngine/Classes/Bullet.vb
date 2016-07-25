Option Explicit On

Imports System.Drawing

''' <summary>
''' Bullet Class responsible for created new bullets
''' </summary>
Public Class Bullet

    Private _veloity As Integer 'stores bullets current velocity
    Private _bmpBulletTexture() As Bitmap 'load bullet textures
    Private _spriteState As Integer 'stores bullets state i.e. direction 

    Public SpritePosition As Rectangle 'sprite current position, determines where bullet needs to fire from

    ''' <summary>
    ''' On creating new objects there is no default constructor
    ''' </summary>
    ''' <param name="spritePosition">Stores current sprite positioning</param>
    ''' <param name="bulletVelocity">Stores bullet velocity</param>
    ''' <param name="spriteState">Stores the sprite, sprite state i.e. facing direction</param>
    ''' <param name="bulletTexture">Loads bullet textures</param>
    Public Sub New(ByVal spritePosition As Rectangle, ByVal bulletVelocity As Integer, ByVal spriteState As Integer, ByVal ParamArray bulletTexture() As Bitmap)
        Me.SpritePosition = spritePosition
        _veloity = bulletVelocity
        _spriteState = spriteState
        LoadTexture(bulletTexture)
    End Sub

    ''' <summary>
    ''' Method used to load bullet textures
    ''' </summary>
    ''' <param name="bulletTexture">array of bullet textures as bitmaps</param>
    Public Sub LoadTexture(ByVal bulletTexture() As Bitmap)
        _bmpBulletTexture = bulletTexture.Clone()
    End Sub

    ''' <summary>
    ''' Updates bullet position based on the sprite positioning at the time the bullet was instantiated
    ''' This ensures bullet continues to go in the same direction
    ''' </summary>
    ''' <remarks>Speed = Distance/Time</remarks>
    Public Sub UpdateBulletPosition()
        Select Case _spriteState
            Case 0
                SpritePosition.X -= _veloity
            Case 1
                SpritePosition.X += _veloity
            Case 2
                SpritePosition.Y += _veloity
            Case 3
                SpritePosition.Y -= _veloity
        End Select
    End Sub

    '''<summary></summary>
    Public Sub Dispose()

        Me.SpritePosition = Nothing

    End Sub

    ''' <summary>
    ''' Draw ne bullet on the games canvas
    ''' </summary>
    ''' <param name="g">Graphics obect used to draw the bullet on canvas</param>
    Public Sub FireBullet(ByVal g As Graphics)
        g.DrawImage(_bmpBulletTexture(_spriteState), SpritePosition)
    End Sub
End Class
