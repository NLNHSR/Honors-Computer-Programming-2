Public Class frmPong
    Dim BSX As Integer
    Dim BSY As Integer
    Private Sub FrmPong_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BSX = 1
        BSY = 1
    End Sub

    Private Sub frmPong_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove
        Dim x As Integer = e.X
    End Sub
End Class
