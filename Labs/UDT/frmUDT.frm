VERSION 5.00
Begin VB.Form frmUDT 
   Caption         =   "UDT"
   ClientHeight    =   5520
   ClientLeft      =   120
   ClientTop       =   465
   ClientWidth     =   11520
   LinkTopic       =   "Form1"
   ScaleHeight     =   5520
   ScaleWidth      =   11520
   StartUpPosition =   3  'Windows Default
   Begin VB.CommandButton cmdmostexp 
      Caption         =   "Most expensive"
      Height          =   495
      Left            =   600
      TabIndex        =   3
      Top             =   3300
      Width           =   1275
   End
   Begin VB.ListBox lstcountries 
      Height          =   3375
      Left            =   6960
      TabIndex        =   2
      Top             =   900
      Width           =   2175
   End
   Begin VB.CommandButton cmdFill 
      Caption         =   "Fill"
      Height          =   735
      Left            =   960
      TabIndex        =   1
      Top             =   840
      Width           =   1335
   End
   Begin VB.ListBox lstflags 
      Height          =   3375
      Left            =   4380
      TabIndex        =   0
      Top             =   900
      Width           =   1935
   End
   Begin VB.Label lblmostexp 
      BackColor       =   &H8000000E&
      BorderStyle     =   1  'Fixed Single
      Height          =   555
      Left            =   2100
      TabIndex        =   4
      Top             =   3300
      Width           =   1275
   End
End
Attribute VB_Name = "frmUDT"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit

Private Sub cmdFill_Click()

i = 1
Randomize
For i = 1 To 10
With arrayflags(i)
    .ns = Int(Rnd * 25) + 1
    .price = (Int(Rnd * 2250) + 750) / 100
    .country = arraycountries(Int(Rnd * 17) + 1)
    lstflags.AddItem .country
    lstflags.AddItem .ns
    lstflags.AddItem .price
End With
Next i

End Sub

Private Sub cmdmostexp_Click()

Dim p As Single
Dim location As Integer
p = arrayflags(1).price
For i = 2 To 10
    If arrayflags(i).price > p Then
        p = arrayflags(i).price
        location = i
    End If
Next i
lblmostexp.Caption = arrayflags(location).country + "    " + Str(arrayflags(location).ns) + "   " + Str(arrayflags(location).price)

End Sub

Private Sub Form_Load()
Dim strline As String
i = 1
Open "C:\Users\neel.shettigar\Downloads\flagcountries.txt" For Input As #1
Do While Not EOF(1)
    Line Input #1, strline
    arraycountries(i) = strline
    lstcountries.AddItem (arraycountries(i))
    i = i + 1
Loop

End Sub
