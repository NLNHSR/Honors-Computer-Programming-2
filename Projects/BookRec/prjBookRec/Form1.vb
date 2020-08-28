Imports System.ComponentModel
Public Class frmBookRec
    Dim counter As Integer
    Dim TotalReaders As Integer
    Structure Reader
        Dim Name As String
        Dim arrRatings() As Integer
    End Structure
    Structure Readerlist
        Dim arrReaders() As Reader
        Dim NumNew As Integer
        Sub Create()
            frmBookRec.counter = 0
            Dim path As String = "D:\CP\HCP2\Projects\BookRec\readerratings.txt"
            FileOpen(2, path, OpenMode.Input)
            Do While Not EOF(2)
                Dim test As String = LineInput(2)
                frmBookRec.counter = frmBookRec.counter + 1
            Loop
            frmBookRec.counter = frmBookRec.counter / 2
            FileClose(2)
            Dim i As Integer = 1
            FileOpen(2, path, OpenMode.Input)
            ReDim arrReaders(frmBookRec.counter)
            Do While Not EOF(2)
                ReDim arrReaders(i).arrRatings(55)
                Dim Name As String = LineInput(2)
                arrReaders(i).Name = Name
                Dim arrSplit() As String
                Dim strline As String = LineInput(2)
                arrSplit = strline.Split("  ")
                For x As Integer = 1 To 55
                    arrReaders(i).arrRatings(x) = Val(arrSplit(x - 1))
                Next
                i += 1
            Loop
            FileClose(2)
            NumNew = 0
        End Sub
        Sub Add(Name As String)
            NumNew = NumNew + 1
            ReDim Preserve arrReaders(86 + NumNew)
            arrReaders(86 + NumNew).Name = Name
            frmBookRec.TotalReaders = 86 + NumNew
        End Sub
    End Structure
    Structure Book
        Dim Title As String, Author As String
    End Structure
    Structure Booklist
        Dim arrBooks() As Book
        Sub Create()
            ReDim arrBooks(55)
            Dim path As String = "D:\CP\HCP2\Projects\BookRec\books.txt"
            FileOpen(1, path, OpenMode.Input)
            Dim i As Integer = 1
            Do While Not EOF(1)
                Dim strline As String = LineInput(1)
                Dim midcheck As Boolean = False
                Dim position As Integer
                Dim x As Integer = 1
                Do While midcheck = False
                    If Mid(strline, x, 1) = "," Then
                        position = x
                        midcheck = True
                    End If
                    x = x + 1
                Loop
                arrBooks(i).Author = (Mid(strline, 1, position - 1))
                arrBooks(i).Title = (Mid(strline, position + 1, (Len(strline) - position)))
                i += 1
            Loop
            FileClose(1)
        End Sub
    End Structure
    Dim Books As Booklist
    Dim Readers As Readerlist
    Dim arrButtons(6) As RadioButton
    Sub SetControlArrays()
        arrButtons(1) = RBn5
        arrButtons(2) = RBn3
        arrButtons(3) = RB0
        arrButtons(4) = RB1
        arrButtons(5) = RB3
        arrButtons(6) = RB5
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Readers.Create()
        Books.Create()
        SetControlArrays()
        ReaderPos = 0
        BookPos = 0
        For i = 1 To counter
            lstReaders.Items.Add(Readers.arrReaders(i).Name)
        Next
        TotalReaders = counter
    End Sub
    Structure BookRec
        Dim arrSimilarityScore() As Integer
        Dim arrAverageScore() As Integer
        Dim arrMax() As Integer
        Dim arrpos() As Integer
        Sub MethodA()
            ReDim arrMax(55)
            ReDim arrpos(55)
            Dim sum As Integer = 0
            Dim temp As Integer
            Dim temp2 As Integer
            For i = 1 To 55
                If frmBookRec.Readers.arrReaders(frmBookRec.ReaderPos).arrRatings(i) = 0 Then
                    sum = 0
                    For x As Integer = 1 To frmBookRec.TotalReaders
                        sum += frmBookRec.Readers.arrReaders(x).arrRatings(i)
                    Next
                    sum = sum / frmBookRec.TotalReaders
                    arrMax(i) = sum
                    arrpos(i) = i
                End If
            Next
            For x = 1 To 55
                For y = 2 To 55
                    If arrMax(x) > arrMax(y) Then
                        temp = arrMax(y)
                        temp2 = arrpos(y)
                        arrMax(y) = arrMax(x)
                        arrpos(y) = arrpos(x)
                        arrMax(x) = temp
                        arrpos(x) = temp
                    End If
                Next y
            Next x
            For i = 2 To 6
                frmBookRec.txtRec.Text = frmBookRec.Books.arrBooks(arrpos(i)).Title
                frmBookRec.lstBooks.Items.Add(frmBookRec.Books.arrBooks(arrpos(i)).Title)
            Next
        End Sub
        Sub MethodB()
            ReDim arrSimilarityScore(frmBookRec.TotalReaders)
            For i As Integer = 1 To frmBookRec.TotalReaders
                If i <> frmBookRec.ReaderPos Then
                    Dim SScore As Integer = 0
                    For x As Integer = 1 To 55
                        If frmBookRec.Readers.arrReaders(frmBookRec.ReaderPos).arrRatings(x) <> 6 Then
                            SScore = SScore + (frmBookRec.Readers.arrReaders(i).arrRatings(x) * frmBookRec.Readers.arrReaders(frmBookRec.ReaderPos).arrRatings(x))
                        End If
                    Next
                    arrSimilarityScore(i) = SScore
                End If
            Next
            Dim maxpos As Integer = 0
            Dim max As Integer = -1375
            For i = 1 To frmBookRec.TotalReaders
                If arrSimilarityScore(i) > max Then
                    max = arrSimilarityScore(i)
                    maxpos = i
                End If
            Next
            MsgBox("Highest Similarity Score Was: " & max)
            Dim OutputString As String = ""
            MsgBox("Most Similar Reader Was: " & frmBookRec.Readers.arrReaders(maxpos).Name)
            For x = 1 To 55
                If frmBookRec.Readers.arrReaders((frmBookRec.ReaderPos)).arrRatings(x) = 0 Then
                    If frmBookRec.Readers.arrReaders(maxpos).arrRatings(x) >= 3 Then
                        OutputString = OutputString & frmBookRec.Books.arrBooks(x).Title & "," & frmBookRec.Books.arrBooks(x).Author & "   "
                        frmBookRec.lstBooks.Items.Add(frmBookRec.Books.arrBooks(x).Title)
                    End If
                End If
            Next
            frmBookRec.txtRec.Text = OutputString
        End Sub
        Sub MethodC()
            ReDim arrSimilarityScore(frmBookRec.TotalReaders)
            For i As Integer = 1 To frmBookRec.TotalReaders
                If i <> frmBookRec.ReaderPos Then
                    Dim SScore As Integer = 0
                    For x As Integer = 1 To 55
                        If frmBookRec.Readers.arrReaders(frmBookRec.ReaderPos).arrRatings(x) <> 6 Then
                            SScore = SScore + (frmBookRec.Readers.arrReaders(i).arrRatings(x) * frmBookRec.Readers.arrReaders(frmBookRec.ReaderPos).arrRatings(x))
                        End If
                    Next
                    arrSimilarityScore(i) = SScore
                End If
            Next
            ReDim arrAverageScore(55)
            Dim max As Integer = 0
            Dim maxpos As Integer = 0
            Dim OutputString As String = ""
            For i As Integer = 1 To 55
                Dim AScore As Integer = 0
                For x As Integer = 1 To frmBookRec.TotalReaders
                    AScore = AScore + (frmBookRec.Readers.arrReaders(x).arrRatings(i) * arrSimilarityScore(x))
                Next
                arrAverageScore(i) = AScore
            Next
            For i = 1 To 55
                If arrAverageScore(i) > max And frmBookRec.Readers.arrReaders(frmBookRec.ReaderPos).arrRatings(i) = 0 Then
                    max = arrAverageScore(i)
                    maxpos = i
                End If
            Next
            OutputString = frmBookRec.Books.arrBooks(maxpos).Title & "," & frmBookRec.Books.arrBooks(maxpos).Author & " "
            frmBookRec.txtRec.Text = OutputString
            frmBookRec.lstBooks.Items.Add(frmBookRec.Books.arrBooks(maxpos).Title)
        End Sub
    End Structure
    Dim Recommendations As BookRec
    Private Sub lstReaders_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstReaders.SelectedIndexChanged
        ReaderPos = lstReaders.SelectedIndex + 1
        lblReader.Text = Readers.arrReaders(ReaderPos).Name
    End Sub
    Dim ReaderPos As Integer
    Dim BookPos As Integer
    Private Sub cmbEdit_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbEdit.SelectedIndexChanged
        If cmbEdit.SelectedIndex = 0 Then 'Add
            Dim name As String = InputBox("Enter Your Name:", "New Reader")
            Readers.Add(name)
            lstReaders.Items.Clear()
            For i = 1 To (Readers.arrReaders.Length) - 1
                lstReaders.Items.Add(Readers.arrReaders(i).Name)
            Next
            ReaderPos = Readers.arrReaders.Length - 1
            lblReader.Text = Readers.arrReaders(ReaderPos).Name
            BookPos = 0
            lblAuthor.Text = Books.arrBooks(BookPos + 1).Author
            lblTitle.Text = Books.arrBooks(BookPos + 1).Title
            ReDim Readers.arrReaders(ReaderPos).arrRatings(55)
        ElseIf cmbEdit.SelectedIndex = 1 Then 'Change
            ReaderPos = lstReaders.SelectedIndex + 1
            lblReader.Text = Readers.arrReaders(ReaderPos).Name
            lblAuthor.Text = Books.arrBooks(1).Author
            lblTitle.Text = Books.arrBooks(1).Title
            Dim Rating As Integer = Readers.arrReaders(ReaderPos).arrRatings(1)
            If Rating = -5 Then
                arrButtons(1).Checked = True
            ElseIf Rating = -3 Then
                arrButtons(2).Checked = True
            ElseIf Rating = 0 Then
                arrButtons(3).Checked = True
            ElseIf Rating = 1 Then
                arrButtons(4).Checked = True
            ElseIf Rating = 3 Then
                arrButtons(5).Checked = True
            ElseIf Rating = 5 Then
                arrButtons(6).Checked = True
            End If
            BookPos = 1
        ElseIf cmbEdit.SelectedIndex = 2 Then 'Delete
            TotalReaders = TotalReaders - 1
            For i = ReaderPos To TotalReaders
                Readers.arrReaders(i).Name = Readers.arrReaders(i + 1).Name
                Readers.arrReaders(i).arrRatings = Readers.arrReaders(i + 1).arrRatings
            Next
            ReDim Preserve Readers.arrReaders(TotalReaders)
            lstReaders.Items.Clear()
            For i = 1 To TotalReaders
                lstReaders.Items.Add(Readers.arrReaders(i).Name)
            Next
        End If
    End Sub

    Private Sub cmdNext_Click(sender As Object, e As EventArgs) Handles cmdNext.Click
        If BookPos + 1 >= 56 Then
            MsgBox("You've Rated All The Books!")
        Else
            BookPos = BookPos + 1
        End If
        lblTitle.Text = Books.arrBooks(BookPos).Title
        lblAuthor.Text = Books.arrBooks(BookPos).Author
        Dim Checked As Boolean = False
        Dim i As Integer = 1
        Dim ButtonPos As Integer
        Do Until Checked = True
            If arrButtons(i).Checked = True Then
                Checked = True
                ButtonPos = i
            End If
            i = i + 1
        Loop
        Readers.arrReaders(ReaderPos).arrRatings(BookPos) = Val(arrButtons(ButtonPos).Text)
    End Sub

    Private Sub CmbMethods_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbMethods.SelectedIndexChanged
        If cmbMethods.SelectedIndex = 0 Then 'Method A
            lstBooks.Items.Clear()
            Recommendations.MethodA()
        ElseIf cmbMethods.SelectedIndex = 1 Then 'Method B
            lstBooks.Items.Clear()
            Recommendations.MethodB()
        ElseIf cmbMethods.SelectedIndex = 2 Then 'Method C
            lstBooks.Items.Clear()
            Recommendations.MethodC()
        End If
    End Sub

    Private Sub cmdDone_Click(sender As Object, e As EventArgs) Handles cmdDone.Click
        For i As Integer = BookPos + 1 To 55
            Readers.arrReaders(ReaderPos).arrRatings(i) = 6
        Next
    End Sub

    Private Sub lstBooks_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstBooks.SelectedIndexChanged
        Dim title As String = lstBooks.SelectedItem
        Dim path As String = "D:\CP\HCP2\Projects\BookRec\images\" & title & ".jpg"
        picBookCover.Image = Image.FromFile(path)
    End Sub
    Private Sub frmBookRec_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Dim path As String = "D:\CP\HCP2\Projects\BookRec\readerratings.txt"
        System.IO.File.WriteAllText(path, "")
        FileOpen(1, path, OpenMode.Output)
        For i As Integer = 1 To TotalReaders
            PrintLine(1, Readers.arrReaders(i).Name)
            Dim strout As String = ""
            For x As Integer = 1 To 55
                strout = strout & Trim(Str(Readers.arrReaders(i).arrRatings(x))) & " "
            Next x
            PrintLine(1, strout)
        Next i
    End Sub
End Class
