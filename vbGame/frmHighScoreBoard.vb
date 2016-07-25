Option Explicit On

Imports System.IO

Public Class frmHighScoreBoard
    Private Sub frmHighScoreBoard_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        ps.ReadPlayerScore()
        Dim PlayerScores() As Player
        PlayerScores = ps.DisplayPlayers()

        For index As Integer = 0 To PlayerScores.Length - 1
            If PlayerScores(PlayerScores.Length - index - 1).Name <> "" Then

                lblPlayerName.Items.Add(PlayerScores(PlayerScores.Length - index - 1).Name)
                lblPlayerScore.Items.Add(PlayerScores(PlayerScores.Length - index - 1).Score)
            End If
        Next

    End Sub
End Class