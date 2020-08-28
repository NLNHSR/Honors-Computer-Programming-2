Attribute VB_Name = "modEmployee"
Option Explicit

Type Employee
    FN As String
    LN As String
    Age As Integer
    PayKind As String
    Salary As Single
    Dependants As Integer
End Type

Global arrEmployees(100) As Employee
Global Entry As Integer
Global Current As Integer
Global Current2 As Integer
Global i As Integer
Global Filename As String
Global Path As String
Global EmployeeName As String

'Save as = done
'Save = done
'Open = done
'Delete = done
'Add = done
'Change = done
'View- All = done
'View- Individual = done
'Search = done

