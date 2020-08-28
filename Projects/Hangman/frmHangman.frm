VERSION 5.00
Begin VB.Form frmHangman 
   BackColor       =   &H00E0E0E0&
   Caption         =   "Form1"
   ClientHeight    =   9585
   ClientLeft      =   120
   ClientTop       =   465
   ClientWidth     =   10530
   LinkTopic       =   "Form1"
   ScaleHeight     =   9585
   ScaleWidth      =   10530
   StartUpPosition =   3  'Windows Default
   Begin VB.Timer Timer3 
      Interval        =   1000
      Left            =   13320
      Top             =   1920
   End
   Begin VB.Timer Timer2 
      Interval        =   100
      Left            =   12240
      Top             =   2040
   End
   Begin VB.Timer Timer1 
      Interval        =   250
      Left            =   12720
      Top             =   2040
   End
   Begin VB.Timer Timer 
      Interval        =   500
      Left            =   12840
      Top             =   1260
   End
   Begin VB.CommandButton cmdQuit 
      Caption         =   "Quit"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   14.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   435
      Left            =   9000
      TabIndex        =   40
      Top             =   6360
      Width           =   795
   End
   Begin VB.ComboBox cmbDifficulty 
      Height          =   315
      Left            =   660
      Style           =   2  'Dropdown List
      TabIndex        =   38
      Top             =   5760
      Width           =   1995
   End
   Begin VB.ListBox lstWSF 
      Height          =   1815
      Left            =   12120
      TabIndex        =   32
      Top             =   2760
      Width           =   1455
   End
   Begin VB.ListBox lstLetters 
      Height          =   1815
      Left            =   10680
      TabIndex        =   31
      Top             =   2760
      Width           =   1335
   End
   Begin VB.CommandButton cmdLetter 
      BackColor       =   &H80000005&
      Caption         =   "B"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   14.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   500
      Index           =   26
      Left            =   1380
      TabIndex        =   28
      Top             =   7785
      Width           =   500
   End
   Begin VB.CommandButton cmdLetter 
      Caption         =   "C"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   14.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   500
      Index           =   25
      Left            =   2100
      TabIndex        =   27
      Top             =   7785
      Width           =   500
   End
   Begin VB.CommandButton cmdLetter 
      Caption         =   "D"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   14.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   500
      Index           =   24
      Left            =   2820
      TabIndex        =   26
      Top             =   7785
      Width           =   500
   End
   Begin VB.CommandButton cmdLetter 
      Caption         =   "E"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   14.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   500
      Index           =   23
      Left            =   3540
      TabIndex        =   25
      Top             =   7785
      Width           =   500
   End
   Begin VB.CommandButton cmdLetter 
      Caption         =   "F"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   14.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   500
      Index           =   22
      Left            =   4260
      TabIndex        =   24
      Top             =   7785
      Width           =   500
   End
   Begin VB.CommandButton cmdLetter 
      Caption         =   "G"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   14.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   500
      Index           =   21
      Left            =   4980
      TabIndex        =   23
      Top             =   7785
      Width           =   500
   End
   Begin VB.CommandButton cmdLetter 
      Caption         =   "H"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   14.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   500
      Index           =   20
      Left            =   5700
      TabIndex        =   22
      Top             =   7785
      Width           =   500
   End
   Begin VB.CommandButton cmdLetter 
      Caption         =   "I"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   14.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   500
      Index           =   19
      Left            =   6420
      TabIndex        =   21
      Top             =   7785
      Width           =   500
   End
   Begin VB.CommandButton cmdLetter 
      Caption         =   "J"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   14.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   500
      Index           =   18
      Left            =   7140
      TabIndex        =   20
      Top             =   7785
      Width           =   500
   End
   Begin VB.CommandButton cmdLetter 
      Caption         =   "K"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   14.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   500
      Index           =   17
      Left            =   7860
      TabIndex        =   19
      Top             =   7785
      Width           =   500
   End
   Begin VB.CommandButton cmdLetter 
      Caption         =   "L"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   14.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   500
      Index           =   16
      Left            =   8580
      TabIndex        =   18
      Top             =   7785
      Width           =   500
   End
   Begin VB.CommandButton cmdLetter 
      Caption         =   "N"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   14.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   500
      Index           =   15
      Left            =   660
      TabIndex        =   17
      Top             =   8505
      Width           =   500
   End
   Begin VB.CommandButton cmdLetter 
      Caption         =   "O"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   14.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   500
      Index           =   14
      Left            =   1380
      TabIndex        =   16
      Top             =   8505
      Width           =   500
   End
   Begin VB.CommandButton cmdLetter 
      Caption         =   "P"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   14.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   500
      Index           =   13
      Left            =   2100
      TabIndex        =   15
      Top             =   8505
      Width           =   500
   End
   Begin VB.CommandButton cmdLetter 
      Caption         =   "Q"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   14.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   500
      Index           =   12
      Left            =   2820
      TabIndex        =   14
      Top             =   8505
      Width           =   500
   End
   Begin VB.CommandButton cmdLetter 
      Caption         =   "R"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   14.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   500
      Index           =   11
      Left            =   3540
      TabIndex        =   13
      Top             =   8505
      Width           =   500
   End
   Begin VB.CommandButton cmdLetter 
      Caption         =   "S"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   14.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   500
      Index           =   10
      Left            =   4260
      TabIndex        =   12
      Top             =   8505
      Width           =   500
   End
   Begin VB.CommandButton cmdLetter 
      Caption         =   "T"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   14.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   500
      Index           =   9
      Left            =   4980
      TabIndex        =   11
      Top             =   8505
      Width           =   500
   End
   Begin VB.CommandButton cmdLetter 
      Caption         =   "U"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   14.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   500
      Index           =   8
      Left            =   5700
      TabIndex        =   10
      Top             =   8505
      Width           =   500
   End
   Begin VB.CommandButton cmdLetter 
      Caption         =   "V"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   14.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   500
      Index           =   7
      Left            =   6420
      TabIndex        =   9
      Top             =   8505
      Width           =   500
   End
   Begin VB.CommandButton cmdLetter 
      Caption         =   "W"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   14.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   500
      Index           =   6
      Left            =   7140
      TabIndex        =   8
      Top             =   8505
      Width           =   500
   End
   Begin VB.CommandButton cmdLetter 
      Caption         =   "X"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   14.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   500
      Index           =   5
      Left            =   7860
      TabIndex        =   7
      Top             =   8505
      Width           =   500
   End
   Begin VB.CommandButton cmdLetter 
      Caption         =   "Y"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   14.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   500
      Index           =   4
      Left            =   8580
      TabIndex        =   6
      Top             =   8505
      Width           =   500
   End
   Begin VB.CommandButton cmdLetter 
      Caption         =   "M"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   14.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   500
      Index           =   3
      Left            =   9300
      TabIndex        =   5
      Top             =   7785
      Width           =   500
   End
   Begin VB.CommandButton cmdLetter 
      Caption         =   "Z"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   14.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   500
      Index           =   2
      Left            =   9300
      TabIndex        =   4
      Top             =   8505
      Width           =   500
   End
   Begin VB.CommandButton cmdLetter 
      BackColor       =   &H80000005&
      Caption         =   "A"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   14.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   500
      Index           =   1
      Left            =   660
      TabIndex        =   3
      Top             =   7785
      Width           =   500
   End
   Begin VB.CommandButton cmdGenerate 
      Caption         =   "New Word"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   14.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   435
      Left            =   7860
      TabIndex        =   1
      Top             =   6960
      Width           =   1935
   End
   Begin VB.ListBox lstwords 
      Height          =   2205
      Left            =   10680
      TabIndex        =   0
      Top             =   480
      Width           =   1335
   End
   Begin VB.Label lblTime 
      BorderStyle     =   1  'Fixed Single
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   13.5
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   615
      Left            =   720
      TabIndex        =   44
      Top             =   1320
      Width           =   1215
   End
   Begin VB.Label lblLose 
      Alignment       =   2  'Center
      BackColor       =   &H0000FFFF&
      BorderStyle     =   1  'Fixed Single
      Caption         =   "YOU LOSE!"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   17.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   495
      Left            =   4140
      TabIndex        =   35
      Top             =   2340
      Visible         =   0   'False
      Width           =   3255
   End
   Begin VB.Label lblAnswer 
      Alignment       =   2  'Center
      BorderStyle     =   1  'Fixed Single
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   12
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   405
      Left            =   4140
      TabIndex        =   42
      Top             =   3480
      Visible         =   0   'False
      Width           =   3255
   End
   Begin VB.Label lblAnswerWas 
      Alignment       =   2  'Center
      BorderStyle     =   1  'Fixed Single
      Caption         =   "The word was:"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   14.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   435
      Left            =   4140
      TabIndex        =   41
      Top             =   2940
      Visible         =   0   'False
      Width           =   3255
   End
   Begin VB.Label lblWin 
      Alignment       =   2  'Center
      BackColor       =   &H0000FFFF&
      BorderStyle     =   1  'Fixed Single
      Caption         =   "YOU WIN!"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   18
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   510
      Left            =   4140
      TabIndex        =   36
      Top             =   2340
      Visible         =   0   'False
      Width           =   3225
   End
   Begin VB.Image Crush5 
      Height          =   1800
      Left            =   4200
      Picture         =   "frmHangman.frx":0000
      Stretch         =   -1  'True
      Top             =   5640
      Visible         =   0   'False
      Width           =   3400
   End
   Begin VB.Image Crush4 
      Height          =   1800
      Left            =   4200
      Picture         =   "frmHangman.frx":524B
      Stretch         =   -1  'True
      Top             =   5640
      Visible         =   0   'False
      Width           =   3400
   End
   Begin VB.Image Crush3 
      Height          =   1800
      Left            =   4200
      Picture         =   "frmHangman.frx":A9B2
      Stretch         =   -1  'True
      Top             =   5640
      Visible         =   0   'False
      Width           =   3405
   End
   Begin VB.Image Crush2 
      Height          =   1800
      Left            =   4200
      Picture         =   "frmHangman.frx":100B6
      Stretch         =   -1  'True
      Top             =   5640
      Visible         =   0   'False
      Width           =   3405
   End
   Begin VB.Image Crush1 
      Height          =   1800
      Left            =   4200
      Picture         =   "frmHangman.frx":1581D
      Stretch         =   -1  'True
      Top             =   5640
      Width           =   3400
   End
   Begin VB.Image imgSad 
      Height          =   765
      Left            =   5460
      Picture         =   "frmHangman.frx":1AA68
      Stretch         =   -1  'True
      Top             =   4380
      Visible         =   0   'False
      Width           =   765
   End
   Begin VB.Image imgSmile 
      Height          =   765
      Left            =   5460
      Picture         =   "frmHangman.frx":204B8
      Stretch         =   -1  'True
      Top             =   4380
      Width           =   765
   End
   Begin VB.Image img16 
      Height          =   900
      Left            =   5460
      Picture         =   "frmHangman.frx":25F29
      Stretch         =   -1  'True
      Top             =   2460
      Width           =   795
   End
   Begin VB.Image img46 
      Height          =   900
      Left            =   5460
      Picture         =   "frmHangman.frx":28C33
      Stretch         =   -1  'True
      Top             =   2460
      Visible         =   0   'False
      Width           =   795
   End
   Begin VB.Image img36 
      Height          =   900
      Left            =   5460
      Picture         =   "frmHangman.frx":2B75C
      Stretch         =   -1  'True
      Top             =   2460
      Visible         =   0   'False
      Width           =   795
   End
   Begin VB.Image img26 
      Height          =   900
      Left            =   5460
      Picture         =   "frmHangman.frx":2E39B
      Stretch         =   -1  'True
      Top             =   2460
      Visible         =   0   'False
      Width           =   795
   End
   Begin VB.Image img15 
      Height          =   900
      Left            =   6300
      Picture         =   "frmHangman.frx":310A2
      Stretch         =   -1  'True
      Top             =   2760
      Width           =   795
   End
   Begin VB.Image img45 
      Height          =   900
      Left            =   6300
      Picture         =   "frmHangman.frx":33DAC
      Stretch         =   -1  'True
      Top             =   2760
      Visible         =   0   'False
      Width           =   795
   End
   Begin VB.Image img35 
      Height          =   900
      Left            =   6300
      Picture         =   "frmHangman.frx":368D5
      Stretch         =   -1  'True
      Top             =   2760
      Visible         =   0   'False
      Width           =   795
   End
   Begin VB.Image img25 
      Height          =   900
      Left            =   6300
      Picture         =   "frmHangman.frx":39514
      Stretch         =   -1  'True
      Top             =   2760
      Visible         =   0   'False
      Width           =   795
   End
   Begin VB.Image img14 
      Height          =   900
      Left            =   4620
      Picture         =   "frmHangman.frx":3C21B
      Stretch         =   -1  'True
      Top             =   2760
      Width           =   800
   End
   Begin VB.Image img44 
      Height          =   900
      Left            =   4620
      Picture         =   "frmHangman.frx":3EF25
      Stretch         =   -1  'True
      Top             =   2760
      Visible         =   0   'False
      Width           =   795
   End
   Begin VB.Image img34 
      Height          =   900
      Left            =   4620
      Picture         =   "frmHangman.frx":41A4E
      Stretch         =   -1  'True
      Top             =   2760
      Visible         =   0   'False
      Width           =   795
   End
   Begin VB.Image img24 
      Height          =   900
      Left            =   4620
      Picture         =   "frmHangman.frx":4468D
      Stretch         =   -1  'True
      Top             =   2760
      Visible         =   0   'False
      Width           =   795
   End
   Begin VB.Image img13 
      Height          =   900
      Left            =   6420
      Picture         =   "frmHangman.frx":47394
      Stretch         =   -1  'True
      Top             =   1680
      Width           =   800
   End
   Begin VB.Image img43 
      Height          =   900
      Left            =   6420
      Picture         =   "frmHangman.frx":4A09E
      Stretch         =   -1  'True
      Top             =   1680
      Visible         =   0   'False
      Width           =   795
   End
   Begin VB.Image img33 
      Height          =   900
      Left            =   6420
      Picture         =   "frmHangman.frx":4CBC7
      Stretch         =   -1  'True
      Top             =   1680
      Visible         =   0   'False
      Width           =   795
   End
   Begin VB.Image img23 
      Height          =   900
      Left            =   6420
      Picture         =   "frmHangman.frx":4F806
      Stretch         =   -1  'True
      Top             =   1680
      Visible         =   0   'False
      Width           =   795
   End
   Begin VB.Image img12 
      Height          =   900
      Left            =   5460
      Picture         =   "frmHangman.frx":5250D
      Stretch         =   -1  'True
      Top             =   1320
      Width           =   795
   End
   Begin VB.Image img42 
      Height          =   900
      Left            =   5460
      Picture         =   "frmHangman.frx":55217
      Stretch         =   -1  'True
      Top             =   1320
      Visible         =   0   'False
      Width           =   795
   End
   Begin VB.Image img32 
      Height          =   900
      Left            =   5460
      Picture         =   "frmHangman.frx":57D40
      Stretch         =   -1  'True
      Top             =   1320
      Visible         =   0   'False
      Width           =   795
   End
   Begin VB.Image img22 
      Height          =   900
      Left            =   5460
      Picture         =   "frmHangman.frx":5A97F
      Stretch         =   -1  'True
      Top             =   1320
      Visible         =   0   'False
      Width           =   795
   End
   Begin VB.Image img1 
      Height          =   900
      Left            =   4500
      Picture         =   "frmHangman.frx":5D686
      Stretch         =   -1  'True
      Top             =   1680
      Width           =   795
   End
   Begin VB.Image img4 
      Height          =   900
      Left            =   4500
      Picture         =   "frmHangman.frx":60390
      Stretch         =   -1  'True
      Top             =   1680
      Visible         =   0   'False
      Width           =   795
   End
   Begin VB.Image img3 
      Height          =   900
      Left            =   4500
      Picture         =   "frmHangman.frx":62EB9
      Stretch         =   -1  'True
      Top             =   1680
      Visible         =   0   'False
      Width           =   795
   End
   Begin VB.Image img2 
      Height          =   900
      Left            =   4500
      Picture         =   "frmHangman.frx":65AF8
      Stretch         =   -1  'True
      Top             =   1680
      Visible         =   0   'False
      Width           =   795
   End
   Begin VB.Label Label 
      Alignment       =   2  'Center
      BorderStyle     =   1  'Fixed Single
      Caption         =   "Hangman!"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   27.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   795
      Index           =   2
      Left            =   660
      TabIndex        =   43
      Top             =   240
      Width           =   5775
   End
   Begin VB.Label Label 
      Alignment       =   2  'Center
      BorderStyle     =   1  'Fixed Single
      Caption         =   "Difficulty"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   14.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Index           =   1
      Left            =   660
      TabIndex        =   39
      Top             =   5280
      Width           =   2055
   End
   Begin VB.Label Label 
      Alignment       =   2  'Center
      BorderStyle     =   1  'Fixed Single
      Caption         =   "Lives"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   14.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Index           =   0
      Left            =   8040
      TabIndex        =   37
      Top             =   240
      Width           =   915
   End
   Begin VB.Label lblLives 
      Alignment       =   2  'Center
      BorderStyle     =   1  'Fixed Single
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   15
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   435
      Left            =   9120
      TabIndex        =   34
      Top             =   240
      Width           =   735
   End
   Begin VB.Label lblLetter 
      BorderStyle     =   1  'Fixed Single
      Height          =   495
      Left            =   12120
      TabIndex        =   33
      Top             =   1200
      Width           =   555
   End
   Begin VB.Label Label1 
      Alignment       =   2  'Center
      BackStyle       =   0  'Transparent
      BorderStyle     =   1  'Fixed Single
      Caption         =   "Word So Far"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   14.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   435
      Left            =   660
      TabIndex        =   30
      Top             =   6300
      Width           =   2055
   End
   Begin VB.Label lblWSF 
      Alignment       =   2  'Center
      BorderStyle     =   1  'Fixed Single
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   14.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   510
      Left            =   660
      TabIndex        =   29
      Top             =   6900
      Width           =   3465
   End
   Begin VB.Label lblRandWord 
      BorderStyle     =   1  'Fixed Single
      Height          =   555
      Left            =   12120
      TabIndex        =   2
      Top             =   480
      Width           =   1515
   End
   Begin VB.Line line6 
      BorderWidth     =   3
      X1              =   5820
      X2              =   5820
      Y1              =   3000
      Y2              =   4320
   End
   Begin VB.Line line5 
      BorderWidth     =   3
      X1              =   5820
      X2              =   6660
      Y1              =   4380
      Y2              =   3300
   End
   Begin VB.Line line4 
      BorderWidth     =   3
      X1              =   4980
      X2              =   5820
      Y1              =   3360
      Y2              =   4380
   End
   Begin VB.Line line3 
      BorderWidth     =   3
      X1              =   6900
      X2              =   5820
      Y1              =   2100
      Y2              =   4380
   End
   Begin VB.Line line2 
      BorderWidth     =   3
      X1              =   5820
      X2              =   5820
      Y1              =   1920
      Y2              =   3060
   End
   Begin VB.Line line1 
      BorderWidth     =   3
      X1              =   4980
      X2              =   5820
      Y1              =   2280
      Y2              =   4320
   End
End
Attribute VB_Name = "frmHangman"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit
Dim ArrayWords(58112), ArrayLettersPicked(26), ArrayLetters(26), ArrayWSF(26), Path, Strline, RandWord, WSF, Letter, Difficulty As String
Dim i, RandNum As Long
Dim picked, correct, test, img1pop, img2pop, img3pop, img4pop, img5pop, img6pop, play As Boolean
Dim x, y, z, Lives, check, time As Integer

Private Sub cmbDifficulty_LostFocus()

If cmbDifficulty.ListIndex = 0 Then
    Difficulty = "Easy"
ElseIf cmbDifficulty.ListIndex = 1 Then
    Difficulty = "Medium"
ElseIf cmbDifficulty.ListIndex = 2 Then
    Difficulty = "Hard"
End If

End Sub

'RULES:
'Play hangman -COMPLETE
'Do not allow user to choose same letter -COMPLETE
'Extra credit is using a control array to store used letters -COMPLETE
'Extra credit Genres(Easy-short words, Medium-medium words, Hard-long words) -COMPLETE
'Extra credit is adding animations
'Add answer streak(not in rubric or extra credit)
'Hints
'still need to code for third balloon to pop(farthest left), already added first variable, still need to add second local one


Private Sub cmdGenerate_Click()

If time <> 0 Or lblLose.Visible = True Then
    If Difficulty <> "" Then
        Randomize
        lstLetters.Clear
        lstWSF.Clear
        RandNum = Int((58112 * Rnd) + 1)
        RandWord = UCase(ArrayWords(RandNum))
        If Difficulty = "Easy" Then
            Do Until Len(RandWord) >= 16
                    RandNum = Int((58112 * Rnd) + 1)
                    RandWord = UCase(ArrayWords(RandNum))
            Loop
        ElseIf Difficulty = "Medium" Then
            Do Until Len(RandWord) >= 9 And Len(RandWord) <= 15
                    RandNum = Int((58112 * Rnd) + 1)
                    RandWord = UCase(ArrayWords(RandNum))
            Loop
        ElseIf Difficulty = "Hard" Then
            Do Until Len(RandWord) <= 8
                RandNum = Int((58112 * Rnd) + 1)
                RandWord = UCase(ArrayWords(RandNum))
            Loop
        End If
        lblRandWord.Caption = RandWord
        time = 100
        play = True
        Lives = 6
    End If
    For i = 1 To 26
        cmdLetter(i).BackColor = &H80000005
    Next i
    picked = False
    x = 0
    lblLives.Caption = Lives
    correct = True
    Erase ArrayLettersPicked
    lblLose.Visible = False
    lblWin.Visible = False
    check = 0
    z = 0
    lblAnswer.Visible = False
    lblAnswerWas.Visible = False
    img1.Visible = True
    img4.Visible = False
    img12.Visible = True
    img42.Visible = False
    img13.Visible = True
    img43.Visible = False
    img14.Visible = True
    img44.Visible = False
    img15.Visible = True
    img45.Visible = False
    img16.Visible = True
    img46.Visible = False
    img1pop = False
    img2pop = False
    img3pop = False
    img4pop = False
    img5pop = False
    img6pop = False
    line1.Visible = True
    line2.Visible = True
    line3.Visible = True
    line4.Visible = True
    line5.Visible = True
    line6.Visible = True
    imgSmile.Visible = True
    imgSad.Visible = False
End If

End Sub

Private Sub cmdLetter_Click(Index As Integer)

If time <> 0 Then
    If RandWord <> "" Then
        For y = 1 To 2
            If lblWin.Visible = False Then
                If Lives <> 0 Then
                    correct = True
                    Letter = Trim(cmdLetter(Index).Caption)
                    picked = False
                    For i = 0 To 26
                        If ArrayLettersPicked(i) = Letter Then
                            picked = True
                        End If
                    Next i
                    If picked = False Then
                        lblLetter.Caption = Letter
                        For i = 0 To 26
                            If ArrayLetters(i) <> Letter Then
                                cmdLetter(Index).BackColor = &HFF&
                                cmdLetter(Index).BackColor = &HFF&
                                correct = False
                            End If
                        Next i
                        For i = 0 To 26
                            If ArrayLetters(i) = Letter Then
                                    If InStr(1, RandWord, Letter, 1) <> 0 Then
                                        ArrayWSF(i) = Letter
                                        cmdLetter(Index).BackColor = &HFF00&
                                        cmdLetter(Index).BackColor = &HFF00&
                                        correct = True
                                    End If
                            End If
                        Next i
                        If correct = False Then
                            Lives = Lives - 1
                            lblLives.Caption = Lives
                        End If
                        WSF = ""
                        lstWSF.Clear
                        For i = 1 To Len(RandWord)
                            WSF = WSF & ArrayWSF(i)
                            lstWSF.AddItem (ArrayWSF(i))
                        Next i
                        lblWSF.Caption = WSF
                        x = x + 1
                        ArrayLettersPicked(x) = Letter
            
                    End If
                    If WSF = RandWord Then
                        lblWin.Visible = True
                    End If
                Else
                    lblLose.Visible = True
                    lblAnswerWas.Visible = True
                    lblAnswer.Visible = True
                    lblAnswer.Caption = RandWord
                End If
            End If
        Next y
    End If
End If

End Sub

Private Sub cmdQuit_Click()

End

End Sub

Private Sub Form_Load()

Path = "D:\19 S1 NS CP2\Hangman\Dictionary.txt"
i = 1
Open Path For Input As #1
Do While Not EOF(1)
    Line Input #1, Strline
    ArrayWords(i) = Strline
    lstwords.AddItem (ArrayWords(i))
    i = i + 1
Loop
Close #1
cmbDifficulty.AddItem ("Easy")
cmbDifficulty.AddItem ("Medium")
cmbDifficulty.AddItem ("Hard")
time = 100
play = False

End Sub

Private Sub lblLives_Change()

If lblLives.Caption = "5" Then
    img1pop = True
ElseIf lblLives.Caption = "4" Then
    img2pop = True
ElseIf lblLives.Caption = "3" Then
    img3pop = True
ElseIf lblLives.Caption = "2" Then
    img4pop = True
ElseIf lblLives.Caption = "1" Then
    img5pop = True
ElseIf lblLives.Caption = "0" Then
    img6pop = True
End If


End Sub

Private Sub lblRandWord_Change()

Dim i As Long
For i = 1 To Len(RandWord)
    ArrayLetters(i) = Mid(RandWord, i, 1)
    ArrayWSF(i) = "-"
    lstLetters.AddItem (ArrayLetters(i))
    lstWSF.AddItem (ArrayWSF(i))
Next i

WSF = ""
For i = 1 To Len(RandWord)
    WSF = WSF & ArrayWSF(i)
Next i
lblWSF.Caption = WSF

End Sub

Private Sub Timer_Timer()

If lblLose.Visible = True Then
    imgSad.Visible = True
    imgSmile.Visible = False
End If

Dim img1stop, img2stop, img3stop, img4stop, img5stop, img6stop As Boolean

If img1pop = True Then
    img1stop = False
    If img1stop = False Then
        If img1.Visible = True Then
            img2.Visible = True
            img1.Visible = False
        ElseIf img2.Visible = True Then
            img3.Visible = True
            img2.Visible = False
        ElseIf img3.Visible = True Then
            img4.Visible = True
            img3.Visible = False
            line1.Visible = False
        ElseIf img4.Visible = True Then
            img1stop = True
        End If
    End If
End If

If img2pop = True Then
    img2stop = False
    If img2stop = False Then
        If img12.Visible = True Then
            img22.Visible = True
            img12.Visible = False
        ElseIf img22.Visible = True Then
            img32.Visible = True
            img22.Visible = False
        ElseIf img32.Visible = True Then
            img42.Visible = True
            img32.Visible = False
            line2.Visible = False
        ElseIf img42.Visible = True Then
            img2stop = True
        End If
    End If
End If


If img3pop = True Then
    img3stop = False
    If img3stop = False Then
        If img13.Visible = True Then
            img23.Visible = True
            img13.Visible = False
        ElseIf img23.Visible = True Then
            img33.Visible = True
            img23.Visible = False
        ElseIf img33.Visible = True Then
            img43.Visible = True
            img33.Visible = False
            line3.Visible = False
        ElseIf img43.Visible = True Then
            img3stop = True
        End If
    End If
End If


If img4pop = True Then
    img4stop = False
    If img4stop = False Then
        If img14.Visible = True Then
            img24.Visible = True
            img14.Visible = False
        ElseIf img24.Visible = True Then
            img34.Visible = True
            img24.Visible = False
        ElseIf img34.Visible = True Then
            img44.Visible = True
            img34.Visible = False
            line4.Visible = False
        ElseIf img44.Visible = True Then
            img4stop = True
        End If
    End If
End If


If img5pop = True Then
    img5stop = False
    If img5stop = False Then
        If img15.Visible = True Then
            img25.Visible = True
            img15.Visible = False
        ElseIf img25.Visible = True Then
            img35.Visible = True
            img25.Visible = False
        ElseIf img35.Visible = True Then
            img45.Visible = True
            img35.Visible = False
            line5.Visible = False
        ElseIf img45.Visible = True Then
            img5stop = True
        End If
    End If
End If


If img6pop = True Then
    img6stop = False
    If img6stop = False Then
        If img16.Visible = True Then
            img26.Visible = True
            img16.Visible = False
        ElseIf img26.Visible = True Then
            img36.Visible = True
            img26.Visible = False
        ElseIf img36.Visible = True Then
            img46.Visible = True
            img36.Visible = False
            line6.Visible = False
        ElseIf img46.Visible = True Then
            img6stop = True
        End If
    End If
End If


End Sub

Private Sub Timer1_Timer()

If Crush1.Visible = True Then
    Crush1.Visible = False
    Crush2.Visible = True
ElseIf Crush2.Visible = True Then
    Crush2.Visible = False
    Crush3.Visible = True
ElseIf Crush3.Visible = True Then
    Crush3.Visible = False
    Crush4.Visible = True
ElseIf Crush4.Visible = True Then
    Crush4.Visible = False
    Crush1.Visible = True
End If

End Sub

Private Sub Timer2_Timer()

If lblLose.BackColor = &HFFFF& Then
    lblLose.BackColor = &HFF&
ElseIf lblLose.BackColor = &HFF& Then
    lblLose.BackColor = &HFFFF&
End If

If lblWin.BackColor = &HFFFF& Then
    lblWin.BackColor = &HFF&
ElseIf lblWin.BackColor = &HFF& Then
    lblWin.BackColor = &HFFFF&
End If

End Sub

Private Sub Timer3_Timer()

If lblLose.Visible = False Then
    If lblWin.Visible = False Then
        If play = True Then
            If time <> 0 Then
                time = time - 1
                lblTime.Caption = time
            End If
            If time = 0 Then
                lblLose.Visible = True
            End If
        End If
    End If
End If

End Sub
