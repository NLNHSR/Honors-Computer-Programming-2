VERSION 5.00
Begin VB.Form frm100Stus 
   Caption         =   "100Stus"
   ClientHeight    =   6090
   ClientLeft      =   120
   ClientTop       =   465
   ClientWidth     =   9690
   LinkTopic       =   "Form1"
   ScaleHeight     =   6090
   ScaleWidth      =   9690
   StartUpPosition =   3  'Windows Default
   Begin VB.CommandButton cmdSaveAs 
      Caption         =   "Save As"
      Height          =   375
      Left            =   7920
      TabIndex        =   7
      Top             =   4860
      Width           =   1575
   End
   Begin VB.CommandButton cmdOpen 
      Caption         =   "Open"
      Height          =   375
      Left            =   6120
      TabIndex        =   6
      Top             =   4860
      Width           =   1575
   End
   Begin VB.ListBox lstHighestGPAs 
      Height          =   645
      Left            =   2640
      TabIndex        =   5
      Top             =   5340
      Width           =   6855
   End
   Begin VB.ListBox lstLastNames 
      Height          =   4935
      Left            =   1440
      TabIndex        =   3
      Top             =   1020
      Width           =   1035
   End
   Begin VB.ListBox lstFirstNames 
      Height          =   4935
      Left            =   180
      TabIndex        =   2
      Top             =   1020
      Width           =   1035
   End
   Begin VB.ListBox lstOutput 
      Height          =   4545
      Left            =   2640
      TabIndex        =   1
      Top             =   180
      Width           =   6855
   End
   Begin VB.CommandButton cmdFill 
      Caption         =   "Fill"
      Height          =   735
      Left            =   180
      TabIndex        =   0
      Top             =   180
      Width           =   2295
   End
   Begin VB.Label Label 
      Alignment       =   2  'Center
      BorderStyle     =   1  'Fixed Single
      Caption         =   "Highest GPA"
      Height          =   375
      Left            =   2640
      TabIndex        =   4
      Top             =   4860
      Width           =   2295
   End
End
Attribute VB_Name = "frm100Stus"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit

Private Sub cmdFill_Click()

i = 1
Randomize
For i = 1 To 100
With Students(i)
    .FN = FirstNames(Int(Rnd * 100) + 1)
    .LN = LastNames(Int(Rnd * 100) + 1)
    .GL = Int((12 - 9 + 1) * Rnd + 9)
    .T1 = Int((100 - 50 + 1) * Rnd + 50)
    .T2 = Int((100 - 50 + 1) * Rnd + 50)
    .T3 = Int((100 - 50 + 1) * Rnd + 50)
    If ((.T1 + .T2 + .T3) / 3) >= 90 Then
        GPA = 4
    ElseIf ((.T1 + .T2 + .T3) / 3) >= 80 And ((.T1 + .T2 + .T3) / 3) < 90 Then
        GPA = 3
    ElseIf ((.T1 + .T2 + .T3) / 3) >= 70 And ((.T1 + .T2 + .T3) / 3) < 80 Then
        GPA = 2
    ElseIf ((.T1 + .T2 + .T3) / 3) >= 60 And ((.T1 + .T2 + .T3) / 3) < 70 Then
        GPA = 1
    ElseIf ((.T1 + .T2 + .T3) / 3) < 60 Then
        GPA = 0
    End If
    .GPA = GPA
    .ID = Int((999999 - 100000 + 1) * Rnd + 100000)
    lstOutput.AddItem (.FN & ", " & .LN & "     " & "ID: " & .ID & " " & "Grade: " & .GL & "       " & "Scores: " & "(" & .T1 & ", " & .T2 & ", " & .T3 & ")" & "       " & "GPA: " & .GPA)
End With
Next i
max = 0
For i = 1 To 100
    If Students(i).GPA > max Then
        max = Students(i).GPA
    End If
Next i
For i = 1 To 100
    If Students(i).GPA = max Then
        lstHighestGPAs.AddItem (Students(i).FN & ", " & Students(i).LN & "     " & "ID: " & Students(i).ID & " " & "Grade: " & Students(i).GL & "       " & "Scores: " & "(" & Students(i).T1 & ", " & Students(i).T2 & ", " & Students(i).T3 & ")" & "       " & "GPA: " & Students(i).GPA)
    End If
Next i

End Sub

Private Sub Form_Load()

i = 1
Open "C:\Users\neel.shettigar\Desktop\FirstNames.txt" For Input As #1
'Open "C:\Users\naresh_shettigar\Desktop\VB6\100Stus\FirstNames.txt" For Input As #1
For x = 1 To 100
    Line Input #1, strline
    FirstNames(i) = strline
    lstFirstNames.AddItem (strline)
    i = i + 1
Next x
i = 1
Open "C:\Users\neel.shettigar\Desktop\LastNames.txt" For Input As #2
'Open "C:\Users\naresh_shettigar\Desktop\VB6\100Stus\LastNames.txt" For Input As #2
For x = 1 To 100
    Line Input #2, strline
    LastNames(i) = strline
    lstLastNames.AddItem (strline)
    i = i + 1
Next x

End Sub
Private Sub cmdOpen_Click()
lstOutput.Clear
Entry = 1
Filename = InputBox("Enter Name of File", "Save As...", "Bobby")
Path = "C:\Users\neel.shettigar\Desktop\" + UCase(Filename) + ".dat"
Open Path For Random Access Read As #3 Len = 38
Do While Not EOF(3)
    Get #3, , Students(Entry)
    '
    Entry = Entry + 1
Loop

Current = Entry - 2
For i = 1 To Current
    With Students(i)
        lstOutput.AddItem ("First Name: " & .FN & "  " & "Last Name:  " & .LN)
        lstOutput.AddItem ("Grade: " & Str$(.GL))
        lstOutput.AddItem ("ID Number: " & Str$(.ID))
        lstOutput.AddItem ("Test Scores: " & .T1 & "% , " & .T2 & "% , " & .T3 & "%")
        lstOutput.AddItem ("GPA: " & .GPA)
        lstOutput.AddItem ""
        lstOutput.AddItem ""
    End With
Next i
Close #1
End Sub
Private Sub cmdSaveAs_Click()

' You can bring a third form to save the filename and then have it use a network
Filename = InputBox("Enter Name of File", "Save As...", "Bobby")
Path = "C:\Users\neel.shettigar\Desktop\" + UCase(Filename) + ".dat"
Open Path For Random Access Write As #3 Len = 38

' Takes 22 bytes to store one, and then keeps repeating until the loop reaches a 100
For i = 1 To 100
    Put #3, i, Students(i)
Next i

Close #3

End Sub
