Imports System.Reflection.Emit
Imports System.Threading

Public Class Hikaye

    Dim Phase As Integer = 0
    Private Sub Hikaye_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        My.Computer.Audio.Play(My.Resources.Endless, AudioPlayMode.BackgroundLoop)
    End Sub

    Private Sub Hikaye_Click(sender As Object, e As EventArgs) Handles Me.Click
        If Phase = 0 Then
            Me.BackgroundImage = My.Resources.angryteacher
            Label1.Text = "Hocası bunu her gördüğünde" + vbCrLf + "çok sinirlenirmiş."
        ElseIf Phase = 1 Then
            Me.BackgroundImage = My.Resources.fgradepaper
            Label1.Text = "Ve artık her dersten F almaya başlamış..."
        ElseIf Phase = 2 Then
            Me.BackgroundImage = My.Resources.aloneatschool
            Label1.Text = "Bunu düzeltmeliydi" + vbCrLf + "yoksa okulu hiç bitiremeyecekti!"
        ElseIf Phase = 3 Then
            Me.Hide()
            PlayPhase.Show()
        End If
        Phase += 1
    End Sub
End Class