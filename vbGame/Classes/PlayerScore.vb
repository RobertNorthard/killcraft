Option Explicit On

Imports System.IO

Public Class PlayerScores

    ''' <summary>
    ''' Array of player objects
    ''' </summary>
    Private scores() As Player

    ''' <summary>
    ''' Numebr of elements in the array
    ''' </summary>
    Private nElements As Integer

    ''' <summary>
    ''' Creates new object of type player scores
    ''' </summary>
    ''' <param name="max">Max number of elements in the array</param>

    Public Sub New(ByVal max As Integer)
        Dim s(max) As Player
        scores = s.Clone()

        For index As Integer = 0 To scores.Length - 1
            scores(index) = New Player("", "")
        Next

        nElements = 0
    End Sub

    ''' <summary>
    ''' Inserts new player object into the array
    ''' </summary>
    ''' <param name="value">object to be added</param>
    ''' <remarks></remarks>
    Public Sub Insert(ByVal value As Player)
        scores(nElements) = value
        nElements += 1
    End Sub

    ''' <summary>
    ''' Bubble sort to sort the object of type player
    ''' </summary>
    Public Sub Sort()

        Dim outer, inner As Integer

        For outer = nElements - 1 To 0 Step -1
            For inner = 0 To outer - 1
                If Double.Parse(scores(inner).Score) > Double.Parse(scores(inner + 1).Score) Then
                    Swap(inner, inner + 1)
                End If
            Next
        Next
    End Sub

    ''' <summary>
    ''' Bubble sort swap element method
    ''' </summary>
    ''' <param name="p1">player 1 object to swap with player 2</param>
    ''' <param name="p2">player 2 object</param>
    Public Sub Swap(ByVal p1 As Integer, ByVal p2 As Integer)
        Dim temp As Player
        temp = scores(p1)
        scores(p1) = scores(p2)
        scores(p2) = temp
    End Sub

    ''' <summary>
    ''' Reads player's scored from a text-file
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub ReadPlayerScore()

        Using StreamReader As New StreamReader("../PlayerScores.txt", True)

            While StreamReader.Peek() <> -1
                Dim playerName As String = StreamReader.ReadLine()
                Dim playerScore As String = StreamReader.ReadLine()
                ps.Insert(New Player(playerName, playerScore))
            End While
        End Using
    End Sub

    ''' <summary>
    ''' Sorts and siplayed sorted array of players
    ''' </summary>
    ''' <returns>returns the sorted array of player scores</returns>
    Public Function DisplayPlayers()
        Sort()
        Return Me.scores
    End Function
End Class
