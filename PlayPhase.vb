Imports System.ComponentModel
Imports System.Reflection.Emit
Imports System.Runtime.Intrinsics.X86
Imports System.Security.Authentication.ExtendedProtection
Imports System.Security.Cryptography.X509Certificates
Imports System.Threading
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar
Imports Microsoft.VisualBasic.Logging

Public Class PlayPhase

    Dim GradeList As New List(Of String)({"F", "D-", "D", "D+", "C-", "C", "C+", "B-", "B", "B+", "A-", "A"})
    Dim GradePoint As Double = 1
    Dim Health As Integer = 3
    Dim Grade As String = GradeList(0)
    Dim Shutdown As Boolean = False
    Dim MusicVL As Boolean = My.Settings.MusicVL

    Private Sub MainFormG_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown

        If NeedPress = "Left" Or NeedPress = "Right" Or NeedPress = "Up" Or NeedPress = "Down" Then
            Select Case e.KeyValue
                Case 37
                    CheckArrow("Left")
                Case 38
                    CheckArrow("Up")
                Case 39
                    CheckArrow("Right")
                Case 40
                    CheckArrow("Down")
            End Select

            If NeedPress = "Completed" Then
                If UP_ProgressBar.Value <> UP_ProgressBar.Maximum Then
                    UP_ProgressBar.Value += 10
                End If
                If UP_ProgressBar.Value = UP_ProgressBar.Maximum Then
                    If Grade <> "A" Then
                        GradeImage()
                        UP_ProgressBar.Value = 0
                    Else
                        GameOver()
                    End If
                End If
            End If
        End If
    End Sub

    Function CheckArrow(button As String)
        If NeedPress = button Then
            Arrow_Right.ForeColor = Color.FromArgb(0, 0, 0)
            Arrow_UP.ForeColor = Color.FromArgb(0, 0, 0)
            Arrow_Down.ForeColor = Color.FromArgb(0, 0, 0)
            Arrow_Left.ForeColor = Color.FromArgb(0, 0, 0)
            Pencil.Image = My.Resources.anipencil
            NeedPress = "Completed"
        Else
            RemoveHealth()
        End If


    End Function

    Function RemoveHealth()
        Arrow_Right.ForeColor = Color.FromArgb(255, 0, 0)
        Arrow_UP.ForeColor = Color.FromArgb(255, 0, 0)
        Arrow_Down.ForeColor = Color.FromArgb(255, 0, 0)
        Arrow_Left.ForeColor = Color.FromArgb(255, 0, 0)
        NeedPress = "Wrong"
        Health -= 1
        Select Case Health
            Case 2
                Kalp3.Visible = False
            Case 1
                Kalp2.Visible = False
            Case 0
                GameOver()
        End Select
    End Function

    Dim timer As Integer = 0
    Function GameOver()
        Shutdown = True
        Me.Close()
        GGPhase.Show()
    End Function

    Dim NeedPress As String


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles GameTimer.Tick

        timer += GradePoint

        If timer > 35 Then

            timer = 0
            If NeedPress = "Left" Or NeedPress = "Right" Or NeedPress = "Up" Or NeedPress = "Down" Then
                RemoveHealth()
            Else
                Pencil.Image = My.Resources.nonpencil
                Arrow_Right.ForeColor = Color.FromArgb(0, 0, 0)
                Arrow_UP.ForeColor = Color.FromArgb(0, 0, 0)
                Arrow_Down.ForeColor = Color.FromArgb(0, 0, 0)
                Arrow_Left.ForeColor = Color.FromArgb(0, 0, 0)
                Dim random As Integer = CInt((Rnd() * 3))
                Select Case random
                    Case 0
                        NeedPress = "Left"
                        Arrow_Left.ForeColor = Color.FromArgb(0, 255, 0)
                    Case 1
                        NeedPress = "Right"
                        Arrow_Right.ForeColor = Color.FromArgb(0, 255, 0)
                    Case 2
                        NeedPress = "Down"
                        Arrow_Down.ForeColor = Color.FromArgb(0, 255, 0)
                    Case 3
                        NeedPress = "Up"
                        Arrow_UP.ForeColor = Color.FromArgb(0, 255, 0)

                End Select
            End If
        End If

    End Sub

    Function GradeImage()
        GradePoint += 1
        If Grade = "F" Then
            GradeImg.Image = My.Resources.DNegativeGrade
            Me.BackColor = Color.FromArgb(255, 150, 100)
            Grade = GradeList(1)
        ElseIf Grade = "D-" Then
            GradeImg.Image = My.Resources.DGrade
            Me.BackColor = Color.FromArgb(255, 200, 100)
            Grade = GradeList(2)
        ElseIf Grade = "D" Then
            GradeImg.Image = My.Resources.DPlusGrade
            Me.BackColor = Color.FromArgb(255, 255, 100)
            Grade = GradeList(3)
        ElseIf Grade = "D+" Then
            GradeImg.Image = My.Resources.CNegativeGrade
            Me.BackColor = Color.FromArgb(255, 100, 150)
            Grade = GradeList(4)
        ElseIf Grade = "C-" Then
            GradeImg.Image = My.Resources.CGrade
            Me.BackColor = Color.FromArgb(255, 100, 200)
            Grade = GradeList(5)
        ElseIf Grade = "C" Then
            GradeImg.Image = My.Resources.CPlusGrade
            Me.BackColor = Color.FromArgb(255, 100, 255)
            Grade = GradeList(6)
        ElseIf Grade = "C+" Then
            GradeImg.Image = My.Resources.BNegativeGrade
            Me.BackColor = Color.FromArgb(255, 150, 150)
            Grade = GradeList(7)
        ElseIf Grade = "B-" Then
            GradeImg.Image = My.Resources.BGrade
            Me.BackColor = Color.FromArgb(255, 200, 150)
            Grade = GradeList(8)
        ElseIf Grade = "B" Then
            GradeImg.Image = My.Resources.BPlusGrade
            Me.BackColor = Color.FromArgb(255, 255, 150)
            Grade = GradeList(9)
        ElseIf Grade = "B+" Then
            GradeImg.Image = My.Resources.ANegativeGrade
            Me.BackColor = Color.FromArgb(255, 150, 200)
            Grade = GradeList(10)
        ElseIf Grade = "A-" Then
            GradeImg.Image = My.Resources.AGrade
            Me.BackColor = Color.FromArgb(255, 150, 255)
            Grade = GradeList(11)
        End If
    End Function

    Private Sub MainFormG_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        My.Settings.Grade = Grade
        My.Settings.MusicVL = MusicVL
        If Shutdown = False Then
            Hikaye.Close()
        End If
    End Sub
    Private Sub PlayPhase_Load(sender As Object, e As EventArgs) Handles Me.Load
        If MusicVL = False Then
            VolumeImg.Image = My.Resources.soundoff
        End If
    End Sub

    Private Sub NameBox_KeyDown(sender As Object, e As KeyEventArgs) Handles NameBox.KeyDown
        If e.KeyCode = Keys.Enter Then
            If NameBox.Text.Trim.Length > 0 Then
                My.Settings.UserName = NameBox.Text
                Arrow_Right.Visible = True
                Arrow_UP.Visible = True
                Arrow_Down.Visible = True
                Arrow_Left.Visible = True
                NameBox.Visible = False
                NameBox.Enabled = False
                GameTimer.Start()
            Else
                MsgBox("Lütfen isminizi giriniz.")
            End If
        End If
    End Sub
    Private Sub VolumeImg_Click(sender As Object, e As EventArgs) Handles VolumeImg.Click
        If MusicVL = True Then
            MusicVL = False
            My.Computer.Audio.Play(My.Resources.ClickSound, AudioPlayMode.Background)
            VolumeImg.Image = My.Resources.soundoff
        Else
            MusicVL = True
            My.Computer.Audio.Play(My.Resources.Endless, AudioPlayMode.BackgroundLoop)
            VolumeImg.Image = My.Resources.soundon
        End If
    End Sub

End Class
