Public Class frmBlackJack
    Dim arrPlayerPics(5) As PictureBox
    Dim arrPlayerSplitPics(5) As PictureBox
    Dim arrDealerPics(5) As PictureBox
    Dim totalpoints As Integer
    Dim betpoints As Integer
    Sub SetControlArrays()
        arrPlayerPics(1) = P1
        arrPlayerPics(2) = P2
        arrPlayerPics(3) = P3
        arrPlayerPics(4) = P4
        arrPlayerPics(5) = P5
        arrPlayerSplitPics(1) = PS1
        arrPlayerSplitPics(2) = PS2
        arrPlayerSplitPics(3) = PS3
        arrPlayerSplitPics(4) = PS4
        arrPlayerSplitPics(5) = PS5
        arrDealerPics(1) = D1
        arrDealerPics(2) = D2
        arrDealerPics(3) = D3
        arrDealerPics(4) = D4
        arrDealerPics(5) = D5
    End Sub
    Structure card
        Dim v As Integer
        Dim s As Integer
        Dim cs As String
        Dim val As Integer
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
        Function GetCardValue()
            Select Case v
                Case 1
                    val = 11
                Case 11
                    val = 10
                Case 12
                    val = 10
                Case 13
                    val = 10
                Case Else
                    val = v
            End Select
            Return val
        End Function
    End Structure
    Dim cardstruct As card
    Structure deck
        Dim arrcards() As card
        Sub create()
            ReDim arrcards(52)
            Dim cc As Integer = 1
            For i As Integer = 1 To 13
                For j As Integer = 1 To 4
                    arrcards(cc).v = i
                    arrcards(cc).s = j
                    cc += 1
                Next
            Next
        End Sub
        Sub shuffle()
            Dim temp As card, y As Integer
            Randomize()
            For x As Integer = 1 To 52
                y = Int(Rnd() * 52) + 1
                temp = arrcards(x)
                arrcards(x) = arrcards(y)
                arrcards(y) = temp
            Next
        End Sub
    End Structure
    Dim FullDeck As deck
    Dim pc As Integer, dc As Integer, fc As Integer, pbj As Integer, dbj As Integer
    Dim pp As Integer, dp As Integer
    Dim pcs As Integer, pbjs As Integer, pps As Integer
    Dim SplitDone As Boolean

    Private Sub CmdStand_Click(sender As Object, e As EventArgs) Handles cmdStand.Click
        If SplitDone = False And split = True Then
            SplitTurn = True
            SplitDone = True
            picSplit.Visible = True
        Else
            Dim path As String
            'path = "\\kummer2\Student Work\Computer Programming 2\Card Images\cardimages\" & arrDealerHand.arrcard(1).GetCardString & ".gif"
            path = "C:\Users\Neel Shettigar\Desktop\CP\Computer Programming 2\Card Images\cardimages\" & arrDealerHand.arrcard(1).GetCardString & ".gif"
            arrDealerPics(1).Image = Image.FromFile(path)
            dbj = arrDealerHand.arrcard(1).GetCardValue + arrDealerHand.arrcard(2).GetCardValue
            gbDealer.Text = "Dealer BJ Score: " & Str(dbj)
            dp += 1
            dc += 1
            If dbj = 21 Then
                MsgBox("You Lose!")
                totalpoints += (betpoints * 2)
                If insurancecheck = True Then
                    totalpoints += insurancepoints * 2
                End If
                lblPoints.Text = totalpoints
                arrplayers(playercount).score = totalpoints
            ElseIf dbj = pbj Then
                MsgBox("Its a Tie!")
                totalpoints += betpoints
                lblPoints.Text = totalpoints
                arrplayers(playercount).score = totalpoints
            ElseIf dbj > pbj Then
                MsgBox("You Lose!")
            Else
                Do Until dbj >= 17
                    'path = "\\kummer2\Student Work\Computer Programming 2\Card Images\cardimages\" & FullDeck.arrcards(fc).GetCardString & ".gif"
                    path = "C:\Users\Neel Shettigar\Desktop\CP\Computer Programming 2\Card Images\cardimages\" & FullDeck.arrcards(fc).GetCardString & ".gif"
                    arrDealerPics(dp).Image = Image.FromFile(path)
                    arrDealerHand.addcard(FullDeck.arrcards(fc), dc)
                    dbj += FullDeck.arrcards(fc).GetCardValue
                    gbDealer.Text = "Dealer BJ Score: " & Str(dbj)
                    dc += 1
                    dp += 1
                    fc += 1
                    If dbj >= 21 Then
                        Exit Do
                    End If
                Loop
                If dbj > 21 Then
                    MsgBox("You Win!")
                    totalpoints += (betpoints * 2)
                    lblPoints.Text = totalpoints
                    arrplayers(playercount).score = totalpoints
                ElseIf dbj > pbj Then
                    MsgBox("You Lose!")
                ElseIf pbj > dbj Then
                    MsgBox("You Win!")
                    totalpoints += betpoints * 2
                    lblPoints.Text = totalpoints
                    arrplayers(playercount).score = totalpoints
                ElseIf pbj = dbj Then
                    MsgBox("Its a Tie!")
                    totalpoints += betpoints
                    lblPoints.Text = totalpoints
                    arrplayers(playercount).score = totalpoints
                End If
            End If
            gbDealer.Text = "Dealer BJ Score: " & Str(dbj)
            If SplitDone = True And split = True Then
                If dbj = 21 Then
                    MsgBox("You Lose!")
                    totalpoints += (betpoints * 2)
                    If insurancecheck = True Then
                        totalpoints += insurancepoints * 2
                    End If
                    lblPoints.Text = totalpoints
                    arrplayers(playercount).score = totalpoints
                ElseIf dbj = pbjs Then
                    MsgBox("Its a Tie!")
                    totalpoints += betpoints
                    lblPoints.Text = totalpoints
                    arrplayers(playercount).score = totalpoints
                ElseIf dbj > pbjs Then
                    MsgBox("You Lose!")
                Else
                    If dbj > 21 Then
                        MsgBox("You Win!")
                        totalpoints += (betpoints * 2)
                        lblPoints.Text = totalpoints
                        arrplayers(playercount).score = totalpoints
                    ElseIf dbj > pbj Then
                        MsgBox("You Lose!")
                    ElseIf pbjs > dbj Then
                        MsgBox("You Win!")
                        totalpoints += betpoints * 2
                        lblPoints.Text = totalpoints
                        arrplayers(playercount).score = totalpoints
                    ElseIf pbjs = dbj Then
                        MsgBox("Its a Tie!")
                        totalpoints += betpoints
                        lblPoints.Text = totalpoints
                        arrplayers(playercount).score = totalpoints
                    End If
                End If
                gbDealer.Text = "Dealer BJ Score: " & Str(dbj)
            End If
        End If
    End Sub

    Private Sub cmdPlay_Click(sender As Object, e As EventArgs) Handles cmdPlay.Click
        FullDeck.create()
        FullDeck.shuffle()
        SetControlArrays()
        arrDealerHand.create()
        arrPlayerHand.create()
        Dim path As String
        lblPoints.Text = totalpoints
        Dim pointscheck As Boolean
        picSplit.Visible = False
        Do
            pointscheck = True
            betpoints = InputBox("Enter Amount", "Bet Points", Str(Int(totalpoints / 2)))
            If betpoints > totalpoints Then
                pointscheck = False
                betpoints = 0
                MsgBox("Not Enough Points!")
            End If
        Loop Until pointscheck = True
        totalpoints -= betpoints
        lblPoints.Text = totalpoints
        arrplayers(playercount).score = totalpoints
        pbj = 0
        dbj = 0
        pp = 0
        dp = 0
        dc = 0
        pc = 0
        For i As Integer = 1 To 5
            arrPlayerPics(i).Image = Nothing
            arrDealerPics(i).Image = Nothing
            arrPlayerSplitPics(i).Image = Nothing
        Next
        gbDealer.Text = "Dealer BJ Score:"
        fc = 1
        dc += 1
        dp += 1
        'path = "\\kummer2\Student Work\Computer Programming 2\Card Images\cardimages\b.gif"
        path = "C:\Users\Neel Shettigar\Desktop\CP\Computer Programming 2\Card Images\cardimages\b.gif"
        arrDealerPics(dp).Image = Image.FromFile(path)
        arrDealerHand.addcard(FullDeck.arrcards(fc), dc)
        dbj += FullDeck.arrcards(fc).GetCardValue
        dc += 1
        dp += 1
        fc += 1
        'path = "\\kummer2\Student Work\Computer Programming 2\Card Images\cardimages\" & FullDeck.arrcards(fc).GetCardString & ".gif"
        path = "C:\Users\Neel Shettigar\Desktop\CP\Computer Programming 2\Card Images\cardimages\" & FullDeck.arrcards(fc).GetCardString & ".gif"
        arrDealerPics(dp).Image = Image.FromFile(path)
        arrDealerHand.addcard(FullDeck.arrcards(fc), dc)
        dbj += FullDeck.arrcards(fc).GetCardValue
        pc += 1
        pp += 1
        fc += 1
        'path = "\\kummer2\Student Work\Computer Programming 2\Card Images\cardimages\" & FullDeck.arrcards(fc).GetCardString & ".gif"
        path = "C:\Users\Neel Shettigar\Desktop\CP\Computer Programming 2\Card Images\cardimages\" & FullDeck.arrcards(fc).GetCardString & ".gif"
        arrPlayerPics(pp).Image = Image.FromFile(path)
        arrPlayerHand.addcard(FullDeck.arrcards(fc), pc)
        pbj += FullDeck.arrcards(fc).GetCardValue
        pc += 1
        pp += 1
        fc += 1
        gbPlayer.Text = Initials & " BJ Score: " & pbj
        'path = "\\kummer2\Student Work\Computer Programming 2\Card Images\cardimages\" & FullDeck.arrcards(fc).GetCardString & ".gif"
        path = "C:\Users\Neel Shettigar\Desktop\CP\Computer Programming 2\Card Images\cardimages\" & FullDeck.arrcards(fc).GetCardString & ".gif"
        arrPlayerPics(pp).Image = Image.FromFile(path)
        arrPlayerHand.addcard(FullDeck.arrcards(fc), pc)
        pbj += FullDeck.arrcards(fc).GetCardValue
        gbPlayer.Text = Initials & " BJ Score: " & pbj
        pp += 1
        fc += 1
        pc += 1
        gbPlayer.Text = Initials & " BJ Score: " & pbj
        If pbj = 21 Then
            MsgBox("You Win!")
            totalpoints += (betpoints * 2)
            lblPoints.Text = totalpoints
            arrplayers(playercount).score = totalpoints
        End If
        split = False
        If (Mid(arrPlayerHand.arrcard(1).GetCardString, 1, 1) = Mid(arrPlayerHand.arrcard(2).GetCardString, 1, 1)) And betpoints <= totalpoints Then
            Dim splitcheck = MsgBox("Do you want to split?", MsgBoxStyle.YesNo, "Split")
            If splitcheck = MsgBoxResult.Yes Then
                totalpoints -= betpoints
                arrplayers(playercount).score = totalpoints
                split = True
                arrPlayerHand.create()
                arrPlayerHand.split()
                arrPlayerHand.addcard(FullDeck.arrcards(3), 1)
                arrPlayerHand.addcardsplit((FullDeck.arrcards(4)), 1)
                arrPlayerHand.addcard(FullDeck.arrcards(5), 2)
                arrPlayerHand.addcardsplit((FullDeck.arrcards(6)), 2)
                path = "C:\Users\Neel Shettigar\Desktop\CP\Computer Programming 2\Card Images\cardimages\" & FullDeck.arrcards(3).GetCardString & ".gif"
                arrPlayerPics(1).Image = Image.FromFile(path)
                path = "C:\Users\Neel Shettigar\Desktop\CP\Computer Programming 2\Card Images\cardimages\" & FullDeck.arrcards(5).GetCardString & ".gif"
                arrPlayerPics(2).Image = Image.FromFile(path)
                path = "C:\Users\Neel Shettigar\Desktop\CP\Computer Programming 2\Card Images\cardimages\" & FullDeck.arrcards(4).GetCardString & ".gif"
                arrPlayerSplitPics(1).Image = Image.FromFile(path)
                path = "C:\Users\Neel Shettigar\Desktop\CP\Computer Programming 2\Card Images\cardimages\" & FullDeck.arrcards(6).GetCardString & ".gif"
                arrPlayerSplitPics(2).Image = Image.FromFile(path)
                pc = 3
                pcs = 3
                pp = 3
                pps = 3
                pbj = (arrPlayerHand.arrcard(1).GetCardValue + arrPlayerHand.arrcard(2).GetCardValue)
                pbjs = (arrPlayerHand.arrcard2(1).GetCardValue + arrPlayerHand.arrcard2(2).GetCardValue)
                gbPlayer.Text = Initials & " BJ Score: " & pbj
                gbPlayerSplit.Text = Initials & " BJ Score: " & pbjs
            End If
        End If
        DD = False
        If pbj <= 11 And (betpoints) <= totalpoints Then
            Dim check = MsgBox("Do you want to Double Down?", MsgBoxStyle.YesNo, "Double Down")
            If check = MsgBoxResult.Yes Then
                totalpoints -= betpoints
                betpoints *= 2
                lblPoints.Text = totalpoints
                arrplayers(playercount).score = totalpoints
                DD = True
            End If
        End If
        If arrDealerHand.arrcard(2).GetCardValue = 11 Then
            Dim insurance = MsgBox("Do you want to bet insurance?", MsgBoxStyle.YesNo, "Insurance")
            If insurance = MsgBoxResult.Yes Then
                Do
                    insurancecheck = True
                    insurancepoints = InputBox("Enter amount", "Insurance Bet")
                    If insurancepoints > totalpoints Then
                        insurancecheck = False
                        MsgBox("Not enough Points!")
                    End If
                Loop Until insurancecheck = True
                totalpoints -= insurancepoints
                lblPoints.Text = totalpoints
                arrplayers(playercount).score = totalpoints
            End If
        End If
        SplitDone = False
        SplitTurn = False
    End Sub
    Dim Initials As String
    Dim playercount As Integer
    Dim insurancecheck As Boolean
    Dim insurancepoints As Integer
    Dim split As Boolean

    Private Sub frmBlackJack_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim path As String
        'path = "C:\Users\Neel Shettigar\Downloads\players.txt"
        path = "C:\Users\Neel Shettigar\Desktop\CP\19 S1 NS CP2\BlackJack\prjBlackJack\players.txt"
        'path = "C:\Users\neel.shettigar\Desktop\BlackJack\prjBlackJack\players.txt"
        FileOpen(1, path, OpenMode.Input)
        playercount = 0
        Dim playername As String
        Dim points As Integer
        Do While Not EOF(1)
            playercount += 1
            playername = LineInput(1)
            points = LineInput(1)
            arrplayers(playercount).name = playername
            arrplayers(playercount).score = points
        Loop
        Dim swapped As Boolean
        Dim gap As Integer = playercount
        Do
            gap = Int(gap / 1.3)
            If gap < 1 Then gap = 1
            swapped = False
            For x As Integer = 1 To playercount - gap
                If arrplayers(x).score < arrplayers(x + gap).score Then
                    Dim temp As player = arrplayers(x)
                    arrplayers(x) = arrplayers(x + gap)
                    arrplayers(x + gap) = temp
                    swapped = True
                End If
            Next
        Loop Until Not swapped And gap = 1
        For i As Integer = 1 To 10
            lstTopTen.Items.Add(i & ") " & arrplayers(i).name & " - " & arrplayers(i).score)
            lstTopTen.Items.Add("-----------------------------")
        Next
        FileClose(1)
    End Sub
    Dim arrplayers(1000) As player
    Dim arrTopTen(10) As player
    Structure player
        Dim score As Integer
        Dim name As String
    End Structure
    Private Sub CmdNew_Click(sender As Object, e As EventArgs) Handles cmdNew.Click
        Initials = ""
        Initials = InputBox("Enter your initials", "New Player", "AAA")
        playercount += 1
        arrplayers(playercount).name = Initials
        FullDeck.create()
        FullDeck.shuffle()
        SetControlArrays()
        arrDealerHand.create()
        arrPlayerHand.create()
        totalpoints = 1000
        lblPoints.Text = totalpoints
        arrplayers(playercount).score = totalpoints
        Dim pointscheck As Boolean
        picSplit.Visible = False
        Do
            pointscheck = True
            betpoints = InputBox("Enter Amount", "Bet Points", Str(Int(totalpoints / 2)))
            If betpoints > totalpoints Then
                pointscheck = False
                betpoints = 0
                MsgBox("Not Enough Points!")
            End If
        Loop Until pointscheck = True
        totalpoints -= betpoints
        lblPoints.Text = totalpoints
        arrplayers(playercount).score = totalpoints
        Dim path As String
        pbj = 0
        dbj = 0
        pp = 0
        dp = 0
        dc = 0
        pc = 0
        For i As Integer = 1 To 5
            arrPlayerPics(i).Image = Nothing
            arrDealerPics(i).Image = Nothing
            arrPlayerSplitPics(i).Image = Nothing
        Next
        gbDealer.Text = "Dealer BJ Score:"
        fc = 1
        dc += 1
        dp += 1
        'path = "\\kummer2\Student Work\Computer Programming 2\Card Images\cardimages\b.gif"
        path = "C:\Users\Neel Shettigar\Desktop\CP\Computer Programming 2\Card Images\cardimages\b.gif"
        arrDealerPics(dp).Image = Image.FromFile(path)
        arrDealerHand.addcard(FullDeck.arrcards(fc), dc)
        dbj += FullDeck.arrcards(fc).GetCardValue
        dc += 1
        dp += 1
        fc += 1
        'path = "\\kummer2\Student Work\Computer Programming 2\Card Images\cardimages\" & FullDeck.arrcards(fc).GetCardString & ".gif"
        path = "C:\Users\Neel Shettigar\Desktop\CP\Computer Programming 2\Card Images\cardimages\" & FullDeck.arrcards(fc).GetCardString & ".gif"
        arrDealerPics(dp).Image = Image.FromFile(path)
        arrDealerHand.addcard(FullDeck.arrcards(fc), dc)
        dbj += FullDeck.arrcards(fc).GetCardValue
        pc += 1
        pp += 1
        fc += 1
        'path = "\\kummer2\Student Work\Computer Programming 2\Card Images\cardimages\" & FullDeck.arrcards(fc).GetCardString & ".gif"
        path = "C:\Users\Neel Shettigar\Desktop\CP\Computer Programming 2\Card Images\cardimages\" & FullDeck.arrcards(fc).GetCardString & ".gif"
        arrPlayerPics(pp).Image = Image.FromFile(path)
        arrPlayerHand.addcard(FullDeck.arrcards(fc), pc)
        pbj += FullDeck.arrcards(fc).GetCardValue
        pc += 1
        pp += 1
        fc += 1
        gbPlayer.Text = Initials & " BJ Score: " & pbj
        'path = "\\kummer2\Student Work\Computer Programming 2\Card Images\cardimages\" & FullDeck.arrcards(fc).GetCardString & ".gif"
        path = "C:\Users\Neel Shettigar\Desktop\CP\Computer Programming 2\Card Images\cardimages\" & FullDeck.arrcards(fc).GetCardString & ".gif"
        arrPlayerPics(pp).Image = Image.FromFile(path)
        arrPlayerHand.addcard(FullDeck.arrcards(fc), pc)
        pbj += FullDeck.arrcards(fc).GetCardValue
        gbPlayer.Text = Initials & " BJ Score: " & pbj
        pp += 1
        fc += 1
        pc += 1
        gbPlayer.Text = Initials & " BJ Score: " & pbj
        If pbj = 21 Then
            MsgBox("You Win!")
            totalpoints += (betpoints * 2)
            lblPoints.Text = totalpoints
            arrplayers(playercount).score = totalpoints
        End If
        split = False
        If (Mid(arrPlayerHand.arrcard(1).GetCardString, 1, 1) = Mid(arrPlayerHand.arrcard(2).GetCardString, 1, 1)) And betpoints <= totalpoints Then
            Dim splitcheck = MsgBox("Do you want to split?", MsgBoxStyle.YesNo, "Split")
            If splitcheck = MsgBoxResult.Yes Then
                totalpoints -= betpoints
                arrplayers(playercount).score = totalpoints
                split = True
                arrPlayerHand.create()
                arrPlayerHand.split()
                arrPlayerHand.addcard(FullDeck.arrcards(3), 1)
                arrPlayerHand.addcardsplit(FullDeck.arrcards(4), 1)
                arrPlayerHand.addcard(FullDeck.arrcards(5), 2)
                arrPlayerHand.addcardsplit(FullDeck.arrcards(6), 1)
                pps = 3
                pcs = 3
                pc = 3
                pp = 3
                path = "C:\Users\Neel Shettigar\Desktop\CP\Computer Programming 2\Card Images\cardimages\" & FullDeck.arrcards(3).GetCardString & ".gif"
                arrPlayerPics(1).Image = Image.FromFile(path)
                path = "C:\Users\Neel Shettigar\Desktop\CP\Computer Programming 2\Card Images\cardimages\" & FullDeck.arrcards(5).GetCardString & ".gif"
                arrPlayerPics(2).Image = Image.FromFile(path)
                path = "C:\Users\Neel Shettigar\Desktop\CP\Computer Programming 2\Card Images\cardimages\" & FullDeck.arrcards(4).GetCardString & ".gif"
                arrPlayerSplitPics(1).Image = Image.FromFile(path)
                path = "C:\Users\Neel Shettigar\Desktop\CP\Computer Programming 2\Card Images\cardimages\" & FullDeck.arrcards(6).GetCardString & ".gif"
                arrPlayerSplitPics(2).Image = Image.FromFile(path)
            End If
        End If
        DD = False
        If pbj <= 11 And ((betpoints * 2) <= totalpoints) Then
            Dim check = MsgBox("Do you want to Double Down?", MsgBoxStyle.YesNo, "Double Down")
            If check = MsgBoxResult.Yes Then
                totalpoints -= betpoints
                betpoints *= 2
                lblPoints.Text = totalpoints
                arrplayers(playercount).score = totalpoints
                DD = True
            End If
        End If
        If arrDealerHand.arrcard(2).GetCardValue = 11 Then
            Dim insurance = MsgBox("Do you want to bet insurance?", MsgBoxStyle.YesNo, "Insurance")
            If insurance = MsgBoxResult.Yes Then
                Do
                    insurancecheck = True
                    insurancepoints = InputBox("Enter amount", "Insurance Bet")
                    If insurancepoints > totalpoints Then
                        insurancecheck = False
                        MsgBox("Not enough Points!")
                    End If
                Loop Until insurancecheck = True
                totalpoints -= insurancepoints
                lblPoints.Text = totalpoints
                arrplayers(playercount).score = totalpoints
            End If
        End If
        SplitDone = False
        SplitTurn = False
    End Sub
    Dim arrDealerHand As bjhand
    Dim arrPlayerHand As bjhand
    Dim DD As Boolean
    Dim SplitTurn As Boolean
    Private Sub CmdHit_Click(sender As Object, e As EventArgs) Handles cmdHit.Click
        Dim path As String
        If SplitTurn = True Then
            picSplit.Visible = True
            arrPlayerHand.addcardsplit(FullDeck.arrcards(fc), pcs)
            'path = "\\kummer2\Student Work\Computer Programming 2\Card Images\cardimages\" & FullDeck.arrcards(fc).GetCardString & ".gif"
            path = "C:\Users\Neel Shettigar\Desktop\CP\Computer Programming 2\Card Images\cardimages\" & FullDeck.arrcards(fc).GetCardString & ".gif"
            arrPlayerSplitPics(pps).Image = Image.FromFile(path)
            'pbj = 0
            'For i As Integer = 1 To pc
            '    pbj += arrPlayerHand.GetCardValue(i)
            'Next
            If DD = True Then
                pbjs += arrPlayerHand.arrcard(pcs).GetCardValue
                gbPlayerSplit.Text = Initials & " BJ Score: " & Str(pbjs)
                If pbjs = 21 Then
                    MsgBox("You Win!")
                    totalpoints += (betpoints * 2)
                    lblPoints.Text = totalpoints
                    arrplayers(playercount).score = totalpoints
                Else
                    If split = True Then
                        SplitTurn = True
                    Else
                        Call CmdStand_Click(Nothing, Nothing)
                    End If
                End If
            Else
                If (pbjs + arrPlayerHand.arrcard2(pcs).GetCardValue) > 21 And (arrPlayerHand.arrcard2(pcs).GetCardString) = "a" Then
                    pbjs += 1
                Else
                    If pbjs + arrPlayerHand.arrcard2(pcs).GetCardValue > 21 Then
                        pbjs = 0
                        For i As Integer = 1 To pcs
                            If arrPlayerHand.arrcard2(i).v = 1 Then
                                Dim check = MsgBox("Change the ace to a 1?", MsgBoxStyle.YesNo, "Ace 1 or 11")
                                If check = MsgBoxResult.Yes Then
                                    pbjs += 1
                                Else
                                    pbjs += 11
                                End If
                            Else
                                pbjs += arrPlayerHand.arrcard2(i).GetCardValue
                            End If
                        Next
                    Else
                        pbjs += arrPlayerHand.arrcard2(pcs).GetCardValue
                    End If
                End If
            End If
            gbPlayerSplit.Text = Initials & " BJ Score: " & Str(pbjs)
            fc += 1
            pps += 1
            pcs += 1
            If pcs = 6 And pbjs < 21 Then
                MsgBox("You Win!")
                totalpoints += (betpoints * 2)
                lblPoints.Text = totalpoints
                arrplayers(playercount).score = totalpoints
                If split = True Then
                    SplitTurn = True
                End If
            End If
            If pbjs > 21 Then
                MsgBox("You Lose!")
                'path = "\\kummer2\Student Work\Computer Programming 2\Card Images\cardimages\" & arrDealerHand.arrcard(1).GetCardString & ".gif"
                path = "C:\Users\Neel Shettigar\Desktop\CP\Computer Programming 2\Card Images\cardimages\" & arrDealerHand.arrcard(1).GetCardString & ".gif"
                arrDealerPics(1).Image = Image.FromFile(path)
                dbj = (arrDealerHand.arrcard(1).GetCardValue) + (arrDealerHand.arrcard(2).GetCardValue)
                gbDealer.Text = "Dealer BJ Score: " & dbj
                If split = True Then
                    SplitTurn = True
                End If
            End If
            If pbjs = 21 Then
                MsgBox("You Win!")
                totalpoints += (betpoints * 2)
                lblPoints.Text = totalpoints
                arrplayers(playercount).score = totalpoints
                If split = True Then
                    SplitTurn = True
                End If
            End If
            SplitDone = True
        Else
            arrPlayerHand.addcard(FullDeck.arrcards(fc), pc)
            'path = "\\kummer2\Student Work\Computer Programming 2\Card Images\cardimages\" & FullDeck.arrcards(fc).GetCardString & ".gif"
            path = "C:\Users\Neel Shettigar\Desktop\CP\Computer Programming 2\Card Images\cardimages\" & FullDeck.arrcards(fc).GetCardString & ".gif"
            arrPlayerPics(pp).Image = Image.FromFile(path)
            'pbj = 0
            'For i As Integer = 1 To pc
            '    pbj += arrPlayerHand.GetCardValue(i)
            'Next
            If DD = True Then
                pbj += arrPlayerHand.arrcard(pc).GetCardValue
                gbPlayer.Text = Initials & " BJ Score: " & Str(pbj)
                If pbj = 21 Then
                    MsgBox("You Win!")
                    totalpoints += (betpoints * 2)
                    lblPoints.Text = totalpoints
                    arrplayers(playercount).score = totalpoints
                Else
                    If split = True Then
                        SplitTurn = True
                        picSplit.Visible = True
                    Else
                        Call CmdStand_Click(Nothing, Nothing)
                    End If
                End If
            Else
                If (pbj + arrPlayerHand.arrcard(pc).GetCardValue) > 21 And (arrPlayerHand.arrcard(pc).GetCardString) = "a" Then
                    pbj += 1
                Else
                    If pbj + arrPlayerHand.arrcard(pc).GetCardValue > 21 Then
                        pbj = 0
                        For i As Integer = 1 To pc
                            If arrPlayerHand.arrcard(i).v = 1 Then
                                Dim check = MsgBox("Change the ace to a 1?", MsgBoxStyle.YesNo, "Ace 1 or 11")
                                If check = MsgBoxResult.Yes Then
                                    pbj += 1
                                Else
                                    pbj += 11
                                End If
                            Else
                                pbj += arrPlayerHand.arrcard(i).GetCardValue
                            End If
                        Next
                    Else
                        pbj += arrPlayerHand.arrcard(pc).GetCardValue
                    End If
                End If
            End If
            gbPlayer.Text = Initials & " BJ Score: " & Str(pbj)
            fc += 1
            pp += 1
            pc += 1
            If pc = 6 And pbj < 21 Then
                MsgBox("You Win!")
                totalpoints += (betpoints * 2)
                lblPoints.Text = totalpoints
                arrplayers(playercount).score = totalpoints
                If split = True Then
                    SplitTurn = True
                    picSplit.Visible = True
                End If
            End If
            If pbj > 21 Then
                MsgBox("You Lose!")
                'path = "\\kummer2\Student Work\Computer Programming 2\Card Images\cardimages\" & arrDealerHand.arrcard(1).GetCardString & ".gif"
                path = "C:\Users\Neel Shettigar\Desktop\CP\Computer Programming 2\Card Images\cardimages\" & arrDealerHand.arrcard(1).GetCardString & ".gif"
                arrDealerPics(1).Image = Image.FromFile(path)
                dbj = (arrDealerHand.arrcard(1).GetCardValue) + (arrDealerHand.arrcard(2).GetCardValue)
                gbDealer.Text = "Dealer BJ Score: " & dbj
                If insurancecheck = True And dbj = 21 Then
                    totalpoints += insurancepoints * 2
                End If
                lblPoints.Text = totalpoints
                arrplayers(playercount).score = totalpoints
                If split = True Then
                    SplitTurn = True
                    picSplit.Visible = True
                End If
            End If
            If pbj = 21 Then
                MsgBox("You Win!")
                totalpoints += (betpoints * 2)
                lblPoints.Text = totalpoints
                arrplayers(playercount).score = totalpoints
                If split = True Then
                    SplitTurn = True
                    picSplit.Visible = True
                End If
            End If
        End If
    End Sub

    Private Sub frmBlackJack_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Dim path As String
        'path = "C:\Users\Neel Shettigar\Downloads\players.txt"
        path = "C:\Users\Neel Shettigar\Desktop\CP\19 S1 NS CP2\BlackJack\prjBlackJack\players.txt"
        'path = "C:\Users\neel.shettigar\Desktop\BlackJack\prjBlackJack\players.txt"
        System.IO.File.WriteAllText(path, "")
        FileOpen(1, path, OpenMode.Output)
        For i As Integer = 1 To playercount
            PrintLine(1, arrplayers(i).name)
            PrintLine(1, arrplayers(i).score)
        Next
        FileClose(1)
    End Sub

    Structure bjhand
        Dim arrcard() As card
        Dim arrcard2() As card
        Sub create()
            ReDim arrcard(5)
        End Sub
        Sub split()
            ReDim arrcard2(5)
        End Sub
        Sub addcard(cl As card, pos As Integer)
            arrcard(pos) = cl
        End Sub
        Sub addcardsplit(cl As card, pos As Integer)
            arrcard2(pos) = cl
        End Sub
        Function GetCardValue(d)
            Dim val As Integer
            Select Case arrcard(d).v
                Case 1
                    val = 11
                Case 10
                    val = 10
                Case 11
                    val = 10
                Case 12
                    val = 10
                Case 13
                    val = 10
                Case Else
                    val = arrcard(d).v
            End Select
            GetCardValue = val
        End Function
    End Structure

End Class
