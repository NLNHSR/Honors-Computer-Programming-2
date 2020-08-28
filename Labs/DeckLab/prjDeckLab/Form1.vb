Public Class frmDeckLab
    Dim x As Integer
    Dim y As Integer
    Dim i As Integer
    Dim path As String
    Dim arrDeck(52) As String
    Private Structure Card
        Dim v As Integer
        Dim s As Integer
        Dim cs As String
        Function GetCardString()
            cs = ""
            Select Case v
                Case 1
                    cs = "a"
                Case 10
                    cs = "t"
                Case 11
                    cs = "j"
                Case 12
                    cs = "q"
                Case 13
                    cs = "k"
                Case Else
                    cs += Trim(Str(v))
            End Select
            Select Case s
                Case 1
                    cs += "c"
                Case 2
                    cs += "d"
                Case 3
                    cs += "h"
                Case 4
                    cs += "s"
            End Select
            Return cs
        End Function
    End Structure
    Private Sub cmdDeck_Click(sender As Object, e As EventArgs) Handles cmdDeck.Click
        Dim cs As String
        Dim Deck As Card
        i = 0
        lstDeck.Items.Clear()
        For x = 1 To 4
            For y = 1 To 13
                With Deck
                    i = i + 1
                    .v = y
                    .s = x
                    arrDeck(i) = Deck.GetCardString
                    lstDeck.Items.Add(arrDeck(i))
                End With
            Next
        Next
    End Sub

    Private Sub cmdCard_Click(sender As Object, e As EventArgs) Handles cmdCard.Click
        Dim card As String
        Dim v As Integer
        Dim s As Integer
        Card = arrDeck((Int((Rnd() * 52) + 1)))
        'path = "C:\Users\Neel Shettigar\Desktop\CP\Computer Programming 2\Card Images\cardimages\" & card & ".gif"
        path = "\\kummer2\Student Work\Computer Programming 2\Card Images\cardimages\" & card & ".gif"
        picCard.Image = Image.FromFile(path)
    End Sub

    Private Sub cmdShuffle_Click(sender As Object, e As EventArgs) Handles cmdShuffle.Click
        Dim temp As String
        lstDeck.Items.Clear()

        For i = 1 To 2704
            x = Int((Rnd() * 52) + 1)
            y = Int((Rnd() * 52) + 1)
            temp = arrDeck(x)
            arrDeck(x) = arrDeck(y)
            arrDeck(y) = temp
        Next
        For i = 1 To 52
            lstDeck.Items.Add(arrDeck(i))
        Next
    End Sub

    Private Sub LstDeck_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstDeck.SelectedIndexChanged
        Dim card As String
        card = lstDeck.SelectedItem
        path = "\\kummer2\Student Work\Computer Programming 2\Card Images\cardimages\" & card & ".gif"
        picCard.Image = Image.FromFile(path)
    End Sub
End Class
