Public Class frmInventory
    Dim i As Integer
    Dim VIN As String
    Dim Engine(3) As RadioButton
    Dim Transmission(3) As RadioButton
    Dim DriveTrain(3) As RadioButton
    Dim Color(3) As RadioButton
    Dim Features(12) As CheckBox
    Dim arrCars(25) As String
    Dim name As String
    Dim path As String
    Dim entry As Integer
    Dim count As Integer
    Private Sub FrmInventory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbYear.Items.Add("2018")
        cmbYear.Items.Add("2019")
        cmbYear.Items.Add("2020")
        cmbCondition.Items.Add("New")
        cmbCondition.Items.Add("Fair")
        cmbCondition.Items.Add("Poor")
        cmbCompany.Items.Add("Audi")
        cmbCompany.Items.Add("BMW")
        cmbCompany.Items.Add("Mercedes")
        VIN = ""
        picA1.Visible = False
        picA2.Visible = False
        picA3.Visible = False
        picB1.Visible = False
        picB2.Visible = False
        picB3.Visible = False
        picM1.Visible = False
        picM2.Visible = False
        picM3.Visible = False
        SetControlArrays()
        entry = -1
        count = -1
    End Sub
    Sub SetControlArrays()
        Engine(1) = rbV8
        Engine(2) = rbV10
        Engine(3) = rbV12
        Transmission(1) = rbAuto
        Transmission(2) = rbDual
        Transmission(3) = rbManual
        DriveTrain(1) = rbFront
        DriveTrain(2) = rbBack
        DriveTrain(3) = rbAll
        Color(1) = rbBlack
        Color(2) = rbRed
        Color(3) = rbWhite
        Features(1) = cb1
        Features(2) = cb2
        Features(3) = cb3
        Features(4) = cb4
        Features(5) = cb5
        Features(6) = cb6
        Features(7) = cb7
        Features(8) = cb8
        Features(9) = cb9
        Features(10) = cb10
        Features(11) = cb11
        Features(12) = cb12
    End Sub
    Private Sub CompressToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CompressToolStripMenuItem.Click
        Call Compress()
    End Sub

    Private Sub CmbCompany_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbCompany.SelectedIndexChanged
        If cmbCompany.Text = "Audi" Then
            cmbModel.Items.Clear()
            cmbModel.Items.Add("Audi A6")
            cmbModel.Items.Add("Audi Q7")
            cmbModel.Items.Add("Audi R8")
        ElseIf cmbCompany.Text = "BMW" Then
            cmbModel.Items.Clear()
            cmbModel.Items.Add("BMW GT6")
            cmbModel.Items.Add("BMW X7")
            cmbModel.Items.Add("BMW I8")
        ElseIf cmbCompany.Text = "Mercedes" Then
            cmbModel.Items.Clear()
            cmbModel.Items.Add("Mercedes AMG")
            cmbModel.Items.Add("Mercedes C-Class")
            cmbModel.Items.Add("Mercedes GLC")
        End If
    End Sub

    Private Sub AddToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddToolStripMenuItem.Click
        lblVIN.Text = ""
        entry = entry + 1
        count = count + 1
        arrCars(entry) = VIN
        lstOutput.Items.Clear()
        For i = 0 To count
            lstOutput.Items.Add(arrCars(i))
        Next
        'lstOutput.Items.Add(VIN)
    End Sub

    Private Sub lstOutput_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstOutput.SelectedIndexChanged
        lblVIN.Text = ""
        VIN = lstOutput.SelectedItem
        lblVIN.Text = (VIN)
        entry = lstOutput.SelectedIndex
    End Sub

    Private Sub DeleteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteToolStripMenuItem.Click
        For i = entry To count
            arrCars(i) = arrCars(i + 1)
        Next
        count = count - 1
        lstOutput.Items.Clear()
        For i = 0 To count
            lstOutput.Items.Add(arrCars(i))
        Next
        'lstOutput.Items.Remove(lstOutput.SelectedItem)
    End Sub

    Private Sub ChangeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChangeToolStripMenuItem.Click
        Call Compress()
        arrCars(entry) = VIN
        lstOutput.Items.Clear()
        For i = 0 To count
            lstOutput.Items.Add(arrCars(i))
            'lstOutput.Items.Item(lstOutput.SelectedIndex) = VIN
        Next i
        lblVIN.Text = ""
    End Sub
    Private Function Compress() As String
        lblVIN.Text = ""
        VIN = ""
        If cmbYear.Text = "2018" Then
            VIN = VIN & "18"
        ElseIf cmbYear.Text = "2019" Then
            VIN = VIN & "19"
        ElseIf cmbYear.Text = "2020" Then
            VIN = VIN & "20"
        End If
        If cmbCondition.Text = "New" Then
            VIN = VIN & "N"
        ElseIf cmbCondition.Text = "Fair" Then
            VIN = VIN & "F"
        ElseIf cmbCondition.Text = "Poor" Then
            VIN = VIN & "P"
        End If
        If cmbCompany.Text = "Audi" Then
            VIN = VIN & "A"
        ElseIf cmbCompany.Text = "BMW" Then
            VIN = VIN & "B"
        ElseIf cmbCompany.Text = "Mercedes" Then
            VIN = VIN & "M"
        End If
        If cmbModel.Text = "Audi A6" Or cmbModel.Text = "BMW GT6" Or cmbModel.Text = "Mercedes AMG" Then
            VIN = VIN & "1"
        ElseIf cmbModel.Text = "Audi Q7" Or cmbModel.Text = "BMW X7" Or cmbModel.Text = "Mercedes C-Class" Then
            VIN = VIN & "2"
        ElseIf cmbModel.Text = "Audi R8" Or cmbModel.Text = "BMW I8" Or cmbModel.Text = "Mercedes GLC" Then
            VIN = VIN & "3"
        End If
        For i = 1 To 3
            If Engine(i).Checked = True Then
                'VIN = VIN & Str(i)
                If i = 1 Then
                    VIN = VIN & "1"
                ElseIf i = 2 Then
                    VIN = VIN & "2"
                ElseIf i = 3 Then
                    VIN = VIN & "3"
                End If
            End If
        Next
        For i = 1 To 3
            If Transmission(i).Checked = True Then
                'VIN = VIN & Str(i)
                If i = 1 Then
                    VIN = VIN & "1"
                ElseIf i = 2 Then
                    VIN = VIN & "2"
                ElseIf i = 3 Then
                    VIN = VIN & "3"
                End If
            End If
        Next
        For i = 1 To 3
            If DriveTrain(i).Checked = True Then
                'VIN = VIN & Str(i)
                If i = 1 Then
                    VIN = VIN & "1"
                ElseIf i = 2 Then
                    VIN = VIN & "2"
                ElseIf i = 3 Then
                    VIN = VIN & "3"
                End If
            End If
        Next
        For i = 1 To 3
            If Color(i).Checked = True Then
                'VIN = VIN & Str(i)
                If i = 1 Then
                    VIN = VIN & "1"
                ElseIf i = 2 Then
                    VIN = VIN & "2"
                ElseIf i = 3 Then
                    VIN = VIN & "3"
                End If
            End If
        Next
        For i = 1 To 12
            If Features(i).Checked = True Then
                VIN = VIN & "1"
            Else
                VIN = VIN & "0"
            End If
        Next
        lblVIN.Text = VIN
        cmbYear.Items.Clear()
        cmbCompany.Items.Clear()
        cmbCondition.Items.Clear()
        cmbModel.Items.Clear()
        cmbYear.Text = ""
        cmbCompany.Text = ""
        cmbCondition.Text = ""
        cmbModel.Text = ""
        rbV8.Checked = False
        rbV10.Checked = False
        rbV12.Checked = False
        rbAuto.Checked = False
        rbBack.Checked = False
        rbFront.Checked = False
        rbManual.Checked = False
        rbDual.Checked = False
        rbAuto.Checked = False
        rbBack.Checked = False
        rbWhite.Checked = False
        rbRed.Checked = False
        cb1.Checked = False
        cb2.Checked = False
        cb3.Checked = False
        cb4.Checked = False
        cb5.Checked = False
        cb6.Checked = False
        cb7.Checked = False
        cb8.Checked = False
        cb9.Checked = False
        cb10.Checked = False
        cb11.Checked = False
        cb12.Checked = False
        cmbYear.Items.Add("2018")
        cmbYear.Items.Add("2019")
        cmbYear.Items.Add("2020")
        cmbCondition.Items.Add("New")
        cmbCondition.Items.Add("Fair")
        cmbCondition.Items.Add("Poor")
        cmbCompany.Items.Add("Audi")
        cmbCompany.Items.Add("BMW")
        cmbCompany.Items.Add("Mercedes")
        picA1.Visible = False
        picA2.Visible = False
        picA3.Visible = False
        picB1.Visible = False
        picB2.Visible = False
        picB3.Visible = False
        picM1.Visible = False
        picM2.Visible = False
        picM3.Visible = False
        Return VIN
    End Function
    Private Sub SaveAsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveAsToolStripMenuItem.Click
        name = InputBox("File Name?", "Save As")
        'path = "C:\Users\naresh_shettigar\Desktop\VB6\Inventory\" & Trim(name) & ".txt"
        path = "C:\Users\neel.shettigar\Desktop\prjInventory\InventoryFiles\" & Trim(name) & ".txt"
        FileOpen(1, path, OpenMode.Output)
        For i = 0 To count
            'PrintLine(1, lstOutput.Items.Item(i))
            PrintLine(1, arrCars(i))
        Next
        FileClose(1)
    End Sub

    Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click
        lstOutput.Items.Clear()
        name = InputBox("File Name?", "Open File")
        'path = "C:\Users\naresh_shettigar\Desktop\VB6\Inventory\" & Trim(name) & ".txt"
        path = "C:\Users\neel.shettigar\Desktop\prjInventory\InventoryFiles\" & Trim(name) & ".txt"
        FileOpen(1, path, OpenMode.Input)
        Dim temp As String
        entry = -1
        count = -1
        i = -1
        Do While Not EOF(1)
            i = i + 1
            temp = LineInput(1)
            'lstOutput.Items.Add(temp)
            arrCars(i) = temp
            entry = entry + 1
            count = count + 1
        Loop
        FileClose(1)
        For i = 0 To count
            lstOutput.Items.Add(arrCars(i))
        Next
    End Sub
    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click
        If name <> "" Then
            'path = "C:\Users\naresh_shettigar\Desktop\VB6\Inventory\" & Trim(name) & ".txt"
            path = "C:\Users\neel.shettigar\Desktop\prjInventory\InventoryFiles\" & Trim(name) & ".txt"
            FileOpen(1, path, OpenMode.Output)
            For i = 0 To count
                'PrintLine(1, lstOutput.Items.Item(i))
                PrintLine(1, arrCars(i))
            Next
            FileClose(1)
        End If
    End Sub

    Private Sub cmbModel_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbModel.SelectedIndexChanged
        If cmbModel.Text = "Audi A6" Then
            picA1.Visible = True
            picA2.Visible = False
            picA3.Visible = False
            picB1.Visible = False
            picB2.Visible = False
            picB3.Visible = False
            picM1.Visible = False
            picM2.Visible = False
            picM3.Visible = False
        ElseIf cmbModel.Text = "Audi Q7" Then
            picA1.Visible = False
            picA2.Visible = True
            picA3.Visible = False
            picB1.Visible = False
            picB2.Visible = False
            picB3.Visible = False
            picM1.Visible = False
            picM2.Visible = False
            picM3.Visible = False
        ElseIf cmbModel.Text = "Audi R8" Then
            picA1.Visible = False
            picA2.Visible = False
            picA3.Visible = True
            picB1.Visible = False
            picB2.Visible = False
            picB3.Visible = False
            picM1.Visible = False
            picM2.Visible = False
            picM3.Visible = False
        ElseIf cmbModel.Text = "BMW GT6" Then
            picA1.Visible = False
            picA2.Visible = False
            picA3.Visible = False
            picB1.Visible = True
            picB2.Visible = False
            picB3.Visible = False
            picM1.Visible = False
            picM2.Visible = False
            picM3.Visible = False
        ElseIf cmbModel.Text = "BMW X7" Then
            picA1.Visible = False
            picA2.Visible = False
            picA3.Visible = False
            picB1.Visible = False
            picB2.Visible = True
            picB3.Visible = False
            picM1.Visible = False
            picM2.Visible = False
            picM3.Visible = False
        ElseIf cmbModel.Text = "BMW I8" Then
            picA1.Visible = False
            picA2.Visible = False
            picA3.Visible = False
            picB1.Visible = False
            picB2.Visible = False
            picB3.Visible = True
            picM1.Visible = False
            picM2.Visible = False
            picM3.Visible = False
        ElseIf cmbModel.Text = "Mercedes AMG" Then
            picA1.Visible = False
            picA2.Visible = False
            picA3.Visible = False
            picB1.Visible = False
            picB2.Visible = False
            picB3.Visible = False
            picM1.Visible = True
            picM2.Visible = False
            picM3.Visible = False
        ElseIf cmbModel.Text = "Mercedes C-Class" Then
            picA1.Visible = False
            picA2.Visible = False
            picA3.Visible = False
            picB1.Visible = False
            picB2.Visible = False
            picB3.Visible = False
            picM1.Visible = False
            picM2.Visible = True
            picM3.Visible = False
        ElseIf cmbModel.Text = "Mercedes GLC" Then
            picA1.Visible = False
            picA2.Visible = False
            picA3.Visible = False
            picB1.Visible = False
            picB2.Visible = False
            picB3.Visible = False
            picM1.Visible = False
            picM2.Visible = False
            picM3.Visible = True
        End If
    End Sub

    Private Sub DecompressToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DecompressToolStripMenuItem.Click
        If Mid(VIN, 1, 2) = "18" Then
            cmbYear.Text = "2018"
        ElseIf Mid(VIN, 1, 2) = "19" Then
            cmbYear.Text = "2019"
        ElseIf Mid(VIN, 1, 2) = "20" Then
            cmbYear.Text = "2020"
        End If
        If Mid(VIN, 3, 1) = "N" Then
            cmbCondition.Text = "New"
        ElseIf Mid(VIN, 3, 1) = "F" Then
            cmbCondition.Text = "Fair"
        ElseIf Mid(VIN, 3, 1) = "P" Then
            cmbCondition.Text = "Poor"
        End If
        If Mid(VIN, 4, 2) = "A1" Then
            cmbCompany.Text = "Audi"
            cmbModel.Text = "Audi A6"
        ElseIf Mid(VIN, 4, 2) = "A2" Then
            cmbCompany.Text = "Audi"
            cmbModel.Text = "Audi Q7"
        ElseIf Mid(VIN, 4, 2) = "A3" Then
            cmbCompany.Text = "Audi"
            cmbModel.Text = "Audi R8"
        ElseIf Mid(VIN, 4, 2) = "B1" Then
            cmbCompany.Text = "BMW"
            cmbModel.Text = "BMW GT6"
        ElseIf Mid(VIN, 4, 2) = "B2" Then
            cmbCompany.Text = "BMW"
            cmbModel.Text = "BMW X7"
        ElseIf Mid(VIN, 4, 2) = "B3" Then
            cmbCompany.Text = "BMW"
            cmbModel.Text = "BMW I8"
        ElseIf Mid(VIN, 4, 2) = "M1" Then
            cmbCompany.Text = "Mercedes"
            cmbModel.Text = "Mercedes AMG"
        ElseIf Mid(VIN, 4, 2) = "M2" Then
            cmbCompany.Text = "Mercedes"
            cmbModel.Text = "Mercedes C-Class"
        ElseIf Mid(VIN, 4, 2) = "M3" Then
            cmbCompany.Text = "Mercedes"
            cmbModel.Text = "Mercedes GLC"
        End If
        If Mid(VIN, 6, 1) = "1" Then
            rbV8.Checked = True
            rbV10.Checked = False
            rbV12.Checked = False
        ElseIf Mid(VIN, 6, 1) = "2" Then
            rbV10.Checked = True
            rbV8.Checked = False
            rbV12.Checked = False
        ElseIf Mid(VIN, 6, 1) = "3" Then
            rbV12.Checked = True
            rbV10.Checked = False
            rbV8.Checked = False
        End If
        If Mid(VIN, 7, 1) = "1" Then
            rbAuto.Checked = True
            rbDual.Checked = False
            rbManual.Checked = False
        ElseIf Mid(VIN, 7, 1) = "2" Then
            rbDual.Checked = True
            rbAuto.Checked = False
            rbManual.Checked = False
        ElseIf Mid(VIN, 7, 1) = "3" Then
            rbManual.Checked = True
            rbAuto.Checked = False
            rbDual.Checked = False
        End If
        If Mid(VIN, 8, 1) = "1" Then
            rbFront.Checked = True
            rbBack.Checked = False
            rbAll.Checked = False
        ElseIf Mid(VIN, 8, 1) = "2" Then
            rbBack.Checked = True
            rbFront.Checked = False
            rbAll.Checked = False
        ElseIf Mid(VIN, 8, 1) = "3" Then
            rbAll.Checked = True
            rbBack.Checked = False
            rbFront.Checked = False
        End If
        If Mid(VIN, 9, 1) = "1" Then
            rbBlack.Checked = True
            rbWhite.Checked = False
            rbRed.Checked = False
        ElseIf Mid(VIN, 9, 1) = "2" Then
            rbRed.Checked = True
            rbBlack.Checked = False
            rbWhite.Checked = False
        ElseIf Mid(VIN, 9, 1) = "3" Then
            rbWhite.Checked = True
            rbRed.Checked = False
            rbBlack.Checked = False
        End If
        If Mid(VIN, 10, 1) = "1" Then
            cb1.Checked = True
        Else
            cb1.Checked = False
        End If
        If Mid(VIN, 11, 1) = "1" Then
            cb2.Checked = True
        Else
            cb2.Checked = False
        End If
        If Mid(VIN, 12, 1) = "1" Then
            cb3.Checked = True
        Else
            cb3.Checked = False
        End If
        If Mid(VIN, 13, 1) = "1" Then
            cb4.Checked = True
        Else
            cb4.Checked = False
        End If
        If Mid(VIN, 14, 1) = "1" Then
            cb5.Checked = True
        Else
            cb5.Checked = False
        End If
        If Mid(VIN, 15, 1) = "1" Then
            cb6.Checked = True
        Else
            cb6.Checked = False
        End If
        If Mid(VIN, 16, 1) = "1" Then
            cb7.Checked = True
        Else
            cb7.Checked = False
        End If
        If Mid(VIN, 17, 1) = "1" Then
            cb8.Checked = True
        Else
            cb8.Checked = False
        End If
        If Mid(VIN, 18, 1) = "1" Then
            cb9.Checked = True
        Else
            cb9.Checked = False
        End If
        If Mid(VIN, 19, 1) = "1" Then
            cb10.Checked = True
        Else
            cb10.Checked = False
        End If
        If Mid(VIN, 20, 1) = "1" Then
            cb11.Checked = True
        Else
            cb11.Checked = False
        End If
        If Mid(VIN, 21, 1) = "1" Then
            cb12.Checked = True
        Else
            cb12.Checked = False
        End If
    End Sub
End Class