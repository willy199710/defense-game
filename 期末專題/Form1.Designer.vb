<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form 覆寫 Dispose 以清除元件清單。
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

    '為 Windows Form 設計工具的必要項
    Private components As System.ComponentModel.IContainer

    '注意: 以下為 Windows Form 設計工具所需的程序
    '可以使用 Windows Form 設計工具進行修改。
    '請勿使用程式碼編輯器進行修改。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Play = New System.Windows.Forms.Button()
        Me.Bye = New System.Windows.Forms.Button()
        Me.Rank = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("標楷體", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label1.Location = New System.Drawing.Point(62, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(334, 33)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "2 D 火 柴 人 守 城"
        '
        'Play
        '
        Me.Play.Font = New System.Drawing.Font("標楷體", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Play.Location = New System.Drawing.Point(164, 89)
        Me.Play.Name = "Play"
        Me.Play.Size = New System.Drawing.Size(130, 48)
        Me.Play.TabIndex = 2
        Me.Play.Text = "開始"
        Me.Play.UseVisualStyleBackColor = True
        '
        'Bye
        '
        Me.Bye.Font = New System.Drawing.Font("標楷體", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Bye.Location = New System.Drawing.Point(12, 89)
        Me.Bye.Name = "Bye"
        Me.Bye.Size = New System.Drawing.Size(130, 48)
        Me.Bye.TabIndex = 3
        Me.Bye.Text = "離開"
        Me.Bye.UseVisualStyleBackColor = True
        '
        'Rank
        '
        Me.Rank.Font = New System.Drawing.Font("標楷體", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Rank.Location = New System.Drawing.Point(314, 89)
        Me.Rank.Name = "Rank"
        Me.Rank.Size = New System.Drawing.Size(130, 48)
        Me.Rank.TabIndex = 4
        Me.Rank.Text = "排行榜"
        Me.Rank.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoValidate = System.Windows.Forms.AutoValidate.Disable
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(457, 359)
        Me.Controls.Add(Me.Rank)
        Me.Controls.Add(Me.Bye)
        Me.Controls.Add(Me.Play)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.Text = "2D 火柴人守城"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Play As Button
    Friend WithEvents Bye As Button
    Friend WithEvents Rank As Button
End Class
