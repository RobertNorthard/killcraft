Imports System.Drawing

''' <summary>
''' Manages the relation ship between classes, and the need for certain methods when manipulating sprites positioning
''' </summary>
''' <remarks>Implemented by Sprite Class and SpriteAI Class</remarks>
Public Interface ISprite

    ''' <summary>
    ''' Load Sprite Textures
    ''' </summary>
    ''' <param name="textures">Sprite Textures as param array</param>
    Sub LoadTextures(ByVal ParamArray textures() As Image)

    ''' <summary>
    ''' Method for Drawing Sprite
    ''' </summary>
    ''' <param name="g">Graphics object</param>
    Sub DrawSprite(ByRef g As Graphics)

    ''' <summary>
    ''' Move Sprite Left
    ''' </summary>
    Sub MoveLeft()

    ''' <summary>
    ''' Move Sprite Right
    ''' </summary>
    Sub MoveRight()

    ''' <summary>
    ''' Move Sprite Down
    ''' </summary>
    Sub MoveDown()

    ''' <summary>
    ''' Move Sprite Up
    ''' </summary>
    Sub MoveUp()

End Interface
