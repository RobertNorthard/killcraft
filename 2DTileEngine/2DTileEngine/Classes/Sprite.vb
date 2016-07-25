Option Explicit On

Imports System.Drawing

Public Class Sprite
    Implements ISprite

    ''' <summary>
    ''' The tile the players sprite is currently on
    ''' </summary>
    Public _selectedTile As Integer

    ''' <summary>
    ''' Stores sprite textures
    ''' </summary>
    Public _textures() As Image

    ''' <summary>
    ''' A new object of type bullet
    ''' </summary>
    Private _item As Bullet

    ''' <summary>
    ''' Stores the current sprite state i.e. the direction the sprite is facing
    ''' </summary>
    Public State As Integer = 0

    ''' <summary>
    ''' The player sprite bounding box. Stores the sprite x, y location and width, height
    ''' </summary>
    Public SpriteRectangle As Rectangle

    ''' <summary>
    ''' Stores the player health
    ''' </summary>
    Public HealthValue As Integer = 50

    ''' <summary>
    ''' A new collection of bullets
    ''' </summary>
    ''' <remarks>Each time a new bullet is fired it is added to the collection of bullets. This makes updating each bullet easier</remarks>
    Public BulletObjects As New Collection

    ''' <summary>
    ''' The sprite active, if active sprite is alive etc. 
    ''' </summary>
    Public isActive As Boolean = True

    Public Sub New(ByRef spriteRectangle As Rectangle, ByRef velocity As Integer)

        'set sprite variables
        Me.SpriteRectangle = spriteRectangle
        GameMechanics.Velocity = velocity

    End Sub

    ''' <summary>
    ''' Loads sprite textures into an array of bitmap images <seealso>_textures</seealso>
    ''' </summary>
    ''' <param name="textures">Textures that represent the sprite's different states</param>
    Public Overridable Sub LoadTextures(ByVal ParamArray textures() As Image) Implements ISprite.LoadTextures

        _textures = textures.Clone() 'load sprite textures

    End Sub

    ''' <summary>
    ''' Draws game sprite
    ''' </summary>
    ''' <param name="g">Graphics object required in order to draw sprite on canvas</param>
    Public Overridable Sub DrawSprite(ByRef g As Graphics) Implements ISprite.DrawSprite

        g.DrawImage(_textures(State), SpriteRectangle) 'Draw player sprite

        'Draw player's health bar
        g.FillRectangle(Brushes.Red, New Rectangle(SpriteRectangle.X, SpriteRectangle.Y - 10, 50, 5))
        g.FillRectangle(Brushes.CornflowerBlue, New Rectangle(SpriteRectangle.X, SpriteRectangle.Y - 10, HealthValue, 5))
    End Sub

    ''' <summary>
    ''' Calculates the current sprites positioning on tile. 
    ''' </summary>
    ''' <param name="x">player X coordinate</param>
    ''' <param name="y">Player Y coordinate</param>
    Public Overridable Sub PlaceTile(ByVal x As Integer, ByVal y As Integer)

        Select Case State
            Case 0
                x -= GameMechanics.Velocity

            Case 1
                x += GameMechanics.Velocity

            Case 2
                y += GameMechanics.Velocity

            Case 3
                y -= GameMechanics.Velocity
        End Select

        'Calculates sprites current position on tile
        Dim tileX = SpriteXCord(x)
        Dim tileY = SpriteYCord(y)

        GameMechanics.GameMap(tileY, tileX) = _selectedTile
    End Sub
    ''' <summary>
    ''' Gets the player's sprite's X coordinate
    ''' </summary>
    ''' <param name="x">players s location</param>
    ''' <returns>returns the current X player's location on the tile grid</returns>
    Public Function SpriteYCord(ByVal x As Integer) As Integer
        Return Math.Floor((x) / 50)
    End Function

    ''' <summary>
    ''' Gets the player's sprite's y coordinate
    ''' </summary>
    ''' <param name="y">player y coordinate</param>
    ''' <returns>returns players y location on the tile grid</returns>
    Public Function SpriteXCord(ByVal y As Integer) As Integer
        Return Math.Floor((y) / 50)
    End Function

    ''' <summary>
    ''' Calculates the current sprites positioning on tile. And allows once invoked to change a tile         
    ''' </summary>
    ''' <param name="x">X position of player</param>
    ''' <param name="y">Y position of player</param>
    Public Function TilePassable(ByVal x As Integer, ByVal y As Integer) As Boolean

        'Calculates sprites current position on tile
        Dim tileX = SpriteXCord(x)
        Dim tileY = SpriteYCord(y)


        If x >= 0 And y > 0 And y < 700 And x < 800 Then
            'Tiles that cannot be passed by the sprite entitity
            If GameMechanics.GameMap(tileY, tileX) = 6 Or GameMechanics.GameMap(tileY, tileX) = 7 _
            Or GameMechanics.GameMap(tileY, tileX) = 5 Or GameMechanics.GameMap(tileY, tileX) = 4 Then
                Return False
            End If
        End If

        Return True

    End Function

    ''' <summary>
    ''' Updates all the bullets positioning in the BulletObjects Collection
    ''' </summary>
    Public Overridable Sub UpdateBulletPosition()
        For Each Me._item In BulletObjects
            Me._item.UpdateBulletPosition()
        Next
    End Sub

    ''' <summary>
    ''' Fires Bullet
    ''' </summary>
    Public Overridable Sub FireBullet()

        'Add new bullet to bullet objects collection
        BulletObjects.Add(New Bullet(New Rectangle(SpriteRectangle.X, SpriteRectangle.Y, 50, 50), 50, State, New Bitmap("..\Images\Fireball\Fireball_left.png"), New Bitmap("..\Images\Fireball\Fireball.png"), New Bitmap("..\Images\Fireball\Fireball_down.png"), New Bitmap("..\Images\Fireball\Fireball_up.png")))

    End Sub

    ''' <summary>
    ''' Moves sprite left
    ''' </summary>
    ''' <remarks>Velocity = 50</remarks>
    Public Overridable Sub MoveLeft() Implements ISprite.MoveLeft

        State = 0 'Set sprite state
        If TilePassable(SpriteRectangle.X - GameMechanics.Velocity, SpriteRectangle.Y) Then
            SpriteRectangle.X -= GameMechanics.Velocity
            GameMechanics.CheckBounds(SpriteRectangle) 'check collision detection
        End If
    End Sub

    ''' <summary>
    ''' Moves sprite right
    ''' </summary>
    ''' <remarks>Velocity = 50</remarks>
    Public Overridable Sub MoveRight() Implements ISprite.MoveRight

        State = 1 'Set sprite state

        If TilePassable(SpriteRectangle.X + GameMechanics.Velocity, SpriteRectangle.Y) Then
            SpriteRectangle.X += GameMechanics.Velocity
            GameMechanics.CheckBounds(SpriteRectangle) 'check collision detection
        End If

    End Sub

    ''' <summary>
    ''' Moves sprite down
    ''' </summary>
    ''' <remarks>Velocity = 50</remarks>
    Public Overridable Sub MoveDown() Implements ISprite.MoveDown

        State = 2 'Set sprite state

        If TilePassable(SpriteRectangle.X, SpriteRectangle.Y + GameMechanics.Velocity) Then
            SpriteRectangle.Y += GameMechanics.Velocity
            GameMechanics.CheckBounds(SpriteRectangle) 'check collision detection
        End If

    End Sub

    ''' <summary>
    ''' Moves sprite up
    ''' </summary>
    ''' <remarks>Velocity = 50</remarks>
    Public Overridable Sub MoveUp() Implements ISprite.MoveUp

        State = 3 'Set sprite state
        If TilePassable(SpriteRectangle.X, SpriteRectangle.Y - GameMechanics.Velocity) Then
            SpriteRectangle.Y -= GameMechanics.Velocity
            GameMechanics.CheckBounds(SpriteRectangle) 'check collision detection
        End If

    End Sub
End Class
