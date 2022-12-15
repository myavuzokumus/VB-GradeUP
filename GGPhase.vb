Imports System.ComponentModel

Public Class GGPhase

    Public Grade As String = My.Settings.Grade
    Public UserName As String = My.Settings.UserName
    Dim Shutdown As Boolean = False

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Shutdown = True
        Me.Close()
        PlayPhase.Show()
    End Sub

    Private Sub GGPhase_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        If Shutdown = False Then
            Hikaye.Close()
        End If
    End Sub

    Private Sub GGPhase_Load(sender As Object, e As EventArgs) Handles Me.Load
        If Grade = "F" Then
            Result.Text = "Daha çok çalışmalısın " & vbCrLf & UserName & "..." & vbCrLf & "Sonuç"
            GradeImg.Image = My.Resources.FGrade
            Me.BackColor = Color.FromArgb(255, 150, 100)
            Result.BackColor = Color.FromArgb(255, 150, 100)
        ElseIf Grade = "D-" Then
            Result.Text = "Daha çok çalışmalısın " & vbCrLf & UserName & "..." & vbCrLf & "Sonuç"
            GradeImg.Image = My.Resources.DNegativeGrade
            Me.BackColor = Color.FromArgb(255, 200, 100)
            'Result.BackColor = Color.FromArgb(255, 200, 100)
        ElseIf Grade = "D" Then
            Result.Text = "Daha çok çalışmalısın " & vbCrLf & UserName & "..." & vbCrLf & "Sonuç"
            GradeImg.Image = My.Resources.DGrade
            Me.BackColor = Color.FromArgb(255, 255, 100)
            Result.BackColor = Color.FromArgb(255, 255, 100)
        ElseIf Grade = "D+" Then
            Result.Text = "Daha çok çalışmalısın " & vbCrLf & UserName & "..." & vbCrLf & "Sonuç"
            GradeImg.Image = My.Resources.DPlusGrade
            Me.BackColor = Color.FromArgb(255, 100, 150)
            Result.BackColor = Color.FromArgb(255, 100, 150)
        ElseIf Grade = "C-" Then
            Result.Text = "Daha çok çalışmalısın " & vbCrLf & UserName & "..." & vbCrLf & "Sonuç"
            GradeImg.Image = My.Resources.CNegativeGrade
            Me.BackColor = Color.FromArgb(255, 100, 200)
            Result.BackColor = Color.FromArgb(255, 100, 200)
        ElseIf Grade = "C" Then
            Result.Text = "Hiç yoktan iyidir, değil mi" & vbCrLf & UserName & "?" & vbCrLf & "Sonuç"
            GradeImg.Image = My.Resources.CPlusGrade
            Me.BackColor = Color.FromArgb(255, 100, 255)
            Result.BackColor = Color.FromArgb(255, 100, 255)
        ElseIf Grade = "C+" Then
            Result.Text = "Hiç yoktan iyidir, değil mi" & vbCrLf & UserName & "?" & vbCrLf & "Sonuç"
            GradeImg.Image = My.Resources.CPlusGrade
            Me.BackColor = Color.FromArgb(255, 150, 150)
            Result.BackColor = Color.FromArgb(255, 150, 150)
        ElseIf Grade = "B-" Then
            Result.Text = "Hiç yoktan iyidir, değil mi" & vbCrLf & UserName & "?" & vbCrLf & "Sonuç"
            GradeImg.Image = My.Resources.BNegativeGrade
            Me.BackColor = Color.FromArgb(255, 200, 150)
            Result.BackColor = Color.FromArgb(255, 200, 150)
        ElseIf Grade = "B" Then
            Result.Text = "Vaow tebrikler" & UserName & vbCrLf & ", fena değil." & vbCrLf & "Sonuç"
            GradeImg.Image = My.Resources.BGrade
            Me.BackColor = Color.FromArgb(255, 255, 150)
            Result.BackColor = Color.FromArgb(255, 255, 150)
        ElseIf Grade = "B+" Then
            Result.Text = "Vaow tebrikler" & UserName & vbCrLf & ", fena değil." & vbCrLf & "Sonuç"
            GradeImg.Image = My.Resources.BPlusGrade
            Me.BackColor = Color.FromArgb(255, 150, 200)
            Result.BackColor = Color.FromArgb(255, 150, 200)
        ElseIf Grade = "A-" Then
            Result.Text = UserName & "nesin ya böyle?!" & vbCrLf & "Sonuç"
            GradeImg.Image = My.Resources.ANegativeGrade
            Me.BackColor = Color.FromArgb(255, 150, 255)
            Result.BackColor = Color.FromArgb(255, 150, 255)
            GameOverIMG.Image = My.Resources.mezuniyet
        ElseIf Grade = "A" Then
            Result.Text = "İşte aradığımız kişi" & UserName & vbCrLf & "Tebrikler!" & vbCrLf & "Sonuç"
            GradeImg.Image = My.Resources.AGrade
            Me.BackColor = Color.FromArgb(255, 255, 255)
            Result.BackColor = Color.FromArgb(255, 255, 255)
            GameOverIMG.Image = My.Resources.mezuniyet
        End If
    End Sub


End Class