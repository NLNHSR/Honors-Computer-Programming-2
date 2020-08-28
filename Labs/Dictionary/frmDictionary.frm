VERSION 5.00
Begin VB.Form frmDictionary 
   BackColor       =   &H000000C0&
   Caption         =   "Form1"
   ClientHeight    =   3915
   ClientLeft      =   120
   ClientTop       =   465
   ClientWidth     =   4350
   LinkTopic       =   "Form1"
   ScaleHeight     =   3915
   ScaleWidth      =   4350
   StartUpPosition =   3  'Windows Default
   Begin VB.CommandButton cmdQuit 
      BackColor       =   &H00C0C0FF&
      Caption         =   "Quit"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   11.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   500
      Left            =   1260
      Style           =   1  'Graphical
      TabIndex        =   5
      Top             =   2520
      Width           =   800
   End
   Begin VB.CommandButton cmdClear 
      BackColor       =   &H00C0C0FF&
      Caption         =   "Clear"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   11.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   500
      Left            =   350
      Style           =   1  'Graphical
      TabIndex        =   4
      Top             =   2520
      Width           =   800
   End
   Begin VB.CommandButton cmdWordLength 
      BackColor       =   &H00C0C0FF&
      Caption         =   "Word Length"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   12
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   500
      Left            =   350
      Style           =   1  'Graphical
      TabIndex        =   3
      Top             =   1860
      Width           =   1700
   End
   Begin VB.CommandButton cmdGenerate 
      BackColor       =   &H00C0C0FF&
      Caption         =   "Generate"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   12
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   500
      Left            =   350
      Style           =   1  'Graphical
      TabIndex        =   1
      Top             =   1200
      Width           =   1700
   End
   Begin VB.ListBox lstwords 
      BackColor       =   &H00C0FFFF&
      BeginProperty Font 
         Name            =   "Calibri"
         Size            =   9.75
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   2760
      Left            =   2280
      TabIndex        =   0
      Top             =   300
      Width           =   1700
   End
   Begin VB.Label lblLongestWord 
      BackColor       =   &H00C0E0FF&
      BeginProperty Font 
         Name            =   "Calibri"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   500
      Left            =   2280
      TabIndex        =   7
      Top             =   3120
      Width           =   1700
   End
   Begin VB.Label Label1 
      Alignment       =   2  'Center
      BackColor       =   &H00C0C0FF&
      Caption         =   "Longest Word"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   11.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   500
      Left            =   350
      TabIndex        =   6
      Top             =   3120
      Width           =   1700
   End
   Begin VB.Label lblRandWord 
      BackColor       =   &H00C0E0FF&
      BorderStyle     =   1  'Fixed Single
      BeginProperty Font 
         Name            =   "Calibri"
         Size            =   9.75
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   735
      Left            =   350
      TabIndex        =   2
      Top             =   300
      Width           =   1700
   End
End
Attribute VB_Name = "frmDictionary"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit
Dim Path, ArrayWords(58112), Strline, Max As String
Dim i, x, y, z, RandNum, Length As Long
Dim LengthCheck, LengthActivate As Boolean

Private Sub cmdClear_Click()
Erase ArrayWords
lstwords.Clear
Path = "D:\19 S1 NS CP2\Dictionary\Dictionary.txt"
i = 1
Open Path For Input As #1
Do While Not EOF(1)
    Line Input #1, Strline
    ArrayWords(i) = Strline
    lstwords.AddItem (ArrayWords(i))
    i = i + 1
Loop
Close #1
LengthActivate = False
lblRandWord.Caption = ""

End Sub

Private Sub cmdGenerate_Click()
Randomize

If LengthActivate = True Then
    LengthCheck = False
    Do Until LengthCheck = True
        RandNum = Int((58112 * Rnd) + 1)
        If Len(ArrayWords(RandNum)) = Length Then
            lblRandWord.Caption = ArrayWords(RandNum)
            LengthCheck = True
        End If
    Loop
Else
     RandNum = Int((58112 * Rnd) + 1)
     lblRandWord.Caption = ArrayWords(RandNum)
End If
        
End Sub

Private Sub cmdQuit_Click()

End

End Sub

Private Sub cmdWordLength_Click()

Length = Val(InputBox("Only show words of a certain length", "Word Length", "Enter Number"))
Path = "D:\19 S1 NS CP2\Dictionary\Dictionary.txt"
x = 1
lstwords.Clear
Erase ArrayWords
Open Path For Input As #1
Do While Not EOF(1)
    Line Input #1, Strline
    If Len(Strline) = Length Then
        ArrayWords(x) = Strline
        lstwords.AddItem (ArrayWords(x))
    Else
        x = x + 1
    End If
Loop
Close #1
LengthActivate = True

End Sub

Private Sub Form_Load()

Path = "D:\19 S1 NS CP2\Dictionary\Dictionary.txt"
i = 1
Open Path For Input As #1
Do While Not EOF(1)
    Line Input #1, Strline
    ArrayWords(i) = Strline
    lstwords.AddItem (ArrayWords(i))
    i = i + 1
Loop
Max = ArrayWords(1)
For y = 2 To 58112
    If Len(ArrayWords(y)) > Len(Max) Then
        Max = ArrayWords(y)
    End If
Next y
lblLongestWord.Caption = Max
Close #1
LengthActivate = False

End Sub
