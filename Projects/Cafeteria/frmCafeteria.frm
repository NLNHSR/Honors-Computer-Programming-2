VERSION 5.00
Begin VB.Form frmCafeteria 
   BackColor       =   &H00000000&
   Caption         =   "School Cafeteria Rankings"
   ClientHeight    =   5370
   ClientLeft      =   120
   ClientTop       =   465
   ClientWidth     =   8745
   LinkTopic       =   "Form1"
   ScaleHeight     =   5370
   ScaleWidth      =   8745
   StartUpPosition =   3  'Windows Default
   Begin VB.TextBox txtPeople 
      Height          =   315
      Left            =   240
      TabIndex        =   35
      Top             =   1080
      Width           =   1215
   End
   Begin VB.CommandButton cmdGraphtype 
      Caption         =   "Scatter Plot"
      Height          =   400
      Index           =   3
      Left            =   240
      Style           =   1  'Graphical
      TabIndex        =   34
      Top             =   3960
      Width           =   1230
   End
   Begin VB.PictureBox pctLegend 
      AutoRedraw      =   -1  'True
      BackColor       =   &H8000000E&
      Height          =   2835
      Left            =   7080
      ScaleHeight     =   2775
      ScaleWidth      =   1395
      TabIndex        =   23
      Top             =   2400
      Width           =   1455
      Begin VB.Label lblLegend 
         AutoSize        =   -1  'True
         BackColor       =   &H8000000E&
         Height          =   195
         Index           =   9
         Left            =   0
         TabIndex        =   33
         Top             =   2160
         Visible         =   0   'False
         Width           =   45
      End
      Begin VB.Label lblLegend 
         AutoSize        =   -1  'True
         BackColor       =   &H8000000E&
         Height          =   195
         Index           =   8
         Left            =   0
         TabIndex        =   32
         Top             =   1920
         Visible         =   0   'False
         Width           =   45
      End
      Begin VB.Label lblLegend 
         AutoSize        =   -1  'True
         BackColor       =   &H8000000E&
         Height          =   195
         Index           =   7
         Left            =   0
         TabIndex        =   31
         Top             =   1680
         Visible         =   0   'False
         Width           =   45
      End
      Begin VB.Label lblLegend 
         AutoSize        =   -1  'True
         BackColor       =   &H8000000E&
         Height          =   195
         Index           =   6
         Left            =   0
         TabIndex        =   30
         Top             =   1440
         Visible         =   0   'False
         Width           =   45
      End
      Begin VB.Label lblLegend 
         AutoSize        =   -1  'True
         BackColor       =   &H8000000E&
         Height          =   195
         Index           =   5
         Left            =   0
         TabIndex        =   29
         Top             =   1200
         Visible         =   0   'False
         Width           =   45
      End
      Begin VB.Label lblLegend 
         AutoSize        =   -1  'True
         BackColor       =   &H8000000E&
         Height          =   195
         Index           =   4
         Left            =   0
         TabIndex        =   28
         Top             =   960
         Visible         =   0   'False
         Width           =   45
      End
      Begin VB.Label lblLegend 
         AutoSize        =   -1  'True
         BackColor       =   &H8000000E&
         Height          =   195
         Index           =   3
         Left            =   0
         TabIndex        =   27
         Top             =   720
         Visible         =   0   'False
         Width           =   45
      End
      Begin VB.Label lblLegend 
         AutoSize        =   -1  'True
         BackColor       =   &H8000000E&
         Height          =   195
         Index           =   2
         Left            =   0
         TabIndex        =   26
         Top             =   480
         Visible         =   0   'False
         Width           =   45
      End
      Begin VB.Label lblLegend 
         AutoSize        =   -1  'True
         BackColor       =   &H8000000E&
         Height          =   195
         Index           =   1
         Left            =   0
         TabIndex        =   25
         Top             =   240
         Visible         =   0   'False
         Width           =   45
      End
      Begin VB.Label lblLegend 
         AutoSize        =   -1  'True
         BackColor       =   &H8000000E&
         Height          =   195
         Index           =   0
         Left            =   0
         TabIndex        =   24
         Top             =   0
         Visible         =   0   'False
         Width           =   45
      End
   End
   Begin VB.CommandButton cmdGraphtype 
      Caption         =   "Rotating Pie"
      Height          =   400
      Index           =   2
      Left            =   240
      Style           =   1  'Graphical
      TabIndex        =   20
      Top             =   3480
      Width           =   1230
   End
   Begin VB.CommandButton cmdGraphtype 
      Caption         =   "Vertical Bar"
      Height          =   400
      Index           =   1
      Left            =   240
      Style           =   1  'Graphical
      TabIndex        =   19
      Top             =   3000
      Width           =   1230
   End
   Begin VB.CommandButton cmdGraphtype 
      Caption         =   "Horizontal Bar "
      Height          =   400
      Index           =   0
      Left            =   240
      Style           =   1  'Graphical
      TabIndex        =   18
      Top             =   2520
      Width           =   1230
   End
   Begin VB.ComboBox cmbNumChoices 
      BackColor       =   &H8000000F&
      Height          =   315
      Left            =   240
      Style           =   2  'Dropdown List
      TabIndex        =   16
      Top             =   720
      Width           =   1230
   End
   Begin VB.CommandButton cmdClear 
      Caption         =   "Clear"
      Height          =   250
      Left            =   240
      TabIndex        =   5
      Top             =   4680
      Width           =   1230
   End
   Begin VB.CommandButton cmdExit 
      Caption         =   "Exit"
      Height          =   250
      Left            =   240
      TabIndex        =   3
      Top             =   5000
      Width           =   1230
   End
   Begin VB.CommandButton cmdTalley 
      Caption         =   "Talley"
      Height          =   400
      Left            =   240
      TabIndex        =   2
      Top             =   1440
      Width           =   1230
   End
   Begin VB.PictureBox pctGraph 
      AutoRedraw      =   -1  'True
      BackColor       =   &H8000000E&
      Height          =   5000
      Left            =   1800
      ScaleHeight     =   10
      ScaleMode       =   0  'User
      ScaleWidth      =   10
      TabIndex        =   1
      Top             =   240
      Width           =   5000
      Begin VB.Label lblTalley 
         AutoSize        =   -1  'True
         BackColor       =   &H8000000E&
         BorderStyle     =   1  'Fixed Single
         Height          =   255
         Index           =   9
         Left            =   5000
         TabIndex        =   15
         Top             =   2700
         Visible         =   0   'False
         Width           =   105
      End
      Begin VB.Label lblTalley 
         AutoSize        =   -1  'True
         BackColor       =   &H8000000E&
         BorderStyle     =   1  'Fixed Single
         Height          =   255
         Index           =   8
         Left            =   5000
         TabIndex        =   14
         Top             =   2400
         Visible         =   0   'False
         Width           =   105
      End
      Begin VB.Label lblTalley 
         AutoSize        =   -1  'True
         BackColor       =   &H8000000E&
         BorderStyle     =   1  'Fixed Single
         Height          =   255
         Index           =   7
         Left            =   5000
         TabIndex        =   13
         Top             =   2100
         Visible         =   0   'False
         Width           =   105
      End
      Begin VB.Label lblTalley 
         AutoSize        =   -1  'True
         BackColor       =   &H8000000E&
         BorderStyle     =   1  'Fixed Single
         Height          =   255
         Index           =   6
         Left            =   5000
         TabIndex        =   12
         Top             =   1800
         Visible         =   0   'False
         Width           =   105
      End
      Begin VB.Label lblTalley 
         AutoSize        =   -1  'True
         BackColor       =   &H8000000E&
         BorderStyle     =   1  'Fixed Single
         Height          =   255
         Index           =   5
         Left            =   5000
         TabIndex        =   11
         Top             =   1500
         Visible         =   0   'False
         Width           =   105
      End
      Begin VB.Label lblTalley 
         AutoSize        =   -1  'True
         BackColor       =   &H8000000E&
         BorderStyle     =   1  'Fixed Single
         Height          =   255
         Index           =   0
         Left            =   5000
         TabIndex        =   10
         Top             =   0
         Visible         =   0   'False
         Width           =   105
      End
      Begin VB.Label lblTalley 
         AutoSize        =   -1  'True
         BackColor       =   &H8000000E&
         BorderStyle     =   1  'Fixed Single
         Height          =   255
         Index           =   1
         Left            =   5000
         TabIndex        =   9
         Top             =   300
         Visible         =   0   'False
         Width           =   105
      End
      Begin VB.Label lblTalley 
         AutoSize        =   -1  'True
         BackColor       =   &H8000000E&
         BorderStyle     =   1  'Fixed Single
         Height          =   255
         Index           =   2
         Left            =   5000
         TabIndex        =   8
         Top             =   600
         Visible         =   0   'False
         Width           =   105
      End
      Begin VB.Label lblTalley 
         AutoSize        =   -1  'True
         BackColor       =   &H8000000E&
         BorderStyle     =   1  'Fixed Single
         Height          =   255
         Index           =   3
         Left            =   5000
         TabIndex        =   7
         Top             =   900
         Visible         =   0   'False
         Width           =   105
      End
      Begin VB.Label lblTalley 
         AutoSize        =   -1  'True
         BackColor       =   &H8000000E&
         BorderStyle     =   1  'Fixed Single
         Height          =   255
         Index           =   4
         Left            =   5000
         TabIndex        =   6
         Top             =   1200
         Visible         =   0   'False
         Width           =   105
      End
   End
   Begin VB.ListBox lstRankings 
      Height          =   840
      Left            =   7080
      TabIndex        =   0
      Top             =   720
      Width           =   1455
   End
   Begin VB.Label Label2 
      Alignment       =   2  'Center
      BackColor       =   &H8000000E&
      BorderStyle     =   1  'Fixed Single
      Caption         =   "Legend"
      Height          =   405
      Left            =   7080
      TabIndex        =   22
      Top             =   1920
      Width           =   1455
   End
   Begin VB.Label Label1 
      Alignment       =   2  'Center
      BackColor       =   &H8000000E&
      BorderStyle     =   1  'Fixed Single
      Caption         =   "Graph Type"
      Height          =   405
      Left            =   240
      TabIndex        =   21
      Top             =   2040
      Width           =   1215
   End
   Begin VB.Label Label 
      BackColor       =   &H8000000E&
      BorderStyle     =   1  'Fixed Single
      Caption         =   "Num of Choices"
      Height          =   315
      Index           =   1
      Left            =   240
      TabIndex        =   17
      Top             =   300
      Width           =   1230
   End
   Begin VB.Label Label 
      Alignment       =   2  'Center
      BackColor       =   &H8000000E&
      BorderStyle     =   1  'Fixed Single
      Caption         =   "Rankings"
      Height          =   405
      Index           =   0
      Left            =   7080
      TabIndex        =   4
      Top             =   240
      Width           =   1455
   End
End
Attribute VB_Name = "frmCafeteria"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit
Dim Ranking(1 To 1000) As Integer
Dim Tallies(1 To 10) As Integer
Dim Choices(1 To 10) As String
Dim GraphType As Integer
Dim NumChoices As Integer
Dim Tallied As Boolean

Private Sub cmbNumChoices_LostFocus()

NumChoices = Val(cmbNumChoices.Text)

End Sub

Private Sub cmdClear_Click()

Dim x As Integer
cmbNumChoices.Clear
lstRankings.Clear
Erase Tallies()
Call Form_Load
pctGraph.Cls
pctLegend.Cls
For x = 0 To 9
    lblTalley(x).Visible = False
    lblTalley(x).Caption = ""
    lblLegend(x).Visible = False
    lblLegend(x).Caption = ""
Next x
Tallied = False

End Sub

Private Sub cmdExit_Click()

End

End Sub

Private Sub cmdGraphtype_Click(Index As Integer)

If Tallied = True Then
    Dim x As Integer
    Dim y As Integer
    Dim z As Integer
    Dim a As Integer
    Const topedge = 0.7
    Const bottomedge = 0.3
    If NumChoices <> 0 Then
        cmdGraphtype(0).BackColor = &H8000000F
        cmdGraphtype(1).BackColor = &H8000000F
        cmdGraphtype(2).BackColor = &H8000000F
        pctLegend.Scale (0, 0)-(5, NumChoices)
        For y = 1 To NumChoices
                pctLegend.Line (0.25, y - topedge)-(1.5, y - bottomedge), QBColor(y + 4), BF
                lblLegend(y - 1).Visible = True
                lblLegend(y - 1).Left = 1.75
                lblLegend(y - 1).Top = y - topedge
                lblLegend(y - 1).Caption = Choices(y)
        Next y
        'If GraphType = 0 Then
            If cmdGraphtype(0) Then
                pctGraph.Cls
                For x = 0 To 9
                    lblTalley(x).Visible = False
                    lblTalley(x).Caption = ""
                Next x
                If NumChoices = 2 Then
                    pctGraph.Scale (0, 0)-(750, NumChoices)
                Else
                    pctGraph.Scale (0, 0)-(500, NumChoices)
                End If
                For y = 1 To NumChoices
                    lblTalley(y - 1).Visible = True
                    pctGraph.Line (0, y - topedge)-(Tallies(y), (y - bottomedge)), QBColor(y + 4), BF
                    lblTalley(y - 1).Left = (Tallies(y) + 1) + 15
                    lblTalley(y - 1).Top = y - topedge
                    lblTalley(y - 1) = Str$(Tallies(y))
                Next y
    
            ElseIf cmdGraphtype(1) Then
                pctGraph.Cls
                For x = 0 To 9
                    lblTalley(x).Visible = False
                    lblTalley(x).Caption = ""
                Next x
                If NumChoices = 2 Then
                    pctGraph.Scale (NumChoices, 750)-(0, 0)
                Else
                    pctGraph.Scale (NumChoices, 500)-(0, 0)
                End If
                Const leftedge = 0.7
                Const rightedge = 0.3
                For z = 1 To NumChoices
                    lblTalley(z - 1).Visible = True
                    pctGraph.Line (z - leftedge, -500)-(z - rightedge, Tallies(z)), QBColor(z + 4), BF
                    lblTalley(z - 1).Left = z - rightedge
                    lblTalley(z - 1).Top = (Tallies(z) + 1) + 30
                    lblTalley(z - 1) = Str$(Tallies(z))
                Next z
            ElseIf cmdGraphtype(2) Then
                pctGraph.Cls
                For x = 0 To 9
                    lblTalley(x).Visible = False
                    lblTalley(x).Caption = ""
                Next x
                Dim BA, EA As Double
                Dim i As Integer
                Dim Theta, NTheta As Double
                pctGraph.Scale (-10, 10)-(10, -10)
                pctGraph.Circle (0, 0), 8, QBColor(1)
                BA = 0.001

                For i = 1 To NumChoices
                    pctGraph.FillStyle = 0
                    pctGraph.FillColor = QBColor(i + 4)
                    EA = BA + ((Tallies(i) / (Val(txtPeople.Text))) * 6.28)
                    pctGraph.Circle (0, 0), 8, QBColor(i + 4), -BA, -EA
                    'Theta = ((Tallies(i) / 1000) * 360) + ((Tallies(i - 1) / 1000) * 360)
                    'to convert to radians divide by  / 0.01745329
                   
                    lblTalley(i - 1).Visible = True
                    lblTalley(i - 1).Left = 8 * Cos((EA + BA) / 2)
                    lblTalley(i - 1).Top = 8 * (Sin((EA + BA) / 2))
                    lblTalley(i - 1).Caption = Str$(Tallies(i))
                    BA = EA
                Next i
            ElseIf cmdGraphtype(3) Then
                pctGraph.Scale (0, 10)-(1000, 0)
                For a = 1 To Val(txtPeople.Text)
    
                    pctGraph.FillStyle = 0
                    pctGraph.Circle (a, Ranking(a)), 0.25
                Next a
            End If
            cmdGraphtype(Index).BackColor = &H80000010
        'End If
    End If
End If

End Sub

Private Sub cmdTalley_Click()

If NumChoices = 0 Then
    MsgBox ("Please Select Number Of Choices")
Else
        Dim x As Integer
        '-Initialize the tallies
        For x = 1 To 10
            Tallies(x) = 0
        Next x
        Randomize
        For x = 1 To Val(txtPeople.Text)
            Ranking(x) = Int(NumChoices * Rnd) + 1
        Next x
        lstRankings.Clear
        For x = 1 To Val(txtPeople.Text)
            lstRankings.AddItem Str(x) & Chr(9) & Str(Ranking(x))
            Tallies(Ranking(x)) = Tallies(Ranking(x)) + 1
        Next x
        Tallied = True
End If

End Sub

Private Sub Form_Load()
GraphType = 0
NumChoices = 0
Dim x As Integer
For x = 2 To 10
    cmbNumChoices.AddItem (Str(x))
Next x
Choices(1) = "Hamburger"
Choices(2) = "Corn Dog"
Choices(3) = "Hot Dog"
Choices(4) = "Sandwich"
Choices(5) = "Wings"
Choices(6) = "Salad"
Choices(7) = "Wrap"
Choices(8) = "Pizza"
Choices(9) = "Tacos"
Choices(10) = "Pasta"
cmdGraphtype(0).BackColor = &H8000000F
cmdGraphtype(1).BackColor = &H8000000F
cmdGraphtype(2).BackColor = &H8000000F
cmdGraphtype(3).BackColor = &H8000000F

End Sub
