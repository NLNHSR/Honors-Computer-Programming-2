VERSION 5.00
Begin VB.Form frmDialog 
   Caption         =   "Employees"
   ClientHeight    =   3660
   ClientLeft      =   120
   ClientTop       =   465
   ClientWidth     =   2385
   LinkTopic       =   "Form1"
   ScaleHeight     =   3660
   ScaleWidth      =   2385
   StartUpPosition =   3  'Windows Default
   Begin VB.CommandButton cmdMenu 
      BackColor       =   &H8000000A&
      Caption         =   "Menu"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   9.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Left            =   820
      MaskColor       =   &H0000FF00&
      Style           =   1  'Graphical
      TabIndex        =   17
      Top             =   3180
      Width           =   735
   End
   Begin VB.TextBox txtAge 
      BackColor       =   &H00FFFFFF&
      Height          =   315
      Left            =   1200
      TabIndex        =   3
      Top             =   1320
      Width           =   1035
   End
   Begin VB.CommandButton cmdDelete 
      BackColor       =   &H8000000A&
      Caption         =   "Delete"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   12
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Left            =   120
      MaskColor       =   &H0000FF00&
      Style           =   1  'Graphical
      TabIndex        =   15
      Top             =   2760
      Width           =   2110
   End
   Begin VB.CommandButton cmdEdit 
      BackColor       =   &H8000000A&
      Caption         =   "Change"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   12
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Left            =   120
      Style           =   1  'Graphical
      TabIndex        =   14
      Top             =   2760
      Width           =   2110
   End
   Begin VB.CommandButton cmdAdd 
      BackColor       =   &H8000000A&
      Caption         =   "Add"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   12
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Left            =   120
      Style           =   1  'Graphical
      TabIndex        =   13
      Top             =   2760
      Width           =   2110
   End
   Begin VB.CommandButton cmdRight 
      BackColor       =   &H8000000A&
      Caption         =   "--->"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   12
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Left            =   1620
      MaskColor       =   &H0000FF00&
      Style           =   1  'Graphical
      TabIndex        =   12
      Top             =   3180
      Width           =   615
   End
   Begin VB.CommandButton cmdLeft 
      BackColor       =   &H8000000A&
      Caption         =   "<---"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   12
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Left            =   120
      MaskColor       =   &H0000FF00&
      Style           =   1  'Graphical
      TabIndex        =   11
      Top             =   3180
      Width           =   615
   End
   Begin VB.TextBox txtLN 
      BackColor       =   &H00FFFFFF&
      Height          =   315
      Left            =   1200
      TabIndex        =   2
      Top             =   960
      Width           =   1035
   End
   Begin VB.TextBox txtPayKind 
      BackColor       =   &H00FFFFFF&
      Height          =   315
      Left            =   1200
      TabIndex        =   4
      Top             =   1680
      Width           =   1035
   End
   Begin VB.TextBox txtSalary 
      BackColor       =   &H00FFFFFF&
      Height          =   315
      Left            =   1200
      TabIndex        =   5
      Top             =   2040
      Width           =   1035
   End
   Begin VB.TextBox txtDependants 
      BackColor       =   &H00FFFFFF&
      Height          =   315
      Left            =   1200
      TabIndex        =   6
      Top             =   2400
      Width           =   1035
   End
   Begin VB.TextBox txtFN 
      BackColor       =   &H00FFFFFF&
      Height          =   315
      Left            =   1200
      TabIndex        =   1
      Top             =   600
      Width           =   1035
   End
   Begin VB.Label Label6 
      Alignment       =   2  'Center
      BackColor       =   &H8000000A&
      BorderStyle     =   1  'Fixed Single
      Caption         =   "Employee Info"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   9.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Left            =   120
      TabIndex        =   18
      Top             =   120
      Width           =   2115
   End
   Begin VB.Label Label5 
      Alignment       =   2  'Center
      BackColor       =   &H00FFFFFF&
      BorderStyle     =   1  'Fixed Single
      Caption         =   "Age"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   9.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   315
      Left            =   120
      TabIndex        =   16
      Top             =   1320
      Width           =   1035
   End
   Begin VB.Label Label4 
      Alignment       =   2  'Center
      BackColor       =   &H00FFFFFF&
      BorderStyle     =   1  'Fixed Single
      Caption         =   "# Of Dep."
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   9.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   315
      Left            =   120
      TabIndex        =   10
      Top             =   2400
      Width           =   1035
   End
   Begin VB.Label Label3 
      Alignment       =   2  'Center
      BackColor       =   &H00FFFFFF&
      BorderStyle     =   1  'Fixed Single
      Caption         =   "Salary"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   9.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   315
      Left            =   120
      TabIndex        =   9
      Top             =   2040
      Width           =   1035
   End
   Begin VB.Label Label2 
      Alignment       =   2  'Center
      BackColor       =   &H00FFFFFF&
      BorderStyle     =   1  'Fixed Single
      Caption         =   "PayKind"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   9.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   315
      Left            =   120
      TabIndex        =   8
      Top             =   1680
      Width           =   1035
   End
   Begin VB.Label Label1 
      Alignment       =   2  'Center
      BackColor       =   &H00FFFFFF&
      BorderStyle     =   1  'Fixed Single
      Caption         =   "Last Name"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   9.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   315
      Left            =   120
      TabIndex        =   7
      Top             =   960
      Width           =   1035
   End
   Begin VB.Label Label 
      Alignment       =   2  'Center
      BackColor       =   &H00FFFFFF&
      BorderStyle     =   1  'Fixed Single
      Caption         =   "First Name"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   9.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   315
      Index           =   0
      Left            =   120
      TabIndex        =   0
      Top             =   600
      Width           =   1035
   End
End
Attribute VB_Name = "frmDialog"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit

Private Sub cmdAdd_Click()

Entry = Entry + 1
With arrEmployees(Entry)
    .FN = txtFN.Text
    .LN = txtLN.Text
    .Age = txtAge.Text
    .PayKind = txtPayKind.Text
    .Salary = txtSalary.Text
    .Dependants = txtDependants.Text
'    .FN = Str(Entry)
'    .LN = Str(Entry)
'    .Age = Entry
'    .PayKind = Entry
'    .Salary = Entry
'    .Dependants = Entry
End With

txtFN.Text = ""
txtLN.Text = ""
txtAge.Text = ""
txtPayKind.Text = ""
txtSalary.Text = ""
txtDependants.Text = ""
Current2 = Entry

End Sub

Private Sub cmdDelete_Click()

If frmMenu.lstOutput.ListCount <> 0 Then
    arrEmployees(Entry).FN = ""
    arrEmployees(Entry).LN = ""
    arrEmployees(Entry).Age = Empty
    arrEmployees(Entry).PayKind = ""
    arrEmployees(Entry).Salary = Empty
    arrEmployees(Entry).Dependants = Empty
End If
For i = Entry To Current
    arrEmployees(i) = arrEmployees(i + 1)
Next i

End Sub

Private Sub cmdEdit_Click()

If frmMenu.lstOutput.ListCount <> 0 Then
    With arrEmployees(Entry)
        .FN = txtFN.Text
        .LN = txtLN.Text
        .Age = txtAge.Text
        .PayKind = txtPayKind.Text
        .Salary = txtSalary.Text
        .Dependants = txtDependants.Text
    End With
    
    txtFN.Text = ""
    txtLN.Text = ""
    txtAge.Text = ""
    txtPayKind.Text = ""
    txtSalary.Text = ""
    txtDependants.Text = ""
    Current2 = Current
End If

End Sub

Private Sub cmdLeft_Click()

If frmMenu.lstOutput.ListCount <> 0 Then
    Entry = Entry - 1
    If Entry <= 0 Then
        Entry = Current
    End If
    If arrEmployees(Entry).FN <> "" Then
        txtFN.Text = arrEmployees(Entry).FN
        txtLN.Text = arrEmployees(Entry).LN
        txtAge.Text = arrEmployees(Entry).Age
        txtPayKind.Text = arrEmployees(Entry).PayKind
        txtSalary.Text = arrEmployees(Entry).Salary
        txtDependants.Text = arrEmployees(Entry).Dependants
    End If
End If

End Sub

Private Sub cmdMenu_Click()
MsgBox (Current2)
frmDialog.Hide
frmMenu.Show
frmMenu.lstOutput.Clear
For i = 1 To Current
    If arrEmployees(i).FN <> "" Then
        frmMenu.lstOutput.AddItem (arrEmployees(i).FN & ", " & arrEmployees(i).LN & vbTab & "Age: " & arrEmployees(i).Age & vbTab & "PayKind: " & arrEmployees(i).PayKind & vbTab & "Salary: " & arrEmployees(i).Salary & vbTab & "Number of Dependants: " & arrEmployees(i).Dependants)
    End If
Next i

End Sub

Private Sub cmdRight_Click()

If frmMenu.lstOutput.ListCount <> 0 Then
    If Entry > Current Then
        Entry = 1
    Else
        Entry = Entry + 1
    End If
    If arrEmployees(Entry).FN <> "" Then
        txtFN.Text = arrEmployees(Entry).FN
        txtLN.Text = arrEmployees(Entry).LN
        txtAge.Text = arrEmployees(Entry).Age
        txtPayKind.Text = arrEmployees(Entry).PayKind
        txtSalary.Text = arrEmployees(Entry).Salary
        txtDependants.Text = arrEmployees(Entry).Dependants
    Else
        Call cmdRight_Click
    End If
End If

End Sub
