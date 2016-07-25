Option Explicit On
''' <summary>
''' Player oject class
''' </summary>
''' <remarks></remarks>
Public Class Player

    ''' <summary>
    ''' Stores player name
    ''' </summary>
    Public Name As String

    ''' <summary>
    ''' Stores player score
    ''' </summary>
    Public Score As String


    ''' <summary>
    ''' Creates new objec of type player
    ''' </summary>
    ''' <param name="playerName">represents player's name as string</param>
    ''' <param name="playerScore">represents player score as string</param>
    ''' <remarks></remarks>
    Public Sub New(ByVal playerName As String, ByVal playerScore As String)
        Name = playerName
        Score = playerScore
    End Sub
End Class
