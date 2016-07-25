Option Explicit On

Imports System.Drawing

''' <summary>
''' The game mechanics class is responsible for managing the games physics, such as vector manipulation
''' and collision detection etc. 
''' </summary>
Public Class GameMechanics

    ''' <summary>
    ''' Stores the game maps height
    ''' </summary>
    Public Shared MapHeight As Integer = 0

    ''' <summary>
    ''' Stores the game maps width
    ''' </summary>
    Public Shared MapWidth As Integer = 0

    ''' <summary>
    ''' Stores the games tile height
    ''' </summary>
    Public Shared TileHeight As Integer = 50

    ''' <summary>
    ''' Stores the games tile width
    ''' </summary>
    Public Shared TileWidth As Integer = 50

    ''' <summary>
    ''' An array which stores the game map
    ''' </summary>
    Public Shared GameMap(13, 16)

    ''' <summary>
    ''' Stores the environments width
    ''' </summary>
    Public Shared FormWidth As Integer

    ''' <summary>
    ''' Stores the environments height
    ''' </summary>
    Public Shared FormHeight As Integer

    ''' <summary>
    ''' Stores sprites velocity
    ''' </summary>
    Public Shared Velocity = 50

    ''' <summary>
    ''' Gets the magnitude between two points located on a 2D plane using the Cartersian coordinate system
    ''' d=2 root(y2-y1)^2+(x2-x1)^2
    ''' </summary>
    ''' <param name="x2">entity two x location</param>
    ''' <param name="x1">entity one x location</param>
    ''' <param name="y2">entity two y location</param>
    ''' <param name="y1">entity one y location</param>
    ''' <returns>Returns the distance between two points as an integer</returns>
    Public Shared Function GetMagnitude(ByRef x2 As Integer, ByRef x1 As Integer, ByRef y2 As Integer, ByRef y1 As Integer) _
        As Integer

        'Calculates distance between sprite and AI
        Dim dx As Integer = CInt(Math.Pow(x2 - x1, 2))
        Dim dy As Integer = CInt(Math.Pow(y2 - y1, 2))
        Dim distance As Integer = CInt(Math.Pow(dx + dy, 0.5))

        Return distance

    End Function

    ''' <summary>
    ''' This method is responsible for determining if an object adventures outside of the game playable region
    ''' </summary>
    ''' <param name="boundingBox">A rectangle representing the sprites width, height, x and y positioning</param>
    Public Shared Sub CheckBounds(ByRef boundingBox As Rectangle)

        'Canvasses bounds collision detection
        If boundingBox.X < 0 Then
            boundingBox.X += 50
        End If

        If boundingBox.X >= GameMechanics.FormWidth Then
            boundingBox.X -= 50
        End If


        If boundingBox.Y <= 0 Then
            boundingBox.Y += 50
        End If

        If boundingBox.Y >= GameMechanics.FormHeight - 100 Then
            boundingBox.Y -= 50
        End If

    End Sub
End Class
