VERSION 5.00
Begin VB.Form frmSortSearch 
   BackColor       =   &H00800000&
   Caption         =   "Sort & Search"
   ClientHeight    =   5580
   ClientLeft      =   225
   ClientTop       =   870
   ClientWidth     =   6705
   LinkTopic       =   "Form1"
   ScaleHeight     =   5580
   ScaleWidth      =   6705
   StartUpPosition =   3  'Windows Default
   Begin VB.OptionButton optId 
      BackColor       =   &H00800000&
      Caption         =   "ID"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   9.75
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H00FFFFFF&
      Height          =   255
      Left            =   180
      TabIndex        =   9
      Top             =   4860
      Width           =   1755
   End
   Begin VB.OptionButton optName 
      BackColor       =   &H00800000&
      Caption         =   "Name"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   9.75
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H00FFFFFF&
      Height          =   255
      Left            =   180
      TabIndex        =   8
      Top             =   5200
      Width           =   1755
   End
   Begin VB.ListBox lstSearched 
      Height          =   5130
      Left            =   4080
      TabIndex        =   6
      Top             =   360
      Width           =   2475
   End
   Begin VB.ListBox lstSorted 
      Height          =   4350
      Left            =   2160
      TabIndex        =   2
      Top             =   360
      Width           =   1755
   End
   Begin VB.ListBox lstRandom 
      Appearance      =   0  'Flat
      Height          =   4125
      Left            =   180
      TabIndex        =   0
      Top             =   360
      Width           =   1755
   End
   Begin VB.Label Label1 
      Alignment       =   2  'Center
      BackColor       =   &H8000000E&
      BorderStyle     =   1  'Fixed Single
      Caption         =   "Sort By:"
      Height          =   255
      Left            =   180
      TabIndex        =   10
      Top             =   4560
      Width           =   1755
   End
   Begin VB.Label Label 
      Alignment       =   2  'Center
      BackColor       =   &H8000000E&
      BorderStyle     =   1  'Fixed Single
      Caption         =   "Searched "
      Height          =   255
      Index           =   3
      Left            =   4080
      TabIndex        =   7
      Top             =   60
      Width           =   2475
   End
   Begin VB.Label lblTime 
      Alignment       =   2  'Center
      BackColor       =   &H8000000E&
      BorderStyle     =   1  'Fixed Single
      Height          =   315
      Left            =   2160
      TabIndex        =   5
      Top             =   5160
      Width           =   1755
   End
   Begin VB.Label Label5 
      Alignment       =   2  'Center
      BackColor       =   &H8000000E&
      BorderStyle     =   1  'Fixed Single
      Caption         =   "Time:"
      Height          =   255
      Left            =   2160
      TabIndex        =   4
      Top             =   4860
      Width           =   1755
   End
   Begin VB.Label Label2 
      Alignment       =   2  'Center
      BackColor       =   &H8000000E&
      BorderStyle     =   1  'Fixed Single
      Caption         =   "Sorted Array "
      Height          =   255
      Left            =   2160
      TabIndex        =   3
      Top             =   60
      Width           =   1755
   End
   Begin VB.Label Label 
      Alignment       =   2  'Center
      BackColor       =   &H8000000E&
      BorderStyle     =   1  'Fixed Single
      Caption         =   "Random Array"
      Height          =   255
      Index           =   0
      Left            =   180
      TabIndex        =   1
      Top             =   60
      Width           =   1755
   End
   Begin VB.Menu mnuGenerate 
      Caption         =   "Generate"
      Begin VB.Menu mnuWords 
         Caption         =   "Words"
      End
      Begin VB.Menu mnuNumbers 
         Caption         =   "Numbers"
      End
      Begin VB.Menu mnuEmployee 
         Caption         =   "Employee"
      End
   End
   Begin VB.Menu mnuSort 
      Caption         =   "Sort"
      Begin VB.Menu mnuExchange 
         Caption         =   "Exchange"
      End
      Begin VB.Menu mnuBubble 
         Caption         =   "Bubble"
      End
      Begin VB.Menu mnuComb 
         Caption         =   "Comb"
      End
   End
   Begin VB.Menu mnuSearch 
      Caption         =   "Search"
      Begin VB.Menu mnuBinary 
         Caption         =   "Binary Search"
      End
      Begin VB.Menu mnuUnique 
         Caption         =   "Uniqueness"
      End
   End
   Begin VB.Menu mnuShuffle 
      Caption         =   "Shuffle"
   End
End
Attribute VB_Name = "frmSortSearch"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit
'B: Sort array of 5000 rand nums and words from 1-5000 through Exchange, Bubble and Comb sort and find time it takes for each to sort, Binary search for num/word and its pos
'A: UDT, Uniqueness, Shuffle
Dim arrNums(5000) As Integer
Dim arrsort(5000) As Integer
Dim arrsorts(5000) As String
Dim arrShuffle(5000) As Integer
Dim arrTallies(5000) As Integer
Dim arrTalliess(5000) As String
Dim arrUnique(5000) As Integer
Dim arrUniques(5000) As String
Dim arrWords(5000) As String
Dim arrDictionary(58112) As String
Dim arrNames(4945) As String
Dim i As Single
Dim x As Integer
Dim y As Integer
Dim temp As Integer
Dim temps As String
Dim gap As Integer
Dim s As Double
Dim f As Double
Dim swapped As Boolean
Dim searchnum As Integer
Dim high As Integer
Dim low As Integer
Dim pos As Integer
Dim mid As Integer
Dim check As Integer
Dim searched As Boolean
Dim rand As Single
Dim rand2 As Integer
Dim path As String
Dim strline As String
Dim test As Integer
Dim Words As Boolean
Dim Nums As Boolean
Dim FName As Boolean
Dim ID As Boolean
Dim Employees As Boolean
Dim searchword As String
Dim present As Boolean

Private Sub mnuBinary_Click()

If Nums = True Then
    searchnum = InputBox("What number do you want to find?", "Binary Search")
ElseIf Words = True Then
    searchword = InputBox("What word do you want to find?", "Binary Search")
ElseIf Employees = True Then
    If ID = True Then
        searchnum = InputBox("What ID do you want to find?", "Binary Search")
    ElseIf FName = True Then
        searchword = InputBox("What First name do you want to find?", "Binary Search")
    End If
End If
If lblTime.Caption = "" Then
    Call mnuComb_Click
End If
pos = 0
low = 1
high = 5000
If Employees = False Then
Do While low <= high
    mid = Int((low + high) / 2)
    If Nums = True Then
        If searchnum < arrsort(mid) Then
            high = mid - 1
        ElseIf searchnum > arrsort(mid) Then
            low = mid + 1
        Else
            pos = mid
            Exit Do
        End If
    ElseIf Words = True Then
        If StrComp(searchword, (arrsorts(mid))) = -1 Then
            high = mid - 1
        ElseIf StrComp(searchword, (arrsorts(mid))) = 1 Then
            low = mid + 1
        Else
            pos = mid
            Exit Do
        End If
    End If
Loop
End If
check = 1
If pos <> 0 Then
    If Nums = True Then
        lstSearched.AddItem (searchnum & " exists at pos: " & pos)
    ElseIf Words = True Then
        lstSearched.AddItem (searchword & " exists at pos: " & pos)
    End If
    Do
        searched = False
        If Nums = True Then
            If arrsort(pos - check) = searchnum Then
                lstSearched.AddItem (searchnum & " exists at pos: " & (pos - check))
                searched = True
            End If
            If pos <> 5000 Then
                If arrsort(pos + check) = searchnum Then
                    lstSearched.AddItem (searchnum & " exists at pos: " & (pos + check))
                    searched = True
                End If
            End If
        ElseIf Words = True Then
            If arrsorts(pos - check) = searchword Then
                lstSearched.AddItem (searchword & " exists at pos: " & (pos - check))
                searched = True
            End If
            If pos <> 5000 Then
                If arrsorts(pos + check) = searchword Then
                    lstSearched.AddItem (searchword & " exists at pos: " & (pos + check))
                    searched = True
                End If
            End If
        End If
        check = check + 1
    Loop Until searched = False
Else
    If Nums = True Then
        lstSearched.AddItem (searchnum & " doesn't exist")
    ElseIf Words = True Then
        lstSearched.AddItem (searchword & " doesn't exist")
    End If
End If
present = False
If Employees = True Then
If ID = True Then
    'If searchnum < arrsort(mid) Then
    '    high = mid - 1
    'ElseIf searchnum > arrsort(mid) Then
    '    low = mid + 1
    'Else
    '    pos = mid
    '    Exit Do
    'End If
    For i = 1 To 5000
        If arrsort(i) = searchnum Then
            lstSearched.AddItem (arrEmployee(i).FN)
            lstSearched.AddItem (searchnum & " exists at pos: " & i)
            lstSearched.AddItem ("")
            present = True
        End If
    Next i
    If present = False Then
        lstSearched.AddItem ("Employee #: " & searchnum & " doesn't exist")
        lstSearched.AddItem ("")
    End If
ElseIf FName = True Then
    'If StrComp(searchword, (arrsorts(mid))) = -1 Then
    '    high = mid - 1
    'ElseIf StrComp(searchword, (arrsorts(mid))) = 1 Then
    '    low = mid + 1
    'Else
    '    pos = mid
    '    Exit Do
    'End If
    For i = 1 To 5000
        If arrsorts(i) = searchword Then
            lstSearched.AddItem (searchword & " exists at pos: " & i)
            lstSearched.AddItem (arrEmployee(i).ID)
            lstSearched.AddItem ("")
            present = True
        End If
    Next i
    If present = False Then
        lstSearched.AddItem (searchword & " doesn't exist")
        lstSearched.AddItem ("")
    End If
End If
End If

End Sub

Private Sub mnuBubble_Click()

Erase arrsort
lstSorted.Clear
lblTime.Caption = ""
For i = 1 To 5000
    If Nums = True Then
        arrsort(i) = arrNums(i)
    ElseIf Words = True Then
        arrsorts(i) = arrWords(i)
    ElseIf Employees = True Then
        arrsorts(i) = arrEmployee(i).FN
        arrsort(i) = arrEmployee(i).ID
    End If
Next i
s = Timer
i = 5000
Do
    swapped = False
    For x = 1 To i - 1
        If Nums = True Then
            If arrsort(x) > arrsort(x + 1) Then
                temp = arrsort(x)
                arrsort(x) = arrsort(x + 1)
                arrsort(x + 1) = temp
                swapped = True
            End If
        ElseIf Words = True Then
            If StrComp((arrsorts(x)), (arrsorts(x + 1)), 1) = 1 Then
                temps = arrsorts(x)
                arrsorts(x) = arrsorts(x + 1)
                arrsorts(x + 1) = temps
                swapped = True
            End If
        ElseIf Employees = True Then
            If ID = True Then
                If arrsort(x) > arrsort(x + 1) Then
                    temp = arrsort(x)
                    arrsort(x) = arrsort(x + 1)
                    arrsort(x + 1) = temp
                    temps = arrsorts(x)
                    arrsorts(x) = arrsorts(x + 1)
                    arrsorts(x + 1) = temps
                    swapped = True
                End If
            ElseIf FName = True Then
                If StrComp((arrsorts(x)), (arrsorts(x + 1)), 1) = 1 Then
                    temps = arrsorts(x)
                    arrsorts(x) = arrsorts(x + 1)
                    arrsorts(x + 1) = temps
                    temp = arrsort(x)
                    arrsort(x) = arrsort(x + 1)
                    arrsort(x + 1) = temp
                    swapped = True
                End If
            End If
        End If
    Next x
    i = i - 1
Loop Until Not swapped
f = Timer
lblTime.Caption = Round((Str((f - s) * 1000)), 0)
For i = 1 To 5000
    If Nums = True Then
        lstSorted.AddItem (arrsort(i))
    ElseIf Words = True Then
        lstSorted.AddItem (arrsorts(i))
    ElseIf Employees = True Then
        lstSorted.AddItem (arrsorts(i))
        lstSorted.AddItem (arrsort(i))
        lstSorted.AddItem ("")
    End If
Next i

End Sub

Private Sub mnuComb_Click()

Erase arrsort
lstSorted.Clear
lblTime.Caption = ""
For i = 1 To 5000
    If Nums = True Then
        arrsort(i) = arrNums(i)
    ElseIf Words = True Then
        arrsorts(i) = arrWords(i)
    ElseIf Employees = True Then
        arrsorts(i) = arrEmployee(i).FN
        arrsort(i) = arrEmployee(i).ID
    End If
Next i
gap = 5000
s = Timer
Do
    gap = Int(gap / 1.3)
    If gap < 1 Then gap = 1
        swapped = False
    For x = 1 To 5000 - gap
        If Nums = True Then
            If arrsort(x) > arrsort(x + gap) Then
                temp = arrsort(x)
                arrsort(x) = arrsort(x + gap)
                arrsort(x + gap) = temp
                swapped = True
            End If
        ElseIf Words = True Then
            If StrComp((arrsorts(x)), (arrsorts(x + gap)), 1) = 1 Then
                temps = arrsorts(x)
                arrsorts(x) = arrsorts(x + gap)
                arrsorts(x + gap) = temps
                swapped = True
            End If
        ElseIf Employees = True Then
            If ID = True Then
                If arrsort(x) > arrsort(x + gap) Then
                    temp = arrsort(x)
                    arrsort(x) = arrsort(x + gap)
                    arrsort(x + gap) = temp
                    temps = arrsorts(x)
                    arrsorts(x) = arrsorts(x + gap)
                    arrsorts(x + gap) = temps
                    swapped = True
                End If
            ElseIf FName = True Then
                If StrComp((arrsorts(x)), (arrsorts(x + gap)), 1) = 1 Then
                    temps = arrsorts(x)
                    arrsorts(x) = arrsorts(x + gap)
                    arrsorts(x + gap) = temps
                    temp = arrsort(x)
                    arrsort(x) = arrsort(x + gap)
                    arrsort(x + gap) = temp
                    swapped = True
                End If
            End If
        End If
    Next x
Loop Until Not swapped And gap = 1
f = Timer
lblTime.Caption = Round((Str((f - s) * 1000)), 0)
For i = 1 To 5000
    If Nums = True Then
        lstSorted.AddItem (arrsort(i))
    ElseIf Words = True Then
        lstSorted.AddItem (arrsorts(i))
    ElseIf Employees = True Then
        lstSorted.AddItem (arrsorts(i))
        lstSorted.AddItem (arrsort(i))
        lstSorted.AddItem ("")
    End If
Next i

End Sub

Private Sub mnuEmployee_Click()

Nums = False
Words = False
Employees = True
lstRandom.Clear
lstSorted.Clear
lstSearched.Clear
Erase arrWords
Erase arrNums
Erase arrsort
path = "C:\Users\naresh_shettigar\Desktop\VB6\SortSearch\Names.txt"
'path = "C:\Users\neel.shettigar\Downloads\Dictionary.txt"
Open path For Input As #1
i = 0
Do While Not EOF(1)
    i = i + 1
    Line Input #1, strline
    arrNames(i) = strline
Loop
Randomize
For i = 1 To 5000
    rand = (Int(4945 * Rnd) + 1)
    arrEmployee(i).FN = arrNames(rand)
Next i
For i = 1 To 5000
    rand = (Int(5000 * Rnd) + 1)
    arrEmployee(i).ID = rand
Next i
For i = 1 To 5000
    lstRandom.AddItem (arrEmployee(i).FN)
    lstRandom.AddItem (arrEmployee(i).ID)
    lstRandom.AddItem ("")
Next i
Close #1

End Sub

Private Sub mnuExchange_Click()

Erase arrsort
lstSorted.Clear
lblTime.Caption = ""
For i = 1 To 5000
    If Nums = True Then
        arrsort(i) = arrNums(i)
    ElseIf Words = True Then
        arrsorts(i) = arrWords(i)
    ElseIf Employees = True Then
        arrsorts(i) = arrEmployee(i).FN
        arrsort(i) = arrEmployee(i).ID
    End If
Next i
s = Timer
For x = 1 To 4999
    For y = x + 1 To 5000
        If Nums = True Then
            If arrsort(x) > arrsort(y) Then
                temp = arrsort(y)
                arrsort(y) = arrsort(x)
                arrsort(x) = temp
            End If
        ElseIf Words = True Then
            If StrComp((arrsorts(x)), (arrsorts(y)), 1) = 1 Then
                temps = arrsorts(y)
                arrsorts(y) = arrsorts(x)
                arrsorts(x) = temps
            End If
        ElseIf Employees = True Then
            If ID = True Then
                If arrsort(x) > arrsort(y) Then
                    temp = arrsort(y)
                    arrsort(y) = arrsort(x)
                    arrsort(x) = temp
                    temps = arrsorts(y)
                    arrsorts(y) = arrsorts(x)
                    arrsorts(x) = temps
                End If
            ElseIf FName = True Then
                If StrComp((arrsorts(x)), (arrsorts(y)), 1) = 1 Then
                    temps = arrsorts(y)
                    arrsorts(y) = arrsorts(x)
                    arrsorts(x) = temps
                    temp = arrsort(y)
                    arrsort(y) = arrsort(x)
                    arrsort(x) = temp
                End If
            End If
        End If
    Next y
Next x
f = Timer
lblTime.Caption = Round((Str((f - s) * 1000)), 0)
For i = 1 To 5000
    If Nums = True Then
        lstSorted.AddItem (arrsort(i))
    ElseIf Words = True Then
        lstSorted.AddItem (arrsorts(i))
    ElseIf Employees = True Then
        lstSorted.AddItem (arrsorts(i))
        lstSorted.AddItem (arrsort(i))
        lstSorted.AddItem ("")
    End If
Next i

End Sub


Private Sub mnuNumbers_Click()

Employees = False
Words = False
Nums = True
lstRandom.Clear
lstSorted.Clear
lstSearched.Clear
Erase arrWords
Erase arrNums
Erase arrsort
For i = 1 To 5000
    Randomize
    arrNums(i) = (Int(5000 * Rnd) + 1)
    lstRandom.AddItem (arrNums(i))
Next i

End Sub

Private Sub mnuShuffle_Click()

lstRandom.Clear
For i = 1 To 25000
    Randomize
    rand = (Int(5000 * Rnd) + 1)
    rand2 = (Int(5000 * Rnd) + 1)
    If Nums = True Then
        temp = arrNums(rand)
        arrNums(rand) = arrNums(rand2)
        arrNums(rand2) = temp
    ElseIf Words = True Then
        temps = arrWords(rand)
        arrWords(rand) = arrWords(rand2)
        arrWords(rand2) = temps
    ElseIf Employees = True Then
        temp = arrEmployee(rand).ID
        arrEmployee(rand).ID = arrEmployee(rand2).ID
        arrEmployee(rand2).ID = temp
        temps = arrEmployee(rand).FN
        arrEmployee(rand).FN = arrEmployee(rand2).FN
        arrEmployee(rand2).FN = temps
    End If
Next i
For i = 1 To 5000
    If Nums = True Then
        lstRandom.AddItem (arrNums(i))
    ElseIf Words = True Then
        lstRandom.AddItem (arrWords(i))
    ElseIf Employees = True Then
        lstRandom.AddItem (arrEmployee(i).FN)
        lstRandom.AddItem (arrEmployee(i).ID)
        lstRandom.AddItem ("")
    End If
Next i
    

End Sub

Private Sub mnuUnique_Click()

For i = 1 To 5000
    arrUnique(i) = 0
    arrUniques(i) = ""
Next i
If Nums = True Then
    For i = 1 To 5000
        arrTallies(arrNums(i)) = arrTallies(arrNums(i)) + 1
    Next i
    For i = 1 To 5000
        If arrTallies(i) = 1 Then
            lstSearched.AddItem (i & " Exists once")
        End If
    Next i
ElseIf Words = True Then
    For i = 1 To 5000
        test = 0
        For x = i + 1 To 5000
            If arrWords(i) = arrWords(x) Then
                test = test + 1
            End If
        Next x
        If test = 0 Then
            lstSearched.AddItem ((arrWords(i)) & " Exists once")
        End If
    Next i
ElseIf Employees = True Then
    If ID = True Then
        For i = 1 To 5000
            arrTallies(arrEmployee(i).ID) = arrTallies(arrEmployee(i).ID) + 1
        Next i
        For i = 1 To 5000
            If arrTallies(i) = 1 Then
                lstSearched.AddItem (i & " Exists once")
            End If
        Next i
    ElseIf FName = True Then
        For i = 1 To 5000
            test = 0
            For x = i + 1 To 5000
                If arrEmployee(i).FN = arrEmployee(x).FN Then
                    test = test + 1
                End If
            Next x
            If test = 0 Then
                lstSearched.AddItem ((arrEmployee(i).FN) & " Exists once")
            End If
        Next i
    End If
End If

End Sub

Private Sub mnuWords_Click()

Employees = False
Nums = False
Words = True
lstRandom.Clear
lstSorted.Clear
lstSearched.Clear
Erase arrWords
Erase arrNums
Erase arrsort
path = "C:\Users\naresh_shettigar\Desktop\VB6\SortSearch\Dictionary.txt"
'path = "C:\Users\neel.shettigar\Downloads\Dictionary.txt"
Open path For Input As #1
i = 0
Do While Not EOF(1)
    i = i + 1
    Line Input #1, strline
    arrDictionary(i) = strline
Loop
Randomize
For i = 1 To 5000
    rand = (Int(58112 * Rnd) + 1)
    arrWords(i) = arrDictionary(rand)
Next i
For i = 1 To 5000
    lstRandom.AddItem (arrWords(i))
Next i
Close #1
End Sub

Private Sub optId_Click()

ID = True
FName = False

End Sub

Private Sub optName_Click()

FName = True
ID = False

End Sub
