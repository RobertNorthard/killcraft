Option Explicit On

Imports System.Drawing

''' <summary>
''' GameMap class is responsible for drawing the games map on to the games canvas
''' </summary>
Public Class GameMap

    ''' <summary>
    ''' The current tile ID of the tile that the sprite is on
    ''' </summary>
    Private _textureId As String = 0

    ''' <summary>
    ''' Stores the tile textures as bitmaps
    ''' </summary>
    Public BmpTextures() As Bitmap  'Map Textures

    ''' <summary>
    ''' On instantiating a new game map you need to specify certain parametres
    ''' </summary>
    ''' <param name="mapWidth">Map Width</param>
    ''' <param name="mapHeight">Map Height</param>
    Public Sub New(ByRef mapWidth As Integer, ByRef mapHeight As Integer)

        GameMechanics.MapHeight = mapHeight
        GameMechanics.MapWidth = mapWidth

    End Sub

    ''' <summary>
    ''' Loads game map
    ''' </summary>
    ''' <param name="uri">File path of the games map</param>
    Public Sub LoadMap(ByRef uri As String)

        Dim line As String

        'Load map
        Using reader As New IO.StreamReader(uri)
            For x As Integer = 0 To 13

                line = reader.ReadLine()

                Dim tokens() As String = line.Split("-")

                'Stores text file values into multi-dimensional array
                For y As Integer = 0 To 15
                    GameMechanics.GameMap(x, y) = Integer.Parse(tokens(y))
                Next y
            Next x
        End Using
    End Sub

    ''' <summary>
    ''' Load map tile textures
    ''' </summary>
    ''' <param name="textures">The tile textures as bitmaps</param>
    Public Sub LoadTextures(ByVal ParamArray textures() As Bitmap)

        BmpTextures = textures.Clone()

    End Sub

    ''' <summary>
    ''' Draws Game Map
    ''' </summary>
    ''' <param name="graphics">Graphics object, used when drawing to games canvas</param>
    ''' <remarks>TileHeight, TileWidth are used as offsets
    ''' Algorithm runs in 0(n^2) time complexity</remarks>
    Public Sub DrawMap(ByRef graphics As Graphics)
        For x As Integer = 0 To GameMechanics.GameMap.GetLength(1) - 1
            For y As Integer = 0 To GameMechanics.GameMap.GetLength(0) - 1
                _textureId = GameMechanics.GameMap(y, x)
                graphics.DrawImage(BmpTextures(_textureId), New Rectangle(x * GameMechanics.TileHeight, y * GameMechanics.TileHeight, 50, 50))
            Next
        Next
    End Sub
End Class
