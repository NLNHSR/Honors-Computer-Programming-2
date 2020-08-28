VERSION 5.00
Begin VB.Form frmGraphingCalculator 
   AutoRedraw      =   -1  'True
   Caption         =   "Form1"
   ClientHeight    =   6570
   ClientLeft      =   120
   ClientTop       =   465
   ClientWidth     =   12510
   LinkTopic       =   "Form1"
   ScaleHeight     =   6570
   ScaleWidth      =   12510
   StartUpPosition =   3  'Windows Default
   Begin VB.CommandButton cmdColor 
      BackColor       =   &H0000FFFF&
      Height          =   300
      Index           =   3
      Left            =   3600
      Style           =   1  'Graphical
      TabIndex        =   41
      Top             =   1080
      Width           =   300
   End
   Begin VB.CommandButton cmdColor 
      BackColor       =   &H00FF0000&
      Height          =   300
      Index           =   2
      Left            =   3240
      Style           =   1  'Graphical
      TabIndex        =   40
      Top             =   1080
      Width           =   300
   End
   Begin VB.CommandButton cmdColor 
      BackColor       =   &H0000FF00&
      Height          =   300
      Index           =   1
      Left            =   2760
      Style           =   1  'Graphical
      TabIndex        =   39
      Top             =   1080
      Width           =   300
   End
   Begin VB.CommandButton cmdColor 
      BackColor       =   &H000000FF&
      Height          =   300
      Index           =   0
      Left            =   2400
      Style           =   1  'Graphical
      TabIndex        =   38
      Top             =   1080
      Width           =   300
   End
   Begin VB.ListBox lstIntersections 
      Height          =   450
      Left            =   10680
      TabIndex        =   31
      Top             =   2040
      Width           =   1455
   End
   Begin VB.CommandButton cmdDrawtype 
      BackColor       =   &H8000000E&
      Caption         =   "Triangle"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   300
      Index           =   4
      Left            =   2400
      MaskColor       =   &H00FFFFFF&
      Style           =   1  'Graphical
      TabIndex        =   30
      Top             =   360
      Width           =   1500
   End
   Begin VB.CommandButton cmdIntersection 
      BackColor       =   &H8000000E&
      Caption         =   "Intersection(s)"
      Height          =   495
      Left            =   10680
      Style           =   1  'Graphical
      TabIndex        =   29
      Top             =   1320
      Width           =   1455
   End
   Begin VB.CommandButton cmdGraph 
      BackColor       =   &H8000000E&
      Caption         =   "Graph"
      Height          =   255
      Left            =   1560
      MaskColor       =   &H00FFFFFF&
      Style           =   1  'Graphical
      TabIndex        =   28
      Top             =   5400
      Width           =   1500
   End
   Begin VB.CommandButton cmdInputType 
      BackColor       =   &H8000000E&
      Caption         =   "Enter Points"
      Height          =   300
      Index           =   1
      Left            =   2400
      MaskColor       =   &H00FFFFFF&
      Style           =   1  'Graphical
      TabIndex        =   27
      Top             =   1560
      Width           =   1500
   End
   Begin VB.CommandButton cmdInputType 
      BackColor       =   &H8000000E&
      Caption         =   "Click On Graph"
      Height          =   300
      Index           =   0
      Left            =   800
      MaskColor       =   &H00FFFFFF&
      Style           =   1  'Graphical
      TabIndex        =   26
      Top             =   1560
      Width           =   1500
   End
   Begin VB.TextBox txtY22 
      Alignment       =   2  'Center
      Height          =   285
      Left            =   2400
      TabIndex        =   23
      Top             =   4920
      Width           =   1500
   End
   Begin VB.TextBox txtX22 
      Alignment       =   2  'Center
      Height          =   285
      Left            =   800
      TabIndex        =   22
      Top             =   4920
      Width           =   1500
   End
   Begin VB.TextBox txtY12 
      Alignment       =   2  'Center
      Height          =   285
      Left            =   2400
      TabIndex        =   21
      Top             =   4080
      Width           =   1500
   End
   Begin VB.TextBox txtX12 
      Alignment       =   2  'Center
      Height          =   285
      Left            =   800
      TabIndex        =   20
      Top             =   4080
      Width           =   1500
   End
   Begin VB.TextBox txtY2 
      Alignment       =   2  'Center
      Height          =   285
      Left            =   2400
      TabIndex        =   15
      Top             =   3240
      Width           =   1500
   End
   Begin VB.TextBox txtX2 
      Alignment       =   2  'Center
      Height          =   285
      Left            =   800
      TabIndex        =   14
      Top             =   3240
      Width           =   1500
   End
   Begin VB.TextBox txtY1 
      Alignment       =   2  'Center
      Height          =   285
      Left            =   2400
      TabIndex        =   11
      Top             =   2400
      Width           =   1500
   End
   Begin VB.TextBox txtX1 
      Alignment       =   2  'Center
      Height          =   285
      Left            =   800
      TabIndex        =   10
      Top             =   2400
      Width           =   1500
   End
   Begin VB.CommandButton cmdDrawtype 
      BackColor       =   &H8000000E&
      Caption         =   "Box"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   300
      Index           =   3
      Left            =   2400
      MaskColor       =   &H00FFFFFF&
      Style           =   1  'Graphical
      TabIndex        =   7
      Top             =   720
      Width           =   1500
   End
   Begin VB.CommandButton cmdDrawtype 
      BackColor       =   &H8000000E&
      Caption         =   "Circle"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   300
      Index           =   2
      Left            =   800
      MaskColor       =   &H00FFFFFF&
      Style           =   1  'Graphical
      TabIndex        =   6
      Top             =   1080
      Width           =   1500
   End
   Begin VB.CommandButton cmdDrawtype 
      BackColor       =   &H8000000E&
      Caption         =   "Line"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   300
      Index           =   1
      Left            =   800
      MaskColor       =   &H00FFFFFF&
      Style           =   1  'Graphical
      TabIndex        =   5
      Top             =   720
      Width           =   1500
   End
   Begin VB.CommandButton cmdDrawtype 
      BackColor       =   &H8000000E&
      Caption         =   "Parabola"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   300
      Index           =   0
      Left            =   800
      MaskColor       =   &H00FFFFFF&
      Style           =   1  'Graphical
      TabIndex        =   4
      Top             =   360
      Width           =   1500
   End
   Begin VB.CommandButton cmdQuit 
      BackColor       =   &H8000000E&
      Caption         =   "Quit"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   250
      Left            =   2400
      Style           =   1  'Graphical
      TabIndex        =   3
      Top             =   6120
      Width           =   1500
   End
   Begin VB.CommandButton cmdClear 
      BackColor       =   &H8000000E&
      Caption         =   "Clear"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   250
      Left            =   800
      Style           =   1  'Graphical
      TabIndex        =   2
      Top             =   6120
      Width           =   1500
   End
   Begin VB.PictureBox pic1 
      BackColor       =   &H8000000E&
      Height          =   6000
      Left            =   4320
      ScaleHeight     =   10
      ScaleMode       =   0  'User
      ScaleWidth      =   10
      TabIndex        =   0
      Top             =   360
      Width           =   6000
      Begin VB.Label lblPint2 
         AutoSize        =   -1  'True
         BackColor       =   &H8000000E&
         Height          =   195
         Left            =   360
         TabIndex        =   37
         Top             =   2040
         Width           =   45
      End
      Begin VB.Label lblPInt 
         AutoSize        =   -1  'True
         BackColor       =   &H8000000E&
         Height          =   195
         Left            =   360
         TabIndex        =   36
         Top             =   1440
         Width           =   45
      End
      Begin VB.Label lblP4 
         AutoSize        =   -1  'True
         BackColor       =   &H8000000E&
         Height          =   195
         Left            =   360
         TabIndex        =   35
         Top             =   960
         Width           =   45
      End
      Begin VB.Label lblP3 
         AutoSize        =   -1  'True
         BackColor       =   &H8000000E&
         Height          =   195
         Left            =   240
         TabIndex        =   34
         Top             =   360
         Width           =   45
      End
      Begin VB.Label lblP2 
         AutoSize        =   -1  'True
         BackColor       =   &H8000000E&
         Height          =   195
         Left            =   360
         TabIndex        =   33
         Top             =   120
         Width           =   45
      End
      Begin VB.Label lblP1 
         AutoSize        =   -1  'True
         BackColor       =   &H8000000E&
         Height          =   195
         Left            =   120
         TabIndex        =   32
         Top             =   240
         Width           =   45
      End
   End
   Begin VB.Label Label9 
      Alignment       =   2  'Center
      BackColor       =   &H8000000E&
      BorderStyle     =   1  'Fixed Single
      Caption         =   "(X1,Y1)=P1(Center/Vertex), (X2,Y2)=P2"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   255
      Left            =   840
      TabIndex        =   25
      Top             =   5760
      Width           =   3135
   End
   Begin VB.Label Label11 
      Alignment       =   2  'Center
      BackColor       =   &H8000000E&
      BorderStyle     =   1  'Fixed Single
      Caption         =   "Current Position"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   255
      Left            =   10680
      TabIndex        =   24
      Top             =   360
      Width           =   1500
   End
   Begin VB.Label Label8 
      Alignment       =   2  'Center
      BackColor       =   &H8000000E&
      BorderStyle     =   1  'Fixed Single
      Caption         =   "Y2"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   255
      Left            =   2400
      TabIndex        =   19
      Top             =   4560
      Width           =   1500
   End
   Begin VB.Label Label7 
      Alignment       =   2  'Center
      BackColor       =   &H8000000E&
      BorderStyle     =   1  'Fixed Single
      Caption         =   "X2"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   255
      Left            =   795
      TabIndex        =   18
      Top             =   4560
      Width           =   1500
   End
   Begin VB.Label Label6 
      Alignment       =   2  'Center
      BackColor       =   &H8000000E&
      BorderStyle     =   1  'Fixed Single
      Caption         =   "Y1"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   255
      Left            =   2400
      TabIndex        =   17
      Top             =   3720
      Width           =   1500
   End
   Begin VB.Label Label5 
      Alignment       =   2  'Center
      BackColor       =   &H8000000E&
      BorderStyle     =   1  'Fixed Single
      Caption         =   "X1"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   255
      Left            =   795
      TabIndex        =   16
      Top             =   3720
      Width           =   1500
   End
   Begin VB.Label Label4 
      Alignment       =   2  'Center
      BackColor       =   &H8000000E&
      BorderStyle     =   1  'Fixed Single
      Caption         =   "Y2"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   255
      Left            =   2400
      TabIndex        =   13
      Top             =   2880
      Width           =   1500
   End
   Begin VB.Label Label3 
      Alignment       =   2  'Center
      BackColor       =   &H8000000E&
      BorderStyle     =   1  'Fixed Single
      Caption         =   "X2"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   255
      Left            =   795
      TabIndex        =   12
      Top             =   2880
      Width           =   1500
   End
   Begin VB.Label Label2 
      Alignment       =   2  'Center
      BackColor       =   &H8000000E&
      BorderStyle     =   1  'Fixed Single
      Caption         =   "Y1"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   255
      Left            =   2400
      TabIndex        =   9
      Top             =   2040
      Width           =   1500
   End
   Begin VB.Label Label1 
      Alignment       =   2  'Center
      BackColor       =   &H8000000E&
      BorderStyle     =   1  'Fixed Single
      Caption         =   "X1"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   255
      Left            =   795
      TabIndex        =   8
      Top             =   2040
      Width           =   1500
   End
   Begin VB.Label lblPosition 
      BackColor       =   &H8000000E&
      BorderStyle     =   1  'Fixed Single
      Height          =   495
      Left            =   10680
      TabIndex        =   1
      Top             =   720
      Width           =   1500
   End
End
Attribute VB_Name = "frmGraphingCalculator"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit
Dim click, Drawtype, NumGraphs, Graph1, Graph2, R, G, B As Integer
Dim a, i, X1, Y1, X2, Y2, X12, Y12, X22, Y22, PointY As Single

'Due next monday
'Five extra credit points to get A+
'Textboxes as input(Extra Credit)(1)
'Extra drawtypes/graphics(Color)(Extra Credit)(2)
'Points of intersection(Extra Credit)(1 point for every intersection)

Private Sub cmdClear_Click()

pic1.Cls
Call Form_Activate

End Sub

Private Sub cmdColor_Click(Index As Integer)

If Index = 0 Then
    R = 255
    G = 0
    B = 0
ElseIf Index = 1 Then
    R = 0
    G = 255
    B = 0
ElseIf Index = 2 Then
    R = 0
    G = 0
    B = 255
ElseIf Index = 3 Then
    R = 255
    G = 255
    B = 0
End If

    

End Sub

Private Sub cmdDrawtype_Click(Index As Integer)

If NumGraphs <> 2 Then
    If Index = 0 Then
        Drawtype = 1
        cmdDrawtype(0).BackColor = &H8000000A
    ElseIf Index = 1 Then
        Drawtype = 2
        cmdDrawtype(1).BackColor = &H8000000A
    ElseIf Index = 2 Then
        Drawtype = 3
        cmdDrawtype(2).BackColor = &H8000000A
    ElseIf Index = 3 Then
        Drawtype = 4
        cmdDrawtype(3).BackColor = &H8000000A
    ElseIf Index = 4 Then
        Drawtype = 5
        cmdDrawtype(4).BackColor = &H8000000A
    End If
    If NumGraphs = 0 Then
        Graph1 = Drawtype
    ElseIf NumGraphs = 1 Then
        Graph2 = Drawtype
    End If
End If
        
End Sub

Private Sub cmdGraph_Click()

If NumGraphs <> 2 Then
    If Drawtype = 0 Then
        MsgBox ("Select Graph Type")
    Else
        If click = 1 Then
            If txtX1.Text <> "" And txtY1.Text <> "" And txtX2.Text <> "" And txtY2.Text <> "" Then
                X1 = Val(txtX1.Text)
                Y1 = Val(txtY1.Text)
                X2 = Val(txtX2.Text)
                Y2 = Val(txtY2.Text)
                pic1.Circle (X1, Y1), 0.25, vbGreen
                pic1.Circle (X2, Y2), 0.25, vbRed
                If Drawtype = 1 Then
                    Call funcParabola
                ElseIf Drawtype = 2 Then
                    Call funcLine
                ElseIf Drawtype = 3 Then
                    Call funcCircle
                ElseIf Drawtype = 4 Then
                    Call funcBox
                ElseIf Drawtype = 5 Then
                    Call funcTriangle
                End If
            Else
                MsgBox ("Please Enter Points")
            End If
            click = 3
        ElseIf click = 3 Then
            If txtX12.Text <> "" And txtY12.Text <> "" And txtX22.Text <> "" And txtY22.Text <> "" Then
                X12 = Val(txtX12.Text)
                Y12 = Val(txtY12.Text)
                X22 = Val(txtX22.Text)
                Y22 = Val(txtY22.Text)
                pic1.Circle (X12, Y12), 0.25, vbGreen
                pic1.Circle (X22, Y22), 0.25, vbRed
                If Drawtype = 1 Then
                    Call funcParabola
                ElseIf Drawtype = 2 Then
                    Call funcLine
                ElseIf Drawtype = 3 Then
                    Call funcCircle
                ElseIf Drawtype = 4 Then
                    Call funcBox
                ElseIf Drawtype = 5 Then
                    Call funcTriangle
                End If
            Else
                MsgBox ("Please Enter Points")
            End If
        End If
    End If
End If

End Sub

Private Sub cmdInputType_Click(Index As Integer)

If NumGraphs <> 2 Then
    If Drawtype = 0 Then
        MsgBox ("Select Graph Type")
    Else
        If NumGraphs <> 2 Then
            If cmdInputType(0) Then
                pic1.Enabled = True
                txtX1.Enabled = False
                txtY1.Enabled = False
                txtX2.Enabled = False
                txtY2.Enabled = False
                txtX12.Enabled = False
                txtY12.Enabled = False
                txtX22.Enabled = False
                txtY22.Enabled = False
                cmdInputType(0).BackColor = &H8000000A
                cmdInputType(1).BackColor = &H8000000E
            ElseIf cmdInputType(1) Then
                If click = 1 Then
                    txtX1.Enabled = True
                    txtY1.Enabled = True
                    txtX2.Enabled = True
                    txtY2.Enabled = True
                End If
                If click = 3 Then
                    txtX12.Enabled = True
                    txtY12.Enabled = True
                    txtX22.Enabled = True
                    txtY22.Enabled = True
                End If
                cmdInputType(0).BackColor = &H8000000E
                cmdInputType(1).BackColor = &H8000000A
            End If
        End If
    End If
End If

End Sub

Private Sub cmdIntersection_Click()
'1 = parabola
'2 = line
'3 = circle
'4 = box
'5 = triangle

Dim xint, xint2, yint, yint2, a2, B, b2, m, m2 As Single
If Graph1 = 1 And Graph2 = 2 Then 'parabola is x1,y1-vertex and line is x12,y12-x22,y22
    m = (Y22 - Y12) / (X22 - X12)
    a = (Y2 - Y1) / ((X2 - X1) ^ 2)
    B = Y12 - (m * X12)
    If (((4 * a * m * X1) + (4 * a * B) + (m ^ 2) - 4 * a * Y1)) < 0 Then
        lstIntersections.AddItem ("No Intersection")
    Else
        xint = ((2 * a * X1) + m + (((4 * a * m * X1) + (4 * a * B) + (m ^ 2) - 4 * a * Y1) ^ (1 / 2))) / (2 * a)
        xint2 = ((2 * a * X1) + m - (((4 * a * m * X1) + (4 * a * B) + (m ^ 2) - 4 * a * Y1) ^ (1 / 2))) / (2 * a)
        yint = (m * xint) + B
        yint2 = (m * xint2) + B
        pic1.Circle (xint, yint), 0.25, vbBlue
        pic1.Circle (xint2, yint2), 0.25, vbBlue
        lblPInt.Visible = True
        lblPInt.Left = xint + 0.25
        lblPInt.Top = yint - 0.25
        lblPInt = Format(xint, "Fixed") + "," + Format(yint, "Fixed")
        lblPint2.Visible = True
        lblPint2.Left = xint2 + 0.25
        lblPint2.Top = yint2 - 0.25
        lblPint2 = Format(xint2, "Fixed") + "," + Format(yint2, "Fixed")
        lstIntersections.AddItem ("x: " & Round(xint, 3) & ", " & "y: " & Round(yint, 3))
        lstIntersections.AddItem ("x: " & Round(xint2, 3) & ", " & "y: " & Round(yint2, 3))
    End If
End If
If Graph1 = 2 And Graph2 = 1 Then 'parabola is x12,y12-vertex and line is x1,y1-x2,y2
    m = (Y2 - Y1) / (X2 - X1)
    a = (Y22 - Y12) / ((X22 - X12) ^ 2)
    B = Y1 - (m * X1)
    If (((4 * a * m * X12) + (4 * a * B) + (m ^ 2) - 4 * a * Y12)) < 0 Then
        lstIntersections.AddItem ("No Intersection")
    Else
        xint = ((2 * a * X12) + m + (((4 * a * m * X12) + (4 * a * B) + (m ^ 2) - 4 * a * Y12) ^ (1 / 2))) / (2 * a)
        xint2 = ((2 * a * X12) + m - (((4 * a * m * X12) + (4 * a * B) + (m ^ 2) - 4 * a * Y12) ^ (1 / 2))) / (2 * a)
        yint = (m * xint) + B
        yint2 = (m * xint2) + B
        pic1.Circle (xint, yint), 0.25, vbBlue
        pic1.Circle (xint2, yint2), 0.25, vbBlue
        lblPInt.Visible = True
        lblPInt.Left = xint + 0.25
        lblPInt.Top = yint - 0.25
        lblPInt = Format(xint, "Fixed") + "," + Format(yint, "Fixed")
        lblPint2.Visible = True
        lblPint2.Left = xint2 + 0.25
        lblPint2.Top = yint2 - 0.25
        lblPint2 = Format(xint2, "Fixed") + "," + Format(yint2, "Fixed")
        lstIntersections.AddItem ("x: " & Round(xint, 3) & ", " & "y: " & Round(yint, 3))
        lstIntersections.AddItem ("x: " & Round(xint2, 3) & ", " & "y: " & Round(yint2, 3))
    End If
End If

If Graph1 = 1 And Graph2 = 1 Then 'Parabola and Parabola
    a = (Y2 - Y1) / ((X2 - X1) ^ 2)
    a2 = (Y22 - Y12) / ((X22 - X12) ^ 2)
    If ((Y1 * a2) + (a * a2 * (X1 ^ 2)) + (a * (X12 ^ 2) * a2) - (Y12 * a2) - (2 * a * X12 * a2 * X1) + (a * Y12) - (a * Y1)) < 0 Then
        lstIntersections.AddItem ("No Intersection")
    Else
        xint = ((a * X1) - (X12 * a2) + (((Y1 * a2) + (a * a2 * (X1 ^ 2)) + (a * (X12 ^ 2) * a2) - (Y12 * a2) - (2 * a * X12 * a2 * X1) + (a * Y12) - (a * Y1)) ^ (1 / 2))) / (a - a2)
        xint2 = ((a * X1) - (X12 * a2) - (((Y1 * a2) + (a * a2 * (X1 ^ 2)) + (a * (X12 ^ 2) * a2) - (Y12 * a2) - (2 * a * X12 * a2 * X1) + (a * Y12) - (a * Y1)) ^ (1 / 2))) / (a - a2)
        yint = a * ((xint - X1) ^ 2) + Y1
        yint2 = a * ((xint2 - X1) ^ 2) + Y1
        pic1.Circle (xint, yint), 0.25, vbBlue
        pic1.Circle (xint2, yint2), 0.25, vbBlue
        lblPInt.Visible = True
        lblPInt.Left = xint + 0.25
        lblPInt.Top = yint - 0.25
        lblPInt = Format(xint, "Fixed") + "," + Format(yint, "Fixed")
        lblPint2.Visible = True
        lblPint2.Left = xint2 + 0.25
        lblPint2.Top = yint2 - 0.25
        lblPint2 = Format(xint2, "Fixed") + "," + Format(yint2, "Fixed")
        lstIntersections.AddItem ("x: " & Round(xint, 3) & ", " & "y: " & Round(yint, 3))
        lstIntersections.AddItem ("x: " & Round(xint2, 3) & ", " & "y: " & Round(yint2, 3))
    End If
End If

If Graph1 = 2 And Graph2 = 2 Then 'line and line
    m = (Y2 - Y1) / (X2 - X1)
    m2 = (Y22 - Y12) / (X22 - X12)
    B = Y1 - (m * X1)
    b2 = Y12 - (m2 * X12)
    If m = m2 And B <> b2 Then
        lstIntersections.AddItem ("Paralel Lines")
        lstIntersections.AddItem ("No Intersection")
    ElseIf m = m2 And B = b2 Then
        lstIntersections.AddItem ("Same Line")
        lstIntersections.AddItem ("Infinite Intersections")
    ElseIf m <> m2 And B <> b2 Then
        xint = (b2 - B) / (m - m2)
        yint = (m * xint) + B
        pic1.Circle (xint, yint), 0.25, vbBlue
        lblPInt.Visible = True
        lblPInt.Left = xint + 0.25
        lblPInt.Top = yint - 0.25
        lblPInt = Format(xint, "Fixed") + "," + Format(yint, "Fixed")
        lstIntersections.AddItem ("x: " & Round(xint, 3) & ", " & "y: " & Round(yint, 3))
    End If
End If
    

End Sub

Private Sub cmdQuit_Click()

End

End Sub

Private Sub Form_Activate()

lblP1.Visible = False
lblP2.Visible = False
lblP3.Visible = False
lblP4.Visible = False
lblPInt.Visible = False
lblPint2.Visible = False
pic1.Enabled = False
pic1.Scale (-10, 10)-(10, -10)
click = 1
For i = -10 To 10
    pic1.Line (i, -10)-(i, 10), &H80000016
    pic1.Line (-10, i)-(10, i), &H80000016
Next i
pic1.Line (0, 10)-(0, -10)
pic1.Line (-10, 0)-(10, 0)
For i = -10 To 10
    pic1.Line (i, 0.5)-(i, -0.5), vbRed
    pic1.Line (0.5, i)-(-0.5, i), vbRed
Next i
For i = -10 To 10 Step 0.5
    If i Mod 2 = 0 Then
        pic1.Line (i, 0.25)-(i, -0.25), vbBlue
        pic1.Line (0.25, i)-(-0.25, i), vbBlue
    End If
Next i
Graph1 = 5
Graph1 = 5
cmdDrawtype(0).BackColor = &H8000000E
cmdDrawtype(1).BackColor = &H8000000E
cmdDrawtype(2).BackColor = &H8000000E
cmdDrawtype(3).BackColor = &H8000000E
cmdInputType(0).BackColor = &H8000000E
cmdInputType(1).BackColor = &H8000000E
Drawtype = 0
NumGraphs = 0
txtX1.Text = ""
txtY1.Text = ""
txtX2.Text = ""
txtY2.Text = ""
txtX12.Text = ""
txtY12.Text = ""
txtX22.Text = ""
txtY22.Text = ""
txtX1.Enabled = False
txtY1.Enabled = False
txtX2.Enabled = False
txtY2.Enabled = False
txtX12.Enabled = False
txtY12.Enabled = False
txtX22.Enabled = False
txtY22.Enabled = False
lstIntersections.Clear
lblP1.Caption = ""
lblP2.Caption = ""
lblP3.Caption = ""
lblP4.Caption = ""
lblPInt.Caption = ""
lblPint2.Caption = ""
R = 0
G = 0
B = 0

End Sub

Private Sub pic1_MouseDown(Button As Integer, Shift As Integer, X As Single, Y As Single)

If NumGraphs <> 2 Then
    If click = 1 Then
        If Drawtype = 0 Then
            MsgBox ("Select Graph Type")
        Else
            X1 = X
            Y1 = Y
            txtX1.Text = X1
            txtY1.Text = Y1
            click = 2
            lblP1.Visible = True
            lblP1.Left = X1 + 0.25
            lblP1.Top = Y1 - 0.25
            lblP1 = Format(X1, "Fixed") + "," + Format(Y1, "Fixed")
        End If
        pic1.Circle (X1, Y1), 0.25, vbGreen
    ElseIf click = 2 Then
        X2 = X
        Y2 = Y
        txtX2.Text = X2
        txtY2.Text = Y2
        lblP2.Visible = True
        lblP2.Left = X2 + 0.25
        lblP2.Top = Y2 - 0.25
        lblP2 = Format(X2, "Fixed") + "," + Format(Y2, "Fixed")
        pic1.Circle (X2, Y2), 0.25, vbRed
        If Drawtype = 1 Then
            Call funcParabola
        ElseIf Drawtype = 2 Then
            Call funcLine
        ElseIf Drawtype = 3 Then
            Call funcCircle
        ElseIf Drawtype = 4 Then
            Call funcBox
        ElseIf Drawtype = 5 Then
            Call funcTriangle
        End If
        click = 3
        pic1.Enabled = False
    ElseIf click = 3 Then
        If Drawtype = 0 Then
            MsgBox ("Select a graph")
        Else
            X12 = X
            Y12 = Y
            txtX12.Text = X12
            txtY12.Text = Y12
            click = 4
            lblP3.Visible = True
            lblP3.Left = X12 + 0.25
            lblP3.Top = Y12 - 0.25
            lblP3 = Format(X12, "Fixed") + "," + Format(Y12, "Fixed")
        End If
        pic1.Circle (X12, Y12), 0.25, vbGreen
    ElseIf click = 4 Then
        X22 = X
        Y22 = Y
        txtX22.Text = X22
        txtY22.Text = Y22
        lblP4.Visible = True
        lblP4.Left = X22 + 0.25
        lblP4.Top = Y22 - 0.25
        lblP4 = Format(X22, "Fixed") + "," + Format(Y22, "Fixed")
        pic1.Circle (X22, Y22), 0.25, vbRed
        If Drawtype = 1 Then
            Call funcParabola
        ElseIf Drawtype = 2 Then
            Call funcLine
        ElseIf Drawtype = 3 Then
            Call funcCircle
        ElseIf Drawtype = 4 Then
            Call funcBox
        ElseIf Drawtype = 5 Then
            Call funcTriangle
        End If
        click = 5
    End If
End If

End Sub

Private Sub pic1_MouseMove(Button As Integer, Shift As Integer, X As Single, Y As Single)

lblPosition.Caption = "( " & Round(X, 2) & " , " & Round(Y, 4) & " )"

End Sub


Public Function funcParabola()

cmdInputType(0).BackColor = &H8000000E
cmdInputType(1).BackColor = &H8000000E
cmdDrawtype(0).BackColor = &H8000000E
NumGraphs = NumGraphs + 1
If click = 2 Or click = 1 Then
    a = (Y2 - Y1) / ((X2 - X1) ^ 2)
        For i = -10 To 10 Step 0.001
            PointY = a * ((i - X1) ^ 2) + Y1
            pic1.Circle (i, PointY), 0.0025, RGB(R, G, B)
        Next i
ElseIf click = 4 Or click = 3 Then
    a = (Y22 - Y12) / ((X22 - X12) ^ 2)
        For i = -10 To 10 Step 0.001
            PointY = a * ((i - X12) ^ 2) + Y12
            pic1.Circle (i, PointY), 0.0025, RGB(R, G, B)
        Next i
End If
Drawtype = 0
R = 0
G = 0
B = 0

End Function

Public Function funcLine()

cmdInputType(0).BackColor = &H8000000E
cmdInputType(1).BackColor = &H8000000E
cmdDrawtype(1).BackColor = &H8000000E
NumGraphs = NumGraphs + 1
If click = 2 Or click = 1 Then
    pic1.Line ((X1 - (X2 - X1) * 100), (Y1 - (Y2 - Y1) * 100))-((X2 + (X2 - X1) * 100), (Y2 + (Y2 - Y1) * 100)), RGB(R, G, B)
ElseIf click = 4 Or click = 3 Then
    pic1.Line ((X12 - (X22 - X12) * 100), (Y12 - (Y22 - Y12) * 100))-((X22 + (X22 - X12) * 100), (Y22 + (Y22 - Y12) * 100)), RGB(R, G, B)
End If
Drawtype = 0
R = 0
G = 0
B = 0

End Function

Public Function funcCircle()

cmdInputType(0).BackColor = &H8000000E
cmdInputType(1).BackColor = &H8000000E
cmdDrawtype(2).BackColor = &H8000000E
NumGraphs = NumGraphs + 1
If click = 2 Or click = 1 Then
    pic1.Circle (X1, Y1), (((((X2 - X1) ^ 2) + ((Y2 - Y1) ^ 2))) ^ (1 / 2)), RGB(R, G, B)
ElseIf click = 4 Or click = 3 Then
    pic1.Circle (X12, Y12), (((((X22 - X12) ^ 2) + ((Y22 - Y12) ^ 2))) ^ (1 / 2)), RGB(R, G, B)
End If
Drawtype = 0
R = 0
G = 0
B = 0

End Function

Public Function funcBox()

cmdInputType(0).BackColor = &H8000000E
cmdInputType(1).BackColor = &H8000000E
cmdDrawtype(3).BackColor = &H8000000E
NumGraphs = NumGraphs + 1
If click = 2 Or click = 1 Then
    pic1.Line (X1, Y1)-(X2, Y2), RGB(R, G, B), B
ElseIf click = 4 Or click = 3 Then
    pic1.Line (X12, Y12)-(X22, Y22), RGB(R, G, B), B
End If
Drawtype = 0
R = 0
G = 0
B = 0

End Function


Public Function funcTriangle()

cmdInputType(0).BackColor = &H8000000E
cmdInputType(1).BackColor = &H8000000E
cmdDrawtype(4).BackColor = &H8000000E
NumGraphs = NumGraphs + 1
If click = 2 Or click = 1 Then
    pic1.Line (X1, Y1)-(X2, Y2), RGB(R, G, B)
    pic1.Line (X1, Y1)-((X1 - (X2 - X1)), Y2), RGB(R, G, B)
    pic1.Line ((X1 - (X2 - X1)), Y2)-(X2, Y2), RGB(R, G, B)
 
ElseIf click = 4 Or click = 3 Then
    pic1.Line (X12, Y12)-(X22, Y22), RGB(R, G, B)
    pic1.Line (X12, Y12)-((X12 - (X22 - X12)), Y22), RGB(R, G, B)
    pic1.Line ((X12 - (X22 - X12)), Y22)-(X22, Y22), RGB(R, G, B)
End If
Drawtype = 0
R = 0
G = 0
B = 0

End Function
