<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form4
    Inherits System.Windows.Forms.Form

    'Form 覆寫 Dispose 以清除元件清單。
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

    '為 Windows Form 設計工具的必要項
    Private components As System.ComponentModel.IContainer

    '注意: 以下為 Windows Form 設計工具所需的程序
    '可以使用 Windows Form 設計工具進行修改。
    '請勿使用程式碼編輯器進行修改。
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form4))
        Me.ButtonS = New System.Windows.Forms.Label()
        Me.bullet1 = New System.Windows.Forms.PictureBox()
        Me.shooter1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.bulletfly = New System.Windows.Forms.Timer(Me.components)
        Me.enemy1 = New System.Windows.Forms.PictureBox()
        CType(Me.bullet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.shooter1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.enemy1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtonS
        '
        Me.ButtonS.AutoSize = True
        Me.ButtonS.BackColor = System.Drawing.Color.Coral
        Me.ButtonS.Font = New System.Drawing.Font("標楷體", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.ButtonS.Location = New System.Drawing.Point(31, 351)
        Me.ButtonS.Name = "ButtonS"
        Me.ButtonS.Size = New System.Drawing.Size(33, 34)
        Me.ButtonS.TabIndex = 62
        Me.ButtonS.Tag = "0"
        Me.ButtonS.Text = "S"
        '
        'bullet1
        '
        Me.bullet1.BackColor = System.Drawing.Color.Transparent
        Me.bullet1.Image = Global.期末專題.My.Resources.Resources.bullet
        Me.bullet1.Location = New System.Drawing.Point(80, 400)
        Me.bullet1.Name = "bullet1"
        Me.bullet1.Size = New System.Drawing.Size(30, 11)
        Me.bullet1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.bullet1.TabIndex = 53
        Me.bullet1.TabStop = False
        Me.bullet1.Visible = False
        '
        'shooter1
        '
        Me.shooter1.BackColor = System.Drawing.Color.Transparent
        Me.shooter1.Image = CType(resources.GetObject("shooter1.Image"), System.Drawing.Image)
        Me.shooter1.Location = New System.Drawing.Point(23, 388)
        Me.shooter1.Name = "shooter1"
        Me.shooter1.Size = New System.Drawing.Size(51, 53)
        Me.shooter1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.shooter1.TabIndex = 52
        Me.shooter1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("新細明體", 15.0!)
        Me.Label1.Location = New System.Drawing.Point(7, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(770, 200)
        Me.Label1.TabIndex = 63
        Me.Label1.Text = "使用鍵盤上的S、D、F、J、K、L鍵控制子彈射擊以防止怪獸攻打城堡" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "各種怪獸介紹" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "● 翼龍：生命值為3，且每打中一次即換行" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "● 暴龍：生命值為5" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "● " &
    "蘑菇：生命值為2" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "若怪獸攻入城堡，即遊戲結束。" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("新細明體", 19.0!)
        Me.Label2.Location = New System.Drawing.Point(17, 261)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(746, 32)
        Me.Label2.TabIndex = 64
        Me.Label2.Text = "了解遊戲規則後，就按鍵盤S射擊翼龍，開始遊戲吧!"
        '
        'bulletfly
        '
        Me.bulletfly.Interval = 50
        '
        'enemy1
        '
        Me.enemy1.BackColor = System.Drawing.Color.Transparent
        Me.enemy1.Image = Global.期末專題.My.Resources.Resources.恐龍_1
        Me.enemy1.Location = New System.Drawing.Point(754, 384)
        Me.enemy1.Name = "enemy1"
        Me.enemy1.Size = New System.Drawing.Size(60, 63)
        Me.enemy1.TabIndex = 65
        Me.enemy1.TabStop = False
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(853, 487)
        Me.Controls.Add(Me.enemy1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ButtonS)
        Me.Controls.Add(Me.bullet1)
        Me.Controls.Add(Me.shooter1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form4"
        Me.Text = "新手教學"
        CType(Me.bullet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.shooter1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.enemy1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ButtonS As Label
    Friend WithEvents bullet1 As PictureBox
    Friend WithEvents shooter1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents bulletfly As Timer
    Friend WithEvents enemy1 As PictureBox
End Class
