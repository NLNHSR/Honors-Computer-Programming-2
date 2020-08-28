Imports System.ComponentModel

Public Class frmAnimatedGame

    Dim bsx(10) As Integer
    Dim bsy(10) As Integer
    Dim esx As Integer
    Dim esy As Integer
    Dim Asteroids(10) As PictureBox
    Dim Bullets(10) As PictureBox
    Dim BBullets(10) As PictureBox
    Dim TopTen(10) As Label
    Dim OX(10) As Integer
    Dim OY(10) As Integer
    Dim Left As Boolean, Right As Boolean, Down As Boolean, Up As Boolean
    Sub SetControlArrays()

        Asteroids(1) = picA1
        Asteroids(2) = picA2
        Asteroids(3) = picA3
        Asteroids(4) = picA4
        Asteroids(5) = picA5
        Asteroids(6) = picA6
        Asteroids(7) = picA7
        Asteroids(8) = picA8
        Asteroids(9) = picA9
        Asteroids(10) = picA10

        Bullets(1) = picB1
        Bullets(2) = picB2
        Bullets(3) = picB3
        Bullets(4) = picB4
        Bullets(5) = picB5
        Bullets(6) = picB6
        Bullets(7) = picB7
        Bullets(8) = picB8
        Bullets(9) = picB9
        Bullets(10) = picB10

        BBullets(1) = picBB1
        BBullets(2) = picBB2
        BBullets(3) = picBB3
        BBullets(4) = picBB4
        BBullets(5) = picBB5
        BBullets(6) = picBB6
        BBullets(7) = picBB7
        BBullets(8) = picBB8
        BBullets(9) = picBB9
        BBullets(10) = picBB10

        TopTen(1) = lblS1
        TopTen(2) = lblS2
        TopTen(3) = lblS3
        TopTen(4) = lblS4
        TopTen(5) = lblS5
        TopTen(6) = lblS6
        TopTen(7) = lblS7
        TopTen(8) = lblS8
        TopTen(9) = lblS9
        TopTen(10) = lblS10

    End Sub
    Private Sub tmrSpace_Tick(sender As Object, e As EventArgs) Handles tmrSpace.Tick

        If picSpace.Left + 1 > 1000 Then
            picSpace.Left = -1000
        Else
            picSpace.Left = picSpace.Left + 1
        End If

        If picSpace2.Left + 1 > 1000 Then
            picSpace2.Left = -1000
        Else
            picSpace2.Left = picSpace2.Left + 1
        End If
        If Left = True Then
            picShip.Left = picShip.Left - 2
        ElseIf Right = True Then
            picShip.Left = picShip.Left + 2
        End If

        If Down = True Then
            picShip.Top = picShip.Top - 2
        ElseIf Up = True Then
            picShip.Top = picShip.Top + 2
        End If

    End Sub

    Dim ExpCheck As Boolean = False
    Dim BlownUp As Boolean = False
    Private Sub tmrCollision_Tick(sender As Object, e As EventArgs) Handles tmrCollision.Tick

        'Check if asteroid is in zone around the ship
        For i As Integer = 1 To 10
            If (Asteroids(i).Top >= picShip.Top - 35) And (Asteroids(i).Top <= picShip.Top + 40) And (Asteroids(i).Left >= picShip.Left - 35) And (Asteroids(i).Left <= picShip.Left + 30) Then
                If BlownUp = False Then
                    picShip.Visible = False
                    picExp1.Left = picShip.Left
                    picExp2.Left = picShip.Left
                    picExp3.Left = picShip.Left
                    picExp1.Top = picShip.Top
                    picExp2.Top = picShip.Top
                    picExp3.Top = picShip.Top
                    picExp1.Visible = True
                    ExpCheck = True
                    tmrExplosion.Enabled = True
                    BlownUp = True
                    lives -= 1
                    My.Computer.Audio.Play("D:\CP\HCP2\Projects\AnimatedGame\explosion.wav")
                    If lives = 2 Then
                        picL1.Visible = False
                    ElseIf lives = 1 Then
                        picL3.Visible = False
                    ElseIf lives = 0 Then
                        picL2.Visible = False
                    ElseIf lives = -1 Then
                        lblLose.Visible = True
                        tmrAsteroids.Enabled = False
                        tmrBBullets.Enabled = False
                        tmrBullets.Enabled = False
                        tmrCollision.Enabled = False
                        tmrExplosion.Enabled = False
                        tmrMultiplier.Enabled = False
                        gamestart = False
                    End If
                End If
            End If
        Next

        'Check if enemy bullet hit the top of the ship
        For i As Integer = 1 To 10
            If (BBullets(i).Left >= picShip.Left - 10) And (BBullets(i).Left <= picShip.Left + 40) And (BBullets(i).Top >= picShip.Top - 24) And (BBullets(i).Top <= picShip.Top + 64) Then
                If BlownUp = False Then
                    picShip.Visible = False
                    picExp1.Left = picShip.Left
                    picExp2.Left = picShip.Left
                    picExp3.Left = picShip.Left
                    picExp1.Top = picShip.Top
                    picExp2.Top = picShip.Top
                    picExp3.Top = picShip.Top
                    picExp1.Visible = True
                    ExpCheck = True
                    tmrExplosion.Enabled = True
                    BlownUp = True
                    lives -= 1
                    My.Computer.Audio.Play("D:\CP\HCP2\Projects\AnimatedGame\explosion.wav")
                    If lives = 2 Then
                        picL1.Visible = False
                    ElseIf lives = 1 Then
                        picL3.Visible = False
                    ElseIf lives = 0 Then
                        picL2.Visible = False
                    ElseIf lives = -1 Then
                        tmrAsteroids.Enabled = False
                        tmrBBullets.Enabled = False
                        tmrBullets.Enabled = False
                        tmrCollision.Enabled = False
                        tmrExplosion.Enabled = False
                        tmrMultiplier.Enabled = False
                        gamestart = False
                        lblLose.Visible = True
                    End If
                End If
            End If
        Next

        'Your bullet hits the enemy ship
        For i As Integer = 1 To 10
            If (Bullets(i).Left >= picBShip.Left - 10) And (Bullets(i).Left <= picBShip.Left + 40) And (Bullets(i).Top <= picBShip.Top + 40) And (Bullets(i).Top >= picBShip.Top - 24) Then
                If BlownUp = False Then
                    picBShip.Visible = False
                    picExp1.Left = picBShip.Left
                    picExp2.Left = picBShip.Left
                    picExp3.Left = picBShip.Left
                    picExp1.Top = picBShip.Top
                    picExp2.Top = picBShip.Top
                    picExp3.Top = picBShip.Top
                    picExp1.Visible = True
                    ExpCheck = True
                    tmrExplosion.Enabled = True
                    My.Computer.Audio.Play("D:\CP\HCP2\Projects\AnimatedGame\explosion.wav")
                    score += 500 * multiplier
                    lblScore.Text = score
                    picBShip.Left = 35
                    picBShip.Top = 40
                    Dim randomx As Integer
                    Dim randomy As Integer
                    randomx = Int(11 * Rnd() - 5)
                    If randomx = 0 Then
                        randomx = 1
                    Else
                        esx = randomx
                    End If
                    randomy = Int(11 * Rnd() - 5)
                    If randomy = 0 Then
                        randomy = 1
                    Else
                        esy = randomy
                    End If
                    picBShip.Visible = True
                End If
            End If
        Next

        'Ship goes outside of playing area
        If picShip.Top < 84 Then
            picShip.Top = 625
        ElseIf picShip.Top > 625 Then
            picShip.Top = 84
        End If
        If picShip.Left < 70 Then
            picShip.Left = 750
        ElseIf picShip.Left > 750 Then
            picShip.Left = 70
        End If

    End Sub

    Private Sub TmrExplosion_Tick(sender As Object, e As EventArgs) Handles tmrExplosion.Tick

        If ExpCheck = True Then
            If picExp1.Visible = True Then
                picExp1.Visible = False
                picExp2.Visible = True
            ElseIf picExp2.Visible = True Then
                picExp2.Visible = False
                picExp3.Visible = True
            ElseIf picExp3.Visible = True Then
                picExp3.Visible = False
                ExpCheck = False
                tmrExplosion.Enabled = False
            End If
        End If

    End Sub

    Dim BCount As Integer = 1
    Dim BBCount As Integer = 1
    Dim First As Boolean = True
    Dim BFirst As Boolean = True
    Dim Time1 As Double
    Dim Time2 As Double
    Dim BTime1 As Double
    Dim Btime2 As Double

    Private Sub frmAnimatedGame_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If gamestart = True Then
            Select Case e.KeyCode
                Case Keys.Left
                    picShip.Left = picShip.Left - 8
                    Left = True
                    Right = False
                Case Keys.Right
                    picShip.Left = picShip.Left + 8
                    Left = False
                    Right = True
                Case Keys.Down
                    picShip.Top = picShip.Top + 8
                    Up = True
                    Down = False
                Case Keys.Up
                    picShip.Top = picShip.Top - 8
                    Up = False
                    Down = True
                Case Keys.Enter
                    picShip.Visible = True
                    BlownUp = False
                    picShip.Left = 445
                    picShip.Top = 335
                Case Keys.Space
                    If First = True Then
                        Time1 = Now().Millisecond
                        First = False
                    ElseIf First = False Then
                        Time2 = Now().Millisecond
                        First = True
                    End If
                    If Math.Abs(Time2 - Time1) > 100 Then
                        BCount += 1
                        If BCount = 11 Then
                            BCount = 1
                            For i As Integer = 1 To 10
                                Bullets(i).Left = 1000
                            Next
                        End If
                        Bullets(BCount).Left = picShip.Left + 7
                        Bullets(BCount).Top = picShip.Top
                        My.Computer.Audio.Play("D:\CP\HCP2\Projects\AnimatedGame\laser.wav")
                    End If
            End Select
        End If

    End Sub

    Private Sub tmrMultiplier_Tick(sender As Object, e As EventArgs) Handles tmrMultiplier.Tick

        If multiplier <> 5 Then
            multiplier += 1
        End If

    End Sub

    Private Sub tmrBullets_Tick(sender As Object, e As EventArgs) Handles tmrBullets.Tick

        For i As Integer = 1 To BCount
            Bullets(i).Top -= 20
        Next

    End Sub

    Private Sub tmrBBullets_Tick(sender As Object, e As EventArgs) Handles tmrBBullets.Tick

        If BFirst = True Then
            BTime1 = Now().Millisecond
            BFirst = False
        ElseIf BFirst = False Then
            Btime2 = Now().Millisecond
            BFirst = True
        End If

        If Math.Abs(Btime2 - BTime1) > 250 / multiplier Then
            BBCount += 1
            If BBCount = 11 Then
                BBCount = 1
                For i As Integer = 1 To 10
                    BBullets(i).Left = 1000
                Next
            End If
            BBullets(BBCount).Left = picBShip.Left + 7
            BBullets(BBCount).Top = picBShip.Top

        End If

        For i As Integer = 1 To BBCount
            BBullets(i).Top += 20
        Next

    End Sub
    Dim playercount As Integer
    Dim lives As Integer
    Structure player
        Dim name As String
        Dim score As Integer
    End Structure
    Dim arrplayers(1) As player
    Dim arrTopTen(10) As player
    Dim gamestart As Boolean
    Dim initials As String
    Dim score As Integer
    Private Sub cmdNew_Click(sender As Object, e As EventArgs) Handles cmdNew.Click
        lblLose.Visible = False
        Dim randomx As Integer
        Dim randomy As Integer
        For i As Integer = 1 To 10
            Asteroids(i).Left = OX(i)
            Asteroids(i).Top = OY(i)
        Next
        initials = ""
        initials = InputBox("Enter your initials", "New Player", "AAA")
        playercount += 1
        ReDim Preserve arrplayers(playercount)
        arrplayers(playercount).name = initials
        score = 0
        lblScore.Text = score
        lblName.Text = initials
        lives = 3
        tmrAsteroids.Enabled = True
        tmrBBullets.Enabled = True
        tmrBullets.Enabled = True
        tmrCollision.Enabled = True
        tmrExplosion.Enabled = True
        tmrMultiplier.Enabled = True
        gamestart = True
        picL1.Visible = True
        picL2.Visible = True
        picL3.Visible = True
        picShip.Visible = True
        picShip.Left = 445
        picShip.Top = 335
        BlownUp = False
        For i As Integer = 1 To 10

            randomx = Int(11 * Rnd() - 5)
            If randomx = 0 Then
                randomx = 1
                bsx(i) = 1
            Else
                bsx(i) = randomx
                esx = randomx
            End If
            randomy = Int(11 * Rnd() - 5)
            If randomy = 0 Then
                randomy = 1
                bsy(i) = 1
            Else
                bsy(i) = randomy
                esy = randomy
            End If

        Next i
        picBShip.Left = 35
        picBShip.Top = 40
        Left = False
        Right = False
        Up = False
        Down = False
        multiplier = 1

    End Sub

    Private Sub tmrScore_Tick(sender As Object, e As EventArgs) Handles tmrScore.Tick

        If gamestart = True Then
            score += 1
            lblScore.Text = score
        End If
    End Sub

    Private Sub cmdRestart_Click(sender As Object, e As EventArgs) Handles cmdRestart.Click
        lblLose.Visible = False
        Dim randomx As Integer
        Dim randomy As Integer
        For i As Integer = 1 To 10
            Asteroids(i).Left = OX(i)
            Asteroids(i).Top = OY(i)
        Next

        score = 0
        lblScore.Text = score
        lblName.Text = initials
        lives = 3
        tmrAsteroids.Enabled = True
        tmrBBullets.Enabled = True
        tmrBullets.Enabled = True
        tmrCollision.Enabled = True
        tmrExplosion.Enabled = True
        tmrMultiplier.Enabled = True
        gamestart = True
        picL1.Visible = True
        picL2.Visible = True
        picL3.Visible = True
        picShip.Visible = True
        picShip.Left = 445
        picShip.Top = 335
        BlownUp = False
        For i As Integer = 1 To 10

            randomx = Int(11 * Rnd() - 5)
            If randomx = 0 Then
                randomx = 1
                bsx(i) = 1
            Else
                bsx(i) = randomx
                esx = randomx
            End If
            randomy = Int(11 * Rnd() - 5)
            If randomy = 0 Then
                randomy = 1
                bsy(i) = 1
            Else
                bsy(i) = randomy
                esy = randomy
            End If

        Next i
        picBShip.Left = 35
        picBShip.Top = 40
        Left = False
        Right = False
        Up = False
        Down = False
        multiplier = 1

    End Sub

    Private Sub frmAnimatedGame_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tmrAsteroids.Enabled = False
        tmrBBullets.Enabled = False
        tmrBullets.Enabled = False
        tmrCollision.Enabled = False
        tmrExplosion.Enabled = False
        tmrMultiplier.Enabled = False
        gamestart = False

        Dim randomx As Integer, randomy As Integer
        SetControlArrays()
        Randomize()
        For a As Integer = 1 To 10
            OX(a) = Asteroids(a).Left
            OY(a) = Asteroids(a).Top
        Next
        Dim path As String = "D:\CP\HCP2\Projects\AnimatedGame\Players.txt"
        FileOpen(1, path, OpenMode.Input)
        playercount = 0
        Dim playername As String
        Dim points As Integer

        Do While Not EOF(1)
            playercount += 1
            playername = LineInput(1)
            points = LineInput(1)
            ReDim Preserve arrplayers(playercount)
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
            TopTen(i).Text = "P\" & arrplayers(i).name & "_S:" & arrplayers(i).score
        Next
        FileClose(1)

        For i As Integer = 1 To 10

            randomx = Int(11 * Rnd() - 5)
            If randomx = 0 Then
                randomx = 1
                bsx(i) = 1
            Else
                bsx(i) = randomx
                esx = randomx
            End If
            randomy = Int(11 * Rnd() - 5)
            If randomy = 0 Then
                randomy = 1
                bsy(i) = 1
            Else
                bsy(i) = randomy
                esy = randomy
            End If

        Next i

        Left = False
        Right = False
        Up = False
        Down = False

    End Sub

    Private Sub tmrLose_Tick(sender As Object, e As EventArgs) Handles tmrLose.Tick

        If lblLose.ForeColor = Color.MediumAquamarine Then
            lblLose.ForeColor = Color.Black
        ElseIf lblLose.ForeColor = Color.Black Then
            lblLose.ForeColor = Color.MediumAquamarine
        End If

    End Sub

    Dim multiplier As Integer = 1

    Private Sub tmrAsteroids_Tick(sender As Object, e As EventArgs) Handles tmrAsteroids.Tick

        For i As Integer = 1 To 10
            Asteroids(i).Left = Asteroids(i).Left + bsx(i) * multiplier
            Asteroids(i).Top = Asteroids(i).Top + bsy(i) * multiplier
        Next i
        picBShip.Left = picBShip.Left + esx * multiplier
        picBShip.Top = picBShip.Top + esy * multiplier

        For i As Integer = 1 To 10

            If Asteroids(i).Left <= 0 Then

                If bsx(i) < 0 Then
                    bsx(i) = Math.Abs(bsx(i))
                ElseIf (i) > 0 Then
                    bsx(i) = -1 * bsx(i)
                End If

            ElseIf Asteroids(i).Left >= 815 Then

                If bsx(i) < 0 Then
                    bsx(i) = Math.Abs(bsx(i))
                ElseIf (i) > 0 Then
                    bsx(i) = -1 * bsx(i)
                End If

            End If

            If Asteroids(i).Top <= 0 Then

                If bsy(i) < 0 Then
                    bsy(i) = Math.Abs(bsy(i))
                ElseIf (i) > 0 Then
                    bsy(i) = -1 * bsy(i)
                End If
            ElseIf Asteroids(i).Top >= 700 Then

                If bsy(i) < 0 Then
                    bsy(i) = Math.Abs(bsy(i))
                ElseIf (i) > 0 Then
                    bsy(i) = -1 * bsy(i)
                End If

            End If
        Next

        If picBShip.Left <= 0 Then

            If esx < 0 Then
                esx = Math.Abs(esx)
            ElseIf esx > 0 Then
                esx = -1 * esx
            End If

        ElseIf picBShip.Left >= 815 Then

            If esx < 0 Then
                esx = Math.Abs(esx)
            ElseIf esx > 0 Then
                esx = -1 * esx
            End If

        End If

        If picBShip.Top <= 0 Then

            If esy < 0 Then
                esy = Math.Abs(esy)
            ElseIf esy > 0 Then
                esy = -1 * esy
            End If
        ElseIf picBShip.Top >= 700 Then

            If esy < 0 Then
                esy = Math.Abs(esy)
            ElseIf esy > 0 Then
                esy = -1 * esy
            End If

        End If

    End Sub

    Private Sub frmAnimatedGame_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        arrplayers(playercount).score = score
        Dim path As String = "D:\CP\HCP2\Projects\AnimatedGame\Players.txt"
        System.IO.File.WriteAllText(path, "")
        FileOpen(1, path, OpenMode.Output)

        For i As Integer = 1 To playercount
            PrintLine(1, arrplayers(i).name)
            PrintLine(1, arrplayers(i).score)
        Next i

    End Sub
End Class
