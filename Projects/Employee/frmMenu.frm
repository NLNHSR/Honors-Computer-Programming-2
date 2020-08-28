VERSION 5.00
Begin VB.Form frmMenu 
   BackColor       =   &H8000000E&
   Caption         =   "Employees"
   ClientHeight    =   3945
   ClientLeft      =   225
   ClientTop       =   870
   ClientWidth     =   9165
   LinkTopic       =   "Form1"
   ScaleHeight     =   3945
   ScaleWidth      =   9165
   StartUpPosition =   3  'Windows Default
   Begin VB.ListBox lstOutput 
      BeginProperty Font 
         Name            =   "Cambria"
         Size            =   11.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H80000009&
      Height          =   3885
      Left            =   0
      TabIndex        =   0
      Top             =   60
      Width           =   9135
   End
   Begin VB.Menu mnuFile 
      Caption         =   "File"
      Begin VB.Menu mnuNew 
         Caption         =   "New"
      End
      Begin VB.Menu mnuOpen 
         Caption         =   "Open"
      End
      Begin VB.Menu mnuSave 
         Caption         =   "Save"
      End
      Begin VB.Menu mnuSaveAs 
         Caption         =   "Save As"
      End
      Begin VB.Menu mnuExit 
         Caption         =   "Exit"
      End
   End
   Begin VB.Menu mnuEdit 
      Caption         =   "Edit"
      Begin VB.Menu mnuAdd 
         Caption         =   "Add"
      End
      Begin VB.Menu mnuChange 
         Caption         =   "Change"
      End
      Begin VB.Menu mnuDelete 
         Caption         =   "Delete"
      End
   End
   Begin VB.Menu mnuView 
      Caption         =   "View"
      Begin VB.Menu mnuIndividual 
         Caption         =   "Individual"
      End
      Begin VB.Menu mnuSearch 
         Caption         =   "Search"
      End
   End
End
Attribute VB_Name = "frmMenu"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit

Private Sub Form_Load()

Entry = 0

End Sub

Private Sub Form_Resize()

lstOutput.Width = frmMenu.Width
lstOutput.Height = frmMenu.Height

End Sub

Private Sub mnuAdd_Click()

frmDialog.Show
frmMenu.Hide
frmDialog.cmdAdd.Visible = True
frmDialog.cmdDelete.Visible = False
frmDialog.cmdEdit.Visible = False
frmDialog.cmdLeft.Visible = False
frmDialog.cmdRight.Visible = False
frmDialog.cmdMenu.Left = 120
frmDialog.cmdMenu.Width = 2110

End Sub

Private Sub mnuChange_Click()

Current = (lstOutput.ListCount)
frmDialog.Show
frmMenu.Hide
frmDialog.cmdAdd.Visible = False
frmDialog.cmdDelete.Visible = False
frmDialog.cmdEdit.Visible = True
frmDialog.cmdLeft.Visible = True
frmDialog.cmdRight.Visible = True
Entry = 0
frmDialog.cmdMenu.Left = 820
frmDialog.cmdMenu.Width = 735

End Sub

Private Sub mnuDelete_Click()

Current = (lstOutput.ListCount)
frmDialog.Show
frmMenu.Hide
frmDialog.cmdAdd.Visible = False
frmDialog.cmdDelete.Visible = True
frmDialog.cmdEdit.Visible = False
frmDialog.cmdLeft.Visible = True
frmDialog.cmdRight.Visible = True
Entry = 0
frmDialog.cmdMenu.Left = 820
frmDialog.cmdMenu.Width = 735

End Sub

Private Sub mnuExit_Click()

End

End Sub

Private Sub mnuIndividual_Click()
Current2 = (lstOutput.ListCount)
Current = (lstOutput.ListCount)
frmDialog.Show
frmMenu.Hide
frmDialog.cmdAdd.Visible = False
frmDialog.cmdDelete.Visible = False
frmDialog.cmdEdit.Visible = False
frmDialog.cmdLeft.Visible = True
frmDialog.cmdRight.Visible = True
Entry = 0
frmDialog.cmdMenu.Left = 820
frmDialog.cmdMenu.Width = 735
MsgBox (Current2)
End Sub

Private Sub mnuNew_Click()

Erase arrEmployees
Entry = 0
Current = 0
lstOutput.Clear
Filename = ""

End Sub

Private Sub mnuOpen_Click()

Entry = 1
Filename = InputBox("Enter Filename", "Open File")
'Path = "C:\Users\neel.shettigar\Desktop\" & Trim(UCase(Filename)) & ".dat"
Path = "C:\Users\naresh_shettigar\Desktop\VB6\Employee\" & Trim(UCase(Filename)) & ".dat"

Open Path For Random Access Read As #1 'Len = 42
Do While Not EOF(1)
    Get #1, , arrEmployees(Entry)
    Entry = Entry + 1
Loop

For i = 1 To Entry
    If arrEmployees(i).FN <> "" Then
        lstOutput.AddItem (arrEmployees(i).FN & ", " & arrEmployees(i).LN & vbTab & "Age: " & arrEmployees(i).Age & vbTab & "PayKind: " & arrEmployees(i).PayKind & vbTab & "Salary: " & arrEmployees(i).Salary & vbTab & "Number of Dependants: " & arrEmployees(i).Dependants)
    End If
Next i
Close #1

End Sub

Private Sub mnuSave_Click()

If Filename <> "" Then
    'Path = "C:\Users\neel.shettigar\Desktop\" & Trim(UCase(Filename)) & ".dat"
    Path = "C:\Users\naresh_shettigar\Desktop\VB6\Employee\" & Trim(UCase(Filename)) & ".dat"
    
    Open Path For Random Access Write As #1 'Len = 42
    For i = 1 To 10 'set as the amount of positions
        Put #1, i, arrEmployees(i)
    Next i
    Close #1
End If

End Sub

Private Sub mnuSaveAs_Click()

Filename = InputBox("Choose Filename", "Save As")
'Path = "C:\Users\neel.shettigar\Desktop\" & Trim(UCase(Filename)) & ".dat"
Path = "C:\Users\naresh_shettigar\Desktop\VB6\Employee\" & Trim(UCase(Filename)) & ".dat"

Open Path For Random Access Write As #1 'Len = 42
For i = 1 To 10 'set as the amount of positions
    Put #1, i, arrEmployees(i)
Next i
Close #1

End Sub

Private Sub mnuSearch_Click()
Current2 = lstOutput.ListCount
EmployeeName = InputBox("Enter Employee's First Name", "Search")
For i = 1 To lstOutput.ListCount
    If UCase(Trim(arrEmployees(i).FN)) = UCase(Trim(EmployeeName)) Then
        frmMenu.Hide
        frmDialog.Show
        frmDialog.cmdEdit.Visible = False
        frmDialog.cmdAdd.Visible = False
        frmDialog.cmdDelete.Visible = False
        frmDialog.cmdLeft.Visible = False
        frmDialog.cmdRight.Visible = False
        frmDialog.txtFN = arrEmployees(i).FN
        frmDialog.txtLN = arrEmployees(i).LN
        frmDialog.txtAge = arrEmployees(i).Age
        frmDialog.txtPayKind = arrEmployees(i).PayKind
        frmDialog.txtSalary = arrEmployees(i).Salary
        frmDialog.txtDependants = arrEmployees(i).Dependants
        frmDialog.cmdMenu.Left = 120
        frmDialog.cmdMenu.Width = 2110
        Exit For
    End If
Next i

End Sub
