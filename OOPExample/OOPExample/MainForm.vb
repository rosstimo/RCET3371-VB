Option Strict On
Option Explicit On

Imports System.Drawing
Imports OOPExample.CardGame

Public Class MainForm
    Dim deck As New DeckOfCards()

    Sub junk() Handles Me.Load
        'DisplayPictureBox.BackgroundImageLayout.Center.
        'DisplayPictureBox.BackgroundImage = My.Resources.AC
    End Sub

    Sub DealACard() Handles Me.Click
        Dim card As PlayingCard
        card = deck.Deal()
        If card IsNot Nothing Then
            Console.WriteLine(card.ShortName)
            DisplayCard(card.ShortName)
        End If

    End Sub

    Sub DisplayCard(cardName As String)
        Dim g As Graphics = DisplayPictureBox.CreateGraphics()
        Dim cardImage As Image = Image.FromFile($"..\..\Resources\{cardName}.jpg")
        Dim h% = CInt(150)
        Dim w% = CInt(110)
        Dim x% = RandomNumber(DisplayPictureBox.Width \ 20)
        Dim y% = RandomNumber(DisplayPictureBox.Height \ 20)
        g.TranslateTransform(75, 10)
        g.RotateTransform(CSng(RandomNumber(30) - 15))
        g.DrawImage(cardImage, x, y, w, h)
        g.Dispose()
    End Sub
    Private Function RandomNumber(max As Integer) As Integer
        Randomize()
        Return CInt(Math.Floor(Rnd() * max)) + 1
    End Function

End Class
