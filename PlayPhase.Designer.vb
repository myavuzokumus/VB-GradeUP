<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PlayPhase
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PlayPhase))
        Me.Pencil = New FinalProje_GradeUP.TransparentPictureBox()
        Me.GradeUP_Title = New System.Windows.Forms.Label()
        Me.UP_ProgressBar = New System.Windows.Forms.ProgressBar()
        Me.GradePaperIcon = New System.Windows.Forms.PictureBox()
        Me.GradeImg = New FinalProje_GradeUP.TransparentPictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Arrow_Right = New System.Windows.Forms.Label()
        Me.Arrow_UP = New System.Windows.Forms.Label()
        Me.Arrow_Down = New System.Windows.Forms.Label()
        Me.Arrow_Left = New System.Windows.Forms.Label()
        Me.GameTimer = New System.Windows.Forms.Timer(Me.components)
        Me.Kalp1 = New FinalProje_GradeUP.TransparentPictureBox()
        Me.Kalp2 = New FinalProje_GradeUP.TransparentPictureBox()
        Me.Kalp3 = New FinalProje_GradeUP.TransparentPictureBox()
        Me.NameBox = New System.Windows.Forms.TextBox()
        Me.VolumeImg = New FinalProje_GradeUP.TransparentPictureBox()
        CType(Me.Pencil, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GradePaperIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GradeImg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Kalp1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Kalp2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Kalp3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VolumeImg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Pencil
        '
        Me.Pencil.BackColor = System.Drawing.Color.Transparent
        resources.ApplyResources(Me.Pencil, "Pencil")
        Me.Pencil.Name = "Pencil"
        Me.Pencil.TabStop = False
        '
        'GradeUP_Title
        '
        resources.ApplyResources(Me.GradeUP_Title, "GradeUP_Title")
        Me.GradeUP_Title.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.GradeUP_Title.Name = "GradeUP_Title"
        '
        'UP_ProgressBar
        '
        resources.ApplyResources(Me.UP_ProgressBar, "UP_ProgressBar")
        Me.UP_ProgressBar.Name = "UP_ProgressBar"
        Me.UP_ProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        '
        'GradePaperIcon
        '
        Me.GradePaperIcon.BackColor = System.Drawing.Color.Transparent
        Me.GradePaperIcon.BackgroundImage = Global.FinalProje_GradeUP.My.Resources.Resources.papers
        resources.ApplyResources(Me.GradePaperIcon, "GradePaperIcon")
        Me.GradePaperIcon.Name = "GradePaperIcon"
        Me.GradePaperIcon.TabStop = False
        '
        'GradeImg
        '
        Me.GradeImg.BackColor = System.Drawing.Color.Transparent
        resources.ApplyResources(Me.GradeImg, "GradeImg")
        Me.GradeImg.Name = "GradeImg"
        Me.GradeImg.TabStop = False
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.Name = "Label1"
        '
        'Arrow_Right
        '
        resources.ApplyResources(Me.Arrow_Right, "Arrow_Right")
        Me.Arrow_Right.Name = "Arrow_Right"
        '
        'Arrow_UP
        '
        resources.ApplyResources(Me.Arrow_UP, "Arrow_UP")
        Me.Arrow_UP.Name = "Arrow_UP"
        '
        'Arrow_Down
        '
        resources.ApplyResources(Me.Arrow_Down, "Arrow_Down")
        Me.Arrow_Down.Name = "Arrow_Down"
        '
        'Arrow_Left
        '
        resources.ApplyResources(Me.Arrow_Left, "Arrow_Left")
        Me.Arrow_Left.Name = "Arrow_Left"
        '
        'GameTimer
        '
        '
        'Kalp1
        '
        resources.ApplyResources(Me.Kalp1, "Kalp1")
        Me.Kalp1.Name = "Kalp1"
        Me.Kalp1.TabStop = False
        '
        'Kalp2
        '
        resources.ApplyResources(Me.Kalp2, "Kalp2")
        Me.Kalp2.Name = "Kalp2"
        Me.Kalp2.TabStop = False
        '
        'Kalp3
        '
        resources.ApplyResources(Me.Kalp3, "Kalp3")
        Me.Kalp3.Name = "Kalp3"
        Me.Kalp3.TabStop = False
        '
        'NameBox
        '
        resources.ApplyResources(Me.NameBox, "NameBox")
        Me.NameBox.Name = "NameBox"
        '
        'VolumeImg
        '
        resources.ApplyResources(Me.VolumeImg, "VolumeImg")
        Me.VolumeImg.Name = "VolumeImg"
        Me.VolumeImg.TabStop = False
        '
        'PlayPhase
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoValidate = System.Windows.Forms.AutoValidate.Disable
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.Controls.Add(Me.VolumeImg)
        Me.Controls.Add(Me.NameBox)
        Me.Controls.Add(Me.Kalp3)
        Me.Controls.Add(Me.Kalp2)
        Me.Controls.Add(Me.Kalp1)
        Me.Controls.Add(Me.Arrow_Left)
        Me.Controls.Add(Me.Arrow_Down)
        Me.Controls.Add(Me.Arrow_UP)
        Me.Controls.Add(Me.Arrow_Right)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Pencil)
        Me.Controls.Add(Me.GradeImg)
        Me.Controls.Add(Me.UP_ProgressBar)
        Me.Controls.Add(Me.GradeUP_Title)
        Me.Controls.Add(Me.GradePaperIcon)
        Me.MaximizeBox = False
        Me.Name = "PlayPhase"
        CType(Me.Pencil, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GradePaperIcon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GradeImg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Kalp1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Kalp2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Kalp3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VolumeImg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GradeUP_Title As Label
    Friend WithEvents UP_ProgressBar As ProgressBar
    Friend WithEvents GradePaperIcon As PictureBox
    Friend WithEvents Pencil As TransparentPictureBox
    Friend WithEvents GradeImg As TransparentPictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Arrow_Right As Label
    Friend WithEvents Arrow_UP As Label
    Friend WithEvents Arrow_Down As Label
    Friend WithEvents Arrow_Left As Label
    Friend WithEvents GameTimer As Timer
    Friend WithEvents Kalp1 As TransparentPictureBox
    Friend WithEvents Kalp2 As TransparentPictureBox
    Friend WithEvents Kalp3 As TransparentPictureBox
    Friend WithEvents NameBox As TextBox
    Friend WithEvents VolumeImg As TransparentPictureBox
End Class
