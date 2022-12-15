<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GGPhase
    Inherits System.Windows.Forms.Form

    'Form, bileşen listesini temizlemeyi bırakmayı geçersiz kılar.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows Form Tasarımcısı tarafından gerektirilir
    Private components As System.ComponentModel.IContainer

    'NOT: Aşağıdaki yordam Windows Form Tasarımcısı için gereklidir
    'Windows Form Tasarımcısı kullanılarak değiştirilebilir.  
    'Kod düzenleyicisini kullanarak değiştirmeyin.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GGPhase))
        Me.GameOverIMG = New FinalProje_GradeUP.TransparentPictureBox()
        Me.GradeImg = New FinalProje_GradeUP.TransparentPictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Result = New System.Windows.Forms.Label()
        CType(Me.GameOverIMG, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GradeImg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GameOverIMG
        '
        Me.GameOverIMG.Image = CType(resources.GetObject("GameOverIMG.Image"), System.Drawing.Image)
        Me.GameOverIMG.Location = New System.Drawing.Point(334, 60)
        Me.GameOverIMG.Name = "GameOverIMG"
        Me.GameOverIMG.Size = New System.Drawing.Size(420, 331)
        Me.GameOverIMG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.GameOverIMG.TabIndex = 0
        Me.GameOverIMG.TabStop = False
        '
        'GradeImg
        '
        Me.GradeImg.Location = New System.Drawing.Point(127, 173)
        Me.GradeImg.Name = "GradeImg"
        Me.GradeImg.Size = New System.Drawing.Size(110, 105)
        Me.GradeImg.TabIndex = 2
        Me.GradeImg.TabStop = False
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Montserrat ExtraBold", 18.33962!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.Button1.Location = New System.Drawing.Point(61, 312)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(237, 51)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Tekrar oyna!"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Result
        '
        Me.Result.AutoSize = True
        Me.Result.BackColor = System.Drawing.Color.Transparent
        Me.Result.Font = New System.Drawing.Font("Montserrat Black", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Result.Location = New System.Drawing.Point(29, 60)
        Me.Result.Name = "Result"
        Me.Result.Size = New System.Drawing.Size(96, 33)
        Me.Result.TabIndex = 5
        Me.Result.Text = "Label1"
        Me.Result.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Result.UseMnemonic = False
        '
        'GGPhase
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Result)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GradeImg)
        Me.Controls.Add(Me.GameOverIMG)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "GGPhase"
        Me.Text = "GGPhase"
        CType(Me.GameOverIMG, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GradeImg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GameOverIMG As TransparentPictureBox
    Friend WithEvents GradeImg As TransparentPictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Result As Label
End Class
