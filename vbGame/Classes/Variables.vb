Option Explicit On

Imports _2DTileEngine

Module Variables

    'Determines if game running
    Public IsActive As Boolean = False
    Public _gameModeSurvival = False

    'Inititates game map
    Public _gameMap As GameMap

    'Canvas graphic object
    Public _g As Graphics

    'initiate sprite
    Public _sprite As Sprite

    'Determines if bullets fired
    Public _bulletFired As Boolean = False

    'Sprite AIs
    Public _ai As SpriteAi
    Public _ai2 As SpriteAi

    Public _bulletObjects As New Collection
    Public _item As Bullet
    Public GamePlayer As Player

    Public ps As PlayerScores



    Public Sub LoadGameMap()
        ps = New PlayerScores(100)
        'Set map variables 
        _gameMap = New GameMap(800, 800)
        'Load game map
        _gameMap.LoadMap("../Map/Map_Data.txt")

        'Load map textures
        _gameMap.LoadTextures(New Bitmap("..\Images\TileTextures\grass.jpg"), New Bitmap("..\Images\TileTextures\ground.jpg"), New Bitmap("..\Images\TileTextures\Mud.png"), New Bitmap("..\Images\TileTextures\road.jpg"), New Bitmap("..\Images\TileTextures\Rock.png"), New Bitmap("..\Images\TileTextures\wood.jpg"), New Bitmap("..\Images\TileTextures\water.jpg"), New Bitmap("..\Images\TileTextures\Lava.png"))

        'Set sprite variables
        _sprite = New Sprite(New Rectangle(500, 500, 50, 50), 50)

        'Load sprite textures
        _sprite.LoadTextures(New Bitmap("..\Images\Sprite\sprite_left.gif"), New Bitmap("..\Images\Sprite\Sprite_right.gif"), New Bitmap("..\Images\Sprite\Sprite_front.gif"), New Bitmap("..\Images\Sprite\Sprite_back.gif"))
    End Sub

    Public Sub LoadAI()
        'Creates new Sprite AI
        _ai = New SpriteAi(New Rectangle(300, 300, 50, 50), 50, _sprite)
        _ai.LoadTextures(New Bitmap("..\Images\Sprite\AI\skell_left.gif"), New Bitmap("..\Images\Sprite\AI\skell_right.gif"), New Bitmap("..\Images\Sprite\AI\skell_front.gif"), New Bitmap("..\Images\Sprite\AI\skell_back.gif"))

        'Second Sprite AI
        _ai2 = New SpriteAi(New Rectangle(200, 200, 50, 50), 50, _sprite)
        _ai2.LoadTextures(New Bitmap("..\Images\Sprite\AI\skell_left.gif"), New Bitmap("..\Images\Sprite\AI\skell_right.gif"), New Bitmap("..\Images\Sprite\AI\skell_front.gif"), New Bitmap("..\Images\Sprite\AI\skell_back.gif"))

    End Sub

    Public Sub SetEnvironmentVariables()
        'Set form dimensions, ready for object collision tests
        GameMechanics.FormHeight = 800
        GameMechanics.FormWidth = 800
    End Sub
End Module
