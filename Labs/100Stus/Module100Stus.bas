Attribute VB_Name = "Module1"
Option Explicit

Type Students
    FN As String
    LN As String
    GL As Integer
    T1 As Integer
    T2 As Integer
    T3 As Integer
    GPA As Single
    ID As Long
End Type

Global Students(100) As Students
Global FirstNames(100) As String
Global LastNames(100) As String
Global i, x As Integer
Global strline As String
Global GPA As Single
Global max As Single
Global Entry As Integer
Global Filename As String
Global Path As String
Global Current As Integer


